using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.LeftTest.g.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
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
public void LeftTest731()
{
    string s;
    s = this.LeftTest((string)null, 0);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftTest253()
{
    string s;
    s = this.LeftTest("\0", 0);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftTest891()
{
    string s;
    s = this.LeftTest("\0", 1);
    Assert.AreEqual<string>("\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftTest97()
{
    string s;
    s = this.LeftTest("\0\0\0", 1);
    Assert.AreEqual<string>("\0", s);
}
    }
}
