using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW_HST_Transform.Models
{
    public class TcchShiTmp
    {
        public long RoomId { get; set; }
        public long? Zbh { get; set; }
        public string Sgzh { get; set; }
        public string Gazh { get; set; }

        public string Szc { get; set; }

        public string Mjfl { get; set; }
        public string Sh { get; set; }
        public string Sm { get; set; }

        public decimal? Cqmj { get; set; }
        public decimal? Zsmj { get; set; }
        public decimal? Ftmj { get; set; }

        public long? ItemId { get; set; }

        public string ImagePath { get; set; }

        public byte? IsDelete { get; set; }

    }
}
