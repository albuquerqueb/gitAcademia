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
    public class AtendimentoController : Controller
    {
        private readonly Projeto_final_AtosContext _context;

        public AtendimentoController(Projeto_final_AtosContext context)
        {
            _context = context;
        }

        // GET: Atendimento
        public async Task<IActionResult> Index()
        {
#pragma warning disable CS8604 // Possível argumento de referência nula.
            var Projeto_final_AtosContext = _context.Atendimento.Include(a => a.Usuario);
#pragma warning restore CS8604 // Possível argumento de referência nula.
            return View(await Projeto_final_AtosContext.ToListAsync());
        }

        // GET: Atendimento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Atendimento == null)
            {
                return NotFound();
            }

            var atendimento = await _context.Atendimento
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.IdAtendimento == id);
            if (atendimento == null)
            {
                return NotFound();
            }

            return View(atendimento);
        }

        // GET: Atendimento/Create
        public IActionResult Create()
        {
            ViewData["idUsuario"] = new SelectList(_context.Usuario, "idUsuario", "data_nascimento");
            return View();
        }

        // POST: Atendimento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAtendimento,idUsuario,nome,email,duvida")] Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atendimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idUsuario"] = new SelectList(_context.Usuario, "idUsuario", "data_nascimento", atendimento.idUsuario);
            return View(atendimento);
        }

        // GET: Atendimento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Atendimento == null)
            {
                return NotFound();
            }

            var atendimento = await _context.Atendimento.FindAsync(id);
            if (atendimento == null)
            {
                return NotFound();
            }
            ViewData["idUsuario"] = new SelectList(_context.Usuario, "idUsuario", "data_nascimento", atendimento.idUsuario);
            return View(atendimento);
        }

        // POST: Atendimento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAtendimento,idUsuario,nome,email,duvida")] Atendimento atendimento)
        {
            if (id != atendimento.IdAtendimento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atendimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtendimentoExists(atendimento.IdAtendimento))
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
            ViewData["idUsuario"] = new SelectList(_context.Usuario, "idUsuario", "data_nascimento", atendimento.idUsuario);
            return View(atendimento);
        }

        // GET: Atendimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Atendimento == null)
            {
                return NotFound();
            }

            var atendimento = await _context.Atendimento
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.IdAtendimento == id);
            if (atendimento == null)
            {
                return NotFound();
            }

            return View(atendimento);
        }

        // POST: Atendimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Atendimento == null)
            {
                return Problem("Entity set 'Projeto_final_AtosContext.Atendimento'  is null.");
            }
            var atendimento = await _context.Atendimento.FindAsync(id);
            if (atendimento != null)
            {
                _context.Atendimento.Remove(atendimento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtendimentoExists(int id)
        {
          return (_context.Atendimento?.Any(e => e.IdAtendimento == id)).GetValueOrDefault();
        }
    }
}
