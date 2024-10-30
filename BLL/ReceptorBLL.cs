﻿using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ReceptorBLL
   {
      private ReceptorDAL receptorDAL = new ReceptorDAL();

      public List<Receptor> ObtenerReceptores()
      {
         return receptorDAL.ObtenerReceptores();
      }

   }
}
