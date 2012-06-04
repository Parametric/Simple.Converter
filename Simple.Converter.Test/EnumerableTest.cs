using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Simple.Converter.Test
{
    [TestFixture]
    public class EnumerableTest
    {

        [Test]
        public void TestEnumerableConversion()
        {
            SimpleConvert.SetProvider(new FakeConverterProvider());

            var values = new[] {"1", "2", "3", "4"};
            var results = values.Convert().To<int>();

            Assert.That(results, Is.EquivalentTo(new[] {1,2,3,4}));
        }
        private class FakeConverterProvider : IConverterProvider
        {
            public IConvert<TFrom, TTo> Get<TFrom, TTo>()
            {
                object o = new LambdaConverter<string, int>(Int32.Parse);
                return (IConvert<TFrom, TTo>)o;

            }
        }
    }
}
