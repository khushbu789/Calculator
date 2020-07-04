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
        
        public Form1()
        {
            InitializeComponent();
        }
        string operation_performed_1="";
        string result="";
        string r = "";
        string answer = "";
        bool click_equal = false;
        bool click_plus = false;




        //button clicked
        private void button_click_number(object sender, EventArgs e)

        {
            Button button =(Button)sender;
            circular_button13.Enabled = true;
            circular_button25.Enabled = true;
            circular_button23.Enabled = true;
            circular_button24.Enabled = true;

            if (textBox1.Text =="0"|| textBox1.Text.Contains("+") || textBox1.Text.Contains("-")||textBox1.Text.Contains("*")||textBox1.Text.Contains("/") ) {
                textBox1.Text = "";
                
            }
            if (textBox1.Text.Contains("."))
            {
                circular_button20.Enabled = false;
                textBox1.Text = textBox1.Text + button.Text;

            }
            if (textBox1.Text.Contains("Sin("))
            {
                textBox1.Text = textBox1.Text + button.Text;

            }
            if (textBox1.Text.Contains("Cos("))
            {
                textBox1.Text = textBox1.Text + button.Text;

            }
            if (textBox1.Text.Contains("Tan("))
            {
                textBox1.Text = textBox1.Text + button.Text;

            }
            if (textBox1.Text.Contains("log("))
            {
                textBox1.Text = textBox1.Text + button.Text;

            }
            if (textBox1.Text.Contains("ln("))
            {
                textBox1.Text = textBox1.Text + button.Text;

            }

            else if(!textBox1.Text.Contains("Sin(") && !textBox1.Text.Contains("Cos(") && !textBox1.Text.Contains("Tan(") && !textBox1.Text.Contains("log(") && !textBox1.Text.Contains("e") && !textBox1.Text.Contains("ln(") && !textBox1.Text.Contains("."))
            {
                circular_button20.Enabled = true;
                textBox1.Text = textBox1.Text + button.Text;
            }
            
           
        }




        //operation performed
        private void operation_performed(object sender, EventArgs e)
        {
            Button button =(Button)sender;
            
            operation_performed_1 =button.Text;

            if (!textBox1.Text.Contains("+") || !textBox1.Text.Contains("-") || !textBox1.Text.Contains("*") || !textBox1.Text.Contains("/")) {
                if (textBox1.Text.Contains("Sin("))
                {
                    click_plus = true;
                    string s = textBox1.Text;
                    s = s.Remove(0, 4);
                    answer = "";
                    answer = calculate_sin(double.Parse(s));
                    //MessageBox.Show(answer,"Answer for sin");
                    textBox1.Text = answer;
                }
                if (textBox1.Text.Contains("Cos("))
                {
                    click_plus = true;
                    string s = textBox1.Text;
                    s = s.Remove(0, 4);
                    answer = "";
                    answer = calculate_cos(double.Parse(s));
                    textBox1.Text = answer;
                }
                if (textBox1.Text.Contains("Tan("))
                {
                    click_plus = true;
                    string s = textBox1.Text;
                    s = s.Remove(0, 4);
                    answer = "";
                    answer = calculate_tan(double.Parse(s));
                    textBox1.Text = answer;
                }
                if (textBox1.Text.Contains("log("))
                {
                    click_plus = true;
                    string s = textBox1.Text;
                    s = s.Remove(0, 4);
                    answer = "";
                    answer = calculate_log(double.Parse(s));
                    textBox1.Text = answer;
                }

                if (textBox1.Text.Contains("ln("))
                {
                    click_plus = true;
                    string s = textBox1.Text;
                    s = s.Remove(0, 3);
                    answer = "";
                    answer = calculate_ln(double.Parse(s));
                    textBox1.Text = answer;
                }
                if (textBox1.Text.Contains("e"))
                {
                    click_plus = true;
                    answer = "";
                    answer = calculate_e();
                    textBox1.Text = answer;
                }
                result = textBox1.Text;

                textBox1.Text = textBox1.Text + operation_performed_1;
                circular_button13.Enabled = false;
                circular_button25.Enabled = false;
                circular_button23.Enabled = false;
                circular_button24.Enabled = false;



            }


        }




        //equal to button
        private void circular_button26_Click(object sender, EventArgs e)
        {
            click_equal = true;
            switch (operation_performed_1) {
                case "+":

                    if (textBox1.Text.Contains("Sin("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_sin(double.Parse(s));
                       //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Cos("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_cos(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Tan("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_tan(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("log("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_log(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("ln("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_ln(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("e"))
                    {
                        
                        answer = calculate_e();
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }




                    else
                    {
                        result = (double.Parse(result) + double.Parse(textBox1.Text)).ToString();
                        textBox1.Text = "";
                        textBox1.Text = result;
                    }
                    break;
                case "-":
                    if (textBox1.Text.Contains("Sin("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_sin(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) - double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Cos("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_cos(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result)- double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Tan("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_tan(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("log("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_log(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("ln("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_ln(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("e"))
                    {

                        answer = calculate_e();
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }

                    else
                    {
                        result = (double.Parse(result) - double.Parse(textBox1.Text)).ToString();
                        textBox1.Text = "";
                        textBox1.Text = result;
                    }
                    break; 



                case "*":
                    if (textBox1.Text.Contains("Sin("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_sin(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) * double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Cos("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_cos(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) * double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Tan("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_tan(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("log("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_log(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("ln("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_ln(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("e"))
                    {

                        answer = calculate_e();
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }

                    else
                    {
                        result = (double.Parse(result) * double.Parse(textBox1.Text)).ToString();
                        textBox1.Text = "";
                        textBox1.Text = result;
                    }
                    break;

                case "/":
                    if (textBox1.Text.Contains("Sin("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_sin(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) / double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Cos("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_cos(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) / double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("Tan("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_tan(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("log("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_log(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("ln("))
                    {
                        // MessageBox.Show(textBox1.Text, "value");
                        string s = textBox1.Text;
                        s = s.Remove(0, 4);
                        answer = "";
                        //MessageBox.Show(s, "value");
                        answer = calculate_ln(double.Parse(s));
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    if (textBox1.Text.Contains("e"))
                    {

                        answer = calculate_e();
                        //MessageBox.Show(answer, "answer");
                        result = (double.Parse(result) + double.Parse(answer)).ToString();
                        textBox1.Text = result;
                    }
                    else
                    {
                        result = (double.Parse(result) / double.Parse(textBox1.Text)).ToString();
                        textBox1.Text = "";
                        textBox1.Text = result;
                    }
                    break;
                case "default":break;

            }

            if (click_equal && textBox1.Text.Contains("Sin("))
            {

                string s = textBox1.Text;
                s = s.Remove(0, 4);
                answer = "";

                answer = calculate_sin(double.Parse(s));
                textBox1.Text = answer;
            }


            if (click_equal && textBox1.Text.Contains("Cos("))
            {

                string s = textBox1.Text;
                s = s.Remove(0, 4);
                answer = "";

                answer = calculate_cos(double.Parse(s));
                textBox1.Text = answer;
            }

            if (click_equal && textBox1.Text.Contains("Tan("))
            {

                string s = textBox1.Text;
                s = s.Remove(0, 4);
                answer = "";

                answer = calculate_tan(double.Parse(s));
                textBox1.Text = answer;
            }
            if (click_equal && textBox1.Text.Contains("log("))
            {

                string s = textBox1.Text;
                s = s.Remove(0, 4);
                answer = "";

                answer = calculate_log(double.Parse(s));
                textBox1.Text = answer;
            }
            if (click_equal && textBox1.Text.Contains("ln("))
            {

                string s = textBox1.Text;
                s = s.Remove(0, 4);
                answer = "";

                answer = calculate_ln(double.Parse(s));
                textBox1.Text = answer;
            }
            if (click_equal && textBox1.Text.Contains("e"))
            {

               
                answer = "";

                answer = calculate_e();
                textBox1.Text = answer;
            }
        }





        //clear button
        private void circular_button9_Click(object sender, EventArgs e)
        {
            int l = textBox1.Text.Length;
            textBox1.Text = textBox1.Text.Remove(l-1,1);

        }

        
        
        //sin button
        private void circular_button1_Click(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            textBox1.Text = b.Text + "(";
        }



        //calculate sin
        string calculate_sin(double value)
        {
            r = (Math.Sin(value)).ToString();
            return r;
        }


        //calculate cos
        string calculate_cos(double value)
        {
            r = (Math.Cos(value)).ToString();
            return r;
        }


        //calculate tan
        string calculate_tan(double value)
        {
            r = (Math.Tan(value)).ToString();
            return r;
        }

        //calculate log
        string calculate_log(double value)
        {
            r = (Math.Log10(value)).ToString();
            return r;
        }



        //calculate natural log 
        string calculate_ln(double value)
        {
            r = (Math.Log(value)).ToString();
            return r;
        }

        //calculate E
        string calculate_e() {
            r = (Math.E).ToString();
            return r;
        }
        private void circular_button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = b.Text + "(";
        }

        private void circular_button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = b.Text + "(";
        }

        private void circular_button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = b.Text + "(";
        }

        private void circular_button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = b.Text + "(";
        }

        private void circular_button11_Click(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            textBox1.Text = b.Text;
        }

        private void circular_button4_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = b.Text + "(";
        }
    }
}
