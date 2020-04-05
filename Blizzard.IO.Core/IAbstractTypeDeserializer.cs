using System;

namespace Blizzard.IO.Core
{
    public interface IAbstractTypeDeserializer<TData>
    {
        TData Deserialize(byte[] bytes, Type type);
    }
}
