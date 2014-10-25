﻿#region Usings

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace PortableExtensions
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ISpecification{T}"/>.
    /// </summary>
    public static partial class SpecificationEx
    {
        /// <summary>
        /// Combines the current specification with the given expression using a OR link.
        /// </summary>
        /// <typeparam name="T">The target type of the specification.</typeparam>
        /// <param name="specification">The current specification.</param>
        /// <param name="expression">The expression to add.</param>
        /// <returns>Returns the combined specifications.</returns>
        public static ISpecification<T> Or<T>(this ISpecification<T> specification, Func<T, Boolean> expression)
        {
            var newSpecification = new ExpressionSpecification<T>(expression);
            return specification.Or(newSpecification);
        }
    }
}