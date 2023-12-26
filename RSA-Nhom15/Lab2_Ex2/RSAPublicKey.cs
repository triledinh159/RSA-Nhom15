namespace Lab2_Ex2
{
    public partial class RSAPublicKey : Form
    {
        public RSAPublicKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomKeyNumeric form2 = new RandomKeyNumeric();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandomKeyString form3 = new RandomKeyString();
            form3.Show();
        }

    }
}