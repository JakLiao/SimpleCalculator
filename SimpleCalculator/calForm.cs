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
            displayText.Text = cal.Back();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayText.Text = cal.Clear();
        }

        private void btnNumber_Clicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;

                displayText.Text = cal.NumberKey(btnSender.Text);
            }
        }
    }
}
