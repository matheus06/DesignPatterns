using System.Collections;
using Iterator.Aggregate;
using Iterator.Iterator;

namespace Iterator.ConcreteAggregate
{
    public class Collection : IAggregate
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator.Iterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
