using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple.Converter
{
    /// <summary>
    /// Simple converter that just takes a lambda function to convert
    /// </summary>
    /// <typeparam name="TFrom"></typeparam>
    /// <typeparam name="TTo"></typeparam>
    public class LambdaConverter<TFrom,TTo> : IConvert<TFrom,TTo>
    {
        private Func<TFrom, TTo> ConvertFunction { get; set; }

        public LambdaConverter(Func<TFrom, TTo> convert)
        {
            ConvertFunction = convert;
        }
        public TTo Convert(TFrom source)
        {
            return ConvertFunction(source);
        }
    }
}
