using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_07
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyCollection : IEnumerable<int>
    {
        private List<int> _items = new List<int>();

        public void Add(int item)
        {
            _items.Add(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            // Delegate to the List's enumerator
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // Required for non-generic IEnumerable
            return GetEnumerator();
        }
    }
}
