namespace KullanıcıKayıtRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Deneme Dünya !!!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "C# dili derslerine hoşgeldiniz...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Deneme deneme";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}