using System;

namespace Blizzard.IO.Core
{
    public interface IConsumer<out TData>
    {
        void Start();
        void Stop();

        event Action<TData> MessageReceived;
    }
}
