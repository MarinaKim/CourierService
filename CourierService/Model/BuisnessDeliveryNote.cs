using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Lib.Model
{
    public enum TypeOfDoc { mail, parcel, specParcel }
    public class BuisnessDeliveryNote : DeliveryNote
    {
        public TypeOfDoc typeDoc { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine(" ID: {0}", DeliveryNoteId);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("From: {0}", senderFIO);
            Console.WriteLine("Address: {0}", senderAddress);
            Console.WriteLine("Phone: {0}", senderPhone);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("To: {0}", receiverFIO);
            Console.WriteLine("Address: {0}", receiverAddress);
            Console.WriteLine("Phone: {0}", receiverPhone);
            Console.WriteLine("TypeDoc: {0}", typeDoc);
        }
    }
}

