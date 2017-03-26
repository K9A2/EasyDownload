using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static EasyDownload.Util;

namespace EasyDownload
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        /*
         * 这一块是所有网站匹配磁力链接所用的前缀，后缀，和正则表达式
         */
        //Btbook - 磁力搜索
        private const string BTBOOK_PREFIX = @"http://www.btmeet.org/search/";
        private const string BTBOOK_SUFFIX = @".html";
        private const string BTBOOK_REG_MAG = @"(?<=http://www.btmeet.org/wiki/).*?(?=.html)";
        //BT磁力链 - 最好用的磁力链接搜索引擎
        private const string BTCILILIAN_PREFIX = @"http://www.bturls.net/search/";
        private const string BTCILILIAN_SUFFIX = @"_ctime_1.html";
        private const string BTCILILIAN_REG_MAG = @"";
        //磁力搜 - CiLiSou.CN
        private const string CILISOU_PREFIX = @"http://www.cilisou.cn/s.php?q=2012";
        private const string CILISOU_SUFFIX = @"&encode_=1";
        private const string CILISOU_REG_MAG = @"";
        //BT樱桃 - 磁力链接搜索引擎
        private const string BTYINGTAO_PRIFIX = @"http://www.btcherry.info/search?keyword=";
        private const string BTYINGTAO_REG_MAG = @"";
        //BT岛 - 最好用的磁力链接搜索引擎
        private const string BTDAO_PREFIX = @"http://www.btdao5.com/list/";
        private const string BTDAO_SUFFIX = @"-s1d-1.html";
        private const string BTDAO_REG_MAG = @"";
        //蜘蛛磁力搜索 - 磁力链接搜索引擎
        private const string ZHIZHU_PREFIX = @"http://www.zhizhucili.net/so/";
        private const string ZHIZHU_SUFFIX = @"-first-asc-1?f=h";
        private const string ZHIZHU_REG_MAG = @"";
        //磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载
        private const string CILILIAN_PREFIX = @"http://www.cililian.com/main-search.html?kw=";
        private const string CILILIAN_REG_MAG = @"";
        //RunBT - 磁力搜索_BT搜索_磁力链接_种子搜索
        private const string RUNBT_PREFIX = @"http://www.runbt.cc/list/";
        private const string RUNBT_SUFFIX = @"/1";
        private const string RUNBT_REG_MAG = @"";
        //磁力链接 - BT种子磁力链接搜索引擎
        private const string CILIANJIE_PREFIX = @"http://cililian.me/list/";
        private const string CILILIANJIE_SUFFIX = @"/1.html";
        private const string CILILIANJIE_REG_MAG = @"";

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 主界面搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            //用来存储结果的DataTable
            DataTable result = null;

            //提示信息
            MessageBox.Show("搜索中，请稍后");

            //根据所选网站进行搜索
            // 只有「3.BT樱桃 - 磁力链接搜索引擎」和「6.磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载」
            //是「前缀 + 关键字」模式，其余都是「前缀 + 关键字 + 后缀」模式
            switch (cbo_main.SelectedIndex)
            {
                //Btbook - 磁力搜索
                case 0:break;
                //BT磁力链 - 最好用的磁力链接搜索引擎
                case 1:
                    GetBTCiLiLian(txt_keyword.Text.Trim());
                    break;
                //磁力搜 - CiLiSou.CN
                case 2:break;
                //BT樱桃 - 磁力链接搜索引擎
                case 3:break;
                //BT岛 - 最好用的磁力链接搜索引擎
                case 4:break;
                //蜘蛛磁力搜索 - 磁力链接搜索引擎
                case 5:break;
                //磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载
                case 6:break;
                //RunBT - 磁力搜索_BT搜索_磁力链接_种子搜索
                case 7:break;
                //磁力链接 - BT种子磁力链接搜索引擎
                case 8:break;
                default: break;
            }

            //获取搜索结果
            if (result.Rows.Count == 0)
            {
                MessageBox.Show("服务器开小差了，请稍后尝试吧。");
            }
            else
            {
                dg_result.ItemsSource = result.DefaultView;
            }

        }
    }
}
