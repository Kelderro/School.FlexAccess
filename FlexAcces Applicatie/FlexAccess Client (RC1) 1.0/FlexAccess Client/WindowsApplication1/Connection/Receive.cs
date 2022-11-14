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
        private static Boolean TerminateProgram = false;

        public static void ProcessData(DataSet ProcessData)
        {
            switch (ProcessData.Tables[HEADER_TABLE].Rows[0].ItemArray[MESSAGETYPE].ToString())
            {
                case "ConfirmRegister":
                    ConfirmRegister(ProcessData);
                    break;
                case "invalidIP":
                    if (TerminateProgram == false)
                    {
                        System.Windows.Forms.MessageBox.Show("Het locale ip: " + ProcessData.Tables[DATA_TABLE].Rows[0].ItemArray[0].ToString() + " is niet geldig.\nU dient dit ip toe te voegen in de beheers- Applicatie om deze client te mogen starten");
                        TerminateProgram = true;
                    }
                    System.Windows.Forms.Application.Exit();
                    break;
              case "Response":
                    Console.WriteLine("Reactie van server: " + ProcessData.Tables[DATA_TABLE].Rows[0].ItemArray[0].ToString());
                    break;
                default:
                    Console.WriteLine("@@@@ Er is een onbekend procol ontvangen (" + ProcessData.Tables[HEADER_TABLE].Rows[0].ItemArray[MESSAGETYPE].ToString() + ") @@@@@");
                    break;
            }
        }

        private static void ConfirmRegister(DataSet ds)
        {
            Console.WriteLine("@@@@ ConfirmRegister @@@@@");
        }
    }
}
