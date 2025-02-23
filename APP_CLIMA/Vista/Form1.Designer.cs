
namespace APP_CLIMA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCiudades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(265, 383);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(252, 30);
            this.bntBuscar.TabIndex = 0;
            this.bntBuscar.Text = "Buscar Informacion de la Ciudad";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.temp,
            this.temp_min,
            this.temp_max,
            this.humidity});
            this.dgvPrincipal.Location = new System.Drawing.Point(124, 95);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.Size = new System.Drawing.Size(543, 262);
            this.dgvPrincipal.TabIndex = 1;
            this.dgvPrincipal.Visible = false;
            // 
            // temp
            // 
            dataGridViewCellStyle2.NullValue = "0";
            this.temp.DefaultCellStyle = dataGridViewCellStyle2;
            this.temp.HeaderText = "Temperatura";
            this.temp.Name = "temp";
            this.temp.ReadOnly = true;
            // 
            // temp_min
            // 
            this.temp_min.FillWeight = 150F;
            this.temp_min.HeaderText = "Temperatura Minima";
            this.temp_min.Name = "temp_min";
            this.temp_min.ReadOnly = true;
            this.temp_min.Width = 150;
            // 
            // temp_max
            // 
            this.temp_max.HeaderText = "Temperatura Maxima";
            this.temp_max.Name = "temp_max";
            this.temp_max.ReadOnly = true;
            this.temp_max.Width = 150;
            // 
            // humidity
            // 
            this.humidity.HeaderText = "Humedad";
            this.humidity.Name = "humidity";
            this.humidity.ReadOnly = true;
            // 
            // cboCiudades
            // 
            this.cboCiudades.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboCiudades.FormattingEnabled = true;
            this.cboCiudades.Location = new System.Drawing.Point(277, 62);
            this.cboCiudades.Name = "cboCiudades";
            this.cboCiudades.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCiudades.Size = new System.Drawing.Size(383, 21);
            this.cboCiudades.TabIndex = 2;
            this.cboCiudades.Text = "SELECCIONA UNA CIUDAD";
            this.cboCiudades.SelectedIndexChanged += new System.EventHandler(this.bntBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONA UNA CIUDAD: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(634, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "OBTIENE INFORMACION DE UNA CIUDAD ESPECIFICA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCiudades);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp_max;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.ComboBox cboCiudades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

