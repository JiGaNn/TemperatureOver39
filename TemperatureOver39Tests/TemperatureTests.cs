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
    }
}