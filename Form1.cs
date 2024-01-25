namespace bmi_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h, w,t, bmi;
            h=double.Parse(textBox1.Text);
            w=double.Parse(textBox2.Text);
            bmi = w / Math.Pow(h, 2);
            textBox3.Text = bmi.ToString();     
            if(bmi < 18)
            {
                textBox4.Text = "UNDERWEIGHT";
            }
            else if(bmi<=18 && bmi<26)
            {
                textBox4.Text = "you are fit";
            }
            else
            {
                textBox4.Text = "overweight";
            }

        }
    }
}