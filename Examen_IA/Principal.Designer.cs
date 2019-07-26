namespace Examen_IA
{
    partial class Principal
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncomparar = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.pbImagenn = new System.Windows.Forms.PictureBox();
            this.ofb = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(518, 353);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncomparar
            // 
            this.btncomparar.Location = new System.Drawing.Point(193, 353);
            this.btncomparar.Name = "btncomparar";
            this.btncomparar.Size = new System.Drawing.Size(149, 23);
            this.btncomparar.TabIndex = 2;
            this.btncomparar.Text = "COMPARAR IMAGEN";
            this.btncomparar.UseVisualStyleBackColor = true;
            this.btncomparar.Click += new System.EventHandler(this.btncomparar_Click);
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(49, 353);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(125, 23);
            this.btncargar.TabIndex = 3;
            this.btncargar.Text = "CARGAR IMAGEN";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(359, 353);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(148, 23);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "GUARDAR NUEVA ID";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // pbImagenn
            // 
            this.pbImagenn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbImagenn.Image = global::Examen_IA.Properties.Resources.ID_HONDURAS;
            this.pbImagenn.Location = new System.Drawing.Point(61, 12);
            this.pbImagenn.Name = "pbImagenn";
            this.pbImagenn.Size = new System.Drawing.Size(525, 326);
            this.pbImagenn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenn.TabIndex = 0;
            this.pbImagenn.TabStop = false;
            this.pbImagenn.Click += new System.EventHandler(this.pbImagenn_Click);
            this.pbImagenn.DoubleClick += new System.EventHandler(this.pbImagenn_DoubleClick);
            // 
            // ofb
            // 
            this.ofb.FileName = "openFileDialog1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 405);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btncomparar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pbImagenn);
            this.Name = "Principal";
            this.Text = "Principal";
            this.DoubleClick += new System.EventHandler(this.pbImagenn_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenn;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncomparar;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.OpenFileDialog ofb;
    }
}