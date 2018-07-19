using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Lib.Model
{
    public abstract class DeliveryNote
    {
        public DeliveryNote() { }
        public int DeliveryNoteId { get; set; }

        public Address senderAddress { get; set; } = new Address();
        public Address receiverAddress { get; set; } = new Address();

        public string senderFIO { get; set; }
        public string receiverFIO { get; set; }

        public string senderPhone { get; set; }
        public string receiverPhone { get; set; }

        /// <summary>
        /// вывод инфо
        /// </summary>
        public virtual void GetInfo()
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
        }


    }
}
