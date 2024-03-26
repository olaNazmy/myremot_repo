using images.Models;
using images.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace images.Controllers
{
    
    public class productController : Controller
    {
        private ImageContext context;
        IWebHostEnvironment env;


        //inject
        public productController(ImageContext imagecontext,IWebHostEnvironment hostEnvironment)
        {
            
            context = imagecontext;
            env = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }

        //Add just open view
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(ProductViewModel product1)
        {
            string filename = "";
            if(product1.photo != null)
            {
                string Uploader = Path.Combine(env.WebRootPath,"images");
                filename = Guid.NewGuid().ToString() + "_" + product1.photo.FileName;
                string filepath = Path.Combine(Uploader,filename);
                product1.photo.CopyTo(new FileStream(filepath, FileMode.Create));
            }
            //
            product p = new product()
            {
                Name = product1.Name,
                price = product1.price,
                Image = filename
            };
            //
            context.Products.Add(p);
            context.SaveChanges();
            //
            ViewBag.success = "record added successfully";

            return View();
        }
    }
}
