namespace Blizzard.IO.Core
{
    public interface IPublisher<in TData>
    {
        void Publish(TData data);
    }
}
