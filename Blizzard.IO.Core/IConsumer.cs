using System;

namespace Blizzard.IO.Core
{
    public interface IConsumer<TData> : IStartable, IStopable
    {
        event Action<TData> MessageReceived;
    }
}
