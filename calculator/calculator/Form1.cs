using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace calculator
{
    public partial class Form1 : Form
    {
        double num1 , num2 , result ;
        char op;
        TextBox txt = new TextBox();
        Panel panel1 = new Panel();
        Panel panel2 = new Panel();
        Button clear = new Button();
        Button sub = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
            this.Size = new Size(265, 380);
            Button add = new Button();
            add.Text = "+";
            add.Size = new Size(60, 50);
            add.Location = new Point(180, 115);
            add.Click += new EventHandler(add_Click);
            add.BackColor= Color.White;

            
            sub.Text = "-";
            sub.Size = new Size(60, 50);
            sub.Location = new Point(180, 160);
            sub.BackColor = Color.White;
            sub.Click += new EventHandler(sub_Click);

            Button mul = new Button();
            mul.Text = "x";
            mul.Size = new Size(60, 50);
            mul.Location = new Point(180, 10);
            mul.BackColor = Color.White;
            mul.Click += new EventHandler(mul_Click);

            Button div = new Button();
            div.Text = "/";
            div.Size = new Size(60, 50);
            div.Location = new Point(180, 60);
            div.BackColor = Color.White;
            div.Click += new EventHandler(div_Click);


            Button prec = new Button();
            prec.Text = "%";
            prec.Size = new Size(60, 50);
            prec.Location = new Point(120, 160);
            prec.BackColor = Color.White;
            prec.Click += new EventHandler(prec_Click);

            Button equal = new Button();
            equal.Text = "=";
            equal.Size = new Size(60, 50);
            equal.Location = new Point(60, 160);
            equal.BackColor = Color.White;
            equal.Click += new EventHandler(equal_Click);

            Button num0 = new Button();
            num0.Text = "0";
            num0.Size = new Size(60, 50);
            num0.Location = new Point(0, 160);
            num0.BackColor = Color.White;
            num0.Click += new EventHandler(num0_Click) ;

            Button num1 = new Button();
            num1.Text = "1";
            num1.Size = new Size(60, 50);
            num1.Location = new Point(0, 115);
            num1.BackColor = Color.White;
            num1.Click += new EventHandler(num1_Click);

            Button num2 = new Button();
            num2.Text = "2";
            num2.Size = new Size(60, 50);
            num2.Location = new Point(60, 115);
            num2.BackColor = Color.White;
            num2.Click += new EventHandler(num2_Click);
            Button num3 = new Button();
            num3.Text = "3";
            num3.Size = new Size(60, 50);
            num3.Location = new Point(120, 115);
            num3.BackColor = Color.White;
            num3.Click += new EventHandler(num3_Click);
            Button num4 = new Button();
            num4.Text = "4";
            num4.Size = new Size(60, 50);
            num4.Location = new Point(0, 60);
            num4.BackColor = Color.White;
            num4.Click += new EventHandler(num4_Click);
            Button num5 = new Button();
            num5.Text = "5";
            num5.Size = new Size(60, 50);
            num5.Location = new Point(60,60);
            num5.BackColor = Color.White;
            num5.Click += new EventHandler(num5_Click);
            Button num6 = new Button();
            num6.Text = "6";
            num6.Size = new Size(60, 50);
            num6.Location = new Point(120, 60);
            num6.BackColor = Color.White;
            num6.Click += new EventHandler(num6_Click);
            Button num7 = new Button();
            num7.Text = "7";
            num7.Size = new Size(60, 50);
            num7.Location = new Point(0, 10);
            num7.BackColor = Color.White;
            num7.Click += new EventHandler(num7_Click);
            Button num8 = new Button();
            num8.Text = "8";
            num8.Size = new Size(60, 50);
            num8.Location = new Point(60, 10);
            num8.BackColor = Color.White;
            num8.Click += new EventHandler(num8_Click);
            Button num9 = new Button();
            num9.Text = "9";
            num9.Size = new Size(60, 50);
            num9.Location = new Point(120, 10);
            num9.BackColor = Color.White;
            num9.Click += new EventHandler(num9_Click);

            
            clear.Location = new Point(50, 210);
            clear.Size = new Size(140,40);
            clear.Text = "Clear";
            clear.BackColor = Color.White;
            clear.Click += new EventHandler(clear_Click);
            
            panel1.Location = new Point(0, 80);
            panel1.Size = new Size(270, 320);
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle=System.Windows.Forms.BorderStyle.Fixed3D;
            Panel panel2 = new Panel();
            
            txt.Location = new Point(0, 0);
            txt.Size = new Size(270, 100);
            txt.BackColor = Color.White;
            txt.Multiline = true;
            

            Controls.Add(panel1);
            panel1.Controls.Add(add);
            panel1.Controls.Add(sub);
            panel1.Controls.Add(mul);
            panel1.Controls.Add(div);
            panel1.Controls.Add(prec);
            panel1.Controls.Add(equal);
            panel1.Controls.Add(num0);
            panel1.Controls.Add(num1);
            panel1.Controls.Add(num2);
            panel1.Controls.Add(num3);
            panel1.Controls.Add(num4);
            panel1.Controls.Add(num5);
            panel1.Controls.Add(num6);
            panel1.Controls.Add(num7);
            panel1.Controls.Add(num8);
            panel1.Controls.Add(num9);
            panel1.Controls.Add(clear);
            this.Controls.Add(txt);

           

        }
        private void equal_Click(object sender, EventArgs e)
        {
            num2 = (double.Parse(txt.Text));
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        txt.Text = "can't divide by zero";
                        return;
                    }
                    else
                        result = num1 / num2;
                    break;
                case '%':
                    result = (num1 / 100) * num2;
                    break;
            }
            txt.Text = result.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            num1 = (double.Parse(txt.Text));
            op = '+';
            txt.Clear();
        }
        private void sub_Click(object sender, EventArgs e)
        {
            num1 = (double.Parse(txt.Text));
            op = '-';
            txt.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        { 
                num1 = (double.Parse(txt.Text));
                op = '/';
                txt.Clear();
        }
        private void mul_Click (object sender, EventArgs e)
        {
            num1 = (double.Parse(txt.Text));
            op = '*';
            txt.Clear();
        }
        private void prec_Click (object sender , EventArgs e)
        {
            num1 = (double.Parse(txt.Text));
            op = '%';
            txt.Clear();
        }
        
        private void num0_Click(object sender , EventArgs e)
        {
            txt.Text = txt.Text + "0";
        }
        private void num1_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "1";
        }
        private void num2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "2";
        }
        private void num3_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "3";
        }
        private void num4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "4";
        }
        private void num5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "5";
        }
        private void num6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "6";
        }
        private void num7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "7";
        }
        private void num8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "8";
        }
        private void num9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "9";
        }
        private void clear_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }
    }
}
