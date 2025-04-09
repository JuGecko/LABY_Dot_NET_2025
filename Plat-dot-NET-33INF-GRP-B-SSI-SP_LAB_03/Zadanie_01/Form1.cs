//opracowaæ program z interfejsem u¿ytkownika pokazuj¹cy ró¿nicê w dniach, godzinach, sekundach pomiêdzy dwoma podanymi datami
namespace Zadanie_01
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePicker1.Value;
            DateTime endTime = dateTimePicker2.Value;

            TimeSpan diff = endTime - startTime;

            if (diff.TotalSeconds < 0)
            {
                label3.Text = "Data2 nie moze byc wczesniejsza niz Data1!";
                return;
            }

            label3.Text = $"Ró¿nica:\n" +
                             $"{diff.Days} dni\n" +
                             $"{diff.Hours} godziny \n" +
                             $"{diff.Minutes} minuty \n" +
                             $"{diff.Seconds} sekundy \n";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
