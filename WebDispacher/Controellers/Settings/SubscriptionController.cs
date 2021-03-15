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
        public IActionResult GetSubscription(string errorText)
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Subscription"))
                {
                    ViewData["TypeNavBar"] = managerDispatch.GetTypeNavBar(key, idCompany, "Settings");
                    ViewData["TextErrorSub"] = errorText;
                    ViewBag.Subscription = managerDispatch.GetSubscription(idCompany);
                    ViewBag.SubscriptionNext = managerDispatch.GetSubscriptionNext(idCompany);
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

        [Route("All")]
        public IActionResult GetSubscriptions()
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Subscription"))
                {
                    ViewData["TypeNavBar"] = managerDispatch.GetTypeNavBar(key, idCompany, "Settings");
                    ViewBag.Subscriptions = managerDispatch.GetSubscriptions();
                    actionResult = View("~/Views/Settings/Subscription/AllSubscriptions.cshtml");
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

        [Route("Select")]
        public IActionResult SelectSubscriptions(string idPrice, string priodDays)
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Subscription"))
                {
                    ViewData["TypeNavBar"] = managerDispatch.GetTypeNavBar(key, idCompany, "Settings");
                    string errorText = managerDispatch.SelectSub(idPrice, idCompany, priodDays);
                    actionResult = Redirect($"~/Settings/Subscription/Subscriptions?errorText={errorText.Replace("customer", "Company")}");
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

        [Route("CancelNext")]
        public IActionResult CancelSubscriptionsNext()
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Subscription"))
                {
                    ViewData["TypeNavBar"] = managerDispatch.GetTypeNavBar(key, idCompany, "Settings");
                    managerDispatch.CancelSubscriptionsNext(idCompany);
                    actionResult = Redirect("~/Settings/Subscription/Subscriptions");
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
