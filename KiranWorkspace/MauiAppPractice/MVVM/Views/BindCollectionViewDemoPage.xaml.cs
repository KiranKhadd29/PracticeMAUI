using MauiAppPractice.MVVM.ViewModels;

namespace MauiAppPractice.MVVM.Views;

public partial class BindCollectionViewDemoPage : ContentPage
{
	public BindCollectionViewDemoPage()
	{
		InitializeComponent();

		BindingContext = new ProductViewModelForCollection();
	}
	
}