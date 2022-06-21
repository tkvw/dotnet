namespace Tkvw.Lang.Tests;
using Xunit;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(2, 2));
    }

    int Add(int x, int y)
    {
        return x + y;
    }
}