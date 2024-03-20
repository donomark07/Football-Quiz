namespace Football_Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_magliette = new System.Windows.Forms.PictureBox();
            this.pb_squadre = new System.Windows.Forms.PictureBox();
            this.pb_sfondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_magliette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_squadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sfondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_exit
            // 
            this.pb_exit.Image = global::Football_Quiz.Properties.Resources.sfondo_exit;
            this.pb_exit.Location = new System.Drawing.Point(823, 12);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(185, 89);
            this.pb_exit.TabIndex = 3;
            this.pb_exit.TabStop = false;
            // 
            // pb_magliette
            // 
            this.pb_magliette.Image = global::Football_Quiz.Properties.Resources.play_2;
            this.pb_magliette.Location = new System.Drawing.Point(757, 569);
            this.pb_magliette.Name = "pb_magliette";
            this.pb_magliette.Size = new System.Drawing.Size(180, 98);
            this.pb_magliette.TabIndex = 2;
            this.pb_magliette.TabStop = false;
            // 
            // pb_squadre
            // 
            this.pb_squadre.Image = global::Football_Quiz.Properties.Resources.play_1;
            this.pb_squadre.Location = new System.Drawing.Point(157, 559);
            this.pb_squadre.Name = "pb_squadre";
            this.pb_squadre.Size = new System.Drawing.Size(194, 98);
            this.pb_squadre.TabIndex = 1;
            this.pb_squadre.TabStop = false;
            // 
            // pb_sfondo
            // 
            this.pb_sfondo.Image = global::Football_Quiz.Properties.Resources.sfondo_completo;
            this.pb_sfondo.Location = new System.Drawing.Point(-2, 1);
            this.pb_sfondo.Name = "pb_sfondo";
            this.pb_sfondo.Size = new System.Drawing.Size(1022, 703);
            this.pb_sfondo.TabIndex = 0;
            this.pb_sfondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 702);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.pb_magliette);
            this.Controls.Add(this.pb_squadre);
            this.Controls.Add(this.pb_sfondo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_magliette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_squadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sfondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_sfondo;
        private System.Windows.Forms.PictureBox pb_squadre;
        private System.Windows.Forms.PictureBox pb_magliette;
        private System.Windows.Forms.PictureBox pb_exit;
    }
}

