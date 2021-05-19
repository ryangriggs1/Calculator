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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cmTxtBox.Enabled = false;
            mTxtBox.Enabled = false;
            kmTxtBox.Enabled = false;
            metricCB.Checked = true;

        }
        double inch, feet, miles, cm, m, km = 0;
        //clear button
        private void button3_Click(object sender, EventArgs e)
        {
            inTxtBox.Text = "0";
            ftTxtBox.Text = "0";
            miTxtBox.Text = "0";
            cmTxtBox.Text = "0";
            mTxtBox.Text = "0";
            kmTxtBox.Text = "0";
        }

        //done button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //convert button
        private void button2_Click(object sender, EventArgs e)
        {
            if (metricCB.Checked)
            {
                inTxtBox.Enabled = true;
                ftTxtBox.Enabled = true;
                miTxtBox.Enabled = true;
                cmTxtBox.Enabled = false;
                mTxtBox.Enabled = false;
                kmTxtBox.Enabled = false;
                inch = double.Parse(inTxtBox.Text);
                feet = double.Parse(ftTxtBox.Text);
                miles = double.Parse(miTxtBox.Text);
                if (inch != 0)
                {
                    cm = inch * 2.56;
                    cmTxtBox.Text = cm.ToString();
                }
                if (feet != 0)
                {
                    m = feet * 0.3048;
                    mTxtBox.Text = m.ToString();
                }
                if (miles != 0)
                {
                    km = miles * 1.60934;
                    kmTxtBox.Text = km.ToString();
                }
            }
            else if (imperialCB.Checked)
            {
                inTxtBox.Enabled = false;
                ftTxtBox.Enabled = false;
                miTxtBox.Enabled = false;
                cmTxtBox.Enabled = true;
                mTxtBox.Enabled = true;
                kmTxtBox.Enabled = true;
                cm = double.Parse(cmTxtBox.Text);
                m = double.Parse(mTxtBox.Text);
                km = double.Parse(kmTxtBox.Text);
                if (cm != 0)
                {
                    inch = cm * 0.3937007874;
                    inTxtBox.Text = inch.ToString();
                }
                if (m != 0)
                {
                    feet = m * 3.28084;
                    ftTxtBox.Text = feet.ToString();
                }
                if (km != 0)
                {
                    miles = km / 1.609344;
                    miTxtBox.Text = miles.ToString();
                }
            }
            else
            {
                inTxtBox.Enabled = false;
                ftTxtBox.Enabled = false;
                miTxtBox.Enabled = false;
                cmTxtBox.Enabled = false;
                mTxtBox.Enabled = false;
                kmTxtBox.Enabled = false;
            }
        }
    }
}
