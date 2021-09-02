using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServices
{
    public class SqlServerConfigProvider : FileConfigurationProvider
    {
        public SqlServerConfigProvider(FileConfigurationSource source) : base(source)
        {
        }

        public override void Load(Stream stream)
        {

            var data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            //读取私密配置


        }
    }
}
