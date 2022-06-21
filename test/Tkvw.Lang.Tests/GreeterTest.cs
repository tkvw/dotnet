namespace Tkvw.Lang.Tests;


public class GreeterTest
{
    [Theory]
    [InlineData("John")]
    [InlineData("Doe")]
    public void TestSayHello(string name)
    {
        var g = new Greeter();
        
        Assert.Equal($"Hello {name}", g.SayHello(name));
    }
}