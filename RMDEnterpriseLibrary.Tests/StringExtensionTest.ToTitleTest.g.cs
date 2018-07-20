using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.ToTitleTest.g.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
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
public void ToTitleTest236()
{
    string s;
    s = this.ToTitleTest((string)null, false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest827()
{
    string s;
    s = this.ToTitleTest(" ", false);
    Assert.AreEqual<string>(" ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest699()
{
    string s;
    s = this.ToTitleTest(" ", true);
    Assert.AreEqual<string>(" ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest795()
{
    string s;
    s = this.ToTitleTest("\0", false);
    Assert.AreEqual<string>("\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest950()
{
    string s;
    s = this.ToTitleTest("H", false);
    Assert.AreEqual<string>("H", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest740()
{
    string s;
    s = this.ToTitleTest("h", false);
    Assert.AreEqual<string>("H", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest973()
{
    string s;
    s = this.ToTitleTest("a", false);
    Assert.AreEqual<string>("a", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest442()
{
    string s;
    s = this.ToTitleTest(" \0", false);
    Assert.AreEqual<string>(" \0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest463()
{
    string s;
    s = this.ToTitleTest("  ", false);
    Assert.AreEqual<string>("  ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest110()
{
    string s;
    s = this.ToTitleTest(" \0", true);
    Assert.AreEqual<string>(" \0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest119()
{
    string s;
    s = this.ToTitleTest("\0  ", false);
    Assert.AreEqual<string>("\0  ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest17()
{
    string s;
    s = this.ToTitleTest("\0   ", false);
    Assert.AreEqual<string>("\0   ", s);
}
    }
}
