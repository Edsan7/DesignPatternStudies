using System;

namespace Observer
{
    public interface IWatcher<T>
    {
        void OnNotified(T data, Context context);
    }
}