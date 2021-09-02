using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class ShClset
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ProjectType { get; set; }
        public string XList { get; set; }
        public string XType { get; set; }
        public int? XOrder { get; set; }
        public string XBh { get; set; }
    }
}
