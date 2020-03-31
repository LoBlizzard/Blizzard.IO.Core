using System;

namespace Blizzard.IO.Core
{
    public interface IConsumer<TData>
    {
        void StartConsume();
        void StopConsume();

        event Action<TData> MessageReceived;
    }
}
