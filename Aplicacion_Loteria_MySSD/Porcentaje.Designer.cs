namespace Aplicacion_Loteria_MySSD
{
    partial class Porcentaje
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Num_Apariciones = new DataGridViewTextBoxColumn();
            Tasa_Aparicion = new DataGridViewTextBoxColumn();
            Num_Rectangular = new DataGridViewTextBoxColumn();
            btnPorcentaje = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Num_Apariciones, Tasa_Aparicion, Num_Rectangular });
            dataGridView1.Location = new Point(194, 72);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 396);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Num_Apariciones
            // 
            Num_Apariciones.HeaderText = "# Apariciones";
            Num_Apariciones.MinimumWidth = 6;
            Num_Apariciones.Name = "Num_Apariciones";
            Num_Apariciones.Width = 125;
            // 
            // Tasa_Aparicion
            // 
            Tasa_Aparicion.HeaderText = "% Aparicion";
            Tasa_Aparicion.MinimumWidth = 6;
            Tasa_Aparicion.Name = "Tasa_Aparicion";
            Tasa_Aparicion.Width = 125;
            // 
            // Num_Rectangular
            // 
            Num_Rectangular.HeaderText = "# Rectangular";
            Num_Rectangular.MinimumWidth = 6;
            Num_Rectangular.Name = "Num_Rectangular";
            Num_Rectangular.Width = 125;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.BackColor = Color.FromArgb(96, 108, 56);
            btnPorcentaje.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPorcentaje.ForeColor = Color.White;
            btnPorcentaje.Location = new Point(291, 494);
            btnPorcentaje.Margin = new Padding(3, 4, 3, 4);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(337, 84);
            btnPorcentaje.TabIndex = 10;
            btnPorcentaje.Text = "Cerrar ventana";
            btnPorcentaje.UseVisualStyleBackColor = false;
            btnPorcentaje.Click += btnPorcentaje_Click;
            // 
            // Porcentaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 231, 109);
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(btnPorcentaje);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Porcentaje";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Num_Apariciones;
        private DataGridViewTextBoxColumn Tasa_Aparicion;
        private DataGridViewTextBoxColumn Num_Rectangular;
        private Button btnPorcentaje;
    }
}