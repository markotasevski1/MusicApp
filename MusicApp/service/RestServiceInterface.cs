using MusicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.service
{
    internal interface RestServiceInterface
    {
      Task<IEnumerable<Category>> GetCategoriesAsync();
      Task<IEnumerable<Category>> getCategoriesById(long id);
    }
}
