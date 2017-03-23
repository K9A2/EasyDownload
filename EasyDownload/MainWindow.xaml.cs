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
            switch (cbo_main.SelectedIndex)
            {
                case 0:
                    result=GetBtbook(txt_keyword.Text.Trim());
                    break;
                case 1:break;
                case 2:break;
                case 3:break;
                case 4:break;
                case 5:break;
                case 6:break;
                case 7:break;
                case 8:break;
                default: break;
            }

            //获取搜索结果
            //DataTable result = GetBtbook(txt_keyword.Text.Trim());
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
