using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FlexAccess.Connection
{
    class Receive
    {
        private const int HEADER_TABLE = 0;
        private const int DATA_TABLE = 1;
        private const int MESSAGETYPE = 0;

        public static void ProcessData(DataSet ProcessData)
        {
            //Console.WriteLine(ProcessData.GetXml());
            //Console.WriteLine(ProcessData.Tables[HEADER_TABLE].Rows[0].ItemArray[MESSAGETYPE].ToString());
            switch (ProcessData.Tables[HEADER_TABLE].Rows[0].ItemArray[MESSAGETYPE].ToString())
            {
                case "ConfirmRegister":
                    ConfirmRegister(ProcessData);
                    FlexAccess.Program.frmMain.lblStatus.Text = "Verbonden met server";

                    break;
                case "invalidIP":
                    FlexAccess.Program.frmMain.lblStatus.Text = "Ongeldig ip";

                    break;
                case "Response":
                    FlexAccess.Program.frmMain.lblStatus.Text = ProcessData.Tables[DATA_TABLE].Rows[0].ItemArray[0].ToString();
                    break;
                default:
                    Console.WriteLine("@@@@ Er is een onbekend procol ontvangen (" + ProcessData.Tables[HEADER_TABLE].Rows[0].ItemArray[MESSAGETYPE].ToString() + ") @@@@@");
                    break;
            }
        }

        private static void ConfirmRegister(DataSet ds)
        {
            FlexAccess.Program.frmMain.lblStatus.Text = "Verbonden";
            Console.WriteLine("@@@@ ConfirmRegister @@@@@");
        }
    }
}
