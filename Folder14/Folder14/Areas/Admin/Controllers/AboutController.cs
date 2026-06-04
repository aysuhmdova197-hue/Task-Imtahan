using Folder14.Data;
using Folder14.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Folder14.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var datas = await _context.Chefs.ToListAsync();
            return View(datas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(Chef model)
        {
            if (!ModelState.IsValid) return View(model);
            await _context.Chefs.AddAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();
            var data = await _context.Chefs.FindAsync(id.Value);
            if (data is null) return NotFound();
            _context.Chefs.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();
            var data = await _context.Chefs.FindAsync(id.Value);
            if (data is null) return NotFound();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null) return BadRequest();
            var data = await _context.Chefs.FindAsync(id.Value);
            if (data is null) return NotFound();
            return View(new Chef { Image = data.Image, Name = data.Name, Job = data.Job });
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, Chef model)
        {
            if (!ModelState.IsValid) return View(model);
            if (id is null) return BadRequest();
            var data = await _context.Chefs.FindAsync(id.Value);
            if (data is null) return NotFound();
            data.Name = model.Name;
            data.Image = model.Image;
            data.Job = model.Job;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




    }
}
