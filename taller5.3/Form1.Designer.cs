namespace taller5._3
{
    partial class Form1
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
            this.txtlim = new System.Windows.Forms.TextBox();
            this.btnir = new System.Windows.Forms.Button();
            this.lbxserie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite a ser ejecutado:";
            // 
            // txtlim
            // 
            this.txtlim.Location = new System.Drawing.Point(186, 47);
            this.txtlim.Name = "txtlim";
            this.txtlim.Size = new System.Drawing.Size(58, 20);
            this.txtlim.TabIndex = 1;
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(269, 47);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(41, 20);
            this.btnir.TabIndex = 2;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // lbxserie
            // 
            this.lbxserie.FormattingEnabled = true;
            this.lbxserie.Location = new System.Drawing.Point(153, 94);
            this.lbxserie.Name = "lbxserie";
            this.lbxserie.Size = new System.Drawing.Size(60, 212);
            this.lbxserie.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 378);
            this.Controls.Add(this.lbxserie);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.txtlim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlim;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.ListBox lbxserie;
    }
}

