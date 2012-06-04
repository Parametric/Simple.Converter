namespace Simple.Converter
{
    public interface IConvert<TFrom, TTo>
    {
        TTo Convert(TFrom source);
    }
}