using Microsoft.AspNetCore.Mvc;
using System;
using WebDispacher.Service;

namespace WebDispacher.Controellers.Settings
{
    [Route("Settings/Truck")]
    public class TruckSController : Controller
    {
        ManagerDispatch managerDispatch = new ManagerDispatch();

        [Route("Users")]
        //[ResponseCache(Location = ResponseCacheLocation.None, Duration = 300)]
        public IActionResult GetUsers()
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Truck"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    ViewBag.Users = managerDispatch.GetUsers(Convert.ToInt32(idCompany));
                    actionResult = View("~/Views/Settings/TruckSettings.cshtml");
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