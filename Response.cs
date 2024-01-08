using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQL
{
   public class Response
    {
        public Response(bool success, string httpstatus, HttpResponseMessage message=null, string json=null) 
        { 
        this.Success=success;
        this.HttpStatus=httpstatus;
         this.Message=message;
        this.JSON =json;

        }


        public bool Success { get; set; }
        public string HttpStatus { get; set; }
        public HttpResponseMessage Message { get; set; }
        public string JSON { get; set; }

    }
}
