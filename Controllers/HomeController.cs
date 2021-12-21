using back_crud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace back_crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();

        }      


        public IActionResult Entrar()
        {
           
            return View();
        }

       

        public IActionResult Cadastro()
        {

            return View();
          
            
        }
        

        public IActionResult Pesquisar()
        {

            
            return View();

        }
       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}