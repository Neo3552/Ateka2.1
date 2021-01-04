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
    public partial class Egres : Form
    {
        public Egres(Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
            Periodos();
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Unidad_smi.Text = "Unidad " + persona.RecibirUnidad();
            Comunidad_smi.Text = persona.Recibircomunidad();
            Monto_actual_lbl.Text = persona.RecibirActual();
            Monto_anterior_lbl.Text = persona.RecibirAnterior();
        }
        Persona persona = new Persona();
        Conector con = new Conector();
        Strings palabras = new Strings();

        private void Periodos()
        {
            Periodo_cbx.DataSource = con.Periodos();
            Periodo_cbx.ValueMember = "Id";
            Periodo_cbx.DisplayMember = "Periodo";
        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            con.Registro_general_update(con.Recibir_id_unidad(persona.RecibirUnidad(), persona.Recibircomunidad_int()));
            Application.Exit();
        }

        private void Periodo_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = -1;
            try
            {
                numero = Convert.ToInt32(Periodo_cbx.SelectedValue.ToString());
            }
            catch
            {
                numero = 0;
            }

            int select = 10;
            if (numero == 0)
            {
                select = 5;
            }
            DataTable[] datos = con.Egresos_copropietario(100, select, numero);
            Egreso_dgv.DataSource = datos[0];
            Dewcrpcion_egreso_gbx.DataSource = datos[1];
            Monto_dgb.DataSource = datos[2];
            int monto = 0;
            if (!datos[2].Rows[0][0].ToString().Equals("Egresos"))
            {
                for (int i = 0; i < datos[2].Rows.Count; i++)
                {
                    monto = monto + Convert.ToInt32(datos[2].Rows[i][0].ToString().Replace("$", "")
                        .Replace(".", ""));
                }
            }
            Total_egresos_lbl.Text = palabras.RetornoTextos(2).Replace("%monto", monto.ToString("C", CultureInfo.CurrentCulture));
        }

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio(persona);
            form.Show();
            this.Close();
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void revisarColillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Princial form = new Princial(persona);
            form.Show();
            this.Close();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioContrasena form = new CambioContrasena(persona);
            form.Show();
            this.Close();
        }

        private void Datos_unidad_smi_Click(object sender, EventArgs e)
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
