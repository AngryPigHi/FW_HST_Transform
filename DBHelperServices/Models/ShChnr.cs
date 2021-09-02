using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class ShChnr
    {
        public int Id { get; set; }
        public string Djh { get; set; }
        public int? Sjlx { get; set; }
        public string Sjmc { get; set; }
        public int? IsChecked { get; set; }
        public int? Category { get; set; }
    }
}
