using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace DHSolutionsWeb
{
    public static class HTTPClientSingelton
    {

        public static HttpClient client = new HttpClient();

        static HTTPClientSingelton()
        {
            client.BaseAddress = new Uri("http://localhost:51819/api/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}