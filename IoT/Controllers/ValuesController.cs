using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoT.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            string returnedValue = "";
            WebRequest wrGeturl = WebRequest.Create("http://192.168.2.15:1337/getvalues");

            var responseStream = wrGeturl.GetResponse().GetResponseStream();
            if (responseStream==null)
            {
                throw new Exception("Response stream from edison is null.");
            }

            using (var sr = new StreamReader(responseStream))
            {
                returnedValue = sr.ReadToEnd();
            }
            return returnedValue;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
