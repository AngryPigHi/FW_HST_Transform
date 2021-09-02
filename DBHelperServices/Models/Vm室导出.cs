using System;
using System.Collections.Generic;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class Vm室导出
    {
        public long? 受理编号 { get; set; }
        public int? 房间编号 { get; set; }
        public int? 幢编号 { get; set; }
        public string 房号 { get; set; }
        public string 幢号 { get; set; }
        public string 层次 { get; set; }
        public decimal? 房间建筑面积 { get; set; }
        public decimal? 房间分摊面积 { get; set; }
        public decimal? 房间套内面积 { get; set; }
        public decimal? 房间基底面积 { get; set; }
        public decimal? 房间使用面积 { get; set; }
        public decimal? 房间住宅面积 { get; set; }
        public decimal? 房间非住宅面积 { get; set; }
        public decimal? 房间部分产权面积 { get; set; }
        public decimal? 房间阳台面积 { get; set; }
        public decimal? 抵押剩余面积 { get; set; }
        public string 所有权人 { get; set; }
        public string 区号 { get; set; }
        public string 分区号 { get; set; }
        public string 图号 { get; set; }
        public string 丘号 { get; set; }
        public string 特别号 { get; set; }
        public string 房号标识 { get; set; }
        public string 户型 { get; set; }
        public string 旧产籍号 { get; set; }
        public string 东墙 { get; set; }
        public string 西墙 { get; set; }
        public string 南墙 { get; set; }
        public string 北墙 { get; set; }
        public string 单元 { get; set; }
        public string 调查员 { get; set; }
        public DateTime? 调查日期 { get; set; }
        public string 房间用途 { get; set; }
        public string 设计用途 { get; set; }
        public string 房屋性质 { get; set; }
        public string 备注 { get; set; }
        public string 登记状态 { get; set; }
        public string 查封状态 { get; set; }
        public string 抵押状态 { get; set; }
        public string 租赁状态 { get; set; }
        public string 备案状态 { get; set; }
        public string 房屋所属区 { get; set; }
        public string 村 { get; set; }
        public string 街 { get; set; }
        public string 坐落 { get; set; }
        public string 结构 { get; set; }
        public string 总层数 { get; set; }
        public string 建筑质量 { get; set; }
        public string 建成年份 { get; set; }
        public decimal? 分摊系数 { get; set; }
        public string 层编号 { get; set; }
        public string 分户图文件名 { get; set; }
        public byte[] 分户图信息 { get; set; }
        public string 计算公式 { get; set; }
        public string 分户图比例 { get; set; }
        public int? 间数 { get; set; }
        public int? 套数 { get; set; }
        public string 附属房 { get; set; }
        public string 附房类型 { get; set; }
        public string 附属于 { get; set; }
        public string 权证幢号 { get; set; }
        public string 共有部位名称 { get; set; }
    }
}
