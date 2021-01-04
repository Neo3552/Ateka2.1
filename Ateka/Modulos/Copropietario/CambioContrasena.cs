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
    public partial class CambioContrasena : Form
    {
        public CambioContrasena (Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Unidad_smi.Text = "Unidad " + persona.RecibirUnidad();
            Comunidad_smi.Text = persona.Recibircomunidad();
            Porcentaje_lbl.Text =persona.RecibirPorcentaje()+"%";
            Monto_actual_lbl.Text = persona.RecibirActual();
            Monto_anterior_lbl.Text = persona.RecibirAnterior();
        }
        Persona persona = new Persona();
        Conector con = new Conector();
        Encriptacioncs md5 = new Encriptacioncs();

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            con.Registro_general_update(con.Recibir_id_unidad(persona.RecibirUnidad(), persona.Recibircomunidad_int()));
            Application.Exit();
        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            if (con.LoginCopropietario(persona.Recibircomunidad_int(), md5.GetMD5(Contrasena_antigua_txt.Text), persona.RecibirUnidad()))
            {
                if (Nueva_contrasena_txt.Text.Equals(Confirm_txt.Text))
                {
                    if (Nueva_contrasena_txt.Text.Equals(Contrasena_antigua_txt.Text))
                    {
                        MessageBox.Show("Contraseña Antigua y Nueva son las mismas");
                    }
                    else
                    {
                        string encriptacion = md5.GetMD5(Nueva_contrasena_txt.Text);
                        con.Cambio_contrasena(persona.Recibircomunidad_int(), encriptacion, persona.RecibirUnidad());
                        MessageBox.Show("Contraseña Cambiada Correctamente");
                        Contrasena_antigua_txt.Text = "";
                        Nueva_contrasena_txt.Text = "";
                        Confirm_txt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Error en la contraseñas");
            }
        }

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio(persona);
            form.Show();
            this.Close();
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
