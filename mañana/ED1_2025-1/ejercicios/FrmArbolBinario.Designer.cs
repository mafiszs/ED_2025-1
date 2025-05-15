namespace ejercicios
{
    partial class FrmArbolBinario
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
            this.btnInsertarRamas = new System.Windows.Forms.Button();
            this.btnInsertarRaiz = new System.Windows.Forms.Button();
            this.rbIzquierda = new System.Windows.Forms.RadioButton();
            this.rbDerecha = new System.Windows.Forms.RadioButton();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "ARBOL BINARIO";
            // 
            // btnInsertarRamas
            // 
            this.btnInsertarRamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRamas.Location = new System.Drawing.Point(24, 170);
            this.btnInsertarRamas.Name = "btnInsertarRamas";
            this.btnInsertarRamas.Size = new System.Drawing.Size(118, 34);
            this.btnInsertarRamas.TabIndex = 40;
            this.btnInsertarRamas.Text = "Insertar Ramas";
            this.btnInsertarRamas.UseVisualStyleBackColor = true;
            this.btnInsertarRamas.Click += new System.EventHandler(this.btnInsertarRamas_Click);
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(24, 130);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(118, 34);
            this.btnInsertarRaiz.TabIndex = 39;
            this.btnInsertarRaiz.Text = "Insertar Raíz";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // rbIzquierda
            // 
            this.rbIzquierda.AutoSize = true;
            this.rbIzquierda.Location = new System.Drawing.Point(53, 222);
            this.rbIzquierda.Name = "rbIzquierda";
            this.rbIzquierda.Size = new System.Drawing.Size(68, 17);
            this.rbIzquierda.TabIndex = 41;
            this.rbIzquierda.TabStop = true;
            this.rbIzquierda.Text = "Izquierda";
            this.rbIzquierda.UseVisualStyleBackColor = true;
            // 
            // rbDerecha
            // 
            this.rbDerecha.AutoSize = true;
            this.rbDerecha.Location = new System.Drawing.Point(53, 245);
            this.rbDerecha.Name = "rbDerecha";
            this.rbDerecha.Size = new System.Drawing.Size(66, 17);
            this.rbDerecha.TabIndex = 42;
            this.rbDerecha.TabStop = true;
            this.rbDerecha.Text = "Derecha";
            this.rbDerecha.UseVisualStyleBackColor = true;
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(195, 83);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(151, 26);
            this.textNumero.TabIndex = 44;
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ingrese número:";
            // 
            // btnAltura
            // 
            this.btnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(24, 290);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(118, 34);
            this.btnAltura.TabIndex = 45;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(180, 134);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 217);
            this.treeView1.TabIndex = 46;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FrmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbDerecha);
            this.Controls.Add(this.rbIzquierda);
            this.Controls.Add(this.btnInsertarRamas);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.label2);
            this.Name = "FrmArbolBinario";
            this.Text = "FrmArbolBinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarRamas;
        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.RadioButton rbIzquierda;
        private System.Windows.Forms.RadioButton rbDerecha;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.TreeView treeView1;
    }
}