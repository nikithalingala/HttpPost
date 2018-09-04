using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost
{
    class HttpPosting
    {
        public async Task<string> PostHttpAsync()
        {
            string url = "http://www.google.com";
            HttpClient httpClient = new HttpClient();
            Task<string> getTask = httpClient.GetStringAsync(url);
            string getUrlResult = getTask.Result;
           
             return getUrlResult;
            
        }
        HttpClient http = new HttpClient();
        IEnumerator<KeyValuePair<string, string>> queries = new IEnumerator<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string,string>("query1","hello")
            };
        HttpContent q = new FormUrlEncodedContent(queries);
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.PostAsync(url);
        HttpClient content = response.Content();
        HttpContentHeaders headers = content.headers;



    }

}
