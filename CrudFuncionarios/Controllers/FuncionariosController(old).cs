using CrudFuncionarios.Models.Context;
using CrudFuncionarios.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudFuncionarios.Controllers
{
    public class FuncionariosControllerOld : Controller
    {

        private readonly Context _context;
        public FuncionariosControllerOld(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lista = _context.Funcionarios.ToList();
            CarregaTipoFuncionario();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var funcionarios = new Funcionarios();
            CarregaTipoFuncionario();
            return View(funcionarios);
        }

        [HttpPost]
        public IActionResult Create(Funcionarios funcionarios)
        {
            if (ModelState.IsValid)
            {
                _context.Funcionarios.Add(funcionarios);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            CarregaTipoFuncionario();
            return View(funcionarios);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var funcionarios = _context.Funcionarios.Find(Id);

            CarregaTipoFuncionario();
            return View(funcionarios);
        }

        [HttpPost]
        public IActionResult Edit(Funcionarios funcionario)
        {
            if(ModelState.IsValid)
            {
                _context.Funcionarios.Update(funcionario);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                CarregaTipoFuncionario();
                return View(funcionario);
            }
        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var funcionarios = _context.Funcionarios.Find(Id);
            CarregaTipoFuncionario();
            return View(funcionarios);
        }

        [HttpPost]
        public IActionResult Delete(Funcionarios _funcionarios)
        {
            var funcionarios = _context.Funcionarios.Find(_funcionarios.Id);
            if (funcionarios != null)
            {
                _context.Funcionarios.Remove(funcionarios);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(funcionarios);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var funcionarios = _context.Funcionarios.Find(Id);
            CarregaTipoFuncionario();
            return View(funcionarios);
        }

        public void CarregaTipoFuncionario()
        {
            var ItensTipoFuncionario = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "Adminstrador"},
                new SelectListItem{ Value = "2", Text = "Tecnico"},
                new SelectListItem{ Value = "3", Text = "Usuario comum"}
            };

            ViewBag.TipoFuncionarios = ItensTipoFuncionario;
        }


    }
}
