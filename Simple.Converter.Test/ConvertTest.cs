using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Simple.Converter.Test
{
    [TestFixture]
    public class ConvertTest
    {
        [Test]
        public void TestConverter()
        {
            var convert = new SimpleConvert(new FakeConverterProvider());
            var result = convert.From("1").To<int>();
            Assert.That(result, Is.EqualTo(1));

        }
        private class FakeConverterProvider : IConverterProvider
        {
            public IConverter<TFrom, TTo> Get<TFrom, TTo>()
            {
                object o = new FakeConverter();
                return (IConverter<TFrom, TTo>) o;

            }
        }
        private class FakeConverter: IConverter<string,int>
        {
            public int Convert(string source)
            {
                return Int32.Parse(source);
            }
        }
    }
}
