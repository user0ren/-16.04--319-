namespace distant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // задаем обработчик события
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "Кузнецов",
                "Иванов",
                "Петров",
                "Кустов"
            };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://metanit.com");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}