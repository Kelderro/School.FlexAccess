using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using GrFingerXLib;

namespace FlexAccess.FingerReader
{
  class DBFingerPrint
  {
    private FlexAccess.FlexAccessDataSetTableAdapters.module_fingerprintTableAdapter fingerPrintAdapter;

    public DBFingerPrint()
    {
      this.fingerPrintAdapter = new FlexAccessDataSetTableAdapters.module_fingerprintTableAdapter();
    }

    /** Template toevoegen aan de database. */
    public bool saveTemplate(byte[] template, Person.Person person, int flcID)
    {
      try
      {
        fingerPrintAdapter.Insert(person.PersonID, flcID, template);
      }
      catch {
        /**
         * Er kan een fout optreden bij de insert door een duplicate key
         * Hiervoor is gekozen voor als er een fout ontstaat dat er een update wordt uitgevoerd
         */
        try
        {
          fingerPrintAdapter.Update(person.PersonID, flcID, template, person.PersonID, flcID);
        } catch (System.Data.SqlClient.SqlException ex) {
          MessageBox.Show(ex.Message);
        }
      }

      return true;
    }

    // Data ophalen met fingerPrints
    public FlexAccessDataSet.module_fingerprintDataTable getTemplates()
    {
      FlexAccessDataSet.module_fingerprintDataTable fingerPrintData = fingerPrintAdapter.GetData();
      return fingerPrintData;
    }

    public Boolean deleteTemplate(Person.Person person, int flcID)
    {
      this.fingerPrintAdapter = new FlexAccess.FlexAccessDataSetTableAdapters.module_fingerprintTableAdapter();
      try
      {
        fingerPrintAdapter.Delete(person.PersonID, flcID);
        return true;
      }
      catch
      {
        return false;
      }
    }

    public FlexAccessDataSet.module_fingerprintDataTable getUnknownFingers(Person.Person person)
    {
      FlexAccessDataSet.module_fingerprintDataTable fingerPrintData = fingerPrintAdapter.GetData();
      return fingerPrintData;
    }
  }
}
