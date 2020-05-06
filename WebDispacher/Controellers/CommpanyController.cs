using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebDispacher.Service;

namespace WebDispacher.Controellers
{
    [Route("Company")]
    public class CommpanyController : Controller
    {
        ManagerDispatch managerDispatch = new ManagerDispatch();

        [HttpGet]
        [Route("Companies")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult GetCompanies()
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "BaseCommpany";
            try
            {
                string key = null;
                string idCompany = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    ViewBag.Companies = managerDispatch.GetCompanies();
                    actionResult = View("Companies");
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
        [Route("CreateCompany")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult CreateCompany()
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "BaseCommpany";
            try
            {
                string key = null;
                string idCompany = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    actionResult = View("CreateCommpany");
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
        [Route("CreateCompany")]
        public IActionResult CreateCompany(string nameCommpany, List<IFormFile> MCNumberConfirmation, IFormFile IFTA, IFormFile KYU, IFormFile logbookPapers, IFormFile COI, 
            IFormFile permits)
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "BaseCommpany";
            try
            {
                string key = null;
                string idCompany = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    managerDispatch.AddCommpany(nameCommpany, MCNumberConfirmation[0], IFTA, KYU, logbookPapers, COI, permits);
                    actionResult = Redirect($"{Config.BaseReqvesteUrl}/Company/Companies");
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

        [Route("Remove")]
        public IActionResult RemoveCompany(string id)
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "BaseCommpany";
            try
            {
                string key = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    managerDispatch.RemoveCompany(id);
                    actionResult = Redirect($"{Config.BaseReqvesteUrl}/Company/Companies");
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

        [Route("Doc")]
        public async Task<IActionResult> GoToViewCompanykDoc(string id)
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "BaseCommpany";
            try
            {
                string key = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    ViewBag.CompanyDoc = await managerDispatch.GetCompanyDoc(id);
                    ViewBag.CompanyId = id;
                    actionResult = View($"CompanyDocuments");
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

        [Route("SaveDoc")]
        public void SaveDoc(IFormFile uploadedFile, string nameDoc, string id)
        {
            try
            {
                string key = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    managerDispatch.SaveDocCpmmpany(uploadedFile, nameDoc, id);
                }
                else
                {
                    if (Request.Cookies.ContainsKey("KeyAvtho"))
                    {
                        Response.Cookies.Delete("KeyAvtho");
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        [Route("RemoveDoc")]
        public IActionResult RemoveDoc(string idDock, string id)
        {
            IActionResult actionResult = null;
            ViewData["TypeNavBar"] = "BaseCommpany";
            try
            {
                string key = null;
                ViewBag.BaseUrl = Config.BaseReqvesteUrl;
                Request.Cookies.TryGetValue("KeyAvtho", out key);
                if (managerDispatch.CheckKey(key))
                {
                    managerDispatch.RemoveDocCompany(idDock);
                    actionResult = Redirect($"{Config.BaseReqvesteUrl}/Company/Doc?id={id}");
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

        [Route("GetDock")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult GetDock(string docPath, string type)
        {
            IActionResult actionResult = null;
            var imageFileStream = System.IO.File.OpenRead(docPath);
            actionResult = File(imageFileStream, type);
            return actionResult;
        }

        [Route("GetDockPDF")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
        public IActionResult GetDockPDF(string docPath)
        {
            IActionResult actionResult = null;
            var imageFileStream = System.IO.File.OpenRead(docPath);
            actionResult = File(imageFileStream, "application/pdf");
            return actionResult;
        }
    }
}