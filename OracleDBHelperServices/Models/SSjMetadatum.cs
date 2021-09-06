using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class SSjMetadatum
    {
        public string Dm { get; set; }
        public string Dwdm { get; set; }
        public string Nd { get; set; }
        public byte[] Xmldata { get; set; }
    }
}
