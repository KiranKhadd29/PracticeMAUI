using MAUITutorial.MVVM.Models;
using MAUITutorial.MVVM.ViewModels;

namespace MAUITutorial.MVVM.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
		
		BindingContext = new ProductViewModel();
	}
}