using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Lib.Model
{
    public enum Tarif { door, warehouse }
    public class BlitzDeliveryNote : DeliveryNote
    {
        public Tarif tarif { get; set; }
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
            Console.WriteLine("Tarif: {0}", tarif);
        }
    }
}
