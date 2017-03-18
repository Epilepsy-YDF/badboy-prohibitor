using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace badboy_prohibitor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox6.Checked == true)
            {
                tgp.Checked = true;
                lol.Checked = true;
                crossfire.Checked = true;
                speed.Checked = true;
                x5.Checked = true;
                dnf.Checked = true;
                mc.Checked = true;
                mcbox.Checked = true;
                steam.Checked = true;
                _4399.Checked = true;
                _3366.Checked = true;
                _7k7k.Checked = true;
            }
            else
            {
                tgp.Checked = false;
                lol.Checked = false;
                crossfire.Checked = false;
                speed.Checked = false;
                x5.Checked = false;
                dnf.Checked = false;
                mc.Checked = false;
                mcbox.Checked = false;
                steam.Checked = false;
                _4399.Checked = false;
                _3366.Checked = false;
                _7k7k.Checked = false;
            }
        }

        private void _4399_CheckedChanged(object sender, EventArgs e)
        {
            if (_4399.Checked == true)
            {
                FileStream fs = null;
                string filePath = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
                //将待写的入数据从字符串转换为字节数组
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
            }
            else
            {
                string path = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
                string ctt = File.ReadAllText(path).Replace("www.4399.com   127.0.0.1", "");
                File.WriteAllText(path, ctt, Encoding.UTF8);
                string content = File.ReadAllText(path).Replace("4399.com   127.0.0.1", "");
                File.WriteAllText(path, content, Encoding.UTF8);
            }
        }

        private void _3366_CheckedChanged(object sender, EventArgs e)
        {
            if (_3366.Checked == true)
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
            else
            {
                string path = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
                string ctt = File.ReadAllText(path).Replace("www.3366.com   127.0.0.1", "");
                File.WriteAllText(path, ctt, Encoding.UTF8);
                string content = File.ReadAllText(path).Replace("3366.com   127.0.0.1", "");
                File.WriteAllText(path, content, Encoding.UTF8);
            }
        }

        private void _7k7k_CheckedChanged(object sender, EventArgs e)
        {
            if (_7k7k.Checked == true)
            {
                FileStream fs = null;
                string filePath = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
                Encoding encoder = Encoding.UTF8;
                byte[] bytes = encoder.GetBytes(Environment.NewLine + "7k7k.com   127.0.0.1" + Environment.NewLine);
                byte[] btes = encoder.GetBytes("www.7k7k.com   127.0.0.1");
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
            else
            {
                string path = "%SystemRoot%\\System32\\drivers\\etc\\hosts";
                string ctt = File.ReadAllText(path).Replace("www.7k7k.com   127.0.0.1", "");
                File.WriteAllText(path, ctt, Encoding.UTF8);
                string content = File.ReadAllText(path).Replace("7k7k.com   127.0.0.1", "");
                File.WriteAllText(path, content, Encoding.UTF8);
            }
        }
    }
}
