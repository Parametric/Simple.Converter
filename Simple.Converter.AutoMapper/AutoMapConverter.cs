using System;
using AutoMapper;

namespace Simple.Converter.AutoMapper
{
    /// <summary>
    /// Simple class that wraps an AutoMapper converter.
    /// 
    /// If just a straight auto map, just call the empty constructor and should work as is.
    /// var converter = new AutoMapConverter&lt;MyType,ToType&gt;();
    /// 
    /// You can configure the map as much as you want, with map configure constructor
    /// 
    /// If you just want to inherit and do something after the map, just inherit from this class and override AfterMap
    /// </summary>
    /// <typeparam name="TFrom"></typeparam>
    /// <typeparam name="TTo"></typeparam>
    public class AutoMapConverter<TFrom,TTo> : IConverter<TFrom,TTo>
    {
        public virtual TTo Convert(TFrom source)
        {
            return Mapper.DynamicMap<TFrom, TTo>(source);
        }
    }
}
