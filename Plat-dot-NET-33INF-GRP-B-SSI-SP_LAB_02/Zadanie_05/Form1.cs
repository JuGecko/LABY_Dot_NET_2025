namespace Zadanie_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Event handlers
            buttonAdd.Click += buttonAdd_Click;
            buttonRemove.Click += buttonRemove_Click;
            buttonClear.Click += buttonClear_Click;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                labelSelectedItem.Text = "Selected: " + listBox1.SelectedItem.ToString();
            }
            else
            {
                labelSelectedItem.Text = "Selected: None";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSelectedItem_Click(object sender, EventArgs e)
        {

        }
    }
}
