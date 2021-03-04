using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModalidadGradoSpat
{
    public class RestClient<T>
    {
        private const string webServiceUrl = "https://localhost:44398/";
        private readonly HttpClient cliente = new HttpClient();

        public async Task<T> GetAsync(int? id, string aux, string token)
        {
            using (cliente)
            {
                var url = webServiceUrl + aux;
                cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var response = cliente.GetAsync(url).Result;
                if (!response.IsSuccessStatusCode) throw new Exception(await response.Content.ReadAsStringAsync());
                //var response2 = await cliente.GetStringAsync(url);
                var taskModels = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                //return result.Content.ReadAsStringAsync().Result;
                return taskModels;
            }
        }
        public async Task<List<T>> GetAsync(string aux, string token)
        {
            using (cliente)
            {
                var url = webServiceUrl + aux;
                cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var response = await cliente.GetStringAsync(url);
                //recibe cualquier tipo de objeto del API
                //var response = await cliente.GetAsync(url);
                //var otro = response.Headers.GetValues("Pagination");
                var taskModels = JsonConvert.DeserializeObject<List<T>>(response);
                return taskModels;
            }
        }
        public async Task<T> PostAsync(T t, string aux, string token)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = httpClient.PostAsync(webServiceUrl + aux, httpContent).Result;
            if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
            var taskModels = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
            return taskModels;
        }
        public async Task<T> PostAsync(string aux, string token)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var json = "";
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = httpClient.PostAsync(webServiceUrl + aux, httpContent).Result;
            if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
            var taskModels = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
            return taskModels;
        }
        //public async Task<string> PostAsync(IEnumerable<T> t, string aux)
        //{
        //    var httpClient = new HttpClient();
        //    var json = JsonConvert.SerializeObject(t);
        //    HttpContent httpContent = new StringContent(json);
        //    httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        //    var result = await httpClient.PostAsync(webServiceUrl + aux, httpContent);
        //    if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
        //    return result.Content.ReadAsStringAsync().Result;
        //}
        public async Task<string> Login(T t, string aux)
        {
            using (cliente)
            {
                var json = JsonConvert.SerializeObject(t);
                HttpContent httpContent = new StringContent(json);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var result = await cliente.PostAsync(webServiceUrl + aux, httpContent);
                if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
                return result.Content.ReadAsStringAsync().Result;
            }
        }
        public async Task<T> PutAsync(T t, string aux)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(webServiceUrl + aux, httpContent);
            if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
            var taskModels = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
            return taskModels;
        }
        public async Task<T> PutAsync(T t, string aux, string token)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(webServiceUrl + aux, httpContent);
            if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
            var taskModels = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
            return taskModels;
        }
        public async Task<T> PutAsync(string aux)
        {
            var httpClient = new HttpClient();
            var json = "";
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(webServiceUrl + aux, httpContent);
            if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
            var taskModels = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
            return taskModels;
        }
        public async Task<string> PutAsync(string estado, string aux, string token)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(estado);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(webServiceUrl + aux, httpContent);
            if (!result.IsSuccessStatusCode) throw new Exception(result.Content.ReadAsStringAsync().Result);
            return result.Content.ReadAsStringAsync().Result;
        }
        public async Task<string> DeleteAsync(long id, string aux)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync(webServiceUrl + aux + id);
            if (!response.IsSuccessStatusCode) throw new Exception(response.Content.ReadAsStringAsync().Result);
            return response.Content.ReadAsStringAsync().Result;
        }
        public async Task<string> DeleteAsync(string aux)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync(webServiceUrl + aux);
            if (!response.IsSuccessStatusCode) throw new Exception(response.Content.ReadAsStringAsync().Result);
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
