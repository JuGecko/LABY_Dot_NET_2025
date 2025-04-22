//opracowaæ prost¹ bazê danych do przechowywania informacji o osobach jak np.: adres,
//numer telefonu wykorzystuj¹c dostêpne klasy kolekcji w .NET,
//w zadaniu nie wykorzystujemy systemów dostêpu do danych wbudowanych w platformê .NET
namespace Zadanie_04
{
    public partial class Form1 : Form
    {
        private List<Person> personsDatabase;
        public Form1()
        {
            InitializeComponent();
            personsDatabase = new List<Person>();

            // columns for some display
            listView1.View = View.Details;
            listView1.Columns.Add("Imie", 100);
            listView1.Columns.Add("Nazwisko", 100);
            listView1.Columns.Add("Numer telefonu", 150);
        }

        //dodawanie osoby do bazy danych
        private void AddPerson(string name, string surname, string phoneNr)
        {
            var person = new Person
            {
                Name = name,
                Surname = surname,
                PhoneNr = phoneNr
            };
            personsDatabase.Add(person);

            //dodanie do ListView
            var listViewItem = new ListViewItem(new[] { person.Name, person.Surname, person.PhoneNr });
            listView1.Items.Add(listViewItem);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string surname = textBox2.Text.Trim();
            string phoneNr = textBox3.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(phoneNr))
            {
                MessageBox.Show("Wypelnij wszystkie pola.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddPerson(name, surname, phoneNr);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }

    // indywidulany rekord
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNr { get; set; }
    }
}
