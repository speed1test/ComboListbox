namespace EjercicioPrueba
{
    partial class Form2
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
            this.lstInfo1 = new System.Windows.Forms.ListBox();
            this.cmbInfo = new System.Windows.Forms.ComboBox();
            this.btnLlenarInfo = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstInfo1
            // 
            this.lstInfo1.FormattingEnabled = true;
            this.lstInfo1.Location = new System.Drawing.Point(21, 12);
            this.lstInfo1.Name = "lstInfo1";
            this.lstInfo1.Size = new System.Drawing.Size(120, 95);
            this.lstInfo1.TabIndex = 0;
            // 
            // cmbInfo
            // 
            this.cmbInfo.FormattingEnabled = true;
            this.cmbInfo.Location = new System.Drawing.Point(179, 12);
            this.cmbInfo.Name = "cmbInfo";
            this.cmbInfo.Size = new System.Drawing.Size(121, 21);
            this.cmbInfo.TabIndex = 1;
            // 
            // btnLlenarInfo
            // 
            this.btnLlenarInfo.Location = new System.Drawing.Point(21, 127);
            this.btnLlenarInfo.Name = "btnLlenarInfo";
            this.btnLlenarInfo.Size = new System.Drawing.Size(93, 49);
            this.btnLlenarInfo.TabIndex = 2;
            this.btnLlenarInfo.Text = "Llenar de info";
            this.btnLlenarInfo.UseVisualStyleBackColor = true;
            this.btnLlenarInfo.Click += new System.EventHandler(this.btnLlenarInfo_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(207, 127);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(93, 49);
            this.btnSeleccion.TabIndex = 3;
            this.btnSeleccion.Text = "Imprimir selección";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 188);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.btnLlenarInfo);
            this.Controls.Add(this.cmbInfo);
            this.Controls.Add(this.lstInfo1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInfo1;
        private System.Windows.Forms.ComboBox cmbInfo;
        private System.Windows.Forms.Button btnLlenarInfo;
        private System.Windows.Forms.Button btnSeleccion;
    }
}