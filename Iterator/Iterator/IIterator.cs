using Iterator.ConcreteAggregate;

namespace Iterator.Iterator
{
    public interface IIterator
    {
        Item First();
        Item Next();
        int Step { set; }
        bool HasNext { get; }
        Item CurrentItem { get; }
    }
}
