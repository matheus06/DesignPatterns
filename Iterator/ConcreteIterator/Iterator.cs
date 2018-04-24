
using Iterator.ConcreteAggregate;
using Iterator.Iterator;

namespace Iterator.ConcreteIterator
{
    public class Iterator : IIterator
    {
        private Collection _aggregate;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection aggregate)
        {
            _aggregate = aggregate;
        }

        public Item First()
        {
            _current = 0;
            return _aggregate[0] as Item;
        }

        public Item Next()
        {
            _current += _step;
            if (!HasNext)
                return _aggregate[_current] as Item;
            else

                return null;
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public bool HasNext
        {
            get { return _current >= _aggregate.Count; }
        }

        public Item CurrentItem
        {
            get { return _aggregate[_current] as Item; }
        }
    }
}
