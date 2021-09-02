using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class Tabhouse
    {
        public string Unitno { get; set; }
        public decimal Id { get; set; }
        public string Sourceid { get; set; }
        public string Desid { get; set; }
        public decimal Userid { get; set; }
        public DateTime Indate { get; set; }
        public decimal? Inchessflag { get; set; }
    }
}
