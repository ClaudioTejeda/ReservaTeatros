namespace ExamenIIPrograRad
{
    partial class PReservas
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
            this.components = new System.ComponentModel.Container();
            this.idpaciente = new System.Windows.Forms.TextBox();
            this.idmedico = new System.Windows.Forms.TextBox();
            this.txtTeatro = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarTeatro = new System.Windows.Forms.Button();
            this.btnbuscarCliente = new System.Windows.Forms.Button();
            this.dgReservas = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dateTimeFechaingreso = new System.Windows.Forms.DateTimePicker();
            this.txtCitaId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idpaciente
            // 
            this.idpaciente.Enabled = false;
            this.idpaciente.Location = new System.Drawing.Point(590, 12);
            this.idpaciente.Name = "idpaciente";
            this.idpaciente.ReadOnly = true;
            this.idpaciente.Size = new System.Drawing.Size(57, 20);
            this.idpaciente.TabIndex = 73;
            this.idpaciente.Visible = false;
            // 
            // idmedico
            // 
            this.idmedico.Enabled = false;
            this.idmedico.Location = new System.Drawing.Point(527, 12);
            this.idmedico.Name = "idmedico";
            this.idmedico.ReadOnly = true;
            this.idmedico.Size = new System.Drawing.Size(57, 20);
            this.idmedico.TabIndex = 72;
            this.idmedico.Visible = false;
            // 
            // txtTeatro
            // 
            this.txtTeatro.Enabled = false;
            this.txtTeatro.Location = new System.Drawing.Point(448, 85);
            this.txtTeatro.Name = "txtTeatro";
            this.txtTeatro.ReadOnly = true;
            this.txtTeatro.Size = new System.Drawing.Size(193, 20);
            this.txtTeatro.TabIndex = 71;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(448, 56);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(193, 20);
            this.txtCliente.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Teatro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Cliente";
            // 
            // btnBuscarTeatro
            // 
            this.btnBuscarTeatro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTeatro.Location = new System.Drawing.Point(212, 116);
            this.btnBuscarTeatro.Name = "btnBuscarTeatro";
            this.btnBuscarTeatro.Size = new System.Drawing.Size(110, 22);
            this.btnBuscarTeatro.TabIndex = 67;
            this.btnBuscarTeatro.Text = "Buscar";
            this.btnBuscarTeatro.UseVisualStyleBackColor = true;
            this.btnBuscarTeatro.Click += new System.EventHandler(this.btnBuscarPaciente_Click_1);
            // 
            // btnbuscarCliente
            // 
            this.btnbuscarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarCliente.Location = new System.Drawing.Point(212, 88);
            this.btnbuscarCliente.Name = "btnbuscarCliente";
            this.btnbuscarCliente.Size = new System.Drawing.Size(110, 22);
            this.btnbuscarCliente.TabIndex = 66;
            this.btnbuscarCliente.Text = "Buscar";
            this.btnbuscarCliente.UseVisualStyleBackColor = true;
            this.btnbuscarCliente.Click += new System.EventHandler(this.btnbuscarMedico_Click_1);
            // 
            // dgReservas
            // 
            this.dgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservas.Location = new System.Drawing.Point(48, 204);
            this.dgReservas.Name = "dgReservas";
            this.dgReservas.Size = new System.Drawing.Size(593, 150);
            this.dgReservas.TabIndex = 65;
            this.dgReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacientes_CellDoubleClick_1);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(359, 164);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 64;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(247, 164);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 63;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // dateTimeFechaingreso
            // 
            this.dateTimeFechaingreso.Location = new System.Drawing.Point(473, 120);
            this.dateTimeFechaingreso.Name = "dateTimeFechaingreso";
            this.dateTimeFechaingreso.Size = new System.Drawing.Size(193, 20);
            this.dateTimeFechaingreso.TabIndex = 60;
            // 
            // txtCitaId
            // 
            this.txtCitaId.Enabled = false;
            this.txtCitaId.Location = new System.Drawing.Point(212, 56);
            this.txtCitaId.Name = "txtCitaId";
            this.txtCitaId.ReadOnly = true;
            this.txtCitaId.Size = new System.Drawing.Size(110, 20);
            this.txtCitaId.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Fecha Reserva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Busque un Teatro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Busque un Cliente";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(46, 59);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(85, 18);
            this.lab2.TabIndex = 54;
            this.lab2.Text = "Reserva ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Gestion de Reservas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idpaciente);
            this.Controls.Add(this.idmedico);
            this.Controls.Add(this.txtTeatro);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarTeatro);
            this.Controls.Add(this.btnbuscarCliente);
            this.Controls.Add(this.dgReservas);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dateTimeFechaingreso);
            this.Controls.Add(this.txtCitaId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.label1);
            this.Name = "PReservas";
            this.Text = "PReservas";
            this.Load += new System.EventHandler(this.PReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idpaciente;
        private System.Windows.Forms.TextBox idmedico;
        private System.Windows.Forms.TextBox txtTeatro;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTeatro;
        private System.Windows.Forms.Button btnbuscarCliente;
        private System.Windows.Forms.DataGridView dgReservas;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DateTimePicker dateTimeFechaingreso;
        private System.Windows.Forms.TextBox txtCitaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}