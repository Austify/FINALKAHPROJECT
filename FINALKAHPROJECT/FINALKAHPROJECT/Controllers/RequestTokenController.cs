using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FINALKAHPROJECT.Auth;

namespace FINALKAHPROJECT.Controllers
{
    public class RequestTokenController : ApiController
    {
      
        public HttpResponseMessage Get(string username,string password)
        {
            if (CheckUser(username, password))
            {
                return Request.CreateResponse(HttpStatusCode.OK,
             JwtAuthManager.GenerateJWTToken(username));
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized,
             "Invalid Request");
            }

        }

         public bool CheckUser(string username,string password)
        {
             if(username == "Test" && password == "Password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}