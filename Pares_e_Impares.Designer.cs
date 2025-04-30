
namespace _5A_Menu_While_FM
{
    partial class Pares_e_Impares
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
            this.btnpares = new System.Windows.Forms.Button();
            this.btnimpares = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnpares
            // 
            this.btnpares.Location = new System.Drawing.Point(12, 28);
            this.btnpares.Name = "btnpares";
            this.btnpares.Size = new System.Drawing.Size(213, 33);
            this.btnpares.TabIndex = 0;
            this.btnpares.Text = "Pares";
            this.btnpares.UseVisualStyleBackColor = true;
            this.btnpares.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnimpares
            // 
            this.btnimpares.Location = new System.Drawing.Point(12, 67);
            this.btnimpares.Name = "btnimpares";
            this.btnimpares.Size = new System.Drawing.Size(213, 33);
            this.btnimpares.TabIndex = 0;
            this.btnimpares.Text = "Impares ";
            this.btnimpares.UseVisualStyleBackColor = true;
            this.btnimpares.Click += new System.EventHandler(this.btnimpares_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 199);
            this.listBox1.TabIndex = 1;
            // 
            // Pares_e_Impares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 312);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnimpares);
            this.Controls.Add(this.btnpares);
            this.Name = "Pares_e_Impares";
            this.Text = "Pares_e_Impares";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpares;
        private System.Windows.Forms.Button btnimpares;
        private System.Windows.Forms.ListBox listBox1;
    }
}