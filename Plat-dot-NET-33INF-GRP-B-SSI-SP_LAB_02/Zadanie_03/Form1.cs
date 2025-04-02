//podaæ program, który zaprezentuje mo¿liwoœci klasy MessageBox (a dok³adniej metody Show) z przestrzeni System.Windows
namespace Zadanie_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.Click += button3_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form loaded.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk zostal nacisniety.", "Info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uwaga! Przycisk zostal nacisniety!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy kontynuowac?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Wybrano TAK", "Decyzja");
            }
            else
            {
                MessageBox.Show("Wybrano NIE", "Decyzja");
            }
        }
    }
}

