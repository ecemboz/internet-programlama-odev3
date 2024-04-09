using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models.Domain;

namespace WebApplication2.Controllers
{
    public class TblAlbumsController : Controller
    {
        private readonly DemoDbContext _context;

        public TblAlbumsController(DemoDbContext context)
        {
            _context = context;
        }

        // GET: TblAlbums
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tbl_Album2.ToListAsync());
        }

        // GET: TblAlbums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblAlbum = await _context.Tbl_Album2
                .FirstOrDefaultAsync(m => m.Album_Id == id);
            if (tblAlbum == null)
            {
                return NotFound();
            }

            return View(tblAlbum);
        }

        // GET: TblAlbums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblAlbums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Album_Id,Album_No,Album_Tur,Sanatci_Bilgi,Album_Ad,Album_Fiyat,Yerli,Menajer_Bilgi")] TblAlbum tblAlbum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblAlbum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblAlbum);
        }

        // GET: TblAlbums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblAlbum = await _context.Tbl_Album2.FindAsync(id);
            if (tblAlbum == null)
            {
                return NotFound();
            }
            return View(tblAlbum);
        }

        // POST: TblAlbums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Album_Id,Album_No,Album_Tur,Sanatci_Bilgi,Album_Ad,Album_Fiyat,Yerli,Menajer_Bilgi")] TblAlbum tblAlbum)
        {
            if (id != tblAlbum.Album_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblAlbum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblAlbumExists(tblAlbum.Album_Id))
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
            return View(tblAlbum);
        }

        // GET: TblAlbums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblAlbum = await _context.Tbl_Album2
                .FirstOrDefaultAsync(m => m.Album_Id == id);
            if (tblAlbum == null)
            {
                return NotFound();
            }

            return View(tblAlbum);
        }

        // POST: TblAlbums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblAlbum = await _context.Tbl_Album2.FindAsync(id);
            if (tblAlbum != null)
            {
                _context.Tbl_Album2.Remove(tblAlbum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblAlbumExists(int id)
        {
            return _context.Tbl_Album2.Any(e => e.Album_Id == id);
        }
    }
}
