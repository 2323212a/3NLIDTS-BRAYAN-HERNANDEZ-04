namespace _3NLIDTS_BRAYAN_HERNANDEZ_04
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.btnregistros = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "estatura";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(154, 51);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(154, 167);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 22);
            this.txttelefono.TabIndex = 6;
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(154, 139);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 22);
            this.txtestatura.TabIndex = 7;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(154, 109);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 22);
            this.txtedad.TabIndex = 8;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(154, 81);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 22);
            this.txtapellido.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbfemenino);
            this.groupBox1.Controls.Add(this.rbmasculino);
            this.groupBox1.Location = new System.Drawing.Point(154, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 52);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero:";
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(155, 21);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(88, 20);
            this.rbfemenino.TabIndex = 1;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(6, 21);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(89, 20);
            this.rbmasculino.TabIndex = 0;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // btnregistros
            // 
            this.btnregistros.Location = new System.Drawing.Point(454, 277);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Size = new System.Drawing.Size(75, 23);
            this.btnregistros.TabIndex = 13;
            this.btnregistros.Text = "Registros";
            this.btnregistros.UseVisualStyleBackColor = true;
            this.btnregistros.Click += new System.EventHandler(this.btnregistros_Click_1);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(25, 276);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 14;
            this.btnborrar.Text = "borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnregistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.Button btnregistros;
        private System.Windows.Forms.Button btnborrar;
    }
}

