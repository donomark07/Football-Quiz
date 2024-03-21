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
            this.panel_squadre = new System.Windows.Forms.Panel();
            this.panel_magliette = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_magliette = new System.Windows.Forms.PictureBox();
            this.pb_squadre = new System.Windows.Forms.PictureBox();
            this.pb_sfondo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_squadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_magliette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_squadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sfondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_squadre
            // 
            this.panel_squadre.Controls.Add(this.pictureBox2);
            this.panel_squadre.Controls.Add(this.comboBox1);
            this.panel_squadre.Controls.Add(this.button1);
            this.panel_squadre.Controls.Add(this.pictureBox1);
            this.panel_squadre.Location = new System.Drawing.Point(12, 40);
            this.panel_squadre.Name = "panel_squadre";
            this.panel_squadre.Size = new System.Drawing.Size(816, 617);
            this.panel_squadre.TabIndex = 4;
            this.panel_squadre.Visible = false;
            // 
            // panel_magliette
            // 
            this.panel_magliette.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_magliette.Location = new System.Drawing.Point(850, 119);
            this.panel_magliette.Name = "panel_magliette";
            this.panel_magliette.Size = new System.Drawing.Size(158, 165);
            this.panel_magliette.TabIndex = 5;
            this.panel_magliette.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Football_Quiz.Properties.Resources.Screenshot__14_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 617);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_exit
            // 
            this.pb_exit.Image = global::Football_Quiz.Properties.Resources.sfondo_exit;
            this.pb_exit.Location = new System.Drawing.Point(823, 12);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(185, 89);
            this.pb_exit.TabIndex = 3;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_magliette
            // 
            this.pb_magliette.Image = global::Football_Quiz.Properties.Resources.play_2;
            this.pb_magliette.Location = new System.Drawing.Point(757, 569);
            this.pb_magliette.Name = "pb_magliette";
            this.pb_magliette.Size = new System.Drawing.Size(180, 98);
            this.pb_magliette.TabIndex = 2;
            this.pb_magliette.TabStop = false;
            this.pb_magliette.Click += new System.EventHandler(this.pb_magliette_Click);
            // 
            // pb_squadre
            // 
            this.pb_squadre.Image = global::Football_Quiz.Properties.Resources.play_1;
            this.pb_squadre.Location = new System.Drawing.Point(157, 559);
            this.pb_squadre.Name = "pb_squadre";
            this.pb_squadre.Size = new System.Drawing.Size(194, 98);
            this.pb_squadre.TabIndex = 1;
            this.pb_squadre.TabStop = false;
            this.pb_squadre.Click += new System.EventHandler(this.pb_squadre_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(44, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 702);
            this.Controls.Add(this.panel_magliette);
            this.Controls.Add(this.panel_squadre);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.pb_magliette);
            this.Controls.Add(this.pb_squadre);
            this.Controls.Add(this.pb_sfondo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_squadre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_magliette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_squadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sfondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_sfondo;
        private System.Windows.Forms.PictureBox pb_squadre;
        private System.Windows.Forms.PictureBox pb_magliette;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Panel panel_squadre;
        private System.Windows.Forms.Panel panel_magliette;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

