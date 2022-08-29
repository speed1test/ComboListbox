namespace EjercicioPrueba
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
            this.btnInput = new System.Windows.Forms.Button();
            this.dtaTabla = new System.Windows.Forms.DataGridView();
            this.btnForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(32, 233);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(130, 52);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Ingreso de datos";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dtaTabla
            // 
            this.dtaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaTabla.Location = new System.Drawing.Point(32, 12);
            this.dtaTabla.Name = "dtaTabla";
            this.dtaTabla.Size = new System.Drawing.Size(642, 184);
            this.dtaTabla.TabIndex = 1;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(544, 228);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(130, 52);
            this.btnForm2.TabIndex = 2;
            this.btnForm2.Text = "Ejercicio #2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 297);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.dtaTabla);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtaTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.DataGridView dtaTabla;
        private System.Windows.Forms.Button btnForm2;
    }
}

