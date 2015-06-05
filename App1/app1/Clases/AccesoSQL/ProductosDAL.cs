using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace App1.Clases.AccesoSQL
{
    class ProductosDAL
    {
        public static int AgregarProducto(Producto pProducto)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Productos (descripcion,costo,cantidad,id_Terapeuta) values ('{0}','{1}','{2}','{3}')",
                            pProducto.Descripcion, pProducto.Costo, pProducto.Cantidad, pProducto.id_Terapeuta), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Producto> ObtenerProducto()
        {
            List<Producto> _lista = new List<Producto>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("Select id_producto,descripcion,costo,cantidad from Productos", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProductos = new Producto();

                pProductos.Id = _reader.GetInt32(0);
                pProductos.Descripcion = _reader.GetString(1);
                pProductos.Costo = _reader.GetDecimal(2);
                pProductos.Cantidad = _reader.GetInt32(3);


                _lista.Add(pProductos);
            }

            return _lista;
        }

        public static List<Producto> ObtenerProductoss(Int64 pIdTerapeuta)
        {
            List<Producto> _listaDeProductos = new List<Producto>();
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select id_producto,descripcion,costo,cantidad,id_Terapeuta from Productos where id_Terapeuta={0}", pIdTerapeuta), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto pProductos = new Producto();
                    pProductos.Id = reader.GetInt32(0);
                    pProductos.Descripcion = reader.GetString(1);
                    pProductos.Costo = reader.GetDecimal(2);
                    pProductos.Cantidad = reader.GetInt32(3);
                    pProductos.id_Terapeuta = reader.GetInt32(3);

                    _listaDeProductos.Add(pProductos);

                }
                return _listaDeProductos;

                conexion.Close();
            }




        }

        public static int EliminarProductos(Int64 pInt)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand
                    (string.Format(
                        "Delete Productos where id_producto={0} ",
                        pInt), conexion);


                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

        public static bool ExisteTerapeuta(int id)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Productos WHERE id_Terapeuta=@id_Terapeuta";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("id_Terapeuta", id);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }

        public static bool ExisteTratamiento(int id)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Tipo_Tratamiento WHERE id_producto=@id_Producto";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("id_Producto", id);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }

        }


    }
}