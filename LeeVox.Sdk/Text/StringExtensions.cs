using System;
using System.Text;

namespace LeeVox.Sdk
{
    public static class StringExtensions
    {
        /// <summary>
        /// Removes all leading and trailing white-space characters from the current
        /// <see cref="String"/> object, returns <see cref="string.Empty"/> in case of <c>null</c>.
        /// </summary>
        /// <remarks>
        /// This is shortcut to <c>text?.Trim() ?? string.Empty</c>
        /// </remarks>
        public static string SafeTrim(this string text)
            => text?.Trim() ?? string.Empty;

        /// <summary>
        /// Removes all leading and trailing occurrences of a set of characters specified
        /// in an array from the current <see cref="String"/> object, returns <see cref="string.Empty"/>
        /// in case of <c>null</c>.
        /// </summary>
        /// <remarks>
        /// This is shortcut to <c>text?.Trim(trimChars) ?? string.Empty</c>
        /// </remarks>
        public static string SafeTrim(this string text, params char[] trimChars)
            => text?.Trim(trimChars) ?? string.Empty;

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value to another <see cref="String"/> using <see cref="StringComparison.CurrentCulture"/>
        /// </summary>
        public static bool IsEqual(this string a, string b)
            => IsEqual(a, b, StringComparison.CurrentCulture);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value to another <see cref="String"/> using <see cref="StringComparison.CurrentCulture"/> with option to ignore case
        /// </summary>
        public static bool IsEqual(this string a, string b, bool ignoreCase)
            => IsEqual(a, b, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value to another <see cref="String"/> using specified <see cref="StringComparison"/>
        /// </summary>
        public static bool IsEqual(this string a, string b, StringComparison stringComparison)
            => string.Equals(a, b, stringComparison);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value to another <see cref="String"/> using <see cref="StringComparison.Ordinal"/>
        /// </summary>
        public static bool IsOrdinalEqual(this string a, string b)
            => IsOrdinalEqual(a, b, false);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value to another <see cref="String"/> using <see cref="StringComparison.Ordinal"/> with option to ignore case
        /// </summary>
        public static bool IsOrdinalEqual(this string a, string b, bool ignoreCase)
            => string.Equals(a, b, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value (ignore trailing and leading spaces) to another <see cref="String"/> using <see cref="StringComparison.CurrentCulture"/>
        /// </summary>
        public static bool IsEqualIgnoreSpaces(this string a, string b)
            => IsEqualIgnoreSpaces(a, b, StringComparison.CurrentCulture);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value (ignore trailing and leading spaces) to another <see cref="String"/> using <see cref="StringComparison.CurrentCulture"/> with option to ignore case
        /// </summary>
        public static bool IsEqualIgnoreSpaces(this string a, string b, bool ignoreCase)
            => IsEqualIgnoreSpaces(a, b, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value (ignore trailing and leading spaces) to another <see cref="String"/> using a specified <see cref="StringComparison"/>
        /// </summary>
        public static bool IsEqualIgnoreSpaces(this string a, string b, StringComparison stringComparison)
            => string.Equals(a?.Trim(), b?.Trim(), stringComparison);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value (ignore trailing and leading spaces) to another <see cref="String"/> using <see cref="StringComparison.Ordinal"/>
        /// </summary>
        public static bool IsOrdinalEqualIgnoreSpaces(this string a, string b)
            => IsOrdinalEqualIgnoreSpaces(a, b, false);

        /// <summary>
        /// Determines whether a <see cref="String"/> has same value (ignore trailing and leading spaces) to another <see cref="String"/> using <see cref="StringComparison.Ordinal"/> with option to ignore case
        /// </summary>
        public static bool IsOrdinalEqualIgnoreSpaces(this string a, string b, bool ignoreCase)
            => string.Equals(a?.Trim(), b?.Trim(), ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        /// <summary>
        /// Determines whether a <see cref="String"/> contains another <see cref="String"/> using <see cref="StringComparison.CurrentCulture"/> with option to ignore case
        /// </summary>
        /// <exception cref="System.NullReferenceException">current string is null</exception>
        /// <exception cref="System.ArgumentNullException">search string is null</exception>
        public static bool Contains(this string text, string search, bool ignoreCase)
            => Contains(text, search, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);

        /// <summary>
        /// Determines whether a <see cref="String"/> contains another <see cref="String"/> using a specified <see cref="StringComparison"/>
        /// </summary>
        /// <exception cref="System.NullReferenceException">current string is null</exception>
        /// <exception cref="System.ArgumentNullException">search string is null</exception>
        public static bool Contains(this string text, string search, StringComparison stringComparison)
            => text.IndexOf(search, stringComparison) >= 0;

        /// <summary>
        /// Determines whether a <see cref="String"/> contains another <see cref="String"/> using <see cref="StringComparison.Ordinal"/>
        /// </summary>
        /// <exception cref="System.NullReferenceException">current string is null</exception>
        /// <exception cref="System.ArgumentNullException">search string is null</exception>
        public static bool OrdinalContains(this string text, string search)
            => OrdinalContains(text, search, false);

        /// <summary>
        /// Determines whether a <see cref="String"/> contains another <see cref="String"/> using <see cref="StringComparison.Ordinal"/> with option to ignore case
        /// </summary>
        /// <exception cref="System.NullReferenceException">current string is null</exception>
        /// <exception cref="System.ArgumentNullException">search string is null</exception>
        public static bool OrdinalContains(this string text, string search, bool ignoreCase)
            => text.IndexOf(search, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0;
    }
}