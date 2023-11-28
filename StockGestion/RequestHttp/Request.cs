using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using StockGestion.Filters;

namespace StockGestion
{

    public static class Request
    {
        public static async Task<string> GetAsync(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(Token.token);
               
                HttpResponseMessage res = await client.GetAsync(url);
                HttpContent content = res.Content;
                return await content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                throw new RequestException("Erreur lors de la connexion au server");
            }

        }

        public static async Task<string> PostAsync(string url, List<KeyValuePair<string, string>> list)
        {

            try
            {
                HttpClient client = new HttpClient();

                HttpContent content = new FormUrlEncodedContent(list);
                HttpResponseMessage res = await client.PostAsync(url, content);
                content = res.Content;

                return await content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                throw new RequestException("Erreur lors de la connexion au server");
            }

        }

        public static async Task<string> PutAsync(string url, List<KeyValuePair<string, string>> list)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpContent content = new FormUrlEncodedContent(list);
                HttpResponseMessage res = await client.PutAsync(url, content);
                content = res.Content;

                return await content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                throw new RequestException("Erreur lors de la connexion au server");
            }

        }
        public static async Task<string> DeleteAsync(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage res = await client.DeleteAsync(url);
                HttpContent content = res.Content;
                return await content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                throw new RequestException("Erreur lors de la connexion au server");
            }

        }

        public static string Get(string url)
        {
            Task<string> task = Task.Run<string>(() =>
            {
                return GetAsync(url);
            });
            return task.Result;
        }

        public static string Delete(string url)
        {
            Task<string> task = Task.Run<string>(() =>
            {
                return DeleteAsync(url);
            });
            return task.Result;
        }

        public static string Post(string url, List<KeyValuePair<string, string>> list)
        {
            Task<string> task = Task.Run<string>(() =>
            {
                return PostAsync(url, list);
            });
            return task.Result;
        }

        public static string Put(string url, List<KeyValuePair<string, string>> list)
        {
            Task<string> task = Task.Run<string>(() =>
            {
                return PutAsync(url, list);
            });
            return task.Result;
        }
    }
}
