using System;

namespace Exman.Api.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
    }
}
