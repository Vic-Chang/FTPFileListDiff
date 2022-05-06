using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;

namespace FTPFileListInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Net core WinForm 需註冊 big5 encoding
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        // FTP 上的檔案清單
        List<string> _ftpFilesList = new List<string>();

        // FTP 的過濾條件
        List<string> _filterList = new List<string>();

        private async void btn_run_ClickAsync(object sender, EventArgs e)
        {
            lv_files.Items.Clear();
            lv_diff.Items.Clear();

            var ftpIp = tb_ftpIp.Text;
            var ftpAccount = tb_account.Text;
            var ftpPassword = tb_password.Text;
            var ftpFolderPath = tb_ftpPath.Text;
            if (ftpAccount =="" || ftpAccount == "" || ftpPassword == "")
            {
                MessageBox.Show("請填上 FTP 帳號密碼");
                return;
            }
            if (ftpFolderPath.StartsWith("//"))
            {
                ftpFolderPath = ftpFolderPath.Replace("//", "").Replace(ftpIp, "");
            }
            if (!ftpFolderPath.StartsWith("/"))
            {
                ftpFolderPath = "/" + ftpFolderPath;
            }

            FtpClient client = new FtpClient(ftpIp, ftpAccount, ftpPassword);
            // 設定 big5
            client.Encoding = Encoding.GetEncoding("big5");

            _filterList = new List<string>();
            if (cb_image.Checked)
            {
                _filterList.Add(".jpg");
                _filterList.Add(".jpeg");
                _filterList.Add(".bmp");
                _filterList.Add(".png");
                _filterList.Add(".tif");
                _filterList.Add(".heic");
            }
            if (cb_pdf.Checked)
            {
                _filterList.Add(".pdf");
            }
            if (cb_excel.Checked)
            {
                _filterList.Add(".xls");
                _filterList.Add(".xlsx");
                _filterList.Add(".xlsm");
                _filterList.Add(".csv");
            }
            if (cb_txt.Checked)
            {
                _filterList.Add(".txt");
            }

            _ftpFilesList = new List<string>();
            try
            {
                foreach (FtpListItem item in await client.GetListingAsync(ftpFolderPath))
                {
                    var extenstion = Path.GetExtension(item.Name).ToLower();
                    if (_filterList.Contains(extenstion))
                    {
                        _ftpFilesList.Add(item.Name);
                        var listViewItem = new ListViewItem(new[] {item.Name, getFileType(extenstion)});
                        lv_files.Items.Add(listViewItem);

                        lv_files.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lv_files.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }

                lb_filesCount.Text = $"總共有 {_ftpFilesList.Count} 個檔案";
                if (_filterList.Count > 0)
                {
                    btn_exportTxt.Enabled = true;
                    btn_diff.Enabled = true;
                    tb_localPath.ReadOnly = false;
                }
                else
                {
                    btn_exportTxt.Enabled = false;
                    btn_ExportDiff.Enabled = false;
                    btn_diff.Enabled = false;
                    tb_localPath.ReadOnly = true;
                }
            }
            catch (FtpAuthenticationException)
            {
                MessageBox.Show("FTP 帳號或密碼錯誤, 請再次確認!", "錯誤");
            }
            catch
            {
                MessageBox.Show("路徑錯誤, 請再次確認!", "錯誤");
            }
        }

        private string getFileType(string extenstion)
        {
            switch (extenstion)
            {
                case ".jpg":
                case ".jpeg":
                case ".bmp":
                case ".png":
                case ".tif":
                case ".heic":
                    return "圖片";
                case ".pdf":
                    return "PDF";
                case ".txt":
                    return "文字檔";
                case ".xls":
                case ".xlsx":
                case ".xlsm":
                case ".csv":
                    return "EXCEL";
                default:
                    return "";
            }
        }

        private void btn_diff_Click(object sender, EventArgs e)
        {
            lv_diff.Items.Clear();
            var localPath = tb_localPath.Text;
            if (tb_localPath.Text == "")
            {
                MessageBox.Show("請打上本地路徑");
                return;
            }

            try
            {
                DirectoryInfo localPathDirect = new DirectoryInfo(localPath);
                FileInfo[] files = localPathDirect.EnumerateFiles()
                    .Where(f => _filterList.Contains(f.Extension.ToLower())).ToArray();
                List<string> localFileList = new List<string>();
                foreach (FileInfo file in files)
                {
                    localFileList.Add(file.Name);
                }

                var localLeakResult = localFileList.Except(_ftpFilesList);
                foreach (var item in localLeakResult)
                {
                    var listViewItem = new ListViewItem(new[] {item, "FTP缺少"});
                    lv_diff.Items.Add(listViewItem);

                    lv_diff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lv_diff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }

                var ftpLeakResult = _ftpFilesList.Except(localFileList);
                foreach (var item in ftpLeakResult)
                {
                    var listViewItem = new ListViewItem(new[] {item, "本機缺少"});
                    lv_diff.Items.Add(listViewItem);

                    lv_diff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lv_diff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                btn_ExportDiff.Enabled = true;
            }
            catch
            {
                MessageBox.Show("本機路徑錯誤, 請檢查路徑是否有誤!","錯誤");
            }
        }

        private void btn_exportTxt_Click(object sender, EventArgs e)
        {
            string txtFileName = $"FTP結果_{DateTime.Now:yy_MM_dd_HH_mm}.txt";
            string path = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), txtFileName);


            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (var fileName in _ftpFilesList)
                {
                    sw.WriteLine(fileName);
                }
            }

            MessageBox.Show("匯出成功, 已儲存至桌面 !", "通知");
        }

        private void btn_ExportDiff_Click(object sender, EventArgs e)
        {
            string txtFileName = $"比對結果_{DateTime.Now:yy_MM_dd_HH_mm}.txt";
            string path = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), txtFileName);


            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("本機缺少:");
                foreach (ListViewItem item in lv_diff.Items)
                {
                    if (item.SubItems[1].Text == "本機缺少")
                    {
                        sw.WriteLine(item.SubItems[0].Text);
                    }
                }
                sw.WriteLine(Environment.NewLine);
                sw.WriteLine(Environment.NewLine);
                sw.WriteLine("FTP缺少:");
                foreach (ListViewItem item in lv_diff.Items)
                {
                    if (item.SubItems[1].Text == "FTP缺少")
                    {
                        sw.WriteLine(item.SubItems[0].Text);
                    }
                }
            }

            MessageBox.Show("匯出成功, 已儲存至桌面 !", "通知");
        }
    }
}
