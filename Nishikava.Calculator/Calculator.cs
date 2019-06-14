using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nishikava.Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            OutputWindow.TextAlign = HorizontalAlignment.Right;
        }

        /// <summary>
        /// Displaying characters
        /// </summary>
        /// <param name="symbol">accepts a specific character</param>
        public void OutputSymbol(string symbol)
        {
            if (OutputWindow.Text != null)
            {
                OutputWindow.Text = OutputWindow.Text + symbol;
            }
            else
            {
                OutputWindow.Text = symbol;
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            OutputSymbol("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            OutputSymbol("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            OutputSymbol("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            OutputSymbol("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            OutputSymbol("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            OutputSymbol("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            OutputSymbol("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            OutputSymbol("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            OutputSymbol("9");
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            OutputSymbol("0");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            OutputWindow.Clear();
        }

        private void DeleteOneCharacter_Click(object sender, EventArgs e)
        {
            string[] text = new string[OutputWindow.TextLength];
            int counterIndex = 0;

            for (counterIndex = 0; counterIndex < OutputWindow.TextLength; counterIndex++)
            {
                text[counterIndex] = OutputWindow.Text[counterIndex].ToString();
            }

            if (text.Length == 0)
            {

            }
            else
            {
                text[counterIndex - 1] = null;
                OutputWindow.Clear();
            }

            for (int counterOutputWindow = 0; counterOutputWindow < text.Length; counterOutputWindow++)
            {
                OutputSymbol(text[counterOutputWindow]);
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            OutputSymbol("/");
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            OutputSymbol("*");
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            OutputSymbol("-");
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            OutputSymbol("+");
        }

        private void Parentheses_Click(object sender, EventArgs e)
        {           
            int numberOfParentesis = 0;

            for (int counterIndex = 0; counterIndex < OutputWindow.TextLength; counterIndex++)
            {               
                if (OutputWindow.Text[counterIndex].ToString() == "(" || OutputWindow.Text[counterIndex].ToString() == ")")
                {
                    numberOfParentesis++;
                }
            }
            
            var parity = numberOfParentesis % 2 == 0 ? true : false;

            switch (parity)
            {
                case true:
                    if (numberOfParentesis == 0)
                    {
                        OutputSymbol("(");
                    }
                    if (OutputWindow.Text[OutputWindow.TextLength - 1].ToString() == "-" ||
                     OutputWindow.Text[OutputWindow.TextLength - 1].ToString() == "+" ||
                     OutputWindow.Text[OutputWindow.TextLength - 1].ToString() == "*" ||
                     OutputWindow.Text[OutputWindow.TextLength - 1].ToString() == "/" ||
                     OutputWindow.Text[OutputWindow.TextLength - 1].ToString() == "(")
                    {
                        if(numberOfParentesis != 0)
                        {
                            OutputSymbol("(");
                        }
                        
                    }
                    else
                    {
                        if(parity == true && OutputWindow.Text[OutputWindow.TextLength - 1].ToString() == ")")
                        {

                        }
                        else
                        {
                            OutputSymbol(")");
                        }                        
                    }
                    
                    break;
                case false:
                    if (OutputWindow.Text[OutputWindow.TextLength-1].ToString() == "(" ||
                     OutputWindow.Text[OutputWindow.TextLength-1].ToString() == "-" ||
                     OutputWindow.Text[OutputWindow.TextLength-1].ToString() == "+" || 
                     OutputWindow.Text[OutputWindow.TextLength-1].ToString() == "*" ||
                     OutputWindow.Text[OutputWindow.TextLength-1].ToString() == "/")
                    {
                        OutputSymbol("(");
                    }
                    else
                    {
                        OutputSymbol(")");
                    }                   
                    break;
                default:
                    break;
            }           
        }

        private void DecimalSeparator_Click(object sender, EventArgs e)
        {
            OutputSymbol(".");
        }

        private void PositiveOrNegative_Click(object sender, EventArgs e)
        {

        }

        private void Equals_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}
