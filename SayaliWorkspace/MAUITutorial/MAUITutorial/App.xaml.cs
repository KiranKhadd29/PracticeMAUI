namespace MAUITutorial;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var NavPage = new NavigationPage(new MainPage());
		NavPage.BarBackground = Colors.Green;
		NavPage.BarTextColor = Colors.White;
        //MainPage = new FlyoutPageDemo();
        MainPage = new TabbedPageDemo();
    }
}
