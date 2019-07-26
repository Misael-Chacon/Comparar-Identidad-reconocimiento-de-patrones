namespace Examen_IA
{
    partial class Guardar_Identidad
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Información = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pblimagen = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lblImagen = new System.Windows.Forms.Label();
            this.Información.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Información
            // 
            this.Información.Controls.Add(this.button1);
            this.Información.Controls.Add(this.txtnumero);
            this.Información.Controls.Add(this.label2);
            this.Información.Controls.Add(this.txtnombre);
            this.Información.Controls.Add(this.label1);
            this.Información.Location = new System.Drawing.Point(19, 38);
            this.Información.Name = "Información";
            this.Información.Size = new System.Drawing.Size(346, 274);
            this.Información.TabIndex = 0;
            this.Información.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "CARGAR IMAGEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(140, 100);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(200, 20);
            this.txtnumero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMERO IDENTIDAD";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(140, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE COMPLETO";
            // 
            // pblimagen
            // 
            this.pblimagen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pblimagen.Location = new System.Drawing.Point(375, 38);
            this.pblimagen.Name = "pblimagen";
            this.pblimagen.Size = new System.Drawing.Size(408, 274);
            this.pblimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblimagen.TabIndex = 1;
            this.pblimagen.TabStop = false;
            this.pblimagen.DoubleClick += new System.EventHandler(this.pblImage_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "GUARDAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(517, 20);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(124, 13);
            this.lblImagen.TabIndex = 4;
            this.lblImagen.Text = "Cuadro para ver  Imagen";
            // 
            // Guardar_Identidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 384);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pblimagen);
            this.Controls.Add(this.Información);
            this.Name = "Guardar_Identidad";
            this.Text = "RECONOCIMIENTO DE PATRONES DE IDENTIDAD";
            this.Información.ResumeLayout(false);
            this.Información.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Información;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pblimagen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lblImagen;
    }
}

