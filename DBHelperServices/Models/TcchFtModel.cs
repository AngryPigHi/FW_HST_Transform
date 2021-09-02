using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class TcchFtModel
    {
        public long ModelId { get; set; }
        public string Sgzh { get; set; }
        public decimal? Zsarea { get; set; }
        public decimal? Ftarea { get; set; }
        public decimal? Suballarea { get; set; }
        public decimal? Ftnum { get; set; }
        public string Jdnum { get; set; }
        public string Jdname { get; set; }
        public string Tag { get; set; }
        public string Mirror { get; set; }
        public byte? _ { get; set; }
        public long? ItemId { get; set; }
        public byte? IsDelete { get; set; }
        public string OldItemId { get; set; }
    }
}
