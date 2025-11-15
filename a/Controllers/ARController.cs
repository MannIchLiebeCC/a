using a.Data;
using a.Models;
using Microsoft.AspNetCore.Mvc;


namespace a.Controllers 
{
    public class ARController : Controller
    {
        private readonly AreaC_Context _db;
        public ARController(AreaC_Context db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<AR_Categories> objACReserve = _db.AR_DB;
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

            var reserveNum = _db.AR_DB.FirstOrDefault(m => m.AR_ReserveNum == id);
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
        public IActionResult Create(AR_Categories obj)
        {

            if (ModelState.IsValid)
            {
                _db.AR_DB.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Area reservation created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind] AR_Categories obj)
        {
            if (ModelState.IsValid)
            {
                _db.AR_DB.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Area reservation updated successfully";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "User Update Failed";
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
            var reserveNum = _db.AR_DB.Find(id);

            if (reserveNum == null)
            {
                return NotFound();
            }

            return View(reserveNum);
        }


        public IActionResult Delete(Int64? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.AR_DB.Find(id);

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
            var obj = _db.AR_DB.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.AR_DB.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");

        }

    }
}