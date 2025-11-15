using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using a.Data;
using a.Models;

namespace a.Controllers 
{
    public class GPController : Controller
    {
        private readonly AreaC_Context _db;
        public GPController(AreaC_Context db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<GP_Categories> objACReserve = _db.GP_DB;
            //var objStudentList = _db.Students.ToList();
            return View(objACReserve);
        }


        // GET: Students/Details
        public IActionResult Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveNum = _db.GP_DB.FirstOrDefault(m => m.GP_Num == id);
            if (reserveNum == null)
            {
                return NotFound();
            }

            return View(reserveNum);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GP_Categories obj)
        {

            if (ModelState.IsValid)
            {
                _db.GP_DB.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Area reservation created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        [HttpGet]
        public IActionResult Edit(Int64? id)
        {
            if (id == null || id == 0)

            {
                return NotFound();
            }
            var reserveNum = _db.GP_DB.Find(id);

            if (reserveNum == null)
            {
                return NotFound();
            }

            return View(reserveNum);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind] GP_Categories obj)
        {
            if (ModelState.IsValid)
            {
                _db.GP_DB.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Area reservation updated successfully";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "User Update Failed";
            return View(obj);
        }
        public IActionResult Delete(Int64? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.GP_DB.Find(id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(Int64? id)
        {
            var obj = _db.GP_DB.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.GP_DB.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");

        }
    }
}