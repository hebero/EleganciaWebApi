using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Text;

namespace WebApi.Models
{
    public class Productos
    {
        public int Sku { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public int Daniado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Sucursal { get; set; }

        public Productos (string Sucursal)
        {
            string Conexion = Properties.Settings.Default.Conexion;
            SqlConnection Cn; SqlCommand Cmd; SqlDataReader Dr;
            try
            {
                StringBuilder Comando = new StringBuilder();
                Comando.Append("SELECT Sku, Nombre, Existencia, Daniado, FechaVencimiento FROM ");
                Comando.Append("  vInventarioDaniado WHERE  ");
                Comando.AppendFormat(" WHERE IdBodega = {0} ", int.Parse(Sucursal));

            }
    }
}