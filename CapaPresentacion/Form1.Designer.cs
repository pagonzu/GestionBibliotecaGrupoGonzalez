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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opAd);
            this.groupBox1.Controls.Add(this.opSala);
            this.groupBox1.Location = new System.Drawing.Point(37, 147);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(191, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TipoEmpleado";
            // 
            // opAd
            // 
            this.opAd.AutoSize = true;
            this.opAd.Location = new System.Drawing.Point(32, 71);
            this.opAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opAd.Name = "opAd";
            this.opAd.Size = new System.Drawing.Size(123, 17);
            this.opAd.TabIndex = 6;
            this.opAd.TabStop = true;
            this.opAd.Text = "Personal Adquisicion";
            this.opAd.UseVisualStyleBackColor = true;
            // 
            // opSala
            // 
            this.opSala.AutoSize = true;
            this.opSala.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.opSala.Location = new System.Drawing.Point(32, 37);
            this.opSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opSala.Name = "opSala";
            this.opSala.Size = new System.Drawing.Size(90, 17);
            this.opSala.TabIndex = 5;
            this.opSala.TabStop = true;
            this.opSala.Text = "Personal Sala";
            this.opSala.UseVisualStyleBackColor = true;
            // 
            // nombreLog
            // 
            this.nombreLog.Location = new System.Drawing.Point(124, 54);
            this.nombreLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreLog.Name = "nombreLog";
            this.nombreLog.Size = new System.Drawing.Size(76, 20);
            this.nombreLog.TabIndex = 3;
            // 
            // contraseñaLog
            // 
            this.contraseñaLog.Location = new System.Drawing.Point(124, 91);
            this.contraseñaLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contraseñaLog.Name = "contraseñaLog";
            this.contraseñaLog.Size = new System.Drawing.Size(76, 20);
            this.contraseñaLog.TabIndex = 4;
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(98, 279);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(75, 23);
            this.entrar.TabIndex = 7;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // Loguearse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 332);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.contraseñaLog);
            this.Controls.Add(this.nombreLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

