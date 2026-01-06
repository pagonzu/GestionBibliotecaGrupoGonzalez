namespace CapaPresentacion
{
    partial class Loguearse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opAd = new System.Windows.Forms.RadioButton();
            this.opSala = new System.Windows.Forms.RadioButton();
            this.nombreLog = new System.Windows.Forms.TextBox();
            this.contraseñaLog = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opAd);
            this.groupBox1.Controls.Add(this.opSala);
            this.groupBox1.Location = new System.Drawing.Point(49, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(255, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TipoEmpleado";
            // 
            // opAd
            // 
            this.opAd.AutoSize = true;
            this.opAd.Location = new System.Drawing.Point(43, 87);
            this.opAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opAd.Name = "opAd";
            this.opAd.Size = new System.Drawing.Size(155, 20);
            this.opAd.TabIndex = 6;
            this.opAd.TabStop = true;
            this.opAd.Text = "Personal Adquisicion";
            this.opAd.UseVisualStyleBackColor = true;
            // 
            // opSala
            // 
            this.opSala.AutoSize = true;
            this.opSala.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.opSala.Location = new System.Drawing.Point(43, 46);
            this.opSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opSala.Name = "opSala";
            this.opSala.Size = new System.Drawing.Size(113, 20);
            this.opSala.TabIndex = 5;
            this.opSala.TabStop = true;
            this.opSala.Text = "Personal Sala";
            this.opSala.UseVisualStyleBackColor = true;
            // 
            // nombreLog
            // 
            this.nombreLog.Location = new System.Drawing.Point(165, 66);
            this.nombreLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreLog.Name = "nombreLog";
            this.nombreLog.Size = new System.Drawing.Size(100, 22);
            this.nombreLog.TabIndex = 3;
            // 
            // contraseñaLog
            // 
            this.contraseñaLog.Location = new System.Drawing.Point(165, 112);
            this.contraseñaLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraseñaLog.Name = "contraseñaLog";
            this.contraseñaLog.Size = new System.Drawing.Size(100, 22);
            this.contraseñaLog.TabIndex = 4;
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(49, 343);
            this.entrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(100, 28);
            this.entrar.TabIndex = 7;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(204, 343);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(100, 28);
            this.buttonCargar.TabIndex = 8;
            this.buttonCargar.Text = "Cargar Datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // Loguearse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 409);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.contraseñaLog);
            this.Controls.Add(this.nombreLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Loguearse";
            this.Text = "Loguearse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opAd;
        private System.Windows.Forms.RadioButton opSala;
        private System.Windows.Forms.TextBox nombreLog;
        private System.Windows.Forms.TextBox contraseñaLog;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button buttonCargar;
    }
}

