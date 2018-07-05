﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
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
                    string secondValueText = textBox3.Text;
                    double secondValue = Convert.ToDouble(secondValueText);
                    ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                    double result = calculator.Calculate(firstValue, secondValue);
                    textBox2.Text = result.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
