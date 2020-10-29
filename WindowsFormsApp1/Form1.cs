using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public decimal a = 0;
        public decimal b = 0;
        public decimal c = 0;
        public decimal d = 0;
        public decimal res = 0;
        public decimal benz = 0;
        public decimal result = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "A-92";

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a = decimal.Parse(label2.Text);
                a *= numericUpDown1.Value;
                res = a + b + c + d;
                label7.Text = res.ToString();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                b = decimal.Parse(label3.Text);
                b *= numericUpDown2.Value;
                res = a + b + c + d;
                label7.Text = res.ToString();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                c = decimal.Parse(label4.Text);
                c *= numericUpDown3.Value;
                res = a + b + c + d;
                label7.Text = res.ToString();
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                d = decimal.Parse(label5.Text);
                d *= numericUpDown4.Value;
                res = a + b + c + d;
                label7.Text = res.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                a = b = c = d = res = 0;
                label7.Text = "0.00";
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
            }
            if (checkBox1.Checked == false)
            {
                decimal count = numericUpDown1.Value * decimal.Parse(label2.Text);
                a -= count;
                res -= count;
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
                label7.Text = res.ToString();
            }
            if (checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                numericUpDown1_ValueChanged(sender, e);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                a = b = c = d = res = 0;
                label7.Text = "0.00";
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
            }
            if (checkBox2.Checked == false)
            {
                decimal count = numericUpDown2.Value * decimal.Parse(label3.Text);
                b -= count;
                res -= count;
                numericUpDown2.Value = 0;
                numericUpDown2.Enabled = false;
                label7.Text = res.ToString();
            }
            if (checkBox2.Checked == true)
            {
                numericUpDown2.Enabled = true;
                numericUpDown2_ValueChanged(sender, e);
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                a = b = c = d = res = 0;
                label7.Text = "0,00";
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
            }
            if (checkBox3.Checked == false)
            {
                decimal count = numericUpDown3.Value * decimal.Parse(label4.Text);
                c -= count;
                res -= count;
                numericUpDown3.Value = 0;
                numericUpDown3.Enabled = false;
                label7.Text = res.ToString();
            }
            if (checkBox3.Checked == true)
            {
                numericUpDown3.Enabled = true;
                numericUpDown3_ValueChanged(sender, e);
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                a = b = c = d = res = 0;
                label7.Text = "0,00";
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
            }
            if (checkBox4.Checked == false)
            {
                decimal count = numericUpDown4.Value * decimal.Parse(label5.Text);
                d -= count;
                res -= count;
                numericUpDown4.Value = 0;
                numericUpDown4.Enabled = false;
                label7.Text = res.ToString();
            }
            if (checkBox4.Checked == true)
            {
                numericUpDown4.Enabled = true;
                numericUpDown4_ValueChanged(sender, e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "A-95")
            {
                benz = 15;
                label11.Text = benz.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "A-76")
            {
                benz = 20;
                label11.Text = benz.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "A-98")
            {
                benz = 25;
                label11.Text = benz.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "A-92")
            {
                benz = 30;
                label11.Text = benz.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown5.Enabled = true;
            }
            else
            {
                numericUpDown5.Value = 0;
                label16.Text = "0,00";
                numericUpDown5.Enabled = false;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label16.Text = (benz * numericUpDown5.Value).ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                numericUpDown6.Enabled = true;
                label19.Visible = true;
                label20.Visible = true;
            }
            else if (radioButton2.Checked == false)
            {
                numericUpDown6.Value = 0;
                numericUpDown6.Enabled = false;
                label19.Text = "0,00";
                label19.Visible = false;
                label20.Visible = false;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = numericUpDown6.Value.ToString();
            label19.Text = ((int)(numericUpDown6.Value / benz)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(label16.Text) + decimal.Parse(label7.Text);
            label17.Text = result.ToString();
            label21.Text = (decimal.Parse(label21.Text) + result).ToString();
            timer1.Interval = 10000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Наступний клієнт присутній?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(res == DialogResult.Yes)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                label17.Text = "0,00";
                timer1.Stop();
            }
        }
    }
}
