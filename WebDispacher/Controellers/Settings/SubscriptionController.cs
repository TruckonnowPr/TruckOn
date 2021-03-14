using Microsoft.AspNetCore.Mvc;
using System;
using WebDispacher.Models.Subscription;
using WebDispacher.Service;

namespace WebDispacher.Controellers.Settings
{
    [Route("Settings/Subscription")]
    public class SubscriptionController : Controller
    {
        ManagerDispatch managerDispatch = new ManagerDispatch();

        [Route("Subscriptions")]
        public IActionResult GetSubscription()
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
                    ViewData["TypeNavBar"] = managerDispatch.GetTypeNavBar(key, idCompany, "Settings");
                    SubscriptionCompanyDTO subscriptionCompanyDTO = managerDispatch.GetSubscription(idCompany);
                    ViewBag.Subscription = subscriptionCompanyDTO;
                    actionResult = View("~/Views/Settings/Subscription/Subscription.cshtml");
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
