namespace temp_calculator
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input 
            string input = textBox1.Text;
            textBox2.Text = input;
            //convert to F
            //F = C * 9 / 5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
            //show input to textbox
            textBox2.Text = f.ToString();


        }

        private void textBoxF_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            textBox1.Text = input;
            double f = Convert.ToDouble(input);
            double c = (f - 32) / 1.80;
            textBox1.Text = c.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}