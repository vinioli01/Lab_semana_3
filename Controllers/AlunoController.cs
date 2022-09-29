using Microsoft.AspNetCore.Mvc;
using lab.Models;

namespace lab.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno aluno = new Aluno();
            aluno.CriarAluno();

            return View(aluno.BuscarAluno());
        }
    }
}