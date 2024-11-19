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
            btnPorcentaje = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Num_Apariciones });
            dataGridView1.Location = new Point(170, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(476, 297);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // btnPorcentaje
            // 
            btnPorcentaje.BackColor = Color.FromArgb(96, 108, 56);
            btnPorcentaje.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPorcentaje.ForeColor = Color.White;
            btnPorcentaje.Location = new Point(255, 370);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(295, 63);
            btnPorcentaje.TabIndex = 10;
            btnPorcentaje.Text = "Cerrar ventana";
            btnPorcentaje.UseVisualStyleBackColor = false;
            btnPorcentaje.Click += btnPorcentaje_Click;
            // 
            // Porcentaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 231, 109);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnPorcentaje);
            Controls.Add(dataGridView1);
            Name = "Porcentaje";
            Load += Porcentaje_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnPorcentaje;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Num_Apariciones;
    }
}