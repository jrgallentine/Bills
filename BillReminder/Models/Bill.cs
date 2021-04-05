using System;
using System.Collections.Generic;

#nullable disable

namespace BillReminder.Models
{
    public partial class Bill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public string Url { get; set; }
        public DateTime? Due { get; set; }
        public string Description { get; set; }
        public bool? Paid { get; set; }
    }
}
