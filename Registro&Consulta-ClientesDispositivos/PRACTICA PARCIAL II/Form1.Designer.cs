namespace PRACTICA_PARCIAL_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDispositivo = new System.Windows.Forms.ComboBox();
            this.cmbReparacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpcCredito = new System.Windows.Forms.RadioButton();
            this.OpcContado = new System.Windows.Forms.RadioButton();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbConsultaTipoDispositivo = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCONSULTA = new System.Windows.Forms.DataGridView();
            this.columnaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFormaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCONSULTA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(172, 24);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(223, 23);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Dispositivo";
            // 
            // cmbTipoDispositivo
            // 
            this.cmbTipoDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDispositivo.FormattingEnabled = true;
            this.cmbTipoDispositivo.Location = new System.Drawing.Point(172, 64);
            this.cmbTipoDispositivo.Name = "cmbTipoDispositivo";
            this.cmbTipoDispositivo.Size = new System.Drawing.Size(223, 24);
            this.cmbTipoDispositivo.TabIndex = 3;
            // 
            // cmbReparacion
            // 
            this.cmbReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReparacion.FormattingEnabled = true;
            this.cmbReparacion.Location = new System.Drawing.Point(172, 104);
            this.cmbReparacion.Name = "cmbReparacion";
            this.cmbReparacion.Size = new System.Drawing.Size(223, 24);
            this.cmbReparacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reparación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpcCredito);
            this.groupBox1.Controls.Add(this.OpcContado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pago";
            // 
            // OpcCredito
            // 
            this.OpcCredito.AutoSize = true;
            this.OpcCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcCredito.Location = new System.Drawing.Point(186, 32);
            this.OpcCredito.Name = "OpcCredito";
            this.OpcCredito.Size = new System.Drawing.Size(71, 21);
            this.OpcCredito.TabIndex = 8;
            this.OpcCredito.TabStop = true;
            this.OpcCredito.Text = "Credito";
            this.OpcCredito.UseVisualStyleBackColor = true;
            // 
            // OpcContado
            // 
            this.OpcContado.AutoSize = true;
            this.OpcContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcContado.Location = new System.Drawing.Point(60, 32);
            this.OpcContado.Name = "OpcContado";
            this.OpcContado.Size = new System.Drawing.Size(79, 21);
            this.OpcContado.TabIndex = 7;
            this.OpcContado.TabStop = true;
            this.OpcContado.Text = "&Contado";
            this.OpcContado.UseVisualStyleBackColor = true;
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(172, 234);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.ReadOnly = true;
            this.txtImporteTotal.Size = new System.Drawing.Size(136, 20);
            this.txtImporteTotal.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Importe Total";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(429, 24);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 40);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(429, 85);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 40);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(429, 142);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 40);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(429, 201);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 40);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCONSULTA);
            this.groupBox2.Controls.Add(this.cmbConsultaTipoDispositivo);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 374);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // cmbConsultaTipoDispositivo
            // 
            this.cmbConsultaTipoDispositivo.FormattingEnabled = true;
            this.cmbConsultaTipoDispositivo.Location = new System.Drawing.Point(166, 33);
            this.cmbConsultaTipoDispositivo.Name = "cmbConsultaTipoDispositivo";
            this.cmbConsultaTipoDispositivo.Size = new System.Drawing.Size(223, 24);
            this.cmbConsultaTipoDispositivo.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(417, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(98, 40);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de Dispositivo";
            // 
            // dgvCONSULTA
            // 
            this.dgvCONSULTA.AllowUserToAddRows = false;
            this.dgvCONSULTA.AllowUserToDeleteRows = false;
            this.dgvCONSULTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCONSULTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCliente,
            this.columnaDispositivo,
            this.columnaReparacion,
            this.columnaFormaDePago,
            this.columnaImporte});
            this.dgvCONSULTA.Location = new System.Drawing.Point(9, 74);
            this.dgvCONSULTA.Name = "dgvCONSULTA";
            this.dgvCONSULTA.ReadOnly = true;
            this.dgvCONSULTA.RowHeadersVisible = false;
            this.dgvCONSULTA.Size = new System.Drawing.Size(506, 283);
            this.dgvCONSULTA.TabIndex = 17;
            // 
            // columnaCliente
            // 
            this.columnaCliente.HeaderText = "Cliente";
            this.columnaCliente.Name = "columnaCliente";
            this.columnaCliente.ReadOnly = true;
            // 
            // columnaDispositivo
            // 
            this.columnaDispositivo.HeaderText = "Dispositivo";
            this.columnaDispositivo.Name = "columnaDispositivo";
            this.columnaDispositivo.ReadOnly = true;
            // 
            // columnaReparacion
            // 
            this.columnaReparacion.HeaderText = "Reparación";
            this.columnaReparacion.Name = "columnaReparacion";
            this.columnaReparacion.ReadOnly = true;
            // 
            // columnaFormaDePago
            // 
            this.columnaFormaDePago.HeaderText = "Forma de Pago";
            this.columnaFormaDePago.Name = "columnaFormaDePago";
            this.columnaFormaDePago.ReadOnly = true;
            // 
            // columnaImporte
            // 
            this.columnaImporte.HeaderText = "Importe";
            this.columnaImporte.Name = "columnaImporte";
            this.columnaImporte.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtImporteTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbReparacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoDispositivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Smart Rep";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCONSULTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDispositivo;
        private System.Windows.Forms.ComboBox cmbReparacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OpcCredito;
        private System.Windows.Forms.RadioButton OpcContado;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbConsultaTipoDispositivo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFormaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaImporte;
    }
}

