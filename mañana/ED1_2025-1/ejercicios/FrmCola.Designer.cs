namespace ejercicios
{
    partial class FrmCola
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.btnCantidaddeElementos = new System.Windows.Forms.Button();
            this.btnVistazo = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(27, 336);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 34);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.Location = new System.Drawing.Point(166, 149);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(227, 186);
            this.listDatos.TabIndex = 41;
            // 
            // btnCantidaddeElementos
            // 
            this.btnCantidaddeElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidaddeElementos.Location = new System.Drawing.Point(27, 277);
            this.btnCantidaddeElementos.Name = "btnCantidaddeElementos";
            this.btnCantidaddeElementos.Size = new System.Drawing.Size(118, 53);
            this.btnCantidaddeElementos.TabIndex = 40;
            this.btnCantidaddeElementos.Text = "Cantidad de Elementos";
            this.btnCantidaddeElementos.UseVisualStyleBackColor = true;
            this.btnCantidaddeElementos.Click += new System.EventHandler(this.btnCantidaddeElementos_Click);
            // 
            // btnVistazo
            // 
            this.btnVistazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistazo.Location = new System.Drawing.Point(27, 234);
            this.btnVistazo.Name = "btnVistazo";
            this.btnVistazo.Size = new System.Drawing.Size(118, 34);
            this.btnVistazo.TabIndex = 39;
            this.btnVistazo.Text = "Vistazo";
            this.btnVistazo.UseVisualStyleBackColor = true;
            this.btnVistazo.Click += new System.EventHandler(this.btnVistazo_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencolar.Location = new System.Drawing.Point(27, 192);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(118, 34);
            this.btnDesencolar.TabIndex = 38;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncolar.Location = new System.Drawing.Point(27, 149);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(118, 34);
            this.btnEncolar.TabIndex = 37;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(213, 91);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(151, 26);
            this.textNombre.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ingrese nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "COLA (QUEUE) - FIFO";
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 444);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.listDatos);
            this.Controls.Add(this.btnCantidaddeElementos);
            this.Controls.Add(this.btnVistazo);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmCola";
            this.Text = "FrmCola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox listDatos;
        private System.Windows.Forms.Button btnCantidaddeElementos;
        private System.Windows.Forms.Button btnVistazo;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}