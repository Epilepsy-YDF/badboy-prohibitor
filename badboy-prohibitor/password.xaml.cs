using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace badboy_prohibitor
{
    /// <summary>
    /// password.xaml 的交互逻辑
    /// </summary>
    public partial class password : Window
    {
        public password()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pw;
            pw = Convert.ToString(System.IO.File.ReadAllText("D:/test.txt"));

            byte[] outputb = Convert.FromBase64String(pw);
            string jiemi = Encoding.Default.GetString(outputb);
            if (pd.Password==jiemi)
            {
                //MessageBox.Show("yes");
                System.Environment.Exit(0);
            }
            else
            {
                if(pd.Password=="")
                {
                    MessageBox.Show("请输入密码！", "警告");
                }
                else
                {
                    MessageBox.Show("密码错误", "警告");
                    pd.Password = "";
                }

            }
        }
    }
}
