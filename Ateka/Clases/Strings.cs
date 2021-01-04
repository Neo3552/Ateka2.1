using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ateka.Clases
{
    class Strings
    {
        public string[] textos =
            {
                "Unidad Habitacional",    //0
                "Rut",                //1
                "Total hasta la fecha: %monto ",        //2
            };

        public string[] Mensajes =
        {
            //0
            "Cualquier duda "+"\n"+
             "o reclamo puede "+"\n"+
            "Pueden hacerla llegar "+"\n"+
            "al Administrador "+"\n"+
            "Por los siguientes Canales"+"\n"+"\n"

        };



        public string RetornoTextos(int i)
        {
            return textos[i];
        }

        public string RetornoMensaje(int i)
        {
            return Mensajes[i];
        }

    }
}
