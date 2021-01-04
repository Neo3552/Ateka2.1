using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ateka
{
    class Query
    {

        string[] select =
        {
            "select Id_comunidad,Nombre from Comunidad",      //0
            //1
            "select contrasena "+
            "from Unidad_habitacional "+
            "where Numero_unidad=$unidad and id_comunidad=$comunidad", 
            //2
            "select p.Rut,DV,p.Nombre,Primer_apellido,Segundo_Apellido,p.Direccion,Correo,p.Comuna,Telefono,c.nombre,pr.Porcentaje "+
            "from Unidad_persona i,Persona p,Unidad_habitacional u,Comunidad c,Prorrateo pr "+
            "where p.Rut=i.RUT AND i.id_unidad_habitacional=u.id_unidad and u.id_comunidad=c.Id_comunidad and u.id_unidad=pr.Id_unidad and u.Numero_unidad=$unidad and u.id_comunidad=$comunidad ",
            //3
            "select Superficie_util,Terraza,Bodega,Porcentaje "+
            "from Prorrateo p,Unidad_habitacional u "+
            "where p.Id_unidad=u.id_unidad and u.Numero_unidad=$unidad and u.id_comunidad=$comunidad  ",

            " select id_unidad from  Unidad_habitacional where Numero_unidad=$unidad and id_comunidad=$comunidad",  //4

            //5
            "select RazonSocial,Descripcion,Monto_egreso "+
            " from Egreso e, Proveedor p "+
            " where p.Rut=e.ru and e.Id_colillageneral is null and anulacion=1",

            //6
            "select tipo_cargo,Nombre_cargo,Precio_unitario,Cargo_asociado "+
            " from Cargo c,Unidad_habitacional u "+
            " where id_cargo_total is null and anulacion=1  and c.id_unidad_habit=id_unidad and u.Numero_unidad=$unidad and u.id_comunidad=$comunidad",

            "select Fecha_vencimiento, DATE_SUB(NOW(),INTERVAL 3 HOUR),Id_colilla_general from Colilla_general order by Fecha_vencimiento Desc",       //7

            //8
            "select Monto_con_prorrateo,Monto_total "+
            "from Cargo_total c,Colilla_Copropietario co,Unidad_habitacional uni "+
            "where Id_cargo_totales=Id_cargo_total and  Id_unidad_habitacio=uni.id_unidad and uni.Numero_unidad=$unidad and uni.id_comunidad=$comunidad "+
            "order by Id_colilla_cop desc",

            //9
            "select Precio_unitario,Cargo_asociado "+
            "from Cargo c,Unidad_habitacional uni "+
            "where id_cargo_total IS NULL and id_unidad_habit=uni.id_unidad and uni.Numero_unidad=$unidad and uni.id_comunidad=$comunidad ",

            //10
            "select RazonSocial,Descripcion,Monto_egreso "+
            " from Egreso e, Proveedor p "+
            " where p.Rut=e.ru and e.Id_colillageneral=$id_colilla and anulacion=1",

            //11
             "select tipo_cargo, Nombre_cargo, Precio_unitario,0, Cargo_asociado,id_colilla_gener "+
             "from Cargo_total c,Cargo cc,Colilla_Copropietario ccc,Unidad_habitacional u "+
             " where c.id_cargo_total=cc.Id_cargo_total and cc.Id_cargo_total=ccc.Id_cargo_totales and ccc.id_colilla_gener=$colilla " +
             "and ccc.Id_unidad_habitacio=u.id_unidad and u.Numero_unidad=$unidad and u.id_comunidad=$comunidad",

             //12 
             "select p.Nombre,Primer_apellido,Segundo_Apellido,Descripcion,p.Direccion,Correo,p.Comuna,Telefono,Contrasena "+
             "from Perfiles pe,Personas_Perfiles i,Persona p, Personas_Comunidad ii "+
             "where p.Rut=i.Run and pe.Id_Perfiles=i.Id_Perfile and Descripcion!='Copropietario' and ii.Rutn=p.Rut " +
             "and Rut=$rut and ii.Id_comunid=$comunidad",

             //13
              "select * from Comunidad where Id_comunidad=$comunidad",

              //14
              "select tipo_cargo, Nombre_cargo,Numero_unidad, Precio_unitario,ccc.id_cargo_total,Cargo_asociado,cc.id_colilla_gener "+
              "from Cargo c,Colilla_Copropietario cc, Unidad_habitacional u,Cargo_total ccc "+
             " where c.id_unidad_habit=u.id_unidad and anulacion=1 and c.id_cargo_total=ccc.Id_cargo_total and cc.Id_cargo_totales=ccc.Id_cargo_total and id_unidad_habit=$comunidad",

              //15
              "select Rut,RazonSocial "+
              "from Proveedor "+
              "where Anulado=1 "+
              "order by RazonSocial asc",

              "select Id_unidad,Numero_unidad from Unidad_habitacional where id_comunidad=$comunidad ",           //16

              "Select RazonSocial,Giro,Telefono,Contacto,Correo,Direccion,Comuna from Proveedor where anulado=1 ",  //17

              "select * from Colilla_general order by Id_colilla_general desc",  //18

              "select id_egreso,Monto_egreso from Egreso where Id_colillageneral is null and Anulacion=1", //19
              
              //20
              "select id_cargo,Precio_unitario,Cargo_asociado,id_unidad_habit from Cargo where anulacion=1 and id_cargo_total IS NULL order by id_unidad_habit " ,

              //21
              "select id_unidad from Unidad_habitacional where Id_comunidad=$comunidad",

              " select Id_cargo_total, id_unidad_habita,Porcentaje from Cargo_total,Prorrateo where Fecha>=date_sub(CURDATE(), INTERVAL 1 DAY ) and Id_unidad=id_unidad_habita"  //22








    };

        string[] insert =
        {
            "insert into Registro_conexion (Inicio_seccion,Id_Unida) values(DATE_SUB(NOW(),INTERVAL 3 HOUR ),$id_unidad) ",   //0
            //1
            "insert into Egreso (Fecha_egreso,Hora_egreso,Monto_egreso,NumDoc,Descripcion,Anulacion,Ru) "+
            "values('$fecha','$hora',$monto,'$doc','$descripcion',$anulacion,$rut)",
            //2
            "insert into Cargo(Nombre_cargo,Tipo_moneda,Hora_cargo,Fecha_cargo,Precio_cargo,Precio_unitario,Cargo_asociado,tipo_cargo,id_unidad_habit,Anulacion) "+
            "values('$descripcion','Uf','$hora','$fecha',1,$monto,$abonado,'$doc',$rut,$anulacion)",
            //3
             "insert into Proveedor (Rut,DV,RazonSocial,Giro,Direccion,Correo,Comuna,Telefono,Contacto,Anulado) "+
             "values($rut,'$dv','$razon','$Giro','$direccion','$correo','$comuna',$telefono,'$contacto',$anulado)",

             //4
             "insert into Colilla_general (Monto_total,Fecha_emision,Fecha_vencimiento,Monto_anterior) " +
              "values($monto,DATE_SUB(NOW(),INTERVAL 3 HOUR ),'2020/11/30',$anterior)",

             //5
             "insert into Cargo_total (Monto_total,Fecha,id_unidad_habita) values ($monto,DATE_SUB(NOW(),INTERVAL 3 HOUR ),$id)",

             //6
             "update Cargo "+
             "set id_cargo_total=$idcargo "+
             "where id_unidad_habit=$unidad and id_cargo_total IS NULL and Anulacion=1 ",

             //7
             "insert into Colilla_Copropietario (Monto_con_prorrateo,Id_cargo_totales,Id_unidad_habitacio,id_colilla_gener) " +
              "values ($prorrateo,$cargos,$unidad,$colilla)",

    };

        string [] update =
        {
            //0
            "update Registro_conexion "+
            "set Cierre_seccion= DATE_SUB(NOW(),INTERVAL 3 HOUR ) "+
            "where Cierre_seccion is null and Id_Unida=$id_unidad ",
            //1
            "update Unidad_habitacional "+
            "set Contrasena='$Contrasena' "+
            "where Numero_unidad=$id_unidad and Id_comunidad=$comunidad",

            //2
             "update Persona "+
             "set Nombre='$nombre', Primer_apellido='$primer',Segundo_Apellido='$segundo' " +
             ",Direccion='$direccion',Correo='$correo',Comuna='$comuna',Telefono=$telefono "+
             "where Rut=$rut",

             //3
             "update Egreso "+
             "set Id_colillageneral=$id_colilla "+
             "where Id_egreso=$egreso",
        };

        string[] delete =
        {
            ""
        };



        public string Retornoselect(int i)
        {
            return select[i];
        }

        public string RetornoInsert(int i)
        {
            return insert[i];
        }

        public string RetornoUpdate(int i)
        {
            return update[i];
        }

        public string RetornoDelete(int i)
        {
            return delete[i];
        }
    }
}
