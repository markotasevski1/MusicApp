using Ukim.MusicApp.Services;
using Ukim.MusicApp.ViewModels;
using Ukim.MusicApp.Views;

namespace Ukim.MusicApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<CategoriesPage>();
		builder.Services.AddSingleton<CategoriesViewModel>();
		builder.Services.AddTransient<IRestService, RestService>();

		return builder.Build();
	}
}
