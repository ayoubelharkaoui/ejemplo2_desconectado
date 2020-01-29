namespace ejemplo_bases
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.txt_consulta = new System.Windows.Forms.TextBox();
            this.rdo_no_select = new System.Windows.Forms.RadioButton();
            this.rdo_select = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_tablas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_tablas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ejecutar);
            this.groupBox1.Controls.Add(this.txt_consulta);
            this.groupBox1.Controls.Add(this.rdo_no_select);
            this.groupBox1.Controls.Add(this.rdo_select);
            this.groupBox1.Location = new System.Drawing.Point(25, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.Location = new System.Drawing.Point(311, 98);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(75, 23);
            this.btn_ejecutar.TabIndex = 3;
            this.btn_ejecutar.Text = "Ejecutar";
            this.btn_ejecutar.UseVisualStyleBackColor = true;
            this.btn_ejecutar.Click += new System.EventHandler(this.Btn_ejecutar_Click);
            // 
            // txt_consulta
            // 
            this.txt_consulta.Location = new System.Drawing.Point(21, 100);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(254, 20);
            this.txt_consulta.TabIndex = 2;
            // 
            // rdo_no_select
            // 
            this.rdo_no_select.AutoSize = true;
            this.rdo_no_select.Location = new System.Drawing.Point(21, 61);
            this.rdo_no_select.Name = "rdo_no_select";
            this.rdo_no_select.Size = new System.Drawing.Size(163, 17);
            this.rdo_no_select.TabIndex = 1;
            this.rdo_no_select.TabStop = true;
            this.rdo_no_select.Text = "UPDATE, INSERT, DELETE";
            this.rdo_no_select.UseVisualStyleBackColor = true;
            // 
            // rdo_select
            // 
            this.rdo_select.AutoSize = true;
            this.rdo_select.Location = new System.Drawing.Point(21, 37);
            this.rdo_select.Name = "rdo_select";
            this.rdo_select.Size = new System.Drawing.Size(66, 17);
            this.rdo_select.TabIndex = 0;
            this.rdo_select.TabStop = true;
            this.rdo_select.Text = "SELECT";
            this.rdo_select.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 379);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmb_tablas
            // 
            this.cmb_tablas.FormattingEnabled = true;
            this.cmb_tablas.Location = new System.Drawing.Point(369, 13);
            this.cmb_tablas.Name = "cmb_tablas";
            this.cmb_tablas.Size = new System.Drawing.Size(157, 21);
            this.cmb_tablas.TabIndex = 4;
            this.cmb_tablas.SelectedIndexChanged += new System.EventHandler(this.Cmb_tablas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Establecer una Tabla:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.TextBox txt_consulta;
        private System.Windows.Forms.RadioButton rdo_no_select;
        private System.Windows.Forms.RadioButton rdo_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_tablas;
        private System.Windows.Forms.Label label1;
    }
}

