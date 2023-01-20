using MAUITutorial.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITutorial.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewModel()
        {
            Person = new Person()
            {
                Married = "Married"
        };
        }
    }
}
