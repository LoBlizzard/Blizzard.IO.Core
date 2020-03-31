using System;

namespace Blizzard.IO.Core
{
    public interface IConsumerWithMetadata<TData, TMetadata> where TMetadata : BaseMetadata
    {
        event Action<TData, TMetadata> MessageWithMetadataConsumed;
    }
}
