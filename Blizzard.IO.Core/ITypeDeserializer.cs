using System;

namespace Blizzard.IO.Core
{
    public interface ITypeDeserializer<TData>
    {
        TData Deserialize(TData data, Type type);
    }
}
