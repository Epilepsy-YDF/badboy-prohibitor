using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic;


namespace badboy_prohibitor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    public partial class MainWindow : Window
    {
        

        //public object Interaction { get; private set; }

        private void killTask(string 进程名)
        {

            if (Process.GetProcessesByName(进程名).ToList().Count > 0)
            {
                //正在运行
                Process[] processes = Process.GetProcessesByName(进程名);
                foreach (Process p in processes)
                {
                    p.Kill();
                    p.Close();
                    //steamroorreporter.exe
                }
            }
            else
            {
                //未在运行
            }

        }
        public void WriteHOSTS (string host)
        {
            string s = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            if (!File.Exists(s))//判断有没有，没有新建个
            {
                StreamWriter sw = new StreamWriter(s, true, Encoding.UTF8);
                sw.WriteLine();
                sw.WriteLine(host);
                sw.Close();
                sw.Dispose();
            }
            System.IO.StreamReader sr = new System.IO.StreamReader(s, true);
            bool isexist = false;
            while (!sr.EndOfStream)//判断要不要添加
            {
                string ss = sr.ReadLine();
                if (ss.IndexOf("#") == 0) continue;
                if (ss == host)
                {
                    isexist = true;
                    break;
                }
            }
            sr.Close();
            sr.Dispose();
            if (!isexist)//写入内容
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(s, true);
                sw.WriteLine();
                sw.WriteLine(host);
                sw.Close();
                sw.Dispose();
            }
        }

        public MainWindow()
        {
            password pw = new password();
            pw.Show();
            Visibility = Visibility.Collapsed;
            InitializeComponent();
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += Dt_Tick;
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Start();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void selectAll_Checked(object sender, RoutedEventArgs e)
        {
            tgp.IsChecked = true;
            lol.IsChecked = true;
            crossfire.IsChecked = true;
            speed.IsChecked = true;
            x5.IsChecked = true;
            dnf.IsChecked = true;
            mc.IsChecked = true;
            mcbox.IsChecked = true;
            steam.IsChecked = true;
            _4399.IsChecked = true;
            _3366.IsChecked = true;
            _7k7k.IsChecked = true;
        }

        private void selectAll_Unchecked(object sender, RoutedEventArgs e)
        {
            tgp.IsChecked = false;
            lol.IsChecked = false;
            crossfire.IsChecked = false;
            speed.IsChecked = false;
            x5.IsChecked = false;
            dnf.IsChecked = false;
            mc.IsChecked = false;
            mcbox.IsChecked = false;
            steam.IsChecked = false;
            _4399.IsChecked = false;
            _3366.IsChecked = false;
            _7k7k.IsChecked = false;
        }

        private void _4399_Checked(object sender, RoutedEventArgs e)
        {
            WriteHOSTS("127.0.0.1 www.4399.com");
        }

        private void _4399_Unchecked(object sender, RoutedEventArgs e)
        {
            string path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            string ctt = File.ReadAllText(path).Replace("127.0.0.1 www.4399.com", "");
            File.WriteAllText(path, ctt, Encoding.UTF8);
            string content = File.ReadAllText(path).Replace("127.0.0.1 4399.com", "");
            File.WriteAllText(path, content, Encoding.UTF8);
        }

        private void _3366_Checked(object sender, RoutedEventArgs e)
        {
            WriteHOSTS("127.0.0.1 www.3366.com");
        }



        private void About_Click(object sender, RoutedEventArgs e)
        {
            About fr2 = new About();  //新建实例对象
            //fr2.Show(); //通过Show方法显示窗口
            fr2.ShowDialog();
        }

        private void _7k7k_Checked(object sender, RoutedEventArgs e)
        {
            WriteHOSTS("127.0.0.1 www.7k7k.com");

        }

        private void pw_Checked(object sender, RoutedEventArgs e)
        {
            pb.IsEnabled = true;
        }

        private void pw_Unchecked(object sender, RoutedEventArgs e)
        {
            pb.IsEnabled = false;
        }

        private void dsbtaskmgr_Checked(object sender, RoutedEventArgs e)
        {
            string str = Console.ReadLine();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(str + Properties.Resources.禁止任务管理器);
        }


        private void dsbtaskmgr_Unchecked_1(object sender, RoutedEventArgs e)
        {
            string str = Console.ReadLine();

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(str + Properties.Resources.允许任务管理器);
        }

        private void _3366_Unchecked(object sender, RoutedEventArgs e)
        {
            string path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            string ctt = File.ReadAllText(path).Replace("127.0.0.1 www.3366.com", "");
            File.WriteAllText(path, ctt, Encoding.UTF8);
            string content = File.ReadAllText(path).Replace("127.0.0.1 3366.com", "");
            File.WriteAllText(path, content, Encoding.UTF8);
        }

        private void _7k7k_Unchecked(object sender, RoutedEventArgs e)
        {
            string path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            string ctt = File.ReadAllText(path).Replace("127.0.0.1 www.7k7k.com", "");
            File.WriteAllText(path, ctt, Encoding.UTF8);
            string content = File.ReadAllText(path).Replace("127.0.0.1 7k7k.com", "");
            File.WriteAllText(path, content, Encoding.UTF8);
        }
        private void Dt_Tick(object sender, EventArgs e)
        {
            if (mcbox.IsChecked == true)
            {
                killTask("MCPCBox");
            }
            if (steam.IsChecked == true)
            {
                killTask("Steam");
            }
        }

        private void mw_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            if (pw.IsChecked == true)
            {
                //MessageBox.Show("确定");
                if (pb.Password == "")
                {
                    MessageBox.Show("请在密码框中输入你的密码", "警告");
                }
                else
                {
                    password pw = new password();  //新建实例对象
                    pw.ShowDialog();
                }

                

            }
            else
            {
                System.Environment.Exit(0);
            }

        }
        private void steam_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void discNet_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void pb_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(pb.Password);
            string jiami = pb.Password;
            byte[] bytes = Encoding.Default.GetBytes(jiami);
            string ok = Convert.ToBase64String(bytes);
            System.IO.File.WriteAllText("D:/test.txt", ok, Encoding.Default);

        }

        private void mw_Loaded(object sender, RoutedEventArgs e)
        {
            Process[] app = Process.GetProcessesByName("360Tray");
            if (app.Length > 0)
            {
                MessageBox.Show("360正在运行，是否关闭！", "经过");
            }
            else
            {
                //System.Diagnostics.Process.Start("AMS.exe");
            }
        }

        private void savepass_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

