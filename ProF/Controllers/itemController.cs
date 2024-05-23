using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ProF.Data;
using ProF.Models;

namespace ProF.Controllers
{
    public class itemController : Controller
    {
        ApplicationDBcontext db;
        private readonly IWebHostEnvironment _environment;
        public itemController(ApplicationDBcontext db,IWebHostEnvironment environment)
        {
            this.db = db;
            this._environment = environment;
        }
        //list
        public IActionResult ADD()
        {
            List<item> items = db.items.ToList();
            


            return View(items);
        }

        public IActionResult showform_menu()
        {
            List<item> items = db.items.ToList();
			




			return View(items);
        }

        /*
        public IActionResult list_Delete()
        {
            List<item> items = db.items.ToList();



            return View(items);
        }

        
        public IActionResult list_updata()
        {
            List<item> items = db.items.ToList();



            return View(items);
        }
        */

        public IActionResult ADD_Item () { 
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ADD_ItemAsync( item item,IFormFile img_file)
        {
            // to create Images folder in the project Path.
            string path = Path.Combine(_environment.WebRootPath, "img1"); // wwwroot/Img/
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (img_file != null)
            {
                path = Path.Combine(path, img_file.FileName); // for exmple : /Img/Photoname.png
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await img_file.CopyToAsync(stream);
                    // ViewBag.Message = string.Format("<b>{0}</b> uploaded.</br>", img_file.FileName.ToString());
                    item.item_image = img_file.FileName;
                }
            }
            else
            {
                item.item_image = "default.jpeg"; // to save the default image path in database.
            }
            try
            {
                db.Add(item);
                db.SaveChanges();
                return RedirectToAction("ADD");
            }
            catch (Exception ex) { ViewBag.exc = ex.Message; }


            return View();
                }

        public IActionResult Delete(int id)
        {
            item item = db.items.FirstOrDefault();
            return View(item);
        }

   


        [HttpPost]
        public IActionResult Delete(item item)
        {
            //item item = db.items.FirstOrDefault();
            db.items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("ADD");
        }

        public IActionResult Edit(int id)
        {
            var item = db.items.Where(x => x.item_id == id).FirstOrDefault();
            if (item == null)
            {
                return new NotFoundResult();
            }
            return View(item);


        }

        [HttpPost]
        public IActionResult Edit(item item)
        {
            if (ModelState.IsValid)
            {
                db.items.Update(item);
                db.SaveChanges();
                return RedirectToAction("ADD");
            }
            return View(item);


        }




    }
}
