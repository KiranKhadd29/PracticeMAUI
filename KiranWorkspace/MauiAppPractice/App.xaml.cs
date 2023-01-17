using MauiAppPractice.MVVM.Views;

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
		//MainPage = new PresentationControlDemoPage();
		//MainPage = new CommandControlDemoPage();
		//MainPage = new InputControlsDemoPage();
		//MainPage = new ActivityControlDemoPage();	
		//MainPage = new CollectionControlsDemoPage();	
		//MainPage = new ResourcesDemoPage();
		//MainPage = new DataBindingDemoPage();
		//MainPage = new ModesDempPage();
		//MainPage = new INotifyChangedDemoPage();
		//MainPage = new ProductDemoPage();	
		//MainPage = new BindCollectionViewDemoPage();
		MainPage = new CovertorDemoPage();
    }
}
