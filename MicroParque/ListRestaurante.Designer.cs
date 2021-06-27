
namespace MicroParque
{
    partial class ListRestaurante
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFechayHora = new System.Windows.Forms.Label();
            this.LblPersonasPendientes = new System.Windows.Forms.Label();
            this.LblPersonasAceptadas = new System.Windows.Forms.Label();
            this.LblNombreTaller = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 150);
            this.panel1.TabIndex = 10;
            // 
            // LblFechayHora
            // 
            this.LblFechayHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFechayHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechayHora.Location = new System.Drawing.Point(176, 105);
            this.LblFechayHora.Name = "LblFechayHora";
            this.LblFechayHora.Size = new System.Drawing.Size(298, 21);
            this.LblFechayHora.TabIndex = 9;
            this.LblFechayHora.Text = "Horario: ";
            // 
            // LblPersonasPendientes
            // 
            this.LblPersonasPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPersonasPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonasPendientes.Location = new System.Drawing.Point(176, 80);
            this.LblPersonasPendientes.Name = "LblPersonasPendientes";
            this.LblPersonasPendientes.Size = new System.Drawing.Size(298, 27);
            this.LblPersonasPendientes.TabIndex = 8;
            this.LblPersonasPendientes.Text = "Gastronomia:\r\n";
            // 
            // LblPersonasAceptadas
            // 
            this.LblPersonasAceptadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPersonasAceptadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonasAceptadas.Location = new System.Drawing.Point(176, 55);
            this.LblPersonasAceptadas.Name = "LblPersonasAceptadas";
            this.LblPersonasAceptadas.Size = new System.Drawing.Size(296, 23);
            this.LblPersonasAceptadas.TabIndex = 7;
            this.LblPersonasAceptadas.Text = "Empleados:\r\n";
            // 
            // LblNombreTaller
            // 
            this.LblNombreTaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNombreTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTaller.Location = new System.Drawing.Point(174, 19);
            this.LblNombreTaller.Name = "LblNombreTaller";
            this.LblNombreTaller.Size = new System.Drawing.Size(298, 20);
            this.LblNombreTaller.TabIndex = 6;
            this.LblNombreTaller.Text = "NombreRestautante";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MicroParque.Properties.Resources.icono_restaurante_01;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblFechayHora);
            this.Controls.Add(this.LblPersonasPendientes);
            this.Controls.Add(this.LblPersonasAceptadas);
            this.Controls.Add(this.LblNombreTaller);
            this.Name = "ListRestaurante";
            this.Size = new System.Drawing.Size(660, 150);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblFechayHora;
        private System.Windows.Forms.Label LblPersonasPendientes;
        private System.Windows.Forms.Label LblPersonasAceptadas;
        private System.Windows.Forms.Label LblNombreTaller;
    }
}
