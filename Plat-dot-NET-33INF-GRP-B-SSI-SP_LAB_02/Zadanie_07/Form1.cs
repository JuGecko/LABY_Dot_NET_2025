using System.Drawing.Imaging;

namespace Zadanie_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        listView1.View = View.Details;
        }
        
        
    }
}
