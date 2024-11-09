namespace Aplicacion_Loteria_MySSD
{
    partial class frmCartas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartas));
            btnSalir = new Button();
            btnMenu = new Button();
            pbxBaraja = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxBaraja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(1166, 674);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(192, 63);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(1166, 35);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(192, 63);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pbxBaraja
            // 
            pbxBaraja.Image = Properties.Resources.back_2;
            pbxBaraja.Location = new Point(322, 151);
            pbxBaraja.Name = "pbxBaraja";
            pbxBaraja.Size = new Size(310, 439);
            pbxBaraja.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBaraja.TabIndex = 6;
            pbxBaraja.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(739, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmCartas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 231, 109);
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox1);
            Controls.Add(pbxBaraja);
            Controls.Add(btnMenu);
            Controls.Add(btnSalir);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCartas";
            Text = "Loteria Mexicana";
            WindowState = FormWindowState.Maximized;
            Load += frmCartas_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBaraja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnMenu;
        private PictureBox pbxBaraja;
        private PictureBox pictureBox1;
    }
}