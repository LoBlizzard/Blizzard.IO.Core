namespace Blizzard.IO.Core
{
    public interface IConverter<TIn, TOut>
    {
        TOut Convert(TIn obj);
    }
}
