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
            label1.AutoSize = true; // Permite que el Label se ajuste al tamaño del texto
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Name = "label1";
            label1.Text = "LOTERIA";
            label1.ForeColor = Color.FromArgb(188, 108, 37);
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnComemzar
            // 
            btnComemzar.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnComemzar.Name = "btnComemzar";
            btnComemzar.Text = "COMENZAR";
            btnComemzar.UseVisualStyleBackColor = true;
            btnComemzar.Click += button1_Click;
            btnComemzar.ForeColor = Color.White;
            btnComemzar.BackColor = Color.FromArgb(96, 108, 56);
            btnComemzar.AutoSize = true;
            btnComemzar.Padding = new System.Windows.Forms.Padding(20);
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.Name = "btnAbout";
            btnAbout.Text = "Sobre el Proyecto";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            btnComemzar.ForeColor = Color.White;
            btnComemzar.BackColor = Color.FromArgb(96, 108, 56);
            btnAbout.AutoSize = true;
            btnComemzar.Padding = new System.Windows.Forms.Padding(20);
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Name = "btnSalir";
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            btnComemzar.ForeColor = Color.White;
            btnComemzar.BackColor = Color.FromArgb(96, 108, 56);
            btnSalir.AutoSize = true;
            btnComemzar.Padding = new System.Windows.Forms.Padding(20);
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
            ResumeLayout(false);
            PerformLayout();
            CentrarLabel();
            AlinearBotones();  // Alinear los botones al pie de la ventana
            this.Resize += FrmMenu_Resize;
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
