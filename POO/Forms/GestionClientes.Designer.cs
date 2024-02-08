namespace POO
{
    partial class GestionClientes
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
            listClientes = new ListBox();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtTarjetaCredito = new TextBox();
            btnEditar = new Button();
            label5 = new Label();
            btnAgregar = new Button();
            lblId = new Label();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 25;
            listClientes.Location = new Point(17, 20);
            listClientes.Margin = new Padding(4, 5, 4, 5);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(448, 404);
            listClientes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(704, 274);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(600, 61);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 31);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(351, 437);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 38);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(600, 108);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(214, 31);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(600, 156);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 31);
            txtTelefono.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 211);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 2;
            label4.Text = "Tarjeta Crédito";
            // 
            // txtTarjetaCredito
            // 
            txtTarjetaCredito.Location = new Point(600, 206);
            txtTarjetaCredito.Margin = new Padding(4, 5, 4, 5);
            txtTarjetaCredito.Name = "txtTarjetaCredito";
            txtTarjetaCredito.Size = new Size(214, 31);
            txtTarjetaCredito.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(224, 437);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 20);
            label5.Name = "label5";
            label5.Size = new Size(34, 25);
            label5.TabIndex = 6;
            label5.Text = "ID:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(90, 437);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 38);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(600, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 25);
            lblId.TabIndex = 9;
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 750);
            Controls.Add(lblId);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txtTarjetaCredito);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(listClientes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionClientes";
            Text = "Form1";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtTarjetaCredito;
        private Button btnEditar;
        private Label label5;
        private Button btnAgregar;
        private Label lblId;
    }
}