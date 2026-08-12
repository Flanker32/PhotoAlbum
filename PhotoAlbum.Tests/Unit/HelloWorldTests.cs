namespace PhotoAlbum.Tests.Unit;

public class HelloWorldTests
{
    [Fact]
    public void HelloWorld_ReturnsExpectedMessage()
    {
        const string message = "Hello, World!";

        Assert.Equal("Hello, World!", message);
    }
}
