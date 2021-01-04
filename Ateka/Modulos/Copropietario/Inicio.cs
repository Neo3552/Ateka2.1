using Ateka.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ateka.Modulos.Copropietario
{
    public partial class Inicio : Form
    {
        public Inicio(Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Unidad_smi.Text = "Unidad " + persona.RecibirUnidad();
            Comunidad_smi.Text = persona.Recibircomunidad();
            porrateo_lbl.Text = persona.RecibirPorcentaje()+"%";
            Titulo_lbl.Text = Titulo_lbl.Text.Replace("$nombre", persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido());
            Pagos();
            InicioSeccion();
        }

        Persona persona = new Persona();
        Conector con = new Conector();

        public void InicioSeccion()
        {
            con.Registro_general_insert(con.Recibir_id_unidad(persona.RecibirUnidad(), persona.Recibircomunidad_int()));
        }

        public void Pagos()
        {
            DataTable Pagoanterior = con.Cuenta_anterior(persona.RecibirUnidad(),persona.Recibircomunidad_int());
            int cuentaante = Convert.ToInt32(Pagoanterior.Rows[0][0]) + Convert.ToInt32(Pagoanterior.Rows[0][1]);
            persona.IngresarPago_anterior(cuentaante.ToString("C", CultureInfo.CurrentCulture));
            Pago_anterior_lbl.Text = persona.RecibirAnterior();
            int cuentaactaual = con.EgresoActual(persona.RecibirPorcentaje());
            cuentaactaual = cuentaactaual + con.Cargo_actual(persona.RecibirUnidad(), persona.Recibircomunidad_int());
            persona.IngresarPago_actual(cuentaactaual.ToString("C", CultureInfo.CurrentCulture));
            MontoActual_lbl.Text = persona.RecibirActual();
        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            con.Registro_general_update(con.Recibir_id_unidad(persona.RecibirUnidad(), persona.Recibircomunidad_int()));
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Actua_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Datos_gbx_Enter(object sender, EventArgs e)
        {

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

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioContrasena form = new CambioContrasena(persona);
            form.Show();
            this.Close();
        }

        private void agregarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos_unidad form = new Datos_unidad(persona);
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
