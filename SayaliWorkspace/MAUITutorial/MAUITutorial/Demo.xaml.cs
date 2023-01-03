namespace MAUITutorial;

public partial class Demo : ContentPage
{
	public Demo()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}