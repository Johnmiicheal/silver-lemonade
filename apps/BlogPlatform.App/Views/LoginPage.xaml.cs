namespace BlogPlatform.App;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		// TODO: Implement login logic
		await DisplayAlert("Login", "Login functionality not implemented yet.", "OK");
	}

	private async void OnRegisterTapped(object sender, EventArgs e)
	{
		// TODO: Navigate to register page
		await DisplayAlert("Register", "Registration page not implemented yet.", "OK");
	}
}
