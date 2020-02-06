using System;
using System.Web;
using System.Linq;
using PicoYplaca.Common;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PicoYplaca.Models
{
    public class PicoPlacaModel
    {
        [DisplayName("Placa")]
        [StringLength(7, ErrorMessage = Constants.MaxLengthFieldMessage)]
        [RegularExpression(@"^[A-Z]{3}[0-9]{3,4}$", ErrorMessage = Constants.PlateFieldMesage)]
        [Required(ErrorMessage = Constants.RequiredFieldMessage)]
        public string Plate { get; set; }

        [CheckDateRange]
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