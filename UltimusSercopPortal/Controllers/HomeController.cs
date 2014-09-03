using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ULAPW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string BLUP, string Aplicacion)
        { 
            
            if (BLUP != null && Aplicacion =="MA")
            {
                var flag = Convert.ToBoolean(ConfigurationManager.AppSettings["FlagUltimusLogin"]);
                var ip = Request.UserHostAddress;
                
                if (IsTokenValido(BLUP, ip) )
                    return View("Initiate");
                else
                {
                    if (!flag)
                        return Redirect("http://192.168.9.212/easywebacceso/EasyLogin/wfLogin.aspx");
                    else
                        return RedirectToAction("Login");
                }
            }
            else
            {
                return View("Login");
            }
        }


        //public ActionResult Index(string user, string token, string ruc = "")
        //{
        //    if (user != null && token != null)
        //    {
        //        var flag = Convert.ToBoolean(ConfigurationManager.AppSettings["FlagUltimusLogin"]);

        //        if (IsTokenValido(token))
        //            return View("Initiate");
        //        else
        //        {
        //            if (!flag)
        //                return Redirect("http://192.168.9.212/easywebacceso/EasyLogin/wfLogin.aspx");
        //            else
        //                return RedirectToAction("Login");
        //        }
        //    }
        //    else
        //    {
        //        return View("Login");
        //    }
        //}

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Initiate(bool userLoged = false)
        {
            if (userLoged)
                return View();
             else
                return RedirectToAction("Login");
        }

        private bool IsTokenValido(string token, string ip)
        {
            var svc = new ULAPW.ServiceEasyLogin.WSEasyLoginSoapClient();
            //var ip = Request.UserHostAddress; 
            var resp = svc.VerificaToken(token, "MA", ip);
            if (resp == "ERROR" || resp == "TOKEN_NO_VALIDO" || resp == "TOKEN_EXPIRADO" || resp == "IP_INCORRECTA")
                return false;
            else
            {
                //userLoged = true;
                ViewBag.Resultado = resp;
                return true;
            }
            //return true;
        }

        public ActionResult Redirige()
        {
            return View();
        }
    }
}