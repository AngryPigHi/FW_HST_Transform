using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class SdeLogfile
    {
        public string LogfileName { get; set; }
        public decimal LogfileId { get; set; }
        public decimal LogfileDataId { get; set; }
        public decimal RegistrationId { get; set; }
        public decimal Flags { get; set; }
        public decimal SessionTag { get; set; }
        public string LogfileDataDb { get; set; }
        public string LogfileDataOwner { get; set; }
        public string LogfileDataTable { get; set; }
        public string ColumnName { get; set; }
    }
}
