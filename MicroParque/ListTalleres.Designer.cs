
namespace MicroParque
{
    partial class ListTalleres
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
            this.LblNombreTaller = new System.Windows.Forms.Label();
            this.LblPersonasAceptadas = new System.Windows.Forms.Label();
            this.LblPersonasPendientes = new System.Windows.Forms.Label();
            this.LblFechayHora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombreTaller
            // 
            this.LblNombreTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTaller.Location = new System.Drawing.Point(174, 19);
            this.LblNombreTaller.Name = "LblNombreTaller";
            this.LblNombreTaller.Size = new System.Drawing.Size(298, 20);
            this.LblNombreTaller.TabIndex = 1;
            this.LblNombreTaller.Text = "NombreTaller";
            // 
            // LblPersonasAceptadas
            // 
            this.LblPersonasAceptadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonasAceptadas.Location = new System.Drawing.Point(176, 55);
            this.LblPersonasAceptadas.Name = "LblPersonasAceptadas";
            this.LblPersonasAceptadas.Size = new System.Drawing.Size(296, 23);
            this.LblPersonasAceptadas.TabIndex = 2;
            this.LblPersonasAceptadas.Text = "Personas Aceptadas:\r\n";
            // 
            // LblPersonasPendientes
            // 
            this.LblPersonasPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonasPendientes.Location = new System.Drawing.Point(176, 80);
            this.LblPersonasPendientes.Name = "LblPersonasPendientes";
            this.LblPersonasPendientes.Size = new System.Drawing.Size(298, 27);
            this.LblPersonasPendientes.TabIndex = 3;
            this.LblPersonasPendientes.Text = "Personas Pendientes:\r\n";
            // 
            // LblFechayHora
            // 
            this.LblFechayHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechayHora.Location = new System.Drawing.Point(176, 105);
            this.LblFechayHora.Name = "LblFechayHora";
            this.LblFechayHora.Size = new System.Drawing.Size(298, 21);
            this.LblFechayHora.TabIndex = 4;
            this.LblFechayHora.Text = "Fecha y Hora: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 150);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MicroParque.Properties.Resources._1654193;
            this.pictureBox1.Location = new System.Drawing.Point(21, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListTalleres
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblFechayHora);
            this.Controls.Add(this.LblPersonasPendientes);
            this.Controls.Add(this.LblPersonasAceptadas);
            this.Controls.Add(this.LblNombreTaller);
            this.Name = "ListTalleres";
            this.Size = new System.Drawing.Size(513, 150);
            this.Load += new System.EventHandler(this.ListTalleres_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblNombreTaller;
        private System.Windows.Forms.Label LblPersonasAceptadas;
        private System.Windows.Forms.Label LblPersonasPendientes;
        private System.Windows.Forms.Label LblFechayHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
