﻿using System;
using System.Collections.Generic;

namespace Exman.Api.Models
{
    public class Invoice
    {
        public Invoice() => InvoiceItems = new HashSet<InvoiceItem>();

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public float Total { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
