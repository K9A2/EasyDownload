using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// 工具类，包括了所有网站的搜索函数
/// </summary>
namespace EasyDownload
{
    static class Util
    {

        #region 本部分为获取磁力链接的静态函数
        /*
         * 磁力链网站分为两类：
         * 1. 直接在搜索结果页可以直接提取
         *   1.1 Btbook - 磁力搜索
         *   1.2 磁力搜 - CiLiSou.CN
         *   1.3 BT樱桃 - 磁力链接搜索引擎
         *   1.4 BT岛 - 最好用的磁力链接搜索引擎
         *   1.5 蜘蛛磁力搜索 - 磁力链接搜索引擎，需要去除获得的 hash 后 7 位
         *   1.6 RunBT - 磁力搜索_BT搜索_磁力链接_种子搜索
         *   1.7 磁力链接 - BT种子磁力链接搜索引擎
         * 2. 需要从搜索结果页获得磁力链接所在的具体网页后才能获取
         *   2.1 BT磁力链 - 最好用的磁力链接搜索引擎
         *   2.2 磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载
         */

        #region 第一类可以直接获取磁力链接的网站
        /// <summary>
        /// 获取 Btbook 网站下的磁力链接
        /// </summary>
        /// <returns>返回一个 DataGrid，直接绑定到 dg_result</returns>
        public static DataTable GetBtbook(string keyword)
        {
            //结果表
            DataTable result = GetReaultTable();

            //保存每一行
            DataRow row = result.NewRow();

            //网页源代码
            StringBuilder htmlCode = null;

            //磁力链接地址
            string address = "http://www.btmeet.org/search/" + UrlEncode(keyword).ToUpper() + ".html";

            //正则表达式
            string Reg_link = @"(?<=wiki/).*?(?=.html)";

            //获取网页源代码
            htmlCode = new StringBuilder(GetHtmlCode(address));

            //正则表达式匹配，获取所有磁力链接的参数部分
            MatchCollection res_mag = Regex.Matches(htmlCode.ToString(), Reg_link);

            for (int i = 0; i < res_mag.Count; i++)
            {
                row[3] = res_mag[i];
                result.Rows.Add(row);
            }

            return result;

        }
        #endregion

        #region 第二类需要到详情页获取磁力链接网页
        #endregion

        #endregion

        #region 本部分为工具类函数

        /// <summary>
        /// 构造一个用来保存搜索结果的DataTable
        /// 其中包括Name、Date、Size和Link四列
        /// </summary>
        /// <returns>结果表</returns>
        private static DataTable GetReaultTable()
        {
            DataTable result = new DataTable("result");
            DataColumn dc = null;
            dc = result.Columns.Add("Name", Type.GetType("System.String"));
            dc = result.Columns.Add("Date", Type.GetType("System.String"));
            dc = result.Columns.Add("Size", Type.GetType("System.String"));
            dc = result.Columns.Add("Link", Type.GetType("System.String"));

            //返回结果
            return result;

        }

        /// <summary>
        /// 对字符串中的中文字符进行编码
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>编码后的结果</returns>
        private static string UrlEncode(string keyword)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(keyword);
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }

        /// <summary>
        /// 获取指定url的html源代码
        /// </summary>
        /// <param name="link">目标链接地址</param>
        /// <returns>目的网页的html源代码</returns>
        private static string GetHtmlCode(string link)
        {

            //获取指定页面的源代码,并返回包含此页面源代码的一个字符串
            string strHTML;
            Uri uri = new Uri(link);
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(uri);
            myReq.UserAgent = "User-Agent:Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705";
            myReq.Accept = "*/*";
            myReq.KeepAlive = true;
            myReq.Headers.Add("Accept-Language", "zh-cn,en-us;q=0.5");
            HttpWebResponse result = (HttpWebResponse)myReq.GetResponse();
            Stream receviceStream = result.GetResponseStream();
            StreamReader readerOfStream = new StreamReader(receviceStream, System.Text.Encoding.GetEncoding("gb2312"));
            strHTML = readerOfStream.ReadToEnd();
            readerOfStream.Close();
            receviceStream.Close();
            result.Close();

            //返回网页源代码
            return strHTML;

        }

        #endregion

    }

}
