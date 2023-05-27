using DiplomaOborotovIS.data.api.model.user;
using DiplomaOborotovIS.data.api.model.warehouse;
using Hanssens.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Net.Http;
using System.Web;
using System;

namespace accountingProgram.data.api.warehouse
{
    internal class WarehouseApi : IBaseApi<Warehouse>
    {
        private readonly HttpClient httpClient = new();
        private readonly LocalStorage localStorage = new();

        public List<Warehouse> GetAll(string? search = null)
        {
            var builder = new UriBuilder("http://localhost:5000/api/warehouse");

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["search"] = search;
            builder.Query = query.ToString();

            var url = builder.ToString();

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = httpClient.SendAsync(request).Result;

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Warehouse>>(json);
        }

        public void Add(CreateWarehouseDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Post, $"http://localhost:5000/api/warehouse");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Update(int id, CreateWarehouseDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Put, $"http://localhost:5000/api/warehouse/{id}");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Delete(int id)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Delete, $"http://localhost:5000/api/warehouse/{id}");

            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }
    }
}
