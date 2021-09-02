using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class TcchCeng
    {
        public long Id { get; set; }
        public string Sgzh { get; set; }
        public string Cm { get; set; }
        public int? Cg { get; set; }
        public string Clx { get; set; }
        public byte? _ { get; set; }
        public long? Zbh { get; set; }
        public long? ItemId { get; set; }
        public byte? IsDelete { get; set; }
        public string OldItemId { get; set; }
    }
}
