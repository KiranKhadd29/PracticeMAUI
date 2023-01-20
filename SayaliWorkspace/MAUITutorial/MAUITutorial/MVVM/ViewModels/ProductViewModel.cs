using MAUITutorial.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITutorial.MVVM.ViewModels
{
    public class ProductViewModel
    {
        public Product product { get; set; }   
        public ProductViewModel() 
        {
            product = new Product()
            {
                Title = "Nokia",
                Description = "Nokia G21",
                AvailQty = 5,
                ProductWeight = 100,
                IsPopular = true,
                CreatedDate = new DateTime(1998, 5, 16)

            };
        }
    }
}
