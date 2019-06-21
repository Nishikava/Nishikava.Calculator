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
        /// <summary>
        /// Constructor.
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_Load(object sender, EventArgs e)
        {
            OutputWindow.TextAlign = HorizontalAlignment.Right;
        }

        /// <summary>
        /// Displaying characters.
        /// </summary>
        /// <param name="symbol">accepts a specific character.</param>
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

        /// <summary>
        /// Enter number "one".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void One_Click(object sender, EventArgs e)
        {
            OutputSymbol("1");
        }

        /// <summary>
        /// Enter number "two".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Two_Click(object sender, EventArgs e)
        {
            OutputSymbol("2");
        }

        /// <summary>
        /// Enter number "three".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Three_Click(object sender, EventArgs e)
        {
            OutputSymbol("3");
        }

        /// <summary>
        /// Enter number "four".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Four_Click(object sender, EventArgs e)
        {
            OutputSymbol("4");
        }

        /// <summary>
        /// Enter number "five".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Five_Click(object sender, EventArgs e)
        {
            OutputSymbol("5");
        }

        /// <summary>
        /// Enter number "six".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Six_Click(object sender, EventArgs e)
        {
            OutputSymbol("6");
        }

        /// <summary>
        /// Enter number "seven".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Seven_Click(object sender, EventArgs e)
        {
            OutputSymbol("7");
        }

        /// <summary>
        /// Enter number "eight".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eight_Click(object sender, EventArgs e)
        {
            OutputSymbol("8");
        }

        /// <summary>
        /// Enter number "nine".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nine_Click(object sender, EventArgs e)
        {
            OutputSymbol("9");
        }

        /// <summary>
        /// Enter number "zero".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zero_Click(object sender, EventArgs e)
        {
            OutputSymbol("0");
        }

        /// <summary>
        /// Clear all.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            OutputWindow.Clear();
        }

        /// <summary>
        /// Delete last character.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Enter character "division".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Division_Click(object sender, EventArgs e)
        {
            if(OutputWindow.TextLength == 0)
            {

            }
            else
            {
                OutputSymbol("/");
            }
        }

        /// <summary>
        /// Enter character "multiplication".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (OutputWindow.TextLength == 0)
            {

            }
            else
            {
                OutputSymbol("*");
            }
        }

        /// <summary>
        /// Enter character "subtraction".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Subtraction_Click(object sender, EventArgs e)
        {
            if (OutputWindow.TextLength == 0)
            {

            }
            else
            {
                OutputSymbol("-");
            }
        }

        /// <summary>
        /// Enter character "addition".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Addition_Click(object sender, EventArgs e)
        {
            if (OutputWindow.TextLength == 0)
            {

            }
            else
            {
                OutputSymbol("+");
            }
        }

        /// <summary>
        /// Enter character "parentheses".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Enter character "decimal separator".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecimalSeparator_Click(object sender, EventArgs e)
        {
            OutputSymbol(".");
        }

        /// <summary>
        /// Enter character "positive or negative".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PositiveOrNegative_Click(object sender, EventArgs e)
        {
            // TODO: Probably unnecessary function
        }

        /// <summary>
        /// Output of the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equals_Click(object sender, EventArgs e)
        {
            
        }       
    }
}
