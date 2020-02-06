using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicoYplaca.Common
{
    public class Constants
    {
        public const string RequiredFieldMessage = "El campo {0} es requerido";
        public const string RangeFieldMessage = "El campo {0} debe ser un número entre {1} y {2}";
        public const string MaxLengthFieldMessage = "Campo {0} debe ser de máximo {1} caracteres";
        public const string PlateFieldMesage = "Formato de placa incorrecta. Ej: (PCS234)";
    }
}