namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaEnvio = new System.Windows.Forms.Button();
            this.btnListarEnvios = new System.Windows.Forms.Button();
            this.tbEnviosDetalles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAltaEnvio
            // 
            this.btnAltaEnvio.Location = new System.Drawing.Point(356, 14);
            this.btnAltaEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaEnvio.Name = "btnAltaEnvio";
            this.btnAltaEnvio.Size = new System.Drawing.Size(138, 49);
            this.btnAltaEnvio.TabIndex = 0;
            this.btnAltaEnvio.Text = "Alta Envio(1)";
            this.btnAltaEnvio.UseVisualStyleBackColor = true;
            this.btnAltaEnvio.Click += new System.EventHandler(this.btnAltaEnvio_Click);
            // 
            // btnListarEnvios
            // 
            this.btnListarEnvios.Location = new System.Drawing.Point(356, 73);
            this.btnListarEnvios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarEnvios.Name = "btnListarEnvios";
            this.btnListarEnvios.Size = new System.Drawing.Size(138, 49);
            this.btnListarEnvios.TabIndex = 1;
            this.btnListarEnvios.Text = "Listar Envíos (2)";
            this.btnListarEnvios.UseVisualStyleBackColor = true;
            this.btnListarEnvios.Click += new System.EventHandler(this.btnListarEnvios_Click);
            // 
            // tbEnviosDetalles
            // 
            this.tbEnviosDetalles.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnviosDetalles.Location = new System.Drawing.Point(14, 14);
            this.tbEnviosDetalles.Multiline = true;
            this.tbEnviosDetalles.Name = "tbEnviosDetalles";
            this.tbEnviosDetalles.Size = new System.Drawing.Size(335, 140);
            this.tbEnviosDetalles.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 163);
            this.Controls.Add(this.tbEnviosDetalles);
            this.Controls.Add(this.btnListarEnvios);
            this.Controls.Add(this.btnAltaEnvio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEnvio;
        private System.Windows.Forms.Button btnListarEnvios;
        private System.Windows.Forms.TextBox tbEnviosDetalles;
    }
}

