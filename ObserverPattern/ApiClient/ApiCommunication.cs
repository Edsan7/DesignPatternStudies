using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Observer.ApiClient
{
    public class ApiCommunication
    {
        private readonly HttpClient _httpClient;
        public ApiCommunication(string baseUrl)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri(baseUrl);
        }

        public async Task<T> SendGet<T>(string endPoint, Dictionary<string, string> queryParams)
        {
            try
            {
                NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);

                foreach (var dictQuery in queryParams)
                {
                    queryString.Add(dictQuery.Key, dictQuery.Value);
                }

                endPoint = string.Concat(endPoint, queryString.ToString());

                var response = await _httpClient.GetAsync(endPoint);

                if (response.IsSuccessStatusCode)
                {
                    var responseAsync = await response.Content.ReadAsStringAsync();
                    return (T)JsonSerializer.Deserialize<T>(responseAsync);
                }
            }

            catch (System.Exception)
            {
                Console.WriteLine($"Um erro ocorreu ao realizar o método Get para o a url {_httpClient.BaseAddress} - endpoint {endPoint}");
            }

            return default(T);
        }
    }
}