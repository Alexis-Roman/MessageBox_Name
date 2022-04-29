namespace MessageBox_Roman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alexis Nicole B. Roman", "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}