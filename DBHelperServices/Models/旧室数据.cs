using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class 旧室数据
    {
        public string 受理编号 { get; set; }
        public string 房间编号 { get; set; }
        public string 幢编号 { get; set; }
        public string 幢号 { get; set; }
        public string 特别号 { get; set; }
        public string 房号 { get; set; }
        public string 房号标识 { get; set; }
        public string 层次 { get; set; }
        public decimal? 房间建筑面积 { get; set; }
        public decimal? 房间分摊面积 { get; set; }
        public decimal? 房间套内面积 { get; set; }
        public string 房间用途 { get; set; }
        public string 结构 { get; set; }
        public string 分摊系数 { get; set; }
    }
}
