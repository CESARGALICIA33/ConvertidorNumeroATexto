using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConvertidorNumeroATexto.CSD; //incluir 

namespace ConvertidorNumeroATexto.CSU
{
    public partial class Conversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnLetra_Click(object sender, EventArgs e)
        {
            //llamada de la operacion

            //creamos una instancia de la clase convertir
            Convertir oConvertir = new Convertir();
            //pasamos a la caja de texto resultado utilizando la funcion toletras convertido en tipo ulong
            TxtRespuesta.Text = oConvertir.NumeroToLetras(ulong.Parse(txtNumero.Text));
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {

            //creamos una instancia de la clase convertir
            Convertir oConvertir = new Convertir();
            //pasamos a la caja de texto resultado utilizando la funcion toletras convertido en tipo ulong
            TxtRespuesta.Text = oConvertir.NumeroToLetrasDolar(decimal.Parse(txtNumero.Text));
        }
    }
}