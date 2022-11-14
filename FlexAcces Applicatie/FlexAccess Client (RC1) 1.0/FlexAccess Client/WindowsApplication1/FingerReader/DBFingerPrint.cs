using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.FingerReader
{
    class DBFingerPrint
    {
        private FlexAccessDataSetTableAdapters.module_fingerprintTableAdapter fingerPrintAdapter;

        public DBFingerPrint()
        {
            this.fingerPrintAdapter = new FlexAccessDataSetTableAdapters.module_fingerprintTableAdapter();
        }

        public FlexAccessDataSet.module_fingerprintDataTable getTemplates()
        {
            FlexAccessDataSet.module_fingerprintDataTable fingerPrintData = fingerPrintAdapter.GetData();
            return fingerPrintData;
        }
    }
}
