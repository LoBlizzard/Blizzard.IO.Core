using System;

namespace Blizzard.IO.Core
{
    public interface IConcreteTypeDeserializer<TData>
    {
        TData Deserialize(TData data, Type type);
    }
}
