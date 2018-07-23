using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMDEnterpriseLibrary
{
    public static class Helpers
    {
        /// <summary>
        /// Same as bool?.GetValueOrDefault
        /// </summary>
        /// <param name="IsTrue">Source value</param>
        /// <returns></returns>
        public static bool BoolFromNullable(bool? IsTrue)
        {
            return (IsTrue != null) && (bool)IsTrue;
        }
        /// <summary>
        /// Same as bool?.GetValueOrDefault except returns a bool?
        /// </summary>
        /// <param name="IsTrue"></param>
        /// <returns></returns>
        public static bool? NullableBoolIsTrue(bool? IsTrue)
        {
            return (bool?)((IsTrue != null) && (bool)IsTrue);
        }
        /// <summary>
        /// Check if a string contains a value double.  Returns boolean result of double.TryParse
        /// </summary>
        /// <param name="s">Source string</param>
        /// <returns></returns>
        public static bool IsNumeric(string s)
        {
            double d;
            return double.TryParse(s, out d);
        }
        /// <summary>
        /// Check if a string can be parsed as DateTime.  Returns result of DateTime.TryParse
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsDate(string s)
        {
            DateTime dt;
            return DateTime.TryParse(s, out dt);
        }
        /// <summary>
        /// Doubles all instances of a single quote in the string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string SQLQuote(string s)
        {
            return s.Replace("'", "''");
        }
        /// <summary>
        /// If s is null, return blank, otherwise returns s.ToString()
        /// </summary>
        /// <param name="s">Source object</param>
        /// <returns></returns>
        public static string BlankNull(object s)
        {
            if (s == null)
            {
                return "";
            }
            else
            {
                return s.ToString();
            }
        }
        /// <summary>
        /// If s is null, returned 0, otherwise results int value of s (same as int?.GetValueOrDefault)
        /// </summary>
        /// <param name="s">Source int?</param>
        /// <returns></returns>
        public static int ZeroNull(int? s)
        {
            if (s == null)
            {
                return 0;
            }
            else
            {
                return (int)s;
            }
        }
        /// <summary>
        /// Replaces all instances of double quote with \"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string JSDoubleQuote(string s)
        {
            return s?.Replace("\"", "\\\"");
        }
        /// <summary>
        /// Replaces all instances of single quote with \'
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string JSSingleQuote(string s)
        {
            return s?.Replace("'", "\\'");
        }
        /// <summary>
        /// Returns the value obtained via int.TryParse or 0
        /// </summary>
        /// <param name="s">Source string</param>
        /// <returns></returns>
        public static int SafeIntFromString(string s)
        {
            if (s == null || !IsNumeric(s))
            {
                return 0;
            }
            else
            {
                int i;
                if (int.TryParse(s, out i))
                {
                    return i;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Returns the value obtained via Int64.TryParse or 0
        /// </summary>
        /// <param name="s">Source string</param>
        /// <returns></returns>
        public static long SafeLongFromString(string s)
        {
            if (s == null || !IsNumeric(s))
            {
                return 0;
            }
            else
            {
                Int64 i;
                if (Int64.TryParse(s, out i))
                {
                    return i;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Returns the value obtained via double.TryParse or 0
        /// </summary>
        /// <param name="s">Source string</param>
        /// <returns></returns>
        public static double SafeDoubleFromString(string s)
        {
            if (s == null || !IsNumeric(s))
            {
                return 0;
            }
            else
            {
                double d;
                if (double.TryParse(s, out d))
                {
                    return d;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// If string is a valid DateTime, returns it in the format dt.ToString("ddd M/d h:mm").ToUpper() + dt.ToString("tt").ToLower(), otherwise returns blank
        /// </summary>
        /// <param name="sdt">Source string</param>
        /// <returns>Non-null string</returns>
        public static string CompactDateTimeString(string sdt)
        {
            if (sdt != null && IsDate(sdt))
            {
                DateTime dt = DateTime.Parse(sdt);
                return dt.ToString("ddd M/d h:mm").ToUpper() + dt.ToString("tt").ToLower();
            }
            else
            {
                return BlankNull(sdt);
            }
        }
        public static string DateToString(DateTime? TheDate, string DateFormatString)
        {
            if (TheDate == null)
                return "";
            else
                return ((DateTime)TheDate).ToString(DateFormatString);
        }
        public static string CompactDateTimeRangeString(string sdt, string sdt2)
        {
            if (sdt != null && IsDate(sdt) && sdt2 != null && IsDate(sdt2))
            {
                DateTime dt = DateTime.Parse(sdt2);
                return CompactDateTimeString(sdt) + " - " + dt.ToString("h:mmtt").ToLower();
            }
            else
            {
                return BlankNull(sdt) + " - " + BlankNull(sdt2);
            }
        }
        public static string ShortFileSize(long bytes, int precision)
        {
            float i = bytes;
            string s = "";
            if (i >= (1024 * 1024))
            {
                i = i / (1024 * 1024);
                s = "M";
            }
            else if (i >= 1024)
            {
                i = i / 1024;
                s = "K";
            }
            return i.ToString("F" + precision.ToString()) + s;
        }
        /// <summary>
        ///     Encodes a string using only uppercase letters of the alphabet.  String length is encoded and checked also (see ConvertFromAlpha).
        /// </summary>
        /// <param name="s">The string to encode</param>
        /// <returns>An encoded string</returns>
        public static string ConvertToAlpha(string s)
        {
            string t = "";
            char[] a = (s + "|" + s.Length.ToString()).ToCharArray(); // add payload length and encode with string to prevent arbitrary adding and dropping of characters
            char c;
            for (int i = 0; i < a.Length; i++)
            {
                c = a[i];
                t += ((char)(65 + (int)((int)(c) / 26))).ToString() + ((char)(65 + ((int)(c) % 26))).ToString();
            }
            return t;
        }

        public static string ConvertFromAlpha(string s)
        {
            string t = "";
            char[] a = s.ToCharArray();
            char c1; char c2;

            if (a.Length % 2 == 0) // invalid if length is odd
            {
                for (int i = 0; i < a.Length; i += 2)
                {
                    c1 = a[i];
                    c2 = a[i + 1];
                    t += (char)(((int)(c1) - 65) * 26 + ((int)(c2) - 65));
                }
                int i2 = t.LastIndexOf("|");
                int i1 = Helpers.SafeIntFromString(t.Substring(t.LastIndexOf("|") + 1));

                // the string is supposed to end with the payload length, so extract and compare
                if (t.LastIndexOf("|") > 0 && Helpers.SafeIntFromString(t.Substring(t.LastIndexOf("|") + 1)) > 0 && Helpers.SafeIntFromString(t.Substring(t.LastIndexOf("|") + 1)) == (t.LastIndexOf("|")))
                {
                    t = t.Substring(0, Helpers.SafeIntFromString(t.Substring(t.LastIndexOf("|") + 1)));
                }
                else
                {
                    t = "";
                }
            }
            return t;
        }
        public static string SafeShortDate(string s)
        {
            if (IsDate(s))
            {
                return DateTime.Parse(s).ToString("d");
            }
            else
            {
                return s;
            }
        }
        public static bool isIntList(string s, char separator)
        {
            bool allNumeric = true;
            string[] t = BlankNull(s).Split(separator);
            foreach (string u in t)
            {
                allNumeric = allNumeric && IsNumeric(u);
                if (!allNumeric)
                {
                    break;
                }
            }
            return allNumeric;
        }
        public static string GetFileNameFromFilePath(string FilePath)
        {
            //            string sPath = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            System.IO.FileInfo oInfo = new System.IO.FileInfo(FilePath);
            string sRet = oInfo.Name;
            return sRet;
        }
        public static class AnyObject<T> where T : class, new()
        {
            public static T ShallowCopy(T item)
            {
                return ShallowCopy(item, "");
            }

            public static T ShallowCopy(T item, string OmitPropeties)
            {
                if (item == null)
                {
                    return null;
                }
                T newItem = new T();
                foreach (System.Reflection.PropertyInfo prop in item.GetType().GetProperties())
                {
                    if ((prop.PropertyType.IsValueType || prop.PropertyType.Name == "String") && !prop.PropertyType.Name.StartsWith("EntitySet") && !("|" + OmitPropeties + "|").ToLower().Contains("|" + prop.Name.ToLower() + "|"))
                    {
                        System.Reflection.PropertyInfo prop2 = item.GetType().GetProperty(prop.Name);
                        prop2.SetValue(newItem, prop.GetValue(item, null), null);
                    }
                }
                return newItem;
            }
        }
        public static Boolean TryStrToGuid(String s, out Guid value)
        {
            if (s == null)
            {
                value = Guid.Empty;
                return false;
            }
            try
            {
                value = new Guid(s);
                return true;
            }
            catch (FormatException)
            {
                value = Guid.Empty;
                return false;
            }
        }
        public static Boolean IsNonEmptyGuid(string s)
        {
            Guid testguid;
            if (TryStrToGuid(s, out testguid))
            {
                return testguid != Guid.Empty;
            }
            else
                return false;
        }
        public static Guid SafeGuidFromString(string s)
        {
            Guid testguid;
            bool test = TryStrToGuid(s, out testguid);
            return testguid;
        }
    }
}
