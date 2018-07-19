using CourierService.Lib.Model;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Lib
{
    public class DBWork
    {/// <summary>
     /// Create DataBase
     /// </summary>
     /// <param name="Note"></param>
     /// <param name="mes"></param>
     /// <returns></returns>
        public static bool CreateNote(DeliveryNote Note, out string mes)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(@"CourierService.db"))
                {
                    LiteCollection<DeliveryNote> Notes = db.GetCollection<DeliveryNote>("Note");
                    Notes.Insert(Note);
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
