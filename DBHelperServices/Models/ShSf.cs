using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class ShSf
    {
        public int Id { get; set; }
        public double? Skje { get; set; }
        public DateTime? Skrq { get; set; }
        public string Skfs { get; set; }
        public string Skr { get; set; }
        public string Pid { get; set; }
    }
}
