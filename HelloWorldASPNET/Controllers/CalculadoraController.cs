using Microsoft.AspNetCore.Mvc;

namespace HelloWorldASPNET.Controllers
{
    public class CalculadoraController : Controller
    {
        
        
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Calcular(int number1, int number2)
        {
            ViewBag.Resultado = number1 + number2;

            return View();
        }
    }
}
