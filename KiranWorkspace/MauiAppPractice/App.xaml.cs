namespace MauiAppPractice;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navPage = new NavigationPage(new MainPage());
		navPage.BarBackgroundColor = Colors.Gray;
		navPage.BarTextColor= Colors.White;
		//MainPage = navPage;
		//MainPage = new DemoPage();
		//MainPage = new FlyoutPageDemo();
		//MainPage = new TabbedPageDemo();
		//MainPage = new StackPageDemo();
		//MainPage = new GridLayoutDemoPage();
		//MainPage = new AbsoluteLayoutPageDemo();
		//MainPage = new FlexLayoutPageDemo();
		MainPage = new PresentationControlDemoPage();
    }
}
