using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IO;
using System;
using Microsoft.AspNetCore.Http;
using Lab3.Models;

 namespace Lab3.Controllers
 {
     public class ProductController : Controller
     {
         private ProductData data;

         public ProductController(ProductData productData)
         {
             data=productData;

         }
         public IActionResult Index()
         {
             return View(data.ProductList);
         }
         [HttpGet]

         public IActionResult Create()
         {
             ProductModel productModel = new ProductModel();
             return View(productModel);
         }

         [HttpPost]
         public IActionResult Create(ProductModel productModel,IFormFile photo)
         {
             if(ModelState.IsValid)
             {
                 ProductModel newProDuct = new ProductModel();
                 if(photo==null || photo.Length==0)
                 {
                     newProDuct.ProductImage="iphoneX.png";
                 }
                 else
                 {
                     var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images",photo.FileName);
                     var stream = new FileStream(path,FileMode.Create);
                     photo.CopyToAsync(stream);
                     newProDuct.ProductImage=photo.FileName;

                 }
                 newProDuct.ProductName = productModel.ProductName;
                 newProDuct.ProductQuanlity = productModel.ProductQuanlity;
                 newProDuct.ProductPrice = productModel.ProductPrice;
                 newProDuct.Descriptions = productModel.Descriptions;
                 newProDuct.CreateDate = DateTime.Now;
                 data.ProductList.Add(newProDuct);
                 return RedirectToAction("Index","Product");
             }
             else
             {
                 return View(productModel);
             }
         }
     }
 }
