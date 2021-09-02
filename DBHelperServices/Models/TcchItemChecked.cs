using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class TcchItemChecked
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public string Remark { get; set; }
        public byte? Direction { get; set; }
        public byte? Status { get; set; }
        public string CheckUser { get; set; }
        public DateTime? Cdate { get; set; }
        public string OldItemId { get; set; }
    }
}
