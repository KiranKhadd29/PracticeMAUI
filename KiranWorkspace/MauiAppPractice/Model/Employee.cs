using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPractice.Model
{
    public class Employee : INotifyChangedDemoPage
    {
        private int _id;
        public int Id
        {
            get => _id; set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        private string _name;
        public string Name { get=>_name; set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        private int _age;
        public int Age { get=>_age; set
            {
                _age = value;
                onPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
