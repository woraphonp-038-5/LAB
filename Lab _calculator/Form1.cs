namespace Lab_calculator
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void inputBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_b_Click(object sender, EventArgs e) //+
        {
            this.input1 = double.Parse(this.inputBox1.Text);
            this.inputBox1.Text = "";
            this.op = "+";
            this.inputBox2.Text = this.inputBox2.Text + "+";
        }

        private void button_l_Click(object sender, EventArgs e) //-
        {
            this.input1 = double.Parse(this.inputBox1.Text);
            this.inputBox1.Text = "";
            this.op = "-";
            this.inputBox2.Text = this.inputBox2.Text + "-";
        }

        private void button_k_Click(object sender, EventArgs e) //*
        {
            this.input1 = double.Parse(this.inputBox1.Text);
            this.inputBox1.Text = "";
            this.op = "*";
            this.inputBox2.Text = this.inputBox2.Text + "*";
        }

        private void button_h_Click(object sender, EventArgs e) //_/
        {
            this.input1 = double.Parse(this.inputBox1.Text);
            this.inputBox1.Text = "";
            this.op = "/";
            this.inputBox2.Text = this.inputBox2.Text + "/";
        }

        private void button_sum_Click(object sender, EventArgs e) //=
        {
            double input2 = Double.Parse(this.inputBox1.Text);
            double result = 0;
            if (this.op == "+")
            {
                result = input1 + input2;
            }
            else if (this.op == "-")
            {
                result = input1 - input2;
            }
            else if (this.op == "*")
            {
                result = input1 * input2;
            }
            else if (this.op == "/")
            {
                result = input1 / input2;
            }
            else if (this.op == "C")
            {
                result = input2;
            }
            this.inputBox1.Text = Convert.ToString (result);
            this.inputBox1.Text = string.Format("{0:n}",double.Parse(this.inputBox1.Text));



        }

        private void button_C_Click(object sender, EventArgs e) //C
        {
            inputBox1.Clear();
            inputBox2.Clear();
            this.op = "C";
        }

        private void button__Click(object sender, EventArgs e) //.
        {
            this.inputBox1.Text = this.inputBox1.Text + ".";
            this.inputBox2.Text = this.inputBox2.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "1";
            this.inputBox2.Text = this.inputBox2.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "2";
            this.inputBox2.Text = this.inputBox2.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "3";
            this.inputBox2.Text = this.inputBox2.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "4";
            this.inputBox2.Text = this.inputBox2.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "5";
            this.inputBox2.Text = this.inputBox2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "6";
            this.inputBox2.Text = this.inputBox2.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "7";
            this.inputBox2.Text = this.inputBox2.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "8";
            this.inputBox2.Text = this.inputBox2.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "9";
            this.inputBox2.Text = this.inputBox2.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.inputBox1.Text = this.inputBox1.Text + "0";
            this.inputBox2.Text = this.inputBox2.Text + "0";
        }
    }
}