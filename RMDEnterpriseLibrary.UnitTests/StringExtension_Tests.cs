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
        [TestMethod()]
        public void IsNumeric_Test()
        {
            Assert.AreEqual(true, "0".IsNumeric());
            Assert.AreEqual(true, "1".IsNumeric());
            Assert.AreEqual(true, "-1".IsNumeric());
            Assert.AreEqual(true, "0.0".IsNumeric());
            Assert.AreEqual(true, "0.1".IsNumeric());
            Assert.AreEqual(true, "1.0".IsNumeric());
            Assert.AreEqual(true, "-1.1".IsNumeric());
            // due to precision limits MaxValue and MinValue's ToString create 
            // strings that round up to higher values, which fail.  G14 format 
            // rounds down to a string that will parse back to a double
            Assert.AreEqual(true, (double.MaxValue).ToString("G14").IsNumeric()); // 1.7976931348623E+308
            Assert.AreEqual(true, (double.MinValue).ToString("G14").IsNumeric()); // -1.7976931348623E+308
            Assert.AreEqual(false, "A".IsNumeric());
            Assert.AreEqual(false, "1A".IsNumeric());
            Assert.AreEqual(false, ((string)null).IsNumeric());
        }
    }
}