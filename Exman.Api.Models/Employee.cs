using System;

namespace Exman.Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public int ReportsTo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
    }
}
