namespace gzdemo
{
    partial class FormCfg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textDbConn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSleepTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTableName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCommitCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFile = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.folderBrowserFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库连接:";
            // 
            // textDbConn
            // 
            this.textDbConn.Location = new System.Drawing.Point(196, 50);
            this.textDbConn.Name = "textDbConn";
            this.textDbConn.Size = new System.Drawing.Size(122, 21);
            this.textDbConn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "睡眠时间:";
            // 
            // textSleepTime
            // 
            this.textSleepTime.Location = new System.Drawing.Point(196, 87);
            this.textSleepTime.Name = "textSleepTime";
            this.textSleepTime.Size = new System.Drawing.Size(122, 21);
            this.textSleepTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "插入表名:";
            // 
            // textTableName
            // 
            this.textTableName.Location = new System.Drawing.Point(196, 127);
            this.textTableName.Name = "textTableName";
            this.textTableName.Size = new System.Drawing.Size(122, 21);
            this.textTableName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "事务提交频率:";
            // 
            // textCommitCount
            // 
            this.textCommitCount.Location = new System.Drawing.Point(196, 168);
            this.textCommitCount.Name = "textCommitCount";
            this.textCommitCount.Size = new System.Drawing.Size(122, 21);
            this.textCommitCount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "录入文件名称:";
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(196, 217);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(122, 21);
            this.textFile.TabIndex = 10;
            this.textFile.TextChanged += new System.EventHandler(this.textFile_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(80, 290);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.buttonExit.Location = new System.Drawing.Point(252, 290);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(196, 248);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(284, 21);
            this.txt_Path.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "文件路径:";
            // 
            // FormCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCommitCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTableName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSleepTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDbConn);
            this.Controls.Add(this.label1);
            this.Name = "FormCfg";
            this.Text = "配置";
            this.Load += new System.EventHandler(this.FormCfg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDbConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSleepTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCommitCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label label6;
    }
}