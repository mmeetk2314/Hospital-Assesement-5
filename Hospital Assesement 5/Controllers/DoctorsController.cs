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
    
    public class DoctorsController : Controller
    {
        private readonly Hospital_Assesement_5Context _context;

        public DoctorsController(Hospital_Assesement_5Context context)
        {
            _context = context;
        }

        // GET: Doctors
        public async Task<IActionResult> Index()
        {
            var hospital_Assesement_5Context = _context.Doctor.Include(d => d.Hospital_ID);
            return View(await hospital_Assesement_5Context.ToListAsync());
        }

        // GET: Doctors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctor
                .Include(d => d.Hospital_ID)
                .FirstOrDefaultAsync(m => m.DoctorID == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }
        [Authorize]

        // GET: Doctors/Create
        public IActionResult Create()
        {
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalName");
            return View();
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorID,DoctorName,StartDate,ContactNumber,EmailId,HospitalID")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalID", doctor.HospitalID);
            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctor.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalName", doctor.HospitalID);
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorID,DoctorName,StartDate,ContactNumber,EmailId,HospitalID")] Doctor doctor)
        {
            if (id != doctor.DoctorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.DoctorID))
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
            ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalID", doctor.HospitalID);
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctor
                .Include(d => d.Hospital_ID)
                .FirstOrDefaultAsync(m => m.DoctorID == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await _context.Doctor.FindAsync(id);
            _context.Doctor.Remove(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(int id)
        {
            return _context.Doctor.Any(e => e.DoctorID == id);
        }
    }
}
