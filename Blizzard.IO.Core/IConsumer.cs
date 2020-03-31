using System;

namespace Blizzard.IO.Core
{
    public interface IConsumer<out TData>
    {
        void StartConsume();
        void StopConsume();
        event Action<TData> MessageConsumed;
    }
}
