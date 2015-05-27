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
                            "insert into Productos (descripcion,costo,cantidad) values ('{0}','{1}','{2}')",
                            pProducto.Descripcion, pProducto.Costo, pProducto.Cantidad), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
