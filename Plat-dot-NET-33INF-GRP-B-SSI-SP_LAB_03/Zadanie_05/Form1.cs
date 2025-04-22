namespace Zadanie_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 1000000;
            int[] numbers = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rand.Next(1, 1000000);
            }

            ArraySearch searcher = new ArraySearch(numbers);
            searcher.FindLargestAndSmallest();
            MessageBox.Show($"Najwieksza wartosc: {searcher.Largest}\nNajmniejsza wartosc: {searcher.Smallest}", "Wynik wyszukiwania: ");
        }
        private class ArraySearch
        {
            private readonly int[] array;
            public int Largest { get; private set; }
            public int Smallest { get; private set; }

            public ArraySearch(int[] array)
            {
                this.array = array;
            }

            public void FindLargestAndSmallest()
            {
                Thread largestThread = new Thread(SearchLargest);
                Thread smallestThread = new Thread(SearchSmallest);

                largestThread.Start();
                smallestThread.Start();

                largestThread.Join();
                smallestThread.Join();
            }

            private void SearchLargest()
            {
                int localLargest = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > localLargest)
                    {
                        localLargest = array[i];
                    }
                }
                Largest = localLargest;
            }

            private void SearchSmallest()
            {
                int localSmallest = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < localSmallest)
                    {
                        localSmallest = array[i];
                    }
                }
                Smallest = localSmallest;
            }
        }
    }
}
