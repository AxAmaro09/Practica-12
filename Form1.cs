namespace Practic12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal = double.Parse(textBox1.Text);
            if (cal < 3) MessageBox.Show("reprobado");
           
            }

        }
    }
}
