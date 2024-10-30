using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Emisor
   {
      private int dniCuenta;
      private string nombreApellidoTitular;
      private double saldoCuenta;

      public int DniCuenta { get => dniCuenta; set => dniCuenta = value; }
      public string NombreApellidoTitular { get => nombreApellidoTitular; set => nombreApellidoTitular = value; }
      public double SaldoCuenta { get => saldoCuenta; set => saldoCuenta = value; }
   }
}
