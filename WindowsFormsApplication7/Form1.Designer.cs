namespace WindowsFormsApplication7
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_next = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.info_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_finish = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_eleptical = new System.Windows.Forms.CheckBox();
            this.cb_suana = new System.Windows.Forms.CheckBox();
            this.cb_pool = new System.Windows.Forms.CheckBox();
            this.cb_treadmill = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_daily = new System.Windows.Forms.RadioButton();
            this.rb_monthly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbzumba = new System.Windows.Forms.RadioButton();
            this.rbaquazumba = new System.Windows.Forms.RadioButton();
            this.rbswimming = new System.Windows.Forms.RadioButton();
            this.rbyoga = new System.Windows.Forms.RadioButton();
            this.bill_tab = new System.Windows.Forms.TabPage();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registration_txt = new System.Windows.Forms.TextBox();
            this.personalinfo_txt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.bill_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.bill_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_next);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.address_txtbox);
            this.tabPage1.Controls.Add(this.info_txtbox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "personal info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(353, 207);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(88, 35);
            this.btn_next.TabIndex = 9;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 8;
            // 
            // address_txtbox
            // 
            this.address_txtbox.Location = new System.Drawing.Point(133, 92);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.address_txtbox.Size = new System.Drawing.Size(162, 20);
            this.address_txtbox.TabIndex = 7;
            // 
            // info_txtbox
            // 
            this.info_txtbox.Location = new System.Drawing.Point(140, 16);
            this.info_txtbox.Name = "info_txtbox";
            this.info_txtbox.Size = new System.Drawing.Size(135, 20);
            this.info_txtbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(25, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(25, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(25, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "customer info";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_finish);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "registration info ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(310, 215);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(75, 23);
            this.btn_finish.TabIndex = 7;
            this.btn_finish.Text = "finish";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(131, 215);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "days";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_eleptical);
            this.groupBox3.Controls.Add(this.cb_suana);
            this.groupBox3.Controls.Add(this.cb_pool);
            this.groupBox3.Controls.Add(this.cb_treadmill);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(333, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "extra";
            // 
            // cb_eleptical
            // 
            this.cb_eleptical.AutoSize = true;
            this.cb_eleptical.Location = new System.Drawing.Point(14, 46);
            this.cb_eleptical.Name = "cb_eleptical";
            this.cb_eleptical.Size = new System.Drawing.Size(72, 19);
            this.cb_eleptical.TabIndex = 5;
            this.cb_eleptical.Text = "eloptical";
            this.cb_eleptical.UseVisualStyleBackColor = true;
            // 
            // cb_suana
            // 
            this.cb_suana.AutoSize = true;
            this.cb_suana.Location = new System.Drawing.Point(14, 114);
            this.cb_suana.Name = "cb_suana";
            this.cb_suana.Size = new System.Drawing.Size(60, 19);
            this.cb_suana.TabIndex = 4;
            this.cb_suana.Text = "suana";
            this.cb_suana.UseVisualStyleBackColor = true;
            // 
            // cb_pool
            // 
            this.cb_pool.AutoSize = true;
            this.cb_pool.Location = new System.Drawing.Point(14, 84);
            this.cb_pool.Name = "cb_pool";
            this.cb_pool.Size = new System.Drawing.Size(50, 19);
            this.cb_pool.TabIndex = 3;
            this.cb_pool.Text = "pool";
            this.cb_pool.UseVisualStyleBackColor = true;
            // 
            // cb_treadmill
            // 
            this.cb_treadmill.AutoSize = true;
            this.cb_treadmill.Location = new System.Drawing.Point(14, 19);
            this.cb_treadmill.Name = "cb_treadmill";
            this.cb_treadmill.Size = new System.Drawing.Size(74, 19);
            this.cb_treadmill.TabIndex = 2;
            this.cb_treadmill.Text = "treadmill";
            this.cb_treadmill.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_daily);
            this.groupBox2.Controls.Add(this.rb_monthly);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(47, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "time";
            // 
            // rb_daily
            // 
            this.rb_daily.AutoSize = true;
            this.rb_daily.Location = new System.Drawing.Point(154, 34);
            this.rb_daily.Name = "rb_daily";
            this.rb_daily.Size = new System.Drawing.Size(50, 19);
            this.rb_daily.TabIndex = 1;
            this.rb_daily.TabStop = true;
            this.rb_daily.Text = "daily";
            this.rb_daily.UseVisualStyleBackColor = true;
            this.rb_daily.CheckedChanged += new System.EventHandler(this.rb_daily_CheckedChanged);
            // 
            // rb_monthly
            // 
            this.rb_monthly.AutoSize = true;
            this.rb_monthly.Location = new System.Drawing.Point(6, 34);
            this.rb_monthly.Name = "rb_monthly";
            this.rb_monthly.Size = new System.Drawing.Size(68, 19);
            this.rb_monthly.TabIndex = 0;
            this.rb_monthly.TabStop = true;
            this.rb_monthly.Text = "monthly";
            this.rb_monthly.UseVisualStyleBackColor = true;
            this.rb_monthly.CheckedChanged += new System.EventHandler(this.rb_monthly_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbzumba);
            this.groupBox1.Controls.Add(this.rbaquazumba);
            this.groupBox1.Controls.Add(this.rbswimming);
            this.groupBox1.Controls.Add(this.rbyoga);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(47, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "class";
            // 
            // rbzumba
            // 
            this.rbzumba.AutoSize = true;
            this.rbzumba.Location = new System.Drawing.Point(144, 32);
            this.rbzumba.Name = "rbzumba";
            this.rbzumba.Size = new System.Drawing.Size(63, 19);
            this.rbzumba.TabIndex = 4;
            this.rbzumba.TabStop = true;
            this.rbzumba.Text = "zumba";
            this.rbzumba.UseVisualStyleBackColor = true;
            // 
            // rbaquazumba
            // 
            this.rbaquazumba.AutoSize = true;
            this.rbaquazumba.Location = new System.Drawing.Point(144, 64);
            this.rbaquazumba.Name = "rbaquazumba";
            this.rbaquazumba.Size = new System.Drawing.Size(91, 19);
            this.rbaquazumba.TabIndex = 3;
            this.rbaquazumba.TabStop = true;
            this.rbaquazumba.Text = "aquazumba";
            this.rbaquazumba.UseVisualStyleBackColor = true;
            // 
            // rbswimming
            // 
            this.rbswimming.AutoSize = true;
            this.rbswimming.Location = new System.Drawing.Point(3, 55);
            this.rbswimming.Name = "rbswimming";
            this.rbswimming.Size = new System.Drawing.Size(82, 19);
            this.rbswimming.TabIndex = 2;
            this.rbswimming.TabStop = true;
            this.rbswimming.Text = "swimming";
            this.rbswimming.UseVisualStyleBackColor = true;
            // 
            // rbyoga
            // 
            this.rbyoga.AutoSize = true;
            this.rbyoga.Location = new System.Drawing.Point(12, 32);
            this.rbyoga.Name = "rbyoga";
            this.rbyoga.Size = new System.Drawing.Size(51, 19);
            this.rbyoga.TabIndex = 1;
            this.rbyoga.TabStop = true;
            this.rbyoga.Text = "yoga";
            this.rbyoga.UseVisualStyleBackColor = true;
            // 
            // bill_tab
            // 
            this.bill_tab.Controls.Add(this.btn_close);
            this.bill_tab.Controls.Add(this.btn_new);
            this.bill_tab.Controls.Add(this.label3);
            this.bill_tab.Controls.Add(this.label2);
            this.bill_tab.Controls.Add(this.registration_txt);
            this.bill_tab.Controls.Add(this.personalinfo_txt);
            this.bill_tab.Location = new System.Drawing.Point(4, 22);
            this.bill_tab.Name = "bill_tab";
            this.bill_tab.Padding = new System.Windows.Forms.Padding(3);
            this.bill_tab.Size = new System.Drawing.Size(484, 272);
            this.bill_tab.TabIndex = 2;
            this.bill_tab.Text = "Bill";
            this.bill_tab.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(400, 232);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 34);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(262, 232);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(119, 36);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "new registration";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "registration info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "personal info";
            // 
            // registration_txt
            // 
            this.registration_txt.Location = new System.Drawing.Point(24, 123);
            this.registration_txt.Multiline = true;
            this.registration_txt.Name = "registration_txt";
            this.registration_txt.Size = new System.Drawing.Size(365, 96);
            this.registration_txt.TabIndex = 1;
            // 
            // personalinfo_txt
            // 
            this.personalinfo_txt.Location = new System.Drawing.Point(24, 19);
            this.personalinfo_txt.Multiline = true;
            this.personalinfo_txt.Name = "personalinfo_txt";
            this.personalinfo_txt.Size = new System.Drawing.Size(365, 87);
            this.personalinfo_txt.TabIndex = 0;
            this.personalinfo_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 313);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bill_tab.ResumeLayout(false);
            this.bill_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.TextBox info_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_monthly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbzumba;
        private System.Windows.Forms.RadioButton rbaquazumba;
        private System.Windows.Forms.RadioButton rbswimming;
        private System.Windows.Forms.RadioButton rbyoga;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_eleptical;
        private System.Windows.Forms.CheckBox cb_suana;
        private System.Windows.Forms.CheckBox cb_pool;
        private System.Windows.Forms.CheckBox cb_treadmill;
        private System.Windows.Forms.RadioButton rb_daily;
        private System.Windows.Forms.TabPage bill_tab;
        private System.Windows.Forms.TextBox personalinfo_txt;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registration_txt;
    }
}

