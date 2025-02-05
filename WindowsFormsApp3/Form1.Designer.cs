namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnlongb = new System.Windows.Forms.Button();
            this.btnshortb = new System.Windows.Forms.Button();
            this.btnpomodoro = new System.Windows.Forms.Button();
            this.lblminute = new System.Windows.Forms.Label();
            this.lblsaniye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnminimize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "POMODORO CLOCK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.Location = new System.Drawing.Point(579, 12);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(61, 51);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnminimize.Location = new System.Drawing.Point(528, 11);
            this.btnminimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(61, 51);
            this.btnminimize.TabIndex = 9;
            this.btnminimize.Text = "_";
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.CadetBlue;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstart.Location = new System.Drawing.Point(166, 467);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(96, 36);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.CadetBlue;
            this.btnstop.FlatAppearance.BorderSize = 0;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstop.Location = new System.Drawing.Point(276, 467);
            this.btnstop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(96, 36);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnlongb
            // 
            this.btnlongb.BackColor = System.Drawing.Color.CadetBlue;
            this.btnlongb.FlatAppearance.BorderSize = 0;
            this.btnlongb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlongb.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlongb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlongb.Location = new System.Drawing.Point(483, 118);
            this.btnlongb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlongb.Name = "btnlongb";
            this.btnlongb.Size = new System.Drawing.Size(141, 42);
            this.btnlongb.TabIndex = 3;
            this.btnlongb.Text = "Long Break";
            this.btnlongb.UseVisualStyleBackColor = false;
            this.btnlongb.Click += new System.EventHandler(this.btnlongb_Click);
            // 
            // btnshortb
            // 
            this.btnshortb.BackColor = System.Drawing.Color.CadetBlue;
            this.btnshortb.FlatAppearance.BorderSize = 0;
            this.btnshortb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshortb.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnshortb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshortb.Location = new System.Drawing.Point(483, 73);
            this.btnshortb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnshortb.Name = "btnshortb";
            this.btnshortb.Size = new System.Drawing.Size(141, 39);
            this.btnshortb.TabIndex = 4;
            this.btnshortb.Text = "Short Break";
            this.btnshortb.UseVisualStyleBackColor = false;
            this.btnshortb.Click += new System.EventHandler(this.btnshortb_Click);
            // 
            // btnpomodoro
            // 
            this.btnpomodoro.BackColor = System.Drawing.Color.CadetBlue;
            this.btnpomodoro.FlatAppearance.BorderSize = 0;
            this.btnpomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpomodoro.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpomodoro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpomodoro.Location = new System.Drawing.Point(216, 130);
            this.btnpomodoro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnpomodoro.Name = "btnpomodoro";
            this.btnpomodoro.Size = new System.Drawing.Size(141, 38);
            this.btnpomodoro.TabIndex = 5;
            this.btnpomodoro.Text = "Pomodoro";
            this.btnpomodoro.UseVisualStyleBackColor = false;
            this.btnpomodoro.Click += new System.EventHandler(this.btnpomodoro_Click);
            // 
            // lblminute
            // 
            this.lblminute.AutoSize = true;
            this.lblminute.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminute.Location = new System.Drawing.Point(189, 404);
            this.lblminute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblminute.Name = "lblminute";
            this.lblminute.Size = new System.Drawing.Size(71, 59);
            this.lblminute.TabIndex = 6;
            this.lblminute.Text = "00";
            // 
            // lblsaniye
            // 
            this.lblsaniye.AutoSize = true;
            this.lblsaniye.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsaniye.Location = new System.Drawing.Point(296, 404);
            this.lblsaniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsaniye.Name = "lblsaniye";
            this.lblsaniye.Size = new System.Drawing.Size(71, 59);
            this.lblsaniye.TabIndex = 7;
            this.lblsaniye.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(266, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 59);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 76);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 20);
            this.label.TabIndex = 10;
            this.label.Text = "Pomodoro Ad";
            // 
            // btnistatistik
            // 
            this.btnistatistik.BackColor = System.Drawing.Color.CadetBlue;
            this.btnistatistik.FlatAppearance.BorderSize = 0;
            this.btnistatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnistatistik.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnistatistik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnistatistik.Location = new System.Drawing.Point(483, 166);
            this.btnistatistik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(141, 37);
            this.btnistatistik.TabIndex = 11;
            this.btnistatistik.Text = "istatistik";
            this.btnistatistik.UseVisualStyleBackColor = false;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.SystemColors.Control;
            this.txtTaskName.Location = new System.Drawing.Point(118, 73);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(100, 28);
            this.txtTaskName.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(639, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.btnistatistik);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsaniye);
            this.Controls.Add(this.lblminute);
            this.Controls.Add(this.btnpomodoro);
            this.Controls.Add(this.btnshortb);
            this.Controls.Add(this.btnlongb);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnlongb;
        private System.Windows.Forms.Button btnshortb;
        private System.Windows.Forms.Button btnpomodoro;
        private System.Windows.Forms.Label lblminute;
        private System.Windows.Forms.Label lblsaniye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}

