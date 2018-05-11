using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Presentation.MVC.Controllers
{
    public class PedidoController : Controller
    {
        private IPedidoApplication Application;
        private IClienteApplication ClienteApplication;
        private IProdutoApplication ProdutoApplication;

        public PedidoController(IPedidoApplication application, IClienteApplication clienteApplication, IProdutoApplication produtoApplication)
        {
            Application = application;
            ClienteApplication = clienteApplication;
            ProdutoApplication = produtoApplication;
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
                return View(new List<PedidoDTO>());
            }
        }

        public ActionResult Cadastro()
        {
            ViewBag.Clientes = ClienteApplication.GetAll();
            ViewBag.Produtos = ProdutoApplication.GetAll();

            return View(new PedidoDTO());
        }

        [HttpPost]
        public ActionResult Cadastro(PedidoDTO pedido)
        {
            try
            {
                ViewBag.Clientes = ClienteApplication.GetAll();
                ViewBag.Produtos = ProdutoApplication.GetAll();

                if (ModelState.IsValid)
                {
                    Application.Add(pedido);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(pedido);
                }
            }
            catch (Exception exc)
            {
                ViewBag.Message = exc.Message;
                return View(pedido);
            }
        }
    }
}