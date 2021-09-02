using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class ShSjcl
    {
        public int Id { get; set; }
        public string Djh { get; set; }
        public string Sjmc { get; set; }
        public string XType { get; set; }
        public int? XStatus { get; set; }
        public bool? IsCheck { get; set; }
    }
}
