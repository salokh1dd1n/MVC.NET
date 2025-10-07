using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(string name, int id = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {id}");
    }
}