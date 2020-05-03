using System;
using System.Collections.Generic;

namespace Lab3.Models
{

    public class ProductData
    {
        public List<ProductModel> ProductList { get;set;}
        
        public static ProductData initData()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.AddRange(new List<ProductModel>
            {
                new ProductModel()
                {
                    ProductName = "IphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuanlity = 100,
                    ProductPrice=1000.00,
                    CreateDate=DateTime.Now

                },
                new ProductModel()
                {
                    ProductName = "IphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuanlity = 100,
                    ProductPrice=1000.00,
                    CreateDate=DateTime.Now

                },
                new ProductModel()
                {
                    ProductName = "IphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuanlity = 100,
                    ProductPrice=1000.00,
                    CreateDate=DateTime.Now

                },
                new ProductModel()
                {
                    ProductName = "IphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuanlity = 100,
                    ProductPrice=1000.00,
                    CreateDate=DateTime.Now

                },
                new ProductModel()
                {
                    ProductName = "IphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuanlity = 100,
                    ProductPrice=1000.00,
                    CreateDate=DateTime.Now

                }
            }); ;
            return new ProductData()
            {
                ProductList=products
            };

        }
    }
}