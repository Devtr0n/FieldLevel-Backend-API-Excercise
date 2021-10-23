using FieldLevel.Interfaces;
using FieldLevel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FieldLevel.Services
{
    public class PostService : IPostService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PostService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<PostModel>> GetAllPosts()
        {
            var client = _httpClientFactory.CreateClient("JsonClient");
            var response = await client.GetAsync(new Uri("https://jsonplaceholder.typicode.com/posts"));
            var responseBody = await response.Content.ReadAsStringAsync();
            var json = JsonSerializer.Deserialize<IEnumerable<PostModel>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var results = json.GroupBy(g => g.UserId, (key, g) => g.OrderByDescending(y => y.Id).First())
                                .ToList()
                                .AsEnumerable();

            return results;
        }
    }
}