
using System;
namespace shared.Models
{
    class Product
    {
        public Guid IdProduct {get;set;} 
        public string DescriptionProduct {get;set;}
        public double Price {get;set;} 
        public Guid IdCategory {get;set;} 

    }
}