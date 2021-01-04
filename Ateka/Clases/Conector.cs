using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ateka.Clases
{
    class Conector
    {
        string hostname = "andamio.c0uqlha5mz7g.us-east-2.rds.amazonaws.com";
        string database = "Ateka";
        string id = "root";
        string password = "Rencito123";
        public MySqlConnection con;
        Query query = new Query();

        public MySqlConnection Conectarse()
        {
            MySqlConnection coneccion = new MySqlConnection("Server =" + hostname + "; Database=" + database + "; Uid=" + id + "; Pwd=" + password);
            return coneccion;
        }

        public DataTable Inicio()
        {
            try
            {
                con = Conectarse();
                DataTable Tabla = new DataTable();
                MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(0), con);
                Tabla.Clear();
                retorno.Fill(Tabla);
                con.Close();
                return Tabla;
            }
            catch
            {
                DataTable Tabla = new DataTable();
                return Tabla;
            }
            
        }

        public bool LoginCopropietario(int comunidad, string contrasena, int unidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(1)
                .Replace("$unidad", unidad + "")
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            if (Tabla.Rows[0][0].Equals(contrasena))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Datos(int comunidad, int unidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(2)
                .Replace("$unidad", unidad + "")
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public DataTable Datos_unidad(int comunidad, int unidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(3)
                .Replace("$unidad", unidad + "")
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public void Registro_general_insert(int id)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(0)
                .Replace("$id_unidad", id + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public void Registro_general_update(int id)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoUpdate(0)
                .Replace("$id_unidad", id + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public int Recibir_id_unidad(int numero, int comunidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(4)
                .Replace("$unidad", numero + "")
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Convert.ToInt32(Tabla.Rows[0][0]);
        }

        public DataTable[] Egresos_copropietario(double porcentaje, int select, int peridod)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(select)
                .Replace("$id_colilla", peridod + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            DataTable dato = new DataTable();
            DataTable dato1 = new DataTable();
            DataTable dato2 = new DataTable();
            dato.Columns.Add(" ");
            dato1.Columns.Add(" ");
            dato2.Columns.Add(" ");

            if (Tabla.Rows.Count == 0)
            {
                DataRow fila = dato.NewRow();
                DataRow fila1 = dato1.NewRow();
                DataRow fila2 = dato2.NewRow();
                fila[" "] = "No";
                fila1[" "] = "Hay";
                fila2[" "] = "Egresos";
                dato.Rows.Add(fila);
                dato1.Rows.Add(fila1);
                dato2.Rows.Add(fila2);
            }
            else
            {
                for (int i = 0; i < Tabla.Rows.Count; i++)
                {
                    DataRow fila = dato.NewRow();
                    DataRow fila1 = dato1.NewRow();
                    DataRow fila2 = dato2.NewRow();
                    fila[" "] = Tabla.Rows[i][0].ToString();
                    fila1[" "] = Tabla.Rows[i][1].ToString();
                    int x = Convert.ToInt32(((Convert.ToInt32(Tabla.Rows[i][2].ToString())) * porcentaje / 100));
                    fila2[" "] = x.ToString("C", CultureInfo.CurrentCulture);
                    dato.Rows.Add(fila);
                    dato1.Rows.Add(fila1);
                    dato2.Rows.Add(fila2);
                }
            }


            DataTable[] datos = new DataTable[3];

            datos[0] = dato;
            datos[1] = dato1;
            datos[2] = dato2;
            return datos;
        }

        public DataTable[] Cargos_copropietario(int id, int colillage, int comunidad, int select)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(select)
                .Replace("$unidad", id + "")
                .Replace("$comunidad", comunidad + "")
                .Replace("$colilla", colillage + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            DataTable dato = new DataTable();
            DataTable dato1 = new DataTable();
            DataTable dato2 = new DataTable();
            dato.Columns.Add(" ");
            dato1.Columns.Add(" ");
            dato2.Columns.Add(" ");
            if (Tabla.Rows.Count == 0)
            {
                DataRow fila = dato.NewRow();
                DataRow fila1 = dato1.NewRow();
                DataRow fila2 = dato2.NewRow();
                fila[" "] = "No";
                fila1[" "] = "Hay";
                fila2[" "] = "Cargos";
                dato.Rows.Add(fila);
                dato1.Rows.Add(fila1);
                dato2.Rows.Add(fila2);
            }
            else
            {
                for (int i = 0; i < Tabla.Rows.Count; i++)
                {
                    DataRow fila = dato.NewRow();
                    DataRow fila1 = dato1.NewRow();
                    DataRow fila2 = dato2.NewRow();
                    fila[" "] = Tabla.Rows[i][0].ToString();
                    fila1[" "] = Tabla.Rows[i][1].ToString();
                    int x = Convert.ToInt32(Tabla.Rows[i][2])- Convert.ToInt32(Tabla.Rows[i][4]);
                    fila2[" "] = x.ToString("C", CultureInfo.CurrentCulture);
                    dato.Rows.Add(fila);
                    dato1.Rows.Add(fila1);
                    dato2.Rows.Add(fila2);
                }
            }


            DataTable[] datos = new DataTable[3];

            datos[0] = dato;
            datos[1] = dato1;
            datos[2] = dato2;
            return datos;
        }

        public void Cambio_contrasena(int unidad, string contrasena, int comunidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoUpdate(1)
                .Replace("$id_unidad", comunidad + "")
                .Replace("$comunidad", unidad + "")
                .Replace("$Contrasena", contrasena), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public DataTable Periodos()
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(7), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            DataTable dato = new DataTable();
            dato.Columns.Add("Id");
            dato.Columns.Add("Periodo");
            DataRow fila0 = dato.NewRow();
            fila0["Id"] = 0;
            DateTime fecha = Convert.ToDateTime(Tabla.Rows[0][1].ToString());
            fila0["Periodo"] = fecha.ToString("MMMM") + "/" + fecha.Year.ToString();
            dato.Rows.Add(fila0);
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                DataRow fila = dato.NewRow();
                fila["Id"] = Tabla.Rows[i][2].ToString();
                DateTime fecha2 = Convert.ToDateTime(Tabla.Rows[i][0].ToString());
                fila["Periodo"] = fecha2.ToString("MMMM") + "/" + fecha2.Year.ToString();
                dato.Rows.Add(fila);
            }
            return dato;
        }

        public DataTable Cuenta_anterior(int unidad, int comunidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(8)
                .Replace("$unidad", unidad + "")
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public int EgresoActual(double porcentaje)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(5), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            int egreso = 0;
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                egreso = egreso + Convert.ToInt32(Convert.ToInt32(Tabla.Rows[i][2]) * porcentaje / 100);
            }
            return egreso;
        }

        public int Cargo_actual(int unidad, int comunidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(9)
                .Replace("$unidad", unidad + "")
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            int egreso = 0;
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                egreso = egreso + Convert.ToInt32(Tabla.Rows[i][0])- Convert.ToInt32(Tabla.Rows[i][1]);
            }
            return egreso;
        }

        public void Cambios_datos(Persona persona)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoUpdate(2)
                .Replace("$nombre", persona.Recibirnombre())
                .Replace("$primer", persona.Recibirprimerapellido())
                .Replace("$segundo", persona.Recibirsegundoapellido())
                .Replace("$direccion", persona.RecibirDireccion())
                .Replace("$correo", persona.Recibircorreo())
                .Replace("$comuna", persona.RecibirComuna())
                .Replace("$telefono", persona.Recibirtelefono() + "")
                .Replace("$rut", persona.Recibirrut().ToString()), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public DataTable Login_administrador(Persona persona, int comunidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(12)
                .Replace("$comunidad", comunidad + "")
                .Replace("$rut", persona.Recibirrut().ToString()), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public DataTable Datos_comunidad(int comunidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(13)
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }
        public DataTable[] Cargos_Admin(int colillage, int comunidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(14)
                .Replace("$comunidad", comunidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            DataTable dato = new DataTable();
            DataTable dato1 = new DataTable();
            DataTable dato2 = new DataTable();
            DataTable dato3 = new DataTable();
            dato.Columns.Add(" ");
            dato1.Columns.Add(" ");
            dato2.Columns.Add(" ");
            dato3.Columns.Add(" ");
            if (Tabla.Rows.Count == 0)
            {
                DataRow fila = dato.NewRow();
                DataRow fila1 = dato1.NewRow();
                DataRow fila2 = dato2.NewRow();
                DataRow fila3 = dato3.NewRow();
                fila[" "] = "Sin";
                fila1[" "] = "Cargos";
                fila2[" "] = "Hasta la";
                fila3[" "] = "Fecha";
                dato.Rows.Add(fila);
                dato1.Rows.Add(fila1);
                dato2.Rows.Add(fila2);
                dato3.Rows.Add(fila3);
            }
            else
            {
                for (int i = 0; i < Tabla.Rows.Count; i++)
                {
                    if (Tabla.Rows[i][4].ToString().Equals(""))
                    {
                        if (colillage == 0)
                        {
                            int resta = 0;
                            if (Tabla.Rows[i][0].ToString().Equals("Reserva"))
                            {
                                resta = Convert.ToInt32(Tabla.Rows[i][5]);
                            }
                            DataRow fila = dato.NewRow();
                            DataRow fila1 = dato1.NewRow();
                            DataRow fila2 = dato2.NewRow();
                            DataRow fila3 = dato3.NewRow();
                            fila[" "] = Tabla.Rows[i][0].ToString();
                            fila1[" "] = Tabla.Rows[i][1].ToString();
                            fila2[" "] = Tabla.Rows[i][2].ToString();
                            int x = Convert.ToInt32(Tabla.Rows[i][3])-resta;
                            fila3[" "] = x.ToString("C", CultureInfo.CurrentCulture);
                            dato.Rows.Add(fila);
                            dato1.Rows.Add(fila1);
                            dato2.Rows.Add(fila2);
                            dato3.Rows.Add(fila3);
                        }
                    }
                    else
                    {
                       if(colillage==Convert.ToInt32(Tabla.Rows[i][6]))
                        {
                            int resta = 0;
                            if (Tabla.Rows[i][0].ToString().Equals("Reserva"))
                            {
                                resta = Convert.ToInt32(Tabla.Rows[i][5]);
                            }
                            DataRow fila = dato.NewRow();
                            DataRow fila1 = dato1.NewRow();
                            DataRow fila2 = dato2.NewRow();
                            DataRow fila3 = dato3.NewRow();
                            fila[" "] = Tabla.Rows[i][0].ToString();
                            fila1[" "] = Tabla.Rows[i][1].ToString();
                            fila2[" "] = Tabla.Rows[i][2].ToString();
                            int x = Convert.ToInt32(Tabla.Rows[i][3])-resta;
                            fila3[" "] = x.ToString("C", CultureInfo.CurrentCulture);
                            dato.Rows.Add(fila);
                            dato1.Rows.Add(fila1);
                            dato2.Rows.Add(fila2);
                            dato3.Rows.Add(fila3);
                        }
                    }
                    
                }
            }


            DataTable[] datos = new DataTable[4];

            datos[0] = dato;
            datos[1] = dato1;
            datos[2] = dato2;
            datos[3] = dato3;
            if (datos[3].Rows.Count == 0)
            {
                DataRow fila = dato.NewRow();
                DataRow fila1 = dato1.NewRow();
                DataRow fila2 = dato2.NewRow();
                DataRow fila3 = dato3.NewRow();
                fila[" "] = "Sin";
                fila1[" "] = "Cargos";
                fila2[" "] = "Hasta la";
                fila3[" "] = "Fecha";
                dato.Rows.Add(fila);
                dato1.Rows.Add(fila1);
                dato2.Rows.Add(fila2);
                dato3.Rows.Add(fila3);
            }
            return datos;
        }

        public DataTable Proveedores_datos()
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(15), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public void CrearEgreso(Egreso egreso)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(1)
                .Replace("$fecha",egreso.RecibirFecha().ToString("yyyy/MM/dd"))
                .Replace("$hora", egreso.RecibirHora().ToString("HH:mm"))
                .Replace("$monto", egreso.RecibirMonto()+"")
                .Replace("$doc", egreso.RecibirNumeroDoc())
                .Replace("$descripcion", egreso.RecibirDescripcion())
                .Replace("$anulacion", egreso.RecibirAnulacion()+"")
                .Replace("$rut", egreso.Recibirrut()+""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public DataTable Unidades_datos(int id)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(16)
                .Replace("$comunidad", id+""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public void CrearCargo(Egreso egreso)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(2)
                .Replace("$fecha", egreso.RecibirFecha().ToString("yyyy/MM/dd"))
                .Replace("$hora", egreso.RecibirHora().ToString("HH:mm"))
                .Replace("$monto", egreso.RecibirMonto() + "")
                .Replace("$doc", egreso.RecibirNumeroDoc())
                .Replace("$descripcion", egreso.RecibirDescripcion())
                .Replace("$anulacion", egreso.RecibirAnulacion() + "")
                .Replace("$rut", egreso.Recibirrut() + "")
                .Replace("$abonado",egreso.RecibirMontopagado()+""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public DataTable Proveedores_select()
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(17), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }
        public void IngresarProveedor(Proveedor proveedor)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(3)
                .Replace("$rut", proveedor.Recibirrut()+"")
                .Replace("$dv", proveedor.Recibirdv())
                .Replace("$razon", proveedor.RecibirRazon())
                .Replace("$Giro", proveedor.RecibirGiro())
                .Replace("$direccion", proveedor.RecibirDireccion())
                .Replace("$anulado", proveedor.RecibirAnulacion() + "")
                .Replace("$correo", proveedor.RecibirCorreo())
                .Replace("$comuna", proveedor.RecibirComuna())
                .Replace("$telefono", proveedor.RecibirTelefono() + "")
                .Replace("$contacto", proveedor.RecibirContacto()), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }


        //cierre mes
        public int UlitmaColilla()
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(18), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Convert.ToInt32(Tabla.Rows[0][1]);
        }

        public DataTable Egresos_vacios(int select)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(select), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public void ColillaGen(int monto,int anterior)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(4)
                .Replace("$monto",monto+"")
                .Replace("$anterior",anterior+""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public void UpdateEgresos(int colilla, int egreso)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoUpdate(3)
                .Replace("$id_colilla", colilla + "")
                .Replace("$egreso", egreso + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public DataTable Unidades(int id)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.Retornoselect(21)
                .Replace("$comunidad", id + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
            return Tabla;
        }

        public void CargoTotal(int monto, int id)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(5)
                .Replace("$monto", monto + "")
                .Replace("$id", id + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public void Update_cargos(int idcargo, int unidad)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(6)
                .Replace("$idcargo", idcargo + "")
                .Replace("$unidad", unidad + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

        public void Crearcolillas(int colilla,int monto,int unidad,int cargos)
        {
            con = Conectarse();
            DataTable Tabla = new DataTable();
            MySqlDataAdapter retorno = new MySqlDataAdapter(query.RetornoInsert(7)
                .Replace("$prorrateo", monto + "")
                .Replace("$cargos", cargos + "")
                .Replace("$unidad", unidad + "")
                .Replace("$colilla", colilla + ""), con);
            Tabla.Clear();
            retorno.Fill(Tabla);
            con.Close();
        }

    }
}
