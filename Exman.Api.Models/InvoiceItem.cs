using System;
using System.Collections.Generic;
using System.Text;

namespace Exman.Api.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int TrackId { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
