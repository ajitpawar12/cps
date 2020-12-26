using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPS.Infrastructure.Helpers
{
    public class CustomResponse
    {
        public CustomResponse()
        {
            Errors = new List<KeyValuePair<string, string>>();
        }
        public List<KeyValuePair<string, string>> Errors { get; set; }
        public object ResultObject { get; set; }        
        public string StatusCode { get; set; }
        public bool IsSuccess { get; set; }
    }
}