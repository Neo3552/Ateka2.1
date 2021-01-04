using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ateka.Clases
{
    public class Comunidad
    {
        string direccion;
        string comuna;
        int id;
        string nombre;
        string tipo_comunidad;
        string cargo;
        double superficie;

        public void Ingresardireccion(string direccion) => this.direccion = direccion;
        public void Ingresarcomuna(string comuna) => this.comuna = comuna;
        public void Ingresarid(int id) => this.id = id;
        public void Ingresarnombre(string nombre) => this.nombre = nombre;
        public void IngresarTipo(string tipo_comunidad) => this.tipo_comunidad = tipo_comunidad;
        public void IngresarSuperficie(double superficie) => this.superficie = superficie;
        public void Ingresarcargo(string cargo) => this.cargo = cargo;

        public string Recibirdireccion() => direccion;
        public string Recibircomuna() => comuna;
        public int Recibircomunidad_int() => id;
        public string Recibirnombre() => nombre;
        public string RecibirTipo() => tipo_comunidad;
        public double RecibirSuperficie() => superficie;
        public string Recibircargo() => cargo;
    }
}
