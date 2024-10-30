namespace UAIPago
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         lblNombreEmisor = new Label();
         label2 = new Label();
         cmbEmisor = new ComboBox();
         cmbReceptor = new ComboBox();
         label4 = new Label();
         txtMonto = new TextBox();
         btnTransferir = new Button();
         SuspendLayout();
         // 
         // lblNombreEmisor
         // 
         lblNombreEmisor.AutoSize = true;
         lblNombreEmisor.Location = new Point(229, 72);
         lblNombreEmisor.Name = "lblNombreEmisor";
         lblNombreEmisor.Size = new Size(129, 20);
         lblNombreEmisor.TabIndex = 0;
         lblNombreEmisor.Text = "Selecciona Emisor";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(214, 151);
         label2.Name = "label2";
         label2.Size = new Size(144, 20);
         label2.TabIndex = 2;
         label2.Text = "Selecciona Receptor";
         // 
         // cmbEmisor
         // 
         cmbEmisor.FormattingEnabled = true;
         cmbEmisor.Location = new Point(399, 72);
         cmbEmisor.Name = "cmbEmisor";
         cmbEmisor.Size = new Size(151, 28);
         cmbEmisor.TabIndex = 4;
         // 
         // cmbReceptor
         // 
         cmbReceptor.FormattingEnabled = true;
         cmbReceptor.Location = new Point(399, 143);
         cmbReceptor.Name = "cmbReceptor";
         cmbReceptor.Size = new Size(151, 28);
         cmbReceptor.TabIndex = 5;
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(305, 228);
         label4.Name = "label4";
         label4.Size = new Size(53, 20);
         label4.TabIndex = 6;
         label4.Text = "Monto";
         // 
         // txtMonto
         // 
         txtMonto.Location = new Point(399, 225);
         txtMonto.Name = "txtMonto";
         txtMonto.Size = new Size(151, 27);
         txtMonto.TabIndex = 7;
         // 
         // btnTransferir
         // 
         btnTransferir.Location = new Point(591, 303);
         btnTransferir.Name = "btnTransferir";
         btnTransferir.Size = new Size(94, 29);
         btnTransferir.TabIndex = 8;
         btnTransferir.Text = "ENVIAR";
         btnTransferir.UseVisualStyleBackColor = true;
         btnTransferir.Click += btnTransferir_Click;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(901, 505);
         Controls.Add(btnTransferir);
         Controls.Add(txtMonto);
         Controls.Add(label4);
         Controls.Add(cmbReceptor);
         Controls.Add(cmbEmisor);
         Controls.Add(label2);
         Controls.Add(lblNombreEmisor);
         Name = "Form1";
         Text = "Form1";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label lblNombreEmisor;
      private Label label2;
      private ComboBox cmbEmisor;
      private ComboBox cmbReceptor;
      private Label label4;
      private TextBox txtMonto;
      private Button btnTransferir;
   }
}
