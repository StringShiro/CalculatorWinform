using System;
using System.Windows.Forms;

namespace CalculatorWinform
{
    public partial class CalculatorWinform : Form
    {
        double result_value = 0;
        String operatorPerformed = "";
        bool enter_value = false;
        char isOperation;

        public CalculatorWinform()
        {
            InitializeComponent();
        }

        void btn_numberClicked_event(object sender, EventArgs e) {
            Button b = (Button)sender;
            if ((Rtxt_displayResult.Text == "0") || (enter_value)) {
                Rtxt_displayResult.Text = "";
                enter_value = false;
            }

            if (b.Text == ".")
            {
                if (Rtxt_displayResult.Text.Contains("."))
                { Rtxt_displayResult.Text = Rtxt_displayResult.Text + b.Text; }
            }
            else { Rtxt_displayResult.Text = Rtxt_displayResult.Text + b.Text; }
        }
        void btn_OperatorClicked(object sender, EventArgs e) {
            Button b = (Button)sender;
            if (result_value != 0) {
                btn_equal.PerformClick();
                enter_value=true;
                operatorPerformed = b.Text;
                Standard.Text = System.Convert.ToString(result_value) + " " + operatorPerformed;
            }
            else 
            { 
                operatorPerformed = b.Text;
                result_value = Double.Parse(Rtxt_displayResult.Text);
                Rtxt_displayResult.Text = "";
                Standard.Text = System.Convert.ToString(result_value) + " " + operatorPerformed;
                enter_value = true;
            }
        }

        void btn_operatorPerformed_event(object sender, EventArgs e) {
            Standard.Text = "";
            switch (operatorPerformed)
            {
                case "+":
                    Rtxt_displayResult.Text = (result_value + Double.Parse(Rtxt_displayResult.Text)).ToString();
                    break;
                case "-":
                    Rtxt_displayResult.Text = (result_value + Double.Parse(Rtxt_displayResult.Text)).ToString();
                    break;
                case "/":
                    Rtxt_displayResult.Text = (result_value + Double.Parse(Rtxt_displayResult.Text)).ToString();
                    break;
                case "*":
                    Rtxt_displayResult.Text = (result_value + Double.Parse(Rtxt_displayResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            result_value = Double.Parse(Rtxt_displayResult.Text);
            operatorPerformed = "";
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Rtxt_displayResult.Text.Length > 0 ) {
                Rtxt_displayResult.Text = Rtxt_displayResult.Text.Remove(Rtxt_displayResult.Text.Length - 1, 1);
            }
            if (Rtxt_displayResult.Text == "")
            {
                Rtxt_displayResult.Text = "0";
            }
        }

        private void CalculatorWinform_Load(object sender, EventArgs e)
        {

        }

        private void btn_number1_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number3_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number4_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number5_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number6_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number7_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number8_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number9_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_number0_Click(object sender, EventArgs e)
        {
            btn_numberClicked_event(sender, e);
        }

        private void btn_divine_Click(object sender, EventArgs e)
        {
            btn_OperatorClicked(sender, e);
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            btn_OperatorClicked(sender, e);
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            btn_OperatorClicked(sender, e);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            btn_OperatorClicked(sender, e);
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            btn_operatorPerformed_event(sender,e);
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            btn_OperatorClicked(sender, e);
        }

        private void btn_expendational_Click(object sender, EventArgs e)
        {

        }

        private void Rtxt_displayResult_TextChanged(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Standard_Click(object sender, EventArgs e)
        {

        }
    }
}
