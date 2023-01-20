using MAUITutorial.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITutorial.MVVM.ViewModels
{
    public class ProductViewModelForCollection
    {
        public List<Product> ProductView { get; set; }  = new List<Product>();
        public ProductViewModelForCollection() 
        {
            ProductView.Add(new Product { Title = "Samsung", AvailQty = 5, ProductWeight = 180 });
            ProductView.Add(new Product { Title = "LG", AvailQty = 6, ProductWeight = 280 });
            ProductView.Add(new Product { Title = "Nokia", AvailQty = 7, ProductWeight = 380 });
        }  
    }
}
