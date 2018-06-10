using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntaxAnalyzator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _checkButton_Click(object sender, EventArgs e)
        {
            _resultLabel.Text = Regex.IsMatch(_inputTextBox.Text, @"^([0-9]{1,})([+\-*\/^]{1})([0-9]{1,})(([+\-*\/^]{1})([0-9]+))*$") ? "Zgodne" : "Nie zgodne";
        }
    }
}
