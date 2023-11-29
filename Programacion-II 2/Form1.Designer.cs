namespace Programacion_II_2
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.btnresul = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMEROS";
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(371, 73);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 20);
            this.Num1.TabIndex = 1;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(371, 112);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 20);
            this.Num2.TabIndex = 2;
            // 
            // btnresul
            // 
            this.btnresul.Location = new System.Drawing.Point(343, 163);
            this.btnresul.Name = "btnresul";
            this.btnresul.Size = new System.Drawing.Size(75, 23);
            this.btnresul.TabIndex = 3;
            this.btnresul.Text = "MOSTRAR";
            this.btnresul.UseVisualStyleBackColor = true;
            this.btnresul.Click += new System.EventHandler(this.btnresul_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(354, 205);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(163, 20);
            this.Mostrar.TabIndex = 4;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(442, 163);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Limpiar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.btnresul);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Button btnresul;
        private System.Windows.Forms.TextBox Mostrar;
        private System.Windows.Forms.Button btnclear;
    }
}

