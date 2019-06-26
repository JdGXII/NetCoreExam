using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.ViewModels
{
    public class InvoiceItem
    {
        public int InvoiceId { get; set; }
        public int TrackId { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
