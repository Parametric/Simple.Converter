using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple.Converter
{
    public interface IConverterBuilder<TFrom>
    {
        TTo To<TTo>();

    }
}
