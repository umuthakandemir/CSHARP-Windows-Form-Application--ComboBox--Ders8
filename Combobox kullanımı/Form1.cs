namespace Combobox_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //içertsinde tamamen sıler
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Bir şey seçin");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Manisa");
            comboBox1.Items.Add("istanbul");
            comboBox1.Items.Add("kırıkkale");
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }
    }
}
