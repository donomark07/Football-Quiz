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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_gioco = new System.Windows.Forms.TabPage();
            this.tbp_giocatore = new System.Windows.Forms.TabPage();
            this.grb_cancella = new System.Windows.Forms.GroupBox();
            this.btn_cancella = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_cancella = new System.Windows.Forms.TextBox();
            this.grb_inserisci = new System.Windows.Forms.GroupBox();
            this.btn_inserisci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_inserisci = new System.Windows.Forms.TextBox();
            this.panel_magliette = new System.Windows.Forms.Panel();
            this.cbo_giocatore = new System.Windows.Forms.ComboBox();
            this.cbo_livello = new System.Windows.Forms.ComboBox();
            this.grb_record = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_nuovogiocatore = new System.Windows.Forms.PictureBox();
            this.pb_gioca = new System.Windows.Forms.PictureBox();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_magliette = new System.Windows.Forms.PictureBox();
            this.pb_squadre = new System.Windows.Forms.PictureBox();
            this.pb_sfondo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_squadre.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbp_giocatore.SuspendLayout();
            this.grb_cancella.SuspendLayout();
            this.grb_inserisci.SuspendLayout();
            this.grb_record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nuovogiocatore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gioca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_magliette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_squadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sfondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_squadre
            // 
            this.panel_squadre.Controls.Add(this.tabControl1);
            this.panel_squadre.Controls.Add(this.panel_magliette);
            this.panel_squadre.Controls.Add(this.pb_back);
            this.panel_squadre.Controls.Add(this.pb_nuovogiocatore);
            this.panel_squadre.Controls.Add(this.pb_gioca);
            this.panel_squadre.Controls.Add(this.pb_info);
            this.panel_squadre.Controls.Add(this.cbo_giocatore);
            this.panel_squadre.Controls.Add(this.cbo_livello);
            this.panel_squadre.Controls.Add(this.pictureBox1);
            this.panel_squadre.Location = new System.Drawing.Point(-2, 1);
            this.panel_squadre.Name = "panel_squadre";
            this.panel_squadre.Size = new System.Drawing.Size(1022, 739);
            this.panel_squadre.TabIndex = 4;
            this.panel_squadre.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_gioco);
            this.tabControl1.Controls.Add(this.tbp_giocatore);
            this.tabControl1.Location = new System.Drawing.Point(329, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 715);
            this.tabControl1.TabIndex = 7;
            // 
            // tbp_gioco
            // 
            this.tbp_gioco.Location = new System.Drawing.Point(4, 22);
            this.tbp_gioco.Name = "tbp_gioco";
            this.tbp_gioco.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_gioco.Size = new System.Drawing.Size(672, 689);
            this.tbp_gioco.TabIndex = 0;
            this.tbp_gioco.Text = "gioco";
            this.tbp_gioco.UseVisualStyleBackColor = true;
            // 
            // tbp_giocatore
            // 
            this.tbp_giocatore.Controls.Add(this.grb_record);
            this.tbp_giocatore.Controls.Add(this.grb_cancella);
            this.tbp_giocatore.Controls.Add(this.grb_inserisci);
            this.tbp_giocatore.Location = new System.Drawing.Point(4, 22);
            this.tbp_giocatore.Name = "tbp_giocatore";
            this.tbp_giocatore.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_giocatore.Size = new System.Drawing.Size(672, 689);
            this.tbp_giocatore.TabIndex = 1;
            this.tbp_giocatore.Text = "giocatore";
            this.tbp_giocatore.UseVisualStyleBackColor = true;
            // 
            // grb_cancella
            // 
            this.grb_cancella.Controls.Add(this.btn_cancella);
            this.grb_cancella.Controls.Add(this.label2);
            this.grb_cancella.Controls.Add(this.txb_cancella);
            this.grb_cancella.Location = new System.Drawing.Point(23, 245);
            this.grb_cancella.Name = "grb_cancella";
            this.grb_cancella.Size = new System.Drawing.Size(623, 194);
            this.grb_cancella.TabIndex = 1;
            this.grb_cancella.TabStop = false;
            this.grb_cancella.Text = "cancella giocatore";
            // 
            // btn_cancella
            // 
            this.btn_cancella.Location = new System.Drawing.Point(21, 75);
            this.btn_cancella.Name = "btn_cancella";
            this.btn_cancella.Size = new System.Drawing.Size(584, 83);
            this.btn_cancella.TabIndex = 2;
            this.btn_cancella.Text = "cancella";
            this.btn_cancella.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserisci nome giocatore da cancellare: ";
            // 
            // txb_cancella
            // 
            this.txb_cancella.Location = new System.Drawing.Point(218, 35);
            this.txb_cancella.Name = "txb_cancella";
            this.txb_cancella.Size = new System.Drawing.Size(217, 20);
            this.txb_cancella.TabIndex = 0;
            // 
            // grb_inserisci
            // 
            this.grb_inserisci.Controls.Add(this.btn_inserisci);
            this.grb_inserisci.Controls.Add(this.label1);
            this.grb_inserisci.Controls.Add(this.txb_inserisci);
            this.grb_inserisci.Location = new System.Drawing.Point(23, 29);
            this.grb_inserisci.Name = "grb_inserisci";
            this.grb_inserisci.Size = new System.Drawing.Size(623, 194);
            this.grb_inserisci.TabIndex = 0;
            this.grb_inserisci.TabStop = false;
            this.grb_inserisci.Text = "Nuovo giocatore";
            // 
            // btn_inserisci
            // 
            this.btn_inserisci.Location = new System.Drawing.Point(21, 75);
            this.btn_inserisci.Name = "btn_inserisci";
            this.btn_inserisci.Size = new System.Drawing.Size(584, 83);
            this.btn_inserisci.TabIndex = 2;
            this.btn_inserisci.Text = "Inserisci";
            this.btn_inserisci.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci nome nuovo giocatore:";
            // 
            // txb_inserisci
            // 
            this.txb_inserisci.Location = new System.Drawing.Point(181, 35);
            this.txb_inserisci.Name = "txb_inserisci";
            this.txb_inserisci.Size = new System.Drawing.Size(217, 20);
            this.txb_inserisci.TabIndex = 0;
            // 
            // panel_magliette
            // 
            this.panel_magliette.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_magliette.Location = new System.Drawing.Point(87, 62);
            this.panel_magliette.Name = "panel_magliette";
            this.panel_magliette.Size = new System.Drawing.Size(158, 165);
            this.panel_magliette.TabIndex = 5;
            this.panel_magliette.Visible = false;
            // 
            // cbo_giocatore
            // 
            this.cbo_giocatore.FormattingEnabled = true;
            this.cbo_giocatore.Items.AddRange(new object[] {
            "Alessio",
            "Marco"});
            this.cbo_giocatore.Location = new System.Drawing.Point(206, 522);
            this.cbo_giocatore.Name = "cbo_giocatore";
            this.cbo_giocatore.Size = new System.Drawing.Size(105, 21);
            this.cbo_giocatore.TabIndex = 2;
            // 
            // cbo_livello
            // 
            this.cbo_livello.FormattingEnabled = true;
            this.cbo_livello.Items.AddRange(new object[] {
            "Facile",
            "Medio",
            "Difficile"});
            this.cbo_livello.Location = new System.Drawing.Point(189, 257);
            this.cbo_livello.Name = "cbo_livello";
            this.cbo_livello.Size = new System.Drawing.Size(122, 21);
            this.cbo_livello.TabIndex = 1;
            // 
            // grb_record
            // 
            this.grb_record.Controls.Add(this.label4);
            this.grb_record.Controls.Add(this.label5);
            this.grb_record.Controls.Add(this.label3);
            this.grb_record.Controls.Add(this.pictureBox3);
            this.grb_record.Controls.Add(this.pictureBox2);
            this.grb_record.Location = new System.Drawing.Point(23, 476);
            this.grb_record.Name = "grb_record";
            this.grb_record.Size = new System.Drawing.Size(623, 194);
            this.grb_record.TabIndex = 2;
            this.grb_record.TabStop = false;
            this.grb_record.Text = "Record ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Football_Quiz.Properties.Resources.coppa;
            this.pictureBox3.Location = new System.Drawing.Point(31, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 155);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Football_Quiz.Properties.Resources.podio1;
            this.pictureBox2.Location = new System.Drawing.Point(245, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 156);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pb_back
            // 
            this.pb_back.Image = global::Football_Quiz.Properties.Resources.Screenshot__21_;
            this.pb_back.Location = new System.Drawing.Point(79, 674);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(157, 52);
            this.pb_back.TabIndex = 6;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_nuovogiocatore
            // 
            this.pb_nuovogiocatore.Image = global::Football_Quiz.Properties.Resources.Screenshot__20_;
            this.pb_nuovogiocatore.Location = new System.Drawing.Point(87, 559);
            this.pb_nuovogiocatore.Name = "pb_nuovogiocatore";
            this.pb_nuovogiocatore.Size = new System.Drawing.Size(147, 98);
            this.pb_nuovogiocatore.TabIndex = 5;
            this.pb_nuovogiocatore.TabStop = false;
            // 
            // pb_gioca
            // 
            this.pb_gioca.Image = global::Football_Quiz.Properties.Resources.Screenshot__18_;
            this.pb_gioca.Location = new System.Drawing.Point(51, 308);
            this.pb_gioca.Name = "pb_gioca";
            this.pb_gioca.Size = new System.Drawing.Size(206, 164);
            this.pb_gioca.TabIndex = 4;
            this.pb_gioca.TabStop = false;
            // 
            // pb_info
            // 
            this.pb_info.Image = global::Football_Quiz.Properties.Resources.Screenshot__17_1;
            this.pb_info.Location = new System.Drawing.Point(14, 0);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(54, 52);
            this.pb_info.TabIndex = 3;
            this.pb_info.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Football_Quiz.Properties.Resources.Screenshot__16_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 739);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 740);
            this.Controls.Add(this.panel_squadre);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.pb_magliette);
            this.Controls.Add(this.pb_squadre);
            this.Controls.Add(this.pb_sfondo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_squadre.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbp_giocatore.ResumeLayout(false);
            this.grb_cancella.ResumeLayout(false);
            this.grb_cancella.PerformLayout();
            this.grb_inserisci.ResumeLayout(false);
            this.grb_inserisci.PerformLayout();
            this.grb_record.ResumeLayout(false);
            this.grb_record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nuovogiocatore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gioca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel_squadre;
        private System.Windows.Forms.Panel panel_magliette;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_livello;
        private System.Windows.Forms.ComboBox cbo_giocatore;
        private System.Windows.Forms.PictureBox pb_info;
        private System.Windows.Forms.PictureBox pb_gioca;
        private System.Windows.Forms.PictureBox pb_nuovogiocatore;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_gioco;
        private System.Windows.Forms.TabPage tbp_giocatore;
        private System.Windows.Forms.GroupBox grb_inserisci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_inserisci;
        private System.Windows.Forms.GroupBox grb_cancella;
        private System.Windows.Forms.Button btn_cancella;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_cancella;
        private System.Windows.Forms.Button btn_inserisci;
        private System.Windows.Forms.GroupBox grb_record;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

