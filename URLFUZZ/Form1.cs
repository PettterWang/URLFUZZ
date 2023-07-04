using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URLFUZZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_URLFUZZ_FUZZ_Click(object sender, EventArgs e)
        {
            //
            if (textBox_URLFUZZ_URL.Text == string.Empty)
            {
                MessageBox.Show("URL is NULL");
                return;
            }
            //
            listBox_URLFUZZ_Payload.Items.Clear();
            //
            bool NoDomain;
            if (checkBox_URLFUZZ_NODOMAIN.Checked)
            {
                NoDomain = true;
            }
            else
            {
                NoDomain = false;
            }
            //
            if (checkBox_URLFUZZ_CUSTOM.Checked && textBox_URLFUZZ_CUSTOM.Text != string.Empty)
            {
                URLFUZZ1(textBox_URLFUZZ_URL.Text, textBox_URLFUZZ_CUSTOM.Text, NoDomain);
            }
            //
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/./", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/././", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/./././", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/../", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/.../", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/css/../", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/css/%2e%2e/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/js/../", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/js/%2e%2e/", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;/;/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;/;/;/", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;css/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;css/;css/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;css/;css/;css/", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;js/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;js/;js/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/;js/;js/;js/", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/.;/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/..;/", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/...;/", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/.;/css/../", NoDomain);
            URLFUZZ1(textBox_URLFUZZ_URL.Text, "/.;/js/../", NoDomain);

            URLFUZZ1(textBox_URLFUZZ_URL.Text, ".;/", NoDomain);

            URLFUZZ2(textBox_URLFUZZ_URL.Text, "/", NoDomain);
            // 去重
            List<string> uniqueItems = listBox_URLFUZZ_Payload.Items.Cast<string>().Distinct().ToList();
            // 加载
            listBox_URLFUZZ_Payload.Items.Clear();
            foreach (var i in uniqueItems)
            {
                if (checkBox_URLFUZZ_NODOMAIN.Checked && checkBox_URLFUZZ_REMOVE.Checked && i.StartsWith("/"))
                {
                    listBox_URLFUZZ_Payload.Items.Add(i);
                }
                if (!checkBox_URLFUZZ_NODOMAIN.Checked || !checkBox_URLFUZZ_REMOVE.Checked)
                {
                    listBox_URLFUZZ_Payload.Items.Add(i);
                }
            }
            // 统计
            groupBox_URLFUZZ.Text = listBox_URLFUZZ_Payload.Items.Count.ToString();
        }

        public void URLFUZZ1(string origin_url, string rule, bool NoDomain)
        {
            //
            if (checkBox_URLFUZZ_REPLACE1.Checked)
            {
                rule = rule.Replace(".", "%2e");
            }
            // 解析
            Uri uri = new Uri(origin_url);
            string scheme = uri.Scheme + "://";
            string host = uri.Host;
            string port = ":" + uri.Port.ToString();
            string localPath = uri.LocalPath;
            string fileName = Path.GetFileName(localPath);
            string directoryName = Path.GetDirectoryName(localPath);
            string fileExtension = Path.GetExtension(localPath);
            // 单点 FUZZ
            string newdirectoryName = string.Empty;
            string newUrl = string.Empty;
            int fileLength = directoryName.Split('\\').Length;
            for (int i = 0; i < fileLength; i++)
            {
                //
                string[] files = directoryName.Split('\\');
                files[i] = files[i] + rule;
                newdirectoryName = string.Join("/", files.Select(f => f.EndsWith("/") ? f.Substring(0, f.Length - 1) : f)) + "/";
                //
                if (NoDomain == false)
                {
                    if (port == ":80" || port == ":443")
                    {
                        newUrl = scheme + host + newdirectoryName + fileName;
                    }
                    else
                    {
                        newUrl = scheme + host + port + newdirectoryName + fileName;
                    }
                }
                else
                {
                    if (port == ":80" || port == ":443")
                    {
                        newUrl = newdirectoryName + fileName;
                    }
                    else
                    {
                        newUrl = newdirectoryName + fileName;
                    }
                }
                //
                listBox_URLFUZZ_Payload.Items.Add(newUrl);
            }
            // 全路径FUZZ
            newdirectoryName = string.Empty;
            foreach (var i in directoryName.Split('\\'))
            {
                newdirectoryName += i + rule;
            }
            //
            newUrl = string.Empty;
            if (NoDomain == false)
            {
                if (port == ":80" || port == ":443")
                {
                    newUrl = scheme + host + newdirectoryName + fileName;
                }
                else
                {
                    newUrl = scheme + host + port + newdirectoryName + fileName;
                }
            }
            else
            {
                if (port == ":80" || port == ":443")
                {
                    newUrl = newdirectoryName + fileName;
                }
                else
                {
                    newUrl = newdirectoryName + fileName;
                }
            }
            listBox_URLFUZZ_Payload.Items.Add(newUrl);
            // 单路径 正向FUZZ url1
            string url1 = newUrl;
            int index = url1.IndexOf(rule);
            while (index >= 0)
            {
                //
                url1 = url1.Remove(index, rule.Length - 1);
                //
                if (url1 != origin_url)
                {
                    listBox_URLFUZZ_Payload.Items.Add(url1);
                }
                //
                index = url1.IndexOf(rule);
            }
            // 单路径 反向FUZZ url2
            string url2 = newUrl;
            index = url2.LastIndexOf(rule);
            while (index >= 0)
            {
                //
                url2 = url2.Remove(index, rule.Length - 1);
                //
                if (url2 != origin_url)
                {
                    listBox_URLFUZZ_Payload.Items.Add(url2);
                }
                //
                index = url2.LastIndexOf(rule);
            }
        }

        public void URLFUZZ2(string origin_url, string rule, bool NoDomain)
        {
            //
            if (checkBox_URLFUZZ_REPLACE1.Checked)
            {
                rule = rule.Replace(".", "%2e");
            }
            // 解析
            Uri uri = new Uri(origin_url);
            string scheme = uri.Scheme + "://";
            string host = uri.Host;
            string port = ":" + uri.Port.ToString();
            string localPath = uri.LocalPath;
            string fileName = Path.GetFileName(localPath);
            string directoryName = Path.GetDirectoryName(localPath);
            string fileExtension = Path.GetExtension(localPath);
            // 单点 FUZZ
            string newdirectoryName = string.Empty;
            string newUrl = string.Empty;
            int fileLength = directoryName.Split('\\').Length;
            for (int i = 0; i < fileLength; i++)
            {
                //
                string[] files = directoryName.Split('\\');
                files[i] = files[i] + rule;
                newdirectoryName = string.Join("/", files) + "/";
                //
                if (NoDomain == false)
                {
                    if (port == ":80" || port == ":443")
                    {
                        newUrl = scheme + host + newdirectoryName + fileName;
                    }
                    else
                    {
                        newUrl = scheme + host + port + newdirectoryName + fileName;
                    }
                }
                else
                {
                    if (port == ":80" || port == ":443")
                    {
                        newUrl = newdirectoryName + fileName;
                    }
                    else
                    {
                        newUrl = newdirectoryName + fileName;
                    }
                }
                //
                listBox_URLFUZZ_Payload.Items.Add(newUrl);
            }
            // 全路径FUZZ
            newdirectoryName = string.Empty;
            foreach (var i in directoryName.Split('\\'))
            {
                newdirectoryName += i + rule + rule;
            }
            //
            newUrl = string.Empty;
            if (NoDomain == false)
            {
                if (port == ":80" || port == ":443")
                {
                    newUrl = scheme + host + newdirectoryName + fileName;
                }
                else
                {
                    newUrl = scheme + host + port + newdirectoryName + fileName;
                }
            }
            else
            {
                if (port == ":80" || port == ":443")
                {
                    newUrl = newdirectoryName + fileName;
                }
                else
                {
                    newUrl = newdirectoryName + fileName;
                }
            }
            listBox_URLFUZZ_Payload.Items.Add(newUrl);
        }

        private void button_URLFUZZ_SAVE_Click(object sender, EventArgs e)
        {
            //
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            //
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    //
                    foreach (string i in listBox_URLFUZZ_Payload.Items)
                    {
                        sw.WriteLine(i);
                    }
                }
            }
        }

        private void button_URLFUZZ_CLEAR_Click(object sender, EventArgs e)
        {
            listBox_URLFUZZ_Payload.Items.Clear();
            groupBox_URLFUZZ.Text = string.Empty;
        }

        private void listBox_URLFUZZ_Payload_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_URLFUZZ_Payload.SelectedItem != null)
            {
                //
                string selectedItem = listBox_URLFUZZ_Payload.SelectedItem.ToString();
                //
                Clipboard.SetText(selectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.URLFUZZ_URL != string.Empty)
            {
                textBox_URLFUZZ_URL.Text = Properties.Settings.Default.URLFUZZ_URL;
            }
            if (Properties.Settings.Default.URLFUZZ_CUSTOM != string.Empty)
            {
                textBox_URLFUZZ_CUSTOM.Text = Properties.Settings.Default.URLFUZZ_CUSTOM;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            if (textBox_URLFUZZ_URL.Text != string.Empty)
            {
                Properties.Settings.Default.URLFUZZ_URL = textBox_URLFUZZ_URL.Text;
            }
            if (textBox_URLFUZZ_CUSTOM.Text != string.Empty)
            {
                Properties.Settings.Default.URLFUZZ_CUSTOM = textBox_URLFUZZ_CUSTOM.Text;
            }
            //
            Properties.Settings.Default.Save();
        }
    }
}
