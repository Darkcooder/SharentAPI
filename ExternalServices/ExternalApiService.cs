using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.ExternalServices
{
    public class ExternalApiService
    {
        private IRestClient restClient;

        public ExternalApiService()
        {
            restClient = new RestClient();
        }

        protected async Task<O> SendJsonRequest<O>(string url, object requestBody, Method method = Method.GET, NameValueCollection headerparams = null)
        {
            var request = new RestRequest(url, method);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Accept", "application/json;charset=utf-8");
            request.AddHeader("Content-Type", "application/json;charset=utf-8");

            if(headerparams != null)
            {
                foreach (var i in headerparams.AllKeys)
                {
                    request.AddHeader(i, headerparams[i]);
                }
            }

            if (requestBody != null)
            {
                if(method == Method.POST || method == Method.PUT) request.AddJsonBody(requestBody);
                if(method == Method.GET || method == Method.DELETE)
                {
                    foreach (var property in requestBody.GetType().GetProperties())
                    {
                        request.AddQueryParameter(property.Name, property.GetValue(requestBody).ToString());
                    }
                }
            }

            var responce = await restClient.ExecuteGetTaskAsync(request);
            var content = responce.Content;
            if (string.IsNullOrWhiteSpace(content))
            {
                content = "{}";
            }

            return JsonConvert.DeserializeObject<O>(content);
        }
    }
}
