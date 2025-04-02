using System.Windows.Forms;

namespace Zadanie_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listViewContacts.View = View.Details;
            listViewContacts.Columns.Add("Name", 150);
            listViewContacts.Columns.Add("Date of Birth", 100);

            listViewContacts.Sorting = SortOrder.None;

            buttonAdd.Click += buttonAdd_Click;
            buttonSearch.Click += buttonSearch_Click;
            buttonSortByName.Click += (sender, e) => SortListView(0);
            buttonSortByDOB.Click += (sender, e) => SortListView(1);

        }

        private void listViewContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string dob = dateTimePickerDOB.Value.ToShortDateString();

            if (!string.IsNullOrWhiteSpace(name))
            {
                ListViewItem item = new ListViewItem(new[] { name, dob });
                listViewContacts.Items.Add(item);
                textBoxName.Clear();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower().Trim();

            foreach (ListViewItem item in listViewContacts.Items)
            {
                item.BackColor = item.Text.ToLower().Contains(searchText) ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            }
        }

        private void SortListView(int columnIndex)
        {
            listViewContacts.ListViewItemSorter = new ListViewItemComparer(columnIndex);
            listViewContacts.Sort();
        }

        private void buttonSortByName_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSortByDOB_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    class ListViewItemComparer : System.Collections.IComparer
    {
        private int columnIndex;

        public ListViewItemComparer(int columnIndex)
        {
            this.columnIndex = columnIndex;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;

            if (columnIndex == 1)
            {
                DateTime dateX = DateTime.Parse(itemX.SubItems[columnIndex].Text);
                DateTime dateY = DateTime.Parse(itemY.SubItems[columnIndex].Text);
                return dateX.CompareTo(dateY);
            }

            
            return string.Compare(itemX.SubItems[columnIndex].Text, itemY.SubItems[columnIndex].Text);
        }
    }
    
}
