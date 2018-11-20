using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnetting
{
    public partial class Form1 : Form
    {
        public int firstIP;
        public int secondIP;
        public int thirdIP;
        public int fourthIP;
        public int firstSUB;
        public int secondSUB;
        public int thirdSUB;
        public int fourthSUB;
        public bool canCal = true;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

        public int CheckInput(string input, int output)
        {
            if (int.TryParse(input, out output))
            {
                if (output < 0)
                {
                    canCal = false;
                }
                else if (output > 255)
                {
                    canCal = false;
                }
            }
            else { canCal = false; }
            return output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstIP = CheckInput(textBox1.Text, firstIP);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            secondIP = CheckInput(textBox2.Text, secondIP);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            thirdIP = CheckInput(textBox3.Text, thirdIP);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            fourthIP = CheckInput(textBox4.Text, fourthIP);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LB = "---------------------------------"; //linebreak
            
            if (!canCal)
            {
                richTextBox1.Text = "Cannot calculate.";
                return;
            }
            
            richTextBox1.Text =
                Convert.ToString(firstIP) + "." + Convert.ToString(secondIP) + "." + Convert.ToString(thirdIP) + "." + Convert.ToString(fourthIP) + "\n" +
                LB + "\n" +
                "something, something";

            
        }
    }
}
