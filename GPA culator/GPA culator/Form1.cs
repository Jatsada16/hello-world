namespace GPA_culator
{
    public partial class Form1 : Form
    {
        Culator1 CTGPA = new Culator1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strinput = textBoxGPAINPUT.Text;
            string name = textBoxGPANAME.Text;

            double dinput = Convert.ToDouble(strinput);
            CTGPA.addGPA(dinput, name);

            double gpax = CTGPA.getGPAx();
            textBoxGPAX.Text = gpax.ToString();

            double max = CTGPA.getMax();
            textBoxMAXGPA.Text = max.ToString();
            textBoxMAXNAME.Text = CTGPA.getMaxName().ToString();

            double min = CTGPA.getMin();
            textBoxMINGPA.Text = min.ToString();
            textBoxMINNAME.Text = CTGPA.getMinName().ToString();

            textBoxGPAINPUT.Text = "";
            textBoxGPANAME.Text = string.Empty;
            textBoxALLDATA.Text = CTGPA.getAlldata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAINPUT.Text = "";
            textBoxGPANAME.Text = "";
            textBoxGPAX.Text = "";
            textBoxMAXGPA.Text = "";
            textBoxMAXNAME.Text = "";
            textBoxMINGPA.Text = "";
            textBoxMINNAME.Text = "";
            textBoxALLDATA.Text = "";
        }
    }
}