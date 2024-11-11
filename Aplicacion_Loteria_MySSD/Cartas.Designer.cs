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
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxBaraja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCartaActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCartaAnterior).BeginInit();
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
            pbxBaraja.Location = new Point(322, 77);
            pbxBaraja.Name = "pbxBaraja";
            pbxBaraja.Size = new Size(310, 439);
            pbxBaraja.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBaraja.TabIndex = 6;
            pbxBaraja.TabStop = false;
            // 
            // pbxCartaActual
            // 
            pbxCartaActual.Image = Properties.Resources._1;
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
            pbxCartaAnterior.Image = Properties.Resources._1;
            pbxCartaAnterior.Location = new Point(642, 545);
            pbxCartaAnterior.Name = "pbxCartaAnterior";
            pbxCartaAnterior.Size = new Size(108, 153);
            pbxCartaAnterior.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCartaAnterior.TabIndex = 7;
            pbxCartaAnterior.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(65, 120);
            button1.Name = "button1";
            button1.Size = new Size(192, 63);
            button1.TabIndex = 8;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(65, 217);
            button2.Name = "button2";
            button2.Size = new Size(192, 63);
            button2.TabIndex = 8;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmCartas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 231, 109);
            ClientSize = new Size(1370, 749);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
    }
}