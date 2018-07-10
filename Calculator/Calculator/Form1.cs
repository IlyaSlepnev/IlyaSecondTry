using Calculator.twoArguments;
using Calculator.oneArgument;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMain(object sender, EventArgs e)
        {
            try
            {
                string firstValueText = textBox1.Text;
                double firstValue = Convert.ToDouble(firstValueText);
                string secondValueText = textBox2.Text;
                double secondValue = Convert.ToDouble(secondValueText);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstValue, secondValue);
                textBox3.Text = result.ToString();
            }
            catch (Exception TwoArgumentsException)
            {
                MessageBox.Show("Неверное выражение" + TwoArgumentsException);
            }
        }

        private void ClickMainOne(object sender, EventArgs e)
        {
            try
            {
                string thirdValueText = textBox4.Text;
                double thirdValue = Convert.ToDouble(thirdValueText);
                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double thirdValueResult = calculator.Calculate(thirdValue);
                textBox4.Text = thirdValueResult.ToString();
            }
            catch (Exception OneArgumentException)
            {
                MessageBox.Show("Неверное выражение" + OneArgumentException);
            }
        }

    }
}