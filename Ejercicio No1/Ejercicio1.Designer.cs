
namespace Ejercicio_No1
{
    partial class Ejercicio1
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
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.parImparlabel = new System.Windows.Forms.Label();
            this.PosiNegalabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un valor:";
            // 
            // ValortextBox
            // 
            this.ValortextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValortextBox.Location = new System.Drawing.Point(231, 49);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(175, 28);
            this.ValortextBox.TabIndex = 1;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Calcularbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.Location = new System.Drawing.Point(231, 123);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(175, 42);
            this.Calcularbutton.TabIndex = 2;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // parImparlabel
            // 
            this.parImparlabel.AutoSize = true;
            this.parImparlabel.Location = new System.Drawing.Point(70, 212);
            this.parImparlabel.Name = "parImparlabel";
            this.parImparlabel.Size = new System.Drawing.Size(156, 17);
            this.parImparlabel.TabIndex = 3;
            this.parImparlabel.Text = "El numero es Par/Impar";
            // 
            // PosiNegalabel
            // 
            this.PosiNegalabel.AutoSize = true;
            this.PosiNegalabel.Location = new System.Drawing.Point(356, 212);
            this.PosiNegalabel.Name = "PosiNegalabel";
            this.PosiNegalabel.Size = new System.Drawing.Size(204, 17);
            this.PosiNegalabel.TabIndex = 4;
            this.PosiNegalabel.Text = "El numero es Positivo/Negativo";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 366);
            this.Controls.Add(this.PosiNegalabel);
            this.Controls.Add(this.parImparlabel);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.ValortextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label parImparlabel;
        private System.Windows.Forms.Label PosiNegalabel;
    }
}

