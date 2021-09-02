using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class A01
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? PriceUnit { get; set; }
        public int? XNum { get; set; }
    }
}
