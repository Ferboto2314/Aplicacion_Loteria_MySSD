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
            pbxCartaActual = new PictureBox();
            pbxCartaAnterior = new PictureBox();
            btnNextCard = new Button();
            btnMix = new Button();
            btnPorcentaje = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxBaraja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCartaActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCartaAnterior).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(96, 108, 56);
            btnSalir.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1166, 674);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(192, 63);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(96, 108, 56);
            btnMenu.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(1151, 35);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(192, 63);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pbxBaraja
            // 
            pbxBaraja.Image = Properties.Resources.back_2;
            pbxBaraja.Location = new Point(322, 77);
            pbxBaraja.Name = "pbxBaraja";
            pbxBaraja.Size = new Size(310, 439);
            pbxBaraja.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBaraja.TabIndex = 6;
            pbxBaraja.TabStop = false;
            // 
            // pbxCartaActual
            // 
            pbxCartaActual.Location = new Point(739, 77);
            pbxCartaActual.Name = "pbxCartaActual";
            pbxCartaActual.Size = new Size(310, 439);
            pbxCartaActual.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCartaActual.TabIndex = 6;
            pbxCartaActual.TabStop = false;
            pbxCartaActual.Click += pictureBox1_Click;
            // 
            // pbxCartaAnterior
            // 
            pbxCartaAnterior.Location = new Point(642, 545);
            pbxCartaAnterior.Name = "pbxCartaAnterior";
            pbxCartaAnterior.Size = new Size(108, 153);
            pbxCartaAnterior.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCartaAnterior.TabIndex = 7;
            pbxCartaAnterior.TabStop = false;
            // 
            // btnNextCard
            // 
            btnNextCard.BackColor = Color.FromArgb(96, 108, 56);
            btnNextCard.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextCard.ForeColor = Color.White;
            btnNextCard.Location = new Point(65, 120);
            btnNextCard.Name = "btnNextCard";
            btnNextCard.Size = new Size(192, 91);
            btnNextCard.TabIndex = 8;
            btnNextCard.Text = "Siguiente Carta";
            btnNextCard.UseVisualStyleBackColor = false;
            btnNextCard.Click += button1_Click;
            // 
            // btnMix
            // 
            btnMix.BackColor = Color.FromArgb(96, 108, 56);
            btnMix.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMix.ForeColor = Color.White;
            btnMix.Location = new Point(65, 217);
            btnMix.Name = "btnMix";
            btnMix.Size = new Size(192, 63);
            btnMix.TabIndex = 8;
            btnMix.Text = "Mezclar";
            btnMix.UseVisualStyleBackColor = false;
            btnMix.Click += btnMix_Click;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.BackColor = Color.FromArgb(96, 108, 56);
            btnPorcentaje.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPorcentaje.ForeColor = Color.White;
            btnPorcentaje.Location = new Point(1151, 217);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(192, 63);
            btnPorcentaje.TabIndex = 9;
            btnPorcentaje.Text = "% de Cartas";
            btnPorcentaje.UseVisualStyleBackColor = false;
            btnPorcentaje.Click += btnPorcentaje_Click;
            // 
            // frmCartas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 231, 109);
            ClientSize = new Size(1370, 749);
            ControlBox = false;
            Controls.Add(btnPorcentaje);
            Controls.Add(btnMix);
            Controls.Add(btnNextCard);
            Controls.Add(pbxCartaAnterior);
            Controls.Add(pbxCartaActual);
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
            ((System.ComponentModel.ISupportInitialize)pbxCartaActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCartaAnterior).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnMenu;
        private PictureBox pbxBaraja;
        private PictureBox pbxCartaActual;
        private PictureBox pbxCartaAnterior;
        private Button btnNextCard;
        private Button btnMix;
        private Button btnPorcentaje;
    }
}