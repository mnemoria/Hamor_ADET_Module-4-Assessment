using System;
using System.Windows;
using System.Windows.Controls;

/** GUI & WPF!
    This program creates a form using the
    Toolbox in Visual studio to create a 
    calculator where the user can add, 
    subtract, multiply, and divide numbers
   
    @author: Mary Grizelle Hamor
    @section: BSCS 3-1N
    @date: January 12, 2023
 */

namespace Hamor_ADET_Module_4_Assessment
{
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOperator(object operation, RoutedEventArgs e)
        {
            double num1 = getNumber(this.txtNumber1);
            double num2 = getNumber(this.txtNumber2);

            Button? button = operation as Button;
            string buttonOperator = button.Name;

            double answer = 0;
            switch (buttonOperator)
            {
                case "btnAdd":
                    answer = num1 + num2;
                    break;
                case "btnSubtract":
                    answer = num1 - num2;
                    break;
                case "btnMultiply":
                    answer = num1 * num2;
                    break;
                case "btnDivide":
                    answer = num1 / num2;
                    break;
            }

            lblAnswer.Content = "The answer is " + answer.ToString("#,##0.00");
            lblAnswer.Visibility = Visibility.Visible;
        }

        private double getNumber(TextBox txtNumber)
        {
            double thisNumber;

            try
            {
                double number = Convert.ToDouble(txtNumber.Text);
                return number;
            }
            catch
            {
                thisNumber = 0;
            }

            if (thisNumber == 0)
            {
                MessageBox.Show("You haven't entered a valid number in this text box!", "Error");
                txtNumber.Focus();
                return 0;
            }
            else
            {
                return thisNumber;
            }
        }
    }
}
