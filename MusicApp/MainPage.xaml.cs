namespace MusicApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnAboutClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//DetailPage");
    }
}

