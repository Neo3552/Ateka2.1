using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ateka
{
    public class Persona
    {
        int rut;
        string dv;
        string nombre;
        string primerapellido;
        string segundoapellido;
        string correo;
        int telefono;
        int unidadHabitacional;
        string comunidad;
        int Comunidadint;
        string pago_actual;
        string pagoAnterior;
        double porrateo;
        string comuna;
        string direccion;

        public void Ingresarrut(int rut) => this.rut = rut;
        public void Ingresarrdv(string dv) => this.dv = dv;
        public void Ingresarnombre(string nombre) => this.nombre = nombre;
        public void Ingresarprimerapellido(string primerapellido) => this.primerapellido = primerapellido;
        public void Ingresarsegundoapellido(string segundoapellido) => this.segundoapellido = segundoapellido;
        public void Ingresarcorreo(string correo) => this.correo = correo;
        public void Ingresarunidad(int unidadHabitacional) => this.unidadHabitacional = unidadHabitacional;
        public void Ingresarcomunidad(string comunidad) => this.comunidad = comunidad;
        public void Ingresarcomunidad_int(int Comunidadint) => this.Comunidadint = Comunidadint;
        public void Ingresartelefono(int telefono) => this.telefono = telefono;
        public void IngresarPago_actual(string pago_actual) => this.pago_actual = pago_actual;
        public void IngresarPago_anterior(string pagoAnterior) => this.pagoAnterior = pagoAnterior;
        public void IngresarPorrateo(double porrateo) => this.porrateo = porrateo;
        public void IngresarComuna(string comuna) => this.comuna = comuna;
        public void IngresarDireccion(string direccion) => this.direccion = direccion;


        public int Recibirrut() => rut;
        public string Recibirdv() => dv;
        public string Recibirnombre() => nombre;
        public string Recibirprimerapellido() => primerapellido;
        public string Recibirsegundoapellido() => segundoapellido;
        public string Recibircorreo() => correo;
        public int RecibirUnidad() => unidadHabitacional;
        public string Recibircomunidad() => comunidad;
        public int Recibircomunidad_int() => Comunidadint;
        public int Recibirtelefono() => telefono;
        public string RecibirActual() => pago_actual;
        public string RecibirAnterior() => pagoAnterior;
        public double RecibirPorcentaje() => porrateo;
        public string RecibirComuna() => comuna;
        public string RecibirDireccion() => direccion;
    }
}
