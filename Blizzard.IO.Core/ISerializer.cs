namespace Blizzard.IO.Core
{
    public interface ISerializer<TData>
    {
        byte[] Serialize(TData data);
    }
}
