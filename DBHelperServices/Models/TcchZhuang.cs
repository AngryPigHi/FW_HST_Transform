﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class TcchZhuang
    {
        public long Zid { get; set; }
        public string Sgzh { get; set; }
        public string Gazh { get; set; }
        public string Zjg { get; set; }
        public string Fwcb { get; set; }
        public string Sjyt { get; set; }
        public int? Dscs { get; set; }
        public int? Dxcs { get; set; }
        public string Ftlx { get; set; }
        public string Jgrq { get; set; }
        public string _ { get; set; }
        public long? Zbh { get; set; }
        public long? ItemId { get; set; }
        public byte? IsDelete { get; set; }
        public string OldItemId { get; set; }
        public byte? IsSendReg { get; set; }
        public long? ZbhDj { get; set; }
        public long? ZbhNew { get; set; }
    }
}
