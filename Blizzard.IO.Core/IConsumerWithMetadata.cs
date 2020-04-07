using System;

namespace Blizzard.IO.Core
{
    public interface IConsumerWithMetadata<TData, TMetadata> : IStartable, IStopable
        where TMetadata : BaseMetadata
    {
        event Action<TData, TMetadata> MessageWithMetadataReceived;
    }
}
