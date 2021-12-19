using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Markit.Data;
using Markit.Models;


namespace Markit.Controllers
{
    public class MarkitsController : Controller
    {
        private readonly MarkitContext _context;

        public MarkitsController(MarkitContext context)
        {
            _context = context;
        }

        // GET: Markits
        public async Task<IActionResult> Index(string authorTop, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = (IQueryable<string>)(from m in _context.Markit
                                            orderby m.AuthorTopTenViewModel.Tops
                                            select m.AuthorTopTenViewModel.Tops);

            var markits = from m in _context.Markit
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                markits = markits.Where(s => s.Author.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(authorTop))
            {
                markits = markits.Where(x => x.Tops == authorTop);
            }

            var authorTopVM = new AuthorTopTenViewModel
            {
                Tops = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Markits = await markits.ToListAsync()
            };

            return View(authorTopVM);
        }

        // GET: Markits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var markit = await _context.Markit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (markit == null)
            {
                return NotFound();
            }

            return View(markit);
        }

        // GET: Markits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Markits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Author,ReleaseDate,Text")] Markit markit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(markit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(markit);
        }

        // GET: Markits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var markit = await _context.Markit.FindAsync(id);
            if (markit == null)
            {
                return NotFound();
            }
            return View(markit);
        }

        // POST: Markits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Author,ReleaseDate,Text")] Markit markit)
        {
            if (id != markit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(markit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkitExists(markit.Id))
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
            return View(markit);
        }

        // GET: Markits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var markit = await _context.Markit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (markit == null)
            {
                return NotFound();
            }

            return View(markit);
        }

        // POST: Markits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var markit = await _context.Markit.FindAsync(id);
            _context.Markit.Remove(markit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkitExists(int id)
        {
            return _context.Markit.Any(e => e.Id == id);
        }
    }
}
