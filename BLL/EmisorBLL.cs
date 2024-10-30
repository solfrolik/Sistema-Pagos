using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class EmisorBLL
   {
      private EmisorDAL emisorDAL = new EmisorDAL();
     

      public List<Emisor> ObtenerEmisores()
      {
         return emisorDAL.ObtenerEmisores();
      }
      public bool Transferir(Emisor emisor, Receptor receptor, double monto)
      {
         return emisorDAL.TransferirConTransaccion(emisor, receptor, monto);
      }

   }
}
