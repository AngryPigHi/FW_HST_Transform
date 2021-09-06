using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class DataExchangeDevelopOffice
    {
        public string ListId { get; set; }
        public string EstateType { get; set; }
        public string EstateId { get; set; }
        public string EstateMode { get; set; }
        public string ProcessModeA { get; set; }
        public string ProcessModeB { get; set; }
        public DateTime? ListDate { get; set; }
    }
}
