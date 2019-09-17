using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FINALKAHPROJECT.Auth
{
    public class AuthFailureResult
    {
        private string v;
        private HttpRequestMessage request;

        public AuthFailureResult(string v, HttpRequestMessage request)
        {
            this.v = v;
            this.request = request;
        }
    }
}
