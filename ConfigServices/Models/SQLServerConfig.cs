using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServices.Models
{
    public class SQLServerConfig
    {
        public string Server { get; set; }

        public string Database { get; set; }

        //User Id
        public string UserId { get; set; }

        public string Password { get; set; }

    }
}
