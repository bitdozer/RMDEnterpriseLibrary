using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.ContainsCountTest.g.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
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
public void ContainsCountTest166()
{
    long l;
    l = this.ContainsCountTest((string)null, ' ');
    Assert.AreEqual<long>(0L, l);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ContainsCountTest416()
{
    long l;
    l = this.ContainsCountTest("\0", ' ');
    Assert.AreEqual<long>(0L, l);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ContainsCountTest543()
{
    long l;
    l = this.ContainsCountTest(" ", ' ');
    Assert.AreEqual<long>(1L, l);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ContainsCountTest64()
{
    long l;
    l = this.ContainsCountTest(" \0", ' ');
    Assert.AreEqual<long>(1L, l);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ContainsCountTest971()
{
    long l;
    l = this.ContainsCountTest("  ", ' ');
    Assert.AreEqual<long>(2L, l);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ContainsCountTest963()
{
    long l;
    l = this.ContainsCountTest("! \0", '!');
    Assert.AreEqual<long>(1L, l);
}
    }
}
