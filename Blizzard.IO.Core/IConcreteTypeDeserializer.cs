using System;

namespace Blizzard.IO.Core
{
    public interface IConcreteTypeDeserializer<TData>
    {
        TData Deserialize(byte[] bytes, Type type);
    }
}
