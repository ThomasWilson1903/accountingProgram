using DiplomaOborotovIS.data.api.model.order;
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
using Diploma.model.supply;

namespace accountingProgram.data.api.order
{
    internal class OrderApi
    {
        private readonly HttpClient httpClient = new();
        private readonly LocalStorage localStorage = new();

        public List<Order> GetAll(string? search = null)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var builder = new UriBuilder("http://localhost:5000/api/Order");

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["search"] = search;
            builder.Query = query.ToString();

            var url = builder.ToString();

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Order>>(json);
        }

        public List<SupplyAnalyticDto> GetAnalytic()
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var builder = new UriBuilder("http://localhost:5000/api/Order/Analytics");

            var url = builder.ToString();

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<SupplyAnalyticDto>>(json);
        }

        public void Add(CreateOrderDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Post, $"http://localhost:5000/api/Order");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Update(int id, CreateOrderDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Put, $"http://localhost:5000/api/Order/{id}");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Delete(int id)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Delete, $"http://localhost:5000/api/Order/{id}");

            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }
    }
}
