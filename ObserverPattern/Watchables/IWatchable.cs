

namespace Observer
{
    public interface IWatchable<T>
    {

        void Add(IWatcher<T> observer);
        void Remove(IWatcher<T> observer);
        void Notify();
    }
}