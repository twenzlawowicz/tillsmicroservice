using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tillsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {

            Pen p;
            switch (id)
            {
                case "red":
                    p = Pen.CreateRedPen();
                    return p.ToJson();
                case "blue":
                    p = Pen.CreateBluePen();
                    return p.ToJson();
            }

            return "No pen";
        }


    }
}
