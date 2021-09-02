using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class ShTxl
    {
        public int Id { get; set; }
        public string AddName { get; set; }
        public string AddBirthday { get; set; }
        public string AddTel { get; set; }
        public string AddPhone { get; set; }
        public string AddAddress { get; set; }
        public string AddZip { get; set; }
        public string AddCompany { get; set; }
        public string AddCompanyAddress { get; set; }
    }
}
