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
            double a = Convert.ToDouble(ATextBox.Text);
            double b = Convert.ToDouble(BTextBox.Text);
            double c = Convert.ToDouble(CTextBox.Text);
            Logic logic = new Logic(a, b, c);
            AnswerTextBox.Text = logic.D;
        }
    }
}
