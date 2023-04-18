namespace ProyectoPolleriaWilson
{
    partial class FormHUB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHUB));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.ptnCerrar = new System.Windows.Forms.PictureBox();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.panelBarra.Controls.Add(this.ptnCerrar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(800, 38);
            this.panelBarra.TabIndex = 0;
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(95)))));
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 38);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(200, 412);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(600, 412);
            this.panelContenedor.TabIndex = 2;
            // 
            // ptnCerrar
            // 
            this.ptnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptnCerrar.Image")));
            this.ptnCerrar.Location = new System.Drawing.Point(763, 7);
            this.ptnCerrar.Name = "ptnCerrar";
            this.ptnCerrar.Size = new System.Drawing.Size(25, 25);
            this.ptnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptnCerrar.TabIndex = 0;
            this.ptnCerrar.TabStop = false;
            this.ptnCerrar.Click += new System.EventHandler(this.ptnCerrar_Click);
            // 
            // FormHUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHUB";
            this.Text = "FormHUB";
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox ptnCerrar;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
    }
}