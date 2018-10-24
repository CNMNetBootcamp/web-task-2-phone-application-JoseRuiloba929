using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneApp.Models;

namespace PhoneApp.Controllers
{
    public class PhonesController : Controller
    {
        private readonly PhoneAppContext _context;

        public PhonesController(PhoneAppContext context)
        {
            _context = context;
        }

        // GET: Phones
        public async Task<IActionResult> Index(string sortOrder, string searchString,string currentFilter,
            int? page)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["BrandSortParam"] = string.IsNullOrEmpty(sortOrder) ? "manf_desc" : "";
            ViewData["NameSortParam"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["BatLifeSortParam"] = string.IsNullOrEmpty(sortOrder) ? "batt_desc" : "";
            ViewData["LDateSortParam"] = string.IsNullOrEmpty(sortOrder) ? "ldat_desc" : "";
            ViewData["PhlbSortParam"] = string.IsNullOrEmpty(sortOrder) ? "phlb_desc" : "";
            ViewData["PhOSSortParam"] = string.IsNullOrEmpty(sortOrder) ? "phOS_desc" : "";
            ViewData["PhCPUSortParam"] = string.IsNullOrEmpty(sortOrder) ? "phcpu_desc" : "";
            ViewData["PhMdSortParam"] = string.IsNullOrEmpty(sortOrder) ? "phMd_desc" : "";
            ViewData["ratingSortParam"] = string.IsNullOrEmpty(sortOrder) ? "phrt_desc" : "";

            if (searchString !=null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            var phone = from s in _context.Phone
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                phone = phone.Where(s => s.Brand.Contains(searchString)
                              || s.Name.Contains(searchString)
                              || s.phoneOS.Contains(searchString)
                              || s.phoneCPU.Contains(searchString)
                               || s.phoneDisplay.Contains(searchString)
                              );
            }

            switch (sortOrder)
            {
                case "manf_desc":
                    phone= phone.OrderByDescending(s => s.Brand);
                    break;
                case "name_desc":
                    phone = phone.OrderByDescending(s => s.Name);
                    break;
                case "batt_desc":
                    phone = phone.OrderByDescending(s => s.batteryLife);
                    break;
                case "ldat_desc":
                    phone = phone.OrderByDescending(s => s.LaunchDate);
                    break;
                case "phlb_desc":
                    phone = phone.OrderByDescending(s => s.batteryLife);
                    break;
                case "phOS_desc":
                    phone = phone.OrderByDescending(s => s.LaunchDate);
                    break;
                case "phcpu_desc":
                    phone = phone.OrderByDescending(s => s.phoneCPU);
                    break;
                case "phMd_desc":
                    phone = phone.OrderByDescending(s => s.phoneDisplay);
                    break;
                case "phrt_desc":
                    phone = phone.OrderByDescending(s => s.phoneRating);
                    break;
                default:
                    phone = phone.OrderBy(s => s.Brand);
                
                    break;
            }
            int pageSize = 4;


            return View(await PaginatedList<Phone>.CreateAsync(phone.AsNoTracking(), page ?? 1, pageSize)); ;
        }

        // GET: Phones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone
                .SingleOrDefaultAsync(m => m.iD == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        // GET: Phones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Phones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("iD,Brand,Name,batteryLife,LaunchDate,phoneWeight,phoneOS,phoneCPU,phoneDisplay,phoneRating,phoneImage")] Phone phone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phone);
        }

        // GET: Phones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone.SingleOrDefaultAsync(m => m.iD == id);
            if (phone == null)
            {
                return NotFound();
            }
            return View(phone);
        }

        // POST: Phones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("iD,Brand,Name,batteryLife,LaunchDate,phoneWeight,phoneOS,phoneCPU,phoneDisplay,phoneRating,phoneImage")] Phone phone)
        {
            if (id != phone.iD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhoneExists(phone.iD))
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
            return View(phone);
        }

        // GET: Phones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone
                .SingleOrDefaultAsync(m => m.iD == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        // POST: Phones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phone = await _context.Phone.SingleOrDefaultAsync(m => m.iD == id);
            _context.Phone.Remove(phone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhoneExists(int id)
        {
            return _context.Phone.Any(e => e.iD == id);
        }
    }
}
