namespace MAUITutorial;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		MAUITutorial.Models.Employee emp = new MAUITutorial.Models.Employee()
		{
			Id = 1,
			Name = "Sayali",
			Age = 25
		};
		Binding empBinding= new Binding();
		empBinding.Source = emp;
		empBinding.Path = "Name";
		EmployeeLbl.SetBinding(Label.TextProperty, empBinding);

		//Entry entrylbl= new Entry();

	}
}