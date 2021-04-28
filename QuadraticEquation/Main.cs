using System;
using System.Windows.Forms;

namespace QuadraticEquation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ATextBox.Select();
        }

        private void DisplayAnswerButton_Click(object sender, EventArgs e)
        {
            Answer(ATextBox, BTextBox, CTextBox, AnswerTextBox);
        }

        private void ATextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BTextBox.Focus();
            }
        }

        private void BTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CTextBox.Focus();
            }
        }

        private void CTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Answer(ATextBox, BTextBox, CTextBox, AnswerTextBox);
            }
        }

        public static void Answer(RichTextBox aTextBox, RichTextBox bTextBox, RichTextBox cTextBox, RichTextBox ansTextBox)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            #region DataChecking
            if (Double.TryParse(aTextBox.Text, out double result1))
            {
                a = result1;
            }
            else
            {
                throw new ArgumentException("Invalid value a");
            }

            if (Double.TryParse(bTextBox.Text, out double result2))
            {
                b = result2;

            }
            else
            {
                throw new ArgumentException("Invalid value b");
            }

            if (Double.TryParse(cTextBox.Text, out double result3))
            {
                c = result3;
            }
            else
            {
                throw new ArgumentException("Invalid value c");
            }
            #endregion
            Logic logic = new Logic(a, b, c);
            ansTextBox.Text = logic.D;
        }
    }
}
