using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class HGzwPmt
    {
        public string Bgbh { get; set; }
        public string GzwDcbIndex { get; set; }
        public string GzwPmtIndex { get; set; }
        public string Jlyhm { get; set; }
        public byte[] Pmt { get; set; }
        public string Pmtdownid { get; set; }
        public string Pmtmc { get; set; }
        public string Scjqm { get; set; }
        public string Scsj { get; set; }
    }
}
