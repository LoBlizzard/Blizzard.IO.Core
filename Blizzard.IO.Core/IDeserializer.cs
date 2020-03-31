namespace Blizzard.IO.Core
{
    public interface IDeserializer<TData>
    {
        TData Desirialize(byte[] data);
    }
}
