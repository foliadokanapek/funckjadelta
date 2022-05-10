namespace funckjadelta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textBox3.Text);
            float b = Convert.ToSingle(textBox2.Text);
            float c = Convert.ToSingle(textBox1.Text);
            float bk = b * b;
            float delta = bk-(4*a*c);
            float ujemneb = b * -1;
            float x1 =(float)(ujemneb + Math.Sqrt(delta)) / (2 * a);
            float x2 = (float)(ujemneb - Math.Sqrt(delta)) / (2 * a);
            deltawynik.Text = delta.ToString();
            miejsce1box.Text = x1.ToString();
            miejce2box.Text = x2.ToString();



            if (delta > 0)
            {
                dodatnieujemne.Text = "Delta jest Dodatnia";
            }else if (delta < 0)
            {
                dodatnieujemne.Text = "Delta jest ujemna";
            }else if (delta == 0)
            {
                dodatnieujemne.Text = "Delta równa zero";
            }



        }
    }
}