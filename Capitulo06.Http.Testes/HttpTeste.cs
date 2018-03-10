using System;
using System.IO;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capitulo06.Http.Testes
{
    [TestClass]
    public class HttpTeste
    {
        [TestMethod]
        public void RequestGetMethodTeste()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.example.com?nome=Vitor&cpf=123");
            request.Method = "GET";
            request.Date = DateTime.Now;
            request.UserAgent = "Visual Studio";

            Console.WriteLine(GetResquestToString(request));

            Console.WriteLine(new string('-', 100));

            Console.WriteLine("Query string:" + request.RequestUri.Query);

            Console.WriteLine(new string('-', 100));

            var response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(GetResquestToString(response));
        }

        [TestMethod]
        public void RequestPostMethodTeste()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://httpbin.org/post");
            request.Method = "POST";

            var dados = "placa = ABC1234&ano=2014&modelo=Fiesta";
            var bytes = new System.Text.ASCIIEncoding().GetBytes(dados);

            request.ContentType = "aplication/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;
            request.GetRequestStream().Write(bytes, 0, bytes.Length);


            Console.WriteLine(GetResquestToString(request,dados));

            Console.WriteLine(new string('-', 100));

            var response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(GetResquestToString(response));
        }

        private string GetResquestToString(HttpWebResponse response)
        {
            var statusLine = $"HTTP/{response.ProtocolVersion} {(int)response.StatusCode} { response.StatusDescription}";
            var reader = new StreamReader(response.GetResponseStream());


            return statusLine +
            Environment.NewLine +
            GetHeaders(response.Headers) +
            Environment.NewLine +
            reader.ReadToEnd();
        }

        private string GetResquestToString(HttpWebRequest request,string dados ="")
        {
            var requestLine = $"{request.Method} {request.RequestUri} HTTP/1.1";

            return requestLine +
                Environment.NewLine +
                GetHeaders(request.Headers);
        }

        private string GetHeaders(WebHeaderCollection header)
        {
            var headers = "";

            foreach (var key in header.AllKeys)
            {
                headers += $"{key}: {header[key]}" + Environment.NewLine;
            }

            return headers;
        }
    }
}
