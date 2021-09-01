using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private string funny_message(string calculate_type)
        {
            string message = "";
            switch (calculate_type)
            {
                case "+":
                    message = "is it your salary ? 😲 \n";
                    break;

                case "-":
                    message = "how'd you lose that money ? 😥 \n";
                    break;

                case "*":
                    message = "are you an investor ? 😎 \n";
                    break;

                case "/":
                    message = "share with me too ? 🤑 \n";
                    break;
            }

            return message;
        }

        private void calculate(string _firstNumber, string _secondNumber, string calculate_type)
        {
            string firstNumber = _firstNumber.Replace(" ", "");
            string secondNumber = _secondNumber.Replace(" ", "");
            if (firstNumber == "" || secondNumber == "")
            {
                lbResultMessage.Text = Convert.ToString("please, insert the numbers 😅");
            }
            else
            {
                decimal result = 0;
                switch (calculate_type)
                {
                    case "+":
                        result = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                        break;

                    case "-":
                        result = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                        break;

                    case "*":
                        result = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                        break;

                    case "/":
                        result = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                        break;
                }
                string custom_message = funny_message(calculate_type);
                lbResultMessage.Text = custom_message + result;
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            string firstNumber = tbFirstNumber.Text;
            string secondNumber = tbSecondNumber.Text;
            calculate(firstNumber, secondNumber, "+");
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            string firstNumber = tbFirstNumber.Text;
            string secondNumber = tbSecondNumber.Text;
            calculate(firstNumber, secondNumber, "-");
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            string firstNumber = tbFirstNumber.Text;
            string secondNumber = tbSecondNumber.Text;
            calculate(firstNumber, secondNumber, "*");
        }

        private void Div_Click(object sender, EventArgs e)
        {
            string firstNumber = tbFirstNumber.Text;
            string secondNumber = tbSecondNumber.Text;
            calculate(firstNumber, secondNumber, "/");
        }

        private void load_combobox()
        {
            cbbSocialMedia.Items.Add("github");
            cbbSocialMedia.Items.Add("linkedin");
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            load_combobox();

        }

        private void cbbSocialMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSocialMedia.SelectedItem)
            {
                case "github":
                    System.Diagnostics.Process.Start("www.github.com/okatsuo");
                    break;

                case "linkedin":
                    System.Diagnostics.Process.Start("www.linkedin.com/in/rafael-goncanna/");
                    break;
            }
        }
    }
}
