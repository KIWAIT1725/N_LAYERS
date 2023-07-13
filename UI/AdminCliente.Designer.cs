namespace UI
{
    partial class AdminCliente
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCliente = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnAnular = new Button();
            lblListaClientes = new Label();
            gridClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(255, 128, 255);
            lblNombre.Location = new Point(13, 10);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(114, 16);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Cliente";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.MenuHighlight;
            txtNombre.Location = new Point(13, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(308, 22);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.MenuHighlight;
            txtTelefono.Location = new Point(13, 92);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(308, 22);
            txtTelefono.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(255, 128, 255);
            lblTelefono.Location = new Point(13, 73);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(118, 16);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Telefono del Cliente\r\n";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.MenuHighlight;
            txtCorreo.Location = new Point(13, 157);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(308, 22);
            txtCorreo.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.FromArgb(255, 128, 255);
            lblCliente.Location = new Point(13, 138);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(109, 16);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Correo del Cliente";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(0, 192, 0);
            btnNuevo.Location = new Point(27, 208);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(66, 25);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 192, 192);
            btnGuardar.Location = new Point(134, 208);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 25);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.FromArgb(192, 0, 0);
            btnAnular.Location = new Point(234, 208);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(66, 25);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = false;
            // 
            // lblListaClientes
            // 
            lblListaClientes.AutoSize = true;
            lblListaClientes.BackColor = Color.DodgerBlue;
            lblListaClientes.Location = new Point(13, 250);
            lblListaClientes.Name = "lblListaClientes";
            lblListaClientes.Size = new Size(163, 16);
            lblListaClientes.TabIndex = 9;
            lblListaClientes.Text = "Lista de Clientes Ingresados";
            // 
            // gridClientes
            // 
            gridClientes.BackgroundColor = Color.FromArgb(224, 224, 224);
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(12, 277);
            gridClientes.Name = "gridClientes";
            gridClientes.RowTemplate.Height = 25;
            gridClientes.Size = new Size(308, 144);
            gridClientes.TabIndex = 10;
            // 
            // AdminCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(341, 434);
            Controls.Add(gridClientes);
            Controls.Add(lblListaClientes);
            Controls.Add(btnAnular);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCorreo);
            Controls.Add(lblCliente);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "AdminCliente";
            Text = "AdminCliente";
            Load += AdminCliente_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCliente;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnAnular;
        private Label lblListaClientes;
        private DataGridView gridClientes;
    }
}