namespace Simple.Converter
{
    public interface IConverterProvider
    {
        IConverter<TFrom, TTo> Get<TFrom, TTo>();
    }
}