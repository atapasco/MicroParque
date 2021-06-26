namespace MicroParque
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnTalleres = new System.Windows.Forms.Button();
            this.PanelChild = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1200000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MicroParque.Properties.Resources.barra_menu;
            this.pictureBox1.Location = new System.Drawing.Point(183, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnTalleres
            // 
            this.BtnTalleres.BackColor = System.Drawing.Color.Turquoise;
            this.BtnTalleres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTalleres.Font = new System.Drawing.Font("Langdon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTalleres.Location = new System.Drawing.Point(332, 50);
            this.BtnTalleres.Name = "BtnTalleres";
            this.BtnTalleres.Size = new System.Drawing.Size(104, 65);
            this.BtnTalleres.TabIndex = 5;
            this.BtnTalleres.Text = "TALLERES";
            this.BtnTalleres.UseVisualStyleBackColor = false;
            this.BtnTalleres.Click += new System.EventHandler(this.BtnTalleres_Click);
            // 
            // PanelChild
            // 
            this.PanelChild.Location = new System.Drawing.Point(8, 170);
            this.PanelChild.Name = "PanelChild";
            this.PanelChild.Size = new System.Drawing.Size(1066, 505);
            this.PanelChild.TabIndex = 6;
            // 
            // Frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1103, 554);
            this.Controls.Add(this.PanelChild);
            this.Controls.Add(this.BtnTalleres);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.Opacity = 0.3D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.panelMain_Load);
            this.Click += new System.EventHandler(this.Frm_Main_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Main_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnTalleres;
        private System.Windows.Forms.Panel PanelChild;
    }
}