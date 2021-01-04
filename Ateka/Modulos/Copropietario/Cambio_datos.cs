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
    public partial class Cambio_datos : Form
    {
        public Cambio_datos(Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Unidad_smi.Text = "Unidad " + persona.RecibirUnidad();
            Comunidad_smi.Text = persona.Recibircomunidad();
            Porcentaje_lbl.Text = persona.RecibirPorcentaje() + "%";
            Monto_actual_lbl.Text = persona.RecibirActual();
            Monto_anterior_lbl.Text = persona.RecibirAnterior();
            Llenar_datos();
        }
        Persona persona = new Persona();
        Conector con = new Conector();

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            con.Registro_general_update(con.Recibir_id_unidad(persona.RecibirUnidad(), persona.Recibircomunidad_int()));
            Application.Exit();
        }

        private void Llenar_datos()
        {
            Nombre_txt.Text = persona.Recibirnombre();
            Primer_txt.Text = persona.Recibirprimerapellido();
            Segundo_txt.Text = persona.Recibirsegundoapellido();
            Telefono_txt.Text = persona.Recibirtelefono() + "";
            Comuna_txt.Text = persona.RecibirComuna();
            Direccion_txt.Text = persona.RecibirDireccion();
            Correo_txt.Text = persona.Recibircorreo();
        }

        private void Modificar()
        {
            try
            {
                bool posicion = Correo_txt.Text.Contains("@");
                if (Telefono_txt.Text.Length == 9 && posicion)
                {
                    if (!Nombre_txt.Text.Equals("") && !Primer_txt.Text.Equals("") && !Segundo_txt.Text.Equals("") &&
                        !Comuna_txt.Text.Equals("") && !Direccion_txt.Text.Equals("") && !Correo_txt.Text.Equals(""))
                    {
                        Persona nueva = new Persona();
                        nueva.Ingresarnombre(Nombre_txt.Text);
                        nueva.Ingresarprimerapellido(Primer_txt.Text);
                        nueva.Ingresarsegundoapellido(Segundo_txt.Text);
                        nueva.Ingresartelefono(Convert.ToInt32(Telefono_txt.Text));
                        nueva.IngresarComuna(Comuna_txt.Text);
                        nueva.IngresarDireccion(Direccion_txt.Text);
                        nueva.Ingresarcorreo(Correo_txt.Text);
                        nueva.Ingresarrut(persona.Recibirrut());
                        nueva.Ingresarrdv(persona.Recibirdv());
                        con.Cambios_datos(nueva);
                        persona.Ingresarnombre(Nombre_txt.Text);
                        persona.Ingresarprimerapellido(Primer_txt.Text);
                        persona.Ingresarsegundoapellido(Segundo_txt.Text);
                        persona.Ingresartelefono(Convert.ToInt32(Telefono_txt.Text));
                        persona.IngresarComuna(Comuna_txt.Text);
                        persona.IngresarDireccion(Direccion_txt.Text);
                        persona.Ingresarcorreo(Correo_txt.Text);
                        Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
                        MessageBox.Show("Datos Cambiados Correctamente", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Complete todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingrese Numero de Telefono o Correo Valido", "Error al Modificar Los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese Numero de Telefono", "Error al Modificar Los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar_txt_Click(object sender, EventArgs e)
        {
            Modificar();
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
    }
}
