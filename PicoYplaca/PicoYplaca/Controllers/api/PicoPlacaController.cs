using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PicoYplaca.Dtos;

namespace PicoYplaca.Controllers.api
{
    public class PicoPlacaController : ApiController
    {
        [HttpPost]
        [Route("api/PicoPlaca/Validate")]
        public IHttpActionResult Validate(PicoPlacaDto picoPlaca)
        {
            return Ok();
        }
    }
}
