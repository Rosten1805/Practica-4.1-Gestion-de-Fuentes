namespace Práctica_4._1_Gestión_de_Fuentes
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
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Underline);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        }
}