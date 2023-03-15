namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.textBox2_Process = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_multiple = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.textBox1_Result = new System.Windows.Forms.TextBox();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dot.Location = new System.Drawing.Point(194, 352);
            this.btn_dot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(86, 52);
            this.btn_dot.TabIndex = 48;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_0.Location = new System.Drawing.Point(102, 353);
            this.btn_0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(86, 51);
            this.btn_0.TabIndex = 47;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // textBox2_Process
            // 
            this.textBox2_Process.BackColor = System.Drawing.Color.White;
            this.textBox2_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2_Process.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2_Process.Location = new System.Drawing.Point(14, 40);
            this.textBox2_Process.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2_Process.Multiline = true;
            this.textBox2_Process.Name = "textBox2_Process";
            this.textBox2_Process.ReadOnly = true;
            this.textBox2_Process.Size = new System.Drawing.Size(175, 52);
            this.textBox2_Process.TabIndex = 46;
            this.textBox2_Process.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_result.Location = new System.Drawing.Point(284, 352);
            this.btn_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(86, 52);
            this.btn_result.TabIndex = 45;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_clear.Location = new System.Drawing.Point(14, 352);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 52);
            this.btn_clear.TabIndex = 44;
            this.btn_clear.Text = "c";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_multiple
            // 
            this.btn_multiple.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_multiple.Location = new System.Drawing.Point(284, 179);
            this.btn_multiple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_multiple.Name = "btn_multiple";
            this.btn_multiple.Size = new System.Drawing.Size(86, 52);
            this.btn_multiple.TabIndex = 43;
            this.btn_multiple.Text = "x";
            this.btn_multiple.UseVisualStyleBackColor = true;
            this.btn_multiple.Click += new System.EventHandler(this.btn_multiple_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_minus.Location = new System.Drawing.Point(284, 237);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(86, 52);
            this.btn_minus.TabIndex = 42;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_plus.Location = new System.Drawing.Point(284, 293);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(86, 52);
            this.btn_plus.TabIndex = 41;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_divide.Location = new System.Drawing.Point(284, 121);
            this.btn_divide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(86, 52);
            this.btn_divide.TabIndex = 40;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // textBox1_Result
            // 
            this.textBox1_Result.BackColor = System.Drawing.Color.White;
            this.textBox1_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_Result.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_Result.Location = new System.Drawing.Point(14, 119);
            this.textBox1_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1_Result.Multiline = true;
            this.textBox1_Result.Name = "textBox1_Result";
            this.textBox1_Result.ReadOnly = true;
            this.textBox1_Result.Size = new System.Drawing.Size(175, 52);
            this.textBox1_Result.TabIndex = 39;
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_7.Location = new System.Drawing.Point(14, 179);
            this.btn_7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(82, 52);
            this.btn_7.TabIndex = 36;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_6.Location = new System.Drawing.Point(194, 239);
            this.btn_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(86, 48);
            this.btn_6.TabIndex = 35;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_5.Location = new System.Drawing.Point(102, 239);
            this.btn_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(87, 48);
            this.btn_5.TabIndex = 34;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_4.Location = new System.Drawing.Point(14, 239);
            this.btn_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(82, 48);
            this.btn_4.TabIndex = 33;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_3.Location = new System.Drawing.Point(194, 293);
            this.btn_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(86, 52);
            this.btn_3.TabIndex = 32;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_2.Location = new System.Drawing.Point(102, 293);
            this.btn_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(87, 52);
            this.btn_2.TabIndex = 31;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_1.Location = new System.Drawing.Point(14, 293);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(82, 52);
            this.btn_1.TabIndex = 30;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "출력";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "표준",
            "프로그래머"});
            this.comboBox1.Location = new System.Drawing.Point(16, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_8.Location = new System.Drawing.Point(102, 179);
            this.btn_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(87, 52);
            this.btn_8.TabIndex = 37;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_9.Location = new System.Drawing.Point(194, 179);
            this.btn_9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(86, 52);
            this.btn_9.TabIndex = 38;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.Location = new System.Drawing.Point(194, 123);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 52);
            this.btn_delete.TabIndex = 49;
            this.btn_delete.Text = "del";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 410);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.textBox2_Process);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_multiple);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.textBox1_Result);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "표준 계산기";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TextBox textBox2_Process;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_multiple;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.TextBox textBox1_Result;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_delete;
    }
}

