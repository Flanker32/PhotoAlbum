using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhotoAlbum.Pages;

public class HelloWorldModel : PageModel
{
    public string Message { get; private set; } = string.Empty;

    public void OnGet()
    {
        Message = "Hello World";
    }
}
