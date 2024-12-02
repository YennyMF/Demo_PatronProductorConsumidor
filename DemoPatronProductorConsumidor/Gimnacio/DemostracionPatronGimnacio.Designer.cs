namespace DemoPatronProductorConsumidor.Gimnacio
{
    partial class DemostracionPatronGimnacio
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
            txtTelefono = new TextBox();
            label3 = new Label();
            BtnRegistrar = new Button();
            TxtCorreo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TxtNombres = new TextBox();
            panel2 = new Panel();
            BtnProcesar = new Button();
            DgvClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(TxtCorreo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtNombres);
            panel1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 244);
            panel1.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Times New Roman", 10.8F);
            txtTelefono.Location = new Point(21, 199);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(356, 28);
            txtTelefono.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 164);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.FromArgb(192, 192, 255);
            BtnRegistrar.Location = new Point(398, 199);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(94, 29);
            BtnRegistrar.TabIndex = 5;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click_1;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Font = new Font("Times New Roman", 10.8F);
            TxtCorreo.Location = new Point(21, 118);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(356, 28);
            TxtCorreo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 95);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 3;
            label2.Text = "Correo Electronico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombres:";
            // 
            // TxtNombres
            // 
            TxtNombres.Font = new Font("Times New Roman", 10.8F);
            TxtNombres.Location = new Point(21, 46);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(356, 28);
            TxtNombres.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnProcesar);
            panel2.Controls.Add(DgvClientes);
            panel2.Location = new Point(12, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 214);
            panel2.TabIndex = 2;
            // 
            // BtnProcesar
            // 
            BtnProcesar.BackColor = Color.FromArgb(255, 192, 255);
            BtnProcesar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProcesar.Location = new Point(641, 14);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(99, 29);
            BtnProcesar.TabIndex = 1;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = false;
            BtnProcesar.Click += BtnProcesar_Click_1;
            // 
            // DgvClientes
            // 
            DgvClientes.AllowUserToAddRows = false;
            DgvClientes.AllowUserToDeleteRows = false;
            DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Telefono, Fecha });
            DgvClientes.Location = new Point(3, 14);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.ReadOnly = true;
            DgvClientes.RowHeadersWidth = 51;
            DgvClientes.Size = new Size(632, 208);
            DgvClientes.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // DemostracionPatronGimnacio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 517);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DemostracionPatronGimnacio";
            Text = "DemostracionPatronGimnacio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnRegistrar;
        private TextBox TxtCorreo;
        private Label label2;
        private Label label1;
        private TextBox TxtNombres;
        private Panel panel2;
        private Button BtnProcesar;
        private DataGridView DgvClientes;
        private TextBox txtTelefono;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Fecha;
    }
}