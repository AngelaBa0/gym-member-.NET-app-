using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_daily_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_daily.Checked)
                numericUpDown1.Enabled = true;
        }

        private void rb_monthly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            int monthlyPrice = 0;
            int dailyPrice = 0;
            string description = " ";
            int price = 0; 
            if (rbyoga.Checked)
            {
                description = " Class : yoga /r/n";
                dailyPrice += 10;
                monthlyPrice += 100;
            }
            else if (rbzumba.Checked)
            {
                description += " Class: zumba /r/n ";
                dailyPrice += 10;
                monthlyPrice += 100;

            }
            else if (rbswimming.Checked)
            {
                description += "class : swiming /r/n";
                dailyPrice += 14;
                monthlyPrice += 140;

            }
            else if (rbaquazumba.Checked)
            {
                description += "class : aqua zumba\r\n";
                dailyPrice += 14;
                monthlyPrice += 140;

            }
            if (rb_monthly.Checked)
            {
                description += " type : Monthly \r\n";
                price = monthlyPrice; 
            } else
            {
                description += " type : Daily \r\n";
                dailyPrice = (int)numericUpDown1.Value;
                price = dailyPrice; 
            }
            string extra = " extra"; 
            if ( cb_treadmill.Checked)
            { price += 10; 
                extra += " treadmill";
            }
            if (cb_suana.Checked)
            {
                price += 10;
                extra += " suana";
            }
            if (cb_pool.Checked)
            {
                price += 30;
                extra += " pool";
            }
            if (cb_eleptical.Checked)
            {
                price += 30;
                extra += " eleptical";
            }

            if (extra != " extra:")
            {
                description += extra +" \r\n" ; 
            }

            description += " Price " + price + " $";
            registration_txt.Text = description; 
            personalinfo_txt.Text = " Name : " + info_txtbox.Text + " \r\ntelephone : " + 
        }


    }
}
