using MauiAppPractice.MVVM.ViewModels;

namespace MauiAppPractice.MVVM.Views;

public partial class CommandDemoPage : ContentPage
{
	public CommandDemoPage()
	{
		InitializeComponent();
		BindingContext = new CommandViewModel();

    }
}