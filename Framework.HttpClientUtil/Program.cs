using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;

namespace Framework.HttpClientUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://10.236.198.173:8101/User/Login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/problem+json");
            var body = @"{
" + "\n" +
            @"    ""LoginName"":""MASSVSC"",
" + "\n" +
            @"    ""Password"":""123"",
" + "\n" +
            @"    ""DeviceId"":""""
" + "\n" +
            @"}";
            request.AddParameter("application/problem+json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadLine();
        }

        
    }
}
