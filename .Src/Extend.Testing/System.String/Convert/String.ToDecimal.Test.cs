﻿#region Usings

using System;
using System.Globalization;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class StringExTest
    {
        [Fact]
        public void ToDecimalInvalidFormatTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "InvalidFormat".ToDecimal();

            Assert.Throws<FormatException>( test );
        }

        [Fact]
        public void ToDecimalNullTest()
        {
            String value = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => value.ToDecimal();

            Assert.Throws<ArgumentNullException>( test );
        }

        [Fact]
        public void ToDecimalOverloadFormatNullTest()
        {
            CultureInfo formatProvider = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "10".ToDecimal( formatProvider );

            Assert.Throws<ArgumentNullException>( test );
        }

        [Fact]
        public void ToDecimalOverloadInvalidFormatTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "InvalidFormat".ToDecimal( new CultureInfo( "de-CH" ) );

            Assert.Throws<FormatException>( test );
        }

        [Fact]
        public void ToDecimalOverloadNullTest()
        {
            String value = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => value.ToDecimal( new CultureInfo( "de-CH" ) );

            Assert.Throws<ArgumentNullException>( test );
        }

        [Fact]
        public void ToDecimalOverloadTest()
        {
            var culture = new CultureInfo( "de-CH" );
            var value = new Decimal( 100.123 );
            var actual = value.ToString( culture )
                              .ToDecimal( culture );

            actual
                .Should()
                .Be( value );
        }

        [Fact]
        public void ToDecimalOverloadValueToBigTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "79228162514264337593543950335222".ToDecimal( new CultureInfo( "de-CH" ) );
            Assert.Throws<OverflowException>( test );
        }

        [Fact]
        public void ToDecimalOverloadValueToSmallTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "-79228162514264337593543950335222".ToDecimal( new CultureInfo( "de-CH" ) );
            Assert.Throws<OverflowException>( test );
        }

        [Fact]
        public void ToDecimalTest()
        {
            var value = new Decimal( 100.123 );
            var actual = value.ToString( CultureInfo.CurrentCulture )
                              .ToDecimal();

            actual
                .Should()
                .Be( value );
        }

        [Fact]
        public void ToDecimalValueToBigTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "79228162514264337593543950335222".ToDecimal();
            Assert.Throws<OverflowException>( test );
        }

        [Fact]
        public void ToDecimalValueToSmallTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "-79228162514264337593543950335222".ToDecimal();
            Assert.Throws<OverflowException>( test );
        }
    }
}