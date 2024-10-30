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
   public class EmisorDAL
   {
      public List<Emisor> ObtenerEmisores()
      {
         List<Emisor> emisores = new List<Emisor>();
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
                     Emisor emisor = new Emisor
                     {
                        DniCuenta = reader.GetInt32(0),
                        NombreApellidoTitular = reader.GetString(1),
                        SaldoCuenta = reader.GetDouble(2)
                     };
                     emisores.Add(emisor);
                  }
               }
            }
         }
         return emisores;
      }

      public bool TransferirConTransaccion(Emisor emisor, Receptor receptor, double monto)
      {
         SqlTransaction transaction = null;
         try
         {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UaiPagoConnection"].ConnectionString))
            {
               connection.Open();
               transaction = connection.BeginTransaction();

               string queryDebitarEmisor = "UPDATE TITULAR SET SALDO_CUENTA = SALDO_CUENTA - @Monto WHERE DNI_CUENTA = @DniCuenta";
               using (SqlCommand commandDebitarEmisor = new SqlCommand(queryDebitarEmisor, connection))
               {
                  commandDebitarEmisor.Transaction = transaction;
                  commandDebitarEmisor.Parameters.AddWithValue("@Monto", monto);
                  commandDebitarEmisor.Parameters.AddWithValue("@DniCuenta", emisor.DniCuenta);
                  commandDebitarEmisor.ExecuteNonQuery();
               }

              
               string queryAcreditarReceptor = "UPDATE TITULAR SET SALDO_CUENTA = SALDO_CUENTA + @Monto WHERE DNI_CUENTA = @DniCuenta";
               using (SqlCommand commandAcreditarReceptor = new SqlCommand(queryAcreditarReceptor, connection))
               {
                  commandAcreditarReceptor.Transaction = transaction;
                  commandAcreditarReceptor.Parameters.AddWithValue("@Monto", monto);
                  commandAcreditarReceptor.Parameters.AddWithValue("@DniCuenta", receptor.DniCuenta);
                  commandAcreditarReceptor.ExecuteNonQuery();
               }

               transaction.Commit();
               return true;
            }
         }
         catch (Exception)
         {
            
            if (transaction != null)
            {
               transaction.Rollback();
            }
            throw;
         }
      }
   }
}
