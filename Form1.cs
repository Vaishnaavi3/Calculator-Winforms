using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int operate, first, second;

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button1.Text;
            //TextBox myText = new TextBox();
            //myText.Location = new Point(25, 25);
            //this.Controls.Add(myText);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox textbox3 = new TextBox();
            //textbox3.Location = new Point(150, 20);
            //this.Controls.Add(textbox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TextBox textbox3 = new TextBox();
            //textbox3.Location = new Point(250, 20);
            //textbox3.Text = this.textBox1.Text;
            //this.Controls.Add(textbox3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button16.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button17.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //multiply
            first = Convert.ToInt32(textBox1.Text);
            this.textBox1.Text = textBox1.Text + button12.Text + " ";
            operate = 3;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //division
            first = Convert.ToInt32(textBox1.Text);
            this.textBox1.Text = textBox1.Text + button10.Text + " ";
            operate = 4;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //addition
            first = Convert.ToInt32(textBox1.Text);
            this.textBox1.Text = textBox1.Text + button13.Text + " ";
            operate = 1;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //subtract
            first = Convert.ToInt32(textBox1.Text);
            this.textBox1.Text = textBox1.Text + button11.Text + " ";
            operate = 2;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operate = 0;
            first = 0;
            second = 0;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] lastInput = textBox1.Text.Split(' ');
            second = Convert.ToInt32(lastInput[1]);
            this.textBox1.Text = textBox1.Text + " " + button14.Text;
            Console.WriteLine(second);
            System.Diagnostics.Debug.WriteLine(second + " " + first);

            //equals
            switch (operate)
            {
                case 1:
                    textBox1.Text = textBox1.Text + (first + second);
                    textBox2.Text = textBox2.Text + "\r\n" + textBox1.Text;
                    break;
                case 2:
                    if (second <= first)
                    {
                        textBox1.Text = textBox1.Text + (first - second);
                        textBox2.Text = textBox2.Text + "\r\n" + textBox1.Text;
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + "\r\n" + " First number Should be greater than second number";
                    }

                    break;
                case 3:
                    textBox1.Text = textBox1.Text + (first * second);
                    textBox2.Text = textBox2.Text + "\r\n" + textBox1.Text;
                    break;
                case 4:
                    if (second <= first)
                    {
                        try
                        {
                            textBox1.Text = textBox1.Text + (first / second);
                            textBox2.Text = textBox2.Text + "\r\n" + textBox1.Text;
                        }
                        catch (DivideByZeroException)
                        {
                            textBox2.Text = textBox2.Text + "\r\n" + " Cannot divide by Zero";
                        }
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + "\r\n" + "First number Should be greater than second number";

                    }
                    break;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //backspace
            //textBox1.Text.ElementAt(textBox1.Text.Length);
            textBox1.Text.TrimEnd();

        }
    }
}
