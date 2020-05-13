namespace ModifyFileTime
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FilePath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnModifyCreationTime = new System.Windows.Forms.Button();
            this.btnModifyLastWriteTime = new System.Windows.Forms.Button();
            this.btnModifyLastAccessTime = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(32, 28);
            this.FilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(98, 18);
            this.FilePath.TabIndex = 0;
            this.FilePath.Text = "文件路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "访问时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "写入时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "创建时间：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(598, 28);
            this.textBox1.TabIndex = 1;
            // 
            // btnModifyCreationTime
            // 
            this.btnModifyCreationTime.Location = new System.Drawing.Point(380, 76);
            this.btnModifyCreationTime.Name = "btnModifyCreationTime";
            this.btnModifyCreationTime.Size = new System.Drawing.Size(75, 28);
            this.btnModifyCreationTime.TabIndex = 12;
            this.btnModifyCreationTime.Text = "修改";
            this.btnModifyCreationTime.UseVisualStyleBackColor = true;
            this.btnModifyCreationTime.Click += new System.EventHandler(this.btnModifyCreationTime_Click);
            // 
            // btnModifyLastWriteTime
            // 
            this.btnModifyLastWriteTime.Location = new System.Drawing.Point(380, 127);
            this.btnModifyLastWriteTime.Name = "btnModifyLastWriteTime";
            this.btnModifyLastWriteTime.Size = new System.Drawing.Size(75, 28);
            this.btnModifyLastWriteTime.TabIndex = 13;
            this.btnModifyLastWriteTime.Text = "修改";
            this.btnModifyLastWriteTime.UseVisualStyleBackColor = true;
            this.btnModifyLastWriteTime.Click += new System.EventHandler(this.btnModifyLastWriteTime_Click);
            // 
            // btnModifyLastAccessTime
            // 
            this.btnModifyLastAccessTime.Location = new System.Drawing.Point(380, 183);
            this.btnModifyLastAccessTime.Name = "btnModifyLastAccessTime";
            this.btnModifyLastAccessTime.Size = new System.Drawing.Size(75, 28);
            this.btnModifyLastAccessTime.TabIndex = 14;
            this.btnModifyLastAccessTime.Text = "修改";
            this.btnModifyLastAccessTime.UseVisualStyleBackColor = true;
            this.btnModifyLastAccessTime.Click += new System.EventHandler(this.btnModifyLastAccessTime_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(138, 76);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(212, 28);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(138, 127);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(212, 28);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(138, 179);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(212, 28);
            this.dateTimePicker4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(656, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "修改无意义，当修改创建和写入时间时，访问时间会自动修改为计算机此时的时间";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1133, 239);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.btnModifyCreationTime);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModifyLastAccessTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModifyLastWriteTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifyFileTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifyLastAccessTime;
        private System.Windows.Forms.Button btnModifyLastWriteTime;
        private System.Windows.Forms.Button btnModifyCreationTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label5;
    }
}

