using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class calForm : Form
    {
        CCalculator cal;
        public calForm()
        {
            InitializeComponent();
        }

        private void calForm_Load(object sender, EventArgs e)
        {
            displayText.Text = string.Empty;
            cal = new CCalculator();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            resultText.Text = cal.Back();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayText.Text = cal.Clear();
            resultText.Text = cal.RClear();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                resultText.Text = cal.NumberKey(btnSender.Text);
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                try
                {
                    cal.Result = Convert.ToDouble(resultText.Text);
                }
                catch (FormatException ex)
                {
                    return;
                }
                if (displayText.Text == "")
                {
                    displayText.Text = resultText.Text + cal.SetOperatorByLetter(btnSender.Text);   
                }
                else
                {
                    displayText.Text += cal.SetOperatorByLetter(btnSender.Text);
                }
                cal.DisplayStr = string.Empty;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (cal.DotUsed() == -1)
            {
                resultText.Text = cal.NumberKey(buttonDot.Text);
            }
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            cal.Result = Convert.ToDouble(resultText.Text);
            resultText.Text = cal.Calc();
            displayText.Text = string.Empty; 
        }

        private void buttonColor_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                btnSender.BackColor = Color.Khaki;
            }
        }

        private void buttonColor_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                btnSender.ResetBackColor();
            }
        }

        private void buttonLightColor_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                btnSender.BackColor = SystemColors.ControlLight;
            }
        }
        #region 键盘输入按键keydown事件
        private void Calc_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Back:
                    buttonBack.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad0:
                    button0.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D0:
                    button0.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad1:
                    button1.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D1:
                    button1.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D2:
                    button2.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D3:
                    button3.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D4:
                    button4.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D5:
                    button5.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D6:
                    button6.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D7:
                    button7.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D8:
                    button8.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D9:
                    button9.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Divide:
                    buttonDivide.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Add:
                    buttonAdd.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Multiply:
                    buttonMul.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Subtract:
                    buttonMinus.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Decimal:
                    buttonDot.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    buttonCal.PerformClick();
                    e.Handled = true;
                    break;
                default: break;
            }
            //if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            //    InsertButton("0");
            //else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            //    InsertButton("1");
            //else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            //    InsertButton("2");
            //else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            //    InsertButton("3");
            //else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            //    InsertButton("4");
            //else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            //    InsertButton("5");
            //else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            //    InsertButton("6");
            //else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            //    InsertButton("7");
            //else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            //    InsertButton("8");
            //else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            //    InsertButton("9");
            //else if (e.KeyCode == Keys.Back)
            //    if (this.tbDisplay.Text != "")
            //        this.tbDisplay.Text = this.tbDisplay.Text.Remove(this.tbDisplay.Text.Length - 1);
            //    else ;
            //else if (e.KeyCode == Keys.Divide)
            //{
            //    if (!(add || sub || div || mul))
            //        saveCurrentNumber();
            //    add = false;
            //    sub = false;
            //    div = true;
            //    mul = false;
            //}
            //else if (e.KeyCode == Keys.Multiply)
            //{
            //    if (!(add || sub || div || mul))
            //        saveCurrentNumber();
            //    add = false;
            //    sub = false;
            //    div = false;
            //    mul = true;
            //}
        }
        #endregion
    }
}
