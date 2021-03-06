﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreSample
{
    [Route("api/Values")]
    public class ValuesController : Controller
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5        
        public string Get(int id)
        {
            return "value";
        }


        [Route("fire")]
        [HttpGet]
        public string Bang()
        {
            return System.DateTime.Now.ToString();
        }


        [Route("fire2")]
        [HttpGet]
        public SomeClass Bang2()
        {
            return new SomeClass()
            {
                Number1 = 1,
                Name = "TheName"
            };
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
