using MauiAppPractice.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPractice.MVVM.ViewModels
{
    public class ProductViewModels
    {
        public Product pro { get; set; }    // Pro property added for Product class
        public ProductViewModels() 
        {
            pro = new Product()
            {
                Name = "Nokia",
                Description = "Nokia 5.1 plus",
                AvailQty=10,
                ProWeight=15,
                IsPopular=true,
                CreatedDate= new DateTime(2023,01,16)
            };
        }
    }
}
