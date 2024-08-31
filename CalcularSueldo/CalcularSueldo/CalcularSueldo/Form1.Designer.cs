namespace CalcularSueldo
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblLegajo = new Label();
            lblSueldoDiario = new Label();
            lblSueldo = new Label();
            btnGuardar = new Button();
            btnCalcular = new Button();
            txtNombre = new TextBox();
            txtLegajo = new TextBox();
            txtSueloDiario = new TextBox();
            txtSueldo = new TextBox();
            panel1 = new Panel();
            btnSalir = new Button();
            btnNuevo = new Button();
            txtDiastrabajados = new TextBox();
            lblDiasTrabajados = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(125, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(287, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculo de sueldos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(54, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(54, 130);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 2;
            lblLegajo.Text = "Legajo";
            // 
            // lblSueldoDiario
            // 
            lblSueldoDiario.AutoSize = true;
            lblSueldoDiario.Location = new Point(54, 165);
            lblSueldoDiario.Name = "lblSueldoDiario";
            lblSueldoDiario.Size = new Size(76, 15);
            lblSueldoDiario.TabIndex = 3;
            lblSueldoDiario.Text = "Sueldo diario";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(54, 368);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(43, 15);
            lblSueldo.TabIndex = 4;
            lblSueldo.Text = "Sueldo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(144, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(251, 59);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar Registro";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(144, 321);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(251, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular Sueldo";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(144, 127);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(251, 23);
            txtLegajo.TabIndex = 2;
            // 
            // txtSueloDiario
            // 
            txtSueloDiario.Location = new Point(144, 162);
            txtSueloDiario.Name = "txtSueloDiario";
            txtSueloDiario.Size = new Size(251, 23);
            txtSueloDiario.TabIndex = 3;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(144, 365);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(251, 23);
            txtSueldo.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnNuevo);
            panel1.Location = new Point(-6, 486);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 50);
            panel1.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(480, 16);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(18, 16);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(91, 23);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtDiastrabajados
            // 
            txtDiastrabajados.Location = new Point(144, 196);
            txtDiastrabajados.Name = "txtDiastrabajados";
            txtDiastrabajados.Size = new Size(251, 23);
            txtDiastrabajados.TabIndex = 4;
            // 
            // lblDiasTrabajados
            // 
            lblDiasTrabajados.AutoSize = true;
            lblDiasTrabajados.Location = new Point(54, 199);
            lblDiasTrabajados.Name = "lblDiasTrabajados";
            lblDiasTrabajados.Size = new Size(88, 15);
            lblDiasTrabajados.TabIndex = 12;
            lblDiasTrabajados.Text = "Dias Trabajados";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 537);
            Controls.Add(txtDiastrabajados);
            Controls.Add(lblDiasTrabajados);
            Controls.Add(panel1);
            Controls.Add(txtSueldo);
            Controls.Add(txtSueloDiario);
            Controls.Add(txtLegajo);
            Controls.Add(txtNombre);
            Controls.Add(btnCalcular);
            Controls.Add(btnGuardar);
            Controls.Add(lblSueldo);
            Controls.Add(lblSueldoDiario);
            Controls.Add(lblLegajo);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblLegajo;
        private Label lblSueldoDiario;
        private Label lblSueldo;
        private Button btnGuardar;
        private Button btnCalcular;
        private TextBox txtNombre;
        private TextBox txtLegajo;
        private TextBox txtSueloDiario;
        private TextBox txtSueldo;
        private Panel panel1;
        private Button btnSalir;
        private Button btnNuevo;
        private TextBox txtDiastrabajados;
        private Label lblDiasTrabajados;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}
