using System;
using System.Collections.Generic;
using iTextSharp.text;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using WebDispacher.Mosels;
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
        public IActionResult PaymentMethod()
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
                    List<PaymentMethod> paymentMethods = managerDispatch.GetpaymentMethod(idCompany);
                    ViewBag.PaymentMethods = paymentMethods;
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

        [HttpGet]
        [Route("AddPaymentMethod")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult AddPaymentMethod()
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
                    ViewBag.TxtError = "";
                    ViewBag.Numbercard = "";
                    ViewBag.FullName = "";
                    ViewBag.Expire = "";
                    ViewBag.Cvv = "";
                    actionResult = View("~/Views/Settings/Biling/AddPaymentMethod.cshtml");
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

        [HttpPost]
        [Route("AddPaymentMethod")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult AddPaymentMethod(string number, string name, string expiry, string cvc)
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
                    ResponseStripe responseStripe =  managerDispatch.AddPaymentCard(idCompany, number, name, expiry, cvc);
                    if(responseStripe.IsError)
                    {
                        ViewBag.TxtError = responseStripe.Message;
                        ViewBag.Numbercard = number;
                        ViewBag.FullName = name;
                        ViewBag.Expire = expiry;
                        ViewBag.Cvv = cvc;
                        actionResult = View("~/Views/Settings/Biling/AddPaymentMethod.cshtml");
                    }
                    else
                    {
                        actionResult = Redirect($"{Config.BaseReqvesteUrl}/Settings/Biling/PaymentMethod");
                    }
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
