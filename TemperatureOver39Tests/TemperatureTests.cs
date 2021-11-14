using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemperatureOver39;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureOver39.Tests
{
    [TestClass()]
    public class TemperatureTests
    {
        [TestMethod()]
        public void OutputTest()
        {
            var temp = new Temperature(10, TempType.c);
            Assert.AreEqual("10 °C", temp.Output());

            temp = new Temperature(10, TempType.f);
            Assert.AreEqual("10 °F", temp.Output());

            temp = new Temperature(10, TempType.r);
            Assert.AreEqual("10 °Ra", temp.Output());

            temp = new Temperature(10, TempType.k);
            Assert.AreEqual("10 K", temp.Output());
        }
        [TestMethod()]
        public void AddNumberTest()
        {
            var temp = new Temperature(36.6, TempType.c);
            temp = temp + 3.25;
            Assert.AreEqual("39,85 °C", temp.Output());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var temp = new Temperature(40.2, TempType.c);
            temp = temp - 3.25;
            Assert.AreEqual("36,95 °C", temp.Output());
        }
        [TestMethod()]
        public void MulByNumberTest()
        {
            var temp = new Temperature(41, TempType.f);
            temp = temp * 3;
            Assert.AreEqual("123 °F", temp.Output());
        }
        [TestMethod()]
        public void CelsToAnyTest()
        {
            Temperature temp;

            temp = new Temperature(100, TempType.c);
            Assert.AreEqual("212 °F", temp.To(TempType.f).Output());
            temp = new Temperature(100, TempType.c);
            Assert.AreEqual("373,15 K", temp.To(TempType.k).Output());
            temp = new Temperature(100, TempType.c);
            Assert.AreEqual("671,67 °Ra", temp.To(TempType.r).Output());
        }
        [TestMethod()]
        public void AnyToCelsTest()
        {
            Temperature temp;

            temp = new Temperature(212, TempType.f);
            Assert.AreEqual("100 °C", temp.To(TempType.c).Output());
            temp = new Temperature(373.15, TempType.k);
            Assert.AreEqual("100 °C", temp.To(TempType.c).Output());
            temp = new Temperature(671.67, TempType.r);
            Assert.AreEqual("100 °C", temp.To(TempType.c).Output());
        }
        [TestMethod()]
        public void AnyToAnyTest()
        {
            Temperature temp;

            temp = new Temperature(373.15, TempType.k);
            Assert.AreEqual("212 °F", temp.To(TempType.f).Output());
            temp = new Temperature(671.67, TempType.r);
            Assert.AreEqual("373,15 K", temp.To(TempType.k).Output());
            temp = new Temperature(212, TempType.f);
            Assert.AreEqual("671,67 °Ra", temp.To(TempType.r).Output());
        }
        [TestMethod()]
        public void AnySumTest()
        {
            var c = new Temperature(102, TempType.c);
            var k = new Temperature(278, TempType.k);
            var f = new Temperature(39.4, TempType.f);
            var r = new Temperature(90, TempType.r);
            Assert.AreEqual("106,85 °C", (c + k).Output());
            Assert.AreEqual("-121,15 °C", (c + r).Output());
            Assert.AreEqual("80,13 °F", (f + k).Output());
            Assert.AreEqual("589,07 °Ra", (r + f).Output());
            Assert.AreEqual("328 K", (k + r).Output());
        }
        [TestMethod()]
        public void CompareTest()
        {
            var c = new Temperature(100, TempType.c);
            var k = new Temperature(373.15, TempType.k);
            var f = new Temperature(39.4, TempType.f);
            Assert.AreEqual(true, c == k);
            Assert.AreEqual(false, c == f);
        }
    }
}