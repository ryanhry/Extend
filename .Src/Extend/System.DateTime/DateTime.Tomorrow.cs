﻿#region Usings

using System;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class DateTimeEx
    {
        /// <summary>
        ///     Adds a day to the given date time value.
        /// </summary>
        /// <param name="dateTime">The date time to increase.</param>
        /// <returns>Tomorrow date at same time.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime Tomorrow( this DateTime dateTime )
            => dateTime.AddDays( 1 );
    }
}