using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ateka.Clases
{
    class Proveedor
    {
        int rut;
        string dv;
        string Razon;
        string Giro;
        int Anulacion;
        int Telefono;
        string Contacto;
        string Direccion;
        string Correo;
        string Comuna;

        public void Ingresarrut(int rut) => this.rut = rut;
        public void Ingresardv(string dv) => this.dv = dv;
        public void IngresarRazon(string Razon) => this.Razon = Razon;
        public void IngresarGiro(string Giro) => this.Giro = Giro;
        public void IngresarAnulacion(int Anulacion) => this.Anulacion = Anulacion;
        public void Ingresartelefono(int Telefono) => this.Telefono = Telefono;
        public void Ingresarconmtacto(string Contacto) => this.Contacto = Contacto;
        public void IngresarDireccion(string Direccion) => this.Direccion = Direccion;
        public void IngresarCorreo(string Correo) => this.Correo = Correo;
        public void IngresarComuna(string Comuna) => this.Comuna = Comuna;

        public int Recibirrut() => rut;
        public string Recibirdv() => dv;
        public string RecibirRazon() => Razon;
        public string RecibirGiro() => Giro;
        public int RecibirAnulacion() => Anulacion;
        public int RecibirTelefono() => Telefono;
        public string RecibirComuna() => Comuna;
        public string RecibirContacto() => Contacto;
        public string RecibirDireccion() => Direccion;
        public string RecibirCorreo() => Correo;
    }
}
