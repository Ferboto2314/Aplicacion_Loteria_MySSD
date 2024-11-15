namespace Aplicacion_Loteria_MySSD
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            label1 = new Label();
            btnComemzar = new Button();
            btnAbout = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(188, 108, 37);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 74);
            label1.TabIndex = 3;
            label1.Text = "LOTERIA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnComemzar
            // 
            btnComemzar.AutoSize = true;
            btnComemzar.BackColor = Color.FromArgb(96, 108, 56);
            btnComemzar.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnComemzar.ForeColor = Color.White;
            btnComemzar.Location = new Point(0, 0);
            btnComemzar.Name = "btnComemzar";
            btnComemzar.Padding = new Padding(20);
            btnComemzar.Size = new Size(317, 96);
            btnComemzar.TabIndex = 2;
            btnComemzar.Text = "COMENZAR";
            btnComemzar.UseVisualStyleBackColor = false;
            btnComemzar.Click += button1_Click;
            // 
            // btnAbout
            // 
            btnAbout.AutoSize = true;
            btnAbout.BackColor = Color.FromArgb(96, 108, 56);
            btnAbout.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(0, 0);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(385, 56);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "Sobre el Proyecto";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.BackColor = Color.FromArgb(96, 108, 56);
            btnSalir.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 56);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnSalir);
            Controls.Add(btnAbout);
            Controls.Add(btnComemzar);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMenu";
            Text = "Loteria Mexicana";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            Resize += FrmMenu_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnComemzar;
        private Button btnAbout;
        private Button btnSalir;

        // Método para centrar el Label
        private void CentrarLabel()
        {
            int posX = (this.ClientSize.Width - label1.Width) / 2;
            label1.Location = new Point(posX, 0);
        }

        // Método para alinear los botones al pie de la ventana
        private void AlinearBotones()
        {
            int posX = (this.ClientSize.Width - (btnComemzar.Width + btnAbout.Width + btnSalir.Width + 40)) / 2; // 40 para el espaciado
            btnComemzar.Location = new Point(posX, this.ClientSize.Height - btnComemzar.Height - 100); // Ubica el primer botón
            btnAbout.Location = new Point(btnComemzar.Right + 10, this.ClientSize.Height - btnAbout.Height - 100); // Segundo botón
            btnSalir.Location = new Point(btnAbout.Right + 10, this.ClientSize.Height - btnSalir.Height - 100); // Tercer botón
        }

        // Evento Resize para mantener los botones alineados al cambiar el tamaño de la ventana
        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            CentrarLabel();
            AlinearBotones();
        }
    }
}
