﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class FwHst
    {
        public string FwHstIndex { get; set; }
        public byte[] Hst { get; set; }
        public byte[] Hstbz { get; set; }
        public string Hstbzdownid { get; set; }
        public string Hstbzmc { get; set; }
        public byte[] Hstcad { get; set; }
        public string Hstcaddownid { get; set; }
        public string Hstcadmc { get; set; }
        public string Hstdownid { get; set; }
        public string Hstmc { get; set; }
        public string Jlyhm { get; set; }
        public string Scjqm { get; set; }
        public string Scsj { get; set; }
    }
}
