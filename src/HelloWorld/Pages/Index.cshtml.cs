using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HelloWorld.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    // ✅ Propiedad pública que vamos a testear
    public string Mensaje { get; private set; }

    public void OnGet()
    {
        Mensaje = " Hola Mundo";
    }
}
