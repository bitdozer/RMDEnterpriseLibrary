using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace RMDEnterpriseLibrary
{
    public static class StringExtension
    {
        /// <summary>
        /// Alias for System.Uri.EscapeDataString with null handling (null input returns null)
        /// </summary>
        /// <param name="str">string to encode</param>
        /// <returns></returns>
        public static string UriEscapeDataString(this String str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return Uri.EscapeDataString(str);
        }
        /// <summary>
        /// If string is null, returns blank, otherwise returns original string
        /// </summary>
        /// <param name="str">string to process</param>
        /// <returns></returns>
        public static string BlankIfNull(this String str)
        {
            if (str == null)
                return "";
            else
                return str;
        }
        /// <summary>
        /// Returns the DefaultValue if the string IsNullOrEmpty
        /// </summary>
        /// <param name="str"></param>
        /// <param name="DefaultValue"></param>
        /// <returns></returns>
        public static string OrDefault(this String str, string DefaultValue)
        {
            if (string.IsNullOrEmpty(str))
                return DefaultValue;
            else
                return str;
        }
        /// <summary>
        /// Shortens a string to a maximum target length appending an indicator string
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="length">check length; if string is shorter than this it is not processed</param>
        /// <param name="shortenBy">if string exceeds length it will be shortened to length-shortenBy</param>
        /// <param name="append">string to append if string is shortened, e.g. "..."</param>
        /// <returns></returns>
        public static string LimitLength(this String s, int length, int shortenBy, string append)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (length < 1 || length - shortenBy < 1)
            {
                return "";
            }
            if (length - shortenBy > s.Length)
            {
                return s;
            }
            if (s.Length > length && s.Length > shortenBy)
                return s.Substring(0, length - shortenBy) + (append ?? "");
            else
                return s;
        }
        /// <summary>
        /// Shortens a string to a maximum target length appending "..." if shortening occurred
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="length">check length; if string is shorter than this it is not processed</param>
        /// <param name="shortenBy">if string exceeds length it will be shortened to length-shortenBy</param>
        /// <returns></returns>
        public static string LimitLength(this String s, int length, int shortenBy)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return LimitLength(s, length, shortenBy, "...");
        }
        /// <summary>
        /// Shortens a string to a maximum target length
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="length">check length; if string is shorter than this it is not processed</param>
        /// <returns></returns>
        public static string LimitLength(this String s, int length)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return LimitLength(s, length, 3);
        }
        /// <summary>
        /// Returns the left len characters of a string.  If string is null, returns blank
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="len">maximum characters to return</param>
        /// <returns></returns>
        public static string Left(this string s, int len)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (len < 1 || s.Length == 0)
                return "";
            else if (s.Length <= len)
                return s;
            else
                return s.Substring(0, len);
        }
        /// <summary>
        /// Returns the portion of the string left of the first occurrence of a 
        /// target string; case sensitive; returns blank if input is null or 
        /// search string is not found
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="search">string to search for</param>
        /// <returns></returns>
        public static string LeftOf(this string s, string search)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (search == null)
                return s;
            if (s.Length == 0 || !s.Contains(search))
                return "";
            else
                return s.Substring(0, s.IndexOf(search));
        }
        /// <summary>
        /// Returns the portion of the string left of the first occurrence of a 
        /// target string; case sensitive; returns blank if input is null or 
        /// search string is not found
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="search">string to search for</param>
        /// <param name="ReturnWholeStringIfNotFound">if true, and search is 
        /// not found, whole string is returned; if false blank is returned
        /// </param>
        /// <returns></returns>
        public static string LeftOf(this string s, string search, bool ReturnWholeStringIfNotFound)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (search == null)
                return s;
            if (s.Length == 0 || !(s.Contains(search) || ReturnWholeStringIfNotFound))
                return "";
            else
                return s.Substring(0, (s + search).IndexOf(search));
        }
        /// <summary>
        /// Returns the portion of the string left of the last occurrence of a 
        /// target string; case sensitive; returns blank if input is null or 
        /// search string is not found
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="search">string to search for</param>
        /// <param name="ReturnWholeStringIfNotFound">if true, and search is 
        /// not found, whole string is returned; if false blank is returned
        /// </param>
        /// <returns></returns>
        public static string LeftOfLast(this string s, string search, bool returnWholeStringIfNotFound = false)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search) || !s.Contains(search))
                return returnWholeStringIfNotFound ? s : "";
            return s.Substring(0, s.LastIndexOf(search));
        }
        /// <summary>
        /// Returns the portion of the string right of the last occurrence of a 
        /// target string; case sensitive; returns blank if input is null or 
        /// search string is not found
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="search">string to search for</param>
        /// <param name="ReturnWholeStringIfNotFound">if true, and search is 
        /// not found, whole string is returned; if false blank is returned
        /// </param>
        /// <returns></returns>
        public static string RightOf(this string s, string search, bool ReturnWholeStringIfNotFound)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search))
                return s;
            if (!(s.Contains(search) || ReturnWholeStringIfNotFound))
                return "";
            else
            {
                string t = search + s;
                return t.Substring(t.LastIndexOf(search) + search.Length);
            }
        }
        /// <summary>
        /// Returns the portion of the string right of the last occurrence of a 
        /// target string; case sensitive; returns blank if input is null or 
        /// search string is not found
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="search">string to search for</param>
        /// <returns></returns>
        public static string RightOf(this string s, string search)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search))
                return s;
            if (s.Length == 0 || !s.Contains(search))
                return "";
            else
                return s.Substring(s.LastIndexOf(search) + search.Length);
        }
        /// <summary>
        /// Returns the portion of the string right of the first occurrence of a 
        /// target string; case sensitive; returns blank if input is null or 
        /// search string is not found
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="search">string to search for</param>
        /// <returns></returns>
        public static string RightOfFirst(this string s, string search)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search))
                return s;
            if (s.Length == 0 || !s.Contains(search))
                return "";
            else
                return s.Substring(s.IndexOf(search) + search.Length);
        }
        /// <summary>
        /// Returns the portion of the string right of the first occurrence of a 
        /// target string using the specified comparer when searching; returns 
        /// blank if input is null or search string is not found
        /// </summary>
        /// <param name="s">string to process</param>
        /// <param name="search">string to search for</param>
        /// <param name="comparer">StringComparison to use for search</param>
        /// <returns></returns>
        public static string RightOfFirst(this string s, string search, StringComparison comparer)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search))
                return s;

            if (s.Length == 0 || (s.IndexOf(search, comparer) < 0))
                return "";
            else
                return s.Substring(s.IndexOf(search, comparer) + search.Length);
        }
        /// <summary>
        /// Replace with control over culture and case handling.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search">String to find</param>
        /// <param name="replace">Replacement string</param>
        /// <param name="comparer">StringComparison enumerable type</param>
        /// <returns></returns>
        public static string Replace(this string s, string search, string replace, StringComparison comparer)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(search) || (s.IndexOf(search, comparer) < 0))
                return s;
            else
            {
                string s2 = s;
                int index = 0;
                while (index < s2.Length && s2.IndexOf(search, index, comparer) >= 0)
                {
                    int foundat = s2.IndexOf(search, index, comparer);
                    s2 = s2.Left(foundat) + (replace ?? "") + s2.Substring(foundat + search.Length);
                    index = foundat + (replace == null ? 0 : replace.Length);
                }
                return s2;
            }
        }
        /// <summary>
        /// Returns the portion of a string to the left of the first occurrence of a character
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string LeftOf(this string s, char c)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return LeftOf(s, c.ToString());
        }
        public static string RightOf(this string s, char c)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return RightOf(s, c.ToString());
        }
        public static string Right(this string s, int len)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (len < 1 || s.Length == 0)
                return "";
            else if (s.Length <= len)
                return s;
            else
                return s.Substring(s.Length - len);
        }
        public static string Pluralize(this string s, bool pluralize)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (pluralize && !s.EndsWith("."))
            {
                if (s.EndsWith("y") && !("|ay|ey|oy|iy|uy|").Contains("|" + s.Right(2) + "|"))
                {
                    return s.Left(s.Length - 1) + "ies";
                }
                else if (s.EndsWith("s"))
                {
                    return s + "es";
                }
                else
                    return s + "s";
            }
            else
                return s;
        }
        public static string Pluralize(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return Pluralize(s, true);
        }
        public static bool IsBlankOrNull(this string s, bool TreatWhiteSpaceAsBlank)
        {
            return (string.IsNullOrEmpty(s) || (TreatWhiteSpaceAsBlank && s.Trim().Length == 0));
        }
        public static bool IsBlankOrNull(this string s)
        {
            return string.IsNullOrEmpty(s);
        }
        public static string NullIfBlank(this string s, bool TreatWhiteSpaceAsBlank)
        {
            if (string.IsNullOrEmpty(s) || (TreatWhiteSpaceAsBlank && s.Trim().Length == 0))
                return null;
            else
                return s;
        }
        public static string NullIfBlank(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;
            else
                return s;
        }
        public static string StripNonAlphaNumeric(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
                if (char.IsLetterOrDigit(s[i]))
                    sb.Append(s[i]);
            return sb.ToString();
        }
        public static string StripChars(this string s, char[] chars)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (chars == null || chars.Length == 0)
                return s;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
                if (!chars.Contains(s[i]))
                    sb.Append(s[i]);
            return sb.ToString();
        }
        /// <summary>
        /// Expands a string by adding a space before any upper-case letters
        /// </summary>
        /// <param name="s">Input string in CamelCase</param>
        /// <returns>Input string expanded with spaces.</returns>
        public static string ExpandCamel(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && s[i] >= 'A' && s[i] <= 'Z')
                    sb.Append(" ");
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
        public static long ContainsCount(this string s, char FindChar)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            long count = 0;
            foreach (char c in s)
                if (c == FindChar) count++;
            return count;
        }
        public static string ToSentence(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (s.BlankIfNull().Length > 1)
            {
                return s.Left(1).ToUpper() + s.Substring(1).ToLower();
            }
            else
            {
                return s.BlankIfNull().ToUpper();
            }
        }
        /// <summary>
        /// Like Split, returns a string array, but includes each splitter as an element of the array (allows original to be reassembled from the list). 
        /// </summary>
        /// <param name="s">Input string</param>
        /// <param name="splitters">List of char delimiters</param>
        /// <returns></returns>
        public static string[] SplitKeepSplitters(this string s, params char[] splitters)
        {
            if (string.IsNullOrEmpty(s) || splitters == null || splitters.Length == 0)
                return new string[] {s};

            System.Collections.Generic.List<string> outlist = new List<string>();
            while (s.Length > 0)
            {
                if (splitters.Contains(s[0]))
                {
                    outlist.Add(s[0].ToString());
                    if (s.Length > 1)
                        s = s.Substring(1);
                    else
                        s = "";
                }
                else
                {
                    int i = 0;
                    while (i < s.Length && !splitters.Contains(s[i]))
                        i++;
                    if (s.Length > i + 1)
                    {
                        outlist.Add(s.Left(i));
                        s = s.Substring(i);
                    }
                    else
                    {
                        outlist.Add(s);
                        s = "";
                    }
                }
            }
            return outlist.ToArray();
        }
        /// <summary>
        /// Splits a string list, trims the elements of whitespace and omits blank and duplicate items
        /// </summary>
        /// <param name="s">string to split at splitters</param>
        /// <param name="splitters">char[] of splitter characters</param>
        /// <returns>string[]</returns>
        public static string[] SplitTrim(this string s, params char[] splitters)
        {
            if (s.IsBlankOrNull())
                return new string[0];
            if (splitters == null || splitters.Length == 0)
                return new string[] {s};
            var atemp = s.Split(splitters);
            List<string> templist = new List<string>();
            foreach (var item in atemp)
            {
                s = item.Trim();
                if (s.Length > 0 && !templist.Contains(item))
                    templist.Add(s);
            }
            return templist.ToArray();
        }
        /// <summary>
        /// Splits a string list, trims the elements of whitespace and optionally retains blank and/or duplicate items
        /// </summary>
        /// <param name="AllowEmptyItems">If true, empty values are retained</param>
        /// <param name="AllowDuplicates">If true, duplicate values are retained</param>
        /// <param name="splitters">char[] of splitters</param>
        /// <returns>string[]</returns>
        public static string[] SplitTrim(this string s, bool AllowEmptyItems, bool AllowDuplicates, params char[] splitters)
        {
            var atemp = s.Split(splitters);
            if (atemp.Length == 0)
                return atemp;
            List<string> templist = new List<string>();
            foreach (var item in atemp)
            {
                s = (item ?? "").Trim();
                if ((s.Length > 0 || AllowEmptyItems) && (AllowDuplicates || !templist.Contains(item)))
                    templist.Add(s);
            }
            return templist.ToArray();
        }
        public static string ToTitle(this string s, bool ForceLowerCase)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            string[] words = s.SplitKeepSplitters(' ', '-', '/', '(', '+', '=', '\'', '"', '{', '[', '<', '>', ',', '\n', '\r', '\t', '&');
            string[] ignore = { "of", "on", "the", "a", "an", "the", "to", "but", "or", "and", "nor", "in", "for", "with", "as", "by", "at", "from" };
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    if (!ignore.Contains(word.ToLower()))
                        sb.Append(word[0].ToString().ToUpper() + (ForceLowerCase ? word.Substring(1).ToLower() : word.Substring(1)));
                    else
                        sb.Append(word.ToLower());
                }
            }
            return sb.ToString();
        }

        public static string ToTitle(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            return s.ToTitle(true);
        }
        // adapted from: http://blog.binaryocean.com/2008/02/24/TextBoxMaxLengthFromLINQMetaData.aspx
        /// <summary>
        /// Returns text between first StartText and EndText in s
        /// </summary>
        /// <param name="s">String being searched</param>
        /// <param name="StartText">Start delimiter</param>
        /// <param name="EndText">End delimiter</param>
        /// <returns></returns>
        public static string BetweenFirst(this string s, string StartText, string EndText)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            int start = s.IndexOf(StartText ?? "", StringComparison.OrdinalIgnoreCase) + (StartText ?? "").Length;
            if (start < 0 || start >= s.Length)
                return String.Empty;
            int end = s.IndexOf(EndText ?? "", start, StringComparison.OrdinalIgnoreCase);
            if (end < 1 || end > s.Length)
                return string.Empty;
            return s.Substring(start, end - start);
        }
        public static bool IsNumeric(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            double d;
            return double.TryParse(s, out d);
        }
        public static string ToString(this string[] l, string separator)
        {
            string s = "";
            if (l != null && l.Length > 0)
            {
                for (int i = 0; i < l.Length; i++)
                    s += ((i > 0) ? separator : "") + l[i];
            }
            return s;
        }
        /// <summary>
        /// Returns a CSV of the array.  Values are quoted if any value contains a comma or quote, or if alwaysQuote=true
        /// </summary>
        /// <param name="productArray">Array of string. nulls are converted to the empty string</param>
        /// <param name="alwaysQuote">Always use quotes, even if no value requires it</param>
        /// <returns></returns>
        public static string ToCsvString(this string[] productArray, bool alwaysQuote = false)
        {
            if (productArray == null)
                return null;
            if (productArray.Length == 0)
                return "";
            string s = "";
            bool quoted = alwaysQuote || productArray.Any(p => p != null && (p.Contains(",") || p.Contains("\"")));
            for (var i = 0; i < productArray.Length; i++)
            {
                var s1 = productArray[i] ?? "";
                if (quoted)
                    s1 = s1.Replace("\"", "\"\"");
                s += ((i > 0) ? "," : "") + (quoted ? "\"" : "") + s1 +
                     (quoted ? "\"" : "");
            }
            return s;
        }

        public static string SafeGet(this string[] l, int index)
        {
            if (l != null && index >= 0 &&  l.Length > index)
                return l[index];
            else
                return "";
        }
        public static string SafeGet(this string[] l, int index, string DefaultValue)
        {
            if (l != null && index >= 0 && l.Length > index)
                return l[index];
            else
                return DefaultValue;
        }
        /// <summary>
        /// Returns position of first character in string not in the array.  Returns -1 if not found.
        /// </summary>
        /// <param name="s">String to search</param>
        /// <param name="Find">Char array of ignore characters</param>
        /// <returns></returns>
        public static int IndexOfAnyOther(this string s, char[] Find)
        {
            if (string.IsNullOrEmpty(s) || Find == null || Find.Length == 0)
                return -1;
            var position = 0;
            while (position < s.Length && Find.Contains(s[position]))
                position++;
            if (position >= s.Length)
                return -1;
            else
                return position;
        }
        public static string StripHtmlTags(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            bool inside = false;

            for (int i = 0; i < s.Length; i++)
            {
                char let = s[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    sb.Append(let);
                }
            }
            return sb.ToString();
        }
        public static string NormalizeLineEndings(this string s, string LineEnding)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            s = s.Replace("\r", "");
            s = s.Replace("\n", LineEnding);
            return s;
        }
        public static int SafeInt(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            return Helpers.SafeIntFromString(s);
        }
    }

}
