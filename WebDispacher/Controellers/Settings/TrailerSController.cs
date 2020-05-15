using DaoModels.DAO.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using WebDispacher.Service;

namespace WebDispacher.Controellers.Settings
{
    [Route("Settings/Trailer")]
    public class TrailerSController : Controller
    {
        ManagerDispatch managerDispatch = new ManagerDispatch();

        public IActionResult GetUsers(int idProfile)
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Trailer"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    ViewBag.SelectSetingTrailer = managerDispatch.GetSelectSetingTrailer(idCompany, idProfile);
                    ViewBag.SetingsTrailer = managerDispatch.GetSetingsTrailer(idCompany, idProfile);
                    ViewBag.IdProfile = idProfile;
                    actionResult = View("~/Views/Settings/TrailerSettings.cshtml");
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
        [Route("AddProfile")]
        public IActionResult AddProfile()
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Trailer"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    int id = managerDispatch.AddProfile(idCompany, TypeTransportVehikle.Trailer);
                    actionResult = Redirect($"{Config.BaseReqvesteUrl}/Settings/Trailer?idProfile={id}");
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
        [Route("RemoveProfile")]
        public IActionResult RemoveProfile(int idProfile)
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
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Trailer"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    managerDispatch.RemoveProfile(idCompany, idProfile);
                    actionResult = Redirect($"{Config.BaseReqvesteUrl}/Settings/Trailer?idProfile=0");
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
        [Route("SelectLayout")]
        public string SelectLayout(int idLayout)
        {
            string actionResult = null;
            try
            {
                string key = null;
                string idCompany = null;
                string companyName = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                Request.Cookies.TryGetValue("CommpanyId", out idCompany);
                Request.Cookies.TryGetValue("CommpanyName", out companyName);
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Trailer"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    managerDispatch.SelectLayout(idLayout);
                    actionResult = "";
                }
                else
                {
                    if (Request.Cookies.ContainsKey("KeyAvtho"))
                    {
                        Response.Cookies.Delete("KeyAvtho");
                    }
                    actionResult = null;
                }
            }
            catch (Exception e)
            {

            }
            return actionResult;
        }

        [HttpPost]
        [Route("UnSelectLayout")]
        public string UnSelectLayout(int idLayout)
        {
            string actionResult = null;
            try
            {
                string key = null;
                string idCompany = null;
                string companyName = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                Request.Cookies.TryGetValue("CommpanyId", out idCompany);
                Request.Cookies.TryGetValue("CommpanyName", out companyName);
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Trailer"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    managerDispatch.UnSelectLayout(idLayout);
                    actionResult = "";
                }
                else
                {
                    if (Request.Cookies.ContainsKey("KeyAvtho"))
                    {
                        Response.Cookies.Delete("KeyAvtho");
                    }
                    actionResult = null;
                }
            }
            catch (Exception e)
            {

            }
            return actionResult;
        }

        [HttpPost]
        [Route("LayoutUP")]
        public string LayoutUP(int idLayout, int idTransported)
        {
            string actionResult = null;
            try
            {
                string key = null;
                string idCompany = null;
                string companyName = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                Request.Cookies.TryGetValue("CommpanyId", out idCompany);
                Request.Cookies.TryGetValue("CommpanyName", out companyName);
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Trailer"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    managerDispatch.LayoutUP(idLayout, idTransported);
                    actionResult = "";
                }
                else
                {
                    if (Request.Cookies.ContainsKey("KeyAvtho"))
                    {
                        Response.Cookies.Delete("KeyAvtho");
                    }
                    actionResult = null;
                }
            }
            catch (Exception e)
            {

            }
            return actionResult;
        }

        [HttpPost]
        [Route("LayoutDown")]
        public string LayoutDown(int idLayout, int idTransported)
        {
            string actionResult = null;
            try
            {
                string key = null;
                string idCompany = null;
                string companyName = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                Request.Cookies.TryGetValue("CommpanyId", out idCompany);
                Request.Cookies.TryGetValue("CommpanyName", out companyName);
                if (managerDispatch.CheckKey(key) && managerDispatch.IsPermission(key, idCompany, "Setings/Trailer"))
                {
                    ViewData["TypeNavBar"] = "Settings";//managerDispatch.GetTypeNavBar(key, idCompany);
                    ViewBag.NameCompany = companyName;
                    managerDispatch.LayoutDown(idLayout, idTransported);
                    actionResult = "";
                }
                else
                {
                    if (Request.Cookies.ContainsKey("KeyAvtho"))
                    {
                        Response.Cookies.Delete("KeyAvtho");
                    }
                    actionResult = null;
                }
            }
            catch (Exception e)
            {

            }
            return actionResult;
        }


        [HttpGet]
        [Route("Image")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult GetShiping(string name, string type)
        {
            if (!name.Contains(type))
            {
                name += "." + type;
            }
            var imageFileStream = System.IO.File.OpenRead(name);
            return File(imageFileStream, $"image/{type}");
        }
    }
}