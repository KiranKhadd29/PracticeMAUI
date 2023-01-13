namespace MauiAppPractice;

public partial class ResourcesDemoPage : ContentPage
{
	public ResourcesDemoPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await LoadMauiAsset();
    }
    private async Task LoadMauiAsset()
	{
		using var stream = await FileSystem.OpenAppPackageFileAsync("Employee.json");
		using var reader = new StreamReader(stream);

		var content = reader.ReadToEnd();
		var result = System.Text.Json.JsonSerializer.Deserialize<Employee>(content);
	}
}
public class Employee
	{
	public string Name { get; set; }
	public int Salary { get; set; }
	}
