namespace Blizzard.IO.Core
{
    public interface IDeserializer<TData>
    {
        TData Deserialize(byte[] data);
    }
}
