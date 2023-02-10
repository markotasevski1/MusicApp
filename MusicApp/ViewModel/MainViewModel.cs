using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MusicApp.View;


namespace MusicApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;


        //[RelayCommand]
       // Task Navigate() => Shell.Current.GoToAsync(nameof(DetailPage));
    }
}
