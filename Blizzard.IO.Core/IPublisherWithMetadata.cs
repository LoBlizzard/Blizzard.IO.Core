namespace Blizzard.IO.Core
{
    public interface IPublisherWithMetadata<TData, TMetadata>
    {
        void Publish(TData data, TMetadata metadata);
    }
}
