namespace Simple.Converter
{
    public interface IConverterProvider
    {
        IConvert<TFrom, TTo> Get<TFrom, TTo>();
    }
}