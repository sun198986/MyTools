using System;
using System.IO;
using System.Net.Http;

namespace Framework.HttpClientUtil
{
    public class HttpClientCommit
    {
        public string PostFormFilesAndParam(string requestUri,string path,params string[] para)
        {
            string result = "";
            using (HttpClient client = new HttpClient())
            {
                var content = new MultipartFormDataContent();

                //添加字符串参数，参数名为qq
                //content.Add(new StringContent("123456"), "qrCodeStr");
                //content.Add(new StringContent("孙士杰"), "auditor");

                //添加文件参数，参数名为files，文件名为123.png
                content.Add(new ByteArrayContent(System.IO.File.ReadAllBytes(path)), "fileName", "test.docx");

                var response = client.PostAsync(requestUri, content).Result;
                var headers = response.Headers;

                result = response.Content.ReadAsStringAsync().Result;

                Console.WriteLine(result);
                Console.ReadLine();
            }

            return result;
        }
    }
}
