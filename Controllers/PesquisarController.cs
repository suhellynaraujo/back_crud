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
    public class PesquisarController : Controller
    {
        private readonly Context _context;

        public PesquisarController(Context context)
        {
            _context = context;
        }

        // GET: Pesquisar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pesquisar.ToListAsync());
        }

        // GET: Pesquisar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesquisar = await _context.Pesquisar
                .FirstOrDefaultAsync(m => m.Id_Pesquisar == id);
            if (pesquisar == null)
            {
                return NotFound();
            }

            return View(pesquisar);
        }

        // GET: Pesquisar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pesquisar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Pesquisar,Nome_Destino,Ida,Volta,Id_Destino")] Pesquisar pesquisar)
        {
           
                _context.Add(pesquisar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
        }

        // GET: Pesquisar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesquisar = await _context.Pesquisar.FindAsync(id);
            if (pesquisar == null)
            {
                return NotFound();
            }
            return View(pesquisar);
        }

        // POST: Pesquisar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Pesquisar,Nome_Destino,Ida,Volta,Id_Destino")] Pesquisar pesquisar)
        {
            if (id != pesquisar.Id_Pesquisar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pesquisar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PesquisarExists(pesquisar.Id_Pesquisar))
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
            return View(pesquisar);
        }

        // GET: Pesquisar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesquisar = await _context.Pesquisar
                .FirstOrDefaultAsync(m => m.Id_Pesquisar == id);
            if (pesquisar == null)
            {
                return NotFound();
            }

            return View(pesquisar);
        }

        // POST: Pesquisar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pesquisar = await _context.Pesquisar.FindAsync(id);
            _context.Pesquisar.Remove(pesquisar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PesquisarExists(int id)
        {
            return _context.Pesquisar.Any(e => e.Id_Pesquisar == id);
        }
    }
}
