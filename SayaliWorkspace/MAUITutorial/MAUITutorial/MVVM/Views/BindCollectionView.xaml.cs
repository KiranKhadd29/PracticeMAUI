using MAUITutorial.MVVM.ViewModels;

namespace MAUITutorial.MVVM.Views;

public partial class BindCollectionView : ContentPage
{
	public BindCollectionView()
	{
		InitializeComponent();
		BindingContext = new ProductViewModelForCollection();

    }
}