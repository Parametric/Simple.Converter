using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple.Converter
{
    public class EnumerableConverterBuilder<T>
    {
        private IConverterProvider Provider { get; set; }
        private IEnumerable<T> Items { get; set; }

        internal EnumerableConverterBuilder(IEnumerable<T> items, IConverterProvider provider)
        {
            Provider = provider;
            Items = items;
        }

        public IEnumerable<TTo> To<TTo>()
        {
            var converter = Provider.Get<T, TTo>();
            if (converter == null)
                throw new ArgumentOutOfRangeException("TTo", String.Format("No converter of type IConvert<{0},{1}> has been registered, unable to convert", typeof(T).Name, typeof(TTo).Name));
            return Items.Select(converter.Convert);
        }
    }
}