using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        String line = "";
        String firstNum = "";
        String secondNum = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Focus();
            Button button = (Button)sender;
            if ((textBoxRes.Text == "0") || (isOperationPerformed))
                textBoxRes.Clear();

            isOperationPerformed = false;

            if(button.Text == ".")
            {
                if (!textBoxRes.Text.Contains("."))
                {
                    textBoxRes.Text = textBoxRes.Text + button.Text;
                }
            }
            else
            textBoxRes.Text = textBoxRes.Text + button.Text;
            secondNum = "" + textBoxRes.Text;
        }


        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue == Double.Parse(textBoxRes.Text))
            {
                resultValue = 0;
            }

            if (resultValue != 0)
            {
                buttonRes.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                firstNum = " " + resultValue;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBoxRes.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                firstNum = " " + resultValue;
                isOperationPerformed = true;
            }
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonRes.PerformClick();
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxRes.Text = ((resultValue) + Double.Parse(textBoxRes.Text)).ToString();                  
                    break;
                case "x":
                    textBoxRes.Text = ((resultValue) * Double.Parse(textBoxRes.Text)).ToString();
                    break;
                case "-":
                    textBoxRes.Text = ((resultValue) - Double.Parse(textBoxRes.Text)).ToString();
                    break ;
                case "÷":
                    textBoxRes.Text = ((resultValue) / Double.Parse(textBoxRes.Text)).ToString();
                    break;
                case "1/x":
                    textBoxRes.Text = (1 / Double.Parse(textBoxRes.Text)).ToString();
                    break;
                case "√":
                    textBoxRes.Text = (Math.Sqrt(Double.Parse(textBoxRes.Text))).ToString();
                    break;
                case "x^2":
                    textBoxRes.Text = (Math.Pow(Double.Parse(textBoxRes.Text), 2)).ToString();
                    break;
                default:
                    textBoxRes.Text = "None";
                    break;
            }
            resultValue = Double.Parse(textBoxRes.Text);
            line = firstNum + " " + operationPerformed + " " + secondNum + " " + " = " +  resultValue;
            history.Items.Add(line);
            labelCurrentOperation.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxRes.Text = "0";
            resultValue = 0;
        }
  
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            switch(e.KeyChar.ToString())
            {
                case "1":
                    buttonOne.PerformClick();
                    break;
                case "2":
                    buttonTwo.PerformClick();
                    break;
                case "3":
                    buttonThree.PerformClick();
                    break ;
                case "4":
                    buttonFour.PerformClick();  
                    break;
                case "5":
                    buttonFive.PerformClick();
                    break;
                case "6":
                    buttonSix.PerformClick();
                    break;
                case "7":
                    buttonSeven.PerformClick();
                    break;
                case "8":
                    buttonEight.PerformClick();
                    break;
                case "9":
                    buttonNine.PerformClick();
                    break;
                case "+":
                    buttonAdd.PerformClick();
                    break;
                case "-":
                    buttonSub.PerformClick();
                    break;
                case "*":
                    buttonMul.PerformClick();
                    break;
                case "÷":
                    buttonDiv.PerformClick();
                    break;
   
            }
         
        }

    }
}
