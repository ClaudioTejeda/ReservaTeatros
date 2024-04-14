namespace ExamenIIPrograRad
{
    partial class Buscarcliente
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
            this.dgBuscarMedico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBfiltro = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBuscarMedico
            // 
            this.dgBuscarMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarMedico.Location = new System.Drawing.Point(74, 80);
            this.dgBuscarMedico.Name = "dgBuscarMedico";
            this.dgBuscarMedico.Size = new System.Drawing.Size(533, 150);
            this.dgBuscarMedico.TabIndex = 5;
            this.dgBuscarMedico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBuscarMedico_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione un Cliente";
            // 
            // checkBfiltro
            // 
            this.checkBfiltro.AutoSize = true;
            this.checkBfiltro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBfiltro.Location = new System.Drawing.Point(74, 54);
            this.checkBfiltro.Name = "checkBfiltro";
            this.checkBfiltro.Size = new System.Drawing.Size(98, 20);
            this.checkBfiltro.TabIndex = 3;
            this.checkBfiltro.Text = "Filtrar Activos";
            this.checkBfiltro.UseVisualStyleBackColor = true;
            this.checkBfiltro.CheckedChanged += new System.EventHandler(this.checkBfiltro_CheckedChanged);
            // 
            // Buscarcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgBuscarMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBfiltro);
            this.Name = "Buscarcliente";
            this.Text = "Buscarcliente";
            this.Load += new System.EventHandler(this.Buscarcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBuscarMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBfiltro;
    }
}