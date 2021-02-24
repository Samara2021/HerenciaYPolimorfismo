
namespace FORMULARIOS
{
    partial class FRMCLIENTES
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
            this.GPBCliente = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNumSegSoc = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblCodigoPedido = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtNumSegSoc = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.ApPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GPBCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCliente
            // 
            this.GPBCliente.Controls.Add(this.BtnGuardar);
            this.GPBCliente.Controls.Add(this.CmbCategoria);
            this.GPBCliente.Controls.Add(this.CmbSexo);
            this.GPBCliente.Controls.Add(this.TxtCodigoPedido);
            this.GPBCliente.Controls.Add(this.TxtCedula);
            this.GPBCliente.Controls.Add(this.TxtNumSegSoc);
            this.GPBCliente.Controls.Add(this.TxtApMaterno);
            this.GPBCliente.Controls.Add(this.TxtApPaterno);
            this.GPBCliente.Controls.Add(this.LblCedula);
            this.GPBCliente.Controls.Add(this.LblCodigoPedido);
            this.GPBCliente.Controls.Add(this.LblCategoria);
            this.GPBCliente.Controls.Add(this.LblNumSegSoc);
            this.GPBCliente.Controls.Add(this.LblSexo);
            this.GPBCliente.Controls.Add(this.LblApMaterno);
            this.GPBCliente.Controls.Add(this.LblApPaterno);
            this.GPBCliente.Location = new System.Drawing.Point(21, 24);
            this.GPBCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPBCliente.Name = "GPBCliente";
            this.GPBCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPBCliente.Size = new System.Drawing.Size(944, 172);
            this.GPBCliente.TabIndex = 0;
            this.GPBCliente.TabStop = false;
            this.GPBCliente.Text = "Cliente";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(6, 27);
            this.LblApPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(112, 17);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido Paterno";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(163, 27);
            this.LblApMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(114, 17);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido Materno";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(395, 27);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(39, 17);
            this.LblSexo.TabIndex = 2;
            this.LblSexo.Text = "Sexo";
            this.LblSexo.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblNumSegSoc
            // 
            this.LblNumSegSoc.AutoSize = true;
            this.LblNumSegSoc.Location = new System.Drawing.Point(558, 27);
            this.LblNumSegSoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNumSegSoc.Name = "LblNumSegSoc";
            this.LblNumSegSoc.Size = new System.Drawing.Size(169, 17);
            this.LblNumSegSoc.TabIndex = 3;
            this.LblNumSegSoc.Text = "Numero del seguro social";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(6, 99);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(69, 17);
            this.LblCategoria.TabIndex = 4;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblCodigoPedido
            // 
            this.LblCodigoPedido.AutoSize = true;
            this.LblCodigoPedido.Location = new System.Drawing.Point(220, 99);
            this.LblCodigoPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodigoPedido.Name = "LblCodigoPedido";
            this.LblCodigoPedido.Size = new System.Drawing.Size(119, 17);
            this.LblCodigoPedido.TabIndex = 5;
            this.LblCodigoPedido.Text = "Codigo de pedido";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(451, 99);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(52, 17);
            this.LblCedula.TabIndex = 6;
            this.LblCedula.Text = "Cedula";
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(6, 55);
            this.TxtApPaterno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(105, 23);
            this.TxtApPaterno.TabIndex = 7;
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(166, 55);
            this.TxtApMaterno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(104, 23);
            this.TxtApMaterno.TabIndex = 8;
            // 
            // TxtNumSegSoc
            // 
            this.TxtNumSegSoc.Location = new System.Drawing.Point(561, 56);
            this.TxtNumSegSoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNumSegSoc.Name = "TxtNumSegSoc";
            this.TxtNumSegSoc.Size = new System.Drawing.Size(153, 23);
            this.TxtNumSegSoc.TabIndex = 9;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(435, 123);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(109, 23);
            this.TxtCedula.TabIndex = 10;
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.Location = new System.Drawing.Point(223, 123);
            this.TxtCodigoPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.Size = new System.Drawing.Size(116, 23);
            this.TxtCodigoPedido.TabIndex = 11;
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(364, 56);
            this.CmbSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(121, 24);
            this.CmbSexo.TabIndex = 12;
            this.CmbSexo.Text = "FEMENINO";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CmbCategoria.Location = new System.Drawing.Point(9, 122);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(102, 24);
            this.CmbCategoria.TabIndex = 13;
            this.CmbCategoria.Text = "NUEVO";
            this.CmbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApPaterno,
            this.ApMaterno,
            this.Sexo,
            this.NUMSEGSOC,
            this.CATEGORIA,
            this.CODIGOPEDIDO,
            this.CEDULA});
            this.DGVClientes.Location = new System.Drawing.Point(21, 207);
            this.DGVClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.Size = new System.Drawing.Size(944, 149);
            this.DGVClientes.TabIndex = 1;
            // 
            // ApPaterno
            // 
            this.ApPaterno.HeaderText = "APELLIDO PATERNO";
            this.ApPaterno.Name = "ApPaterno";
            this.ApPaterno.Width = 150;
            // 
            // ApMaterno
            // 
            this.ApMaterno.HeaderText = "APELLIDO MATERNO";
            this.ApMaterno.Name = "ApMaterno";
            this.ApMaterno.Width = 150;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = "NUMERO DEL SEGURO SOCIAL";
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            this.NUMSEGSOC.Width = 200;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CODIGO DEL PEDIDO";
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(649, 113);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(129, 42);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FRMCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 479);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.GPBCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMCLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GPBCliente.ResumeLayout(false);
            this.GPBCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCliente;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblCodigoPedido;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNumSegSoc;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNumSegSoc;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.Button BtnGuardar;
    }
}