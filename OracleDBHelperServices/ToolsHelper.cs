using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OracleDBHelperServices
{
    public static class ToolsHelper
    {
        //通过输入的关键字段，去读取数据库中的SQL语句配置
        public static string ReadFrmDBSQL(string keystring)
        {
            //连接DB字符串
            string sqlConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.9.134)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Persist Security Info=True;User ID=bdcdj_tc;Password=gtis;";//ConfigurationManager.ConnectionStrings["bdcdj_wz_jg"].ConnectionString;
            string sql = "select * from sipsd_tool_sql where sqlstate=1 and keystring='" + keystring + "'";
            DataSet ds = OracleHelper.Query(sqlConnStr, sql);
            string result = ds.Tables[0].Rows[0]["sqlstring"].ToString();

            return result.Replace("\n", " ");
        }

        public static string ReadFrmDBSQL(string keystring, string sqlnum)
        {
            //连接DB字符串
            string sqlConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.9.134)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Persist Security Info=True;User ID=bdcdj_tc;Password=gtis;";// ConfigurationManager.ConnectionStrings["bdcdj_wz_jg"].ConnectionString;
            string sql = "select * from sipsd_tool_sql where sqlstate=1 and sqlnum='" + sqlnum + "' and keystring='" + keystring + "'";
            DataSet ds = OracleHelper.Query(sqlConnStr, sql);
            string result = ds.Tables[0].Rows[0]["sqlstring"].ToString();

            return result.Replace("\n", " ");
        }



        //验证15位身份证件号
        public static bool CheckIDCard15(string Id)

        {
            long n = 0;
            if (long.TryParse(Id, out n) == false || n < Math.Pow(10, 14))

            {
                return false;//数字验证

            }

            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";

            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                return false;//省份验证
            }

            string birth = Id.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();

            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }

            return true;//符合15位身份证标准

        }

        //验证18位身份证件号
        public static bool CheckIDCard18(string Id)
        {
            long n = 0;
            if (long.TryParse(Id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(Id.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return false;//数字验证
            }

            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";

            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = Id.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != Id.Substring(17, 1).ToLower())
            {
                return false;//校验码验证
            }
            return true;//符合GB11643-1999标准
        }


        //校验统一社会信用代码
        public static bool CheckSocialCreditCode(string code)
        {
            if (code == null || code.Length != 18) return false;
            code = code.ToUpper();
            int[] factor = { 1, 3, 9, 27, 19, 26, 16, 17, 20, 29, 25, 13, 8, 24, 10, 30, 28 };
            string str = "0123456789ABCDEFGHJKLMNPQRTUWXY";
            int total = factor.Select((p, i) => p * str.IndexOf(code[i])).Sum();
            int index = total % 31 == 0 ? 0 : (31 - total % 31);
            return str[index] == code.Last();
        }

        //组织机构代码校验
        public static bool CheckOrganizationCode(string code)
        {
            string pattern = @"^[a-zA-Z0-9]{8}-[a-zA-Z0-9]$";
            return Regex.IsMatch(code, pattern);
        }


        //获取时间戳
        public static long CurrentTimeStamp(bool isMinseconds)
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            long times = Convert.ToInt64(isMinseconds ? ts.TotalMilliseconds : ts.TotalSeconds);
            return times;
        }

        //转换日期格式
        public static object FormatDate(string djsjxgtxt)
        {
            string djsjxgtime = "";
            DateTime djsjxg = new DateTime();
            if (djsjxgtxt != "")
            {
                //判断日期中是否包含了'/' '：' ' '
                if (djsjxgtxt.Contains('/') && djsjxgtxt.Contains(':') && djsjxgtxt.Contains(' '))
                {
                    djsjxgtime = djsjxgtxt;
                }
                else if (djsjxgtxt.Contains('/'))
                {
                    djsjxgtime = djsjxgtxt;
                }
                else
                {
                    djsjxgtime = djsjxgtxt.Substring(0, 4) + "/" + djsjxgtxt.Substring(4, 2) + "/" + djsjxgtxt.Substring(6, 2) + " 00:00:00";
                }
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.LongTimePattern = "yy/MM/dd HH:mm:ss";
                djsjxg = Convert.ToDateTime(djsjxgtime, dtFormat);
                return djsjxg;
            }
            else
            {
                return DBNull.Value;
            }

        }
    }
}
