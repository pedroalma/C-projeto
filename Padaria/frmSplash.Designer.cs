namespace Padaria
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pcbLogoP = new System.Windows.Forms.PictureBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.prbLogo = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoP)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogoP
            // 
            this.pcbLogoP.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogoP.Image")));
            this.pcbLogoP.Location = new System.Drawing.Point(275, 173);
            this.pcbLogoP.Name = "pcbLogoP";
            this.pcbLogoP.Size = new System.Drawing.Size(212, 140);
            this.pcbLogoP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoP.TabIndex = 0;
            this.pcbLogoP.TabStop = false;
            this.pcbLogoP.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(365, 332);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(18, 20);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "0";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(379, 332);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(23, 20);
            this.lblPorcentagem.TabIndex = 2;
            this.lblPorcentagem.Text = "%";
            this.lblPorcentagem.Click += new System.EventHandler(this.label2_Click);
            // 
            // prbLogo
            // 
            this.prbLogo.Location = new System.Drawing.Point(275, 364);
            this.prbLogo.Name = "prbLogo";
            this.prbLogo.Size = new System.Drawing.Size(212, 23);
            this.prbLogo.TabIndex = 3;
            this.prbLogo.Value = 50;
            this.prbLogo.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.prbLogo);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.pcbLogoP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogoP;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.ProgressBar prbLogo;
    }
}