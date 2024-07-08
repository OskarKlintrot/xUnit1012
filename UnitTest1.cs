namespace xUnit1012;

[System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Usage",
    "xUnit1012:Null should only be used for nullable parameters",
    Justification = "<Pending>"
)]
public class UnitTest1
{
    [Theory]
    [InlineData(null)]
    [InlineData("Works")]
    [InlineData("Works", "as", "well")]
    public void Test1(params string[]? _) { }

    [Theory]
    [InlineData(null)]
    public void Test2(params string[]? arr)
    {
        Assert.Null(arr);
    }

    [Theory]
    [InlineData]
    public void Test3(params string[]? arr)
    {
        Assert.Empty(arr!);
    }
}
