using GrFingerXLib;
using System;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;

namespace FlexAccess.FingerReader
{
    // Raw image data type.
    public struct TRawImage
    {
        // Image data.
        public object img;
        // Image width.
        public int width;
        // Image height.
        public int height;
        // Image resolution.
        public int Res;
    };

    // the template class
    [Serializable]
    public class TTemplate
    {
        // Template data.
        public System.Array _tpt;
        // Template size
        public int _size;

        public TTemplate()
        {
            // Create a byte buffer for the template
            _tpt = new byte[(int)GRConstants.GR_MAX_SIZE_TEMPLATE];
            _size = 0;
        }
    }

    class FingerPrint
    {

        public const int ERR_INVALID_TEMPLATE = -997;

        // Persoon
        public Person _person;
        // Vinger locatie

        // Database class.
        public FingerReader.DBFingerPrint _DB;
        // The last acquired image.
        public TRawImage _raw;
        // Reference to main form Image.
        public PictureBox _pbFingerPrint;
        // Reference to main form Treeview.
        private TreeView _trvFingers;
        // The template extracted from last acquired image.
        private TTemplate _tpt;

        //Importing necessary HDC functions
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr ptr);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);
        // GrFingerX component
        AxGrFingerXLib.AxGrFingerXCtrl _grfingerx;

        public FingerPrint(PictureBox pbPic)
        {
            _pbFingerPrint = pbPic;
            _DB = new FingerReader.DBFingerPrint();
            _tpt = null;
        }

        // Initializeren GrFinger ActiveX en alle benodigde tools.
        public void InitializeGrFinger(AxGrFingerXLib.AxGrFingerXCtrl grfingerx)
        {
            _grfingerx = grfingerx;
            _grfingerx.Initialize();
            _grfingerx.CapInitialize();
            if (_tpt == null)
                _tpt = new TTemplate();
            _raw = new TRawImage();
        }

        // Extract a fingerprint template from current image
        public Boolean ExtractTemplate()
        {
            int result;

            // set current buffer size for the extract template
            _tpt._size = (int)GRConstants.GR_MAX_SIZE_TEMPLATE;
            result = (int)_grfingerx.Extract(
              ref _raw.img, _raw.width, _raw.height, _raw.Res,
              ref _tpt._tpt, ref _tpt._size,
              (int)GRConstants.GR_DEFAULT_CONTEXT);
            // if error, set template size to 0
            if (result < 0)
            {
                // Result < 0 => extraction problem
                _tpt._size = 0;
            }

            // write template quality to the log
            if ((GRConstants)result == GRConstants.GR_BAD_QUALITY)
            {
                //WriteLog("Template extracted successfully. Slechte kwaliteit.");
            }
            else if ((GRConstants)result == GRConstants.GR_MEDIUM_QUALITY)
            {
                //WriteLog("Template extracted successfully. Middelmatige kwaliteit.");
            }
            else if ((GRConstants)result == GRConstants.GR_HIGH_QUALITY)
            {
                //WriteLog("Template extracted successfully. Hoge kwaliteit.");
            }

            return (result >= 0);
        }

        // Check if we have a valid template
        public bool TemplateIsValid()
        {
            // Check the template size and data
            return ((_tpt._size > 0) && (_tpt._tpt != null));
        }

        // Vingerafdruk op scherm weergeven
        public void PrintBiometricDisplay(bool isBiometric, GrFingerXLib.GRConstants contextId)
        {
            // handle to finger image
            System.Drawing.Image handle = null;
            // screen HDC
            IntPtr hdc = GetDC(System.IntPtr.Zero);

            if (isBiometric)
            {
                // get image with biometric info
                _grfingerx.BiometricDisplay(ref _tpt._tpt,
                  ref _raw.img, _raw.width, _raw.height, _raw.Res, hdc.ToInt32(),
                  ref handle, (int)contextId);
            }
            else
            {
                // get raw image
                _grfingerx.CapRawImageToHandle(ref _raw.img, _raw.width,
                _raw.height, hdc.ToInt32(), ref handle);
            }

            handle = (Image)ResizeBitmap((Bitmap)handle, _pbFingerPrint.Width, _pbFingerPrint.Height);

            // draw image on picture box
            if (handle != null)
            {
                _pbFingerPrint.Image = handle;
                _pbFingerPrint.Update();
            }

            // release screen HDC
            ReleaseDC(System.IntPtr.Zero, hdc);
        }

        public Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }

        // Identify current fingerprint on our database
        public Person Identify(ref int score)
        {
            GRConstants result;
            FlexAccessDataSet.module_fingerprintDataTable fingerPrintData;
            TTemplate tptRef;

            // Checking if template is valid.
            if (!TemplateIsValid()) return null;
            // Starting identification process and supplying query template.
            result = (GRConstants)_grfingerx.IdentifyPrepare(ref _tpt._tpt, (int)GRConstants.GR_DEFAULT_CONTEXT);
            // error?
            if (result < 0) return null;
            // Getting enrolled templates from database.

            fingerPrintData = _DB.getTemplates();

            /** Data uitlezen */
            foreach (FlexAccessDataSet.module_fingerprintRow fingerPrintRow in fingerPrintData)
            {
                /** Template ophalen uit de database en omzetten naar het juiste formaat */
                tptRef = (TTemplate)DeserializeObject((byte[])fingerPrintRow.mfp_data);

                /** Vergelijken met huidige template */
                result = (GRConstants)_grfingerx.Identify(ref tptRef._tpt, ref score, (int)GRConstants.GR_DEFAULT_CONTEXT);

                /** Kopie maken van de weergegeven template */
                TTemplate copyTpt = _tpt;
                /** Template uit database als huidige template instellen */
                _tpt = tptRef;
                /** Overeenkomst in template op scherm weergeven */
                PrintBiometricDisplay(true, GRConstants.GR_DEFAULT_CONTEXT);
                /** Kopie terugzetten van weergegeven template */
                _tpt = copyTpt;

                /** Controle of ze met elkaar overeen komen */
                if (result == GRConstants.GR_MATCH)
                {
                    /** Persoon ID terugsturen */
                    try
                    {
                        Person personFinger = new Person();
                        personFinger.PersonID = fingerPrintRow.prs_id;
                        return personFinger;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    return null;
                }
            }
            /** Geen template gevonden */
            return null;
        }

        private byte[] SerializeObject(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return memoryStream.ToArray();
        }

        private object DeserializeObject(byte[] buffer)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            memoryStream.Write(buffer, 0, buffer.Length);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return binaryFormatter.Deserialize(memoryStream);
        }
    }
}
