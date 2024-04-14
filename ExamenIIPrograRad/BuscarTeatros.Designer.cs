namespace ExamenIIPrograRad
{
    partial class BuscarTeatros
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
            this.dgBuscarPaciente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBuscarPaciente
            // 
            this.dgBuscarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarPaciente.Location = new System.Drawing.Point(96, 84);
            this.dgBuscarPaciente.Name = "dgBuscarPaciente";
            this.dgBuscarPaciente.Size = new System.Drawing.Size(533, 150);
            this.dgBuscarPaciente.TabIndex = 8;
            this.dgBuscarPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBuscarPaciente_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione un Teatro";
            // 
            // BuscarTeatros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgBuscarPaciente);
            this.Controls.Add(this.label1);
            this.Name = "BuscarTeatros";
            this.Text = "BuscarTeatros";
            this.Load += new System.EventHandler(this.BuscarTeatros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBuscarPaciente;
        private System.Windows.Forms.Label label1;
    }
}