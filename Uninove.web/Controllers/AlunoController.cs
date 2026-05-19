using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class AlunoController : Controller
    {
        // Acessível via /Aluno
        public IActionResult Index()
        {
            ViewBag.Nome = "Ana Silva";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View();
        }

        // Acessível via /Aluno/Detalhes/1
        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            ViewBag.Nome = "Ana Silva";
            ViewBag.RA = "12345678";
            
            return View();
        }
    }
}
