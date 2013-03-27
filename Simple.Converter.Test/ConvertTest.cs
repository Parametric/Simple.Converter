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
            SimpleConvert.SetProvider(new FakeConverterProvider());
            var result = SimpleConvert.From("1").To<int>();
            Assert.That(result, Is.EqualTo(1));

        }
        private class FakeConverterProvider : IConverterProvider
        {
            public IConverter<TFrom, TTo> Get<TFrom, TTo>()
            {
                object o = new LambdaConverter<string, int>(Int32.Parse);
                return (IConverter<TFrom, TTo>) o;

            }
        }
    }
}
