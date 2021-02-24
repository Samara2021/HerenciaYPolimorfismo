
namespace FORMULARIOS
{
    partial class FRMEMPLEADOS
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
            this.GboEmpleados = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.CboTipoContrato = new System.Windows.Forms.ComboBox();
            this.CboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.TxtNumSegSoc = new System.Windows.Forms.TextBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblTipoContrato = new System.Windows.Forms.Label();
            this.LblTipoEmpleado = new System.Windows.Forms.Label();
            this.LblNumSegSoc = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DGVEMPLEADOS = new System.Windows.Forms.DataGridView();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LISTACEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblGenerarCedula = new System.Windows.Forms.Label();
            this.TxtGenerarListaCedula = new System.Windows.Forms.TextBox();
            this.GboEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // GboEmpleados
            // 
            this.GboEmpleados.Controls.Add(this.TxtGenerarListaCedula);
            this.GboEmpleados.Controls.Add(this.LblGenerarCedula);
            this.GboEmpleados.Controls.Add(this.BtnGuardar);
            this.GboEmpleados.Controls.Add(this.TxtCedula);
            this.GboEmpleados.Controls.Add(this.CboTipoContrato);
            this.GboEmpleados.Controls.Add(this.CboTipoEmpleado);
            this.GboEmpleados.Controls.Add(this.TxtNumSegSoc);
            this.GboEmpleados.Controls.Add(this.CboSexo);
            this.GboEmpleados.Controls.Add(this.TxtApMaterno);
            this.GboEmpleados.Controls.Add(this.TxtApPaterno);
            this.GboEmpleados.Controls.Add(this.LblCedula);
            this.GboEmpleados.Controls.Add(this.LblTipoContrato);
            this.GboEmpleados.Controls.Add(this.LblTipoEmpleado);
            this.GboEmpleados.Controls.Add(this.LblNumSegSoc);
            this.GboEmpleados.Controls.Add(this.LblSexo);
            this.GboEmpleados.Controls.Add(this.LblApMaterno);
            this.GboEmpleados.Controls.Add(this.LblApPaterno);
            this.GboEmpleados.Location = new System.Drawing.Point(12, 29);
            this.GboEmpleados.Name = "GboEmpleados";
            this.GboEmpleados.Size = new System.Drawing.Size(1088, 226);
            this.GboEmpleados.TabIndex = 0;
            this.GboEmpleados.TabStop = false;
            this.GboEmpleados.Text = "Empleados";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(775, 155);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 47);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(388, 169);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(132, 20);
            this.TxtCedula.TabIndex = 15;
            // 
            // CboTipoContrato
            // 
            this.CboTipoContrato.FormattingEnabled = true;
            this.CboTipoContrato.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CboTipoContrato.Location = new System.Drawing.Point(189, 169);
            this.CboTipoContrato.Name = "CboTipoContrato";
            this.CboTipoContrato.Size = new System.Drawing.Size(112, 21);
            this.CboTipoContrato.TabIndex = 14;
            this.CboTipoContrato.Text = "NUEVO";
            // 
            // CboTipoEmpleado
            // 
            this.CboTipoEmpleado.FormattingEnabled = true;
            this.CboTipoEmpleado.Items.AddRange(new object[] {
            "GERENTE",
            "VENDEDOR"});
            this.CboTipoEmpleado.Location = new System.Drawing.Point(24, 169);
            this.CboTipoEmpleado.Name = "CboTipoEmpleado";
            this.CboTipoEmpleado.Size = new System.Drawing.Size(112, 21);
            this.CboTipoEmpleado.TabIndex = 13;
            this.CboTipoEmpleado.Text = "VENDEDOR";
            // 
            // TxtNumSegSoc
            // 
            this.TxtNumSegSoc.Location = new System.Drawing.Point(598, 78);
            this.TxtNumSegSoc.Name = "TxtNumSegSoc";
            this.TxtNumSegSoc.Size = new System.Drawing.Size(147, 20);
            this.TxtNumSegSoc.TabIndex = 12;
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.CboSexo.Location = new System.Drawing.Point(394, 77);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(112, 21);
            this.CboSexo.TabIndex = 11;
            this.CboSexo.Text = "FEMENINO";
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(176, 78);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(143, 20);
            this.TxtApMaterno.TabIndex = 10;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(24, 78);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(124, 20);
            this.TxtApPaterno.TabIndex = 9;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(391, 139);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(50, 13);
            this.LblCedula.TabIndex = 8;
            this.LblCedula.Text = "CEDULA";
            // 
            // LblTipoContrato
            // 
            this.LblTipoContrato.AutoSize = true;
            this.LblTipoContrato.Location = new System.Drawing.Point(186, 139);
            this.LblTipoContrato.Name = "LblTipoContrato";
            this.LblTipoContrato.Size = new System.Drawing.Size(86, 13);
            this.LblTipoContrato.TabIndex = 7;
            this.LblTipoContrato.Text = "Tipo de Contrato";
            // 
            // LblTipoEmpleado
            // 
            this.LblTipoEmpleado.AutoSize = true;
            this.LblTipoEmpleado.Location = new System.Drawing.Point(21, 139);
            this.LblTipoEmpleado.Name = "LblTipoEmpleado";
            this.LblTipoEmpleado.Size = new System.Drawing.Size(93, 13);
            this.LblTipoEmpleado.TabIndex = 6;
            this.LblTipoEmpleado.Text = "Tipo de Empleado";
            // 
            // LblNumSegSoc
            // 
            this.LblNumSegSoc.AutoSize = true;
            this.LblNumSegSoc.Location = new System.Drawing.Point(595, 43);
            this.LblNumSegSoc.Name = "LblNumSegSoc";
            this.LblNumSegSoc.Size = new System.Drawing.Size(142, 13);
            this.LblNumSegSoc.TabIndex = 5;
            this.LblNumSegSoc.Text = "Numero de Seguridad Social";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(425, 43);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 4;
            this.LblSexo.Text = "Sexo";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(221, 43);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(86, 13);
            this.LblApMaterno.TabIndex = 2;
            this.LblApMaterno.Text = "Apellido Materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(30, 43);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(84, 13);
            this.LblApPaterno.TabIndex = 1;
            this.LblApPaterno.Text = "Apellido Paterno";
            // 
            // DGVEMPLEADOS
            // 
            this.DGVEMPLEADOS.AllowUserToAddRows = false;
            this.DGVEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.SEXO,
            this.NUMSEGSOC,
            this.TIPOEMPLEADO,
            this.TIPOCONTRATO,
            this.SUELDO,
            this.LISTACEDULA});
            this.DGVEMPLEADOS.Location = new System.Drawing.Point(12, 262);
            this.DGVEMPLEADOS.Name = "DGVEMPLEADOS";
            this.DGVEMPLEADOS.Size = new System.Drawing.Size(1088, 128);
            this.DGVEMPLEADOS.TabIndex = 1;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 200;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 200;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = " NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            // 
            // TIPOEMPLEADO
            // 
            this.TIPOEMPLEADO.HeaderText = "TIPO DE EMPLEADO";
            this.TIPOEMPLEADO.Name = "TIPOEMPLEADO";
            this.TIPOEMPLEADO.Width = 125;
            // 
            // TIPOCONTRATO
            // 
            this.TIPOCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPOCONTRATO.Name = "TIPOCONTRATO";
            this.TIPOCONTRATO.Width = 125;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.Name = "SUELDO";
            // 
            // LISTACEDULA
            // 
            this.LISTACEDULA.HeaderText = "LISTA DE CEDULA";
            this.LISTACEDULA.Name = "LISTACEDULA";
            // 
            // LblGenerarCedula
            // 
            this.LblGenerarCedula.AutoSize = true;
            this.LblGenerarCedula.Location = new System.Drawing.Point(611, 139);
            this.LblGenerarCedula.Name = "LblGenerarCedula";
            this.LblGenerarCedula.Size = new System.Drawing.Size(106, 13);
            this.LblGenerarCedula.TabIndex = 17;
            this.LblGenerarCedula.Text = "GENERAR CEDULA";
            // 
            // TxtGenerarListaCedula
            // 
            this.TxtGenerarListaCedula.Location = new System.Drawing.Point(605, 169);
            this.TxtGenerarListaCedula.Name = "TxtGenerarListaCedula";
            this.TxtGenerarListaCedula.Size = new System.Drawing.Size(132, 20);
            this.TxtGenerarListaCedula.TabIndex = 18;
            // 
            // FRMEMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 402);
            this.Controls.Add(this.DGVEMPLEADOS);
            this.Controls.Add(this.GboEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMEMPLEADOS";
            this.Text = "EMPLEADOS";
            this.GboEmpleados.ResumeLayout(false);
            this.GboEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboEmpleados;
        private System.Windows.Forms.Label LblTipoContrato;
        private System.Windows.Forms.Label LblTipoEmpleado;
        private System.Windows.Forms.Label LblNumSegSoc;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.ComboBox CboTipoContrato;
        private System.Windows.Forms.ComboBox CboTipoEmpleado;
        private System.Windows.Forms.TextBox TxtNumSegSoc;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.DataGridView DGVEMPLEADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LISTACEDULA;
        private System.Windows.Forms.TextBox TxtGenerarListaCedula;
        private System.Windows.Forms.Label LblGenerarCedula;
    }
}