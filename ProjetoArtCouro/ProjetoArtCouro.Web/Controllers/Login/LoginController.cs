using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoArtCouro.Web.Controllers.Login
{
    public class LoginController : BaseController
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var tokenModel = ServiceRequest.GetAuthenticationToken(model.UsuarioNome, model.Senha);
            if (tokenModel != null)
            {
                Response.SetAuthCookie(model.UsuarioNome, tokenModel.access_token, tokenModel.roles, false);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("Erro", Erros.InvalidUserOrPassword);
            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}