using System;
using System.Text.Json;

using Newtonsoft.Json;

using Ukim.MusicApp.Models;

namespace Ukim.MusicApp.Services
{
    public class RestService : IRestService
    {
        static HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public static string BaseAddress =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5080" : "http://localhost:5080";
        public List<Category> Items { get; private set; }

        public RestService()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(BaseAddress)
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

        public  async Task<IEnumerable<Category>> GetCategoriesById(int id)
        {          
            var response = await _client.GetStringAsync($"{BaseAddress}/{id}");
            var categoriesById = JsonConvert.DeserializeObject<IEnumerable<Category>>(response);

            return categoriesById;
        }
    }
}
