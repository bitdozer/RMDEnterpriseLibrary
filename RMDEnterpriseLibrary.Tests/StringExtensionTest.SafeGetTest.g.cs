using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.SafeGetTest.g.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
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
public void SafeGetTest117()
{
    string s;
    s = this.SafeGetTest((string[])null, 0);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeGetTest917()
{
    string s;
    string[] ss = new string[0];
    s = this.SafeGetTest(ss, 0);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeGetTest162()
{
    string s;
    string[] ss = new string[1];
    s = this.SafeGetTest(ss, 0);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeGetTest236()
{
    string s;
    string[] ss = new string[0];
    s = this.SafeGetTest(ss, int.MinValue);
    Assert.AreEqual<string>("", s);
}
    }
}
