using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class FwLpb
    {
        public string FwDcbIndex { get; set; }
        public string FwLpbIndex { get; set; }
        public byte[] Lpb { get; set; }
    }
}
