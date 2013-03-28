using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple.Converter
{
    public interface IConvert
    {
        IConverterBuilder<T> From<T>(T item);
    }
}
