namespace appSubastaTrabajo
{
    partial class FormRegistro
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            cmbTipoUsuario = new ComboBox();
            label4 = new Label();
            txtContrasenia = new TextBox();
            btnCrearCuenta = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 28);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 0;
            label1.Text = "Registro Usuario Subasta";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 72);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "ID Usuario";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(187, 90);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(171, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 129);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo de Usuario";
            label3.Click += label3_Click;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(187, 147);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(171, 23);
            cmbTipoUsuario.TabIndex = 4;
            cmbTipoUsuario.SelectedIndexChanged += cmbTipoUsuario_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 185);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(187, 203);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(171, 23);
            txtContrasenia.TabIndex = 6;
            txtContrasenia.Tag = "txtContrasenia";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(188, 248);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(170, 23);
            btnCrearCuenta.TabIndex = 7;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 292);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Atrás";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 327);
            Controls.Add(button2);
            Controls.Add(btnCrearCuenta);
            Controls.Add(txtContrasenia);
            Controls.Add(label4);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistro";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private ComboBox cmbTipoUsuario;
        private Label label4;
        private TextBox txtContrasenia;
        private Button btnCrearCuenta;
        private Button button2;
    }
}