using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ateka.Clases
{
    class Egreso
    {
        int rut;
        DateTime Fecha;
        DateTime Hora;
        string NumerDoc;
        string Descripcion;
        int Anulacion;
        int Monto;
        int MontoPagado;

        public void Ingresarrut(int rut) => this.rut = rut;
        public void IngresarFecha(DateTime Fecha) => this.Fecha = Fecha;
        public void IngresarHora(DateTime Hora) => this.Hora = Hora;
        public void IngresarNumerDoc(string NumerDoc) => this.NumerDoc = NumerDoc;
        public void IngresarDescripcion(string Descripcion) => this.Descripcion = Descripcion;
        public void IngresarAnulacion(int Anulacion) => this.Anulacion = Anulacion;
        public void Ingresarmonto(int Monto) => this.Monto = Monto;
        public void Ingresarmontopagado(int MontoPagado) => this.MontoPagado = MontoPagado;

        public int Recibirrut() => rut;
        public DateTime RecibirFecha() => Fecha;
        public DateTime RecibirHora() => Hora;
        public string RecibirNumeroDoc() => NumerDoc;
        public string RecibirDescripcion() => Descripcion;
        public int RecibirAnulacion() => Anulacion;
        public int RecibirMonto() => Monto;
        public int RecibirMontopagado() => MontoPagado;
    }
}
