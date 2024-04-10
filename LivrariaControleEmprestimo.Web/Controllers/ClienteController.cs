using LivrariaControleEmprestimo.Data.Models;
using LivrariaControleEmprestimo.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.Web.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }
    }
}
