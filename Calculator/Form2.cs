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
        int first, second, numpad;
        int save;
        bool isTwice = false;
        char op;
        string binary, binarytransform;

        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            radioButton_dec.Checked = true;

        }


        private void PrintJinsu()  // 연산 결과 진수 변환 
        {
            label_hex.Text = "";
            label_dec.Text = "";
            label_bin.Text = "";

            label_hex.Text += Convert.ToString(Convert.ToString(save, 16)).ToUpper(); ;
            label_dec.Text += Convert.ToString(Convert.ToString(save, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(save, 2));
        }

        private void PrintNumJinsu(int num) // 계산기 텍스트 출력 진수 변환
        {

            label_hex.Text = Convert.ToString(Convert.ToString(num, 16)).ToUpper(); ;
            label_dec.Text = Convert.ToString(Convert.ToString(num, 10));
            label_bin.Text = Convert.ToString(Convert.ToString(num, 2));
        }

        private void PrintHexaJinsu(string alpha) // 계산기 문자 텍스트 출력 진수 변환
        {
            label_hex.Text = "";
            label_dec.Text = "";
            label_bin.Text = "";
            int num_alpha;
            num_alpha = int.Parse(alpha, System.Globalization.NumberStyles.HexNumber);
            label_hex.Text += Convert.ToString(Convert.ToString(num_alpha, 16)).ToUpper();;
            label_dec.Text += Convert.ToString(Convert.ToString(num_alpha, 10));
            label_bin.Text += Convert.ToString(Convert.ToString(num_alpha, 2));

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            numpad = 1;

            //switch (binary)
            //{
            //    case "hex":
            //        textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
            //        PrintNumJinsu(numpad);
            //        break;
            //    case "dec":
            //        textBox2_Process.Text += Convert.ToString(numpad, 10);
            //        PrintNumJinsu(numpad);
            //        break;
            //    case "bin":
            //        textBox2_Process.Text += Convert.ToString(numpad, 2);
            //        PrintNumJinsu(numpad);
            //        break;
            //}

            if(radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)); 
                PrintNumJinsu(int.Parse(textBox2_Process.Text,System.Globalization.NumberStyles.HexNumber));
            }
            else if(radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
            else if(radioButton_bin.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad,2);
                binarytransform = Convert.ToString(numpad,2);
                PrintNumJinsu(int.Parse(binarytransform));

            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            numpad = 2;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text,System.Globalization.NumberStyles.HexNumber));
            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            numpad = 3;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            numpad = 4;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            numpad = 5;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            numpad = 6;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            numpad = 7;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            numpad = 8;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            numpad = 9;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            numpad = 0;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
                PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintNumJinsu(int.Parse(textBox2_Process.Text));
            }
            else if (radioButton_bin.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad,2);
                binarytransform = Convert.ToString(numpad, 2);
                PrintNumJinsu(int.Parse(binarytransform));
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += ".";
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            numpad = 0XA;

            textBox2_Process.Text += Convert.ToString(numpad,16).ToUpper();
            //textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)).ToUpper();
            PrintNumJinsu(int.Parse(textBox2_Process.Text,System.Globalization.NumberStyles.HexNumber));


        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            numpad = 0XB;

            textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)).ToUpper();
            PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            numpad = 0XC;

            textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)).ToUpper();
            PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            numpad = 0XD;

            textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)).ToUpper();
            PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            numpad = 0XE;

            textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)).ToUpper();
            PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            numpad = 0XF;

            textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)).ToUpper();
            PrintNumJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (textBox2_Process.Text.Length > 0)
            {
                Convert.ToString(textBox2_Process.Text).EndsWith(" ");
                textBox2_Process.Text = textBox2_Process.Text.Substring(0, textBox2_Process.Text.Length - 1);
            }
            else
                return;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
           
                    if (isTwice == true)
                    {
                        if (textBox2_Process.Text == "")
                        {
                            first = save;
                            textBox2_Process.Text = "";
                            isTwice = true;
                        }

                        else if (op != '+')          // N + N ? N 사칙연산
                        {

                            if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintNumJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '*')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintNumJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintNumJinsu(save);
                                isTwice = true;
                            }
                        }

                        else   // N + N + N 덧샘
                        {
                            second = Convert.ToInt16(textBox2_Process.Text)
                                ;
                            textBox2_Process.Text += "";
                            save = (first += second);
                            switch(binary)
                            {
                                case "hexa":
                                    textBox1_Result.Text = Convert.ToString(save, 16);
                                    PrintNumJinsu(int.Parse(textBox1_Result.Text, System.Globalization.NumberStyles.HexNumber));
                                    break;
                                case "dec":
                                    textBox1_Result.Text = Convert.ToString(save);
                                    PrintNumJinsu(save);
                                    break;
                                case "bin":
                                    break;

                            }
                            isTwice = true;
                        }
                    }

                    else    // N + N  =
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

                else if (op != '*')
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

        private void btn_result_Click(object sender, EventArgs e)
        {
            if (textBox2_Process.Text == "")
            {
                switch (op)
                {
                    case '+':
                        save += second;
                        textBox1_Result.Text = Convert.ToString(save);
                        PrintNumJinsu(save);

                        break;
                    case '-':
                        save -= second;
                        textBox1_Result.Text = Convert.ToString(save);
                        PrintNumJinsu(save);
                        break;
                    case '*':
                        save *= second;
                        textBox1_Result.Text = Convert.ToString(save);
                        PrintNumJinsu(save);
                        break;
                    case '/':
                        save /= second;
                        textBox1_Result.Text = Convert.ToString(save);
                        PrintNumJinsu(save);
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
                        PrintNumJinsu(save);
                        break;

                    case '-':
                        textBox2_Process.Text = "";
                        save = (first - second);
                        textBox1_Result.Text = Convert.ToString(save);
                        PrintNumJinsu(save);
                        break;
                    case '*':
                        textBox2_Process.Text = "";
                        save = (first * second);
                        textBox1_Result.Text = Convert.ToString(save);
                        PrintNumJinsu(save);
                        break;
                    case '/':
                        textBox2_Process.Text = "";
                        save = (first / second);
                        textBox1_Result.Text = Convert.ToString(save);
                        PrintNumJinsu(save);
                        break;
                }
            }
        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "";
            textBox2_Process.Text = "";
            first = 0;
            second = 0;
            save = 0;
            isTwice = false;

            label_hex.Text = "";
            label_dec.Text = "";
            label_bin.Text = "";
        }

        private void radioButton_hex_CheckedChanged(object sender, EventArgs e) // 16진수 활성화
        {
            if (radioButton_hex.Checked == true)
            {
                binary = "hexa";
                btn_0.Enabled = true;
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;
                btn_4.Enabled = true;
                btn_5.Enabled = true;
                btn_6.Enabled = true;
                btn_7.Enabled = true;
                btn_8.Enabled = true;
                btn_9.Enabled = true;
                btn_A.Enabled = true;
                btn_B.Enabled = true;
                btn_C.Enabled = true;
                btn_D.Enabled = true;
                btn_E.Enabled = true;
                btn_F.Enabled = true;

                btn_dot.Enabled = false;
            }
        }

        private void radioButton_dec_CheckedChanged(object sender, EventArgs e) // 10진수 활성화
        {
            if (radioButton_dec.Checked == true)
            {
                binary = "dec";
                btn_0.Enabled = true;
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;
                btn_4.Enabled = true;
                btn_5.Enabled = true;
                btn_6.Enabled = true;
                btn_7.Enabled = true;
                btn_8.Enabled = true;
                btn_9.Enabled = true;

                btn_A.Enabled = false;
                btn_B.Enabled = false;
                btn_C.Enabled = false;
                btn_D.Enabled = false;
                btn_E.Enabled = false;
                btn_F.Enabled = false;
                btn_dot.Enabled = false;
            }
        }

        private void radioButton_bin_CheckedChanged(object sender, EventArgs e) //2진수 활성화
        {
            if (radioButton_bin.Checked == true)
            {
                binary = "bin";
                btn_0.Enabled = true;
                btn_1.Enabled = true;

                btn_2.Enabled = false;
                btn_3.Enabled = false;
                btn_4.Enabled = false;
                btn_5.Enabled = false;
                btn_6.Enabled = false;
                btn_7.Enabled = false;
                btn_8.Enabled = false;
                btn_9.Enabled = false;
                btn_A.Enabled = false;
                btn_B.Enabled = false;
                btn_C.Enabled = false;
                btn_D.Enabled = false;
                btn_E.Enabled = false;
                btn_F.Enabled = false;
                btn_dot.Enabled = false;
            }
        }

        private void label_hex_TextChanged(object sender, EventArgs e)
        {
            //label_hex.Text += Convert.ToString(Convert.ToInt32(textBox1_Result.Text), 16);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "표준")
            {
                this.Close();
                Calculator fm1 = new Calculator();
                fm1.Show();

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                return;
            }
        }
    }
}
