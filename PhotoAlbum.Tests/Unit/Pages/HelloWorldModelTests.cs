using PhotoAlbum.Pages;

namespace PhotoAlbum.Tests.Unit.Pages;

public class HelloWorldModelTests
{
    [Fact]
    public void OnGet_SetsMessageToHelloWorld()
    {
        var model = new HelloWorldModel();

        model.OnGet();

        Assert.Equal("Hello World", model.Message);
    }
}
