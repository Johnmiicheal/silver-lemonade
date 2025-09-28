namespace BlogPlatform.App;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnViewPostsClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//PostsPage");
	}
}
