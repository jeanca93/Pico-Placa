using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PicoYplaca.Common;

namespace PicoYplaca.Models
{
    public class PicoPlacaModel
    {
        [DisplayName("Placa")]
        [StringLength(7, ErrorMessage = Constants.MaxLengthFieldMessage)]
        [RegularExpression(@"^[A-Z]{3}[0-9]{3,4}$", ErrorMessage = Constants.PlateFieldMesage)]
        [Required(ErrorMessage = Constants.RequiredFieldMessage)]
        public string Plate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha")]
        [Required(ErrorMessage = Constants.RequiredFieldMessage)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("Hora")]
        [Required(ErrorMessage = Constants.RequiredFieldMessage)]
        public DateTime TimeField { get; set; }

        [Range(0, 2359, ErrorMessage = Constants.RangeFieldMessage)]
        public int Time { get; set; }
    }
}