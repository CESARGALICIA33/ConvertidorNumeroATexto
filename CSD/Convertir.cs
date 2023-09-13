using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertidorNumeroATexto.CSD
{
    public class Convertir
    {
        //creamos una funcion de tipo ulong el cual es un tipo de long sin simbolo
        //con el parametro de tipo ulong llamado numero
        public string NumeroToLetras(ulong Numero)
        {  //variable de dara respuesta
            string respuesta;
            NumberConversion.NumberConversionSoapTypeClient oConvNum = new NumberConversion.NumberConversionSoapTypeClient("NumberConversionSoap");
           //asignamos a respuesta el valor de la operacion numero a palabras con el parametro numero
            respuesta = oConvNum.NumberToWords(Numero);

            return respuesta;

        }

        public string NumeroToLetrasDolar(decimal Numero) {

            string respuesta;
            NumberConversion.NumberConversionSoapTypeClient oConvNum = new NumberConversion.NumberConversionSoapTypeClient("NumberConversionSoap");
            //asignamos a respuesta el valor de la operacion numero a palabras con el parametro numero
            respuesta = oConvNum.NumberToDollars(Numero);

            return respuesta;

        }
    }
}