using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PM2HAHA.Models;

namespace PM2HAHA.Controllers
{
    public class MstRsisController : Controller
    {
        private readonly test_dbContext _context;

        public MstRsisController(test_dbContext context)
        {
            _context = context;
        }

        // GET: MstRsis
        public async Task<IActionResult> Index()
        {
            return View(await _context.MstRsis.ToListAsync());
        }

        // GET: MstRsis/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstRsi = await _context.MstRsis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstRsi == null)
            {
                return NotFound();
            }

            return View(mstRsi);
        }

        // GET: MstRsis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MstRsis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,period,higilevel,lowlevel,usercreate,CreateAt,UploadAt")] MstRsi mstRsi)
        {
            if (ModelState.IsValid)
            {
                mstRsi.Id = Guid.NewGuid();
                _context.Add(mstRsi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mstRsi);
        }

        // GET: MstRsis/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstRsi = await _context.MstRsis.FindAsync(id);
            if (mstRsi == null)
            {
                return NotFound();
            }
            return View(mstRsi);
        }

        // POST: MstRsis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,period,higilevel,lowlevel,usercreate,CreateAt,UploadAt")] MstRsi mstRsi)
        {
            if (id != mstRsi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mstRsi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MstRsiExists(mstRsi.Id))
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
            return View(mstRsi);
        }

        // GET: MstRsis/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstRsi = await _context.MstRsis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstRsi == null)
            {
                return NotFound();
            }

            return View(mstRsi);
        }

        // POST: MstRsis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var mstRsi = await _context.MstRsis.FindAsync(id);
            _context.MstRsis.Remove(mstRsi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MstRsiExists(Guid id)
        {
            return _context.MstRsis.Any(e => e.Id == id);
        }
    }
}
