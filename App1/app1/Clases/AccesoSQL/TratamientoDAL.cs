using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace App1.Clases.AccesoSQL
{
    class TratamientoDAL
    {
        public static int AgregarTratamiento(Tratamiento pTratamiento)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Tipo_Tratamiento (tipo_Tratamiento,id_Producto,Costo) values ('{0}','{1}','{2}')",
                            pTratamiento.Descripcion, pTratamiento.Id_Producto,pTratamiento.Costo), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> _listaProductos = new List<Producto>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select id_Producto,descripcion from Productos", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();

                pProducto.Id = _reader.GetInt32(0);
                pProducto.Descripcion = _reader.GetString(1);



                _listaProductos.Add(pProducto);
            }

            return _listaProductos;
        }
    }
}
