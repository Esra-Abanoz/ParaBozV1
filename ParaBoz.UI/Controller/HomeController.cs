using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace ParaBoz.UI.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return new JsonObject;
        }
    }
}
