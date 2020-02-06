using System;
using System.Web;
using System.Linq;
using PicoYplaca.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PicoYplaca.Dtos
{
    public class PicoPlacaDto
    {
        [StringLength(7, ErrorMessage = Constants.MaxLengthFieldMessage)]
        [RegularExpression(@"^[A-Z]{3}[0-9]{3,4}$", ErrorMessage = Constants.PlateFieldMesage)]
        [Required(ErrorMessage = Constants.RequiredFieldMessage)]
        public string Plate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = Constants.RequiredFieldMessage)]
        public DateTime Date { get; set; }

        [Range(0, 2359, ErrorMessage = Constants.RangeFieldMessage)]
        public int Time { get; set; }
    }
}