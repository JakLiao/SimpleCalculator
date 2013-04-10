namespace SimpleCalculator
{
    partial class calForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.displayText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClsOnce = new System.Windows.Forms.Button();
            this.buttonFu = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPerc = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonCal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnScience = new System.Windows.Forms.RadioButton();
            this.radioBtnNormal = new System.Windows.Forms.RadioButton();
            this.toolTipSci = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNorl = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCal_Hiden = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayText.Font = new System.Drawing.Font("宋体", 14F);
            this.displayText.Location = new System.Drawing.Point(-1, -1);
            this.displayText.Multiline = true;
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.Size = new System.Drawing.Size(258, 32);
            this.displayText.TabIndex = 0;
            this.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultText
            // 
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultText.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultText.Location = new System.Drawing.Point(-1, 31);
            this.resultText.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(258, 33);
            this.resultText.TabIndex = 1;
            this.resultText.Text = "0";
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.Location = new System.Drawing.Point(13, 83);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(52, 32);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClear.Location = new System.Drawing.Point(121, 83);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(52, 32);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonClear.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonClear.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // buttonClsOnce
            // 
            this.buttonClsOnce.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClsOnce.Location = new System.Drawing.Point(67, 83);
            this.buttonClsOnce.Name = "buttonClsOnce";
            this.buttonClsOnce.Size = new System.Drawing.Size(52, 32);
            this.buttonClsOnce.TabIndex = 4;
            this.buttonClsOnce.Text = "CE";
            this.buttonClsOnce.UseVisualStyleBackColor = false;
            this.buttonClsOnce.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonClsOnce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonClsOnce.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonClsOnce.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // buttonFu
            // 
            this.buttonFu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFu.Location = new System.Drawing.Point(175, 83);
            this.buttonFu.Name = "buttonFu";
            this.buttonFu.Size = new System.Drawing.Size(52, 32);
            this.buttonFu.TabIndex = 5;
            this.buttonFu.Text = "±";
            this.buttonFu.UseVisualStyleBackColor = false;
            this.buttonFu.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonFu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonFu.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonFu.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSqrt.Location = new System.Drawing.Point(229, 83);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(52, 32);
            this.buttonSqrt.TabIndex = 6;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonSqrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonSqrt.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonSqrt.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 121);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 32);
            this.button7.TabIndex = 2;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnNumber_Click);
            this.button7.Enter += new System.EventHandler(this.button2_Enter);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button7.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(121, 121);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 32);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnNumber_Click);
            this.button9.Enter += new System.EventHandler(this.button2_Enter);
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button9.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(67, 121);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 32);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnNumber_Click);
            this.button8.Enter += new System.EventHandler(this.button2_Enter);
            this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button8.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDivide.Location = new System.Drawing.Point(175, 121);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(52, 32);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonDivide.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonDivide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonDivide.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonDivide.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // buttonPerc
            // 
            this.buttonPerc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPerc.Location = new System.Drawing.Point(229, 121);
            this.buttonPerc.Name = "buttonPerc";
            this.buttonPerc.Size = new System.Drawing.Size(52, 32);
            this.buttonPerc.TabIndex = 6;
            this.buttonPerc.Text = "%";
            this.buttonPerc.UseVisualStyleBackColor = false;
            this.buttonPerc.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonPerc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonPerc.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonPerc.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnNumber_Click);
            this.button4.Enter += new System.EventHandler(this.button2_Enter);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button4.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(121, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 32);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnNumber_Click);
            this.button6.Enter += new System.EventHandler(this.button2_Enter);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button6.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnNumber_Click);
            this.button5.Enter += new System.EventHandler(this.button2_Enter);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button5.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMul.Location = new System.Drawing.Point(175, 159);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(52, 32);
            this.buttonMul.TabIndex = 5;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonMul.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonMul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonMul.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonMul.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button15.Location = new System.Drawing.Point(229, 159);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 32);
            this.button15.TabIndex = 6;
            this.button15.Text = "1/x";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Enter += new System.EventHandler(this.button2_Enter);
            this.button15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button15.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button15.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNumber_Click);
            this.button1.Enter += new System.EventHandler(this.button2_Enter);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button1.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNumber_Click);
            this.button3.Enter += new System.EventHandler(this.button2_Enter);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button3.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNumber_Click);
            this.button2.Enter += new System.EventHandler(this.button2_Enter);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button2.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinus.Location = new System.Drawing.Point(175, 197);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(52, 32);
            this.buttonMinus.TabIndex = 5;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonMinus.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonMinus.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonMinus.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // buttonCal
            // 
            this.buttonCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCal.Location = new System.Drawing.Point(229, 197);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(52, 70);
            this.buttonCal.TabIndex = 6;
            this.buttonCal.Text = "=";
            this.buttonCal.UseVisualStyleBackColor = false;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            this.buttonCal.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonCal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonCal.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonCal.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(13, 235);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(106, 32);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            this.button0.Enter += new System.EventHandler(this.button2_Enter);
            this.button0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.button0.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.button0.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(121, 235);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(52, 32);
            this.buttonDot.TabIndex = 3;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            this.buttonDot.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonDot.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonDot.MouseLeave += new System.EventHandler(this.buttonColor_MouseLeave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAdd.Location = new System.Drawing.Point(175, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(52, 32);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.btnOperator_Click);
            this.buttonAdd.Enter += new System.EventHandler(this.button2_Enter);
            this.buttonAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonColor_MouseEnter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonLightColor_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonCal_Hiden);
            this.panel1.Controls.Add(this.resultText);
            this.panel1.Controls.Add(this.displayText);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 65);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnScience);
            this.groupBox1.Controls.Add(this.radioBtnNormal);
            this.groupBox1.Location = new System.Drawing.Point(13, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator Mode";
            // 
            // radioBtnScience
            // 
            this.radioBtnScience.AutoSize = true;
            this.radioBtnScience.Location = new System.Drawing.Point(149, 20);
            this.radioBtnScience.Name = "radioBtnScience";
            this.radioBtnScience.Size = new System.Drawing.Size(65, 16);
            this.radioBtnScience.TabIndex = 1;
            this.radioBtnScience.Text = "Science";
            this.toolTipSci.SetToolTip(this.radioBtnScience, "First multiplication and division, then addition and subtraction");
            this.radioBtnScience.UseVisualStyleBackColor = true;
            this.radioBtnScience.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioBtnNormal
            // 
            this.radioBtnNormal.AutoSize = true;
            this.radioBtnNormal.Checked = true;
            this.radioBtnNormal.Location = new System.Drawing.Point(47, 20);
            this.radioBtnNormal.Name = "radioBtnNormal";
            this.radioBtnNormal.Size = new System.Drawing.Size(59, 16);
            this.radioBtnNormal.TabIndex = 0;
            this.radioBtnNormal.TabStop = true;
            this.radioBtnNormal.Text = "Normal";
            this.toolTipNorl.SetToolTip(this.radioBtnNormal, "Ignore the order of operations");
            this.radioBtnNormal.UseVisualStyleBackColor = true;
            this.radioBtnNormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonCal_Hiden
            // 
            this.buttonCal_Hiden.Location = new System.Drawing.Point(85, 2);
            this.buttonCal_Hiden.Name = "buttonCal_Hiden";
            this.buttonCal_Hiden.Size = new System.Drawing.Size(93, 23);
            this.buttonCal_Hiden.TabIndex = 9;
            this.buttonCal_Hiden.UseVisualStyleBackColor = true;
            this.buttonCal_Hiden.Visible = false;
            this.buttonCal_Hiden.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // calForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.buttonPerc);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonFu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonClsOnce);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClsOnce;
        private System.Windows.Forms.Button buttonFu;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonPerc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnScience;
        private System.Windows.Forms.RadioButton radioBtnNormal;
        private System.Windows.Forms.ToolTip toolTipSci;
        private System.Windows.Forms.ToolTip toolTipNorl;
        private System.Windows.Forms.Button buttonCal_Hiden;

    }
}

