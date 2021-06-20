using System;
using System.Threading;
using RestSharp;

namespace Framework.HttpClientUtil
{
    public class HttpHelp
    {
        public async void TestPost()
        {
            var start = DateTime.Now;
            var client = new RestClient("http://10.236.198.173:8001/SpecialPriceForm/GetWaitApproveSP?OptUser=MASPYJJ&RoleId=266&Token=03062d22-e7ee-4439-afd8-368255cf280e&PageNo=1&PageItems=10");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = await client.ExecuteAsync(request);
            var ts = DateTime.Now - start;
            Console.WriteLine($"time:{ts.TotalMilliseconds},{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}