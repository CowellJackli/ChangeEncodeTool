using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;

namespace ChangeCodeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtFolderPath.Text;
            folderBrowserDialog1.ShowDialog();
            txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void btnTtoS_Click(object sender, EventArgs e)
        {
            string src = txtTaget.Text.Trim();
            txtResult.Text = ChineseConverter.ToSimplified(src);
        }

        private void btnStoT_Click(object sender, EventArgs e)
        {
            string src = txtTaget.Text.Trim();
            txtResult.Text = ChineseConverter.ToTraditional(src);
        }

        private void btnTransWord_Click(object sender, EventArgs e)
        {
            string src = txtTaget.Text.Trim();
            txtResult.Text = ChineseConverter.ConvertUsingWord(src, true);
        }

        private void btnSelectTargetPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.SelectedPath = txtTargetPath.Text;
            folderBrowserDialog2.ShowDialog();
            txtTargetPath.Text = folderBrowserDialog2.SelectedPath;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Stream fileStream = openFileDialog1.OpenFile();
            string fileFormate = (comboBox1.SelectedItem.ToString() == "ANSI") ? "BIG5" : "UTF-8";

            using (StreamReader reader = new StreamReader(fileStream, Encoding.GetEncoding(fileFormate)))
            {
                // Read the first line from the file and write it the textbox.
                txtFileResult.Text = reader.ReadToEnd();
                if (chkFileUsingWord.Checked)
                    txtFileResult.Text = ChineseConverter.ConvertUsingWord(txtFileResult.Text, true);
                else
                    txtFileResult.Text = ChineseConverter.ToSimplified(txtFileResult.Text);

            }
            fileStream.Close();
        }

        private void btnCovertFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Stream fileStream = openFileDialog1.OpenFile();

            string fileFormate = (comboBox1.SelectedItem.ToString() == "ANSI") ? "GB2312" : "UTF-8";

            using (StreamReader reader = new StreamReader(fileStream, Encoding.GetEncoding(fileFormate)))
            {
                // Read the first line from the file and write it the textbox.
                string result = reader.ReadToEnd();
                if (chkFileUsingWord.Checked)
                    txtFileResult.Text = ChineseConverter.ConvertUsingWord(result, false);
                else
                    txtFileResult.Text = ChineseConverter.ToTraditional(result);


            }
            fileStream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "ANSI");
            comboBox1.Items.Insert(1, "Unicode");
            comboBox1.SelectedText = "ANSI";
            //comboBox1.Select(0, 1);
        }

        private void btnCovertFolder_Click(object sender, EventArgs e)
        {
            string src = txtFolderPath.Text; //來源資料夾
            string target = txtTargetPath.Text; //目的資料夾

            foreach (string fileName in Directory.GetFiles(src, "*", SearchOption.AllDirectories))
            {
                FileInfo fi = new FileInfo(fileName);
                string targetPath = target + @"\" + fi.Name;
                //if (!File.Exists(target + @"\" + fi.Name))
                //{
                //    File.Create(target + @"\" + fi.Name);
                //}

                Stream fileStream = File.OpenRead(fileName);
                string result = string.Empty;
                using (StreamReader reader = new StreamReader(fileStream, Encoding.GetEncoding("BIG5")))
                {
                    // Read the first line from the file and write it the textbox.
                    result = ChineseConverter.ToSimplified(reader.ReadToEnd());
                }
                Stream targetFile = File.Open(targetPath, FileMode.OpenOrCreate);
                using (StreamWriter sw = new StreamWriter(targetFile, Encoding.GetEncoding("GB2312")))
                {
                    sw.Write(result);
                }
                targetFile.Close();
                fileStream.Close();
            }
        }

        private void chkUsingWord_CheckedChanged(object sender, EventArgs e)
        {

        }

        public int cnt = 1; //處理資料列
        public int totalFilesCnt = 0;
        bool copyFG = false;
        private void btnUnicode_Click(object sender, EventArgs e)
        {
            string src = txtFolderPath.Text; //來源資料夾
            string target = txtTargetPath.Text; //目的資料夾
            if (src == target)
                copyFG = false; //相同資料夾路徑表示使用覆蓋,不需要改編碼的檔案就不蓋了
            else
                copyFG = true;
            cnt = 1; //初始化
            Action<string, string, string> act = (x1, x2, x3) =>
            {
                CompareFileAndChangeCode(x1, x2, x3);
            };
            totalFilesCnt = Directory.GetFiles(src, "*", SearchOption.AllDirectories).Length;
            //先找是不是有子資料夾(根目錄)
            foreach (string DirPath in Directory.GetDirectories(src))
            {
                SearchAndFindDir(DirPath, target, act);
            }
            SearchAndDoEventByDir(src, target, act); //找當前資料夾下的檔案(TOP 第一次)
            GC.Collect();
        }
        private void SearchAndFindDir(string src, string target, Action<string, string, string> act)
        {
            foreach (string DirPath in Directory.GetDirectories(src))
            {
                SearchAndFindDir(DirPath, target, act); //遞迴,一直往下一層去
            }
            SearchAndDoEventByDir(src, target, act); //找當前資料夾下的檔案(第N次)
        }

        private void SearchAndDoEventByDir(string src, string target, Action<string, string, string> act)
        {
            //再找檔案,只找自己的資料夾
            foreach (string fileName in Directory.GetFiles(src, "*", SearchOption.TopDirectoryOnly))
            {
                act.Invoke(target, fileName, src.Replace(txtFolderPath.Text, ""));//僅有資料夾從選擇路徑起
                lblStatus.Text = string.Format("總數:{0},已處理{1}個檔案", totalFilesCnt, cnt);
                Application.DoEvents();
                cnt++;
            }
        }
        //偵測byte[]是否為BIG5編碼
        public static bool IsBig5Encoding(byte[] bytes)
        {
            Encoding big5 = Encoding.GetEncoding(950);
            //將byte[]轉為string再轉回byte[]看位元數是否有變
            return bytes.Length ==
                big5.GetByteCount(big5.GetString(bytes));
        }
        //偵測檔案否為BIG5編碼
        public static bool IsBig5Encoding(string file)
        {
            if (!File.Exists(file)) return false;
            return IsBig5Encoding(File.ReadAllBytes(file));
        }
        private void CompareFileAndChangeCode(string target, string fileName, string parnetDir)
        {
            FileInfo fi = new FileInfo(fileName);
            string dirPath = target + @"\" + parnetDir;
            string targetPath = target + @"\" + parnetDir + @"\" + fi.Name;

            if (!Directory.Exists(dirPath))
            {

                DirectoryInfo dinew = Directory.GetParent(fileName);
                DirectorySecurity ds = Directory.GetAccessControl(dinew.ToString());
                try
                {
                    Directory.CreateDirectory(dirPath, ds);
                }
                catch
                {
                    Directory.CreateDirectory(dirPath);
                }
            }

            //取得原先的屬性(唯獨)
            bool readOnlyFG = fi.IsReadOnly;
            if ((fi.Extension == ".asp" || fi.Extension == ".js" || fi.Extension == ".css" || fi.Extension == ".inc" || fi.Extension == ".txt" || fi.Extension == ".xml" || fi.Extension == ".html") && IsBig5Encoding(fileName))
            {
                fi.Attributes = FileAttributes.Normal;
                FileSecurity fsec = File.GetAccessControl(fi.FullName);
                Stream fileStream = File.OpenRead(fileName);
                StringBuilder result = new StringBuilder();
                string tmpstr = string.Empty;
                using (StreamReader reader = new StreamReader(fileStream, Encoding.GetEncoding("BIG5")))
                {
                    // Read the first line from the file and write it the textbox.
                    while ((tmpstr = reader.ReadLine()) != null)
                    {

                        if (!string.IsNullOrEmpty(tmpstr))
                        {
                            if (tmpstr.ToUpper().IndexOf("NO PARSE") >= 0)
                            {
                                //具備不轉換特殊字的提示,則自動不轉換
                                result.AppendLine(tmpstr);
                            }
                            else
                            {
                                if (tmpstr.ToUpper().IndexOf("EGRPDSN.INC") >= 0 && tmpstr.ToLower().IndexOf("<!--#include") >= 0)
                                {
                                    tmpstr = tmpstr.ToUpper().Replace("EGRPDSN.INC", "egrpDSN_binary.inc");
                                }

                                if ((tmpstr.ToLower().IndexOf("charset") >= 0 || tmpstr.ToLower().IndexOf("encoding") >= 0) && tmpstr.ToLower().IndexOf("big5") >= 0)
                                {
                                    tmpstr = tmpstr.ToLower().Replace("big5", "UTF-8");
                                }

                                //直接該行略過不處理 Response.CodePage,egrpDSN要處理所以不過濾
                                if ((tmpstr.ToLower().IndexOf("response.codepage") >= 0 || tmpstr.ToLower().IndexOf("response.charset") >= 0 || tmpstr.ToLower().IndexOf("@charset") >= 0 || tmpstr.ToLower().IndexOf(@"<%@") >= 0 || tmpstr.ToLower().IndexOf(@"session.codepage") >= 0) && fi.Name.ToLower().ToString().Trim() != "egrpdsn_binary.inc")
                                {
                                    tmpstr = "";//tmpstr = @"'" + tmpstr.ToLower();
                                }
                                if (tmpstr.ToLower().IndexOf("decbinaryforbig5(") >= 0 && tmpstr.ToLower().IndexOf("function") < 0)
                                {
                                    //DecBinaryForBig5(xmlHttp.responseBody))
                                    if (tmpstr.ToLower().IndexOf("responsebody") >= 0)
                                    {
                                        tmpstr = tmpstr.ToLower().Replace("responsebody", "responseText").Replace("decbinaryforbig5", "");
                                    }
                                    else
                                    {
                                        tmpstr = tmpstr.ToLower().Replace("decbinaryforbig5", "");
                                    }
                                }
                                //SAFileup的調整 SoftArtisans.FileUp
                                string strSafileUp = "";
                                if (tmpstr.ToLower().IndexOf("\"softartisans.fileup\"") >= 0 && tmpstr.ToLower().IndexOf("set") >= 0)
                                {

                                    foreach (string strSafileup in tmpstr.ToLower().Replace("=", " = ").Split(' '))
                                    {
                                        if (strSafileup.Trim() != "set" && strSafileup != "server.createObject" && strSafileup.Trim() != "" && !string.IsNullOrEmpty(strSafileup))
                                        {
                                            strSafileUp = string.Format("   {0}.CodePage = 65001", strSafileup.Trim());
                                            break; ; //離開
                                        }
                                    }
                                }
                                if (tmpstr != "")
                                {
                                    result.AppendLine(tmpstr);
                                }

                                if (strSafileUp != "")
                                    result.AppendLine(strSafileUp);
                            }
                        }
                    }

                }

                Stream targetFile = File.Open(targetPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamWriter sw = new StreamWriter(targetFile, Encoding.GetEncoding("UTF-8")))
                {
                    sw.Write(result);
                }
                targetFile.Close();
                fileStream.Close();
                result.Clear();
                try
                {
                    //將權限綁定回去
                    FileInfo fi2 = new FileInfo(targetPath);
                    fi2.SetAccessControl(fsec);
                }
                catch
                {

                }

            }
            else
            {
                //非管制範圍內的檔案,將檔案直接搬移過來
                //解除唯讀
                //FileInfo fi2 = new FileInfo(targetPath);
                //fi2.Attributes = FileAttributes.Normal;
                if (copyFG)
                    fi.CopyTo(targetPath, true); //就全轉了不要去改屬性(不知道屬性會有什麼問題)
                //fi2.Attributes = FileAttributes.ReadOnly;//改為唯讀
            }
            //原先是唯讀檔案的才處理
            if (readOnlyFG)
                fi.Attributes = FileAttributes.ReadOnly;
            else
                fi.Attributes = FileAttributes.Normal;

        }

    }
}
