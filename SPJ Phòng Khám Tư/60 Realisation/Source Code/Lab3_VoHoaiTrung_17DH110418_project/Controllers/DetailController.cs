using System.Linq;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class DetailController : Controller
    {
        private readonly ProductData productData;
        public DetailController(ProductData product)
        {
            this.productData=product;
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            ProductModel productModel= productData.ProductList.FirstOrDefault(p => p.ProductId==id);
            return View(productModel);
        }
    }
}