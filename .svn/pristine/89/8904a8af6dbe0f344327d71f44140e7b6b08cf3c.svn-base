using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMDEnterpriseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMDEnterpriseLibrary.UnitTests
{
    [TestClass()]
    public class StringExtensionTests
    {
        [TestMethod()]
        public void ToCsvStringHandleBlanks()
        {
            // all blanks
            Assert.AreEqual(",,", (new[] { "", "", "" }).ToCsvString());
            Assert.AreEqual(",,", (new[] { "", "", "" }).ToCsvString(false));
            Assert.AreEqual("\"\",\"\",\"\"", (new[] { "", "", "" }).ToCsvString(true));
        }
        [TestMethod()]
        public void ToCsvStringHandleQuotes()
        {   // contains or is quote - should always quote
            Assert.AreEqual("\"\"\"\",\"He said \"\"no\"\" to that\",\"\"", (new[] { "\"", "He said \"no\" to that", "" }).ToCsvString(true));
            Assert.AreEqual("\"\"\"\",\"He said \"\"no\"\" to that\",\"\"", (new[] { "\"", "He said \"no\" to that", "" }).ToCsvString());
            Assert.AreEqual("\"\"\"\",\"He said \"\"no\"\" to that\",\"\"", (new[] { "\"", "He said \"no\" to that", "" }).ToCsvString(false));
        }
        [TestMethod()]
        public void ToCsvStringHandleCommas() { 
            // contains comma
            Assert.AreEqual("\",\",\"No, he said to that\",\"\"", (new[] { ",", "No, he said to that", "" }).ToCsvString(false));
            Assert.AreEqual("\",\",\"No, he said to that\",\"\"", (new[] { ",", "No, he said to that", "" }).ToCsvString());
            Assert.AreEqual("\",\",\"No, he said to that\",\"\"", (new[] { ",", "No, he said to that", "" }).ToCsvString(true));
        }
        [TestMethod()]
        public void ToString_Test()
        {
            Assert.AreEqual(",,", (new[] { "", "", "" }).ToString(","));
            Assert.AreEqual("1,2,3", (new[] { "1", "2", "3" }).ToString(","));
            Assert.AreEqual(",2,", (new[] { "", "2", "" }).ToString(","));
        }
    }
}