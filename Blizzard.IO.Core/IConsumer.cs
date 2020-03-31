using System;

namespace Blizzard.IO.Core
{
    public interface IConsumer<TData>
    {
        void Start();
        void Stop();

        event Action<TData> MessageReceived;
    }
}
