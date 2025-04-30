
namespace _5A_Menu_While_FM
{
    partial class frmMenu
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
            this.btnOp1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnOp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOp1
            // 
            this.btnOp1.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp1.Location = new System.Drawing.Point(22, 68);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(117, 37);
            this.btnOp1.TabIndex = 0;
            this.btnOp1.Text = "Repetir Texto ";
            this.btnOp1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elija una Opción ";
            // 
            // btnOp2
            // 
            this.btnOp2.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp2.Location = new System.Drawing.Point(22, 123);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(117, 37);
            this.btnOp2.TabIndex = 0;
            this.btnOp2.Text = "Pares e Impares ";
            this.btnOp2.UseVisualStyleBackColor = true;
            this.btnOp2.Click += new System.EventHandler(this.btnOp2_Click);
            // 
            // btnOp3
            // 
            this.btnOp3.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp3.Location = new System.Drawing.Point(22, 180);
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.Size = new System.Drawing.Size(117, 37);
            this.btnOp3.TabIndex = 0;
            this.btnOp3.Text = "Sumatoria ";
            this.btnOp3.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOp3);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnOp1);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOp2;
        private System.Windows.Forms.Button btnOp3;
    }
}

