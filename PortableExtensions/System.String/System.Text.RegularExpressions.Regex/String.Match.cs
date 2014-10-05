﻿#region Using

using System;
using System.Text.RegularExpressions;

#endregion

namespace PortableExtensions
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Searches the specified input string for the first occurrence of the specified regular expression.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match( this String input, String pattern )
        {
            input.ThrowIfNull( () => input );
            input.ThrowIfNull( () => pattern );

            return Regex.Match( input, pattern );
        }

        /// <summary>
        ///     Searches the input string for the first occurrence of the specified regular expression, using the specified
        ///     matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match( this String input, String pattern, RegexOptions options )
        {
            input.ThrowIfNull( () => input );
            input.ThrowIfNull( () => pattern );

            return Regex.Match( input, pattern, options );
        }

        /// <summary>
        ///     Searches the input string for the first occurrence of the specified regular expression, using the specified
        ///     matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeOut">The timeout for the regular expression operation.</param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match( this String input, String pattern, RegexOptions options, TimeSpan timeOut )
        {
            input.ThrowIfNull( () => input );
            input.ThrowIfNull( () => pattern );
            timeOut.ThrowIfNull( () => timeOut );

            return Regex.Match( input, pattern, options, timeOut );
        }
    }
}