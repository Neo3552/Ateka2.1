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
    public partial class Crear_cargo : Form
    {
        public Crear_cargo(Persona persona,Comunidad comunidad)
        {
            InitializeComponent();
            this.persona = persona;
            this.comunidad = comunidad;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Cargo_smi.Text = comunidad.Recibircargo();
            Comunidad_smi.Text = comunidad.Recibirnombre();
            Llenar();
            LlenarCombobox();
        }
        Conector con = new Conector();
        Persona persona = new Persona();
        Comunidad comunidad = new Comunidad();
        Strings palabras = new Strings();


        public void Llenar()
        {
            List<Tipo> lista = new List<Tipo>();
            lista.Add(new Tipo("Reserva", "Reserva"));
            lista.Add(new Tipo("Multa", "Multa"));

            DataTable datos = con.Unidades_datos(comunidad.Recibircomunidad_int());
            Unidad_cbx.DataSource = datos;
            Unidad_cbx.ValueMember = "Id_unidad";
            Unidad_cbx.DisplayMember = "Numero_unidad";
            Monto_anterior_lbl.Text = datos.Rows.Count + "";

            Tipo_cbx.DataSource = lista;
            Tipo_cbx.ValueMember = "Descripcion";
            Tipo_cbx.DisplayMember = "Nombre";
        }

        public void LlenarCombobox()
        {
            DataTable[] datos = con.Cargos_Admin(0, comunidad.Recibircomunidad_int());
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
            Monto_actual_lbl.Text = cantidad + "";
        }

        private void Crear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Egreso cargo = new Egreso();
                if(Convert.ToInt32(Monto_txt.Text)>0 && Convert.ToInt32(Adelantado_txt.Text)>=0 && !Descripcion_txt.Text.Equals(""))
                {
                    cargo.Ingresarmonto(Convert.ToInt32(Monto_txt.Text));
                    cargo.IngresarFecha(Convert.ToDateTime(Fecha_dtp.Text));
                    cargo.IngresarHora(Convert.ToDateTime(Hora_dtp.Text));
                    cargo.Ingresarmontopagado(Convert.ToInt32(Adelantado_txt.Text));
                    cargo.IngresarNumerDoc(Tipo_cbx.SelectedValue.ToString());
                    cargo.Ingresarrut(Convert.ToInt32(Unidad_cbx.SelectedValue));
                    cargo.IngresarAnulacion(1);
                    cargo.IngresarDescripcion(Descripcion_txt.Text);
                    con.CrearCargo(cargo);
                    LlenarCombobox();
                    MessageBox.Show("Datos Ingresado Correctamente", "Cargo Ingresado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Ingrese Todos los Datos", "Error al ingresar el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                MessageBox.Show("Ingrese Datos Correctos", "Error al ingresar el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public class Tipo
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }

            public Tipo(string name, string value)
            {
                Nombre = name;
                Descripcion = value;
            }
        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(persona, comunidad);
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
            Egresos egreso = new Egresos(persona,comunidad);
            egreso.Show();
            this.Close();
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_egreso_cs egreso = new Crear_egreso_cs(persona, comunidad);
            egreso.Show();
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
