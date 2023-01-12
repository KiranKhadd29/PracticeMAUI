namespace MAUITutorial;

public partial class CommandsDemo : ContentPage
{
	public CommandsDemo()
	{
		InitializeComponent();
	}

    private void demoBtn_Clicked_1(object sender, EventArgs e)
	{
		DisplayAlert("Demo Page", "Hello World!", "Ok");
	}
    private void RadioButtton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("Option Selected", $"selected:{e.Value}", "ok");
	}
	private void Searching_SearchButtonPressed(object sender, EventArgs e) 
	{
		DisplayAlert("Searching Text",$"You Search {Searching.Text}","ok");
	}
	private void SwipeItem_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Swipe", "Swipe text", "ok");
	}
}