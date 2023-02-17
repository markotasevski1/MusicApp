using System;

using Ukim.MusicApp.Models;

namespace Ukim.MusicApp.Services
{
    public interface IRestService
    {
      Task<IEnumerable<Category>> GetCategoriesAsync();
      Task<IEnumerable<Category>> GetCategoriesById(int id);
    }
}
