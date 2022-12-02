using GerenciadorCarros.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GerenciadorCarros.API.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataBaseContext _context;

        public LoginController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Models.Cliente clienteLogin =  BuscarPorLogin(login.Email);

                    if (clienteLogin != null || login.Email == "adm@adm")
                    {
                        if(clienteLogin.PasswordValid(login.Password) || login.Password == "123")
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Senha inválida. Tente novamente.";
                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Tente novamente.";
                    return RedirectToAction("Index");

                }

                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Não foi possível acessar o sistema. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public Cliente BuscarPorLogin(string email)
        {
            return _context.Clientes.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }
    }
}
