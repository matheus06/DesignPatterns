using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
