using ReverseApi;

namespace ReverseApi.Tests;

public class TextUtilsTests
{
    [Theory]
    [InlineData("hello world", "dlrow olleh")]
    [InlineData("racecar", "racecar")]
    [InlineData("", "")]
    [InlineData("  ", "  ")]
    [InlineData("Great", "taerG")]
    public void Reverse_Works(string input, string expected)
    {
        var actual = TextUtils.Reverse(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Reverse_Null_ReturnsEmpty()
    {
        string? input = null;
        var actual = TextUtils.Reverse(input);
        Assert.Equal(string.Empty, actual);
    }
}
