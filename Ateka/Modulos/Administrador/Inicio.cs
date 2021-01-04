using Ateka.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ateka.Modulos.Administrador
{
    public partial class Inicio : Form
    {
        public Inicio(Persona persona,Comunidad comunidad)
        {
            InitializeComponent();
            this.persona = persona;
            this.comunidad = comunidad;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Cargo_smi.Text = comunidad.Recibircargo();
            Comunidad_smi.Text = comunidad.Recibirnombre();
            Titulo_lbl.Text = Titulo_lbl.Text.Replace("$nombre", Nombre_smi.Text);
            Direccion2_lbl.Text = comunidad.Recibirdireccion();
            Tipo_comunidad_lbl.Text = comunidad.RecibirTipo();
            Tipo_comunidad2_lbl.Text = comunidad.Recibirnombre();
            Mts2_lbl.Text = comunidad.RecibirSuperficie() + " Mts";
            Comuna_lbl.Text = comunidad.Recibircomuna();
        }
        Persona persona = new Persona();
        Comunidad comunidad = new Comunidad();

        private void revisarColillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Egresos egreso = new Egresos(persona,comunidad);
            egreso.Show();
            this.Close();
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_egreso_cs form = new Crear_egreso_cs(persona, comunidad);
            form.Show();
            this.Close();
        }

        private void ingresarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_cargo cargo = new Crear_cargo(persona, comunidad);
            cargo.Show();
            this.Close();
        }

        private void agregarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores(persona,comunidad);
            proveedores.Show();
            this.Close();
        }

        private void cerrarMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cierremes mes =new Cierremes(persona, comunidad);
            mes.Show();
            this.Close();
        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
