using CourierService.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Lib
{
    public class DbAndFile
    {

        private string pathToFile { get; set; }
        public DbAndFile() { }
        public DbAndFile(string pathToFile)
        {
            this.pathToFile = pathToFile;
        }
        public void CreateFileAndDB(DeliveryNote Note)
        {
            string mes = "";
            if (DBWork.CreateNote(Note, out mes))
            {
                FileWork f = new FileWork(pathToFile);
               if(!f.CreateNoteFile(Note, out mes))
                    Console.WriteLine(mes);
            }

        }

    }
}
