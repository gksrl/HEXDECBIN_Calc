using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Calculator : Form
    {
        int first, second, result;
        int save;
        bool isTwice = false;
        bool isContinue = false;
        char op;

        public Calculator()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += ".";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (textBox2_Process.Text.Length > 0)
            {
                Convert.ToString(textBox2_Process.Text).EndsWith(" ");
                textBox2_Process.Text = textBox2_Process.Text.Substring(0, textBox2_Process.Text.Length - 1);
            }
            else
                return;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text = "";
            textBox1_Result.Text = "";
            first = 0;
            second = 0;
            save = 0;
            isTwice = false;
            isContinue = false;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

            if(isTwice == true) // X+Y= +
            {
                if (textBox2_Process.Text == "")
                {
                    first = save;
                    textBox2_Process.Text = "";
                    isTwice = true;
                }

                else if (op != '+')
                {

                    if (op == '-')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first -= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                    else if (op == '*')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first *= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                    else
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first /= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                }

                else
                {
                    second = Convert.ToInt16(textBox2_Process.Text)
                        ;
                    textBox2_Process.Text += "";
                    save = (first += second);
                    textBox1_Result.Text = Convert.ToString(save);
                    isTwice = true;
                }
            }

            else
            {
                first = Convert.ToInt16(textBox2_Process.Text);
                textBox2_Process.Text = "";
                isTwice = true;
            }

            textBox2_Process.Text = "";
            op = '+';

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

            if (isTwice == true)
            {
                if (textBox2_Process.Text == "")
                {
                    first = save;
                    textBox2_Process.Text = "";
                    isTwice = true;
                }

                else if (op != '-')
                {
                    if (op == '+')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first += second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }

                    else if (op == '*')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first *= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                    else
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first /= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                }

                else
                {
                    second = Convert.ToInt16(textBox2_Process.Text);
                    textBox2_Process.Text += "";
                    save = (first -= second);
                    textBox1_Result.Text = Convert.ToString(save);
                    isTwice = true;
                }
            }

            else
            {
                first = Convert.ToInt16(textBox2_Process.Text);
                textBox2_Process.Text = "";
                isTwice = true;
            }

            textBox2_Process.Text = "";
            op = '-';
        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {
            
            if (isTwice == true)
            {
                if (textBox2_Process.Text == "")
                {
                    first = save;
                    textBox2_Process.Text = "";
                    isTwice = true;
                }

                else if(op != '*')
                {
                    if (op == '+')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first += second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                    else if (op == '-')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first -= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }

                    else
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first /= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                }

                else
                {
                    second = Convert.ToInt16(textBox2_Process.Text);
                    textBox2_Process.Text += "";
                    save = (first *= second);
                    textBox1_Result.Text = Convert.ToString(save);
                    isTwice = true;
                }
            }

            else
            {
                first = Convert.ToInt16(textBox2_Process.Text);
                textBox2_Process.Text = "";
                isTwice = true;
            }

            textBox2_Process.Text = "";
            op = '*';
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {

            if (isTwice == true)
            {
                if (textBox2_Process.Text == "")
                {
                    first = save;
                    textBox2_Process.Text = "";
                    isTwice = true;
                }

                else if (op != '/')
                {
                    if (op == '+')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first += second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                    else if (op == '-')
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first -= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }

                    else
                    {
                        second = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text += "";
                        save = (first *= second);
                        textBox1_Result.Text = Convert.ToString(save);
                        isTwice = true;
                    }
                }

                else
                {
                    second = Convert.ToInt16(textBox2_Process.Text);
                    textBox2_Process.Text += "";
                    save = (first /= second);
                    textBox1_Result.Text = Convert.ToString(save);
                    isTwice = true;
                }
            }

            else
            {
                first = Convert.ToInt16(textBox2_Process.Text);
                textBox2_Process.Text = "";
                isTwice = true;
            }

            textBox2_Process.Text = "";
            op = '/';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "프로그래머") 
            {
                this.Close();
                Form2 fm2 = new Form2();
                fm2.Show();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                return;
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            if (textBox2_Process.Text == "")
            {
                switch(op)
                {
                    case '+':
                        save += second;
                        textBox1_Result.Text = Convert.ToString(save);
                        break;
                    case '-':
                        save -= second;
                        textBox1_Result.Text = Convert.ToString(save);
                        break;
                    case '*':
                        save *= second;
                        textBox1_Result.Text = Convert.ToString(save);
                        break;
                    case '/':
                        save /= second;
                        textBox1_Result.Text = Convert.ToString(save);
                        break;
                }
            }

            else
            {
                second = Convert.ToInt16(textBox2_Process.Text);
                switch (op)
                {
                    case '+':
                        textBox2_Process.Text = "";
                        save = (first + second);  // save = (first += second);
                        textBox1_Result.Text = Convert.ToString(save);
                        break;

                    case '-':
                        textBox2_Process.Text = "";
                        save = (first - second);
                        textBox1_Result.Text = Convert.ToString(save);
                        break;
                    case '*':
                        textBox2_Process.Text = "";
                        save = (first * second);
                        textBox1_Result.Text = Convert.ToString(save);
                        break;
                    case '/':
                        textBox2_Process.Text = "";
                        save = (first / second);
                        textBox1_Result.Text = Convert.ToString(save);
                        break;
                }
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
