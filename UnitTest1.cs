namespace xUnit1012;

public class UnitTest1
{
    [Theory]
    [InlineData(null)]
    [InlineData("Works")]
    [InlineData("Works", "as", "well")]
    public void Test1(params string[]? _) { }
}
