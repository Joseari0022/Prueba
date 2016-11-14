namespace RegistroIng.Registros
{
    partial class RegistroObras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroObras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstudiantescomboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.EstudiantedataGridView = new System.Windows.Forms.DataGridView();
            this.Idbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstudiantescomboBox);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.EstudiantedataGridView);
            this.groupBox1.Location = new System.Drawing.Point(15, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(499, 223);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // EstudiantescomboBox
            // 
            this.EstudiantescomboBox.FormattingEnabled = true;
            this.EstudiantescomboBox.Location = new System.Drawing.Point(21, 32);
            this.EstudiantescomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EstudiantescomboBox.Name = "EstudiantescomboBox";
            this.EstudiantescomboBox.Size = new System.Drawing.Size(161, 24);
            this.EstudiantescomboBox.TabIndex = 62;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(379, 32);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(84, 30);
            this.Agregarbutton.TabIndex = 61;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // EstudiantedataGridView
            // 
            this.EstudiantedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantedataGridView.Location = new System.Drawing.Point(21, 66);
            this.EstudiantedataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EstudiantedataGridView.Name = "EstudiantedataGridView";
            this.EstudiantedataGridView.RowTemplate.Height = 24;
            this.EstudiantedataGridView.Size = new System.Drawing.Size(440, 150);
            this.EstudiantedataGridView.TabIndex = 59;
            // 
            // Idbutton
            // 
            this.Idbutton.Image = ((System.Drawing.Image)(resources.GetObject("Idbutton.Image")));
            this.Idbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Idbutton.Location = new System.Drawing.Point(226, 11);
            this.Idbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Idbutton.Name = "Idbutton";
            this.Idbutton.Size = new System.Drawing.Size(89, 43);
            this.Idbutton.TabIndex = 86;
            this.Idbutton.Text = "Id";
            this.Idbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Idbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 370);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(103, 41);
            this.Nuevobutton.TabIndex = 85;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(271, 370);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(103, 41);
            this.Eliminarbutton.TabIndex = 84;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(143, 370);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(103, 41);
            this.Guardarbutton.TabIndex = 83;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Id";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(15, 88);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(183, 22);
            this.NombretextBox.TabIndex = 80;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(15, 30);
            this.IdtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(100, 22);
            this.IdtextBox.TabIndex = 79;
            // 
            // RegistroObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Idbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IdtextBox);
            this.Name = "RegistroObras";
            this.Text = "RegistroObras";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox EstudiantescomboBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridView EstudiantedataGridView;
        private System.Windows.Forms.Button Idbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox IdtextBox;
    }
}