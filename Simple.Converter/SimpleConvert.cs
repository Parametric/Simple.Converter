namespace Simple.Converter
{
    public static class SimpleConvert
    {
        public static ConverterBuilder<T> From<T>(T value)
        {
            return new ConverterBuilder<T>(value, ConverterProvider);
        }

        internal static IConverterProvider ConverterProvider { get; set; }
        public static void SetProvider(IConverterProvider provider)
        {
            ConverterProvider = provider;
        }
    }
}
