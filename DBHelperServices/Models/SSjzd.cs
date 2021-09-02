using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class SSjzd
    {
        public int ItemId { get; set; }
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int? ParentItemId { get; set; }
        public string Category { get; set; }
        public string Remark { get; set; }
        public int? OrderCode { get; set; }
        public bool? Available { get; set; }
    }
}
