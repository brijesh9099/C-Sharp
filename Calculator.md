using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int count;
        float number,ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 00;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void compute(int count)
        {
            switch(count)
            { 
              case 1:
                    ans = number + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
              case 2:
                    ans = number * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

              case 3:
                    ans = number / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

              case 4:
                    ans = number - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break; 
                
                    
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }
    }
}

## output:-
![Untitled](https://user-images.githubusercontent.com/103420599/222318504-85c0c257-1f8c-4342-ab67-450191dfa386.png)
