using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppPractice.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CommandViewModel
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Result { get; set; }

        public ICommand ResultCommand =>
            new Command(Calculate);

        private void Calculate(object obj)
        {
            Result = First + Second;
        }

        public ICommand CommandClick1 =>
            new Command(ExecuteAlert);

        private void ExecuteAlert(object obj)
        {
            App.Current.MainPage.DisplayAlert("Hi,", "Its Kiya Here", "Ok");
        }

        public ICommand commandSearch =>
            new Command(CommandPara);
        private void CommandPara(object obj)
        {
            App.Current.MainPage.DisplayAlert("Hi,", $"{obj}", "Ok");
        }

        public string searchCommand { get; set; }

    }
}
