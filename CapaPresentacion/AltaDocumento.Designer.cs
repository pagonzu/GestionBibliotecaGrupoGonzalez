namespace CapaPresentacion
{
    partial class AltaDocumento
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
            this.ISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.Editorial = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.GroupBox();
            this.Audiolibro = new System.Windows.Forms.RadioButton();
            this.Libro = new System.Windows.Forms.RadioButton();
            this.Añadir = new System.Windows.Forms.Button();
            this.Dar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Duracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.AñoEdicion = new System.Windows.Forms.Label();
            this.txtAñoEdicion = new System.Windows.Forms.TextBox();
            this.Tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(40, 32);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(32, 13);
            this.ISBN.TabIndex = 0;
            this.ISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(141, 25);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(141, 58);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(279, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(141, 93);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(279, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(141, 138);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(279, 20);
            this.txtEditorial.TabIndex = 7;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(40, 65);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(33, 13);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "Titulo";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(40, 100);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(32, 13);
            this.Autor.TabIndex = 9;
            this.Autor.Text = "Autor";
            // 
            // Editorial
            // 
            this.Editorial.AutoSize = true;
            this.Editorial.Location = new System.Drawing.Point(40, 138);
            this.Editorial.Name = "Editorial";
            this.Editorial.Size = new System.Drawing.Size(44, 13);
            this.Editorial.TabIndex = 10;
            this.Editorial.Text = "Editorial";
            // 
            // Tipo
            // 
            this.Tipo.Controls.Add(this.Audiolibro);
            this.Tipo.Controls.Add(this.Libro);
            this.Tipo.Location = new System.Drawing.Point(43, 261);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(377, 100);
            this.Tipo.TabIndex = 11;
            this.Tipo.TabStop = false;
            this.Tipo.Text = "Tipo de documento";
            // 
            // Audiolibro
            // 
            this.Audiolibro.AutoSize = true;
            this.Audiolibro.Location = new System.Drawing.Point(31, 65);
            this.Audiolibro.Name = "Audiolibro";
            this.Audiolibro.Size = new System.Drawing.Size(71, 17);
            this.Audiolibro.TabIndex = 16;
            this.Audiolibro.TabStop = true;
            this.Audiolibro.Text = "Audiolibro";
            this.Audiolibro.UseVisualStyleBackColor = true;
            this.Audiolibro.CheckedChanged += new System.EventHandler(this.Audiolibro_CheckedChanged);
            // 
            // Libro
            // 
            this.Libro.AutoSize = true;
            this.Libro.Location = new System.Drawing.Point(31, 33);
            this.Libro.Name = "Libro";
            this.Libro.Size = new System.Drawing.Size(48, 17);
            this.Libro.TabIndex = 15;
            this.Libro.TabStop = true;
            this.Libro.Text = "Libro";
            this.Libro.UseVisualStyleBackColor = true;
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(43, 367);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(156, 23);
            this.Añadir.TabIndex = 12;
            this.Añadir.Text = "Añadir ejemplares";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // Dar
            // 
            this.Dar.Location = new System.Drawing.Point(237, 367);
            this.Dar.Name = "Dar";
            this.Dar.Size = new System.Drawing.Size(75, 23);
            this.Dar.TabIndex = 13;
            this.Dar.Text = "Dar alta";
            this.Dar.UseVisualStyleBackColor = true;
            this.Dar.Click += new System.EventHandler(this.Dar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(345, 367);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 14;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Duracion
            // 
            this.Duracion.AutoSize = true;
            this.Duracion.Location = new System.Drawing.Point(40, 225);
            this.Duracion.Name = "Duracion";
            this.Duracion.Size = new System.Drawing.Size(50, 13);
            this.Duracion.TabIndex = 15;
            this.Duracion.Text = "Duracion";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(141, 222);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(279, 20);
            this.txtDuracion.TabIndex = 16;
            // 
            // AñoEdicion
            // 
            this.AñoEdicion.AutoSize = true;
            this.AñoEdicion.Location = new System.Drawing.Point(40, 185);
            this.AñoEdicion.Name = "AñoEdicion";
            this.AñoEdicion.Size = new System.Drawing.Size(61, 13);
            this.AñoEdicion.TabIndex = 17;
            this.AñoEdicion.Text = "AñoEdicion";
            // 
            // txtAñoEdicion
            // 
            this.txtAñoEdicion.Location = new System.Drawing.Point(141, 182);
            this.txtAñoEdicion.Name = "txtAñoEdicion";
            this.txtAñoEdicion.Size = new System.Drawing.Size(279, 20);
            this.txtAñoEdicion.TabIndex = 18;
            // 
            // AltaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 420);
            this.Controls.Add(this.txtAñoEdicion);
            this.Controls.Add(this.AñoEdicion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.Duracion);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Dar);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Editorial);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.ISBN);
            this.Name = "AltaDocumento";
            this.Text = "AltaDocumento";
            this.Tipo.ResumeLayout(false);
            this.Tipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label Editorial;
        private System.Windows.Forms.GroupBox Tipo;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button Dar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.RadioButton Audiolibro;
        private System.Windows.Forms.RadioButton Libro;
        private System.Windows.Forms.Label Duracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label AñoEdicion;
        private System.Windows.Forms.TextBox txtAñoEdicion;
    }
}