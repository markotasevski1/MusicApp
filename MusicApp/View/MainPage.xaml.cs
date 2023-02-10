namespace MusicApp.View;

public partial class MainPage : ContentPage
{
    
	public MainPage()
	{
		InitializeComponent();
	}
    private void OnAboutClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//DetailPage");
    }
}