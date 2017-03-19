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
using System.Diagnostics;

namespace badboy_prohibitor
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
            FileStream fs = null;
            string filePath = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
            //将待写入的数据从字符串转换为字节数组
            Encoding encoder = Encoding.UTF8;
            byte[] bytes = encoder.GetBytes(Environment.NewLine + "4399.com   127.0.0.1" + Environment.NewLine);
            byte[] btes = encoder.GetBytes("www.4399.com   127.0.0.1");
            try
            {
                fs = File.OpenWrite(filePath);
                //设定书写的开始位置为文件的末尾  
                fs.Position = fs.Length;
                //将待写入内容追加到文件末尾  
                fs.Write(bytes, 0, bytes.Length);
                fs.Write(btes, 0, btes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件打开失败{0}", ex.ToString());
            }
            finally
            {
                fs.Close();
            }
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
            p.StandardInput.WriteLine(str + "&exit");
            p.StandardInput.AutoFlush = true;
            p.StandardInput.WriteLine("ipconfig /flushdns");
            //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死。同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令
            //获取cmd窗口的输出信息
            string output = p.StandardOutput.ReadToEnd();
            StreamReader reader = p.StandardOutput;
            string line=reader.ReadLine();
            while (!reader.EndOfStream)
            {
                str += line + "  ";
                line = reader.ReadLine();
            }
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
            Console.WriteLine(output);
        }

        private void _4399_Unchecked(object sender, RoutedEventArgs e)
        {
            string path = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
            string ctt = File.ReadAllText(path).Replace("www.4399.com   127.0.0.1", "");
            File.WriteAllText(path, ctt, Encoding.UTF8);
            string content = File.ReadAllText(path).Replace("4399.com   127.0.0.1", "");
            File.WriteAllText(path, content, Encoding.UTF8);
        }

        private void _3366_Checked(object sender, RoutedEventArgs e)
        {
            FileStream fs = null;
            string filePath = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
            Encoding encoder = Encoding.UTF8;
            byte[] bytes = encoder.GetBytes(Environment.NewLine + "3366.com   127.0.0.1" + Environment.NewLine);
            byte[] btes = encoder.GetBytes("www.3366.com   127.0.0.1");
            try
            {
                fs = File.OpenWrite(filePath);
                fs.Position = fs.Length;
                fs.Write(bytes, 0, bytes.Length);
                fs.Write(btes, 0, btes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件打开失败{0}", ex.ToString());
            }
            finally
            {
                fs.Close();
            }
        }

        private void _3366_Unchecked(object sender, RoutedEventArgs e)
        {
            string path = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
            string ctt = File.ReadAllText(path).Replace("www.3366.com   127.0.0.1", "");
            File.WriteAllText(path, ctt, Encoding.UTF8);
            string content = File.ReadAllText(path).Replace("3366.com   127.0.0.1", "");
            File.WriteAllText(path, content, Encoding.UTF8);
        }
    }
}
