using MauiAppPractice.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPractice.MVVM.ViewModels
{
    public class ProductViewModelForCollection
    {
        public List<string> ProductView { get; set; }
        public List<Product> ProductView2 { get; set; } = new List<Product>();
        public ProductViewModelForCollection()
        {
            //ProductView = new List<string>()
            //{
            //    "Sony",
            //    "LG",
            //    "Apple"

            //};

            ProductView2.Add( new Product
                {
                    Name = "Kiran",
                    AvailQty = 20,
                    ProWeight = 67
                } 
            );
            ProductView2.Add(new Product 
                { 
                    Name = "sayali", 
                    AvailQty = 30, 
                    ProWeight = 77 
                }
            );



        } 
    }
}
