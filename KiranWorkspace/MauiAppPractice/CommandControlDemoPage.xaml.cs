namespace MauiAppPractice;

public partial class CommandControlDemoPage : ContentPage
{
	public CommandControlDemoPage()
	{
		InitializeComponent();
	}

	private void DemoBtn_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Demo Page","DemoBtn Click Suceess","Ok");
	}
    private void DemoBtn2_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Imgage Page", "Image Click Suceess", "Ok");
    }
    private void RadioButton_CheckedChanged (object sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("Option Selected", $"Selected:{e.Value}", "Ok");
	}
	private void Searching_SearchButtonPressed(object sender, EventArgs e) 
	{
		DisplayAlert("Searching Text",$"You're {Searching.Text}","Ok");
	}
	private void SwipeItem_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Option", "O", "K");
	}
}