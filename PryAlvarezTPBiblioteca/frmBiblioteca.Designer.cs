namespace PryAlvarezTPBiblioteca
{
    partial class frmBiblioteca
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
            this.dgvBliblioteca = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.btnSiguientes = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDistribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBliblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBliblioteca
            // 
            this.dgvBliblioteca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBliblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBliblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreLibro,
            this.CodigoEditorial,
            this.CodigoAutor,
            this.CodigoDistribuidora});
            this.dgvBliblioteca.Location = new System.Drawing.Point(0, 2);
            this.dgvBliblioteca.Name = "dgvBliblioteca";
            this.dgvBliblioteca.Size = new System.Drawing.Size(624, 268);
            this.dgvBliblioteca.TabIndex = 0;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(12, 294);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(92, 32);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTodos.Location = new System.Drawing.Point(488, 294);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(120, 61);
            this.btnConsultarTodos.TabIndex = 3;
            this.btnConsultarTodos.Text = "Consultar Todo";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSiguientes
            // 
            this.btnSiguientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientes.Location = new System.Drawing.Point(358, 294);
            this.btnSiguientes.Name = "btnSiguientes";
            this.btnSiguientes.Size = new System.Drawing.Size(92, 32);
            this.btnSiguientes.TabIndex = 4;
            this.btnSiguientes.Text = ">>>>>";
            this.btnSiguientes.UseVisualStyleBackColor = true;
            this.btnSiguientes.Click += new System.EventHandler(this.btnSiguientes_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(192, 294);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(92, 32);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "<<<<<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 65;
            // 
            // NombreLibro
            // 
            this.NombreLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NombreLibro.HeaderText = "NombreLibro";
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.Width = 92;
            // 
            // CodigoEditorial
            // 
            this.CodigoEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodigoEditorial.HeaderText = "CodigoEditorial";
            this.CodigoEditorial.Name = "CodigoEditorial";
            this.CodigoEditorial.Width = 102;
            // 
            // CodigoAutor
            // 
            this.CodigoAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodigoAutor.HeaderText = "CodigoAutor";
            this.CodigoAutor.Name = "CodigoAutor";
            this.CodigoAutor.Width = 90;
            // 
            // CodigoDistribuidora
            // 
            this.CodigoDistribuidora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodigoDistribuidora.HeaderText = "CodigoDistribuidora";
            this.CodigoDistribuidora.Name = "CodigoDistribuidora";
            this.CodigoDistribuidora.Width = 123;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 366);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguientes);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvBliblioteca);
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca Listado";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBliblioteca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBliblioteca;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.Button btnSiguientes;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDistribuidora;
    }
}