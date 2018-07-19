using CourierService.Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Lib
{
    public class FileWork
    {
        private string pathToFile { get; set; }
        public FileWork(string pathToFile)
        {
            this.pathToFile = pathToFile;
        }

        public bool CreateNoteFile(DeliveryNote Note, out string mes)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathToFile))
                {
                    sw.WriteLine(Note);
                }
                mes = "";
                return true;
            }
            catch (Exception ex)
            {
                mes = ex.Message;
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

