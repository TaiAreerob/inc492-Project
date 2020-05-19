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
    public class MstDataRawsController : Controller
    {
        private readonly test_dbContext _context;

        public MstDataRawsController(test_dbContext context)
        {
            _context = context;
        }

        // GET: MstDataRaws
        public async Task<IActionResult> Index()
        {
            return View(await _context.MstDataRaws.ToListAsync());
        }

        // GET: MstDataRaws/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstDataRaw = await _context.MstDataRaws
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstDataRaw == null)
            {
                return NotFound();
            }

            return View(mstDataRaw);
        }

        // GET: MstDataRaws/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MstDataRaws/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Aqi,Idx,City,Longitude,Latitude,Co,H,No2,O3,P,Pm10,Pm25,So2,T,W,time,CreateAt,UploadAt")] MstDataRaw mstDataRaw)
        {
            if (ModelState.IsValid)
            {
                mstDataRaw.Id = Guid.NewGuid();
                _context.Add(mstDataRaw);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(mstDataRaw);
        }

        // GET: MstDataRaws/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstDataRaw = await _context.MstDataRaws.FindAsync(id);
            if (mstDataRaw == null)
            {
                return NotFound();
            }
            return View(mstDataRaw);
        }

        // POST: MstDataRaws/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Aqi,Idx,City,Longitude,Latitude,Co,H,No2,O3,P,Pm10,Pm25,So2,T,W,time,CreateAt,UploadAt")] MstDataRaw mstDataRaw)
        {
            if (id != mstDataRaw.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mstDataRaw);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MstDataRawExists(mstDataRaw.Id))
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
            return View(mstDataRaw);
        }

        // GET: MstDataRaws/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstDataRaw = await _context.MstDataRaws
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mstDataRaw == null)
            {
                return NotFound();
            }

            return View(mstDataRaw);
        }

        // POST: MstDataRaws/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var mstDataRaw = await _context.MstDataRaws.FindAsync(id);
            _context.MstDataRaws.Remove(mstDataRaw);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MstDataRawExists(Guid id)
        {
            return _context.MstDataRaws.Any(e => e.Id == id);
        }
    }
}
