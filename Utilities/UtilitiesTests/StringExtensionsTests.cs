using FluentAssertions;
using Utilities;

namespace UtilitiesTests;

public class StringExtensionsTests
{
    [Fact]
    public void ToSnakeCase_converts_normal_sentences()
    {
        "Hello world".ToSnakeCase().Should().Be("hello_world");
        "This is a test".ToSnakeCase().Should().Be("this_is_a_test");
    }

    [Fact]
    public void ToSnakeCase_handles_multiple_spaces()
    {
        "  Too   many   spaces  ".ToSnakeCase().Should().Be("too_many_spaces");
    }

    [Fact]
    public void ToSnakeCase_removes_punctuation()
    {
        "Hello, World!".ToSnakeCase().Should().Be("hello_world");
        "C# is awesome!".ToSnakeCase().Should().Be("c_is_awesome");
    }

    [Fact]
    public void ToSnakeCase_handles_empty_and_whitespace_strings()
    {
        "".ToSnakeCase().Should().Be("");
        "   ".ToSnakeCase().Should().Be("");
    }

    [Fact]
    public void ToSnakeCase_handles_single_word()
    {
        "Python".ToSnakeCase().Should().Be("python");
        "snake_case".ToSnakeCase().Should().Be("snake_case"); // Already fine
    }
}
