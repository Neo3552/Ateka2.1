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
    public partial class Crear_egreso_cs : Form
    {
        public Crear_egreso_cs(Persona persona, Comunidad comunidad)
        {
            InitializeComponent();
            this.persona = persona;
            this.comunidad = comunidad;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Cargo_smi.Text = comunidad.Recibircargo();
            Comunidad_smi.Text = comunidad.Recibirnombre();
            Llenar();
            MostrarEgresos();
        }

        Conector con = new Conector();
        Persona persona = new Persona();
        Comunidad comunidad = new Comunidad();
        Strings palabras = new Strings();

        public void Llenar()
        {
            DataTable datos = con.Proveedores_datos();
            Proveedor_cbx.DataSource = datos;
            Proveedor_cbx.ValueMember = "Rut";
            Proveedor_cbx.DisplayMember = "RazonSocial";
            Monto_anterior_lbl.Text = datos.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void MostrarEgresos()
        {
            DataTable[] datos = con.Egresos_copropietario(100, 5, 0);
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
            Total_egresos_lbl.Text = palabras.RetornoTextos(2).Replace("%monto", monto.ToString("C", CultureInfo.CurrentCulture));
            Monto_actual_lbl.Text = cantidad + "";
        }

        private void Crear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(Monto_txt.Text)>0 && !NumDoc_txt.Text.Equals("") && !Descripcion_txt.Text.Equals(""))
                {
                    Egreso egreso = new Egreso();
                    egreso.Ingresarmonto(Convert.ToInt32(Monto_txt.Text));
                    egreso.Ingresarrut(Convert.ToInt32(Proveedor_cbx.SelectedValue));
                    egreso.IngresarAnulacion(1);
                    egreso.IngresarFecha(Convert.ToDateTime(Fecha_dtp.Text));
                    egreso.IngresarHora(Convert.ToDateTime(Hora_dtp.Text));
                    egreso.IngresarNumerDoc(NumDoc_txt.Text);
                    egreso.IngresarDescripcion(Descripcion_txt.Text);
                    con.CrearEgreso(egreso);
                    MostrarEgresos();
                    MessageBox.Show("Ingreso realizado Corectamente", "Ingreso Realizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            catch
            {
                MessageBox.Show("Ingrese datos Correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(persona,comunidad);
            inicio.Show();
            this.Close();
        }

        private void agregarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores(persona, comunidad);
            proveedores.Show();
            this.Close();
        }

        private void revisarColillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Egresos egreso = new Egresos(persona, comunidad);
            egreso.Show();
            this.Close();
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
    }
}
