using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace DAL
{
   public class ReceptorDAL
   {
      public List<Receptor> ObtenerReceptores()
      {
         List<Receptor> receptores = new List<Receptor>();
         using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UaiPagoConnection"].ConnectionString))
         {
            connection.Open();
            string query = "SELECT DNI_CUENTA, NOMBRE_APELLIDO_TITULAR, SALDO_CUENTA FROM TITULAR";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
               using (SqlDataReader reader = command.ExecuteReader())
               {
                  while (reader.Read())
                  {
                     Receptor receptor = new Receptor
                     {
                        DniCuenta = reader.GetInt32(0),
                        NombreApellidoTitular = reader.GetString(1),
                        SaldoCuenta = reader.GetDouble(2)
                     };
                     receptores.Add(receptor);
                  }
               }
            }
         }
         return receptores;
      }

   }
}
