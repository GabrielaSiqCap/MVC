using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Gabriela Siqueira Caputti", "gabriela.caputti@portalsesisp.org.br", 4449);
            Aluno a2 = new Aluno(2, "Livia Modesto Ormeleze", "livia.ormeleze@portalsesisp.org.br", 4820);
            Aluno a3 = new Aluno(3, "Ana Clara de Souza", "ana.c.souza94@portalsesisp.org.br", 4143);
            Aluno a4 = new Aluno(4, "Maria Elizabete Gomes", "maria.e.gomes@portalsesisp.org.br", 4442);
            Aluno a5 = new Aluno(5, "Antônio Silva de Oliveira", "antonio.oliv@portalsesisp.org.br", 4548);

            // Criar uma lista de Alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //Adicionar os Objetos ALunos na Lista Alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            //Enviando a lista de Alunos por parâmetro na View Index
            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
