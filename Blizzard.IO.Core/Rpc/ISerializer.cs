using System;

namespace Blizzard.IO.Core.Rpc
{
    public interface ISerializer
    {
        object Deserialize(byte[] data, Type type);
        byte[] Serialize(object data);
    }
}
