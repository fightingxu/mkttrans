using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace gzdemo
{
    public partial class FormCfg : Form
    {
        private String sDbConn;
        private int iSleeptTime;
        private String sFile;
        private String sTable;
        private int iCommitCount;
        const string cfgname = "mktcfg.ini";// 默认配置文件
        public String DbConn
        {
            get
            {
                return this.sDbConn;
            }
            set
            {
                this.sDbConn = value;
            }
        }

        public int SleeptTime
        {
            get
            {
                return this.iSleeptTime;
            }
            set
            {
                this.iSleeptTime = value;
            }
        }

        public String File
        {
            get
            {
                return this.sFile;
            }
            set
            {
                this.sFile = value;
            }
        }

        public String Table
        {
            get
            {
                return this.sTable;
            }
            set
            {
                this.sTable = value;
            }
        }

        public int CommitCount
        {
            get
            {
                return this.iCommitCount;
            }
            set
            {
                this.iCommitCount = value;
            }
        }

        public FormCfg()
        {
            InitializeComponent();
        }

        // 初始化赋值
        public void initForm()
        {
            IniFiles infile = new IniFiles(Properties.Resources.cfgname);// 读取默认配置文件mktcfg.ini

            this.textDbConn.Text = this.sDbConn = infile.DbConn;
            // 读取睡眠时间
            this.iSleeptTime = infile.SleeptTime;
            this.textSleepTime.Text = this.iSleeptTime.ToString();
            // 读取睡眠时间结束

            this.textTableName.Text = this.sTable = infile.Table;
            // 读取提交频率
            this.iCommitCount = infile.CommitCount;
            this.textCommitCount.Text = this.iCommitCount.ToString();
            // 读取提交频率结束

            this.sFile = infile.File;
            this.textFile.Text = this.sFile;

        }

        private void FormCfg_Load(object sender, EventArgs e)
        {
            // 判断文件是否存在
            FileInfo fileInfo = new FileInfo("mktcfg.ini");
            if (!(fileInfo.Exists))
            {
                Console.WriteLine("Not Exists");
            }
        }

        private void textFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            if (this.textDbConn.Text != this.sDbConn || this.textSleepTime.Text != this.iSleeptTime.ToString() ||
                  this.textTableName.Text != this.sTable || this.textCommitCount.Text != this.iCommitCount.ToString() || this.textFile.Text != this.sFile)
            {
                if (MessageBox.Show("修改还未保存, 要保存并退出吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    activeSettings();
                    saveSettings();
                    MessageBox.Show("保存成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            activeSettings();
            saveSettings();
            MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void activeSettings()
        {
            this.sDbConn = this.textDbConn.Text;
            this.iSleeptTime = Convert.ToInt32(this.textSleepTime.Text);
            this.sTable = this.textTableName.Text;
            this.iCommitCount = Convert.ToInt32(this.textCommitCount.Text);
            this.sFile = this.textFile.Text;
        }

        private void saveSettings()
        {
            IniFiles ini = new IniFiles(Properties.Resources.cfgname);
            ini.WriteString("SYSTEM", "Database", this.sDbConn);
            ini.WriteInteger("SYSTEM", "SLEEPTIME", this.iSleeptTime);
            ini.WriteString("SYSTEM", "Table", this.sTable);
            ini.WriteInteger("SYSTEM", "CommitCount", this.CommitCount);
            ini.WriteString("SYSTEM", "FILE", this.sFile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.folderBrowserFilePath.ShowDialog();
            this.txt_Path.Text = this.folderBrowserFilePath.SelectedPath;
        }

    }
}
