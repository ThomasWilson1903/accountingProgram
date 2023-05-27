using DiplomaOborotovIS.data.api.model.employee;
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

namespace accountingProgram.data.api.employee
{
    internal class EmployeeApi
    {
        private readonly HttpClient httpClient = new();
        private readonly LocalStorage localStorage = new();

        public List<Employee> GetAll(string? search = null)
        {
            var builder = new UriBuilder("http://localhost:5000/api/Employee");

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["search"] = search;
            builder.Query = query.ToString();

            var url = builder.ToString();

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = httpClient.SendAsync(request).Result;

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Employee>>(json);
        }

        public void Add(CreateEmployeeDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Post, $"http://localhost:5000/api/Employee");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Update(int id, UpdateEmployeeDto body)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Put, $"http://localhost:5000/api/Employee/{id}");

            request.Content = JsonContent.Create(body);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }

        public void Delete(int id)
        {
            var token = localStorage.Get<AuthResponse>("token").Access_token;

            var request = new HttpRequestMessage(HttpMethod.Delete, $"http://localhost:5000/api/Employee/{id}");

            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");

            var response = httpClient.SendAsync(request).Result;
        }
    }
}
