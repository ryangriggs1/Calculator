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
        double value = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }
        //0-9 and . buttons
        private void button_Click(object sender, EventArgs e)
        {
            if(resultBox.Text == "0")
            {
                resultBox.Clear();
            }

            Button b = (Button)sender;
            resultBox.Text = resultBox.Text + b.Text;
        }
        //CE button
        private void button17_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }
        // X + - / buttons
        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(resultBox.Text);
            resultBox.Text = "0";
        }
        // = button
        private void button16_Click(object sender, EventArgs e)
        {
            if(operation == "X")
            {
                resultBox.Text = (value * double.Parse(resultBox.Text)).ToString();
            }else if (operation == "+")
            {
                resultBox.Text = (value + double.Parse(resultBox.Text)).ToString();
            }
            else if(operation == "/")
            {
                resultBox.Text = (value / double.Parse(resultBox.Text)).ToString();
            }
            else if(operation == "-")
            {
                resultBox.Text = (value - double.Parse(resultBox.Text)).ToString();
            }
        }
        // +/- button
        private void button11_Click(object sender, EventArgs e)
        {
            value = double.Parse(resultBox.Text);
            if (value > 0)
            {
                resultBox.Text = (value * -1).ToString();
            }else if(value < 0)
            {
                resultBox.Text = (value * -1).ToString();
            }
        }
        //C button
        private void button18_Click(object sender, EventArgs e)
        {
            value = 0;
            resultBox.Text = "0";
        }
        //<=] button
        string deleteValue;
        private void button19_Click(object sender, EventArgs e)
        {
            deleteValue = resultBox.Text;
            deleteValue = (deleteValue.Substring(0, deleteValue.Length - 1));
            if(deleteValue.Length == 0)
            {
                resultBox.Text = "0";
            }
            else
            {
                resultBox.Text = deleteValue;
            }
        }
        //unit convesrion button
        private void button21_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
