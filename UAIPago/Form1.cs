using BLL;
using Entity;

namespace UAIPago
{
   public partial class Form1 : Form
   {
      private EmisorBLL emisorBLL = new EmisorBLL();
      private ReceptorBLL receptorBLL = new ReceptorBLL();
      public Form1()
      {
         InitializeComponent();
         CargarCombos();
      }
      private void CargarCombos()
      {
         cmbEmisor.DataSource = emisorBLL.ObtenerEmisores();
         cmbEmisor.DisplayMember = "NombreApellidoTitular";
         cmbEmisor.ValueMember = "DniCuenta";

         cmbReceptor.DataSource = receptorBLL.ObtenerReceptores();
         cmbReceptor.DisplayMember = "NombreApellidoTitular";
         cmbReceptor.ValueMember = "DniCuenta";
      }
      private void btnTransferir_Click(object sender, EventArgs e)
      {
         try
         {
            Emisor emisorSeleccionado = (Emisor)cmbEmisor.SelectedItem;
            Receptor receptorSeleccionado = (Receptor)cmbReceptor.SelectedItem;
            double monto = Convert.ToDouble(txtMonto.Text);

            if (monto > 0 && emisorSeleccionado.SaldoCuenta >= monto)
            {
               bool exito = emisorBLL.Transferir(emisorSeleccionado, receptorSeleccionado, monto);
               if (exito)
               {
                  MessageBox.Show("Transferencia realizada con éxito.");
               }
            }
            else
            {
               MessageBox.Show("Saldo insuficiente o monto no válido.");
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Ocurrió un error durante la transferencia: " + ex.Message);
         }
      }

   }

}

