using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.NullIfBlankTest01.g.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
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
public void NullIfBlankTest01895()
{
    string s;
    s = this.NullIfBlankTest01((string)null);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void NullIfBlankTest01257()
{
    string s;
    s = this.NullIfBlankTest01("\0");
    Assert.AreEqual<string>("\0", s);
}
    }
}
