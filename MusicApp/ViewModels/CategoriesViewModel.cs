using System;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using Ukim.MusicApp.Models;
using Ukim.MusicApp.Services;

namespace Ukim.MusicApp.ViewModels
{
    public partial class CategoriesViewModel : ObservableObject
    {
        private readonly IRestService _restService;

        [ObservableProperty]
        private ObservableCollection<Category> categories;

        public CategoriesViewModel(IRestService restService)
        {
            //BindStaticData();
            _restService = restService;
            LoadData();
        }

        private void BindStaticData()
        {
            Categories = new ObservableCollection<Category>()
            {
                { new Category() { Id = 1, Name = "Pop" } },
                { new Category() { Id = 2, Name = "Rock" } },
                { new Category() { Id = 3, Name = "Jazz" } }
            };
        }

        private void LoadData()
        {
            _restService.GetCategoriesAsync().ContinueWith(SetCategories);
        }

        private void SetCategories(Task<IEnumerable<Category>> task)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Categories = new ObservableCollection<Category>(task.Result);
            });
        }
    }
}
