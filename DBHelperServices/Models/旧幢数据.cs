using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class 旧幢数据
    {
        public string 受理编号 { get; set; }
        public string 幢编号 { get; set; }
        public string 幢号 { get; set; }
        public string 特别号 { get; set; }
        public string 房屋所属区 { get; set; }
        public string 坐落 { get; set; }
        public string 产权单位 { get; set; }
        public string 产权来源 { get; set; }
        public decimal? 建筑面积 { get; set; }
        public decimal? 使用面积 { get; set; }
        public decimal? 共有面积 { get; set; }
        public string 分摊系数 { get; set; }
        public string 竣工日期 { get; set; }
        public string 建筑结构 { get; set; }
        public string 层数 { get; set; }
        public string 房屋用途 { get; set; }
        public string 权证幢号 { get; set; }
    }
}
