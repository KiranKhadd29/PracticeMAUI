using MAUITutorial.MVVM.Views;

namespace MAUITutorial;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var NavPage = new NavigationPage(new MainPage());
		NavPage.BarBackground = Colors.Green;
		NavPage.BarTextColor = Colors.White;
        // MainPage = new FlyoutPageDemo();
        // MainPage = new TabbedPageDemo();
        // MainPage = new StackPageDemo();
        // MainPage = new GridPageDemo();
        // MainPage = new AbsoluteLayoutDemo();
        // MainPage = new FlexLayoutDemo();
        // MainPage = new PresentationControl();
        // MainPage = new CommandsDemo();
        // MainPage = new InputControls();
        // MainPage = new ActivityControl();
        // MainPage = new CollectionControl();
        // MainPage = new ResourceExample();
        // MainPage = new DataBinding();
        // MainPage = new ModesExample();
        // MainPage = new INotifyChanged();
        MainPage = new ProductPage();
    }
}
