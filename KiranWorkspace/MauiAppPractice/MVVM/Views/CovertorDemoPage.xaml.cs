using MauiAppPractice.MVVM.ViewModels;

namespace MauiAppPractice.MVVM.Views;

public partial class CovertorDemoPage : ContentPage
{
	public CovertorDemoPage()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}