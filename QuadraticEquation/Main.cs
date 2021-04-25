using System;
using System.Windows.Forms;

namespace QuadraticEquation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void DisplayAnswerButton_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            #region DataChecking
            if (Double.TryParse(ATextBox.Text, out double result1))
            {
                a = result1;
            }
            else
            {
                throw new ArgumentException("Invalid value a");
            }

            if (Double.TryParse(BTextBox.Text, out double result2))
            {
                b = result2;

            }
            else
            {
                throw new ArgumentException("Invalid value b");
            }

            if (Double.TryParse(CTextBox.Text, out double result3))
            {
                c = result3;
            }
            else
            {
                throw new ArgumentException("Invalid value c");
            }
            #endregion
            Logic logic = new Logic(a, b, c);
            AnswerTextBox.Text = logic.D;
        }
    }
}
