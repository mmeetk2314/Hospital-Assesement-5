using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital_Assesement_5.Data;
using Hospital_Assesement_5.Models;
using Microsoft.AspNetCore.Authorization;

namespace Hospital_Assesement_5.Controllers
{
    public class MedicinesController : Controller
    {
        private readonly Hospital_Assesement_5Context _context;

        public MedicinesController(Hospital_Assesement_5Context context)
        {
            _context = context;
        }

        // GET: Medicines
        public async Task<IActionResult> Index()
        {
            var hospital_Assesement_5Context = _context.Medicine.Include(m => m.Hospital_ID);
            return View(await hospital_Assesement_5Context.ToListAsync());
        }

        // GET: Medicines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = await _context.Medicine
                .Include(m => m.Hospital_ID)
                .FirstOrDefaultAsync(m => m.MedicineID == id);
            if (medicine == null)
            {
                return NotFound();
            }

            return View(medicine);
        }
        [Authorize]
        // GET: Medicines/Create
        public IActionResult Create()
        {
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalName");
            return View();
        }

        // POST: Medicines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicineID,MedicineName,Price,HospitalID")] Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalID", medicine.HospitalID);
            return View(medicine);
        }

        // GET: Medicines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = await _context.Medicine.FindAsync(id);
            if (medicine == null)
            {
                return NotFound();
            }
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalName", medicine.HospitalID);
            return View(medicine);
        }

        // POST: Medicines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicineID,MedicineName,Price,HospitalID")] Medicine medicine)
        {
            if (id != medicine.MedicineID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicineExists(medicine.MedicineID))
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
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalID", medicine.HospitalID);
            return View(medicine);
        }

        // GET: Medicines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = await _context.Medicine
                .Include(m => m.Hospital_ID)
                .FirstOrDefaultAsync(m => m.MedicineID == id);
            if (medicine == null)
            {
                return NotFound();
            }

            return View(medicine);
        }

        // POST: Medicines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicine = await _context.Medicine.FindAsync(id);
            _context.Medicine.Remove(medicine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineExists(int id)
        {
            return _context.Medicine.Any(e => e.MedicineID == id);
        }
    }
}
