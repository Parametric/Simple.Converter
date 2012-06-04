using System;

namespace Simple.Converter
{
    public class ConverterBuilder<TFrom>
    {
        private IConverterProvider Provider { get; set; }
        private TFrom Item { get; set; }

        internal ConverterBuilder(TFrom item, IConverterProvider provider)
        {
            Provider = provider;
            Item = item;
        }

        public TTo To<TTo>()
        {
            var converter = Provider.Get<TFrom, TTo>();
            if (converter == null)
                throw new ArgumentOutOfRangeException("TTo", String.Format("No converter of type IConvert<{0},{1}> has been registered, unable to convert", typeof(TFrom).Name, typeof(TTo).Name));
            return converter.Convert(Item);
        }
    }
}