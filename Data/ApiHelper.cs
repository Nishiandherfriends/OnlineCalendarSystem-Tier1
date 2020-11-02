using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Data
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://dnp.metamate.me/"); // Here you can write the base address for simplicity
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
        }

        /*
        public async Task loadInfo()
        {
            string url = "";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Class class = await reponse.Content.ReadAsAsync<Class>();
                    return null; //return the information
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        */
    }
}