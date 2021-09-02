using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class TcchDataDict
    {
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int? Sort { get; set; }
    }
}
