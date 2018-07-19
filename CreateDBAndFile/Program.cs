using CourierService.Lib;
using CourierService.Lib.Model;
using GeneratorName;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDBAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете тип посылки: \n 1. Express\n2. Buisness\n3.Blitz");
            int n = Int32.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    {
                        // string msg = "";
                        //DeliveryNote sender = InfoForExpressDeliveryNote();

                        // if (!DBWork.CreateNote(sender, out msg))
                        // {
                        //     Console.WriteLine(msg);
                        // }
                        DeliveryNote tmp = InfoForExpressDeliveryNote();
                        DbAndFile db = new DbAndFile();
                        db.CreateFileAndDB(tmp);

                    }
                    break;
                case 2:
                    {

                        //string msg = "";
                        //DeliveryNote sender = InfoForBuisnessDeliveryNote();

                        //if (!DBWork.CreateNote(sender, out msg))
                        //{
                        //    Console.WriteLine(msg);
                        //}

                        DeliveryNote tmp = InfoForBuisnessDeliveryNote();
                        DbAndFile db = new DbAndFile();
                        db.CreateFileAndDB(tmp);
                    }
                    break;

                case 3:
                    {
                        //string msg = "";
                        //DeliveryNote sender = InfoForBlitzDeliveryNote();

                        //if (!DBWork.CreateNote(sender, out msg))
                        //{
                        //    Console.WriteLine(msg);
                        //}
                        DeliveryNote tmp = InfoForBlitzDeliveryNote();
                        DbAndFile db = new DbAndFile();
                        db.CreateFileAndDB(tmp);
                    }
                    break;
            }
        }

        static public ExspressDeliveryNote InfoForExpressDeliveryNote()
        {
            Random rnd = new Random();
            Generator gen = new Generator();
            int id = rnd.Next();
            Console.WriteLine("ID:{0}", id);
            ExspressDeliveryNote Note = new ExspressDeliveryNote();
            Console.WriteLine("Введите данные отправителя:");
            Note.senderFIO = gen.GenerateDefault((Gender)rnd.Next(2))
                .Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n", "")
                .Substring(1);
            Console.WriteLine("ФИО: {0}", Note.senderFIO);
            Console.Write("номер телефона: ");
            Note.senderPhone = Console.ReadLine();
            Console.WriteLine("Адрес: ");
            Console.Write("Страна: ");
            Note.senderAddress.country = Console.ReadLine();
            Console.Write("Город: ");
            Note.senderAddress.city = Console.ReadLine();
            Console.Write("Улица: ");
            Note.senderAddress.street = Console.ReadLine();
            Console.Write("Дом, кв: ");
            Note.senderAddress.house = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Введите данные получателя:");
            Note.receiverFIO = gen.GenerateDefault((Gender)rnd.Next(2))
                .Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n", "")
                .Substring(1);
            Console.WriteLine("ФИО: {0}", Note.receiverFIO);
            Console.Write("номер телефона: ");
            Note.receiverPhone = Console.ReadLine();
            Console.WriteLine("Адрес: ");
            Console.Write("Страна: ");
            Note.receiverAddress.country = Console.ReadLine();
            Console.Write("Город: ");
            Note.receiverAddress.city = Console.ReadLine();
            Console.Write("Улица: ");
            Note.receiverAddress.street = Console.ReadLine();
            Console.Write("Дом, кв: ");
            Note.receiverAddress.house = Console.ReadLine();
            return Note;

        }

        static public BuisnessDeliveryNote InfoForBuisnessDeliveryNote()
        {
            Random rnd = new Random();
            Generator gen = new Generator();
            int id = rnd.Next();
            Console.WriteLine("ID:{0}",id);
            BuisnessDeliveryNote Note = new BuisnessDeliveryNote();           
            Note.typeDoc = (TypeOfDoc)rnd.Next(0, 2);
            Console.WriteLine("TypeDoc:{0}", Note.typeDoc);
            Console.WriteLine("Введите данные отправителя: ");
            Note.senderFIO = gen.GenerateDefault((Gender)rnd.Next(2))
                 .Replace("<center><b><font size=7>", "")
                 .Replace("</font></b></center>", "")
                 .Replace("\n", "")
                 .Substring(1);
            Console.WriteLine("ФИО: {0}", Note.senderFIO);
            Console.Write("номер телефона: ");
            Note.senderPhone = Console.ReadLine();
            Console.WriteLine("Адрес");
            Console.Write("Страна: ");
            Note.senderAddress.country = Console.ReadLine();
            Console.Write("Город: ");
            Note.senderAddress.city = Console.ReadLine();
            Console.Write("Улица: ");
            Note.senderAddress.street = Console.ReadLine();
            Console.Write("Дом, кв: ");
            Note.senderAddress.house = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Введите данные получателя:");
            Note.receiverFIO = gen.GenerateDefault((Gender)rnd.Next(2))
                .Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n", "")
                .Substring(1);
            Console.WriteLine("ФИО: {0}", Note.receiverFIO);
            Console.Write("номер телефона: ");
            Note.receiverPhone = Console.ReadLine();
            Console.WriteLine("Адрес: ");
            Console.Write("Страна: ");
            Note.receiverAddress.country = Console.ReadLine();
            Console.Write("Город: ");
            Note.receiverAddress.city = Console.ReadLine();
            Console.Write("Улица: ");
            Note.receiverAddress.street = Console.ReadLine();
            Console.Write("Дом, кв: ");
            Note.receiverAddress.house = Console.ReadLine();
            return Note;
        }

        static public BlitzDeliveryNote InfoForBlitzDeliveryNote()
        {
            Random rnd = new Random();
            Generator gen = new Generator();

            BlitzDeliveryNote Note = new BlitzDeliveryNote();
            int id = rnd.Next();
            Console.WriteLine("ID:{0}", id);            
            Note.tarif = (Tarif)rnd.Next(0, 1);
            Console.WriteLine("TypeDoc: {0}", Note.tarif);
            Console.WriteLine("Введите данные отправителя:");
           
            Note.senderFIO = gen.GenerateDefault((Gender)rnd.Next(2))
                 .Replace("<center><b><font size=7>", "")
                 .Replace("</font></b></center>", "")
                 .Replace("\n", "")
                 .Substring(1);
            Console.WriteLine("ФИО: {0}", Note.senderFIO);
            Console.Write("номер телефона: ");
            Note.senderPhone = Console.ReadLine();
            Console.WriteLine("Адрес");
            Console.Write("Страна: ");
            Note.senderAddress.country = Console.ReadLine();
            Console.Write("Город: ");
            Note.senderAddress.city = Console.ReadLine();
            Console.Write("Улица: ");
            Note.senderAddress.street = Console.ReadLine();
            Console.Write("Дом, кв: ");
            Note.senderAddress.house = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Введите данные получателя:");
            
            Note.receiverFIO = gen.GenerateDefault((Gender)rnd.Next(2))
                 .Replace("<center><b><font size=7>", "")
                 .Replace("</font></b></center>", "")
                 .Replace("\n", "")
                 .Substring(1);
            Console.WriteLine("ФИО: {0}", Note.receiverFIO);
            Console.Write("номер телефона: ");
            Note.receiverPhone = Console.ReadLine();
            Console.WriteLine("Адрес: ");
            Console.Write("Страна: ");
            Note.receiverAddress.country = Console.ReadLine();
            Console.Write("Город: ");
            Note.receiverAddress.city = Console.ReadLine();
            Console.Write("Улица: ");
            Note.receiverAddress.street = Console.ReadLine();
            Console.Write("Дом, кв: ");
            Note.receiverAddress.house = Console.ReadLine();
            return Note;
        }
    }
}
