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
            this.Codigo.Location = new System.Drawing.Point(85, 68);
            this.Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(54, 16);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo:";
            // 
            // Documento
            // 
            this.Documento.AutoSize = true;
            this.Documento.Location = new System.Drawing.Point(85, 124);
            this.Documento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(121, 16);
            this.Documento.TabIndex = 1;
            this.Documento.Text = "Documento (ISBN):";
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Location = new System.Drawing.Point(85, 186);
            this.Personal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(64, 16);
            this.Personal.TabIndex = 2;
            this.Personal.Text = "Personal:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(251, 68);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // Prestado
            // 
            this.Prestado.AutoSize = true;
            this.Prestado.Location = new System.Drawing.Point(89, 240);
            this.Prestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prestado.Name = "Prestado";
            this.Prestado.Size = new System.Drawing.Size(83, 20);
            this.Prestado.TabIndex = 4;
            this.Prestado.TabStop = true;
            this.Prestado.Text = "Prestado";
            this.Prestado.UseVisualStyleBackColor = true;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(89, 297);
            this.Aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(100, 28);
            this.Aceptar.TabIndex = 5;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(284, 297);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 28);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // txtPersonal
            // 
            this.txtPersonal.Location = new System.Drawing.Point(251, 182);
            this.txtPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(160, 22);
            this.txtPersonal.TabIndex = 7;
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(251, 124);
            this.cmbDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(160, 24);
            this.cmbDocumento.TabIndex = 8;
            // 
            // AltaEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 359);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Prestado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.Codigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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