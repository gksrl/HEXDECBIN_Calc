namespace Calculator
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.textBox2_Process = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_multiple = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.label_hex = new System.Windows.Forms.Label();
            this.label_dec = new System.Windows.Forms.Label();
            this.label_bin = new System.Windows.Forms.Label();
            this.textBox1_Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_hex = new System.Windows.Forms.RadioButton();
            this.radioButton_dec = new System.Windows.Forms.RadioButton();
            this.radioButton_bin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "표준",
            "프로그래머"});
            this.comboBox1.Location = new System.Drawing.Point(12, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "입력";
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dot.Location = new System.Drawing.Point(230, 452);
            this.btn_dot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(65, 52);
            this.btn_dot.TabIndex = 71;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_0.Location = new System.Drawing.Point(156, 452);
            this.btn_0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(65, 52);
            this.btn_0.TabIndex = 70;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // textBox2_Process
            // 
            this.textBox2_Process.BackColor = System.Drawing.Color.White;
            this.textBox2_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2_Process.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2_Process.Location = new System.Drawing.Point(12, 41);
            this.textBox2_Process.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2_Process.Multiline = true;
            this.textBox2_Process.Name = "textBox2_Process";
            this.textBox2_Process.ReadOnly = true;
            this.textBox2_Process.Size = new System.Drawing.Size(352, 40);
            this.textBox2_Process.TabIndex = 69;
            this.textBox2_Process.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_result
            // 
            this.btn_result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_result.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_result.Location = new System.Drawing.Point(304, 452);
            this.btn_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(65, 52);
            this.btn_result.TabIndex = 68;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = false;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_clear.Location = new System.Drawing.Point(82, 452);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(65, 52);
            this.btn_clear.TabIndex = 67;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_multiple
            // 
            this.btn_multiple.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_multiple.Location = new System.Drawing.Point(304, 296);
            this.btn_multiple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_multiple.Name = "btn_multiple";
            this.btn_multiple.Size = new System.Drawing.Size(65, 52);
            this.btn_multiple.TabIndex = 66;
            this.btn_multiple.Text = "x";
            this.btn_multiple.UseVisualStyleBackColor = true;
            this.btn_multiple.Click += new System.EventHandler(this.btn_multiple_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_minus.Location = new System.Drawing.Point(304, 348);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(65, 52);
            this.btn_minus.TabIndex = 65;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_plus.Location = new System.Drawing.Point(304, 400);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(65, 52);
            this.btn_plus.TabIndex = 64;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_divide.Location = new System.Drawing.Point(304, 244);
            this.btn_divide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(65, 52);
            this.btn_divide.TabIndex = 63;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_8.Location = new System.Drawing.Point(156, 296);
            this.btn_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(65, 52);
            this.btn_8.TabIndex = 60;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_7.Location = new System.Drawing.Point(82, 296);
            this.btn_7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(65, 52);
            this.btn_7.TabIndex = 59;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_5.Location = new System.Drawing.Point(156, 348);
            this.btn_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(65, 52);
            this.btn_5.TabIndex = 57;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_4.Location = new System.Drawing.Point(82, 348);
            this.btn_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(65, 52);
            this.btn_4.TabIndex = 56;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_3.Location = new System.Drawing.Point(230, 400);
            this.btn_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(65, 52);
            this.btn_3.TabIndex = 55;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_2.Location = new System.Drawing.Point(156, 400);
            this.btn_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(65, 52);
            this.btn_2.TabIndex = 54;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_1.Location = new System.Drawing.Point(82, 400);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(65, 52);
            this.btn_1.TabIndex = 53;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_B
            // 
            this.btn_B.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_B.Location = new System.Drawing.Point(8, 244);
            this.btn_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(65, 52);
            this.btn_B.TabIndex = 79;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_C.Location = new System.Drawing.Point(8, 296);
            this.btn_C.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(65, 52);
            this.btn_C.TabIndex = 80;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_6.Location = new System.Drawing.Point(230, 348);
            this.btn_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(65, 52);
            this.btn_6.TabIndex = 81;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_9.Location = new System.Drawing.Point(230, 296);
            this.btn_9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(65, 52);
            this.btn_9.TabIndex = 82;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_del.Location = new System.Drawing.Point(304, 192);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(65, 52);
            this.btn_del.TabIndex = 83;
            this.btn_del.Text = "delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_A
            // 
            this.btn_A.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_A.Location = new System.Drawing.Point(8, 192);
            this.btn_A.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(65, 52);
            this.btn_A.TabIndex = 84;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_D
            // 
            this.btn_D.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_D.Location = new System.Drawing.Point(8, 348);
            this.btn_D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(65, 52);
            this.btn_D.TabIndex = 85;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_E
            // 
            this.btn_E.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_E.Location = new System.Drawing.Point(8, 400);
            this.btn_E.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(65, 52);
            this.btn_E.TabIndex = 86;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = true;
            this.btn_E.Click += new System.EventHandler(this.btn_E_Click);
            // 
            // btn_F
            // 
            this.btn_F.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_F.Location = new System.Drawing.Point(8, 452);
            this.btn_F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(65, 52);
            this.btn_F.TabIndex = 87;
            this.btn_F.Text = "F";
            this.btn_F.UseVisualStyleBackColor = true;
            this.btn_F.Click += new System.EventHandler(this.btn_F_Click);
            // 
            // label_hex
            // 
            this.label_hex.AutoSize = true;
            this.label_hex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_hex.Location = new System.Drawing.Point(80, 108);
            this.label_hex.Name = "label_hex";
            this.label_hex.Size = new System.Drawing.Size(2, 17);
            this.label_hex.TabIndex = 91;
            this.label_hex.TextChanged += new System.EventHandler(this.label_hex_TextChanged);
            // 
            // label_dec
            // 
            this.label_dec.AutoSize = true;
            this.label_dec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_dec.Location = new System.Drawing.Point(79, 131);
            this.label_dec.Name = "label_dec";
            this.label_dec.Size = new System.Drawing.Size(2, 17);
            this.label_dec.TabIndex = 92;
            // 
            // label_bin
            // 
            this.label_bin.AutoSize = true;
            this.label_bin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_bin.Location = new System.Drawing.Point(79, 156);
            this.label_bin.Name = "label_bin";
            this.label_bin.Size = new System.Drawing.Size(2, 17);
            this.label_bin.TabIndex = 93;
            // 
            // textBox1_Result
            // 
            this.textBox1_Result.BackColor = System.Drawing.Color.White;
            this.textBox1_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_Result.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_Result.Location = new System.Drawing.Point(230, 108);
            this.textBox1_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1_Result.Multiline = true;
            this.textBox1_Result.Name = "textBox1_Result";
            this.textBox1_Result.ReadOnly = true;
            this.textBox1_Result.Size = new System.Drawing.Size(134, 40);
            this.textBox1_Result.TabIndex = 94;
            this.textBox1_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "출력";
            // 
            // radioButton_hex
            // 
            this.radioButton_hex.AutoSize = true;
            this.radioButton_hex.Location = new System.Drawing.Point(12, 106);
            this.radioButton_hex.Name = "radioButton_hex";
            this.radioButton_hex.Size = new System.Drawing.Size(56, 19);
            this.radioButton_hex.TabIndex = 96;
            this.radioButton_hex.TabStop = true;
            this.radioButton_hex.Text = "HEX";
            this.radioButton_hex.UseVisualStyleBackColor = true;
            this.radioButton_hex.CheckedChanged += new System.EventHandler(this.radioButton_hex_CheckedChanged);
            // 
            // radioButton_dec
            // 
            this.radioButton_dec.AutoSize = true;
            this.radioButton_dec.Location = new System.Drawing.Point(12, 131);
            this.radioButton_dec.Name = "radioButton_dec";
            this.radioButton_dec.Size = new System.Drawing.Size(57, 19);
            this.radioButton_dec.TabIndex = 97;
            this.radioButton_dec.TabStop = true;
            this.radioButton_dec.Text = "DEC";
            this.radioButton_dec.UseVisualStyleBackColor = true;
            this.radioButton_dec.CheckedChanged += new System.EventHandler(this.radioButton_dec_CheckedChanged);
            // 
            // radioButton_bin
            // 
            this.radioButton_bin.AutoSize = true;
            this.radioButton_bin.Location = new System.Drawing.Point(12, 156);
            this.radioButton_bin.Name = "radioButton_bin";
            this.radioButton_bin.Size = new System.Drawing.Size(50, 19);
            this.radioButton_bin.TabIndex = 98;
            this.radioButton_bin.TabStop = true;
            this.radioButton_bin.Text = "BIN";
            this.radioButton_bin.UseVisualStyleBackColor = true;
            this.radioButton_bin.CheckedChanged += new System.EventHandler(this.radioButton_bin_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 506);
            this.Controls.Add(this.radioButton_bin);
            this.Controls.Add(this.radioButton_dec);
            this.Controls.Add(this.radioButton_hex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_Result);
            this.Controls.Add(this.label_bin);
            this.Controls.Add(this.label_dec);
            this.Controls.Add(this.label_hex);
            this.Controls.Add(this.btn_F);
            this.Controls.Add(this.btn_E);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.textBox2_Process);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_multiple);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "프로그래머 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TextBox textBox2_Process;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_multiple;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Label label_hex;
        private System.Windows.Forms.Label label_dec;
        private System.Windows.Forms.Label label_bin;
        private System.Windows.Forms.TextBox textBox1_Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_hex;
        private System.Windows.Forms.RadioButton radioButton_dec;
        private System.Windows.Forms.RadioButton radioButton_bin;
    }
}