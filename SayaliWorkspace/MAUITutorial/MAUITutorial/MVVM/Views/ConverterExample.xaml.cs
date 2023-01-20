using MAUITutorial.MVVM.ViewModels;

namespace MAUITutorial.MVVM.Views;

public partial class ConverterExample : ContentPage
{
	public ConverterExample()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}