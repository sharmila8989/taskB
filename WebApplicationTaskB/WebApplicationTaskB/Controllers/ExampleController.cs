﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationTaskB.Controllers
{
    public class ExampleController : ApiController
    {
        // GET: api/Example
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Example/5
       // public string Get(int id)
        //{
            //return "value";
       // }

        
    }
}
