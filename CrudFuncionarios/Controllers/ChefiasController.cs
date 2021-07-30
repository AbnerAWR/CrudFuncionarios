using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudFuncionarios.Models.Context;
using CrudFuncionarios.Models.Entity;
using X.PagedList;

namespace CrudFuncionarios.Controllers
{
    public class ChefiasController : Controller
    {
        private readonly Context _context;

        public ChefiasController(Context context)
        {
            _context = context;
        }

        // GET: Chefias
        public IActionResult Index(int pagina = 1)
        {
            var context = _context.Chefia.OrderBy(f => f.Id).ToPagedList(pagina, 10);
            return View(context);
        }

        // GET: Chefias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chefia = await _context.Chefia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chefia == null)
            {
                return NotFound();
            }

            return View(chefia);
        }

        // GET: Chefias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chefias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Chefia chefia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chefia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chefia);
        }

        // GET: Chefias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chefia = await _context.Chefia.FindAsync(id);
            if (chefia == null)
            {
                return NotFound();
            }
            return View(chefia);
        }

        // POST: Chefias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Chefia chefia)
        {
            if (id != chefia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chefia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChefiaExists(chefia.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(chefia);
        }

        // GET: Chefias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chefia = await _context.Chefia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chefia == null)
            {
                return NotFound();
            }

            return View(chefia);
        }

        // POST: Chefias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var chefia = await _context.Chefia.FindAsync(id);
                _context.Chefia.Remove(chefia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(ErrorDelete));

                throw;
            }
            
                       
        }

        private bool ChefiaExists(int id)
        {
            return _context.Chefia.Any(e => e.Id == id);
        }

        public IActionResult ErrorDelete()
        { 
            return View();
        }


    }
}
