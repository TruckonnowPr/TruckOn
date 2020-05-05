using Microsoft.AspNetCore.Mvc;
using System;
using WebDispacher.Service;

namespace WebDispacher.Controellers
{
    public class ContactsController : Controller
    {
        ManagerDispatch managerDispatch = new ManagerDispatch();

        [Route("Contact/Contacts")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult Contacts(int page)
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "NavBaseCommpany";
            try
            {
                string key = null;
                string idCompany = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key) && Request.Cookies.TryGetValue("CommpanyId", out idCompany))
                {
                    ViewBag.Contacts = managerDispatch.GetContacts(idCompany);
                    actionResult = View("FullContacts");
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
            catch (Exception)
            {

            }
            return actionResult;
        }


        [HttpGet]
        [Route("Contact/CreateContact")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult CreateContact()
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "NavBaseCommpany";
            try
            {
                string key = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    actionResult = View("CreateContact");
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
            catch (Exception)
            {

            }
            return actionResult;
        }

        [HttpPost]
        [Route("Contact/CreateContact")]
        public IActionResult CreateDriver(string fullName, string emailAddress, string phoneNumbe)
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "NavBaseCommpany";
            try
            {
                string key = null;
                string idCompany = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key) && Request.Cookies.TryGetValue("CommpanyId", out idCompany))
                {
                    if ((fullName != null && fullName != "") && (emailAddress != null && emailAddress != "") && (emailAddress != null && emailAddress != "")
                       && (fullName != null && fullName != ""))
                    {
                        managerDispatch.CreateContact(fullName, emailAddress, phoneNumbe, idCompany);
                        actionResult = Redirect($"{Config.BaseReqvesteUrl}/Contact/Contacts");
                    }
                    else
                    {
                        actionResult = View("CreateContact");
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
            catch (Exception)
            {

            }
            return actionResult;
        }
    }
}