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
    public partial class Cierremes : Form
    {
        bool bloqueado = true;
        public Cierremes(Persona persona,Comunidad comunidad)
        {
            InitializeComponent();
            this.persona = persona;
            this.comunidad = comunidad;
            Nombre_smi.Text = persona.Recibirnombre() + " " + persona.Recibirprimerapellido() + " " + persona.Recibirsegundoapellido();
            Cargo_smi.Text = comunidad.Recibircargo();
            Comunidad_smi.Text = comunidad.Recibirnombre();
            Titulo_lbl.Text = Titulo_lbl.Text.Replace("$nombre", Nombre_smi.Text);
            Direccion2_lbl.Text = comunidad.Recibirdireccion();
            Tipo_comunidad_lbl.Text = comunidad.RecibirTipo();
            Tipo_comunidad2_lbl.Text = comunidad.Recibirnombre();
            Mts2_lbl.Text = comunidad.RecibirSuperficie() + " Mts";
            Comuna_lbl.Text = comunidad.Recibircomuna();
        }
        Persona persona = new Persona();
        Comunidad comunidad = new Comunidad();
        Conector con = new Conector();

        private void button1_Click(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                bloqueado = false;
                int suma = 0;
                int montoanterior = con.UlitmaColilla();
                DataTable egresos = con.Egresos_vacios(19);
                int[] egreso = new int[egresos.Rows.Count];
                for (int i = 0; i < egresos.Rows.Count; i++)
                {
                    suma = suma + Convert.ToInt32(egresos.Rows[i][1]);
                    egreso[i] = Convert.ToInt32(egresos.Rows[i][0]);
                }
                con.ColillaGen(suma, montoanterior);
                int colillagen = Convert.ToInt32(con.Egresos_vacios(18).Rows[0][0]);
                for (int i = 0; i < egreso.Length; i++)
                {
                    con.UpdateEgresos(colillagen, egreso[i]);
                }
                DataTable cargos = con.Egresos_vacios(20);
                DataTable unidad = con.Unidades(comunidad.Recibircomunidad_int());
                int suma2 = 0;
                int[,] sumacargo = new int[unidad.Rows.Count, 2];
                for (int i = 0; i < unidad.Rows.Count; i++)
                {
                    suma2 = 0;
                    sumacargo[i, 0] = Convert.ToInt32(unidad.Rows[i][0]);
                    for (int f = 0; f < cargos.Rows.Count; f++)
                    {
                        if (Convert.ToInt32(unidad.Rows[i][0]) == Convert.ToInt32(cargos.Rows[f][3]))
                        {
                            suma2 = suma2 + Convert.ToInt32(cargos.Rows[f][1]) - Convert.ToInt32(cargos.Rows[f][2]);
                        }
                    }
                    sumacargo[i, 1] = suma2;
                }

                for (int i = 0; i < unidad.Rows.Count; i++)
                {
                    con.CargoTotal(sumacargo[i, 1], sumacargo[i, 0]);
                }

                DataTable cargos2 = con.Egresos_vacios(22);

                for (int i = 0; i < cargos2.Rows.Count; i++)
                {
                    con.Update_cargos(Convert.ToInt32(cargos2.Rows[i][0]), Convert.ToInt32(cargos2.Rows[i][1]));
                }

                for (int i = 0; i < cargos2.Rows.Count; i++)
                {
                    int prorrateo = Convert.ToInt32(suma * Convert.ToDouble(cargos2.Rows[i][2]) / 100);
                    con.Crearcolillas(colillagen, prorrateo, Convert.ToInt32(cargos2.Rows[i][1]), Convert.ToInt32(cargos2.Rows[i][0]));
                }
                MessageBox.Show("Cierre de Mes creado correctamnete", "Cierre de mes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloqueado = true;
            }
            
        }

        private void Inicio_smi_Click(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                Inicio inicio = new Inicio(persona, comunidad);
                inicio.Show();
                this.Close();
            }
            

        }

        private void Cerrar_sesion_smi_Click(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                Application.Exit();
            }
            
        }

        private void agregarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                Proveedores proveedore = new Proveedores(persona, comunidad);
                proveedore.Show();
                this.Close();
            }
            
        }

        private void revisarColillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                Egresos egreso = new Egresos(persona, comunidad);
                egreso.Show();
                this.Close();
            }
            
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                Crear_egreso_cs egreso = new Crear_egreso_cs(persona, comunidad);
                egreso.Show();
                this.Close();
            }
            
        }

        private void ingresarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bloqueado)
            {
                Crear_cargo crear = new Crear_cargo(persona, comunidad);
                crear.Show();
                this.Close();
            }
           
        }
    }
}
