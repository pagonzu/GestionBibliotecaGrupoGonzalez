namespace CapaPresentacion
{
    partial class ListadoUsuarios
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
            this.DNI = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Button();
            this.lstDNI = new System.Windows.Forms.ListBox();
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(115, 92);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(75, 23);
            this.DNI.TabIndex = 0;
            this.DNI.Text = "DNI";
            this.DNI.UseVisualStyleBackColor = true;
            this.DNI.Click += new System.EventHandler(this.DNI_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(310, 92);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(75, 23);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            this.Nombre.UseVisualStyleBackColor = true;
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // lstDNI
            // 
            this.lstDNI.FormattingEnabled = true;
            this.lstDNI.ItemHeight = 16;
            this.lstDNI.Location = new System.Drawing.Point(70, 139);
            this.lstDNI.Name = "lstDNI";
            this.lstDNI.Size = new System.Drawing.Size(166, 244);
            this.lstDNI.TabIndex = 2;
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.ItemHeight = 16;
            this.lstNombre.Location = new System.Drawing.Point(266, 139);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(172, 244);
            this.lstNombre.TabIndex = 3;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(209, 405);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 4;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 440);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.lstDNI);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DNI);
            this.Name = "ListadoUsuarios";
            this.Text = "ListadoUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DNI;
        private System.Windows.Forms.Button Nombre;
        private System.Windows.Forms.ListBox lstDNI;
        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.Button Cerrar;
    }
}