using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using a.Models;
using a.Data;

public class LController : Controller
{
    private readonly AreaC_Context _context;

    public LController(AreaC_Context context)
    {
        _context = context;
    }

    // -----------------------------
    // GET: Create
    // -----------------------------
    public IActionResult Create()
    {
        return View();
    }

    // -----------------------------
    // POST: Create
    // Upload Image and Save
    // -----------------------------
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(L_Categories model)
    {
        if (model.ImageFile != null)
        {
            using var ms = new MemoryStream();
            await model.ImageFile.CopyToAsync(ms);
            model.L_LoadnRegis = ms.ToArray();
        }

        _context.Add(model);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    // -----------------------------
    // INDEX PAGE
    // -----------------------------
    public async Task<IActionResult> Index()
    {
        return View(await _context.L_DB.ToListAsync());
        //IEnumerable<L_Categories> objACReserve = _db.AR_DB;
        //return View(objACReserve);
    }

    public async Task<IActionResult> Download(long id)
    {
        var item = await _context.L_DB.FindAsync(id);
        if (item == null || item.L_LoadnRegis == null)
            return NotFound();

        return File(item.L_LoadnRegis, "image/jpeg", $"StudentImage_{id}.jpg");
    }
    // --------------------
    // GET: Edit
    // --------------------
    public async Task<IActionResult> Edit(long id)
    {
        var item = await _context.L_DB.FindAsync(id);
        if (item == null)
            return NotFound();

        return View(item);
    }

    // --------------------
    // POST: Edit
    // --------------------
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, L_Categories model)
    {
        if (id != model.L_Num)
            return NotFound();

        var existing = await _context.L_DB.FindAsync(id);
        if (existing == null)
            return NotFound();

        // Update fields
        existing.L_StuID = model.L_StuID;
        existing.L_StuName = model.L_StuName;
        existing.LockerCode = model.LockerCode;
        existing.L_Semester = model.L_Semester;
        existing.L_ContactNumber = model.L_ContactNumber;
        existing.L_Approval = model.L_Approval;

        // If user uploads a new image
        if (model.ImageFile != null)
        {
            using var ms = new MemoryStream();
            await model.ImageFile.CopyToAsync(ms);
            existing.L_LoadnRegis = ms.ToArray();
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }



    public async Task<IActionResult> Details(long id)
    {
        var item = await _context.L_DB.FirstOrDefaultAsync(x => x.L_Num == id);
        if (item == null)
            return NotFound();

        return View(item);
    }
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        var item = await _context.L_DB.FindAsync(id);
        if (item == null)
            return NotFound();

        _context.L_DB.Remove(item);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Delete(long id)
    {
        var item = await _context.L_DB.FirstOrDefaultAsync(x => x.L_Num == id);
        if (item == null)
            return NotFound();

        return View(item);
    }


}
