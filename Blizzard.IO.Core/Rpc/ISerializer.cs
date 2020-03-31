using System;

namespace Blizzard.IO.Core.Rpc
{
    public interface ISerializer
    {
        object Deserialize(byte[] bytes, Type type);
        byte[] Serialize(object data);
    }
}
