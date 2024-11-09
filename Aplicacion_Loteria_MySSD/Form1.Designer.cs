namespace Aplicacion_Loteria_MySSD
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(522, 48);
            label1.Name = "label1";
            label1.Size = new Size(341, 74);
            label1.TabIndex = 0;
            label1.Text = "LOTERIA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnComemzar
            // 
            btnComemzar.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            btnComemzar.Location = new Point(473, 573);
            btnComemzar.Name = "btnComemzar";
            btnComemzar.Size = new Size(440, 136);
            btnComemzar.TabIndex = 1;
            btnComemzar.Text = "COMENZAR";
            btnComemzar.UseVisualStyleBackColor = true;
            btnComemzar.Click += button1_Click;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.Location = new Point(1127, 638);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(192, 76);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "Sobre el Proyecto";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(1127, 569);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(192, 63);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 231, 109);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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
        }

        #endregion

        private Label label1;
        private Button btnComemzar;
        private Button btnAbout;
        private Button btnSalir;
    }
}
