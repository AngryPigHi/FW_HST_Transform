using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServices.Models
{
    public class OracleConfig
    {
        public string UserId { get; set; }

        public string Password { get; set; }

        public string DataSource { get; set; }

        public string Host { get; set; }

        public string Port { get; set; }

        public string ServiceName { get; set; }

    }
}
