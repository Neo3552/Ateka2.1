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

namespace Ateka.Modulos.Administrador
{
    public partial class Egresos : Form
    {
        public Egresos(Persona persona, Comunidad comunidad)
        {
            InitializeComponent();
            Periodos();
            this.persona = persona;
            this.comunidad = comunidad;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Cargo_smi.Text = comunidad.Recibircargo();
            Comunidad_smi.Text = comunidad.Recibirnombre();
            //llenar();
        }

        Conector con = new Conector();
        Persona persona = new Persona();
        Comunidad comunidad = new Comunidad();
        Strings palabras = new Strings();

        private void Periodos()
        {
            Periodo_cbx.DataSource = con.Periodos();
            Periodo_cbx.ValueMember = "Id";
            Periodo_cbx.DisplayMember = "Periodo";
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
            int cantidad = 0;
            if (!datos[2].Rows[0][0].ToString().Equals("Egresos"))
            {
                for (int i = 0; i < datos[2].Rows.Count; i++)
                {
                    monto = monto + Convert.ToInt32(datos[2].Rows[i][0].ToString().Replace("$", "")
                        .Replace(".", ""));
                    cantidad++;
                }
            }
            llenar();
            Total_egresos_lbl.Text = palabras.RetornoTextos(2).Replace("%monto", monto.ToString("C", CultureInfo.CurrentCulture));
            Monto_actual_lbl.Text = cantidad+"";
        }


        public void llenar()
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
            DataTable[] datos = con.Cargos_Admin(numero, comunidad.Recibircomunidad_int());
            Cargo_dgv.DataSource = datos[0];
            Descripcion_dgv.DataSource = datos[1];
            Monto_dgv.DataSource = datos[2];
            dataGridView1.DataSource = datos[3];
            int monto2 = 0;
            int cantidad = 0;
            if (!datos[3].Rows[0][0].ToString().Equals("Fecha"))
            {
                for (int i = 0; i < datos[3].Rows.Count; i++)
                {
                    monto2 = monto2 + Convert.ToInt32(datos[3].Rows[i][0].ToString().Replace("$", "")
                        .Replace(".", ""));
                    cantidad++;
                }
            }
            
            Total_cargo_lbl.Text = palabras.RetornoTextos(2).Replace("%monto", monto2.ToString("C", CultureInfo.CurrentCulture));
            Monto_anterior_lbl.Text = cantidad + "";
        }

        private void agregarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores(persona, comunidad);
            proveedores.Show();
            this.Close();
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_egreso_cs crear = new Crear_egreso_cs(persona, comunidad);
            crear.Show();
            this.Close();
        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_cargo cargo = new Crear_cargo(persona, comunidad);
            cargo.Show();
            this.Close();
        }

        private void cerrarMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cierremes cierre = new Cierremes(persona, comunidad);
            cierre.Show();
            this.Close();
        }

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(persona, comunidad);
            inicio.Show();
            this.Close();
        }
    }
}
