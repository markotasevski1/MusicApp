using Ukim.MusicApp.ViewModels;

namespace Ukim.MusicApp.Views;

public partial class CategoriesPage : ContentPage
{
	public CategoriesPage(CategoriesViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}