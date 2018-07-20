using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.IsNumericTest.g.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace RMDEnterpriseLibrary.Tests
{
    public partial class StringExtensionTest
    {

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest582()
{
    bool b;
    b = this.IsNumericTest((string)null);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest28()
{
    bool b;
    b = this.IsNumericTest("\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest667()
{
    bool b;
    b = this.IsNumericTest("0");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest660()
{
    bool b;
    b = this.IsNumericTest("0\0");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest882()
{
    bool b;
    b = this.IsNumericTest("耰\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest161()
{
    bool b;
    b = this.IsNumericTest("耰e");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest814()
{
    bool b;
    b = this.IsNumericTest("耰");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest71()
{
    bool b;
    b = this.IsNumericTest("耰e\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest815()
{
    bool b;
    b = this.IsNumericTest("-");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest640()
{
    bool b;
    b = this.IsNumericTest("耰.");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest885()
{
    bool b;
    b = this.IsNumericTest("耰e0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest137()
{
    bool b;
    b = this.IsNumericTest("耰e0\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest856()
{
    bool b;
    b = this.IsNumericTest("耰e:");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest978()
{
    bool b;
    b = this.IsNumericTest("-\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest411()
{
    bool b;
    b = this.IsNumericTest("耰.\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest369()
{
    bool b;
    b = this.IsNumericTest("耰.0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest52()
{
    bool b;
    b = this.IsNumericTest("耰.0\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest821()
{
    bool b;
    b = this.IsNumericTest("耰e00");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest23()
{
    bool b;
    b = this.IsNumericTest("耰e00\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest899()
{
    bool b;
    b = this.IsNumericTest("-耰.00");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest450()
{
    bool b;
    b = this.IsNumericTest("-00");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest199()
{
    bool b;
    b = this.IsNumericTest("-耰.00\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void IsNumericTest970()
{
    bool b;
    b = this.IsNumericTest("-00\0");
    Assert.AreEqual<bool>(true, b);
}
    }
}
