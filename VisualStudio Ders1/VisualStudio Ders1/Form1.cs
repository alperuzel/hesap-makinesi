namespace VisualStudio_Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "HOﬁGELD›N›Z!";
        }

        private void textBoxMesaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox›simler.Items.Add(textBoxMesaj.Text);
        }

        private void buttonLabelEkle_Click(object sender, EventArgs e)
        {
            label›sim.Text = textBoxMesaj.Text;
        }
    }
}
