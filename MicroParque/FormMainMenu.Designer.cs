
namespace MicroParque
{
    partial class FrmPal
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
            this.PbEncuestas = new System.Windows.Forms.PictureBox();
            this.PbTallres = new System.Windows.Forms.PictureBox();
            this.PbHome = new System.Windows.Forms.PictureBox();
            this.PanelChild = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbEncuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTallres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // PbEncuestas
            // 
            this.PbEncuestas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbEncuestas.Image = global::MicroParque.Properties.Resources.logo_encuestas;
            this.PbEncuestas.Location = new System.Drawing.Point(553, 629);
            this.PbEncuestas.Name = "PbEncuestas";
            this.PbEncuestas.Size = new System.Drawing.Size(378, 419);
            this.PbEncuestas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbEncuestas.TabIndex = 5;
            this.PbEncuestas.TabStop = false;
            // 
            // PbTallres
            // 
            this.PbTallres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbTallres.Image = global::MicroParque.Properties.Resources.logo1;
            this.PbTallres.Location = new System.Drawing.Point(100, 629);
            this.PbTallres.Name = "PbTallres";
            this.PbTallres.Size = new System.Drawing.Size(378, 419);
            this.PbTallres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTallres.TabIndex = 2;
            this.PbTallres.TabStop = false;
            // 
            // PbHome
            // 
            this.PbHome.Image = global::MicroParque.Properties.Resources.fotos1;
            this.PbHome.Location = new System.Drawing.Point(1, -3);
            this.PbHome.Name = "PbHome";
            this.PbHome.Size = new System.Drawing.Size(1035, 538);
            this.PbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbHome.TabIndex = 0;
            this.PbHome.TabStop = false;
            // 
            // PanelChild
            // 
            this.PanelChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChild.Location = new System.Drawing.Point(1, -3);
            this.PanelChild.Name = "PanelChild";
            this.PanelChild.Size = new System.Drawing.Size(1052, 554);
            this.PanelChild.TabIndex = 7;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Teal;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Linen;
            this.BtnLogin.Location = new System.Drawing.Point(857, 44);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLogin.Size = new System.Drawing.Size(117, 36);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Teal;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Linen;
            this.BtnBack.Location = new System.Drawing.Point(59, 46);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBack.Size = new System.Drawing.Size(117, 36);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(24)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1053, 550);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PbEncuestas);
            this.Controls.Add(this.PbTallres);
            this.Controls.Add(this.PbHome);
            this.Controls.Add(this.PanelChild);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FrmPal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbEncuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTallres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbHome;
        private System.Windows.Forms.PictureBox PbTallres;
        private System.Windows.Forms.PictureBox PbEncuestas;
        private System.Windows.Forms.Panel PanelChild;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnBack;
    }
}

