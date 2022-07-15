using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_final_Atos.Data;
using Projeto_final_Atos.Models;

namespace Projeto_final_Atos.Controllers
{
    public class PacoteController : Controller
    {
        private readonly Projeto_final_AtosContext _context;

        public PacoteController(Projeto_final_AtosContext context)
        {
            _context = context;
        }

        // GET: Pacote
        public async Task<IActionResult> Index()
        {
#pragma warning disable CS8604 // Possível argumento de referência nula.
            var projeto_final_AtosContext = _context.Pacote.Include(p => p.Atendimento);
#pragma warning restore CS8604 // Possível argumento de referência nula.
            return View(await projeto_final_AtosContext.ToListAsync());
        }

        // GET: Pacote/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pacote == null)
            {
                return NotFound();
            }

            var pacote = await _context.Pacote
                .Include(p => p.Atendimento)
                .FirstOrDefaultAsync(m => m.idPacotes == id);
            if (pacote == null)
            {
                return NotFound();
            }

            return View(pacote);
        }

        // GET: Pacote/Create
        public IActionResult Create()
        {
            ViewData["idAtendimento"] = new SelectList(_context.Atendimento, "IdAtendimento", "IdAtendimento");
            return View();
        }

        // POST: Pacote/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPacotes,idAtendimento,nome,origem,destino,saida,retorno,preco")] Pacote pacote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pacote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idAtendimento"] = new SelectList(_context.Atendimento, "IdAtendimento", "IdAtendimento", pacote.idAtendimento);
            return View(pacote);
        }

        // GET: Pacote/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pacote == null)
            {
                return NotFound();
            }

            var pacote = await _context.Pacote.FindAsync(id);
            if (pacote == null)
            {
                return NotFound();
            }
            ViewData["idAtendimento"] = new SelectList(_context.Atendimento, "IdAtendimento", "IdAtendimento", pacote.idAtendimento);
            return View(pacote);
        }

        // POST: Pacote/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idPacotes,idAtendimento,nome,origem,destino,saida,retorno,preco")] Pacote pacote)
        {
            if (id != pacote.idPacotes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pacote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacoteExists(pacote.idPacotes))
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
            ViewData["idAtendimento"] = new SelectList(_context.Atendimento, "IdAtendimento", "IdAtendimento", pacote.idAtendimento);
            return View(pacote);
        }

        // GET: Pacote/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pacote == null)
            {
                return NotFound();
            }

            var pacote = await _context.Pacote
                .Include(p => p.Atendimento)
                .FirstOrDefaultAsync(m => m.idPacotes == id);
            if (pacote == null)
            {
                return NotFound();
            }

            return View(pacote);
        }

        // POST: Pacote/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pacote == null)
            {
                return Problem("Entity set 'Projeto_final_AtosContext.Pacote'  is null.");
            }
            var pacote = await _context.Pacote.FindAsync(id);
            if (pacote != null)
            {
                _context.Pacote.Remove(pacote);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacoteExists(int id)
        {
          return (_context.Pacote?.Any(e => e.idPacotes == id)).GetValueOrDefault();
        }
    }
}
