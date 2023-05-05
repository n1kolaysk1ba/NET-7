using System.Collections.Generic;
using System.Net;

namespace ConsoleApp5
{
    public class ApiResponse<T>
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public List<T> Data { get; set; }
    }
}