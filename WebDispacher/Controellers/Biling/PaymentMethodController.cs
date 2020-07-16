using System;
using Microsoft.AspNetCore.Mvc;
using WebDispacher.Service;

namespace WebDispacher.Controellers.Biling
{
    [Route("Settings/Biling")]
    public class PaymentMethodController : Controller
    {
        ManagerDispatch managerDispatch = new ManagerDispatch();

        [HttpGet]
        [Route("PaymentMethod")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult GetCompanies()
        {
            IActionResult actionResult = null;
            try
            {
                string key = null;
                string idCompany = null;
                string companyName = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                Request.Cookies.TryGetValue("CommpanyId", out idCompany);
                Request.Cookies.TryGetValue("CommpanyName", out companyName);
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "PaymentMethod"))
                {
                    ViewBag.NameCompany = companyName;
                    ViewData["TypeNavBar"] = "Settings"; //managerDispatch.GetTypeNavBar(key, idCompany);
                    actionResult = View("~/Views/Settings/Biling/PaymentMethod.cshtml");
                }
                else
                {
                    if (Request.Cookies.ContainsKey("KeyAvtho"))
                    {
                        Response.Cookies.Delete("KeyAvtho");
                    }
                    actionResult = Redirect(Config.BaseReqvesteUrl);
                }
            }
            catch (Exception e)
            {

            }
            return actionResult;
        }
    }
}
