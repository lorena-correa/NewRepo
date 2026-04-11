namespace appSubastaTrabajo.Formularios
{
    partial class FormPrincipal
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
            panel1 = new Panel();
            lblTipoUsuario = new Label();
            lblIdUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            label10 = new Label();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTipoUsuario);
            panel1.Controls.Add(lblIdUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 26);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(277, 5);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(71, 15);
            lblTipoUsuario.TabIndex = 3;
            lblTipoUsuario.Text = "TipoUsuario";
            lblTipoUsuario.Click += label4_Click;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(65, 4);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(57, 15);
            lblIdUsuario.TabIndex = 2;
            lblIdUsuario.Text = "IdUsuario";
            lblIdUsuario.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 5);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 263);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(200, 246);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 0;
            label5.Text = "Subastas Activas";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Producto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 161);
            panel4.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 124);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 6;
            label10.Text = "idEstado";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 124);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 5;
            label9.Text = "Estado:";
            // 
            // button2
            // 
            button2.Location = new Point(14, 73);
            button2.Name = "button2";
            button2.Size = new Size(234, 23);
            button2.TabIndex = 4;
            button2.Text = "Aceptar precio actual";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(168, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ofertar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 36);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 1;
            label8.Text = "Oferta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(5, 9);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 0;
            label7.Text = "Acciones";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label lblTipoUsuario;
        private Label lblIdUsuario;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label7;
        private GroupBox groupBox1;
        private Label label9;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label8;
        private Label label10;
    }
}