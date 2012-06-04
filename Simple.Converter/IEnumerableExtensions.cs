using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple.Converter
{
    public static class EnumerableExtensions
    {
        public static EnumerableConverterBuilder<T> Convert<T>(this IEnumerable<T> self)
        {
            return new EnumerableConverterBuilder<T>(self, SimpleConvert.ConverterProvider);
        }
    }
}
