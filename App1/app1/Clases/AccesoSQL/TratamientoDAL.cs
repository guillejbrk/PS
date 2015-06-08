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
                            pTratamiento.Descripcion, pTratamiento.IdProducto,pTratamiento.Costo), Conn);

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

        public static List<Tratamiento> ObtenerTratamiento()
        {
            List<Tratamiento> _listaTratamiento = new List<Tratamiento>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando =
                new SqlCommand("select id_Tipo_Tratamiento, tipo_Tratamiento,id_Producto , Costo from Tipo_Tratamiento", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Tratamiento pTratamiento = new Tratamiento();

                pTratamiento.Id = _reader.GetInt32(0);
                pTratamiento.Descripcion = _reader.GetString(1);
                pTratamiento.IdProducto = _reader.GetInt32(2);
                pTratamiento.Costo = _reader.GetDecimal(3);


                _listaTratamiento.Add(pTratamiento);
            }

            return _listaTratamiento;
        }

        public static int EliminarTrataiento(Int64 pInt)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand
                    (string.Format(
                        "Delete Tipo_Tratamiento where id_Tipo_Tratamiento={0} ",
                        pInt), conexion);


                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

        public static bool ExisteTurno(int id)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Turno WHERE id_TipoTratamiento=@id_TipoTratamiento";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("id_TipoTratamiento", id);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }

        }


       
    }
}
