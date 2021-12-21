#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using back_crud.Models;

namespace back_crud.Controllers
{
    public class EntrarController : Controller
    {
        private readonly Context _context;

        public EntrarController(Context context)
        {
            _context = context;
        }

        // GET: Entrar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entrar.ToListAsync());
        }

        // GET: Entrar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrar = await _context.Entrar
                .FirstOrDefaultAsync(m => m.Id_Entrar == id);
            if (entrar == null)
            {
                return NotFound();
            }

            return View(entrar);
        }

        // GET: Entrar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entrar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Entrar,Email,Senha,Id_Cadastro")] Entrar entrar)
        {
           
                _context.Add(entrar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
        }

        // GET: Entrar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrar = await _context.Entrar.FindAsync(id);
            if (entrar == null)
            {
                return NotFound();
            }
            return View(entrar);
        }

        // POST: Entrar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Entrar,Email,Senha,Id_Cadastro")] Entrar entrar)
        {
            if (id != entrar.Id_Entrar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entrar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntrarExists(entrar.Id_Entrar))
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
            return View(entrar);
        }

        // GET: Entrar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrar = await _context.Entrar
                .FirstOrDefaultAsync(m => m.Id_Entrar == id);
            if (entrar == null)
            {
                return NotFound();
            }

            return View(entrar);
        }

        // POST: Entrar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entrar = await _context.Entrar.FindAsync(id);
            _context.Entrar.Remove(entrar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntrarExists(int id)
        {
            return _context.Entrar.Any(e => e.Id_Entrar == id);
        }
    }
}
