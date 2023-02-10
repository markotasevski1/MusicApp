
using MusicApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicApp.service
{
    public class RestService : RestServiceInterface
    {
        static HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        static string apiUrl="ADD-API-ADDRESS";
        public List<Category> Items { get; private set; }

        public RestService()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(apiUrl)
            };
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public  async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var json = await _client.GetStringAsync("/api/Categories");
                var categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(json);
            return categories;
        }
        public  async Task<IEnumerable<Category>> getCategoriesById(long id)
        {
          
            var response = await _client.GetStringAsync($"{apiUrl}/{id}");
            var categoriesById = JsonConvert.DeserializeObject<IEnumerable<Category>>(response);

            return categoriesById;
        }

    }
}
