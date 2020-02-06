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
            PicoPlataValidateDto validate = new PicoPlataValidateDto()
            {
                Message = "Placa vehicular se encuentra en un horario permitido"
            };

            if (!ModelState.IsValid)
            {
                var errors = string.Join(Environment.NewLine, ModelState.Values
                    .SelectMany(x => x.Errors)
                    .Select(x => string.Concat("- ", x.ErrorMessage)));

                return BadRequest(errors);
            }

            try
            {
                var authorized = false;
                var timeRange1 = new Tuple<int, int>(700, 930);
                var timeRange2 = new Tuple<int, int>(1600, 1930);
                authorized = (picoPlaca.Date.DayOfWeek == DayOfWeek.Saturday || picoPlaca.Date.DayOfWeek == DayOfWeek.Sunday);

                if (!authorized)
                {
                    var lastDigit = -1;
                    var isNumeric = false;
                    var lastCharacter = picoPlaca.Plate.Substring(picoPlaca.Plate.Length - 1);

                    isNumeric = int.TryParse(lastCharacter, out lastDigit);

                    if (isNumeric)
                    {
                        int from = 1, to = 10;
                        var dateDayOfWeek = (int) picoPlaca.Date.DayOfWeek;

                        to = (dateDayOfWeek + 1);
                        from = (dateDayOfWeek + (dateDayOfWeek - 1));

                        if (lastDigit == 0)
                            lastDigit = 10;

                        authorized = (!Enumerable.Range(from, (to - from)).Contains(lastDigit));

                        if (!authorized)
                        {
                            authorized = (!(Enumerable.Range(timeRange1.Item1, (timeRange1.Item2 - timeRange1.Item1))
                                                .Contains(picoPlaca.Time) || Enumerable.Range(timeRange2.Item1,
                                                    (timeRange2.Item2 - timeRange2.Item1))
                                                .Contains(picoPlaca.Time)));

                            if (!authorized)
                                validate = new PicoPlataValidateDto()
                                {
                                    Valid = false,
                                    Message = "Placa vehicular se encuentra en un horario restringido"
                                };
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Ok(validate);
        }
    }
}
