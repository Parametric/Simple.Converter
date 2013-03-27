using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Simple.Converter.AutoMapper;

namespace Simple.Converter.Test
{
    [TestFixture]
    public class AutoMapConverterTest
    {

        [Test]
        public void Test_NoConfigure()
        {
            var converter = new AutoMapConverter<C1, C3>();

            var class1 = new C1 { MappedProperty = "Mapped", UnmappedProperty = "Unmapped" };
            var class2 = converter.Convert(class1);
            Assert.That(class2.DifferentName, Is.Not.EqualTo(class1.UnmappedProperty));
            Assert.That(class2.MappedProperty, Is.EqualTo(class1.MappedProperty));
        }
        private class C1
        {
            public string MappedProperty { get; set; }
            public string UnmappedProperty { get; set; }
        }
        private class C2
        {
            public string MappedProperty { get; set; }
            public string DifferentName { get; set; }
        }
        private class C3
        {
            public string MappedProperty { get; set; }
            public string DifferentName { get; set; }
        }
    }
}
