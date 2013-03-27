using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple.Converter
{
    public class SimpleConvert : IConvert
    {
        private readonly IConverterProvider _provider;

        public SimpleConvert(IConverterProvider provider)
        {
            _provider = provider;
        }

        public ConverterBuilder<T> From<T>(T item)
        {
            return new ConverterBuilder<T>(item, _provider);
        }
    }
}
