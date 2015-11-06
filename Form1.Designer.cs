namespace ChangeCodeTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnUnicode = new System.Windows.Forms.Button();
            this.btnSelectTargetPath = new System.Windows.Forms.Button();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.chkUsingWord = new System.Windows.Forms.CheckBox();
            this.btnCovertFolder = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTransWord = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnStoT = new System.Windows.Forms.Button();
            this.btnTtoS = new System.Windows.Forms.Button();
            this.txtTaget = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkFileUsingWord = new System.Windows.Forms.CheckBox();
            this.btnCovertFile = new System.Windows.Forms.Button();
            this.txtFileResult = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnUnicode);
            this.groupBox1.Controls.Add(this.btnSelectTargetPath);
            this.groupBox1.Controls.Add(this.txtTargetPath);
            this.groupBox1.Controls.Add(this.chkUsingWord);
            this.groupBox1.Controls.Add(this.btnCovertFolder);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.txtFolderPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能1:將資料夾下所有檔案轉換編碼";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(216, 198);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 12);
            this.lblStatus.TabIndex = 8;
            // 
            // btnUnicode
            // 
            this.btnUnicode.Location = new System.Drawing.Point(19, 181);
            this.btnUnicode.Name = "btnUnicode";
            this.btnUnicode.Size = new System.Drawing.Size(191, 29);
            this.btnUnicode.TabIndex = 7;
            this.btnUnicode.Text = "將BIG5檔案轉換為UTF-8編碼";
            this.btnUnicode.UseVisualStyleBackColor = true;
            this.btnUnicode.Click += new System.EventHandler(this.btnUnicode_Click);
            // 
            // btnSelectTargetPath
            // 
            this.btnSelectTargetPath.Location = new System.Drawing.Point(217, 106);
            this.btnSelectTargetPath.Name = "btnSelectTargetPath";
            this.btnSelectTargetPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTargetPath.TabIndex = 6;
            this.btnSelectTargetPath.Text = "選擇資料夾";
            this.btnSelectTargetPath.UseVisualStyleBackColor = true;
            this.btnSelectTargetPath.Click += new System.EventHandler(this.btnSelectTargetPath_Click);
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Location = new System.Drawing.Point(19, 106);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(191, 22);
            this.txtTargetPath.TabIndex = 5;
            this.txtTargetPath.Text = "D:\\WebManager\\WebNew";
            // 
            // chkUsingWord
            // 
            this.chkUsingWord.AutoSize = true;
            this.chkUsingWord.Location = new System.Drawing.Point(234, 158);
            this.chkUsingWord.Name = "chkUsingWord";
            this.chkUsingWord.Size = new System.Drawing.Size(96, 16);
            this.chkUsingWord.TabIndex = 4;
            this.chkUsingWord.Text = "使用語意轉換";
            this.chkUsingWord.UseVisualStyleBackColor = true;
            this.chkUsingWord.CheckedChanged += new System.EventHandler(this.chkUsingWord_CheckedChanged);
            // 
            // btnCovertFolder
            // 
            this.btnCovertFolder.Location = new System.Drawing.Point(19, 143);
            this.btnCovertFolder.Name = "btnCovertFolder";
            this.btnCovertFolder.Size = new System.Drawing.Size(191, 31);
            this.btnCovertFolder.TabIndex = 3;
            this.btnCovertFolder.Text = "將檔案皆轉為簡體中文";
            this.btnCovertFolder.UseVisualStyleBackColor = true;
            this.btnCovertFolder.Click += new System.EventHandler(this.btnCovertFolder_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(217, 55);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "選擇資料夾";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(18, 57);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(192, 22);
            this.txtFolderPath.TabIndex = 1;
            this.txtFolderPath.Text = "D:\\WebManager\\Web";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇的目錄資料夾";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTransWord);
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.btnStoT);
            this.groupBox2.Controls.Add(this.btnTtoS);
            this.groupBox2.Controls.Add(this.txtTaget);
            this.groupBox2.Location = new System.Drawing.Point(440, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 505);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能2:文字繁簡互轉";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTransWord
            // 
            this.btnTransWord.Location = new System.Drawing.Point(263, 225);
            this.btnTransWord.Name = "btnTransWord";
            this.btnTransWord.Size = new System.Drawing.Size(133, 39);
            this.btnTransWord.TabIndex = 4;
            this.btnTransWord.Text = "語意轉換(WORD)";
            this.btnTransWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransWord.UseVisualStyleBackColor = true;
            this.btnTransWord.Click += new System.EventHandler(this.btnTransWord_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(25, 304);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(371, 181);
            this.txtResult.TabIndex = 3;
            // 
            // btnStoT
            // 
            this.btnStoT.Location = new System.Drawing.Point(156, 225);
            this.btnStoT.Name = "btnStoT";
            this.btnStoT.Size = new System.Drawing.Size(101, 39);
            this.btnStoT.TabIndex = 2;
            this.btnStoT.Text = "簡轉繁";
            this.btnStoT.UseVisualStyleBackColor = true;
            this.btnStoT.Click += new System.EventHandler(this.btnStoT_Click);
            // 
            // btnTtoS
            // 
            this.btnTtoS.Location = new System.Drawing.Point(25, 225);
            this.btnTtoS.Name = "btnTtoS";
            this.btnTtoS.Size = new System.Drawing.Size(125, 39);
            this.btnTtoS.TabIndex = 1;
            this.btnTtoS.Text = "繁轉簡";
            this.btnTtoS.UseVisualStyleBackColor = true;
            this.btnTtoS.Click += new System.EventHandler(this.btnTtoS_Click);
            // 
            // txtTaget
            // 
            this.txtTaget.Location = new System.Drawing.Point(25, 40);
            this.txtTaget.Multiline = true;
            this.txtTaget.Name = "txtTaget";
            this.txtTaget.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTaget.Size = new System.Drawing.Size(371, 156);
            this.txtTaget.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.chkFileUsingWord);
            this.groupBox3.Controls.Add(this.btnCovertFile);
            this.groupBox3.Controls.Add(this.txtFileResult);
            this.groupBox3.Controls.Add(this.btnSelectFile);
            this.groupBox3.Location = new System.Drawing.Point(13, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 272);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能3:單檔轉換";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ANSI",
            "UNICODE"});
            this.comboBox1.Location = new System.Drawing.Point(262, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // chkFileUsingWord
            // 
            this.chkFileUsingWord.AutoSize = true;
            this.chkFileUsingWord.Location = new System.Drawing.Point(160, 39);
            this.chkFileUsingWord.Name = "chkFileUsingWord";
            this.chkFileUsingWord.Size = new System.Drawing.Size(96, 16);
            this.chkFileUsingWord.TabIndex = 4;
            this.chkFileUsingWord.Text = "使用語意轉換";
            this.chkFileUsingWord.UseVisualStyleBackColor = true;
            // 
            // btnCovertFile
            // 
            this.btnCovertFile.Location = new System.Drawing.Point(18, 50);
            this.btnCovertFile.Name = "btnCovertFile";
            this.btnCovertFile.Size = new System.Drawing.Size(136, 23);
            this.btnCovertFile.TabIndex = 3;
            this.btnCovertFile.Text = "選檔案,轉繁體";
            this.btnCovertFile.UseVisualStyleBackColor = true;
            this.btnCovertFile.Click += new System.EventHandler(this.btnCovertFile_Click);
            // 
            // txtFileResult
            // 
            this.txtFileResult.Location = new System.Drawing.Point(17, 79);
            this.txtFileResult.Multiline = true;
            this.txtFileResult.Name = "txtFileResult";
            this.txtFileResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileResult.Size = new System.Drawing.Size(366, 173);
            this.txtFileResult.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(17, 21);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(137, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "選檔案,轉簡體";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "繁簡互轉工具V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCovertFolder;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnStoT;
        private System.Windows.Forms.Button btnTtoS;
        private System.Windows.Forms.TextBox txtTaget;
        private System.Windows.Forms.Button btnTransWord;
        private System.Windows.Forms.Button btnSelectTargetPath;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.CheckBox chkUsingWord;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.CheckBox chkFileUsingWord;
        private System.Windows.Forms.Button btnCovertFile;
        private System.Windows.Forms.TextBox txtFileResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUnicode;
        private System.Windows.Forms.Label lblStatus;
    }
}

