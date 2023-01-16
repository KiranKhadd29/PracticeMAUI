namespace MauiAppPractice;

public partial class INotifyChangedDemoPage : ContentPage
{
	Model.Employee empM = new Model.Employee();
	public INotifyChangedDemoPage()
	{
		InitializeComponent();
        empM = new Model.Employee()
		{
			Id = 11,
			Name ="Rajasahab",
			Age=59
		};
		BindingContext = empM;
	}

	public void Button_Clicked (object sender, EventArgs e)
	{
		empM.Id = 111;
		empM.Name = "Mr_India";
        empM.Age = 10;
	}
}