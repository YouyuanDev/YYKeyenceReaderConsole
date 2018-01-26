namespace YYKeyenceReaderConsole
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
            this.CommandPortInput = new System.Windows.Forms.TextBox();
            this.DataPortInput = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.lon = new System.Windows.Forms.Button();
            this.loff = new System.Windows.Forms.Button();
            this.receive = new System.Windows.Forms.Button();
            this.textBox_LogConsole = new System.Windows.Forms.TextBox();
            this.textbox_DataConsole = new System.Windows.Forms.TextBox();
            this.button_FTune = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.listBox_Reader = new System.Windows.Forms.ListBox();
            this.button_Tune = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommandPortInput
            // 
            this.CommandPortInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.CommandPortInput.Location = new System.Drawing.Point(872, 27);
            this.CommandPortInput.MaxLength = 5;
            this.CommandPortInput.Name = "CommandPortInput";
            this.CommandPortInput.Size = new System.Drawing.Size(57, 21);
            this.CommandPortInput.TabIndex = 23;
            // 
            // DataPortInput
            // 
            this.DataPortInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DataPortInput.Location = new System.Drawing.Point(1045, 27);
            this.DataPortInput.MaxLength = 5;
            this.DataPortInput.Name = "DataPortInput";
            this.DataPortInput.Size = new System.Drawing.Size(59, 21);
            this.DataPortInput.TabIndex = 25;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(789, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 12);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Command Port";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(960, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 12);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Data Port";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(791, 59);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(138, 62);
            this.connect.TabIndex = 28;
            this.connect.Text = "Connect All";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(948, 59);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(156, 62);
            this.disconnect.TabIndex = 29;
            this.disconnect.Text = "Disconnect All";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // lon
            // 
            this.lon.Location = new System.Drawing.Point(852, 336);
            this.lon.Name = "lon";
            this.lon.Size = new System.Drawing.Size(189, 116);
            this.lon.TabIndex = 30;
            this.lon.Text = "Trigger LON";
            this.lon.UseVisualStyleBackColor = true;
            this.lon.Click += new System.EventHandler(this.lon_Click);
            // 
            // loff
            // 
            this.loff.Location = new System.Drawing.Point(852, 483);
            this.loff.Name = "loff";
            this.loff.Size = new System.Drawing.Size(189, 104);
            this.loff.TabIndex = 31;
            this.loff.Text = "Trigger LOFF";
            this.loff.UseVisualStyleBackColor = true;
            this.loff.Click += new System.EventHandler(this.loff_Click);
            // 
            // receive
            // 
            this.receive.Location = new System.Drawing.Point(1025, 289);
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(79, 41);
            this.receive.TabIndex = 32;
            this.receive.Text = "Receive Data";
            this.receive.UseVisualStyleBackColor = true;
            this.receive.Visible = false;
            this.receive.Click += new System.EventHandler(this.receive_Click);
            // 
            // textBox_LogConsole
            // 
            this.textBox_LogConsole.Location = new System.Drawing.Point(25, 27);
            this.textBox_LogConsole.Multiline = true;
            this.textBox_LogConsole.Name = "textBox_LogConsole";
            this.textBox_LogConsole.ReadOnly = true;
            this.textBox_LogConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_LogConsole.Size = new System.Drawing.Size(358, 251);
            this.textBox_LogConsole.TabIndex = 33;
            // 
            // textbox_DataConsole
            // 
            this.textbox_DataConsole.Location = new System.Drawing.Point(25, 299);
            this.textbox_DataConsole.Multiline = true;
            this.textbox_DataConsole.Name = "textbox_DataConsole";
            this.textbox_DataConsole.ReadOnly = true;
            this.textbox_DataConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_DataConsole.Size = new System.Drawing.Size(744, 313);
            this.textbox_DataConsole.TabIndex = 34;
            // 
            // button_FTune
            // 
            this.button_FTune.Location = new System.Drawing.Point(948, 141);
            this.button_FTune.Name = "button_FTune";
            this.button_FTune.Size = new System.Drawing.Size(71, 61);
            this.button_FTune.TabIndex = 35;
            this.button_FTune.Text = "FTune";
            this.button_FTune.UseVisualStyleBackColor = true;
            this.button_FTune.Click += new System.EventHandler(this.button_FTune_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(791, 224);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(313, 59);
            this.button_Clear.TabIndex = 36;
            this.button_Clear.Text = "Clear Logs";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // listBox_Reader
            // 
            this.listBox_Reader.FormattingEnabled = true;
            this.listBox_Reader.ItemHeight = 12;
            this.listBox_Reader.Location = new System.Drawing.Point(402, 27);
            this.listBox_Reader.Name = "listBox_Reader";
            this.listBox_Reader.Size = new System.Drawing.Size(367, 256);
            this.listBox_Reader.TabIndex = 37;
            // 
            // button_Tune
            // 
            this.button_Tune.Location = new System.Drawing.Point(1033, 141);
            this.button_Tune.Name = "button_Tune";
            this.button_Tune.Size = new System.Drawing.Size(71, 61);
            this.button_Tune.TabIndex = 38;
            this.button_Tune.Text = "Tune";
            this.button_Tune.UseVisualStyleBackColor = true;
            this.button_Tune.Click += new System.EventHandler(this.button_Tune_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(791, 141);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(138, 61);
            this.button_Reset.TabIndex = 39;
            this.button_Reset.Text = "RESET";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "Online Readers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "Command Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "Data Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Tune);
            this.Controls.Add(this.listBox_Reader);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_FTune);
            this.Controls.Add(this.textbox_DataConsole);
            this.Controls.Add(this.textBox_LogConsole);
            this.Controls.Add(this.receive);
            this.Controls.Add(this.loff);
            this.Controls.Add(this.lon);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataPortInput);
            this.Controls.Add(this.CommandPortInput);
            this.Name = "Form1";
            this.Text = "YYKeyenceReaderConsole 读码器服务端控制台";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommandPortInput;
        private System.Windows.Forms.TextBox DataPortInput;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button lon;
        private System.Windows.Forms.Button loff;
        private System.Windows.Forms.Button receive;
        private System.Windows.Forms.TextBox textBox_LogConsole;
        private System.Windows.Forms.TextBox textbox_DataConsole;
        private System.Windows.Forms.Button button_FTune;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ListBox listBox_Reader;
        private System.Windows.Forms.Button button_Tune;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

