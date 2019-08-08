using System;
using System.Configuration;
using System.Text;


class FactoryConexion
{

    public static string CreateConnection(string pUsuario, String pContrasena)
    {

        StringBuilder conexion = new StringBuilder();
        // Lee la conexion default
        conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        // Agrega al usuario
        conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
        return conexion.ToString();
    }

}