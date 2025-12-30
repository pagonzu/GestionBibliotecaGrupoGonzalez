namespace CapaPresentacion
{
    partial class AltaEjemplar
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
            this.Codigo = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.Label();
            this.Personal = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Prestado = new System.Windows.Forms.RadioButton();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.txtPersonal = new System.Windows.Forms.TextBox();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(64, 55);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(43, 13);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo:";
            // 
            // Documento
            // 
            this.Documento.AutoSize = true;
            this.Documento.Location = new System.Drawing.Point(64, 101);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(99, 13);
            this.Documento.TabIndex = 1;
            this.Documento.Text = "Documento (ISBN):";
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Location = new System.Drawing.Point(64, 151);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(51, 13);
            this.Personal.TabIndex = 2;
            this.Personal.Text = "Personal:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(188, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // Prestado
            // 
            this.Prestado.AutoSize = true;
            this.Prestado.Location = new System.Drawing.Point(67, 195);
            this.Prestado.Name = "Prestado";
            this.Prestado.Size = new System.Drawing.Size(67, 17);
            this.Prestado.TabIndex = 4;
            this.Prestado.TabStop = true;
            this.Prestado.Text = "Prestado";
            this.Prestado.UseVisualStyleBackColor = true;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(67, 241);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 5;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(213, 241);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // txtPersonal
            // 
            this.txtPersonal.Location = new System.Drawing.Point(188, 148);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(121, 20);
            this.txtPersonal.TabIndex = 7;
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(188, 101);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbDocumento.TabIndex = 8;
            // 
            // AltaEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 292);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Prestado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.Codigo);
            this.Name = "AltaEjemplar";
            this.Text = "AltaEjemplar";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Documento;
        private System.Windows.Forms.Label Personal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton Prestado;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox txtPersonal;
        private System.Windows.Forms.ComboBox cmbDocumento;
    }
}