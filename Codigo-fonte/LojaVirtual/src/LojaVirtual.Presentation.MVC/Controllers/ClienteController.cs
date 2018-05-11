using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Presentation.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteApplication Application;

        public ClienteController(IClienteApplication application)
        {
            Application = application;
        }

        public ActionResult Index()
        {
            try
            {
                return View(Application.GetAll());
            }
            catch (Exception exc)
            {
                ViewBag.Message = exc.Message;
                return View(new List<ClienteDTO>());
            }
        }

        public ActionResult Cadastro()
        {
            return View(new ClienteDTO());
        }

        [HttpPost]
        public ActionResult Cadastro(ClienteDTO cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Application.Add(cliente);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(cliente);
                }
            }
            catch(Exception exc)
            {
                ViewBag.Message = exc.Message;
                return View(cliente);
            }
        }
    }
}