using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace Lab3.Models
{
    public class ProductModel
    {
        public int ProductId{get;set;}
        [DisplayName("Product Name")]
        [Required(ErrorMessage="not null")]

        public string ProductName{get;set;}
        [DisplayName("Quality")]
        [Required]
        [Range(0,100)]

        public int ProductQuanlity{get;set;}
        [DisplayName("Image")]

        public string ProductImage{get;set;}
        [DisplayName("Category")]

        public int CategoryId{get;set;}
        [Required]
        [Range(0,999.99)]
        [DisplayName("Price")]

        public double ProductPrice {get;set;}
        [DisplayName("Create on")]
        public DateTime CreateDate {get;set;}
        public string Descriptions {get;set;}
        private static int nextId = 1;

        public ProductModel()
        {
            ProductId = nextId;
            nextId++;
        }
        public override int GetHashCode()
        {
            return ProductId;
        }

    }
}