using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class SSjzdLx
    {
        public int Id { get; set; }
        public string LxType { get; set; }
        public int? ObjectCode { get; set; }
        public int? FirstClass { get; set; }
        public int? SecondClass { get; set; }
        public int? ThirdClass { get; set; }
        public string UserId { get; set; }
        public string IntRemark { get; set; }
        public bool? BoolRemark { get; set; }
    }
}
