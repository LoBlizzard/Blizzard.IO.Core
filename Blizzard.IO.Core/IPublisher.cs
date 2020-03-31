namespace Blizzard.IO.Core
{
    public interface IPublisher<TData>
    {
        void Publish(TData data);
    }
}
