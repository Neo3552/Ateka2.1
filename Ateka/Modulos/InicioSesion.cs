using Ateka.Clases;
using Ateka.Modulos.Copropietario;
using Ateka.Modulos.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ateka
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            Nombre_lbl.Text= palabras.RetornoTextos(0);
            Llenar();
        }

        Conector con = new Conector();
        Strings palabras = new Strings();
        Encriptacioncs md5 = new Encriptacioncs();
        verificadorderut verificador = new verificadorderut();
        int ubicacion = 0;

        private void coproietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nombre_txt.Text = "";
            Contrasena_txt.Text = "";
            Guion_lbl.Visible = Dv_txt.Visible = Dv_txt.Enabled = false;
            Nombre_lbl.Text= palabras.RetornoTextos(0);
            Nombre_txt.MaxLength = 32767;
            ubicacion = 0;
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nombre_txt.Text = "";
            Contrasena_txt.Text = "";
            Guion_lbl.Visible = Dv_txt.Visible = Dv_txt.Enabled = true;
            Nombre_lbl.Text = palabras.RetornoTextos(1);
            Nombre_txt.MaxLength = 8;
            ubicacion = 1;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Llenar()
        {
            DataTable dato = con.Inicio();
            Comunidad_cbx.DisplayMember = "Nombre";
            Comunidad_cbx.ValueMember = "Id_comunidad";
            Comunidad_cbx.DataSource = dato;
            if (dato.Rows.Count == 0)
            {
                MessageBox.Show("Hubo problema con su conexion a internet o con la Base de Datos", "Error en la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            if (con.Inicio().Rows.Count == 0)
            {
                MessageBox.Show("Hubo problema con su conexion a internet o con la Base de Datos", "Error en la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ubicacion == 0)
            {
                LoginCopropietario();
            }
            else
            {
                LoginAdmistrador();
            }
            
        }

        public void LoginCopropietario()
        {
            string contrasena;
            int unidad, comunidad;
            contrasena =md5.GetMD5( Contrasena_txt.Text);
            comunidad =Convert.ToInt32(Comunidad_cbx.SelectedValue);
            try
            {
                unidad = Convert.ToInt32(Nombre_txt.Text);
                if (con.LoginCopropietario(comunidad, contrasena, unidad))
                {
                    Persona persona = new Persona();
                    persona.Ingresarunidad(unidad);
                    DataTable datos = con.Datos(comunidad, unidad);
                    persona.Ingresarnombre(datos.Rows[0][2].ToString());
                    persona.Ingresarprimerapellido(datos.Rows[0][3].ToString());
                    persona.Ingresarsegundoapellido(datos.Rows[0][4].ToString());
                    persona.Ingresarcorreo(datos.Rows[0][6].ToString());
                    persona.Ingresartelefono(Convert.ToInt32(datos.Rows[0][8].ToString()));
                    persona.Ingresarcomunidad(datos.Rows[0][9].ToString());
                    persona.Ingresarcomunidad_int(comunidad);
                    persona.IngresarPorrateo(Convert.ToDouble(datos.Rows[0][10].ToString()));
                    persona.IngresarComuna(datos.Rows[0][7].ToString());
                    persona.IngresarDireccion(datos.Rows[0][5].ToString());
                    persona.Ingresarrut(Convert.ToInt32(datos.Rows[0][0].ToString()));
                    persona.Ingresarrdv(datos.Rows[0][1].ToString());
                    Modulos.Copropietario.Inicio form = new Modulos.Copropietario.Inicio(persona);
                    Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Numero de la unidad o Contraseña no son Correctos", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese Numero De la casa o Departamento", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoginAdmistrador()
        {
            string contrasena = md5.GetMD5(Contrasena_txt.Text);
            int rut = Convert.ToInt32(Nombre_txt.Text);
            string dv = Dv_txt.Text;
            int comunidad = Convert.ToInt32(Comunidad_cbx.SelectedValue);
            Persona nueva = new Persona();
            nueva.Ingresarrut(rut);
            DataTable datos = con.Login_administrador(nueva, comunidad);
            try
            {
                if (verificador.Verificar(rut, dv))
                {
                    if (datos.Rows[0][8].ToString().Equals(contrasena))
                    {
                        DataTable comun = con.Datos_comunidad(comunidad);
                        Comunidad comunida = new Comunidad();
                        nueva.Ingresarnombre(datos.Rows[0][0].ToString());
                        nueva.Ingresarprimerapellido(datos.Rows[0][1].ToString());
                        nueva.Ingresarsegundoapellido(datos.Rows[0][2].ToString());
                        nueva.IngresarDireccion(datos.Rows[0][4].ToString());
                        nueva.IngresarComuna(datos.Rows[0][6].ToString());
                        nueva.Ingresarcorreo(datos.Rows[0][5].ToString());
                        nueva.Ingresartelefono(Convert.ToInt32(datos.Rows[0][7].ToString()));
                        nueva.Ingresarrdv(dv);
                        comunida.Ingresarcargo(datos.Rows[0][3].ToString());
                        comunida.Ingresarnombre(comun.Rows[0][1].ToString());
                        comunida.Ingresardireccion(comun.Rows[0][2].ToString());
                        comunida.Ingresarcomuna(comun.Rows[0][3].ToString());
                        comunida.IngresarTipo(comun.Rows[0][4].ToString());
                        comunida.IngresarSuperficie(Convert.ToDouble(comun.Rows[0][5].ToString()));
                        comunida.Ingresarid(comunidad);
                        Modulos.Administrador.Inicio inicio = new Modulos.Administrador.Inicio(nueva, comunida);
                        Hide();
                        inicio.Show();

                    }
                    else
                    {
                        datos = null;
                        MessageBox.Show("Rut o Contraseña no son Correctos", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Rut Valido", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                datos = null;
                MessageBox.Show("Ingrese solo Administrador o Asistente", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
