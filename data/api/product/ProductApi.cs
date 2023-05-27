using DiplomaOborotovIS.data.api.model.user;
using Hanssens.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DiplomaOborotovIS.data.api.model.product;

namespace accountingProgram.data.api.product
{
    internal class ProductApi
    {
        private readonly HttpClient httpClient = new();
        private readonly LocalStorage localStorage = new();

        public List<Product> GetAll(string? search = null)
        {
            var builder = new UriBuilder("http://localhost:5000/api/Product");

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["search"] = search;
            builder.Query = query.ToString();

            var url = builder.ToString();

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = httpClient.SendAsync(request).Result;

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Product>>(json);
        }

        public void Add(CreateProductDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Post, $"http://localhost:5000/api/Product");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Update(int id, CreateProductDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Put, $"http://localhost:5000/api/Product/{id}");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Delete(int id)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Delete, $"http://localhost:5000/api/Product/{id}");

            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }
    }
}
