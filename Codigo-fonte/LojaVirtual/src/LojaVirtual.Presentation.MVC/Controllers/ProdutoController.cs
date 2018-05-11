using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Presentation.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoApplication Application;

        public ProdutoController(IProdutoApplication application)
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
                ViewBag.Message = exc.Message + "\n" + exc.InnerException;
                return View(new List<ProdutoDTO>());
            }
        }

        public ActionResult Cadastro()
        {
            return View(new ProdutoDTO());
        }

        [HttpPost]
        public ActionResult Cadastro(ProdutoDTO produto)
        {
            try
            {
                Application.Add(produto);
                return RedirectToAction("Index");
            }
            catch (Exception exc)
            {
                ViewBag.Message = exc.Message;
                return View(produto);
            }
        }
    }
}