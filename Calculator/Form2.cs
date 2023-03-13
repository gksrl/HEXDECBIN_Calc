using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            //checkBox1_CheckedChanged
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "1";
            label_hex.Text += Convert.ToString(Convert.ToString(1, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(1, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(1, 2));
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "2";
            label_hex.Text += Convert.ToString(Convert.ToString(2, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(2, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(2, 2));
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "3";
            label_hex.Text += Convert.ToString(Convert.ToString(3, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(3, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(3, 2));
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "4";
            label_hex.Text += Convert.ToString(Convert.ToString(4, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(4, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(4, 2));
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "5";
            label_hex.Text += Convert.ToString(Convert.ToString(5, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(5, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(5, 2));
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "6";
            label_hex.Text += Convert.ToString(Convert.ToString(6, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(6, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(6, 2));
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "7";
            label_hex.Text += Convert.ToString(Convert.ToString(7, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(7, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(7, 2));
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "8";
            label_hex.Text += Convert.ToString(Convert.ToString(8, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(8, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(8, 2));
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "9";
            label_hex.Text += Convert.ToString(Convert.ToString(9, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(9, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(9, 2));
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "0";
            label_hex.Text += Convert.ToString(Convert.ToString(1, 16));
            label_dec.Text += Convert.ToString(Convert.ToString(1, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(1, 2));
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += ".";
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "A";
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "B";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "C";
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "D";
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "E";
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text += "F";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (textBox1_Result.Text.Length > 0)
            {
                Convert.ToString(textBox1_Result.Text).EndsWith(" ");
                textBox1_Result.Text = textBox1_Result.Text.Substring(0, textBox1_Result.Text.Length - 1);
            }
            else
                return;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2_Dec.Enabled = false;
            checkBox3_Bin.Enabled = false;

            btn_dot.Enabled = false;

            
            if (checkBox1_Hex.Checked == false) 
            {
                checkBox2_Dec.Enabled = true;
                checkBox3_Bin.Enabled = true;

                btn_dot.Enabled = true;
            }
        }

        private void checkBox2_Dec_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_Hex.Enabled = false;
            checkBox3_Bin.Enabled = false;

            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_dot.Enabled = false;
            if (checkBox2_Dec.Checked == false)
            {
                checkBox1_Hex.Enabled = true;
                checkBox3_Bin.Enabled = true;

                btn_A.Enabled = true;
                btn_B.Enabled = true;
                btn_C.Enabled = true;
                btn_D.Enabled = true;
                btn_E.Enabled = true;
                btn_F.Enabled = true;
                btn_dot.Enabled = true;
            }
        }

        private void checkBox3_Bin_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_Hex.Enabled = false;
            checkBox2_Dec.Enabled = false;

            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_dot.Enabled = false;

            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
            if (checkBox3_Bin.Checked == false)
            {
                checkBox1_Hex.Enabled = true;
                checkBox2_Dec.Enabled = true;

                btn_A.Enabled = true;
                btn_B.Enabled = true;
                btn_C.Enabled = true;
                btn_D.Enabled = true;
                btn_E.Enabled = true;
                btn_F.Enabled = true;
                btn_dot.Enabled = true;

                btn_2.Enabled = true;
                btn_3.Enabled = true;
                btn_4.Enabled = true;
                btn_5.Enabled = true;
                btn_6.Enabled = true;
                btn_7.Enabled = true;
                btn_8.Enabled = true;
                btn_9.Enabled = true;
            }
        }
    }
}
