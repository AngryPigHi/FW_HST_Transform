using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class APatrolErrorLog
    {
        public int Id { get; set; }
        public string ErrorInfo { get; set; }
        public DateTime? Creattime { get; set; }
    }
}
