namespace ejercicios
{
    partial class FrmListaSimple
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
            this.label2 = new System.Windows.Forms.Label();
            this.listNumeros = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btrInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btrBuscar = new System.Windows.Forms.Button();
            this.btrOrdenar = new System.Windows.Forms.Button();
            this.btrMezclar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "LISTA ENLAZADA SIMPLE";
            // 
            // listNumeros
            // 
            this.listNumeros.FormattingEnabled = true;
            this.listNumeros.Location = new System.Drawing.Point(128, 110);
            this.listNumeros.Name = "listNumeros";
            this.listNumeros.Size = new System.Drawing.Size(100, 121);
            this.listNumeros.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(42, 139);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(128, 62);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 8;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // btrInsertar
            // 
            this.btrInsertar.Location = new System.Drawing.Point(42, 110);
            this.btrInsertar.Name = "btrInsertar";
            this.btrInsertar.Size = new System.Drawing.Size(75, 23);
            this.btrInsertar.TabIndex = 7;
            this.btrInsertar.Text = "Insertar";
            this.btrInsertar.UseVisualStyleBackColor = true;
            this.btrInsertar.Click += new System.EventHandler(this.btrInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese número:";
            // 
            // btrBuscar
            // 
            this.btrBuscar.Location = new System.Drawing.Point(42, 168);
            this.btrBuscar.Name = "btrBuscar";
            this.btrBuscar.Size = new System.Drawing.Size(75, 23);
            this.btrBuscar.TabIndex = 12;
            this.btrBuscar.Text = "Buscar";
            this.btrBuscar.UseVisualStyleBackColor = true;
            this.btrBuscar.Click += new System.EventHandler(this.btrBuscar_Click);
            // 
            // btrOrdenar
            // 
            this.btrOrdenar.Location = new System.Drawing.Point(42, 197);
            this.btrOrdenar.Name = "btrOrdenar";
            this.btrOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btrOrdenar.TabIndex = 13;
            this.btrOrdenar.Text = "Ordenar";
            this.btrOrdenar.UseVisualStyleBackColor = true;
            this.btrOrdenar.Click += new System.EventHandler(this.btrOrdenar_Click);
            // 
            // btrMezclar
            // 
            this.btrMezclar.Location = new System.Drawing.Point(42, 226);
            this.btrMezclar.Name = "btrMezclar";
            this.btrMezclar.Size = new System.Drawing.Size(75, 23);
            this.btrMezclar.TabIndex = 14;
            this.btrMezclar.Text = "Mezclar";
            this.btrMezclar.UseVisualStyleBackColor = true;
            // 
            // FrmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 373);
            this.Controls.Add(this.btrMezclar);
            this.Controls.Add(this.btrOrdenar);
            this.Controls.Add(this.btrBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listNumeros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btrInsertar);
            this.Controls.Add(this.label1);
            this.Name = "FrmListaSimple";
            this.Text = "FrmListaSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listNumeros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btrInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btrBuscar;
        private System.Windows.Forms.Button btrOrdenar;
        private System.Windows.Forms.Button btrMezclar;
    }
}