namespace URLFUZZ
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_URLFUZZ = new System.Windows.Forms.GroupBox();
            this.listBox_URLFUZZ_Payload = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_URLFUZZ_URL = new System.Windows.Forms.TextBox();
            this.checkBox_URLFUZZ_CUSTOM = new System.Windows.Forms.CheckBox();
            this.button_URLFUZZ_FUZZ = new System.Windows.Forms.Button();
            this.textBox_URLFUZZ_CUSTOM = new System.Windows.Forms.TextBox();
            this.checkBox_URLFUZZ_NODOMAIN = new System.Windows.Forms.CheckBox();
            this.checkBox_URLFUZZ_REMOVE = new System.Windows.Forms.CheckBox();
            this.button_URLFUZZ_CLEAR = new System.Windows.Forms.Button();
            this.button_URLFUZZ_SAVE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_URLFUZZ_REPLACE1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_URLFUZZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_URLFUZZ);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 559);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_URLFUZZ_REPLACE1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_URLFUZZ_SAVE);
            this.groupBox1.Controls.Add(this.button_URLFUZZ_CLEAR);
            this.groupBox1.Controls.Add(this.checkBox_URLFUZZ_REMOVE);
            this.groupBox1.Controls.Add(this.checkBox_URLFUZZ_NODOMAIN);
            this.groupBox1.Controls.Add(this.textBox_URLFUZZ_CUSTOM);
            this.groupBox1.Controls.Add(this.button_URLFUZZ_FUZZ);
            this.groupBox1.Controls.Add(this.checkBox_URLFUZZ_CUSTOM);
            this.groupBox1.Controls.Add(this.textBox_URLFUZZ_URL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox_URLFUZZ
            // 
            this.groupBox_URLFUZZ.Controls.Add(this.listBox_URLFUZZ_Payload);
            this.groupBox_URLFUZZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_URLFUZZ.Location = new System.Drawing.Point(0, 0);
            this.groupBox_URLFUZZ.Name = "groupBox_URLFUZZ";
            this.groupBox_URLFUZZ.Size = new System.Drawing.Size(550, 559);
            this.groupBox_URLFUZZ.TabIndex = 1;
            this.groupBox_URLFUZZ.TabStop = false;
            // 
            // listBox_URLFUZZ_Payload
            // 
            this.listBox_URLFUZZ_Payload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_URLFUZZ_Payload.FormattingEnabled = true;
            this.listBox_URLFUZZ_Payload.HorizontalScrollbar = true;
            this.listBox_URLFUZZ_Payload.ItemHeight = 12;
            this.listBox_URLFUZZ_Payload.Location = new System.Drawing.Point(3, 17);
            this.listBox_URLFUZZ_Payload.Name = "listBox_URLFUZZ_Payload";
            this.listBox_URLFUZZ_Payload.Size = new System.Drawing.Size(544, 539);
            this.listBox_URLFUZZ_Payload.TabIndex = 0;
            this.listBox_URLFUZZ_Payload.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_URLFUZZ_Payload_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // textBox_URLFUZZ_URL
            // 
            this.textBox_URLFUZZ_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_URLFUZZ_URL.Location = new System.Drawing.Point(47, 20);
            this.textBox_URLFUZZ_URL.Name = "textBox_URLFUZZ_URL";
            this.textBox_URLFUZZ_URL.Size = new System.Drawing.Size(469, 21);
            this.textBox_URLFUZZ_URL.TabIndex = 1;
            this.textBox_URLFUZZ_URL.Text = "http://192.168.10.23/public/upload/files/111.jpg";
            // 
            // checkBox_URLFUZZ_CUSTOM
            // 
            this.checkBox_URLFUZZ_CUSTOM.AutoSize = true;
            this.checkBox_URLFUZZ_CUSTOM.Checked = true;
            this.checkBox_URLFUZZ_CUSTOM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_URLFUZZ_CUSTOM.Location = new System.Drawing.Point(47, 49);
            this.checkBox_URLFUZZ_CUSTOM.Name = "checkBox_URLFUZZ_CUSTOM";
            this.checkBox_URLFUZZ_CUSTOM.Size = new System.Drawing.Size(90, 16);
            this.checkBox_URLFUZZ_CUSTOM.TabIndex = 2;
            this.checkBox_URLFUZZ_CUSTOM.Text = "Custom Rule";
            this.checkBox_URLFUZZ_CUSTOM.UseVisualStyleBackColor = true;
            // 
            // button_URLFUZZ_FUZZ
            // 
            this.button_URLFUZZ_FUZZ.Location = new System.Drawing.Point(47, 176);
            this.button_URLFUZZ_FUZZ.Name = "button_URLFUZZ_FUZZ";
            this.button_URLFUZZ_FUZZ.Size = new System.Drawing.Size(111, 34);
            this.button_URLFUZZ_FUZZ.TabIndex = 3;
            this.button_URLFUZZ_FUZZ.Text = "FUZZ";
            this.button_URLFUZZ_FUZZ.UseVisualStyleBackColor = true;
            this.button_URLFUZZ_FUZZ.Click += new System.EventHandler(this.button_URLFUZZ_FUZZ_Click);
            // 
            // textBox_URLFUZZ_CUSTOM
            // 
            this.textBox_URLFUZZ_CUSTOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_URLFUZZ_CUSTOM.Location = new System.Drawing.Point(143, 47);
            this.textBox_URLFUZZ_CUSTOM.Name = "textBox_URLFUZZ_CUSTOM";
            this.textBox_URLFUZZ_CUSTOM.Size = new System.Drawing.Size(373, 21);
            this.textBox_URLFUZZ_CUSTOM.TabIndex = 4;
            this.textBox_URLFUZZ_CUSTOM.Text = "/search/%2e%2e/";
            // 
            // checkBox_URLFUZZ_NODOMAIN
            // 
            this.checkBox_URLFUZZ_NODOMAIN.AutoSize = true;
            this.checkBox_URLFUZZ_NODOMAIN.Checked = true;
            this.checkBox_URLFUZZ_NODOMAIN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_URLFUZZ_NODOMAIN.Location = new System.Drawing.Point(47, 81);
            this.checkBox_URLFUZZ_NODOMAIN.Name = "checkBox_URLFUZZ_NODOMAIN";
            this.checkBox_URLFUZZ_NODOMAIN.Size = new System.Drawing.Size(78, 16);
            this.checkBox_URLFUZZ_NODOMAIN.TabIndex = 5;
            this.checkBox_URLFUZZ_NODOMAIN.Text = "No Domain";
            this.checkBox_URLFUZZ_NODOMAIN.UseVisualStyleBackColor = true;
            // 
            // checkBox_URLFUZZ_REMOVE
            // 
            this.checkBox_URLFUZZ_REMOVE.AutoSize = true;
            this.checkBox_URLFUZZ_REMOVE.Checked = true;
            this.checkBox_URLFUZZ_REMOVE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_URLFUZZ_REMOVE.Location = new System.Drawing.Point(47, 103);
            this.checkBox_URLFUZZ_REMOVE.Name = "checkBox_URLFUZZ_REMOVE";
            this.checkBox_URLFUZZ_REMOVE.Size = new System.Drawing.Size(168, 16);
            this.checkBox_URLFUZZ_REMOVE.TabIndex = 6;
            this.checkBox_URLFUZZ_REMOVE.Text = "Remove NoStartsWith(\"/\")";
            this.checkBox_URLFUZZ_REMOVE.UseVisualStyleBackColor = true;
            // 
            // button_URLFUZZ_CLEAR
            // 
            this.button_URLFUZZ_CLEAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_URLFUZZ_CLEAR.Location = new System.Drawing.Point(405, 513);
            this.button_URLFUZZ_CLEAR.Name = "button_URLFUZZ_CLEAR";
            this.button_URLFUZZ_CLEAR.Size = new System.Drawing.Size(111, 34);
            this.button_URLFUZZ_CLEAR.TabIndex = 7;
            this.button_URLFUZZ_CLEAR.Text = "CLEAR";
            this.button_URLFUZZ_CLEAR.UseVisualStyleBackColor = true;
            this.button_URLFUZZ_CLEAR.Click += new System.EventHandler(this.button_URLFUZZ_CLEAR_Click);
            // 
            // button_URLFUZZ_SAVE
            // 
            this.button_URLFUZZ_SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_URLFUZZ_SAVE.Location = new System.Drawing.Point(405, 473);
            this.button_URLFUZZ_SAVE.Name = "button_URLFUZZ_SAVE";
            this.button_URLFUZZ_SAVE.Size = new System.Drawing.Size(111, 34);
            this.button_URLFUZZ_SAVE.TabIndex = 8;
            this.button_URLFUZZ_SAVE.Text = "SAVE";
            this.button_URLFUZZ_SAVE.UseVisualStyleBackColor = true;
            this.button_URLFUZZ_SAVE.Click += new System.EventHandler(this.button_URLFUZZ_SAVE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "[*]DoubleClick item of listbox send data to Clipboard.";
            // 
            // checkBox_URLFUZZ_REPLACE1
            // 
            this.checkBox_URLFUZZ_REPLACE1.AutoSize = true;
            this.checkBox_URLFUZZ_REPLACE1.Location = new System.Drawing.Point(47, 125);
            this.checkBox_URLFUZZ_REPLACE1.Name = "checkBox_URLFUZZ_REPLACE1";
            this.checkBox_URLFUZZ_REPLACE1.Size = new System.Drawing.Size(72, 16);
            this.checkBox_URLFUZZ_REPLACE1.TabIndex = 10;
            this.checkBox_URLFUZZ_REPLACE1.Text = ". -> %2e";
            this.checkBox_URLFUZZ_REPLACE1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 559);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URLFUZZ v 1.0 By T00ls.Net";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_URLFUZZ.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_URLFUZZ;
        private System.Windows.Forms.ListBox listBox_URLFUZZ_Payload;
        private System.Windows.Forms.Button button_URLFUZZ_FUZZ;
        private System.Windows.Forms.CheckBox checkBox_URLFUZZ_CUSTOM;
        private System.Windows.Forms.TextBox textBox_URLFUZZ_URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_URLFUZZ_CUSTOM;
        private System.Windows.Forms.CheckBox checkBox_URLFUZZ_NODOMAIN;
        private System.Windows.Forms.CheckBox checkBox_URLFUZZ_REMOVE;
        private System.Windows.Forms.Button button_URLFUZZ_SAVE;
        private System.Windows.Forms.Button button_URLFUZZ_CLEAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_URLFUZZ_REPLACE1;
    }
}

