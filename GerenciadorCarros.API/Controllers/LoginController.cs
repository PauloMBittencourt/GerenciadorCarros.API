using GerenciadorCarros.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorCarros.API.Controllers
{
    public class LoginController : Controller
    {
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
                    if(login.Email == "adm@adm" && login.Password == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Tente novamente";
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
    }
}
