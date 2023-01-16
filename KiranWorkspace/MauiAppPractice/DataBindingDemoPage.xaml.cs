namespace MauiAppPractice;

public partial class DataBindingDemoPage : ContentPage
{
	public DataBindingDemoPage()
	{
		InitializeComponent();
	}
	public void Button_Clicked (object sender, EventArgs e)
	{
		MauiAppPractice.Model.Employee  emp= new MauiAppPractice.Model.Employee()
		{
			Id = 4,
			Name = "Kiran B Khadd",
			Age= 25,
		};
		//Binding empBinding = new Binding();
		//empBinding.Source= emp;
		//empBinding.Path = "Name";
		//EmployeeLabel.SetBinding(Label.TextProperty, empBinding);
		//BindingContext= emp;
		EmployeeLabel.BindingContext= emp;
		EmployeeLabel.SetBinding(Label.TextProperty, "Age");

    }

}