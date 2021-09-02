using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class 受理表
    {
        public string 受理编号 { get; set; }
        public string 申请人一 { get; set; }
        public string 申请人一证件名称 { get; set; }
        public string 项目名称 { get; set; }
        public string 环节Id { get; set; }
        public string 受理日期 { get; set; }
        public decimal? 登记面积 { get; set; }
        public string 业务类别 { get; set; }
        public string 测绘成果编号 { get; set; }
        public string 测绘公司 { get; set; }
    }
}
