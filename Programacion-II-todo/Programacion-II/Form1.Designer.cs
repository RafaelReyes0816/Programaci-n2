namespace Programacion_II
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
            this.txtResul = new System.Windows.Forms.TextBox();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResul
            // 
            this.txtResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResul.Location = new System.Drawing.Point(12, 12);
            this.txtResul.Multiline = true;
            this.txtResul.Name = "txtResul";
            this.txtResul.ReadOnly = true;
            this.txtResul.Size = new System.Drawing.Size(468, 40);
            this.txtResul.TabIndex = 0;
            this.txtResul.Text = "0";
            this.txtResul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Num3
            // 
            this.Num3.Location = new System.Drawing.Point(12, 98);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(45, 45);
            this.Num3.TabIndex = 1;
            this.Num3.Text = "1";
            this.Num3.UseVisualStyleBackColor = true;
            // 
            // Num4
            // 
            this.Num4.Location = new System.Drawing.Point(12, 150);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(45, 45);
            this.Num4.TabIndex = 2;
            this.Num4.Text = "2";
            this.Num4.UseVisualStyleBackColor = true;
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(12, 203);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(45, 45);
            this.Num1.TabIndex = 3;
            this.Num1.Text = "3";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num0
            // 
            this.Num0.Location = new System.Drawing.Point(96, 252);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(45, 45);
            this.Num0.TabIndex = 7;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 311);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.txtResul);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num0;
    }
}

