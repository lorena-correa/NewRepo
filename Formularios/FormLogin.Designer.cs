namespace appSubastaTrabajo
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtContrasenia = new TextBox();
            btnIniciarSesion = new Button();
            btnCrearCuenta = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(186, 98);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Tag = "id_usuario";
            label1.Text = "ID Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AccessibleDescription = "Ej: Juan123";
            txtUsuario.Cursor = Cursors.Hand;
            txtUsuario.ForeColor = SystemColors.WindowText;
            txtUsuario.Location = new Point(186, 116);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(186, 154);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Tag = "contrasenia";
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Cursor = Cursors.Hand;
            txtContrasenia.Location = new Point(186, 172);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(158, 23);
            txtContrasenia.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.SteelBlue;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatStyle = FlatStyle.System;
            btnIniciarSesion.ForeColor = SystemColors.Menu;
            btnIniciarSesion.Location = new Point(186, 217);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(158, 23);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Cursor = Cursors.Hand;
            btnCrearCuenta.Location = new Point(186, 250);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(158, 23);
            btnCrearCuenta.TabIndex = 5;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 56);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 6;
            label3.Text = "Inicio de Sesión Subasta Online";
            label3.Click += label3_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 327);
            Controls.Add(label3);
            Controls.Add(btnCrearCuenta);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContrasenia);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Aplicación de Subastas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtContrasenia;
        private Button btnIniciarSesion;
        private Button btnCrearCuenta;
        private Label label3;
    }
}
