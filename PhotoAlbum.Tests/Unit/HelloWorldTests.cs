namespace PhotoAlbum.Tests.Unit;

public class HelloWorldTests
{
    [Fact]
    public void GetMessage_ReturnsHelloWorld()
    {
        var helloWorld = new HelloWorld();

        Assert.Equal("Hello, World!", helloWorld.GetMessage());
    }
}
