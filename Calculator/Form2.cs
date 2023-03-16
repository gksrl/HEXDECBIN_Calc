using System;
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


        private void PrintLabelJinsu(int num) // 계산기 텍스트 출력 진수 변환
        {

            label_hex.Text = Convert.ToString(num, 16).ToUpper();
            label_dec.Text = Convert.ToString(num, 10);
            label_bin.Text = Convert.ToString(num, 2).PadLeft(8, '0').Insert(4, " ");
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            numpad = 1;

            //switch (binary)
            //{
            //    case "hex":
            //        textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16));
            //        PrintLabelJinsu(numpad);
            //        break;
            //    case "dec":
            //        textBox2_Process.Text += Convert.ToString(numpad, 10);
            //        PrintLabelJinsu(numpad);
            //        break;
            //    case "bin":
            //        textBox2_Process.Text += Convert.ToString(numpad, 2);
            //        PrintLabelJinsu(numpad);
            //        break;
            //}

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
            else if (radioButton_bin.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 2);
                binarytransform += Convert.ToString(numpad, 2);
                PrintLabelJinsu(Convert.ToInt32(binarytransform, 2));

            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            numpad = 2;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            numpad = 3;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            numpad = 4;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            numpad = 5;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            numpad = 6;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            numpad = 7;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            numpad = 8;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            numpad = 9;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            numpad = 0;

            if (radioButton_hex.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 16);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));

            }
            else if (radioButton_dec.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 10);
                PrintLabelJinsu(int.Parse(textBox2_Process.Text));
            }
            else if (radioButton_bin.Checked == true)
            {
                textBox2_Process.Text += Convert.ToString(numpad, 2);
                binarytransform += Convert.ToString(numpad, 2);
                PrintLabelJinsu(Convert.ToInt32(binarytransform, 2));
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox2_Process.Text += ".";
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            numpad = 0XA;

            textBox2_Process.Text += Convert.ToString(numpad, 16).ToUpper();
            //textBox2_Process.Text += Convert.ToString(Convert.ToString(numpad, 16)).ToUpper();
            PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));


        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            numpad = 0XB;

            textBox2_Process.Text += Convert.ToString(numpad, 16).ToUpper();
            PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            numpad = 0XC;

            textBox2_Process.Text += Convert.ToString(numpad, 16).ToUpper();
            PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            numpad = 0XD;

            textBox2_Process.Text += Convert.ToString(numpad, 16).ToUpper();
            PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            numpad = 0XE;

            textBox2_Process.Text += Convert.ToString(numpad, 16).ToUpper();
            PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            numpad = 0XF;

            textBox2_Process.Text += Convert.ToString(numpad, 16).ToUpper();
            PrintLabelJinsu(int.Parse(textBox2_Process.Text, System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (textBox2_Process.Text.Length > 0)
            {
                Convert.ToString(textBox2_Process.Text).EndsWith(" ");
                textBox2_Process.Text = textBox2_Process.Text.Substring(0, textBox2_Process.Text.Length - 1);
                switch (binary)
                {
                    case "hexa":
                        if (textBox2_Process.Text == "")
                        {
                            label_hex.Text = "";
                            label_dec.Text = "";
                            label_bin.Text = "";
                        }
                        else
                        {
                            PrintLabelJinsu(Convert.ToInt32(textBox2_Process.Text, 16));
                        }
                        break;
                    case "dec":
                        if (textBox2_Process.Text == "")
                        {
                            label_hex.Text = "";
                            label_dec.Text = "";
                            label_bin.Text = "";
                        }
                        else
                        {
                            PrintLabelJinsu(Convert.ToInt32(textBox2_Process.Text, 10));
                        }
                        break;
                    case "bin":
                        if (textBox2_Process.Text == "")
                        {
                            label_hex.Text = "";
                            label_dec.Text = "";
                            label_bin.Text = "";
                        }
                        else
                        {
                            PrintLabelJinsu(Convert.ToInt32(textBox2_Process.Text, 2));
                        }
                        break;

                }
            }
            else if (textBox2_Process.Text.Length == 0)
            {
                return;
            }

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

            if (isTwice == true)
            {
                if (textBox2_Process.Text == "")   // X+Y= +
                {
                    first = save;
                    textBox2_Process.Text = "";
                    isTwice = true;
                }

                else if (op != '+')          // X + Y ? Z 사칙연산
                {
                    switch (binary)
                    {
                        case "hexa":
                            if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '*')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "dec":
                            if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '*')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "bin":
                            if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '*')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                    }
                }

                else   // N + N + N 덧샘
                {
                    //second = Convert.ToInt16(textBox2_Process.Text);
                    //textBox2_Process.Text += "";
                    //save = (first += second);
                    //textBox1_Result.Text = Convert.ToString(save);
                    //PrintLabelJinsu(save);

                    switch (binary)
                    {
                        case "hexa":
                            second = Convert.ToInt32(textBox2_Process.Text, 16);
                            textBox2_Process.Text += "";
                            save = (first += second);
                            textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                            PrintLabelJinsu(save);

                            break;
                        case "dec":
                            second = Convert.ToInt16(textBox2_Process.Text);
                            textBox2_Process.Text += "";
                            save = (first += second);
                            textBox1_Result.Text = Convert.ToString(save);
                            PrintLabelJinsu(save);
                            break;
                        case "bin":
                            second = Convert.ToInt32(textBox2_Process.Text, 2);
                            textBox2_Process.Text += "";
                            save = (first += second);
                            textBox1_Result.Text = Convert.ToString(save, 2);
                            PrintLabelJinsu(save);
                            break;

                    }
                    isTwice = true;
                }
            }

            else    // N + N  =
            {
                if (textBox2_Process.Text == "")
                {
                    MessageBox.Show("숫자를 입력하세요");
                    return;
                }

                else
                {
                    switch (binary)
                    {
                        case "hexa":
                            first = Convert.ToInt32(textBox2_Process.Text, 16);
                            textBox2_Process.Text = "";
                            break;
                        case "dec":
                            first = Convert.ToInt16(textBox2_Process.Text);
                            textBox2_Process.Text = "";
                            break;
                        case "bin":
                            first = Convert.ToInt32(textBox2_Process.Text, 2);
                            textBox2_Process.Text = "";
                            break;

                    }
                }
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
                    switch (binary)
                    {
                        case "hexa":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '*')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "dec":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '*')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "bin":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '*')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                    }
                }

                else
                {
                    switch (binary)
                    {
                        case "hexa":
                            second = Convert.ToInt32(textBox2_Process.Text, 16); // 두번째 변수 16진수로 입력 
                            textBox2_Process.Text += "";
                            save = (first -= second);
                            textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                            PrintLabelJinsu(save);

                            break;
                        case "dec":
                            second = Convert.ToInt16(textBox2_Process.Text);
                            textBox2_Process.Text += "";
                            save = (first -= second);
                            textBox1_Result.Text = Convert.ToString(save);
                            PrintLabelJinsu(save);
                            break;
                        case "bin":
                            second = Convert.ToInt32(textBox2_Process.Text, 2); // 두번째 변수 2진수로 입력 
                            textBox2_Process.Text += "";
                            save = (first -= second);
                            textBox1_Result.Text = Convert.ToString(save, 2);
                            PrintLabelJinsu(save);
                            break;

                    }
                }
            }

            else
            {
                switch (binary)
                {
                    case "hexa":
                        first = Convert.ToInt32(textBox2_Process.Text, 16);
                        textBox2_Process.Text = "";
                        break;
                    case "dec":
                        first = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text = "";
                        break;
                    case "bin":
                        first = Convert.ToInt32(textBox2_Process.Text, 2);
                        textBox2_Process.Text = "";
                        break;

                }
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
                    switch (binary)
                    {
                        case "hexa":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "dec":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "bin":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first /= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                    }
                }

                else
                {
                    switch (binary)
                    {
                        case "hexa":
                            second = Convert.ToInt32(textBox2_Process.Text, 16); // 두번째 변수 16진수로 입력 
                            textBox2_Process.Text += "";
                            save = (first *= second);
                            textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                            PrintLabelJinsu(save);

                            break;
                        case "dec":
                            second = Convert.ToInt16(textBox2_Process.Text);
                            textBox2_Process.Text += "";
                            save = (first *= second);
                            textBox1_Result.Text = Convert.ToString(save);
                            PrintLabelJinsu(save);
                            break;
                        case "bin":
                            second = Convert.ToInt32(textBox2_Process.Text, 2); // 두번째 변수 2진수로 입력 
                            textBox2_Process.Text += "";
                            save = (first *= second);
                            textBox1_Result.Text = Convert.ToString(save, 2);
                            PrintLabelJinsu(save);
                            break;

                    }
                    isTwice = true;
                }
            }

            else
            {
                switch (binary)
                {
                    case "hexa":
                        first = Convert.ToInt32(textBox2_Process.Text, 16); // 16진수 10진수로 변환
                        textBox2_Process.Text = "";
                        break;
                    case "dec":
                        first = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text = "";
                        break;
                    case "bin":
                        first = Convert.ToInt32(textBox2_Process.Text, 2); // 16진수 10진수로 변환
                        textBox2_Process.Text = "";
                        break;

                }
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
                    switch (binary)
                    {
                        case "hexa":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 16);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "dec":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                        case "bin":
                            if (op == '+')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first += second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else if (op == '-')
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first -= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            else
                            {
                                second = Convert.ToInt16(textBox2_Process.Text, 2);
                                textBox2_Process.Text += "";
                                save = (first *= second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                isTwice = true;
                            }
                            break;
                    }
                }

                else
                {
                    switch (binary)
                    {
                        case "hexa":
                            second = Convert.ToInt32(textBox2_Process.Text, 16);
                            textBox2_Process.Text += "";
                            save = (first /= second);
                            textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                            PrintLabelJinsu(save);

                            break;
                        case "dec":
                            second = Convert.ToInt16(textBox2_Process.Text);
                            textBox2_Process.Text += "";
                            save = (first /= second);
                            textBox1_Result.Text = Convert.ToString(save);
                            PrintLabelJinsu(save);
                            break;
                        case "bin":
                            second = Convert.ToInt32(textBox2_Process.Text, 2);
                            textBox2_Process.Text += "";
                            save = (first /= second);
                            textBox1_Result.Text = Convert.ToString(save, 2);
                            PrintLabelJinsu(save);
                            break;

                    }
                    isTwice = true;
                }
            }

            else
            {
                switch (binary)
                {
                    case "hexa":
                        first = Convert.ToInt32(textBox2_Process.Text, 16);
                        textBox2_Process.Text = "";
                        break;
                    case "dec":
                        first = Convert.ToInt16(textBox2_Process.Text);
                        textBox2_Process.Text = "";
                        break;
                    case "bin":
                        first = Convert.ToInt32(textBox2_Process.Text, 2);
                        textBox2_Process.Text = "";
                        break;

                }
                isTwice = true;
            }

            textBox2_Process.Text = "";
            op = '/';
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            if (textBox2_Process.Text == "")
            {
                switch (binary)
                {
                    case "hexa":
                        switch (op)
                        {
                            case '+':
                                save += second;
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);

                                break;
                            case '-':
                                save -= second;
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                break;
                            case '*':
                                save *= second;
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                break;
                            case '/':
                                save /= second;
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                break;
                        }
                        break;
                    case "dec":
                        switch (op)
                        {
                            case '+':
                                save += second;
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);

                                break;
                            case '-':
                                save -= second;
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                break;
                            case '*':
                                save *= second;
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                break;
                            case '/':
                                save /= second;
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                break;
                        }
                        break;
                    case "bin":
                        switch (op)
                        {
                            case '+':
                                save += second;
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);

                                break;
                            case '-':
                                save -= second;
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                break;
                            case '*':
                                save *= second;
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                break;
                            case '/':
                                save /= second;
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                break;
                        }
                        break;
                }
            }

            else
            {
                switch (binary)
                {
                    case "hexa":
                        second = Convert.ToInt16(textBox2_Process.Text, 16);
                        switch (op)
                        {
                            case '+':
                                textBox2_Process.Text = "";
                                save = (first + second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                break;

                            case '-':
                                textBox2_Process.Text = "";
                                save = (first - second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                break;
                            case '*':
                                textBox2_Process.Text = "";
                                save = (first * second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                break;
                            case '/':
                                textBox2_Process.Text = "";
                                save = (first / second);
                                textBox1_Result.Text = Convert.ToString(save, 16).ToUpper();
                                PrintLabelJinsu(save);
                                break;
                        }
                        break;
                    case "dec":
                        second = Convert.ToInt16(textBox2_Process.Text);
                        switch (op)
                        {
                            case '+':
                                textBox2_Process.Text = "";
                                save = (first + second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                break;

                            case '-':
                                textBox2_Process.Text = "";
                                save = (first - second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                break;
                            case '*':
                                textBox2_Process.Text = "";
                                save = (first * second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                break;
                            case '/':
                                textBox2_Process.Text = "";
                                save = (first / second);
                                textBox1_Result.Text = Convert.ToString(save);
                                PrintLabelJinsu(save);
                                break;
                        }
                        break;
                    case "bin":
                        second = Convert.ToInt16(textBox2_Process.Text, 2);
                        switch (op)
                        {
                            case '+':
                                textBox2_Process.Text = "";
                                save = (first + second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                break;

                            case '-':
                                textBox2_Process.Text = "";
                                save = (first - second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                break;
                            case '*':
                                textBox2_Process.Text = "";
                                save = (first * second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                break;
                            case '/':
                                textBox2_Process.Text = "";
                                save = (first / second);
                                textBox1_Result.Text = Convert.ToString(save, 2);
                                PrintLabelJinsu(save);
                                break;
                        }
                        break;
                }
            }
        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "";
            textBox2_Process.Text = "0";
            first = 0;
            second = 0;
            save = 0;
            binarytransform = "";
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
                //for(int i = 0; i <= 9; i++)
                //{
                //    btn_[i].Enabled = true;
                //}
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
            textBox2_Process.Text = label_hex.Text;
            textBox1_Result.Text = "";
            first = 0;
            second = 0;
            save = 0;
            isTwice = false;
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
            textBox2_Process.Text = label_dec.Text;
            textBox1_Result.Text = "";
            first = 0;
            second = 0;
            isTwice = false;

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
            string temp1;
            if(label_bin.Text == "")
            {
                return;
            }
            else
            {
                temp1 = label_bin.Text.Substring(0, 4) + label_bin.Text.Substring(label_bin.Text.Length - 4);
                textBox2_Process.Text = temp1;
                textBox1_Result.Text = "";
            }

            first = 0;
            second = 0;
            isTwice = false;

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
