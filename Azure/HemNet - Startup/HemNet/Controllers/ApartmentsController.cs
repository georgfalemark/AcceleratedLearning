using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HemNet.Data;
using HemNet.Models;
using HemNet.Views;

namespace HemNet.Controllers
{
    public class ApartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Apartments
        public async Task<IActionResult> Index(int count)
        {

            var appartmentSortVm = new AppartmentSortVm
            {
                Apartments = await _context.Apartments.OrderBy(x => x.ApartmentNumber).Include(a => a.HousingCooperative).ToListAsync(),
                CurrentSort = count
            };





            int xxx = 0;
            ViewData["y"] = xxx;




            int[] arr1 = new int[] { 1, 2, 3 };
            ViewData["intArr"] = arr1;


            if (count == 1)
                return View(await _context.Apartments.OrderBy(x => x.ApartmentNumber).Include(a => a.HousingCooperative).ToListAsync());
            else if (count == 2)
                return View(await _context.Apartments.OrderByDescending(x => x.Price).Include(a => a.HousingCooperative).ToListAsync());
            else
                return View(await _context.Apartments.OrderBy(x => x.Price).Include(a => a.HousingCooperative).ToListAsync());







            //if (count == 0 || xxx == 0)
            //{
            //    xxx++;
            //    count++;
            //    return View(await _context.Apartments.OrderBy(x => x.ApartmentNumber).Include(a => a.HousingCooperative).ToListAsync());
            //}
            //else if (count == 1 || xxx == 1)
            //{
            //    xxx++;
            //    count++;
            //    return View(await _context.Apartments.OrderBy(x => x.Price).Include(a => a.HousingCooperative).ToListAsync());
            //}
            //else if (count == 2 || xxx == 2)
            //{
            //    xxx++;
            //    count++;
            //    return View(await _context.Apartments.OrderByDescending(x => x.Price).Include(a => a.HousingCooperative).ToListAsync());
            //}
            //else
            //{
            //    count = 0;
            //}

            //xxx++;
            //count++;


            //return View(await _context.Apartments.OrderBy(x => x.ApartmentNumber).Include(a => a.HousingCooperative).ToListAsync());


        }

        // GET: Apartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartments
                .Include(a => a.HousingCooperative)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apartment == null)
            {
                return NotFound();
            }

            return View(apartment);
        }

        // GET: Apartments/Create
        public IActionResult Create()
        {
            ViewData["HousingCooperativeId"] = new SelectList(_context.HousingCooperatives, "Id", "Name");
            return View();
        }

        // POST: Apartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ApartmentNumber,Rent,Rooms,Size,Price,OperatingCost,HousingCooperativeId")] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HousingCooperativeId"] = new SelectList(_context.HousingCooperatives, "Id", "Name", apartment.HousingCooperativeId);
            return View(apartment);
        }

        // GET: Apartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartments.FindAsync(id);
            if (apartment == null)
            {
                return NotFound();
            }
            ViewData["HousingCooperativeId"] = new SelectList(_context.HousingCooperatives, "Id", "Name", apartment.HousingCooperativeId);
            return View(apartment);
        }

        // POST: Apartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ApartmentNumber,Rent,Rooms,Size,Price,OperatingCost,HousingCooperativeId")] Apartment apartment)
        {
            if (id != apartment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApartmentExists(apartment.Id))
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
            ViewData["HousingCooperativeId"] = new SelectList(_context.HousingCooperatives, "Id", "Name", apartment.HousingCooperativeId);
            return View(apartment);
        }

        // GET: Apartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartments
                .Include(a => a.HousingCooperative)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apartment == null)
            {
                return NotFound();
            }

            return View(apartment);
        }

        // POST: Apartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apartment = await _context.Apartments.FindAsync(id);
            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApartmentExists(int id)
        {
            return _context.Apartments.Any(e => e.Id == id);
        }
    }
}
