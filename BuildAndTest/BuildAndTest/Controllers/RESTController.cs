using BuildAndTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BuildAndTest.Controllers
{
    public class RESTController : ApiController
    {
        [HttpPost]
        public int Get()
        {
            BusinessModel bus = new BusinessModel();
            return bus.GetTheIdValue();
        }
        [HttpPost]
        public List<string> GetList(int Id)
        {
            return new List<string> {
                "Data1",
                "Data2"
            };
        }
    }
}
