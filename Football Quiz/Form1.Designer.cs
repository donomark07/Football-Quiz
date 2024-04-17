using System.Drawing;
using System.Resources;

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
            this.tbc_squadre = new System.Windows.Forms.TabControl();
            this.tbp_giocatore = new System.Windows.Forms.TabPage();
            this.grb_record = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_cancella = new System.Windows.Forms.GroupBox();
            this.btn_cancella = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_cancella = new System.Windows.Forms.TextBox();
            this.grb_inserisci = new System.Windows.Forms.GroupBox();
            this.btn_inserisci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_inserisci = new System.Windows.Forms.TextBox();
            this.tbp_giocofacile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbp_giocomedio = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbp_giocodifficile = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbp_1facile = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbp_2facile = new System.Windows.Forms.TabPage();
            this.tbp_3facile = new System.Windows.Forms.TabPage();
            this.tbp_4facile = new System.Windows.Forms.TabPage();
            this.tbp_5facile = new System.Windows.Forms.TabPage();
            this.tbp_6facile = new System.Windows.Forms.TabPage();
            this.tbp_7facile = new System.Windows.Forms.TabPage();
            this.tbp_8facile = new System.Windows.Forms.TabPage();
            this.tbp_9facile = new System.Windows.Forms.TabPage();
            this.tbp_10facile = new System.Windows.Forms.TabPage();
            this.cbo_giocatore = new System.Windows.Forms.ComboBox();
            this.cbo_livello = new System.Windows.Forms.ComboBox();
            this.panel_magliette = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_nuovogiocatore = new System.Windows.Forms.PictureBox();
            this.pb_gioca = new System.Windows.Forms.PictureBox();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_magliette = new System.Windows.Forms.PictureBox();
            this.pb_squadre = new System.Windows.Forms.PictureBox();
            this.pb_sfondo = new System.Windows.Forms.PictureBox();
            this.panel_squadre.SuspendLayout();
            this.tbc_squadre.SuspendLayout();
            this.tbp_giocatore.SuspendLayout();
            this.grb_record.SuspendLayout();
            this.grb_cancella.SuspendLayout();
            this.grb_inserisci.SuspendLayout();
            this.tbp_giocofacile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbp_giocomedio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbp_giocodifficile.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbp_1facile.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
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
            this.panel_squadre.Controls.Add(this.tbc_squadre);
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
            // tbc_squadre
            // 
            this.tbc_squadre.Controls.Add(this.tbp_giocatore);
            this.tbc_squadre.Controls.Add(this.tbp_giocofacile);
            this.tbc_squadre.Controls.Add(this.tbp_giocomedio);
            this.tbc_squadre.Controls.Add(this.tbp_giocodifficile);
            this.tbc_squadre.Controls.Add(this.tbp_1facile);
            this.tbc_squadre.Controls.Add(this.tbp_2facile);
            this.tbc_squadre.Controls.Add(this.tbp_3facile);
            this.tbc_squadre.Controls.Add(this.tbp_4facile);
            this.tbc_squadre.Controls.Add(this.tbp_5facile);
            this.tbc_squadre.Controls.Add(this.tbp_6facile);
            this.tbc_squadre.Controls.Add(this.tbp_7facile);
            this.tbc_squadre.Controls.Add(this.tbp_8facile);
            this.tbc_squadre.Controls.Add(this.tbp_9facile);
            this.tbc_squadre.Controls.Add(this.tbp_10facile);
            this.tbc_squadre.Location = new System.Drawing.Point(329, 3);
            this.tbc_squadre.Name = "tbc_squadre";
            this.tbc_squadre.SelectedIndex = 0;
            this.tbc_squadre.Size = new System.Drawing.Size(680, 723);
            this.tbc_squadre.TabIndex = 7;
            this.tbc_squadre.Visible = false;
            // 
            // tbp_giocatore
            // 
            this.tbp_giocatore.Controls.Add(this.grb_record);
            this.tbp_giocatore.Controls.Add(this.grb_cancella);
            this.tbp_giocatore.Controls.Add(this.grb_inserisci);
            this.tbp_giocatore.Location = new System.Drawing.Point(4, 22);
            this.tbp_giocatore.Name = "tbp_giocatore";
            this.tbp_giocatore.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_giocatore.Size = new System.Drawing.Size(672, 697);
            this.tbp_giocatore.TabIndex = 1;
            this.tbp_giocatore.Text = "giocatore";
            this.tbp_giocatore.UseVisualStyleBackColor = true;
            // 
            // grb_record
            // 
            this.grb_record.Controls.Add(this.pictureBox3);
            this.grb_record.Controls.Add(this.label4);
            this.grb_record.Controls.Add(this.label5);
            this.grb_record.Controls.Add(this.label3);
            this.grb_record.Controls.Add(this.pictureBox2);
            this.grb_record.Location = new System.Drawing.Point(23, 476);
            this.grb_record.Name = "grb_record";
            this.grb_record.Size = new System.Drawing.Size(623, 194);
            this.grb_record.TabIndex = 2;
            this.grb_record.TabStop = false;
            this.grb_record.Text = "Record ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "???";
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
            // tbp_giocofacile
            // 
            this.tbp_giocofacile.BackColor = System.Drawing.Color.Transparent;
            this.tbp_giocofacile.Controls.Add(this.groupBox1);
            this.tbp_giocofacile.Controls.Add(this.pictureBox14);
            this.tbp_giocofacile.Location = new System.Drawing.Point(4, 22);
            this.tbp_giocofacile.Name = "tbp_giocofacile";
            this.tbp_giocofacile.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_giocofacile.Size = new System.Drawing.Size(672, 697);
            this.tbp_giocofacile.TabIndex = 0;
            this.tbp_giocofacile.Text = "gioco facile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.pictureBox13);
            this.groupBox1.Location = new System.Drawing.Point(6, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 569);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facile";
            // 
            // tbp_giocomedio
            // 
            this.tbp_giocomedio.Controls.Add(this.groupBox2);
            this.tbp_giocomedio.Controls.Add(this.pictureBox25);
            this.tbp_giocomedio.Location = new System.Drawing.Point(4, 22);
            this.tbp_giocomedio.Name = "tbp_giocomedio";
            this.tbp_giocomedio.Size = new System.Drawing.Size(672, 697);
            this.tbp_giocomedio.TabIndex = 2;
            this.tbp_giocomedio.Text = "gioco medio";
            this.tbp_giocomedio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox15);
            this.groupBox2.Controls.Add(this.pictureBox16);
            this.groupBox2.Controls.Add(this.pictureBox17);
            this.groupBox2.Controls.Add(this.pictureBox18);
            this.groupBox2.Controls.Add(this.pictureBox19);
            this.groupBox2.Controls.Add(this.pictureBox20);
            this.groupBox2.Controls.Add(this.pictureBox21);
            this.groupBox2.Controls.Add(this.pictureBox22);
            this.groupBox2.Controls.Add(this.pictureBox23);
            this.groupBox2.Controls.Add(this.pictureBox24);
            this.groupBox2.Location = new System.Drawing.Point(6, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 569);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medio";
            // 
            // tbp_giocodifficile
            // 
            this.tbp_giocodifficile.Controls.Add(this.groupBox3);
            this.tbp_giocodifficile.Controls.Add(this.pictureBox36);
            this.tbp_giocodifficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_giocodifficile.Name = "tbp_giocodifficile";
            this.tbp_giocodifficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_giocodifficile.TabIndex = 3;
            this.tbp_giocodifficile.Text = "gioco difficile";
            this.tbp_giocodifficile.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox26);
            this.groupBox3.Controls.Add(this.pictureBox27);
            this.groupBox3.Controls.Add(this.pictureBox28);
            this.groupBox3.Controls.Add(this.pictureBox29);
            this.groupBox3.Controls.Add(this.pictureBox30);
            this.groupBox3.Controls.Add(this.pictureBox31);
            this.groupBox3.Controls.Add(this.pictureBox32);
            this.groupBox3.Controls.Add(this.pictureBox33);
            this.groupBox3.Controls.Add(this.pictureBox34);
            this.groupBox3.Controls.Add(this.pictureBox35);
            this.groupBox3.Location = new System.Drawing.Point(6, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 569);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Difficile";
            // 
            // tbp_1facile
            // 
            this.tbp_1facile.Controls.Add(this.groupBox4);
            this.tbp_1facile.Controls.Add(this.pictureBox47);
            this.tbp_1facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_1facile.Name = "tbp_1facile";
            this.tbp_1facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_1facile.TabIndex = 4;
            this.tbp_1facile.Text = "livello 1 facile";
            this.tbp_1facile.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox41);
            this.groupBox4.Controls.Add(this.pictureBox40);
            this.groupBox4.Controls.Add(this.pictureBox39);
            this.groupBox4.Controls.Add(this.pictureBox38);
            this.groupBox4.Controls.Add(this.pictureBox37);
            this.groupBox4.Location = new System.Drawing.Point(6, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(660, 569);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Facile";
            // 
            // tbp_2facile
            // 
            this.tbp_2facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_2facile.Name = "tbp_2facile";
            this.tbp_2facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_2facile.TabIndex = 5;
            this.tbp_2facile.Text = "livello 2 facile";
            this.tbp_2facile.UseVisualStyleBackColor = true;
            // 
            // tbp_3facile
            // 
            this.tbp_3facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_3facile.Name = "tbp_3facile";
            this.tbp_3facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_3facile.TabIndex = 6;
            this.tbp_3facile.Text = "livello 3 facile";
            this.tbp_3facile.UseVisualStyleBackColor = true;
            // 
            // tbp_4facile
            // 
            this.tbp_4facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_4facile.Name = "tbp_4facile";
            this.tbp_4facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_4facile.TabIndex = 7;
            this.tbp_4facile.Text = "livello 4 facile";
            this.tbp_4facile.UseVisualStyleBackColor = true;
            // 
            // tbp_5facile
            // 
            this.tbp_5facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_5facile.Name = "tbp_5facile";
            this.tbp_5facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_5facile.TabIndex = 8;
            this.tbp_5facile.Text = "livello 5 facile";
            this.tbp_5facile.UseVisualStyleBackColor = true;
            // 
            // tbp_6facile
            // 
            this.tbp_6facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_6facile.Name = "tbp_6facile";
            this.tbp_6facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_6facile.TabIndex = 9;
            this.tbp_6facile.Text = "livello 6 facile";
            this.tbp_6facile.UseVisualStyleBackColor = true;
            // 
            // tbp_7facile
            // 
            this.tbp_7facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_7facile.Name = "tbp_7facile";
            this.tbp_7facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_7facile.TabIndex = 10;
            this.tbp_7facile.Text = "livello 7 facile";
            this.tbp_7facile.UseVisualStyleBackColor = true;
            // 
            // tbp_8facile
            // 
            this.tbp_8facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_8facile.Name = "tbp_8facile";
            this.tbp_8facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_8facile.TabIndex = 11;
            this.tbp_8facile.Text = "livello 8 facile";
            this.tbp_8facile.UseVisualStyleBackColor = true;
            // 
            // tbp_9facile
            // 
            this.tbp_9facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_9facile.Name = "tbp_9facile";
            this.tbp_9facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_9facile.TabIndex = 12;
            this.tbp_9facile.Text = "livello 9 facile";
            this.tbp_9facile.UseVisualStyleBackColor = true;
            // 
            // tbp_10facile
            // 
            this.tbp_10facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_10facile.Name = "tbp_10facile";
            this.tbp_10facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_10facile.TabIndex = 13;
            this.tbp_10facile.Text = "livello 10 facile";
            this.tbp_10facile.UseVisualStyleBackColor = true;
            // 
            // cbo_giocatore
            // 
            this.cbo_giocatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbo_livello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // panel_magliette
            // 
            this.panel_magliette.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_magliette.Location = new System.Drawing.Point(779, 157);
            this.panel_magliette.Name = "panel_magliette";
            this.panel_magliette.Size = new System.Drawing.Size(158, 165);
            this.panel_magliette.TabIndex = 5;
            this.panel_magliette.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Football_Quiz.Properties.Resources.coppa_removebg_preview1;
            this.pictureBox3.Location = new System.Drawing.Point(47, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(267, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 128);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(482, 287);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 128);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(267, 287);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 128);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox7.Location = new System.Drawing.Point(48, 287);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(131, 128);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox8.Location = new System.Drawing.Point(48, 153);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(131, 128);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox9.Location = new System.Drawing.Point(482, 19);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(131, 128);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox10.Location = new System.Drawing.Point(48, 19);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(131, 128);
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox11.Location = new System.Drawing.Point(267, 19);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(131, 128);
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox12.Location = new System.Drawing.Point(482, 153);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(131, 128);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox13.Location = new System.Drawing.Point(267, 153);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(131, 128);
            this.pictureBox13.TabIndex = 22;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox14.Location = new System.Drawing.Point(214, 21);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(272, 80);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox15.Location = new System.Drawing.Point(267, 421);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(131, 128);
            this.pictureBox15.TabIndex = 31;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox16.Location = new System.Drawing.Point(482, 287);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(131, 128);
            this.pictureBox16.TabIndex = 30;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox17.Location = new System.Drawing.Point(267, 287);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(131, 128);
            this.pictureBox17.TabIndex = 29;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox18.Location = new System.Drawing.Point(48, 287);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(131, 128);
            this.pictureBox18.TabIndex = 28;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox19.Location = new System.Drawing.Point(48, 153);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(131, 128);
            this.pictureBox19.TabIndex = 27;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox20.Location = new System.Drawing.Point(482, 19);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(131, 128);
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox21.Location = new System.Drawing.Point(48, 19);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(131, 128);
            this.pictureBox21.TabIndex = 25;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox22.Location = new System.Drawing.Point(267, 19);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(131, 128);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox23.Location = new System.Drawing.Point(482, 153);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(131, 128);
            this.pictureBox23.TabIndex = 23;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox24.Location = new System.Drawing.Point(267, 153);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(131, 128);
            this.pictureBox24.TabIndex = 22;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox25.Location = new System.Drawing.Point(214, 21);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(272, 80);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox25.TabIndex = 13;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox26.Location = new System.Drawing.Point(267, 421);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(131, 128);
            this.pictureBox26.TabIndex = 31;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox27.Location = new System.Drawing.Point(482, 287);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(131, 128);
            this.pictureBox27.TabIndex = 30;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox28.Location = new System.Drawing.Point(267, 287);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(131, 128);
            this.pictureBox28.TabIndex = 29;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox29.Location = new System.Drawing.Point(48, 287);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(131, 128);
            this.pictureBox29.TabIndex = 28;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox30.Location = new System.Drawing.Point(48, 153);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(131, 128);
            this.pictureBox30.TabIndex = 27;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox31.Location = new System.Drawing.Point(482, 19);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(131, 128);
            this.pictureBox31.TabIndex = 26;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox32.Location = new System.Drawing.Point(48, 19);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(131, 128);
            this.pictureBox32.TabIndex = 25;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Image = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox33.Location = new System.Drawing.Point(267, 19);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(131, 128);
            this.pictureBox33.TabIndex = 24;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Image = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox34.Location = new System.Drawing.Point(482, 153);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(131, 128);
            this.pictureBox34.TabIndex = 23;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox35.Location = new System.Drawing.Point(267, 153);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(131, 128);
            this.pictureBox35.TabIndex = 22;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox36.Location = new System.Drawing.Point(214, 21);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(272, 80);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox36.TabIndex = 13;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pictureBox41.Location = new System.Drawing.Point(6, 498);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(60, 77);
            this.pictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox41.TabIndex = 4;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox40.Location = new System.Drawing.Point(305, 507);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(48, 53);
            this.pictureBox40.TabIndex = 3;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox39.Location = new System.Drawing.Point(251, 507);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(48, 53);
            this.pictureBox39.TabIndex = 2;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox38.Location = new System.Drawing.Point(359, 507);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(48, 53);
            this.pictureBox38.TabIndex = 1;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pictureBox37.Location = new System.Drawing.Point(594, 501);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(60, 62);
            this.pictureBox37.TabIndex = 0;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox47
            // 
            this.pictureBox47.Image = global::Football_Quiz.Properties.Resources.scritta_livello_1_removebg_preview;
            this.pictureBox47.Location = new System.Drawing.Point(179, 21);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(318, 80);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox47.TabIndex = 15;
            this.pictureBox47.TabStop = false;
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
            this.pb_nuovogiocatore.Click += new System.EventHandler(this.pb_nuovogiocatore_Click);
            // 
            // pb_gioca
            // 
            this.pb_gioca.Image = global::Football_Quiz.Properties.Resources.Screenshot__18_;
            this.pb_gioca.Location = new System.Drawing.Point(51, 308);
            this.pb_gioca.Name = "pb_gioca";
            this.pb_gioca.Size = new System.Drawing.Size(206, 164);
            this.pb_gioca.TabIndex = 4;
            this.pb_gioca.TabStop = false;
            this.pb_gioca.Click += new System.EventHandler(this.pb_gioca_Click);
            // 
            // pb_info
            // 
            this.pb_info.Image = global::Football_Quiz.Properties.Resources.Screenshot__17_1;
            this.pb_info.Location = new System.Drawing.Point(14, 0);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(54, 52);
            this.pb_info.TabIndex = 3;
            this.pb_info.TabStop = false;
            this.pb_info.Click += new System.EventHandler(this.pb_info_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 740);
            this.Controls.Add(this.panel_squadre);
            this.Controls.Add(this.panel_magliette);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.pb_magliette);
            this.Controls.Add(this.pb_squadre);
            this.Controls.Add(this.pb_sfondo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_squadre.ResumeLayout(false);
            this.tbc_squadre.ResumeLayout(false);
            this.tbp_giocatore.ResumeLayout(false);
            this.grb_record.ResumeLayout(false);
            this.grb_record.PerformLayout();
            this.grb_cancella.ResumeLayout(false);
            this.grb_cancella.PerformLayout();
            this.grb_inserisci.ResumeLayout(false);
            this.grb_inserisci.PerformLayout();
            this.tbp_giocofacile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tbp_giocomedio.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tbp_giocodifficile.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tbp_1facile.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
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
        private System.Windows.Forms.TabControl tbc_squadre;
        private System.Windows.Forms.TabPage tbp_giocofacile;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbp_giocomedio;
        private System.Windows.Forms.TabPage tbp_giocodifficile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.TabPage tbp_1facile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox47;
        private System.Windows.Forms.TabPage tbp_2facile;
        private System.Windows.Forms.TabPage tbp_3facile;
        private System.Windows.Forms.TabPage tbp_4facile;
        private System.Windows.Forms.TabPage tbp_5facile;
        private System.Windows.Forms.TabPage tbp_6facile;
        private System.Windows.Forms.TabPage tbp_7facile;
        private System.Windows.Forms.TabPage tbp_8facile;
        private System.Windows.Forms.TabPage tbp_9facile;
        private System.Windows.Forms.TabPage tbp_10facile;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.PictureBox pictureBox39;
    }
}

