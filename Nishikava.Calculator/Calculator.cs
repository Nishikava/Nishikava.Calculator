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
            
        }

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

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Division_Click(object sender, EventArgs e)
        {
            OutputSymbol("/");
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            OutputSymbol("x");
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
            OutputSymbol("=");
        }
    }
}
