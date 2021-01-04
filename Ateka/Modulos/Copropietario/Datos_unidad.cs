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

namespace Ateka.Modulos.Copropietario
{
    public partial class Datos_unidad : Form
    {
        public Datos_unidad(Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Unidad_smi.Text = "Unidad " + persona.RecibirUnidad();
            Comunidad_smi.Text = persona.Recibircomunidad();
            Cargar();
            Mensaje_lbl.Text = palabras.RetornoMensaje(0);
            Monto_actual_lbl.Text = persona.RecibirActual();
            Monto_anterior_lbl.Text = persona.RecibirAnterior();
        }
        Persona persona = new Persona();
        Conector con = new Conector();
        Strings palabras = new Strings();

        public void Cargar()
        {
            DataTable datos = con.Datos_unidad(persona.Recibircomunidad_int(), persona.RecibirUnidad());
            Comunidad_lbl.Text = Comunidad_lbl.Text.Replace("$con", persona.Recibircomunidad());
            Unidad_lbl.Text = Unidad_lbl.Text.Replace("$unidad", persona.RecibirUnidad()+"");
            Superficie_lbl.Text = Superficie_lbl.Text.Replace("$total", datos.Rows[0][0].ToString());
            Terraza_lbl.Text = Terraza_lbl.Text.Replace("$total", datos.Rows[0][1].ToString());
            Bodega_lbl.Text=Bodega_lbl.Text.Replace("$total", datos.Rows[0][2].ToString());
            Porcentaje_lbl.Text = Porcentaje_lbl.Text.Replace("$por", datos.Rows[0][3].ToString());
            Nombre_lbl.Text = Nombre_smi.Text;
            Telefono_lbl.Text = "Telefono :" + persona.Recibirtelefono();
            Correo_lbl.Text = persona.Recibircorreo();
        }

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio(persona);
            form.Show();
            this.Close();
        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            con.Registro_general_update(con.Recibir_id_unidad(persona.RecibirUnidad(), persona.Recibircomunidad_int()));
            Application.Exit();
        }

        private void revisarColillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Princial form = new Princial(persona);
            form.Show();
            this.Close();
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Egres form = new Egres(persona);
            form.Show();
            this.Close();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioContrasena form = new CambioContrasena(persona);
            form.Show();
            this.Close();
        }

        private void agregarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambio_datos form = new Cambio_datos(persona);
            form.Show();
            this.Close();
        }

        private void cambiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambio_datos form = new Cambio_datos(persona);
            form.Show();
            this.Close();
        }
    }
}
