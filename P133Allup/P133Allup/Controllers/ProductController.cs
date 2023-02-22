using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using P133Allup.DataAccessLayer;
using P133Allup.Models;

namespace P133Allup.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
      //  public async Task<IActionResult> ProductModal(int? id)
      //  {
        //    if (id==null) {
          //      return BadRequest();
            //}
            //Product product = await _context.Products.Include(p=>p.ProductImages).FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);
            //if (product==null) {
              //  return NotFound();
            //}
            //return PartialView("_ModalPartial", product);
//        }

       
    }

}
