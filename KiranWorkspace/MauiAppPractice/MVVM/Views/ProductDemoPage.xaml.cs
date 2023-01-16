using MauiAppPractice.MVVM.ViewModels;
using System.ComponentModel;

namespace MauiAppPractice.MVVM.Views;

public partial class ProductDemoPage : ContentPage
{
	public ProductDemoPage()
	{
		InitializeComponent();
		BindingContext = new ProductViewModels();
	}
}