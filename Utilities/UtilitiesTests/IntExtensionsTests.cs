using FluentAssertions;
using Utilities;

namespace UtilitiesTests;

public class IntExtensionsTests
{
    [Fact]
    public void ToOrdinal_converts_correctly()
    {
        1.ToOrdinal().Should().Be("1st");
        2.ToOrdinal().Should().Be("2nd");
        3.ToOrdinal().Should().Be("3rd");
        4.ToOrdinal().Should().Be("4th");
        11.ToOrdinal().Should().Be("11th");
        12.ToOrdinal().Should().Be("12th");
        13.ToOrdinal().Should().Be("13th");
        21.ToOrdinal().Should().Be("21st");
        22.ToOrdinal().Should().Be("22nd");
        23.ToOrdinal().Should().Be("23rd");
    }

    [Fact]
    public void IsPrime_detects_primes_correctly()
    {
        2.IsPrime().Should().BeTrue();
        3.IsPrime().Should().BeTrue();
        5.IsPrime().Should().BeTrue();
        7.IsPrime().Should().BeTrue();
        11.IsPrime().Should().BeTrue();
        97.IsPrime().Should().BeTrue();
        101.IsPrime().Should().BeTrue();
    }

    [Fact]
    public void IsPrime_detects_non_primes_correctly()
    {
        1.IsPrime().Should().BeFalse();
        4.IsPrime().Should().BeFalse();
        6.IsPrime().Should().BeFalse();
        9.IsPrime().Should().BeFalse();
        15.IsPrime().Should().BeFalse();
        100.IsPrime().Should().BeFalse();
    }
}
