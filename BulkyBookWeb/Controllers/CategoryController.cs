using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        //GET action method
        public IActionResult Create()
        {
            return View();
        }

        //POST action method
        //HttpPost attribute
        [HttpPost]
        //Help to prevent forgery
        [ValidateAntiForgeryToken]

        //Create a category action
        public IActionResult Create(Category obj)
        {
            //Custom validation
            if(obj.Name==obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot match the Name.");
            }

            //Validation - checks if model is valid
            if (ModelState.IsValid)
            {
                //What the user adds - adds category entity
                _db.Categories.Add(obj);
                //saves changes that was just added adn saves to database
                _db.SaveChanges();

                //Display alerts
                TempData["success"] = "Category created successfully";

                //then returns to the category view Index
                return RedirectToAction("Index");
            }

            //If model is not valid return to object
            return View(obj);
        }


        //Edit POST and GET

        //GET action method
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Returns matching id from the database
            var categoryFromDb = _db.Categories.Find(id);
            //var categoryFromDbFirst = _db.Categories.FirstOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(c => c.Id == id);

            if(categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST action method
        //HttpPost attribute
        [HttpPost]
        //Help to prevent forgery
        [ValidateAntiForgeryToken]

        //Edit a category action
        public IActionResult Edit(Category obj)
        {
            //Custom validation
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot match the Name.");
            }

            //Validation - checks if model is valid
            if (ModelState.IsValid)
            {
                //What the user updates - updates category entity
                _db.Categories.Update(obj);
                //saves changes that was just updated and saves to database
                _db.SaveChanges();

                //Display alerts
                TempData["success"] = "Category updated successfully";

                //then returns to the category view Index
                return RedirectToAction("Index");
            }

            //If model is not valid return to object
            return View(obj);
        }




        //Delete POST and GET

        //GET action method
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Returns matching id from the database
            var categoryFromDb = _db.Categories.Find(id);
            //var categoryFromDbFirst = _db.Categories.FirstOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST action method
        //HttpPost attribute. Action name gives explicit name that matches in the Delete view
        [HttpPost,ActionName("Delete")]
        //Help to prevent forgery
        [ValidateAntiForgeryToken]

        //Delete a category action
        public IActionResult DeletePOST(int? id)
        {
            //get the object to delete
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            //What the user updates - updates category entity
            _db.Categories.Remove(obj);
            //saves changes that was just updated and saves to database
            _db.SaveChanges();

            TempData["success"] = "Category deleted successfully";

            //then returns to the category view Index
            return RedirectToAction("Index");

        }


    }
}
