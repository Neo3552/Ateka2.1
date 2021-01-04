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
    public partial class Proveedores : Form
    {
        public Proveedores(Persona persona,Comunidad comunidad)
        {
            InitializeComponent();
            this.persona = persona;
            this.comunidad = comunidad;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Cargo_smi.Text = comunidad.Recibircargo();
            Comunidad_smi.Text = comunidad.Recibirnombre();
            Llenar();
        }

        Conector con = new Conector();
        Persona persona = new Persona();
        Comunidad comunidad = new Comunidad();
        Strings palabras = new Strings();
        verificadorderut verificador = new verificadorderut();

        public void Llenar()
        {
            DataTable datos = con.Proveedores_select();
            Proveedores_dgv.DataSource = datos;
            Monto_anterior_lbl.Text = datos.Rows.Count.ToString();
        }

        private void Crear_btn_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (verificador.Verificar(Convert.ToInt32(Rut_txt.Text), Dv_txt.Text))
                {
                    if (!Telefono_txt.Text.Equals("") && !Comuna_txt.Text.Equals("") && !Contacto_txt.Text.Equals("") &&
                        !Correo_txt.Text.Equals("") && !Direccion_txt.Text.Equals("") && !Giro_txt.Text.Equals("") && 
                        !Razon_txt.Text.Equals(""))
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor.Ingresarrut(Convert.ToInt32(Rut_txt.Text));
                        proveedor.Ingresardv(Dv_txt.Text);
                        proveedor.Ingresartelefono(Convert.ToInt32(Telefono_txt.Text));
                        proveedor.IngresarComuna(Comuna_txt.Text);
                        proveedor.Ingresarconmtacto(Contacto_txt.Text);
                        proveedor.IngresarCorreo(Correo_txt.Text);
                        proveedor.IngresarDireccion(Direccion_txt.Text);
                        proveedor.IngresarGiro(Giro_txt.Text);
                        proveedor.IngresarRazon(Razon_txt.Text);
                        proveedor.IngresarAnulacion(1);
                        con.IngresarProveedor(proveedor);
                        MessageBox.Show("Proveedor Ingresado Correctamente", "Ingreso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Llenar();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingrese Rut Valido", "Error al ingresar el Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Ingrese Datos Correctos", "Error al ingresar el Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void revisarColillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Egresos egreso = new Egresos(persona, comunidad);
            egreso.Show();
            this.Close();
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_egreso_cs egreso = new Crear_egreso_cs(persona, comunidad);
            egreso.Show();
            this.Close();
        }

        private void ingresarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_cargo crear = new Crear_cargo(persona, comunidad);
            crear.Show();
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
