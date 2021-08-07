namespace IP_Server
{
    partial class Form1
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
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hostAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.portNum = new System.Windows.Forms.TextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toggleBtn = new System.Windows.Forms.Button();
            this.connectStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(240, 78);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(79, 25);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Server";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hostAddress
            // 
            this.hostAddress.Location = new System.Drawing.Point(48, 81);
            this.hostAddress.Name = "hostAddress";
            this.hostAddress.Size = new System.Drawing.Size(86, 20);
            this.hostAddress.TabIndex = 2;
            this.hostAddress.Text = "127.0.0.1";
            this.hostAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Server";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(190, 81);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(44, 20);
            this.portNum.TabIndex = 5;
            this.portNum.Text = "2200";
            this.portNum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(325, 78);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(80, 25);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop Server";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Connection Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // toggleBtn
            // 
            this.toggleBtn.Location = new System.Drawing.Point(140, 45);
            this.toggleBtn.Name = "toggleBtn";
            this.toggleBtn.Size = new System.Drawing.Size(57, 23);
            this.toggleBtn.TabIndex = 8;
            this.toggleBtn.Text = "TCP";
            this.toggleBtn.UseVisualStyleBackColor = true;
            // 
            // connectStatus
            // 
            this.connectStatus.Location = new System.Drawing.Point(10, 109);
            this.connectStatus.Multiline = true;
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(473, 266);
            this.connectStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 387);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.toggleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.portNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portNum;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button toggleBtn;
        private System.Windows.Forms.TextBox connectStatus;
    }
}

