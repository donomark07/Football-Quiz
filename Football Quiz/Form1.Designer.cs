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
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_punteggio1facile = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziofacile1_3 = new System.Windows.Forms.Label();
            this.lbl_indiziofacile1_1 = new System.Windows.Forms.Label();
            this.lbl_indiziofacile1_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile1 = new System.Windows.Forms.Label();
            this.btn_opzione4facile1 = new System.Windows.Forms.Button();
            this.btn_opzione3facile1 = new System.Windows.Forms.Button();
            this.btn_opzione2facile1 = new System.Windows.Forms.Button();
            this.btn_opzione1facile1 = new System.Windows.Forms.Button();
            this.tbp_2facile = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_punteggio2facile = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile2_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile2_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile2_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile2 = new System.Windows.Forms.Button();
            this.btn_opzione3facile2 = new System.Windows.Forms.Button();
            this.btn_opzione2facile2 = new System.Windows.Forms.Button();
            this.btn_opzione1facile2 = new System.Windows.Forms.Button();
            this.tbp_3facile = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_punteggio3facile = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziofacile3_1 = new System.Windows.Forms.Label();
            this.lbl_indiziofacile3_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile3_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile3 = new System.Windows.Forms.Button();
            this.btn_opzione3facile3 = new System.Windows.Forms.Button();
            this.btn_opzione2facile3 = new System.Windows.Forms.Button();
            this.btn_opzione1facile3 = new System.Windows.Forms.Button();
            this.tbp_4facile = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_punteggio4facile = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziofacile4_1 = new System.Windows.Forms.Label();
            this.lbl_indiziofacile4_2 = new System.Windows.Forms.Label();
            this.lbl_indiziofacile4_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile4 = new System.Windows.Forms.Button();
            this.btn_opzione3facile4 = new System.Windows.Forms.Button();
            this.btn_opzione2facile4 = new System.Windows.Forms.Button();
            this.btn_opzione1facile4 = new System.Windows.Forms.Button();
            this.tbp_5facile = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_punteggio5facile = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile5_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile5_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile5_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile5 = new System.Windows.Forms.Button();
            this.btn_opzione3facile5 = new System.Windows.Forms.Button();
            this.btn_opzione2facile5 = new System.Windows.Forms.Button();
            this.btn_opzione1facile5 = new System.Windows.Forms.Button();
            this.tbp_6facile = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_punteggio6facile = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile6_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile6_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile6_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile6 = new System.Windows.Forms.Button();
            this.btn_opzione3facile6 = new System.Windows.Forms.Button();
            this.btn_opzione2facile6 = new System.Windows.Forms.Button();
            this.btn_opzione1facile6 = new System.Windows.Forms.Button();
            this.tbp_7facile = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_punteggio7facile = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile7_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile7_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile7_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile7 = new System.Windows.Forms.Button();
            this.btn_opzione3facile7 = new System.Windows.Forms.Button();
            this.btn_opzione2facile7 = new System.Windows.Forms.Button();
            this.btn_opzione1facile7 = new System.Windows.Forms.Button();
            this.tbp_8facile = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_punteggio8facile = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile8_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile8_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile8_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile8 = new System.Windows.Forms.Button();
            this.btn_opzione3facile8 = new System.Windows.Forms.Button();
            this.btn_opzione2facile8 = new System.Windows.Forms.Button();
            this.btn_opzione1facile8 = new System.Windows.Forms.Button();
            this.tbp_9facile = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_punteggio9facile = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile9_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile9_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile9_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile9 = new System.Windows.Forms.Button();
            this.btn_opzione3facile9 = new System.Windows.Forms.Button();
            this.btn_opzione2facile9 = new System.Windows.Forms.Button();
            this.btn_opzione1facile9 = new System.Windows.Forms.Button();
            this.tbp_10facile = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_punteggio10facile = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile10_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile10_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile10_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile10 = new System.Windows.Forms.Button();
            this.btn_opzione3facile10 = new System.Windows.Forms.Button();
            this.btn_opzione2facile10 = new System.Windows.Forms.Button();
            this.btn_opzione1facile10 = new System.Windows.Forms.Button();
            this.tbp_finefacile = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_punteggiofinale = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbp_1medio = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_punteggio1medio = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziomedio1_3 = new System.Windows.Forms.Label();
            this.lbl_indiziomedio1_1 = new System.Windows.Forms.Label();
            this.lbl_indiziomedio1_2 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_opzione4medio1 = new System.Windows.Forms.Button();
            this.btn_opzione3medio1 = new System.Windows.Forms.Button();
            this.btn_opzione2medio1 = new System.Windows.Forms.Button();
            this.btn_opzione1medio1 = new System.Windows.Forms.Button();
            this.tbp_2medio = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl_punteggio2medio = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziomedio2_1 = new System.Windows.Forms.Label();
            this.lbl_indiziomedio2_2 = new System.Windows.Forms.Label();
            this.lbl_indiziomedio2_3 = new System.Windows.Forms.Label();
            this.btn_opzione4medio2 = new System.Windows.Forms.Button();
            this.btn_opzione3medio2 = new System.Windows.Forms.Button();
            this.btn_opzione2medio2 = new System.Windows.Forms.Button();
            this.btn_opzione1medio2 = new System.Windows.Forms.Button();
            this.tbp_3medio = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_punteggio3medio = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziomedio3_3 = new System.Windows.Forms.Label();
            this.lbl_indiziomedio3_1 = new System.Windows.Forms.Label();
            this.lbl_indiziomedio3_2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btn_opzione4medio3 = new System.Windows.Forms.Button();
            this.btn_opzione3medio3 = new System.Windows.Forms.Button();
            this.btn_opzione2medio3 = new System.Windows.Forms.Button();
            this.btn_opzione1medio3 = new System.Windows.Forms.Button();
            this.tbp_4medio = new System.Windows.Forms.TabPage();
            this.tbp_5medio = new System.Windows.Forms.TabPage();
            this.tbp_6medio = new System.Windows.Forms.TabPage();
            this.tbp_7medio = new System.Windows.Forms.TabPage();
            this.tbp_8medio = new System.Windows.Forms.TabPage();
            this.tbp_9medio = new System.Windows.Forms.TabPage();
            this.tbp_10medio = new System.Windows.Forms.TabPage();
            this.tbp_finemedio = new System.Windows.Forms.TabPage();
            this.tbp_1difficile = new System.Windows.Forms.TabPage();
            this.tbp_2difficile = new System.Windows.Forms.TabPage();
            this.tbp_3difficile = new System.Windows.Forms.TabPage();
            this.tbp_4difficile = new System.Windows.Forms.TabPage();
            this.tbp_5difficile = new System.Windows.Forms.TabPage();
            this.tbp_6difficile = new System.Windows.Forms.TabPage();
            this.tbp_7difficile = new System.Windows.Forms.TabPage();
            this.tbp_8difficile = new System.Windows.Forms.TabPage();
            this.tbp_9difficile = new System.Windows.Forms.TabPage();
            this.tbp_10difficile = new System.Windows.Forms.TabPage();
            this.tbp_finedifficili = new System.Windows.Forms.TabPage();
            this.cbo_giocatore = new System.Windows.Forms.ComboBox();
            this.cbo_livello = new System.Windows.Forms.ComboBox();
            this.panel_magliette = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_opzione4medio4 = new System.Windows.Forms.Button();
            this.btn_opzione3medio4 = new System.Windows.Forms.Button();
            this.btn_opzione2medio4 = new System.Windows.Forms.Button();
            this.btn_opzione1medio4 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile4 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile4 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile4 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile4 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.btn_opzione4medio5 = new System.Windows.Forms.Button();
            this.btn_opzione3medio5 = new System.Windows.Forms.Button();
            this.btn_opzione2medio5 = new System.Windows.Forms.Button();
            this.btn_opzione1medio5 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile5 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile5 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile5 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile5 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.btn_opzione4medio6 = new System.Windows.Forms.Button();
            this.btn_opzione3medio6 = new System.Windows.Forms.Button();
            this.btn_opzione2medio6 = new System.Windows.Forms.Button();
            this.btn_opzione1medio6 = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile6 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile6 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile6 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile6 = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.btn_opzione4medio7 = new System.Windows.Forms.Button();
            this.btn_opzione3medio7 = new System.Windows.Forms.Button();
            this.btn_opzione2medio7 = new System.Windows.Forms.Button();
            this.btn_opzione1medio7 = new System.Windows.Forms.Button();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile7 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile7 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile7 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile7 = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.btn_opzione4medio8 = new System.Windows.Forms.Button();
            this.btn_opzione3medio8 = new System.Windows.Forms.Button();
            this.btn_opzione2medio8 = new System.Windows.Forms.Button();
            this.btn_opzione1medio8 = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile8 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile8 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile8 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile8 = new System.Windows.Forms.Button();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.btn_opzione4medio9 = new System.Windows.Forms.Button();
            this.btn_opzione3medio9 = new System.Windows.Forms.Button();
            this.btn_opzione2medio9 = new System.Windows.Forms.Button();
            this.btn_opzione1medio9 = new System.Windows.Forms.Button();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile9 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile9 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile9 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile9 = new System.Windows.Forms.Button();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.btn_opzione4medio10 = new System.Windows.Forms.Button();
            this.btn_opzione3medio10 = new System.Windows.Forms.Button();
            this.btn_opzione2medio10 = new System.Windows.Forms.Button();
            this.btn_opzione1medio10 = new System.Windows.Forms.Button();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile10 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile10 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile10 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile10 = new System.Windows.Forms.Button();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile1 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile1 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile1 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile1 = new System.Windows.Forms.Button();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile2 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile2 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile2 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile2 = new System.Windows.Forms.Button();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.btn_opzione4difficile3 = new System.Windows.Forms.Button();
            this.btn_opzione3difficile3 = new System.Windows.Forms.Button();
            this.btn_opzione2difficile3 = new System.Windows.Forms.Button();
            this.btn_opzione1difficile3 = new System.Windows.Forms.Button();
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
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile1_2 = new System.Windows.Forms.PictureBox();
            this.pb_inzidiofacile1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile1_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti1facile = new System.Windows.Forms.PictureBox();
            this.pictureBox97 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile2_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile2_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile2_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti2facile = new System.Windows.Forms.PictureBox();
            this.pictureBox98 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind3 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile3_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile3_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile3_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti3facile = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind4 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile4_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile4_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile4_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti4facile = new System.Windows.Forms.PictureBox();
            this.pictureBox99 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind5 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile5_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile5_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile5_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti5facile = new System.Windows.Forms.PictureBox();
            this.pictureBox100 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind6 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile6_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile6_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile6_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti6facile = new System.Windows.Forms.PictureBox();
            this.pictureBox101 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind7 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile7_2 = new System.Windows.Forms.PictureBox();
            this.pb_indizifacile7_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile7_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti7facile = new System.Windows.Forms.PictureBox();
            this.pictureBox102 = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind8 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile8_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile8_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile8_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti8facile = new System.Windows.Forms.PictureBox();
            this.pictureBox103 = new System.Windows.Forms.PictureBox();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind9 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile9_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile9_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile9_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti9facile = new System.Windows.Forms.PictureBox();
            this.pictureBox104 = new System.Windows.Forms.PictureBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind10 = new System.Windows.Forms.PictureBox();
            this.pb_livellofacile10_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile10_1 = new System.Windows.Forms.PictureBox();
            this.pb_livellofacile10_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox105 = new System.Windows.Forms.PictureBox();
            this.pictureBox96 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio1_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio1_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio1_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio1 = new System.Windows.Forms.PictureBox();
            this.pb_homelivello1medio = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaindietromedio2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio2_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio2_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio2_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio2 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio2 = new System.Windows.Forms.PictureBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaindietromedio3 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio3_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio3_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio3_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio3 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio3 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio4_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio4_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio4_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio4 = new System.Windows.Forms.PictureBox();
            this.pb_homelivello4medio = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio5_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio5_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio5_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio5 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio5 = new System.Windows.Forms.PictureBox();
            this.pictureBox91 = new System.Windows.Forms.PictureBox();
            this.pictureBox110 = new System.Windows.Forms.PictureBox();
            this.pictureBox111 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio6_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio6_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio6_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio6 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio6 = new System.Windows.Forms.PictureBox();
            this.pictureBox117 = new System.Windows.Forms.PictureBox();
            this.pictureBox126 = new System.Windows.Forms.PictureBox();
            this.pictureBox127 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio7_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio7_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio7_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio7 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio7 = new System.Windows.Forms.PictureBox();
            this.pictureBox133 = new System.Windows.Forms.PictureBox();
            this.pictureBox142 = new System.Windows.Forms.PictureBox();
            this.pictureBox143 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio8_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio8_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio8_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio8 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio8 = new System.Windows.Forms.PictureBox();
            this.pictureBox151 = new System.Windows.Forms.PictureBox();
            this.pictureBox160 = new System.Windows.Forms.PictureBox();
            this.pictureBox161 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio9_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio9_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio9_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantimedio9 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio9 = new System.Windows.Forms.PictureBox();
            this.pictureBox167 = new System.Windows.Forms.PictureBox();
            this.pictureBox176 = new System.Windows.Forms.PictureBox();
            this.pictureBox177 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio10_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio10_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziomedio10_3 = new System.Windows.Forms.PictureBox();
            this.pb_homemedio10 = new System.Windows.Forms.PictureBox();
            this.pictureBox182 = new System.Windows.Forms.PictureBox();
            this.pictureBox190 = new System.Windows.Forms.PictureBox();
            this.pictureBox191 = new System.Windows.Forms.PictureBox();
            this.pictureBox192 = new System.Windows.Forms.PictureBox();
            this.pictureBox193 = new System.Windows.Forms.PictureBox();
            this.pictureBox194 = new System.Windows.Forms.PictureBox();
            this.pictureBox198 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile1_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile1_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile1_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile1 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile1 = new System.Windows.Forms.PictureBox();
            this.pictureBox204 = new System.Windows.Forms.PictureBox();
            this.pictureBox205 = new System.Windows.Forms.PictureBox();
            this.pictureBox206 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile2_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile2_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile2_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile2 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile2 = new System.Windows.Forms.PictureBox();
            this.pictureBox212 = new System.Windows.Forms.PictureBox();
            this.pictureBox213 = new System.Windows.Forms.PictureBox();
            this.pictureBox214 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile3_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile3_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile3_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile3 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile3 = new System.Windows.Forms.PictureBox();
            this.pictureBox220 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile4_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile4_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile4_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile4 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile4 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile5_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile5_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile5_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile5 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile5 = new System.Windows.Forms.PictureBox();
            this.pictureBox109 = new System.Windows.Forms.PictureBox();
            this.pictureBox118 = new System.Windows.Forms.PictureBox();
            this.pictureBox119 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile6_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile6_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile6_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile6 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile6 = new System.Windows.Forms.PictureBox();
            this.pictureBox125 = new System.Windows.Forms.PictureBox();
            this.pictureBox134 = new System.Windows.Forms.PictureBox();
            this.pictureBox135 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile7_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile7_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile7_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile7 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile7 = new System.Windows.Forms.PictureBox();
            this.pictureBox141 = new System.Windows.Forms.PictureBox();
            this.pictureBox152 = new System.Windows.Forms.PictureBox();
            this.pictureBox153 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile8_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile8_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile8_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile8 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile8 = new System.Windows.Forms.PictureBox();
            this.pictureBox159 = new System.Windows.Forms.PictureBox();
            this.pictureBox168 = new System.Windows.Forms.PictureBox();
            this.pictureBox169 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile9_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile9_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile9_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavantidifficile9 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile9 = new System.Windows.Forms.PictureBox();
            this.pictureBox175 = new System.Windows.Forms.PictureBox();
            this.pictureBox183 = new System.Windows.Forms.PictureBox();
            this.pictureBox184 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile10_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile10_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziodifficile10_3 = new System.Windows.Forms.PictureBox();
            this.pb_homedifficile10 = new System.Windows.Forms.PictureBox();
            this.pictureBox189 = new System.Windows.Forms.PictureBox();
            this.pictureBox147 = new System.Windows.Forms.PictureBox();
            this.pictureBox148 = new System.Windows.Forms.PictureBox();
            this.pictureBox195 = new System.Windows.Forms.PictureBox();
            this.pictureBox196 = new System.Windows.Forms.PictureBox();
            this.pictureBox197 = new System.Windows.Forms.PictureBox();
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
            this.tbp_2facile.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tbp_3facile.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tbp_4facile.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tbp_5facile.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tbp_6facile.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tbp_7facile.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tbp_8facile.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tbp_9facile.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tbp_10facile.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tbp_finefacile.SuspendLayout();
            this.tbp_1medio.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tbp_2medio.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.tbp_3medio.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tbp_4medio.SuspendLayout();
            this.tbp_5medio.SuspendLayout();
            this.tbp_6medio.SuspendLayout();
            this.tbp_7medio.SuspendLayout();
            this.tbp_8medio.SuspendLayout();
            this.tbp_9medio.SuspendLayout();
            this.tbp_10medio.SuspendLayout();
            this.tbp_finemedio.SuspendLayout();
            this.tbp_1difficile.SuspendLayout();
            this.tbp_2difficile.SuspendLayout();
            this.tbp_3difficile.SuspendLayout();
            this.tbp_4difficile.SuspendLayout();
            this.tbp_5difficile.SuspendLayout();
            this.tbp_6difficile.SuspendLayout();
            this.tbp_7difficile.SuspendLayout();
            this.tbp_8difficile.SuspendLayout();
            this.tbp_9difficile.SuspendLayout();
            this.tbp_10difficile.SuspendLayout();
            this.tbp_finedifficili.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox33.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inzidiofacile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti1facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti2facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti3facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti4facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti5facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile6_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile6_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile6_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti6facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indizifacile7_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile7_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti7facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile8_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile8_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile8_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti8facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile9_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile9_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile9_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti9facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_livellofacile10_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile10_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_livellofacile10_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homelivello1medio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaindietromedio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaindietromedio3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homelivello4medio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio6_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio6_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio6_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox117)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio7_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio7_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox133)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox142)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio8_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio8_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio8_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox160)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox161)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio9_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio9_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio9_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox176)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox177)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio10_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio10_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio10_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox190)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox191)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox192)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox193)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox194)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox204)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox205)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox206)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox212)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox213)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox214)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox220)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox118)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile6_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile6_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile6_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile7_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile7_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox152)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile8_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile8_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile8_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox159)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox168)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox169)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile9_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile9_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile9_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox175)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile10_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile10_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile10_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox189)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox147)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox148)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox195)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).BeginInit();
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
            this.panel_squadre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_squadre.Location = new System.Drawing.Point(-2, 1);
            this.panel_squadre.Name = "panel_squadre";
            this.panel_squadre.Size = new System.Drawing.Size(1022, 734);
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
            this.tbc_squadre.Controls.Add(this.tbp_finefacile);
            this.tbc_squadre.Controls.Add(this.tbp_1medio);
            this.tbc_squadre.Controls.Add(this.tbp_2medio);
            this.tbc_squadre.Controls.Add(this.tbp_3medio);
            this.tbc_squadre.Controls.Add(this.tbp_4medio);
            this.tbc_squadre.Controls.Add(this.tbp_5medio);
            this.tbc_squadre.Controls.Add(this.tbp_6medio);
            this.tbc_squadre.Controls.Add(this.tbp_7medio);
            this.tbc_squadre.Controls.Add(this.tbp_8medio);
            this.tbc_squadre.Controls.Add(this.tbp_9medio);
            this.tbc_squadre.Controls.Add(this.tbp_10medio);
            this.tbc_squadre.Controls.Add(this.tbp_finemedio);
            this.tbc_squadre.Controls.Add(this.tbp_1difficile);
            this.tbc_squadre.Controls.Add(this.tbp_2difficile);
            this.tbc_squadre.Controls.Add(this.tbp_3difficile);
            this.tbc_squadre.Controls.Add(this.tbp_4difficile);
            this.tbc_squadre.Controls.Add(this.tbp_5difficile);
            this.tbc_squadre.Controls.Add(this.tbp_6difficile);
            this.tbc_squadre.Controls.Add(this.tbp_7difficile);
            this.tbc_squadre.Controls.Add(this.tbp_8difficile);
            this.tbc_squadre.Controls.Add(this.tbp_9difficile);
            this.tbc_squadre.Controls.Add(this.tbp_10difficile);
            this.tbc_squadre.Controls.Add(this.tbp_finedifficili);
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
            this.btn_cancella.Location = new System.Drawing.Point(14, 80);
            this.btn_cancella.Name = "btn_cancella";
            this.btn_cancella.Size = new System.Drawing.Size(584, 83);
            this.btn_cancella.TabIndex = 2;
            this.btn_cancella.Text = "cancella";
            this.btn_cancella.UseVisualStyleBackColor = true;
            this.btn_cancella.Click += new System.EventHandler(this.btn_cancella_Click);
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
            this.btn_inserisci.Click += new System.EventHandler(this.btn_inserisci_Click);
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
            this.groupBox1.Text = "Principiante";
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
            this.groupBox2.Location = new System.Drawing.Point(3, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 569);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Esperto";
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
            this.groupBox3.Text = "Campione";
            // 
            // tbp_1facile
            // 
            this.tbp_1facile.Controls.Add(this.label12);
            this.tbp_1facile.Controls.Add(this.lbl_punteggio1facile);
            this.tbp_1facile.Controls.Add(this.groupBox4);
            this.tbp_1facile.Controls.Add(this.pictureBox97);
            this.tbp_1facile.Controls.Add(this.pictureBox47);
            this.tbp_1facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_1facile.Name = "tbp_1facile";
            this.tbp_1facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_1facile.TabIndex = 4;
            this.tbp_1facile.Text = "livello 1 facile";
            this.tbp_1facile.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Punteggio:";
            // 
            // lbl_punteggio1facile
            // 
            this.lbl_punteggio1facile.AutoSize = true;
            this.lbl_punteggio1facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio1facile.Name = "lbl_punteggio1facile";
            this.lbl_punteggio1facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio1facile.TabIndex = 18;
            this.lbl_punteggio1facile.Text = "100";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_indiziofacile1_3);
            this.groupBox4.Controls.Add(this.lbl_indiziofacile1_1);
            this.groupBox4.Controls.Add(this.lbl_indiziofacile1_2);
            this.groupBox4.Controls.Add(this.lbl_indizifacile1);
            this.groupBox4.Controls.Add(this.btn_opzione4facile1);
            this.groupBox4.Controls.Add(this.btn_opzione3facile1);
            this.groupBox4.Controls.Add(this.btn_opzione2facile1);
            this.groupBox4.Controls.Add(this.btn_opzione1facile1);
            this.groupBox4.Controls.Add(this.pictureBox37);
            this.groupBox4.Controls.Add(this.pb_indiziofacile1_2);
            this.groupBox4.Controls.Add(this.pb_inzidiofacile1);
            this.groupBox4.Controls.Add(this.pb_indiziofacile1_3);
            this.groupBox4.Controls.Add(this.pb_frecciavanti1facile);
            this.groupBox4.Location = new System.Drawing.Point(6, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(660, 569);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Principiante";
            // 
            // lbl_indiziofacile1_3
            // 
            this.lbl_indiziofacile1_3.AutoSize = true;
            this.lbl_indiziofacile1_3.Location = new System.Drawing.Point(170, 550);
            this.lbl_indiziofacile1_3.Name = "lbl_indiziofacile1_3";
            this.lbl_indiziofacile1_3.Size = new System.Drawing.Size(320, 13);
            this.lbl_indiziofacile1_3.TabIndex = 12;
            this.lbl_indiziofacile1_3.Text = "Questa squadra è quella con più titoli di UEFA Champions League.";
            this.lbl_indiziofacile1_3.Visible = false;
            // 
            // lbl_indiziofacile1_1
            // 
            this.lbl_indiziofacile1_1.AutoSize = true;
            this.lbl_indiziofacile1_1.Location = new System.Drawing.Point(193, 501);
            this.lbl_indiziofacile1_1.Name = "lbl_indiziofacile1_1";
            this.lbl_indiziofacile1_1.Size = new System.Drawing.Size(266, 13);
            this.lbl_indiziofacile1_1.TabIndex = 11;
            this.lbl_indiziofacile1_1.Text = "Questa squadra milita nella Liga, campionato spagnolo.";
            this.lbl_indiziofacile1_1.Visible = false;
            // 
            // lbl_indiziofacile1_2
            // 
            this.lbl_indiziofacile1_2.AutoSize = true;
            this.lbl_indiziofacile1_2.Location = new System.Drawing.Point(208, 521);
            this.lbl_indiziofacile1_2.Name = "lbl_indiziofacile1_2";
            this.lbl_indiziofacile1_2.Size = new System.Drawing.Size(232, 13);
            this.lbl_indiziofacile1_2.TabIndex = 10;
            this.lbl_indiziofacile1_2.Text = "L’allenatore di questa squadra è Carlo Ancelotti.";
            this.lbl_indiziofacile1_2.Visible = false;
            // 
            // lbl_indizifacile1
            // 
            this.lbl_indizifacile1.AutoSize = true;
            this.lbl_indizifacile1.Location = new System.Drawing.Point(315, 542);
            this.lbl_indizifacile1.Name = "lbl_indizifacile1";
            this.lbl_indizifacile1.Size = new System.Drawing.Size(0, 13);
            this.lbl_indizifacile1.TabIndex = 9;
            // 
            // btn_opzione4facile1
            // 
            this.btn_opzione4facile1.Location = new System.Drawing.Point(359, 415);
            this.btn_opzione4facile1.Name = "btn_opzione4facile1";
            this.btn_opzione4facile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile1.TabIndex = 8;
            this.btn_opzione4facile1.Text = "Barcellona";
            this.btn_opzione4facile1.UseVisualStyleBackColor = true;
            this.btn_opzione4facile1.Click += new System.EventHandler(this.btn_opzione4facile1_Click);
            // 
            // btn_opzione3facile1
            // 
            this.btn_opzione3facile1.Location = new System.Drawing.Point(109, 415);
            this.btn_opzione3facile1.Name = "btn_opzione3facile1";
            this.btn_opzione3facile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile1.TabIndex = 7;
            this.btn_opzione3facile1.Text = "Bayern Monaco";
            this.btn_opzione3facile1.UseVisualStyleBackColor = true;
            this.btn_opzione3facile1.Click += new System.EventHandler(this.btn_opzione3facile1_Click);
            // 
            // btn_opzione2facile1
            // 
            this.btn_opzione2facile1.Location = new System.Drawing.Point(360, 344);
            this.btn_opzione2facile1.Name = "btn_opzione2facile1";
            this.btn_opzione2facile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile1.TabIndex = 6;
            this.btn_opzione2facile1.Text = "Real Madrid";
            this.btn_opzione2facile1.UseVisualStyleBackColor = true;
            this.btn_opzione2facile1.Click += new System.EventHandler(this.btn_opzione2facile1_Click);
            // 
            // btn_opzione1facile1
            // 
            this.btn_opzione1facile1.Location = new System.Drawing.Point(109, 344);
            this.btn_opzione1facile1.Name = "btn_opzione1facile1";
            this.btn_opzione1facile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile1.TabIndex = 5;
            this.btn_opzione1facile1.Text = "Manchester City";
            this.btn_opzione1facile1.UseVisualStyleBackColor = true;
            this.btn_opzione1facile1.Click += new System.EventHandler(this.btn_opzione1facile1_Click);
            // 
            // tbp_2facile
            // 
            this.tbp_2facile.Controls.Add(this.label13);
            this.tbp_2facile.Controls.Add(this.lbl_punteggio2facile);
            this.tbp_2facile.Controls.Add(this.groupBox5);
            this.tbp_2facile.Controls.Add(this.pictureBox98);
            this.tbp_2facile.Controls.Add(this.pictureBox48);
            this.tbp_2facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_2facile.Name = "tbp_2facile";
            this.tbp_2facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_2facile.TabIndex = 5;
            this.tbp_2facile.Text = "livello 2 facile";
            this.tbp_2facile.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(551, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Punteggio:";
            // 
            // lbl_punteggio2facile
            // 
            this.lbl_punteggio2facile.AutoSize = true;
            this.lbl_punteggio2facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio2facile.Name = "lbl_punteggio2facile";
            this.lbl_punteggio2facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio2facile.TabIndex = 19;
            this.lbl_punteggio2facile.Text = "100";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_indizifacile2_1);
            this.groupBox5.Controls.Add(this.lbl_indizifacile2_2);
            this.groupBox5.Controls.Add(this.lbl_indizifacile2_3);
            this.groupBox5.Controls.Add(this.btn_opzione4facile2);
            this.groupBox5.Controls.Add(this.btn_opzione3facile2);
            this.groupBox5.Controls.Add(this.btn_opzione2facile2);
            this.groupBox5.Controls.Add(this.btn_opzione1facile2);
            this.groupBox5.Controls.Add(this.pictureBox42);
            this.groupBox5.Controls.Add(this.pb_frecciaind2);
            this.groupBox5.Controls.Add(this.pb_indiziofacile2_2);
            this.groupBox5.Controls.Add(this.pb_indiziofacile2_1);
            this.groupBox5.Controls.Add(this.pb_indiziofacile2_3);
            this.groupBox5.Controls.Add(this.pb_frecciavanti2facile);
            this.groupBox5.Location = new System.Drawing.Point(6, 107);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(660, 569);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Principiante";
            // 
            // lbl_indizifacile2_1
            // 
            this.lbl_indizifacile2_1.AutoSize = true;
            this.lbl_indizifacile2_1.Location = new System.Drawing.Point(181, 501);
            this.lbl_indizifacile2_1.Name = "lbl_indizifacile2_1";
            this.lbl_indizifacile2_1.Size = new System.Drawing.Size(310, 13);
            this.lbl_indizifacile2_1.TabIndex = 17;
            this.lbl_indizifacile2_1.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.lbl_indizifacile2_1.Visible = false;
            // 
            // lbl_indizifacile2_2
            // 
            this.lbl_indizifacile2_2.AutoSize = true;
            this.lbl_indizifacile2_2.Location = new System.Drawing.Point(216, 521);
            this.lbl_indizifacile2_2.Name = "lbl_indizifacile2_2";
            this.lbl_indizifacile2_2.Size = new System.Drawing.Size(231, 13);
            this.lbl_indizifacile2_2.TabIndex = 16;
            this.lbl_indizifacile2_2.Text = "L’allenatore di questa squadra è Pep Guardiola.";
            this.lbl_indizifacile2_2.Visible = false;
            // 
            // lbl_indizifacile2_3
            // 
            this.lbl_indizifacile2_3.AutoSize = true;
            this.lbl_indizifacile2_3.Location = new System.Drawing.Point(190, 550);
            this.lbl_indizifacile2_3.Name = "lbl_indizifacile2_3";
            this.lbl_indizifacile2_3.Size = new System.Drawing.Size(281, 13);
            this.lbl_indizifacile2_3.TabIndex = 15;
            this.lbl_indizifacile2_3.Text = "Questa squadra è l’ultima detentrice della Premier League.";
            this.lbl_indizifacile2_3.Visible = false;
            // 
            // btn_opzione4facile2
            // 
            this.btn_opzione4facile2.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile2.Name = "btn_opzione4facile2";
            this.btn_opzione4facile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile2.TabIndex = 14;
            this.btn_opzione4facile2.Text = "Bayern Monaco";
            this.btn_opzione4facile2.UseVisualStyleBackColor = true;
            this.btn_opzione4facile2.Click += new System.EventHandler(this.btn_opzione4facile2_Click);
            // 
            // btn_opzione3facile2
            // 
            this.btn_opzione3facile2.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile2.Name = "btn_opzione3facile2";
            this.btn_opzione3facile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile2.TabIndex = 13;
            this.btn_opzione3facile2.Text = "Manchester City";
            this.btn_opzione3facile2.UseVisualStyleBackColor = true;
            this.btn_opzione3facile2.Click += new System.EventHandler(this.btn_opzione3facile2_Click);
            // 
            // btn_opzione2facile2
            // 
            this.btn_opzione2facile2.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile2.Name = "btn_opzione2facile2";
            this.btn_opzione2facile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile2.TabIndex = 12;
            this.btn_opzione2facile2.Text = "Paris Saint Germain";
            this.btn_opzione2facile2.UseVisualStyleBackColor = true;
            this.btn_opzione2facile2.Click += new System.EventHandler(this.btn_opzione2facile2_Click);
            // 
            // btn_opzione1facile2
            // 
            this.btn_opzione1facile2.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile2.Name = "btn_opzione1facile2";
            this.btn_opzione1facile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile2.TabIndex = 11;
            this.btn_opzione1facile2.Text = "Inter";
            this.btn_opzione1facile2.UseVisualStyleBackColor = true;
            this.btn_opzione1facile2.Click += new System.EventHandler(this.btn_opzione1facile2_Click);
            // 
            // tbp_3facile
            // 
            this.tbp_3facile.Controls.Add(this.label14);
            this.tbp_3facile.Controls.Add(this.lbl_punteggio3facile);
            this.tbp_3facile.Controls.Add(this.groupBox6);
            this.tbp_3facile.Controls.Add(this.pictureBox41);
            this.tbp_3facile.Controls.Add(this.pictureBox54);
            this.tbp_3facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_3facile.Name = "tbp_3facile";
            this.tbp_3facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_3facile.TabIndex = 6;
            this.tbp_3facile.Text = "livello 3 facile";
            this.tbp_3facile.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(551, 88);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Punteggio:";
            // 
            // lbl_punteggio3facile
            // 
            this.lbl_punteggio3facile.AutoSize = true;
            this.lbl_punteggio3facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio3facile.Name = "lbl_punteggio3facile";
            this.lbl_punteggio3facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio3facile.TabIndex = 20;
            this.lbl_punteggio3facile.Text = "100";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_indiziofacile3_1);
            this.groupBox6.Controls.Add(this.lbl_indiziofacile3_2);
            this.groupBox6.Controls.Add(this.lbl_indizifacile3_3);
            this.groupBox6.Controls.Add(this.btn_opzione4facile3);
            this.groupBox6.Controls.Add(this.btn_opzione3facile3);
            this.groupBox6.Controls.Add(this.btn_opzione2facile3);
            this.groupBox6.Controls.Add(this.btn_opzione1facile3);
            this.groupBox6.Controls.Add(this.pictureBox46);
            this.groupBox6.Controls.Add(this.pb_frecciaind3);
            this.groupBox6.Controls.Add(this.pb_indiziofacile3_2);
            this.groupBox6.Controls.Add(this.pb_indiziofacile3_1);
            this.groupBox6.Controls.Add(this.pb_indiziofacile3_3);
            this.groupBox6.Controls.Add(this.pb_frecciavanti3facile);
            this.groupBox6.Location = new System.Drawing.Point(6, 107);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(660, 569);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Principiante";
            // 
            // lbl_indiziofacile3_1
            // 
            this.lbl_indiziofacile3_1.AutoSize = true;
            this.lbl_indiziofacile3_1.Location = new System.Drawing.Point(187, 501);
            this.lbl_indiziofacile3_1.Name = "lbl_indiziofacile3_1";
            this.lbl_indiziofacile3_1.Size = new System.Drawing.Size(279, 13);
            this.lbl_indiziofacile3_1.TabIndex = 17;
            this.lbl_indiziofacile3_1.Text = "Questa squadra milita nella Ligue 1, campionato francese.";
            this.lbl_indiziofacile3_1.Visible = false;
            // 
            // lbl_indiziofacile3_2
            // 
            this.lbl_indiziofacile3_2.AutoSize = true;
            this.lbl_indiziofacile3_2.Location = new System.Drawing.Point(213, 521);
            this.lbl_indiziofacile3_2.Name = "lbl_indiziofacile3_2";
            this.lbl_indiziofacile3_2.Size = new System.Drawing.Size(222, 13);
            this.lbl_indiziofacile3_2.TabIndex = 16;
            this.lbl_indiziofacile3_2.Text = "L’allenatore di questa squadra è Luis Enrique.";
            this.lbl_indiziofacile3_2.Visible = false;
            // 
            // lbl_indizifacile3_3
            // 
            this.lbl_indizifacile3_3.AutoSize = true;
            this.lbl_indizifacile3_3.Location = new System.Drawing.Point(227, 550);
            this.lbl_indizifacile3_3.Name = "lbl_indizifacile3_3";
            this.lbl_indizifacile3_3.Size = new System.Drawing.Size(208, 13);
            this.lbl_indizifacile3_3.TabIndex = 15;
            this.lbl_indizifacile3_3.Text = "Questa squadra gioca al Parc des Princes.";
            this.lbl_indizifacile3_3.Visible = false;
            // 
            // btn_opzione4facile3
            // 
            this.btn_opzione4facile3.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile3.Name = "btn_opzione4facile3";
            this.btn_opzione4facile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile3.TabIndex = 14;
            this.btn_opzione4facile3.Text = "Borussia Dortmund";
            this.btn_opzione4facile3.UseVisualStyleBackColor = true;
            this.btn_opzione4facile3.Click += new System.EventHandler(this.btn_opzione4facile3_Click);
            // 
            // btn_opzione3facile3
            // 
            this.btn_opzione3facile3.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile3.Name = "btn_opzione3facile3";
            this.btn_opzione3facile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile3.TabIndex = 13;
            this.btn_opzione3facile3.Text = "Paris Saint Germain";
            this.btn_opzione3facile3.UseVisualStyleBackColor = true;
            this.btn_opzione3facile3.Click += new System.EventHandler(this.btn_opzione3facile3_Click);
            // 
            // btn_opzione2facile3
            // 
            this.btn_opzione2facile3.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile3.Name = "btn_opzione2facile3";
            this.btn_opzione2facile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile3.TabIndex = 12;
            this.btn_opzione2facile3.Text = "Juventus";
            this.btn_opzione2facile3.UseVisualStyleBackColor = true;
            this.btn_opzione2facile3.Click += new System.EventHandler(this.btn_opzione2facile3_Click);
            // 
            // btn_opzione1facile3
            // 
            this.btn_opzione1facile3.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile3.Name = "btn_opzione1facile3";
            this.btn_opzione1facile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile3.TabIndex = 11;
            this.btn_opzione1facile3.Text = "Barcellona";
            this.btn_opzione1facile3.UseVisualStyleBackColor = true;
            this.btn_opzione1facile3.Click += new System.EventHandler(this.btn_opzione1facile3_Click);
            // 
            // tbp_4facile
            // 
            this.tbp_4facile.Controls.Add(this.label15);
            this.tbp_4facile.Controls.Add(this.lbl_punteggio4facile);
            this.tbp_4facile.Controls.Add(this.groupBox7);
            this.tbp_4facile.Controls.Add(this.pictureBox99);
            this.tbp_4facile.Controls.Add(this.pictureBox60);
            this.tbp_4facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_4facile.Name = "tbp_4facile";
            this.tbp_4facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_4facile.TabIndex = 7;
            this.tbp_4facile.Text = "livello 4 facile";
            this.tbp_4facile.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(551, 88);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Punteggio:";
            // 
            // lbl_punteggio4facile
            // 
            this.lbl_punteggio4facile.AutoSize = true;
            this.lbl_punteggio4facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio4facile.Name = "lbl_punteggio4facile";
            this.lbl_punteggio4facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio4facile.TabIndex = 20;
            this.lbl_punteggio4facile.Text = "100";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbl_indiziofacile4_1);
            this.groupBox7.Controls.Add(this.lbl_indiziofacile4_2);
            this.groupBox7.Controls.Add(this.lbl_indiziofacile4_3);
            this.groupBox7.Controls.Add(this.btn_opzione4facile4);
            this.groupBox7.Controls.Add(this.btn_opzione3facile4);
            this.groupBox7.Controls.Add(this.btn_opzione2facile4);
            this.groupBox7.Controls.Add(this.btn_opzione1facile4);
            this.groupBox7.Controls.Add(this.pictureBox49);
            this.groupBox7.Controls.Add(this.pb_frecciaind4);
            this.groupBox7.Controls.Add(this.pb_indiziofacile4_2);
            this.groupBox7.Controls.Add(this.pb_indiziofacile4_1);
            this.groupBox7.Controls.Add(this.pb_indiziofacile4_3);
            this.groupBox7.Controls.Add(this.pb_frecciavanti4facile);
            this.groupBox7.Location = new System.Drawing.Point(6, 107);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(660, 569);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Principiante";
            // 
            // lbl_indiziofacile4_1
            // 
            this.lbl_indiziofacile4_1.AutoSize = true;
            this.lbl_indiziofacile4_1.Location = new System.Drawing.Point(179, 501);
            this.lbl_indiziofacile4_1.Name = "lbl_indiziofacile4_1";
            this.lbl_indiziofacile4_1.Size = new System.Drawing.Size(293, 13);
            this.lbl_indiziofacile4_1.TabIndex = 17;
            this.lbl_indiziofacile4_1.Text = "Questa squadra milita nella Bundesliga, campionato tedesco.";
            this.lbl_indiziofacile4_1.Visible = false;
            // 
            // lbl_indiziofacile4_2
            // 
            this.lbl_indiziofacile4_2.AutoSize = true;
            this.lbl_indiziofacile4_2.Location = new System.Drawing.Point(210, 521);
            this.lbl_indiziofacile4_2.Name = "lbl_indiziofacile4_2";
            this.lbl_indiziofacile4_2.Size = new System.Drawing.Size(238, 13);
            this.lbl_indiziofacile4_2.TabIndex = 16;
            this.lbl_indiziofacile4_2.Text = "L’allenatore di questa squadra è Thomas Tuchel.";
            this.lbl_indiziofacile4_2.Visible = false;
            // 
            // lbl_indiziofacile4_3
            // 
            this.lbl_indiziofacile4_3.AutoSize = true;
            this.lbl_indiziofacile4_3.Location = new System.Drawing.Point(200, 550);
            this.lbl_indiziofacile4_3.Name = "lbl_indiziofacile4_3";
            this.lbl_indiziofacile4_3.Size = new System.Drawing.Size(259, 13);
            this.lbl_indiziofacile4_3.TabIndex = 15;
            this.lbl_indiziofacile4_3.Text = "Questa squadra è l’ultima detentrice della Bundesliga.";
            this.lbl_indiziofacile4_3.Visible = false;
            // 
            // btn_opzione4facile4
            // 
            this.btn_opzione4facile4.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile4.Name = "btn_opzione4facile4";
            this.btn_opzione4facile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile4.TabIndex = 14;
            this.btn_opzione4facile4.Text = "Bayer Leverkusen";
            this.btn_opzione4facile4.UseVisualStyleBackColor = true;
            this.btn_opzione4facile4.Click += new System.EventHandler(this.btn_opzione4facile4_Click);
            // 
            // btn_opzione3facile4
            // 
            this.btn_opzione3facile4.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile4.Name = "btn_opzione3facile4";
            this.btn_opzione3facile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile4.TabIndex = 13;
            this.btn_opzione3facile4.Text = "Real Madrid ";
            this.btn_opzione3facile4.UseVisualStyleBackColor = true;
            this.btn_opzione3facile4.Click += new System.EventHandler(this.btn_opzione3facile4_Click);
            // 
            // btn_opzione2facile4
            // 
            this.btn_opzione2facile4.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile4.Name = "btn_opzione2facile4";
            this.btn_opzione2facile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile4.TabIndex = 12;
            this.btn_opzione2facile4.Text = "Milan ";
            this.btn_opzione2facile4.UseVisualStyleBackColor = true;
            this.btn_opzione2facile4.Click += new System.EventHandler(this.btn_opzione2facile4_Click);
            // 
            // btn_opzione1facile4
            // 
            this.btn_opzione1facile4.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile4.Name = "btn_opzione1facile4";
            this.btn_opzione1facile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile4.TabIndex = 11;
            this.btn_opzione1facile4.Text = "Bayern Monaco";
            this.btn_opzione1facile4.UseVisualStyleBackColor = true;
            this.btn_opzione1facile4.Click += new System.EventHandler(this.btn_opzione1facile4_Click);
            // 
            // tbp_5facile
            // 
            this.tbp_5facile.Controls.Add(this.label16);
            this.tbp_5facile.Controls.Add(this.lbl_punteggio5facile);
            this.tbp_5facile.Controls.Add(this.groupBox8);
            this.tbp_5facile.Controls.Add(this.pictureBox100);
            this.tbp_5facile.Controls.Add(this.pictureBox66);
            this.tbp_5facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_5facile.Name = "tbp_5facile";
            this.tbp_5facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_5facile.TabIndex = 8;
            this.tbp_5facile.Text = "livello 5 facile";
            this.tbp_5facile.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(551, 88);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Punteggio:";
            // 
            // lbl_punteggio5facile
            // 
            this.lbl_punteggio5facile.AutoSize = true;
            this.lbl_punteggio5facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio5facile.Name = "lbl_punteggio5facile";
            this.lbl_punteggio5facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio5facile.TabIndex = 20;
            this.lbl_punteggio5facile.Text = "100";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbl_indizifacile5_1);
            this.groupBox8.Controls.Add(this.lbl_indizifacile5_2);
            this.groupBox8.Controls.Add(this.lbl_indizifacile5_3);
            this.groupBox8.Controls.Add(this.btn_opzione4facile5);
            this.groupBox8.Controls.Add(this.btn_opzione3facile5);
            this.groupBox8.Controls.Add(this.btn_opzione2facile5);
            this.groupBox8.Controls.Add(this.btn_opzione1facile5);
            this.groupBox8.Controls.Add(this.pictureBox53);
            this.groupBox8.Controls.Add(this.pb_frecciaind5);
            this.groupBox8.Controls.Add(this.pb_indiziofacile5_2);
            this.groupBox8.Controls.Add(this.pb_indiziofacile5_1);
            this.groupBox8.Controls.Add(this.pb_indiziofacile5_3);
            this.groupBox8.Controls.Add(this.pb_frecciavanti5facile);
            this.groupBox8.Location = new System.Drawing.Point(6, 107);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(660, 569);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Principiante";
            // 
            // lbl_indizifacile5_1
            // 
            this.lbl_indizifacile5_1.AutoSize = true;
            this.lbl_indizifacile5_1.Location = new System.Drawing.Point(192, 501);
            this.lbl_indizifacile5_1.Name = "lbl_indizifacile5_1";
            this.lbl_indizifacile5_1.Size = new System.Drawing.Size(266, 13);
            this.lbl_indizifacile5_1.TabIndex = 17;
            this.lbl_indizifacile5_1.Text = "Questa squadra milita nella Liga, campionato spagnolo.";
            this.lbl_indizifacile5_1.Visible = false;
            // 
            // lbl_indizifacile5_2
            // 
            this.lbl_indizifacile5_2.AutoSize = true;
            this.lbl_indizifacile5_2.Location = new System.Drawing.Point(229, 521);
            this.lbl_indizifacile5_2.Name = "lbl_indizifacile5_2";
            this.lbl_indizifacile5_2.Size = new System.Drawing.Size(185, 13);
            this.lbl_indizifacile5_2.TabIndex = 16;
            this.lbl_indizifacile5_2.Text = "L’allenatore di questa squadra è Xavi.";
            this.lbl_indizifacile5_2.Visible = false;
            // 
            // lbl_indizifacile5_3
            // 
            this.lbl_indizifacile5_3.AutoSize = true;
            this.lbl_indizifacile5_3.Location = new System.Drawing.Point(236, 550);
            this.lbl_indizifacile5_3.Name = "lbl_indizifacile5_3";
            this.lbl_indizifacile5_3.Size = new System.Drawing.Size(178, 13);
            this.lbl_indizifacile5_3.TabIndex = 15;
            this.lbl_indizifacile5_3.Text = "Questa squadra gioca al Camp Nou.";
            this.lbl_indizifacile5_3.Visible = false;
            // 
            // btn_opzione4facile5
            // 
            this.btn_opzione4facile5.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile5.Name = "btn_opzione4facile5";
            this.btn_opzione4facile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile5.TabIndex = 14;
            this.btn_opzione4facile5.Text = "Liverpool";
            this.btn_opzione4facile5.UseVisualStyleBackColor = true;
            this.btn_opzione4facile5.Click += new System.EventHandler(this.btn_opzione4facile5_Click);
            // 
            // btn_opzione3facile5
            // 
            this.btn_opzione3facile5.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile5.Name = "btn_opzione3facile5";
            this.btn_opzione3facile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile5.TabIndex = 13;
            this.btn_opzione3facile5.Text = "Juventus";
            this.btn_opzione3facile5.UseVisualStyleBackColor = true;
            this.btn_opzione3facile5.Click += new System.EventHandler(this.btn_opzione3facile5_Click);
            // 
            // btn_opzione2facile5
            // 
            this.btn_opzione2facile5.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile5.Name = "btn_opzione2facile5";
            this.btn_opzione2facile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile5.TabIndex = 12;
            this.btn_opzione2facile5.Text = "Atletico Madrid";
            this.btn_opzione2facile5.UseVisualStyleBackColor = true;
            this.btn_opzione2facile5.Click += new System.EventHandler(this.btn_opzione2facile5_Click);
            // 
            // btn_opzione1facile5
            // 
            this.btn_opzione1facile5.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile5.Name = "btn_opzione1facile5";
            this.btn_opzione1facile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile5.TabIndex = 11;
            this.btn_opzione1facile5.Text = "Barcellona";
            this.btn_opzione1facile5.UseVisualStyleBackColor = true;
            this.btn_opzione1facile5.Click += new System.EventHandler(this.btn_opzione1facile5_Click);
            // 
            // tbp_6facile
            // 
            this.tbp_6facile.Controls.Add(this.label17);
            this.tbp_6facile.Controls.Add(this.lbl_punteggio6facile);
            this.tbp_6facile.Controls.Add(this.groupBox9);
            this.tbp_6facile.Controls.Add(this.pictureBox101);
            this.tbp_6facile.Controls.Add(this.pictureBox72);
            this.tbp_6facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_6facile.Name = "tbp_6facile";
            this.tbp_6facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_6facile.TabIndex = 9;
            this.tbp_6facile.Text = "livello 6 facile";
            this.tbp_6facile.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(551, 88);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Punteggio:";
            // 
            // lbl_punteggio6facile
            // 
            this.lbl_punteggio6facile.AutoSize = true;
            this.lbl_punteggio6facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio6facile.Name = "lbl_punteggio6facile";
            this.lbl_punteggio6facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio6facile.TabIndex = 20;
            this.lbl_punteggio6facile.Text = "100";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbl_indizifacile6_1);
            this.groupBox9.Controls.Add(this.lbl_indizifacile6_2);
            this.groupBox9.Controls.Add(this.lbl_indizifacile6_3);
            this.groupBox9.Controls.Add(this.btn_opzione4facile6);
            this.groupBox9.Controls.Add(this.btn_opzione3facile6);
            this.groupBox9.Controls.Add(this.btn_opzione2facile6);
            this.groupBox9.Controls.Add(this.btn_opzione1facile6);
            this.groupBox9.Controls.Add(this.pictureBox55);
            this.groupBox9.Controls.Add(this.pb_frecciaind6);
            this.groupBox9.Controls.Add(this.pb_indiziofacile6_2);
            this.groupBox9.Controls.Add(this.pb_indiziofacile6_1);
            this.groupBox9.Controls.Add(this.pb_indiziofacile6_3);
            this.groupBox9.Controls.Add(this.pb_frecciavanti6facile);
            this.groupBox9.Location = new System.Drawing.Point(6, 107);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(660, 569);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Principiante";
            // 
            // lbl_indizifacile6_1
            // 
            this.lbl_indizifacile6_1.AutoSize = true;
            this.lbl_indizifacile6_1.Location = new System.Drawing.Point(181, 501);
            this.lbl_indizifacile6_1.Name = "lbl_indizifacile6_1";
            this.lbl_indizifacile6_1.Size = new System.Drawing.Size(310, 13);
            this.lbl_indizifacile6_1.TabIndex = 17;
            this.lbl_indizifacile6_1.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.lbl_indizifacile6_1.Visible = false;
            // 
            // lbl_indizifacile6_2
            // 
            this.lbl_indizifacile6_2.AutoSize = true;
            this.lbl_indizifacile6_2.Location = new System.Drawing.Point(220, 521);
            this.lbl_indizifacile6_2.Name = "lbl_indizifacile6_2";
            this.lbl_indizifacile6_2.Size = new System.Drawing.Size(226, 13);
            this.lbl_indizifacile6_2.TabIndex = 16;
            this.lbl_indizifacile6_2.Text = "L’allenatore di questa squadra è Jurgen Klopp.";
            this.lbl_indizifacile6_2.Visible = false;
            // 
            // lbl_indizifacile6_3
            // 
            this.lbl_indizifacile6_3.AutoSize = true;
            this.lbl_indizifacile6_3.Location = new System.Drawing.Point(247, 550);
            this.lbl_indizifacile6_3.Name = "lbl_indizifacile6_3";
            this.lbl_indizifacile6_3.Size = new System.Drawing.Size(164, 13);
            this.lbl_indizifacile6_3.TabIndex = 15;
            this.lbl_indizifacile6_3.Text = "Questa squadra gioca ad Anfield.";
            this.lbl_indizifacile6_3.Visible = false;
            // 
            // btn_opzione4facile6
            // 
            this.btn_opzione4facile6.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile6.Name = "btn_opzione4facile6";
            this.btn_opzione4facile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile6.TabIndex = 14;
            this.btn_opzione4facile6.Text = "Borussia Dortmund";
            this.btn_opzione4facile6.UseVisualStyleBackColor = true;
            this.btn_opzione4facile6.Click += new System.EventHandler(this.btn_opzione4facile6_Click);
            // 
            // btn_opzione3facile6
            // 
            this.btn_opzione3facile6.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile6.Name = "btn_opzione3facile6";
            this.btn_opzione3facile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile6.TabIndex = 13;
            this.btn_opzione3facile6.Text = "Liverpool";
            this.btn_opzione3facile6.UseVisualStyleBackColor = true;
            this.btn_opzione3facile6.Click += new System.EventHandler(this.btn_opzione3facile6_Click);
            // 
            // btn_opzione2facile6
            // 
            this.btn_opzione2facile6.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile6.Name = "btn_opzione2facile6";
            this.btn_opzione2facile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile6.TabIndex = 12;
            this.btn_opzione2facile6.Text = "Thottenham";
            this.btn_opzione2facile6.UseVisualStyleBackColor = true;
            this.btn_opzione2facile6.Click += new System.EventHandler(this.btn_opzione2facile6_Click);
            // 
            // btn_opzione1facile6
            // 
            this.btn_opzione1facile6.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile6.Name = "btn_opzione1facile6";
            this.btn_opzione1facile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile6.TabIndex = 11;
            this.btn_opzione1facile6.Text = "Milan";
            this.btn_opzione1facile6.UseVisualStyleBackColor = true;
            this.btn_opzione1facile6.Click += new System.EventHandler(this.btn_opzione1facile6_Click);
            // 
            // tbp_7facile
            // 
            this.tbp_7facile.Controls.Add(this.label18);
            this.tbp_7facile.Controls.Add(this.lbl_punteggio7facile);
            this.tbp_7facile.Controls.Add(this.groupBox10);
            this.tbp_7facile.Controls.Add(this.pictureBox102);
            this.tbp_7facile.Controls.Add(this.pictureBox78);
            this.tbp_7facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_7facile.Name = "tbp_7facile";
            this.tbp_7facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_7facile.TabIndex = 10;
            this.tbp_7facile.Text = "livello 7 facile";
            this.tbp_7facile.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(551, 88);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Punteggio:";
            // 
            // lbl_punteggio7facile
            // 
            this.lbl_punteggio7facile.AutoSize = true;
            this.lbl_punteggio7facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio7facile.Name = "lbl_punteggio7facile";
            this.lbl_punteggio7facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio7facile.TabIndex = 20;
            this.lbl_punteggio7facile.Text = "100";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lbl_indizifacile7_1);
            this.groupBox10.Controls.Add(this.lbl_indizifacile7_2);
            this.groupBox10.Controls.Add(this.lbl_indizifacile7_3);
            this.groupBox10.Controls.Add(this.btn_opzione4facile7);
            this.groupBox10.Controls.Add(this.btn_opzione3facile7);
            this.groupBox10.Controls.Add(this.btn_opzione2facile7);
            this.groupBox10.Controls.Add(this.btn_opzione1facile7);
            this.groupBox10.Controls.Add(this.pictureBox59);
            this.groupBox10.Controls.Add(this.pb_frecciaind7);
            this.groupBox10.Controls.Add(this.pb_indiziofacile7_2);
            this.groupBox10.Controls.Add(this.pb_indizifacile7_1);
            this.groupBox10.Controls.Add(this.pb_indiziofacile7_3);
            this.groupBox10.Controls.Add(this.pb_frecciavanti7facile);
            this.groupBox10.Location = new System.Drawing.Point(6, 107);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(660, 569);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Principiante";
            // 
            // lbl_indizifacile7_1
            // 
            this.lbl_indizifacile7_1.AutoSize = true;
            this.lbl_indizifacile7_1.Location = new System.Drawing.Point(201, 501);
            this.lbl_indizifacile7_1.Name = "lbl_indizifacile7_1";
            this.lbl_indizifacile7_1.Size = new System.Drawing.Size(270, 13);
            this.lbl_indizifacile7_1.TabIndex = 17;
            this.lbl_indizifacile7_1.Text = "Questa squadra milita nella Serie A, campionato italiano.";
            this.lbl_indizifacile7_1.Visible = false;
            // 
            // lbl_indizifacile7_2
            // 
            this.lbl_indizifacile7_2.AutoSize = true;
            this.lbl_indizifacile7_2.Location = new System.Drawing.Point(210, 521);
            this.lbl_indizifacile7_2.Name = "lbl_indizifacile7_2";
            this.lbl_indizifacile7_2.Size = new System.Drawing.Size(254, 13);
            this.lbl_indizifacile7_2.TabIndex = 16;
            this.lbl_indizifacile7_2.Text = "L’allenatore di questa squadra è Massimiliano Allegri.";
            this.lbl_indizifacile7_2.Visible = false;
            // 
            // lbl_indizifacile7_3
            // 
            this.lbl_indizifacile7_3.AutoSize = true;
            this.lbl_indizifacile7_3.Location = new System.Drawing.Point(201, 550);
            this.lbl_indizifacile7_3.Name = "lbl_indizifacile7_3";
            this.lbl_indizifacile7_3.Size = new System.Drawing.Size(272, 13);
            this.lbl_indizifacile7_3.TabIndex = 15;
            this.lbl_indizifacile7_3.Text = "Questa squadra è conosciuta anche così: “i bianconeri”.";
            this.lbl_indizifacile7_3.Visible = false;
            // 
            // btn_opzione4facile7
            // 
            this.btn_opzione4facile7.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile7.Name = "btn_opzione4facile7";
            this.btn_opzione4facile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile7.TabIndex = 14;
            this.btn_opzione4facile7.Text = "Atletico Madrid";
            this.btn_opzione4facile7.UseVisualStyleBackColor = true;
            this.btn_opzione4facile7.Click += new System.EventHandler(this.btn_opzione4facile7_Click);
            // 
            // btn_opzione3facile7
            // 
            this.btn_opzione3facile7.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile7.Name = "btn_opzione3facile7";
            this.btn_opzione3facile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile7.TabIndex = 13;
            this.btn_opzione3facile7.Text = "Juventus";
            this.btn_opzione3facile7.UseVisualStyleBackColor = true;
            this.btn_opzione3facile7.Click += new System.EventHandler(this.btn_opzione3facile7_Click);
            // 
            // btn_opzione2facile7
            // 
            this.btn_opzione2facile7.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile7.Name = "btn_opzione2facile7";
            this.btn_opzione2facile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile7.TabIndex = 12;
            this.btn_opzione2facile7.Text = "Inter";
            this.btn_opzione2facile7.UseVisualStyleBackColor = true;
            this.btn_opzione2facile7.Click += new System.EventHandler(this.btn_opzione2facile7_Click);
            // 
            // btn_opzione1facile7
            // 
            this.btn_opzione1facile7.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile7.Name = "btn_opzione1facile7";
            this.btn_opzione1facile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile7.TabIndex = 11;
            this.btn_opzione1facile7.Text = "Arsenal";
            this.btn_opzione1facile7.UseVisualStyleBackColor = true;
            this.btn_opzione1facile7.Click += new System.EventHandler(this.btn_opzione1facile7_Click);
            // 
            // tbp_8facile
            // 
            this.tbp_8facile.Controls.Add(this.label19);
            this.tbp_8facile.Controls.Add(this.lbl_punteggio8facile);
            this.tbp_8facile.Controls.Add(this.groupBox11);
            this.tbp_8facile.Controls.Add(this.pictureBox103);
            this.tbp_8facile.Controls.Add(this.pictureBox84);
            this.tbp_8facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_8facile.Name = "tbp_8facile";
            this.tbp_8facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_8facile.TabIndex = 11;
            this.tbp_8facile.Text = "livello 8 facile";
            this.tbp_8facile.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(551, 88);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Punteggio:";
            // 
            // lbl_punteggio8facile
            // 
            this.lbl_punteggio8facile.AutoSize = true;
            this.lbl_punteggio8facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio8facile.Name = "lbl_punteggio8facile";
            this.lbl_punteggio8facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio8facile.TabIndex = 20;
            this.lbl_punteggio8facile.Text = "100";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lbl_indizifacile8_1);
            this.groupBox11.Controls.Add(this.lbl_indizifacile8_2);
            this.groupBox11.Controls.Add(this.lbl_indizifacile8_3);
            this.groupBox11.Controls.Add(this.btn_opzione4facile8);
            this.groupBox11.Controls.Add(this.btn_opzione3facile8);
            this.groupBox11.Controls.Add(this.btn_opzione2facile8);
            this.groupBox11.Controls.Add(this.btn_opzione1facile8);
            this.groupBox11.Controls.Add(this.pictureBox61);
            this.groupBox11.Controls.Add(this.pb_frecciaind8);
            this.groupBox11.Controls.Add(this.pb_indiziofacile8_2);
            this.groupBox11.Controls.Add(this.pb_indiziofacile8_1);
            this.groupBox11.Controls.Add(this.pb_indiziofacile8_3);
            this.groupBox11.Controls.Add(this.pb_frecciavanti8facile);
            this.groupBox11.Location = new System.Drawing.Point(6, 107);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(660, 569);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Principiante";
            // 
            // lbl_indizifacile8_1
            // 
            this.lbl_indizifacile8_1.AutoSize = true;
            this.lbl_indizifacile8_1.Location = new System.Drawing.Point(198, 501);
            this.lbl_indizifacile8_1.Name = "lbl_indizifacile8_1";
            this.lbl_indizifacile8_1.Size = new System.Drawing.Size(270, 13);
            this.lbl_indizifacile8_1.TabIndex = 17;
            this.lbl_indizifacile8_1.Text = "Questa squadra milita nella Serie A, campionato italiano.";
            this.lbl_indizifacile8_1.Visible = false;
            // 
            // lbl_indizifacile8_2
            // 
            this.lbl_indizifacile8_2.AutoSize = true;
            this.lbl_indizifacile8_2.Location = new System.Drawing.Point(212, 521);
            this.lbl_indizifacile8_2.Name = "lbl_indizifacile8_2";
            this.lbl_indizifacile8_2.Size = new System.Drawing.Size(236, 13);
            this.lbl_indizifacile8_2.TabIndex = 16;
            this.lbl_indizifacile8_2.Text = "L’allenatore di questa squadra è Simone Inzaghi.";
            this.lbl_indizifacile8_2.Visible = false;
            // 
            // lbl_indizifacile8_3
            // 
            this.lbl_indizifacile8_3.AutoSize = true;
            this.lbl_indizifacile8_3.Location = new System.Drawing.Point(198, 550);
            this.lbl_indizifacile8_3.Name = "lbl_indizifacile8_3";
            this.lbl_indizifacile8_3.Size = new System.Drawing.Size(267, 13);
            this.lbl_indizifacile8_3.TabIndex = 15;
            this.lbl_indizifacile8_3.Text = "Questa squadra gioca al Giuseppe Meazza in San Siro.";
            this.lbl_indizifacile8_3.Visible = false;
            // 
            // btn_opzione4facile8
            // 
            this.btn_opzione4facile8.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile8.Name = "btn_opzione4facile8";
            this.btn_opzione4facile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile8.TabIndex = 14;
            this.btn_opzione4facile8.Text = "Inter";
            this.btn_opzione4facile8.UseVisualStyleBackColor = true;
            this.btn_opzione4facile8.Click += new System.EventHandler(this.btn_opzione4facile8_Click);
            // 
            // btn_opzione3facile8
            // 
            this.btn_opzione3facile8.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile8.Name = "btn_opzione3facile8";
            this.btn_opzione3facile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile8.TabIndex = 13;
            this.btn_opzione3facile8.Text = "Arsenal";
            this.btn_opzione3facile8.UseVisualStyleBackColor = true;
            this.btn_opzione3facile8.Click += new System.EventHandler(this.btn_opzione3facile8_Click);
            // 
            // btn_opzione2facile8
            // 
            this.btn_opzione2facile8.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile8.Name = "btn_opzione2facile8";
            this.btn_opzione2facile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile8.TabIndex = 12;
            this.btn_opzione2facile8.Text = "Marsiglia";
            this.btn_opzione2facile8.UseVisualStyleBackColor = true;
            this.btn_opzione2facile8.Click += new System.EventHandler(this.btn_opzione2facile8_Click);
            // 
            // btn_opzione1facile8
            // 
            this.btn_opzione1facile8.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile8.Name = "btn_opzione1facile8";
            this.btn_opzione1facile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile8.TabIndex = 11;
            this.btn_opzione1facile8.Text = "Roma";
            this.btn_opzione1facile8.UseVisualStyleBackColor = true;
            this.btn_opzione1facile8.Click += new System.EventHandler(this.btn_opzione1facile8_Click);
            // 
            // tbp_9facile
            // 
            this.tbp_9facile.Controls.Add(this.label20);
            this.tbp_9facile.Controls.Add(this.lbl_punteggio9facile);
            this.tbp_9facile.Controls.Add(this.groupBox12);
            this.tbp_9facile.Controls.Add(this.pictureBox104);
            this.tbp_9facile.Controls.Add(this.pictureBox90);
            this.tbp_9facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_9facile.Name = "tbp_9facile";
            this.tbp_9facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_9facile.TabIndex = 12;
            this.tbp_9facile.Text = "livello 9 facile";
            this.tbp_9facile.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(551, 88);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Punteggio:";
            // 
            // lbl_punteggio9facile
            // 
            this.lbl_punteggio9facile.AutoSize = true;
            this.lbl_punteggio9facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio9facile.Name = "lbl_punteggio9facile";
            this.lbl_punteggio9facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio9facile.TabIndex = 20;
            this.lbl_punteggio9facile.Text = "100";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lbl_indizifacile9_1);
            this.groupBox12.Controls.Add(this.lbl_indizifacile9_2);
            this.groupBox12.Controls.Add(this.lbl_indizifacile9_3);
            this.groupBox12.Controls.Add(this.btn_opzione4facile9);
            this.groupBox12.Controls.Add(this.btn_opzione3facile9);
            this.groupBox12.Controls.Add(this.btn_opzione2facile9);
            this.groupBox12.Controls.Add(this.btn_opzione1facile9);
            this.groupBox12.Controls.Add(this.pictureBox65);
            this.groupBox12.Controls.Add(this.pb_frecciaind9);
            this.groupBox12.Controls.Add(this.pb_indiziofacile9_2);
            this.groupBox12.Controls.Add(this.pb_indiziofacile9_1);
            this.groupBox12.Controls.Add(this.pb_indiziofacile9_3);
            this.groupBox12.Controls.Add(this.pb_frecciavanti9facile);
            this.groupBox12.Location = new System.Drawing.Point(6, 107);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(660, 569);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Principiante";
            // 
            // lbl_indizifacile9_1
            // 
            this.lbl_indizifacile9_1.AutoSize = true;
            this.lbl_indizifacile9_1.Location = new System.Drawing.Point(205, 501);
            this.lbl_indizifacile9_1.Name = "lbl_indizifacile9_1";
            this.lbl_indizifacile9_1.Size = new System.Drawing.Size(270, 13);
            this.lbl_indizifacile9_1.TabIndex = 17;
            this.lbl_indizifacile9_1.Text = "Questa squadra milita nella Serie A, campionato italiano.";
            this.lbl_indizifacile9_1.Visible = false;
            // 
            // lbl_indizifacile9_2
            // 
            this.lbl_indizifacile9_2.AutoSize = true;
            this.lbl_indizifacile9_2.Location = new System.Drawing.Point(223, 521);
            this.lbl_indizifacile9_2.Name = "lbl_indizifacile9_2";
            this.lbl_indizifacile9_2.Size = new System.Drawing.Size(223, 13);
            this.lbl_indizifacile9_2.TabIndex = 16;
            this.lbl_indizifacile9_2.Text = "L’allenatore di questa squadra è Stefano Pioli.";
            this.lbl_indizifacile9_2.Visible = false;
            // 
            // lbl_indizifacile9_3
            // 
            this.lbl_indizifacile9_3.AutoSize = true;
            this.lbl_indizifacile9_3.Location = new System.Drawing.Point(205, 550);
            this.lbl_indizifacile9_3.Name = "lbl_indizifacile9_3";
            this.lbl_indizifacile9_3.Size = new System.Drawing.Size(265, 13);
            this.lbl_indizifacile9_3.TabIndex = 15;
            this.lbl_indizifacile9_3.Text = "Questa squadra è conosciuta anche così: “i rossoneri”.";
            this.lbl_indizifacile9_3.Visible = false;
            // 
            // btn_opzione4facile9
            // 
            this.btn_opzione4facile9.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile9.Name = "btn_opzione4facile9";
            this.btn_opzione4facile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile9.TabIndex = 14;
            this.btn_opzione4facile9.Text = "Lazio";
            this.btn_opzione4facile9.UseVisualStyleBackColor = true;
            this.btn_opzione4facile9.Click += new System.EventHandler(this.btn_opzione4facile9_Click);
            // 
            // btn_opzione3facile9
            // 
            this.btn_opzione3facile9.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile9.Name = "btn_opzione3facile9";
            this.btn_opzione3facile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile9.TabIndex = 13;
            this.btn_opzione3facile9.Text = "Atletico Madrid";
            this.btn_opzione3facile9.UseVisualStyleBackColor = true;
            this.btn_opzione3facile9.Click += new System.EventHandler(this.btn_opzione3facile9_Click);
            // 
            // btn_opzione2facile9
            // 
            this.btn_opzione2facile9.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile9.Name = "btn_opzione2facile9";
            this.btn_opzione2facile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile9.TabIndex = 12;
            this.btn_opzione2facile9.Text = "Chelsea";
            this.btn_opzione2facile9.UseVisualStyleBackColor = true;
            this.btn_opzione2facile9.Click += new System.EventHandler(this.btn_opzione2facile9_Click);
            // 
            // btn_opzione1facile9
            // 
            this.btn_opzione1facile9.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile9.Name = "btn_opzione1facile9";
            this.btn_opzione1facile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile9.TabIndex = 11;
            this.btn_opzione1facile9.Text = "Milan";
            this.btn_opzione1facile9.UseVisualStyleBackColor = true;
            this.btn_opzione1facile9.Click += new System.EventHandler(this.btn_opzione1facile9_Click);
            // 
            // tbp_10facile
            // 
            this.tbp_10facile.Controls.Add(this.label21);
            this.tbp_10facile.Controls.Add(this.lbl_punteggio10facile);
            this.tbp_10facile.Controls.Add(this.groupBox13);
            this.tbp_10facile.Controls.Add(this.pictureBox105);
            this.tbp_10facile.Controls.Add(this.pictureBox96);
            this.tbp_10facile.Location = new System.Drawing.Point(4, 22);
            this.tbp_10facile.Name = "tbp_10facile";
            this.tbp_10facile.Size = new System.Drawing.Size(672, 697);
            this.tbp_10facile.TabIndex = 13;
            this.tbp_10facile.Text = "livello 10 facile";
            this.tbp_10facile.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(551, 88);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Punteggio:";
            // 
            // lbl_punteggio10facile
            // 
            this.lbl_punteggio10facile.AutoSize = true;
            this.lbl_punteggio10facile.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio10facile.Name = "lbl_punteggio10facile";
            this.lbl_punteggio10facile.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio10facile.TabIndex = 20;
            this.lbl_punteggio10facile.Text = "100";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.lbl_indizifacile10_1);
            this.groupBox13.Controls.Add(this.lbl_indizifacile10_2);
            this.groupBox13.Controls.Add(this.lbl_indizifacile10_3);
            this.groupBox13.Controls.Add(this.btn_opzione4facile10);
            this.groupBox13.Controls.Add(this.btn_opzione3facile10);
            this.groupBox13.Controls.Add(this.btn_opzione2facile10);
            this.groupBox13.Controls.Add(this.btn_opzione1facile10);
            this.groupBox13.Controls.Add(this.pictureBox67);
            this.groupBox13.Controls.Add(this.pb_frecciaind10);
            this.groupBox13.Controls.Add(this.pb_livellofacile10_2);
            this.groupBox13.Controls.Add(this.pb_indiziofacile10_1);
            this.groupBox13.Controls.Add(this.pb_livellofacile10_3);
            this.groupBox13.Location = new System.Drawing.Point(6, 107);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(660, 569);
            this.groupBox13.TabIndex = 18;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Principiante";
            // 
            // lbl_indizifacile10_1
            // 
            this.lbl_indizifacile10_1.AutoSize = true;
            this.lbl_indizifacile10_1.Location = new System.Drawing.Point(188, 501);
            this.lbl_indizifacile10_1.Name = "lbl_indizifacile10_1";
            this.lbl_indizifacile10_1.Size = new System.Drawing.Size(293, 13);
            this.lbl_indizifacile10_1.TabIndex = 17;
            this.lbl_indizifacile10_1.Text = "Questa squadra milita nella Bundesliga, campionato tedesco.";
            this.lbl_indizifacile10_1.Visible = false;
            // 
            // lbl_indizifacile10_2
            // 
            this.lbl_indizifacile10_2.AutoSize = true;
            this.lbl_indizifacile10_2.Location = new System.Drawing.Point(218, 521);
            this.lbl_indizifacile10_2.Name = "lbl_indizifacile10_2";
            this.lbl_indizifacile10_2.Size = new System.Drawing.Size(220, 13);
            this.lbl_indizifacile10_2.TabIndex = 16;
            this.lbl_indizifacile10_2.Text = "L’allenatore di questa squadra è Edin Terzic’.";
            this.lbl_indizifacile10_2.Visible = false;
            // 
            // lbl_indizifacile10_3
            // 
            this.lbl_indizifacile10_3.AutoSize = true;
            this.lbl_indizifacile10_3.Location = new System.Drawing.Point(168, 553);
            this.lbl_indizifacile10_3.Name = "lbl_indizifacile10_3";
            this.lbl_indizifacile10_3.Size = new System.Drawing.Size(331, 13);
            this.lbl_indizifacile10_3.TabIndex = 15;
            this.lbl_indizifacile10_3.Text = "Questa squadra è famosa per la curva dei propri tifosi, “il muro giallo”.";
            this.lbl_indizifacile10_3.Visible = false;
            // 
            // btn_opzione4facile10
            // 
            this.btn_opzione4facile10.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4facile10.Name = "btn_opzione4facile10";
            this.btn_opzione4facile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4facile10.TabIndex = 14;
            this.btn_opzione4facile10.Text = "Bayer Leverkusen";
            this.btn_opzione4facile10.UseVisualStyleBackColor = true;
            this.btn_opzione4facile10.Click += new System.EventHandler(this.btn_opzione4facile10_Click);
            // 
            // btn_opzione3facile10
            // 
            this.btn_opzione3facile10.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3facile10.Name = "btn_opzione3facile10";
            this.btn_opzione3facile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3facile10.TabIndex = 13;
            this.btn_opzione3facile10.Text = "Arsenal";
            this.btn_opzione3facile10.UseVisualStyleBackColor = true;
            this.btn_opzione3facile10.Click += new System.EventHandler(this.btn_opzione3facile10_Click);
            // 
            // btn_opzione2facile10
            // 
            this.btn_opzione2facile10.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2facile10.Name = "btn_opzione2facile10";
            this.btn_opzione2facile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2facile10.TabIndex = 12;
            this.btn_opzione2facile10.Text = "Borussia Dortmund";
            this.btn_opzione2facile10.UseVisualStyleBackColor = true;
            this.btn_opzione2facile10.Click += new System.EventHandler(this.btn_opzione2facile10_Click);
            // 
            // btn_opzione1facile10
            // 
            this.btn_opzione1facile10.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1facile10.Name = "btn_opzione1facile10";
            this.btn_opzione1facile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1facile10.TabIndex = 11;
            this.btn_opzione1facile10.Text = "Bayern Monaco";
            this.btn_opzione1facile10.UseVisualStyleBackColor = true;
            this.btn_opzione1facile10.Click += new System.EventHandler(this.btn_opzione1facile10_Click);
            // 
            // tbp_finefacile
            // 
            this.tbp_finefacile.Controls.Add(this.pictureBox43);
            this.tbp_finefacile.Controls.Add(this.pictureBox40);
            this.tbp_finefacile.Controls.Add(this.pictureBox44);
            this.tbp_finefacile.Controls.Add(this.pictureBox39);
            this.tbp_finefacile.Controls.Add(this.pictureBox38);
            this.tbp_finefacile.Controls.Add(this.label11);
            this.tbp_finefacile.Controls.Add(this.label10);
            this.tbp_finefacile.Controls.Add(this.label9);
            this.tbp_finefacile.Controls.Add(this.label8);
            this.tbp_finefacile.Controls.Add(this.lbl_punteggiofinale);
            this.tbp_finefacile.Controls.Add(this.label6);
            this.tbp_finefacile.Location = new System.Drawing.Point(4, 22);
            this.tbp_finefacile.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_finefacile.Name = "tbp_finefacile";
            this.tbp_finefacile.Size = new System.Drawing.Size(672, 697);
            this.tbp_finefacile.TabIndex = 14;
            this.tbp_finefacile.Text = "Fine livelli facile";
            this.tbp_finefacile.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(534, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "CAMBIA GIOCATORE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "TORNA ALLA HOME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 604);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "PASSA AL LIVELLO CAMPIONE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 604);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "PASSA AL LIVELLO ESPERTO";
            // 
            // lbl_punteggiofinale
            // 
            this.lbl_punteggiofinale.AutoSize = true;
            this.lbl_punteggiofinale.Location = new System.Drawing.Point(307, 184);
            this.lbl_punteggiofinale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_punteggiofinale.Name = "lbl_punteggiofinale";
            this.lbl_punteggiofinale.Size = new System.Drawing.Size(74, 13);
            this.lbl_punteggiofinale.TabIndex = 1;
            this.lbl_punteggiofinale.Text = "PUNTEGGIO ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "COMPLIMENTI HAI FINITO IL LIVELLO PRINCIPIANTE, IL TUO PUNTEGGIO FINALE È DI:";
            // 
            // tbp_1medio
            // 
            this.tbp_1medio.Controls.Add(this.label22);
            this.tbp_1medio.Controls.Add(this.lbl_punteggio1medio);
            this.tbp_1medio.Controls.Add(this.groupBox14);
            this.tbp_1medio.Controls.Add(this.pb_homelivello1medio);
            this.tbp_1medio.Controls.Add(this.pictureBox58);
            this.tbp_1medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_1medio.Name = "tbp_1medio";
            this.tbp_1medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_1medio.TabIndex = 15;
            this.tbp_1medio.Text = "livello 1 medio";
            this.tbp_1medio.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(551, 88);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Punteggio:";
            // 
            // lbl_punteggio1medio
            // 
            this.lbl_punteggio1medio.AutoSize = true;
            this.lbl_punteggio1medio.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio1medio.Name = "lbl_punteggio1medio";
            this.lbl_punteggio1medio.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio1medio.TabIndex = 23;
            this.lbl_punteggio1medio.Text = "100";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.lbl_indiziomedio1_3);
            this.groupBox14.Controls.Add(this.lbl_indiziomedio1_1);
            this.groupBox14.Controls.Add(this.lbl_indiziomedio1_2);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.btn_opzione4medio1);
            this.groupBox14.Controls.Add(this.btn_opzione3medio1);
            this.groupBox14.Controls.Add(this.btn_opzione2medio1);
            this.groupBox14.Controls.Add(this.btn_opzione1medio1);
            this.groupBox14.Controls.Add(this.pictureBox45);
            this.groupBox14.Controls.Add(this.pb_indiziomedio1_2);
            this.groupBox14.Controls.Add(this.pb_indiziomedio1_1);
            this.groupBox14.Controls.Add(this.pb_indiziomedio1_3);
            this.groupBox14.Controls.Add(this.pb_frecciavantimedio1);
            this.groupBox14.Location = new System.Drawing.Point(6, 107);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(660, 569);
            this.groupBox14.TabIndex = 21;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Esperto";
            // 
            // lbl_indiziomedio1_3
            // 
            this.lbl_indiziomedio1_3.AutoSize = true;
            this.lbl_indiziomedio1_3.Location = new System.Drawing.Point(183, 550);
            this.lbl_indiziomedio1_3.Name = "lbl_indiziomedio1_3";
            this.lbl_indiziomedio1_3.Size = new System.Drawing.Size(285, 13);
            this.lbl_indiziomedio1_3.TabIndex = 12;
            this.lbl_indiziomedio1_3.Text = "Questa squadra è conosciuta anche come “i colchoneros”.";
            this.lbl_indiziomedio1_3.Visible = false;
            // 
            // lbl_indiziomedio1_1
            // 
            this.lbl_indiziomedio1_1.AutoSize = true;
            this.lbl_indiziomedio1_1.Location = new System.Drawing.Point(193, 501);
            this.lbl_indiziomedio1_1.Name = "lbl_indiziomedio1_1";
            this.lbl_indiziomedio1_1.Size = new System.Drawing.Size(266, 13);
            this.lbl_indiziomedio1_1.TabIndex = 11;
            this.lbl_indiziomedio1_1.Text = "Questa squadra milita nella Liga, campionato spagnolo.";
            this.lbl_indiziomedio1_1.Visible = false;
            // 
            // lbl_indiziomedio1_2
            // 
            this.lbl_indiziomedio1_2.AutoSize = true;
            this.lbl_indiziomedio1_2.Location = new System.Drawing.Point(208, 521);
            this.lbl_indiziomedio1_2.Name = "lbl_indiziomedio1_2";
            this.lbl_indiziomedio1_2.Size = new System.Drawing.Size(236, 13);
            this.lbl_indiziomedio1_2.TabIndex = 10;
            this.lbl_indiziomedio1_2.Text = "L’allenatore di questa squadra è Diego Simeone.";
            this.lbl_indiziomedio1_2.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(315, 542);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 9;
            // 
            // btn_opzione4medio1
            // 
            this.btn_opzione4medio1.Location = new System.Drawing.Point(359, 415);
            this.btn_opzione4medio1.Name = "btn_opzione4medio1";
            this.btn_opzione4medio1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio1.TabIndex = 8;
            this.btn_opzione4medio1.Text = "Chelsea";
            this.btn_opzione4medio1.UseVisualStyleBackColor = true;
            this.btn_opzione4medio1.Click += new System.EventHandler(this.btn_opzione4medio1_Click);
            // 
            // btn_opzione3medio1
            // 
            this.btn_opzione3medio1.Location = new System.Drawing.Point(109, 415);
            this.btn_opzione3medio1.Name = "btn_opzione3medio1";
            this.btn_opzione3medio1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio1.TabIndex = 7;
            this.btn_opzione3medio1.Text = "Atletich Bilbao";
            this.btn_opzione3medio1.UseVisualStyleBackColor = true;
            this.btn_opzione3medio1.Click += new System.EventHandler(this.btn_opzione3medio1_Click);
            // 
            // btn_opzione2medio1
            // 
            this.btn_opzione2medio1.Location = new System.Drawing.Point(360, 344);
            this.btn_opzione2medio1.Name = "btn_opzione2medio1";
            this.btn_opzione2medio1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio1.TabIndex = 6;
            this.btn_opzione2medio1.Text = "Atletico Madrid";
            this.btn_opzione2medio1.UseVisualStyleBackColor = true;
            this.btn_opzione2medio1.Click += new System.EventHandler(this.btn_opzione2medio1_Click);
            // 
            // btn_opzione1medio1
            // 
            this.btn_opzione1medio1.Location = new System.Drawing.Point(109, 344);
            this.btn_opzione1medio1.Name = "btn_opzione1medio1";
            this.btn_opzione1medio1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio1.TabIndex = 5;
            this.btn_opzione1medio1.Text = "Arsenal";
            this.btn_opzione1medio1.UseVisualStyleBackColor = true;
            this.btn_opzione1medio1.Click += new System.EventHandler(this.btn_opzione1medio1_Click);
            // 
            // tbp_2medio
            // 
            this.tbp_2medio.Controls.Add(this.label28);
            this.tbp_2medio.Controls.Add(this.lbl_punteggio2medio);
            this.tbp_2medio.Controls.Add(this.groupBox15);
            this.tbp_2medio.Controls.Add(this.pb_homemedio2);
            this.tbp_2medio.Controls.Add(this.pictureBox71);
            this.tbp_2medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_2medio.Name = "tbp_2medio";
            this.tbp_2medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_2medio.TabIndex = 16;
            this.tbp_2medio.Text = "livello 2 medio";
            this.tbp_2medio.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(551, 88);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Punteggio:";
            // 
            // lbl_punteggio2medio
            // 
            this.lbl_punteggio2medio.AutoSize = true;
            this.lbl_punteggio2medio.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio2medio.Name = "lbl_punteggio2medio";
            this.lbl_punteggio2medio.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio2medio.TabIndex = 25;
            this.lbl_punteggio2medio.Text = "100";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.lbl_indiziomedio2_1);
            this.groupBox15.Controls.Add(this.lbl_indiziomedio2_2);
            this.groupBox15.Controls.Add(this.lbl_indiziomedio2_3);
            this.groupBox15.Controls.Add(this.btn_opzione4medio2);
            this.groupBox15.Controls.Add(this.btn_opzione3medio2);
            this.groupBox15.Controls.Add(this.btn_opzione2medio2);
            this.groupBox15.Controls.Add(this.btn_opzione1medio2);
            this.groupBox15.Controls.Add(this.pictureBox57);
            this.groupBox15.Controls.Add(this.pb_frecciaindietromedio2);
            this.groupBox15.Controls.Add(this.pb_indiziomedio2_2);
            this.groupBox15.Controls.Add(this.pb_indiziomedio2_1);
            this.groupBox15.Controls.Add(this.pb_indiziomedio2_3);
            this.groupBox15.Controls.Add(this.pb_frecciavantimedio2);
            this.groupBox15.Location = new System.Drawing.Point(6, 107);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(660, 569);
            this.groupBox15.TabIndex = 23;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Esperto";
            // 
            // lbl_indiziomedio2_1
            // 
            this.lbl_indiziomedio2_1.AutoSize = true;
            this.lbl_indiziomedio2_1.Location = new System.Drawing.Point(182, 501);
            this.lbl_indiziomedio2_1.Name = "lbl_indiziomedio2_1";
            this.lbl_indiziomedio2_1.Size = new System.Drawing.Size(293, 13);
            this.lbl_indiziomedio2_1.TabIndex = 17;
            this.lbl_indiziomedio2_1.Text = "Questa squadra milita nella Bundesliga, campionato tedesco.";
            this.lbl_indiziomedio2_1.Visible = false;
            // 
            // lbl_indiziomedio2_2
            // 
            this.lbl_indiziomedio2_2.AutoSize = true;
            this.lbl_indiziomedio2_2.Location = new System.Drawing.Point(218, 521);
            this.lbl_indiziomedio2_2.Name = "lbl_indiziomedio2_2";
            this.lbl_indiziomedio2_2.Size = new System.Drawing.Size(220, 13);
            this.lbl_indiziomedio2_2.TabIndex = 16;
            this.lbl_indiziomedio2_2.Text = "L’allenatore di questa squadra è Xabi Alonso.";
            this.lbl_indiziomedio2_2.Visible = false;
            // 
            // lbl_indiziomedio2_3
            // 
            this.lbl_indiziomedio2_3.AutoSize = true;
            this.lbl_indiziomedio2_3.Location = new System.Drawing.Point(196, 550);
            this.lbl_indiziomedio2_3.Name = "lbl_indiziomedio2_3";
            this.lbl_indiziomedio2_3.Size = new System.Drawing.Size(259, 13);
            this.lbl_indiziomedio2_3.TabIndex = 15;
            this.lbl_indiziomedio2_3.Text = "Questa squadra è l’ultima detentrice della Bundesliga.";
            this.lbl_indiziomedio2_3.Visible = false;
            // 
            // btn_opzione4medio2
            // 
            this.btn_opzione4medio2.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio2.Name = "btn_opzione4medio2";
            this.btn_opzione4medio2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio2.TabIndex = 14;
            this.btn_opzione4medio2.Text = "Lipsia";
            this.btn_opzione4medio2.UseVisualStyleBackColor = true;
            this.btn_opzione4medio2.Click += new System.EventHandler(this.btn_opzione4medio2_Click);
            // 
            // btn_opzione3medio2
            // 
            this.btn_opzione3medio2.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio2.Name = "btn_opzione3medio2";
            this.btn_opzione3medio2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio2.TabIndex = 13;
            this.btn_opzione3medio2.Text = "Bayer Leverkusen";
            this.btn_opzione3medio2.UseVisualStyleBackColor = true;
            this.btn_opzione3medio2.Click += new System.EventHandler(this.btn_opzione3medio2_Click);
            // 
            // btn_opzione2medio2
            // 
            this.btn_opzione2medio2.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio2.Name = "btn_opzione2medio2";
            this.btn_opzione2medio2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio2.TabIndex = 12;
            this.btn_opzione2medio2.Text = "Lazio";
            this.btn_opzione2medio2.UseVisualStyleBackColor = true;
            this.btn_opzione2medio2.Click += new System.EventHandler(this.btn_opzione2medio2_Click);
            // 
            // btn_opzione1medio2
            // 
            this.btn_opzione1medio2.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio2.Name = "btn_opzione1medio2";
            this.btn_opzione1medio2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio2.TabIndex = 11;
            this.btn_opzione1medio2.Text = "Manchester United";
            this.btn_opzione1medio2.UseVisualStyleBackColor = true;
            this.btn_opzione1medio2.Click += new System.EventHandler(this.btn_opzione1medio2_Click);
            // 
            // tbp_3medio
            // 
            this.tbp_3medio.Controls.Add(this.label34);
            this.tbp_3medio.Controls.Add(this.lbl_punteggio3medio);
            this.tbp_3medio.Controls.Add(this.groupBox16);
            this.tbp_3medio.Controls.Add(this.pb_homemedio3);
            this.tbp_3medio.Controls.Add(this.pictureBox80);
            this.tbp_3medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_3medio.Name = "tbp_3medio";
            this.tbp_3medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_3medio.TabIndex = 17;
            this.tbp_3medio.Text = "livello 3 medio";
            this.tbp_3medio.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(551, 88);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 13);
            this.label34.TabIndex = 24;
            this.label34.Text = "Punteggio:";
            // 
            // lbl_punteggio3medio
            // 
            this.lbl_punteggio3medio.AutoSize = true;
            this.lbl_punteggio3medio.Location = new System.Drawing.Point(610, 88);
            this.lbl_punteggio3medio.Name = "lbl_punteggio3medio";
            this.lbl_punteggio3medio.Size = new System.Drawing.Size(25, 13);
            this.lbl_punteggio3medio.TabIndex = 23;
            this.lbl_punteggio3medio.Text = "100";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.pb_frecciaindietromedio3);
            this.groupBox16.Controls.Add(this.lbl_indiziomedio3_3);
            this.groupBox16.Controls.Add(this.lbl_indiziomedio3_1);
            this.groupBox16.Controls.Add(this.lbl_indiziomedio3_2);
            this.groupBox16.Controls.Add(this.label39);
            this.groupBox16.Controls.Add(this.btn_opzione4medio3);
            this.groupBox16.Controls.Add(this.btn_opzione3medio3);
            this.groupBox16.Controls.Add(this.btn_opzione2medio3);
            this.groupBox16.Controls.Add(this.btn_opzione1medio3);
            this.groupBox16.Controls.Add(this.pictureBox73);
            this.groupBox16.Controls.Add(this.pb_indiziomedio3_2);
            this.groupBox16.Controls.Add(this.pb_indiziomedio3_1);
            this.groupBox16.Controls.Add(this.pb_indiziomedio3_3);
            this.groupBox16.Controls.Add(this.pb_frecciavantimedio3);
            this.groupBox16.Location = new System.Drawing.Point(6, 107);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(660, 569);
            this.groupBox16.TabIndex = 21;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Esperto";
            // 
            // lbl_indiziomedio3_3
            // 
            this.lbl_indiziomedio3_3.AutoSize = true;
            this.lbl_indiziomedio3_3.Location = new System.Drawing.Point(147, 550);
            this.lbl_indiziomedio3_3.Name = "lbl_indiziomedio3_3";
            this.lbl_indiziomedio3_3.Size = new System.Drawing.Size(358, 13);
            this.lbl_indiziomedio3_3.TabIndex = 12;
            this.lbl_indiziomedio3_3.Text = "Questa squadra è stata la prima a vincere la Conference League nel 2022.";
            this.lbl_indiziomedio3_3.Visible = false;
            // 
            // lbl_indiziomedio3_1
            // 
            this.lbl_indiziomedio3_1.AutoSize = true;
            this.lbl_indiziomedio3_1.Location = new System.Drawing.Point(197, 501);
            this.lbl_indiziomedio3_1.Name = "lbl_indiziomedio3_1";
            this.lbl_indiziomedio3_1.Size = new System.Drawing.Size(270, 13);
            this.lbl_indiziomedio3_1.TabIndex = 11;
            this.lbl_indiziomedio3_1.Text = "Questa squadra milita nella Serie A, campionato italiano.";
            this.lbl_indiziomedio3_1.Visible = false;
            // 
            // lbl_indiziomedio3_2
            // 
            this.lbl_indiziomedio3_2.AutoSize = true;
            this.lbl_indiziomedio3_2.Location = new System.Drawing.Point(208, 521);
            this.lbl_indiziomedio3_2.Name = "lbl_indiziomedio3_2";
            this.lbl_indiziomedio3_2.Size = new System.Drawing.Size(246, 13);
            this.lbl_indiziomedio3_2.TabIndex = 10;
            this.lbl_indiziomedio3_2.Text = "L’allenatore di questa squadra è Daniele De Rossi.";
            this.lbl_indiziomedio3_2.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(315, 542);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(0, 13);
            this.label39.TabIndex = 9;
            // 
            // btn_opzione4medio3
            // 
            this.btn_opzione4medio3.Location = new System.Drawing.Point(359, 415);
            this.btn_opzione4medio3.Name = "btn_opzione4medio3";
            this.btn_opzione4medio3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio3.TabIndex = 8;
            this.btn_opzione4medio3.Text = "West-Ham";
            this.btn_opzione4medio3.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio3
            // 
            this.btn_opzione3medio3.Location = new System.Drawing.Point(109, 415);
            this.btn_opzione3medio3.Name = "btn_opzione3medio3";
            this.btn_opzione3medio3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio3.TabIndex = 7;
            this.btn_opzione3medio3.Text = "Benfica";
            this.btn_opzione3medio3.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio3
            // 
            this.btn_opzione2medio3.Location = new System.Drawing.Point(360, 344);
            this.btn_opzione2medio3.Name = "btn_opzione2medio3";
            this.btn_opzione2medio3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio3.TabIndex = 6;
            this.btn_opzione2medio3.Text = "Fiorentina";
            this.btn_opzione2medio3.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio3
            // 
            this.btn_opzione1medio3.Location = new System.Drawing.Point(109, 344);
            this.btn_opzione1medio3.Name = "btn_opzione1medio3";
            this.btn_opzione1medio3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio3.TabIndex = 5;
            this.btn_opzione1medio3.Text = "Roma";
            this.btn_opzione1medio3.UseVisualStyleBackColor = true;
            // 
            // tbp_4medio
            // 
            this.tbp_4medio.Controls.Add(this.label7);
            this.tbp_4medio.Controls.Add(this.label23);
            this.tbp_4medio.Controls.Add(this.groupBox17);
            this.tbp_4medio.Controls.Add(this.pb_homelivello4medio);
            this.tbp_4medio.Controls.Add(this.pictureBox68);
            this.tbp_4medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_4medio.Name = "tbp_4medio";
            this.tbp_4medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_4medio.TabIndex = 18;
            this.tbp_4medio.Text = "livello 4 medio";
            this.tbp_4medio.UseVisualStyleBackColor = true;
            // 
            // tbp_5medio
            // 
            this.tbp_5medio.Controls.Add(this.label35);
            this.tbp_5medio.Controls.Add(this.label36);
            this.tbp_5medio.Controls.Add(this.groupBox18);
            this.tbp_5medio.Controls.Add(this.pb_homemedio5);
            this.tbp_5medio.Controls.Add(this.pictureBox91);
            this.tbp_5medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_5medio.Name = "tbp_5medio";
            this.tbp_5medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_5medio.TabIndex = 19;
            this.tbp_5medio.Text = "livello 5 medio";
            this.tbp_5medio.UseVisualStyleBackColor = true;
            // 
            // tbp_6medio
            // 
            this.tbp_6medio.Controls.Add(this.label46);
            this.tbp_6medio.Controls.Add(this.label47);
            this.tbp_6medio.Controls.Add(this.groupBox20);
            this.tbp_6medio.Controls.Add(this.pb_homemedio6);
            this.tbp_6medio.Controls.Add(this.pictureBox117);
            this.tbp_6medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_6medio.Name = "tbp_6medio";
            this.tbp_6medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_6medio.TabIndex = 20;
            this.tbp_6medio.Text = "livello 6 medio";
            this.tbp_6medio.UseVisualStyleBackColor = true;
            // 
            // tbp_7medio
            // 
            this.tbp_7medio.Controls.Add(this.label56);
            this.tbp_7medio.Controls.Add(this.label57);
            this.tbp_7medio.Controls.Add(this.groupBox22);
            this.tbp_7medio.Controls.Add(this.pb_homemedio7);
            this.tbp_7medio.Controls.Add(this.pictureBox133);
            this.tbp_7medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_7medio.Name = "tbp_7medio";
            this.tbp_7medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_7medio.TabIndex = 21;
            this.tbp_7medio.Text = "livello 7 medio";
            this.tbp_7medio.UseVisualStyleBackColor = true;
            // 
            // tbp_8medio
            // 
            this.tbp_8medio.Controls.Add(this.label66);
            this.tbp_8medio.Controls.Add(this.label67);
            this.tbp_8medio.Controls.Add(this.groupBox24);
            this.tbp_8medio.Controls.Add(this.pb_homemedio8);
            this.tbp_8medio.Controls.Add(this.pictureBox151);
            this.tbp_8medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_8medio.Name = "tbp_8medio";
            this.tbp_8medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_8medio.TabIndex = 22;
            this.tbp_8medio.Text = "livello 8 medio";
            this.tbp_8medio.UseVisualStyleBackColor = true;
            // 
            // tbp_9medio
            // 
            this.tbp_9medio.Controls.Add(this.label76);
            this.tbp_9medio.Controls.Add(this.label77);
            this.tbp_9medio.Controls.Add(this.groupBox26);
            this.tbp_9medio.Controls.Add(this.pb_homemedio9);
            this.tbp_9medio.Controls.Add(this.pictureBox167);
            this.tbp_9medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_9medio.Name = "tbp_9medio";
            this.tbp_9medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_9medio.TabIndex = 23;
            this.tbp_9medio.Text = "livello 9 medio";
            this.tbp_9medio.UseVisualStyleBackColor = true;
            // 
            // tbp_10medio
            // 
            this.tbp_10medio.Controls.Add(this.label86);
            this.tbp_10medio.Controls.Add(this.label87);
            this.tbp_10medio.Controls.Add(this.groupBox29);
            this.tbp_10medio.Controls.Add(this.pb_homemedio10);
            this.tbp_10medio.Controls.Add(this.pictureBox182);
            this.tbp_10medio.Location = new System.Drawing.Point(4, 22);
            this.tbp_10medio.Name = "tbp_10medio";
            this.tbp_10medio.Size = new System.Drawing.Size(672, 697);
            this.tbp_10medio.TabIndex = 24;
            this.tbp_10medio.Text = "livello 10 medio";
            this.tbp_10medio.UseVisualStyleBackColor = true;
            // 
            // tbp_finemedio
            // 
            this.tbp_finemedio.Controls.Add(this.pictureBox190);
            this.tbp_finemedio.Controls.Add(this.pictureBox191);
            this.tbp_finemedio.Controls.Add(this.pictureBox192);
            this.tbp_finemedio.Controls.Add(this.pictureBox193);
            this.tbp_finemedio.Controls.Add(this.pictureBox194);
            this.tbp_finemedio.Controls.Add(this.label96);
            this.tbp_finemedio.Controls.Add(this.label97);
            this.tbp_finemedio.Controls.Add(this.label98);
            this.tbp_finemedio.Controls.Add(this.label99);
            this.tbp_finemedio.Controls.Add(this.label100);
            this.tbp_finemedio.Controls.Add(this.label101);
            this.tbp_finemedio.Location = new System.Drawing.Point(4, 22);
            this.tbp_finemedio.Name = "tbp_finemedio";
            this.tbp_finemedio.Size = new System.Drawing.Size(672, 697);
            this.tbp_finemedio.TabIndex = 25;
            this.tbp_finemedio.Text = "fine medio";
            this.tbp_finemedio.UseVisualStyleBackColor = true;
            // 
            // tbp_1difficile
            // 
            this.tbp_1difficile.Controls.Add(this.label108);
            this.tbp_1difficile.Controls.Add(this.label109);
            this.tbp_1difficile.Controls.Add(this.groupBox31);
            this.tbp_1difficile.Controls.Add(this.pb_homedifficile1);
            this.tbp_1difficile.Controls.Add(this.pictureBox204);
            this.tbp_1difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_1difficile.Name = "tbp_1difficile";
            this.tbp_1difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_1difficile.TabIndex = 26;
            this.tbp_1difficile.Text = "livello 1 difficile";
            this.tbp_1difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_2difficile
            // 
            this.tbp_2difficile.Controls.Add(this.label114);
            this.tbp_2difficile.Controls.Add(this.label115);
            this.tbp_2difficile.Controls.Add(this.groupBox32);
            this.tbp_2difficile.Controls.Add(this.pb_homedifficile2);
            this.tbp_2difficile.Controls.Add(this.pictureBox212);
            this.tbp_2difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_2difficile.Name = "tbp_2difficile";
            this.tbp_2difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_2difficile.TabIndex = 27;
            this.tbp_2difficile.Text = "livello 2 difficile";
            this.tbp_2difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_3difficile
            // 
            this.tbp_3difficile.Controls.Add(this.label119);
            this.tbp_3difficile.Controls.Add(this.label120);
            this.tbp_3difficile.Controls.Add(this.groupBox33);
            this.tbp_3difficile.Controls.Add(this.pb_homedifficile3);
            this.tbp_3difficile.Controls.Add(this.pictureBox220);
            this.tbp_3difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_3difficile.Name = "tbp_3difficile";
            this.tbp_3difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_3difficile.TabIndex = 28;
            this.tbp_3difficile.Text = "livello 3 difficile";
            this.tbp_3difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_4difficile
            // 
            this.tbp_4difficile.Controls.Add(this.label29);
            this.tbp_4difficile.Controls.Add(this.label30);
            this.tbp_4difficile.Controls.Add(this.groupBox27);
            this.tbp_4difficile.Controls.Add(this.pb_homedifficile4);
            this.tbp_4difficile.Controls.Add(this.pictureBox81);
            this.tbp_4difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_4difficile.Name = "tbp_4difficile";
            this.tbp_4difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_4difficile.TabIndex = 29;
            this.tbp_4difficile.Text = "livello 4 difficile";
            this.tbp_4difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_5difficile
            // 
            this.tbp_5difficile.Controls.Add(this.label41);
            this.tbp_5difficile.Controls.Add(this.label42);
            this.tbp_5difficile.Controls.Add(this.groupBox19);
            this.tbp_5difficile.Controls.Add(this.pb_homedifficile5);
            this.tbp_5difficile.Controls.Add(this.pictureBox109);
            this.tbp_5difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_5difficile.Name = "tbp_5difficile";
            this.tbp_5difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_5difficile.TabIndex = 30;
            this.tbp_5difficile.Text = "livello 5 difficile";
            this.tbp_5difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_6difficile
            // 
            this.tbp_6difficile.Controls.Add(this.label51);
            this.tbp_6difficile.Controls.Add(this.label52);
            this.tbp_6difficile.Controls.Add(this.groupBox21);
            this.tbp_6difficile.Controls.Add(this.pb_homedifficile6);
            this.tbp_6difficile.Controls.Add(this.pictureBox125);
            this.tbp_6difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_6difficile.Name = "tbp_6difficile";
            this.tbp_6difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_6difficile.TabIndex = 31;
            this.tbp_6difficile.Text = "livello 6 difficile";
            this.tbp_6difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_7difficile
            // 
            this.tbp_7difficile.Controls.Add(this.label61);
            this.tbp_7difficile.Controls.Add(this.label62);
            this.tbp_7difficile.Controls.Add(this.groupBox23);
            this.tbp_7difficile.Controls.Add(this.pb_homedifficile7);
            this.tbp_7difficile.Controls.Add(this.pictureBox141);
            this.tbp_7difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_7difficile.Name = "tbp_7difficile";
            this.tbp_7difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_7difficile.TabIndex = 32;
            this.tbp_7difficile.Text = "livello 7 difficile";
            this.tbp_7difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_8difficile
            // 
            this.tbp_8difficile.Controls.Add(this.label71);
            this.tbp_8difficile.Controls.Add(this.label72);
            this.tbp_8difficile.Controls.Add(this.groupBox25);
            this.tbp_8difficile.Controls.Add(this.pb_homedifficile8);
            this.tbp_8difficile.Controls.Add(this.pictureBox159);
            this.tbp_8difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_8difficile.Name = "tbp_8difficile";
            this.tbp_8difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_8difficile.TabIndex = 33;
            this.tbp_8difficile.Text = "livello 8 difficile";
            this.tbp_8difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_9difficile
            // 
            this.tbp_9difficile.Controls.Add(this.label81);
            this.tbp_9difficile.Controls.Add(this.label82);
            this.tbp_9difficile.Controls.Add(this.groupBox28);
            this.tbp_9difficile.Controls.Add(this.pb_homedifficile9);
            this.tbp_9difficile.Controls.Add(this.pictureBox175);
            this.tbp_9difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_9difficile.Name = "tbp_9difficile";
            this.tbp_9difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_9difficile.TabIndex = 34;
            this.tbp_9difficile.Text = "livello 9 difficile";
            this.tbp_9difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_10difficile
            // 
            this.tbp_10difficile.Controls.Add(this.label91);
            this.tbp_10difficile.Controls.Add(this.label92);
            this.tbp_10difficile.Controls.Add(this.groupBox30);
            this.tbp_10difficile.Controls.Add(this.pb_homedifficile10);
            this.tbp_10difficile.Controls.Add(this.pictureBox189);
            this.tbp_10difficile.Location = new System.Drawing.Point(4, 22);
            this.tbp_10difficile.Name = "tbp_10difficile";
            this.tbp_10difficile.Size = new System.Drawing.Size(672, 697);
            this.tbp_10difficile.TabIndex = 35;
            this.tbp_10difficile.Text = "livello 10 difficile";
            this.tbp_10difficile.UseVisualStyleBackColor = true;
            // 
            // tbp_finedifficili
            // 
            this.tbp_finedifficili.Controls.Add(this.pictureBox147);
            this.tbp_finedifficili.Controls.Add(this.pictureBox148);
            this.tbp_finedifficili.Controls.Add(this.pictureBox195);
            this.tbp_finedifficili.Controls.Add(this.pictureBox196);
            this.tbp_finedifficili.Controls.Add(this.pictureBox197);
            this.tbp_finedifficili.Controls.Add(this.label102);
            this.tbp_finedifficili.Controls.Add(this.label103);
            this.tbp_finedifficili.Controls.Add(this.label104);
            this.tbp_finedifficili.Controls.Add(this.label105);
            this.tbp_finedifficili.Controls.Add(this.label106);
            this.tbp_finedifficili.Controls.Add(this.label107);
            this.tbp_finedifficili.Location = new System.Drawing.Point(4, 22);
            this.tbp_finedifficili.Name = "tbp_finedifficili";
            this.tbp_finedifficili.Size = new System.Drawing.Size(672, 697);
            this.tbp_finedifficili.TabIndex = 36;
            this.tbp_finedifficili.Text = "fine livelli difficili";
            this.tbp_finedifficili.UseVisualStyleBackColor = true;
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
            "Principiante",
            "Esperto ",
            "Campione "});
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Punteggio:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(610, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "100";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label24);
            this.groupBox17.Controls.Add(this.label25);
            this.groupBox17.Controls.Add(this.label26);
            this.groupBox17.Controls.Add(this.btn_opzione4medio4);
            this.groupBox17.Controls.Add(this.btn_opzione3medio4);
            this.groupBox17.Controls.Add(this.btn_opzione2medio4);
            this.groupBox17.Controls.Add(this.btn_opzione1medio4);
            this.groupBox17.Controls.Add(this.pictureBox50);
            this.groupBox17.Controls.Add(this.pictureBox51);
            this.groupBox17.Controls.Add(this.pb_indiziomedio4_2);
            this.groupBox17.Controls.Add(this.pb_indiziomedio4_1);
            this.groupBox17.Controls.Add(this.pb_indiziomedio4_3);
            this.groupBox17.Controls.Add(this.pb_frecciavantimedio4);
            this.groupBox17.Location = new System.Drawing.Point(6, 107);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(660, 569);
            this.groupBox17.TabIndex = 23;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Esperto";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(170, 501);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(310, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.label24.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(210, 521);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(223, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "L’allenatore di questa squadra è Erik ten Hag.";
            this.label25.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(194, 550);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(252, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Questa è la squadra con più titoli di Premier League.";
            this.label26.Visible = false;
            // 
            // btn_opzione4medio4
            // 
            this.btn_opzione4medio4.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio4.Name = "btn_opzione4medio4";
            this.btn_opzione4medio4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio4.TabIndex = 14;
            this.btn_opzione4medio4.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio4
            // 
            this.btn_opzione3medio4.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio4.Name = "btn_opzione3medio4";
            this.btn_opzione3medio4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio4.TabIndex = 13;
            this.btn_opzione3medio4.Text = "Sporting Lisbona";
            this.btn_opzione3medio4.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio4
            // 
            this.btn_opzione2medio4.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio4.Name = "btn_opzione2medio4";
            this.btn_opzione2medio4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio4.TabIndex = 12;
            this.btn_opzione2medio4.Text = "Manchester United";
            this.btn_opzione2medio4.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio4
            // 
            this.btn_opzione1medio4.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio4.Name = "btn_opzione1medio4";
            this.btn_opzione1medio4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio4.TabIndex = 11;
            this.btn_opzione1medio4.Text = "Everton";
            this.btn_opzione1medio4.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(551, 88);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 13);
            this.label29.TabIndex = 26;
            this.label29.Text = "Punteggio:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(610, 88);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(25, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "100";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.label31);
            this.groupBox27.Controls.Add(this.label32);
            this.groupBox27.Controls.Add(this.label33);
            this.groupBox27.Controls.Add(this.btn_opzione4difficile4);
            this.groupBox27.Controls.Add(this.btn_opzione3difficile4);
            this.groupBox27.Controls.Add(this.btn_opzione2difficile4);
            this.groupBox27.Controls.Add(this.btn_opzione1difficile4);
            this.groupBox27.Controls.Add(this.pictureBox69);
            this.groupBox27.Controls.Add(this.pictureBox70);
            this.groupBox27.Controls.Add(this.pb_indiziodifficile4_2);
            this.groupBox27.Controls.Add(this.pb_indiziodifficile4_1);
            this.groupBox27.Controls.Add(this.pb_indiziodifficile4_3);
            this.groupBox27.Controls.Add(this.pb_frecciavantidifficile4);
            this.groupBox27.Location = new System.Drawing.Point(6, 107);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(660, 569);
            this.groupBox27.TabIndex = 23;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Campione";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(202, 501);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(256, 13);
            this.label31.TabIndex = 17;
            this.label31.Text = "Questa squadra milita in Serie A, campionato italiano.";
            this.label31.Visible = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(202, 521);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(256, 13);
            this.label32.TabIndex = 16;
            this.label32.Text = "L’allenatore di questa squadra è Gianpiero Gasperini.";
            this.label32.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(142, 550);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(389, 13);
            this.label33.TabIndex = 15;
            this.label33.Text = "Questa squadra si è qualificata ai quarti della UEFA Champions League del 2021.";
            this.label33.Visible = false;
            // 
            // btn_opzione4difficile4
            // 
            this.btn_opzione4difficile4.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile4.Name = "btn_opzione4difficile4";
            this.btn_opzione4difficile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile4.TabIndex = 14;
            this.btn_opzione4difficile4.Text = "Bayer Leverkusen";
            this.btn_opzione4difficile4.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile4
            // 
            this.btn_opzione3difficile4.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile4.Name = "btn_opzione3difficile4";
            this.btn_opzione3difficile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile4.TabIndex = 13;
            this.btn_opzione3difficile4.Text = "Real Madrid ";
            this.btn_opzione3difficile4.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile4
            // 
            this.btn_opzione2difficile4.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile4.Name = "btn_opzione2difficile4";
            this.btn_opzione2difficile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile4.TabIndex = 12;
            this.btn_opzione2difficile4.Text = "Milan ";
            this.btn_opzione2difficile4.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile4
            // 
            this.btn_opzione1difficile4.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile4.Name = "btn_opzione1difficile4";
            this.btn_opzione1difficile4.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile4.TabIndex = 11;
            this.btn_opzione1difficile4.Text = "Bayern Monaco";
            this.btn_opzione1difficile4.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(551, 88);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 13);
            this.label35.TabIndex = 26;
            this.label35.Text = "Punteggio:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(610, 88);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(25, 13);
            this.label36.TabIndex = 25;
            this.label36.Text = "100";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label37);
            this.groupBox18.Controls.Add(this.label38);
            this.groupBox18.Controls.Add(this.label40);
            this.groupBox18.Controls.Add(this.btn_opzione4medio5);
            this.groupBox18.Controls.Add(this.btn_opzione3medio5);
            this.groupBox18.Controls.Add(this.btn_opzione2medio5);
            this.groupBox18.Controls.Add(this.btn_opzione1medio5);
            this.groupBox18.Controls.Add(this.pictureBox82);
            this.groupBox18.Controls.Add(this.pictureBox83);
            this.groupBox18.Controls.Add(this.pb_indiziomedio5_2);
            this.groupBox18.Controls.Add(this.pb_indiziomedio5_1);
            this.groupBox18.Controls.Add(this.pb_indiziomedio5_3);
            this.groupBox18.Controls.Add(this.pb_frecciavantimedio5);
            this.groupBox18.Location = new System.Drawing.Point(6, 107);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(660, 569);
            this.groupBox18.TabIndex = 23;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Esperto";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(170, 501);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(310, 13);
            this.label37.TabIndex = 17;
            this.label37.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.label37.Visible = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(216, 521);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(220, 13);
            this.label38.TabIndex = 16;
            this.label38.Text = "L’allenatore di questa squadra è Mikel Arteta.";
            this.label38.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(186, 550);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(263, 13);
            this.label40.TabIndex = 15;
            this.label40.Text = "Questa squadra è conosciuta anche così: “i Gunners”.";
            this.label40.Visible = false;
            // 
            // btn_opzione4medio5
            // 
            this.btn_opzione4medio5.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio5.Name = "btn_opzione4medio5";
            this.btn_opzione4medio5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio5.TabIndex = 14;
            this.btn_opzione4medio5.Text = "Liverpool";
            this.btn_opzione4medio5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio5
            // 
            this.btn_opzione3medio5.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio5.Name = "btn_opzione3medio5";
            this.btn_opzione3medio5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio5.TabIndex = 13;
            this.btn_opzione3medio5.Text = "Juventus";
            this.btn_opzione3medio5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio5
            // 
            this.btn_opzione2medio5.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio5.Name = "btn_opzione2medio5";
            this.btn_opzione2medio5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio5.TabIndex = 12;
            this.btn_opzione2medio5.Text = "Atletico Madrid";
            this.btn_opzione2medio5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio5
            // 
            this.btn_opzione1medio5.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio5.Name = "btn_opzione1medio5";
            this.btn_opzione1medio5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio5.TabIndex = 11;
            this.btn_opzione1medio5.Text = "Barcellona";
            this.btn_opzione1medio5.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(551, 88);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(58, 13);
            this.label41.TabIndex = 26;
            this.label41.Text = "Punteggio:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(610, 88);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(25, 13);
            this.label42.TabIndex = 25;
            this.label42.Text = "100";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label43);
            this.groupBox19.Controls.Add(this.label44);
            this.groupBox19.Controls.Add(this.label45);
            this.groupBox19.Controls.Add(this.btn_opzione4difficile5);
            this.groupBox19.Controls.Add(this.btn_opzione3difficile5);
            this.groupBox19.Controls.Add(this.btn_opzione2difficile5);
            this.groupBox19.Controls.Add(this.btn_opzione1difficile5);
            this.groupBox19.Controls.Add(this.pictureBox92);
            this.groupBox19.Controls.Add(this.pictureBox93);
            this.groupBox19.Controls.Add(this.pb_indiziodifficile5_2);
            this.groupBox19.Controls.Add(this.pb_indiziodifficile5_1);
            this.groupBox19.Controls.Add(this.pb_indiziodifficile5_3);
            this.groupBox19.Controls.Add(this.pb_frecciavantidifficile5);
            this.groupBox19.Location = new System.Drawing.Point(6, 107);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(660, 569);
            this.groupBox19.TabIndex = 23;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Campione";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(192, 501);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(270, 13);
            this.label43.TabIndex = 17;
            this.label43.Text = "Questa squadra milita nella Serie A, campionato italiano.";
            this.label43.Visible = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(215, 521);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(213, 13);
            this.label44.TabIndex = 16;
            this.label44.Text = "L’allenatore di questa squadra è Igor Tudor.";
            this.label44.Visible = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(201, 542);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(249, 13);
            this.label45.TabIndex = 15;
            this.label45.Text = "Questa squadra gioca allo stadio Olimpico di Roma.";
            this.label45.Visible = false;
            // 
            // btn_opzione4difficile5
            // 
            this.btn_opzione4difficile5.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile5.Name = "btn_opzione4difficile5";
            this.btn_opzione4difficile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile5.TabIndex = 14;
            this.btn_opzione4difficile5.Text = "Liverpool";
            this.btn_opzione4difficile5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile5
            // 
            this.btn_opzione3difficile5.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile5.Name = "btn_opzione3difficile5";
            this.btn_opzione3difficile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile5.TabIndex = 13;
            this.btn_opzione3difficile5.Text = "Juventus";
            this.btn_opzione3difficile5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile5
            // 
            this.btn_opzione2difficile5.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile5.Name = "btn_opzione2difficile5";
            this.btn_opzione2difficile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile5.TabIndex = 12;
            this.btn_opzione2difficile5.Text = "Atletico Madrid";
            this.btn_opzione2difficile5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile5
            // 
            this.btn_opzione1difficile5.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile5.Name = "btn_opzione1difficile5";
            this.btn_opzione1difficile5.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile5.TabIndex = 11;
            this.btn_opzione1difficile5.Text = "Barcellona";
            this.btn_opzione1difficile5.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(551, 88);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(58, 13);
            this.label46.TabIndex = 26;
            this.label46.Text = "Punteggio:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(610, 88);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(25, 13);
            this.label47.TabIndex = 25;
            this.label47.Text = "100";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.label48);
            this.groupBox20.Controls.Add(this.label49);
            this.groupBox20.Controls.Add(this.label50);
            this.groupBox20.Controls.Add(this.btn_opzione4medio6);
            this.groupBox20.Controls.Add(this.btn_opzione3medio6);
            this.groupBox20.Controls.Add(this.btn_opzione2medio6);
            this.groupBox20.Controls.Add(this.btn_opzione1medio6);
            this.groupBox20.Controls.Add(this.pictureBox110);
            this.groupBox20.Controls.Add(this.pictureBox111);
            this.groupBox20.Controls.Add(this.pb_indiziomedio6_2);
            this.groupBox20.Controls.Add(this.pb_indiziomedio6_1);
            this.groupBox20.Controls.Add(this.pb_indiziomedio6_3);
            this.groupBox20.Controls.Add(this.pb_frecciavantimedio6);
            this.groupBox20.Location = new System.Drawing.Point(6, 107);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(660, 569);
            this.groupBox20.TabIndex = 23;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Esperto";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(192, 501);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(270, 13);
            this.label48.TabIndex = 17;
            this.label48.Text = "Questa squadra milita nella Serie A, campionato italiano.";
            this.label48.Visible = false;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(192, 521);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(255, 13);
            this.label49.TabIndex = 16;
            this.label49.Text = "L’allenatore di questa squadra è Francesco Calzona.";
            this.label49.Visible = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(154, 550);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(337, 13);
            this.label50.TabIndex = 15;
            this.label50.Text = "In questa squadra ha giocato per due anni Diego Armando Maradona.";
            this.label50.Visible = false;
            // 
            // btn_opzione4medio6
            // 
            this.btn_opzione4medio6.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio6.Name = "btn_opzione4medio6";
            this.btn_opzione4medio6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio6.TabIndex = 14;
            this.btn_opzione4medio6.Text = "Borussia Dortmund";
            this.btn_opzione4medio6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio6
            // 
            this.btn_opzione3medio6.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio6.Name = "btn_opzione3medio6";
            this.btn_opzione3medio6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio6.TabIndex = 13;
            this.btn_opzione3medio6.Text = "Liverpool";
            this.btn_opzione3medio6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio6
            // 
            this.btn_opzione2medio6.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio6.Name = "btn_opzione2medio6";
            this.btn_opzione2medio6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio6.TabIndex = 12;
            this.btn_opzione2medio6.Text = "Thottenham";
            this.btn_opzione2medio6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio6
            // 
            this.btn_opzione1medio6.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio6.Name = "btn_opzione1medio6";
            this.btn_opzione1medio6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio6.TabIndex = 11;
            this.btn_opzione1medio6.Text = "Milan";
            this.btn_opzione1medio6.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(551, 88);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(58, 13);
            this.label51.TabIndex = 26;
            this.label51.Text = "Punteggio:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(610, 88);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(25, 13);
            this.label52.TabIndex = 25;
            this.label52.Text = "100";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label53);
            this.groupBox21.Controls.Add(this.label54);
            this.groupBox21.Controls.Add(this.label55);
            this.groupBox21.Controls.Add(this.btn_opzione4difficile6);
            this.groupBox21.Controls.Add(this.btn_opzione3difficile6);
            this.groupBox21.Controls.Add(this.btn_opzione2difficile6);
            this.groupBox21.Controls.Add(this.btn_opzione1difficile6);
            this.groupBox21.Controls.Add(this.pictureBox118);
            this.groupBox21.Controls.Add(this.pictureBox119);
            this.groupBox21.Controls.Add(this.pb_indiziodifficile6_2);
            this.groupBox21.Controls.Add(this.pb_indiziodifficile6_1);
            this.groupBox21.Controls.Add(this.pb_indiziodifficile6_3);
            this.groupBox21.Controls.Add(this.pb_frecciavantidifficile6);
            this.groupBox21.Location = new System.Drawing.Point(6, 107);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(660, 569);
            this.groupBox21.TabIndex = 23;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Campione";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(181, 501);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(310, 13);
            this.label53.TabIndex = 17;
            this.label53.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.label53.Visible = false;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(220, 521);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(226, 13);
            this.label54.TabIndex = 16;
            this.label54.Text = "L’allenatore di questa squadra è David Moyes.";
            this.label54.Visible = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(192, 550);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(287, 13);
            this.label55.TabIndex = 15;
            this.label55.Text = "Questa squadra ha sede nel distretto londinese di Newham.";
            this.label55.Visible = false;
            // 
            // btn_opzione4difficile6
            // 
            this.btn_opzione4difficile6.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile6.Name = "btn_opzione4difficile6";
            this.btn_opzione4difficile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile6.TabIndex = 14;
            this.btn_opzione4difficile6.Text = "Borussia Dortmund";
            this.btn_opzione4difficile6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile6
            // 
            this.btn_opzione3difficile6.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile6.Name = "btn_opzione3difficile6";
            this.btn_opzione3difficile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile6.TabIndex = 13;
            this.btn_opzione3difficile6.Text = "Liverpool";
            this.btn_opzione3difficile6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile6
            // 
            this.btn_opzione2difficile6.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile6.Name = "btn_opzione2difficile6";
            this.btn_opzione2difficile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile6.TabIndex = 12;
            this.btn_opzione2difficile6.Text = "Thottenham";
            this.btn_opzione2difficile6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile6
            // 
            this.btn_opzione1difficile6.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile6.Name = "btn_opzione1difficile6";
            this.btn_opzione1difficile6.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile6.TabIndex = 11;
            this.btn_opzione1difficile6.Text = "Milan";
            this.btn_opzione1difficile6.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(551, 88);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(58, 13);
            this.label56.TabIndex = 26;
            this.label56.Text = "Punteggio:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(610, 88);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(25, 13);
            this.label57.TabIndex = 25;
            this.label57.Text = "100";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label58);
            this.groupBox22.Controls.Add(this.label59);
            this.groupBox22.Controls.Add(this.label60);
            this.groupBox22.Controls.Add(this.btn_opzione4medio7);
            this.groupBox22.Controls.Add(this.btn_opzione3medio7);
            this.groupBox22.Controls.Add(this.btn_opzione2medio7);
            this.groupBox22.Controls.Add(this.btn_opzione1medio7);
            this.groupBox22.Controls.Add(this.pictureBox126);
            this.groupBox22.Controls.Add(this.pictureBox127);
            this.groupBox22.Controls.Add(this.pb_indiziomedio7_2);
            this.groupBox22.Controls.Add(this.pb_indiziomedio7_1);
            this.groupBox22.Controls.Add(this.pb_indiziomedio7_3);
            this.groupBox22.Controls.Add(this.pb_frecciavantimedio7);
            this.groupBox22.Location = new System.Drawing.Point(6, 107);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(660, 569);
            this.groupBox22.TabIndex = 23;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Esperto";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(190, 501);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(271, 13);
            this.label58.TabIndex = 17;
            this.label58.Text = "Questa squadra milita nella Ligue 1, campionato inglese.";
            this.label58.Visible = false;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(200, 521);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(251, 13);
            this.label59.TabIndex = 16;
            this.label59.Text = "L’allenatore di questa squadra è Jean-Louis Gasset.";
            this.label59.Visible = false;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(147, 550);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(373, 13);
            this.label60.TabIndex = 15;
            this.label60.Text = "Questa è l’unica squadra francese ad aver vinto la UEFA Champions League.";
            this.label60.Visible = false;
            // 
            // btn_opzione4medio7
            // 
            this.btn_opzione4medio7.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio7.Name = "btn_opzione4medio7";
            this.btn_opzione4medio7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio7.TabIndex = 14;
            this.btn_opzione4medio7.Text = "Atletico Madrid";
            this.btn_opzione4medio7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio7
            // 
            this.btn_opzione3medio7.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio7.Name = "btn_opzione3medio7";
            this.btn_opzione3medio7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio7.TabIndex = 13;
            this.btn_opzione3medio7.Text = "Juventus";
            this.btn_opzione3medio7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio7
            // 
            this.btn_opzione2medio7.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio7.Name = "btn_opzione2medio7";
            this.btn_opzione2medio7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio7.TabIndex = 12;
            this.btn_opzione2medio7.Text = "Inter";
            this.btn_opzione2medio7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio7
            // 
            this.btn_opzione1medio7.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio7.Name = "btn_opzione1medio7";
            this.btn_opzione1medio7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio7.TabIndex = 11;
            this.btn_opzione1medio7.Text = "Arsenal";
            this.btn_opzione1medio7.UseVisualStyleBackColor = true;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(551, 88);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(58, 13);
            this.label61.TabIndex = 26;
            this.label61.Text = "Punteggio:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(610, 88);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(25, 13);
            this.label62.TabIndex = 25;
            this.label62.Text = "100";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label63);
            this.groupBox23.Controls.Add(this.label64);
            this.groupBox23.Controls.Add(this.label65);
            this.groupBox23.Controls.Add(this.btn_opzione4difficile7);
            this.groupBox23.Controls.Add(this.btn_opzione3difficile7);
            this.groupBox23.Controls.Add(this.btn_opzione2difficile7);
            this.groupBox23.Controls.Add(this.btn_opzione1difficile7);
            this.groupBox23.Controls.Add(this.pictureBox134);
            this.groupBox23.Controls.Add(this.pictureBox135);
            this.groupBox23.Controls.Add(this.pb_indiziodifficile7_2);
            this.groupBox23.Controls.Add(this.pb_indiziodifficile7_1);
            this.groupBox23.Controls.Add(this.pb_indiziodifficile7_3);
            this.groupBox23.Controls.Add(this.pb_frecciavantidifficile7);
            this.groupBox23.Location = new System.Drawing.Point(6, 107);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(660, 569);
            this.groupBox23.TabIndex = 23;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Campione";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(181, 501);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(310, 13);
            this.label63.TabIndex = 17;
            this.label63.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.label63.Visible = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(210, 521);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(251, 13);
            this.label64.TabIndex = 16;
            this.label64.Text = "L’allenatore di questa squadra è Ange Postecoglou.";
            this.label64.Visible = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(203, 550);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(258, 13);
            this.label65.TabIndex = 15;
            this.label65.Text = "Questa squadra è conosciuta anche così: “gli Spurs”.";
            this.label65.Visible = false;
            // 
            // btn_opzione4difficile7
            // 
            this.btn_opzione4difficile7.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile7.Name = "btn_opzione4difficile7";
            this.btn_opzione4difficile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile7.TabIndex = 14;
            this.btn_opzione4difficile7.Text = "Atletico Madrid";
            this.btn_opzione4difficile7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile7
            // 
            this.btn_opzione3difficile7.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile7.Name = "btn_opzione3difficile7";
            this.btn_opzione3difficile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile7.TabIndex = 13;
            this.btn_opzione3difficile7.Text = "Juventus";
            this.btn_opzione3difficile7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile7
            // 
            this.btn_opzione2difficile7.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile7.Name = "btn_opzione2difficile7";
            this.btn_opzione2difficile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile7.TabIndex = 12;
            this.btn_opzione2difficile7.Text = "Inter";
            this.btn_opzione2difficile7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile7
            // 
            this.btn_opzione1difficile7.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile7.Name = "btn_opzione1difficile7";
            this.btn_opzione1difficile7.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile7.TabIndex = 11;
            this.btn_opzione1difficile7.Text = "Arsenal";
            this.btn_opzione1difficile7.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(551, 88);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(58, 13);
            this.label66.TabIndex = 26;
            this.label66.Text = "Punteggio:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(610, 88);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(25, 13);
            this.label67.TabIndex = 25;
            this.label67.Text = "100";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.label68);
            this.groupBox24.Controls.Add(this.label69);
            this.groupBox24.Controls.Add(this.label70);
            this.groupBox24.Controls.Add(this.btn_opzione4medio8);
            this.groupBox24.Controls.Add(this.btn_opzione3medio8);
            this.groupBox24.Controls.Add(this.btn_opzione2medio8);
            this.groupBox24.Controls.Add(this.btn_opzione1medio8);
            this.groupBox24.Controls.Add(this.pictureBox142);
            this.groupBox24.Controls.Add(this.pictureBox143);
            this.groupBox24.Controls.Add(this.pb_indiziomedio8_2);
            this.groupBox24.Controls.Add(this.pb_indiziomedio8_1);
            this.groupBox24.Controls.Add(this.pb_indiziomedio8_3);
            this.groupBox24.Controls.Add(this.pb_frecciavantimedio8);
            this.groupBox24.Location = new System.Drawing.Point(6, 107);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(660, 569);
            this.groupBox24.TabIndex = 23;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Esperto";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(188, 501);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(266, 13);
            this.label68.TabIndex = 17;
            this.label68.Text = "Questa squadra milita nella Liga, campionato spagnolo.";
            this.label68.Visible = false;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(188, 521);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(276, 13);
            this.label69.TabIndex = 16;
            this.label69.Text = "L’allenatore di questa squadra è Enrique Sánchez Flores.";
            this.label69.Visible = false;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(170, 550);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(302, 13);
            this.label70.TabIndex = 15;
            this.label70.Text = "Questa squadra è quella con più titoli di UEFA Europa League.";
            this.label70.Visible = false;
            // 
            // btn_opzione4medio8
            // 
            this.btn_opzione4medio8.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio8.Name = "btn_opzione4medio8";
            this.btn_opzione4medio8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio8.TabIndex = 14;
            this.btn_opzione4medio8.Text = "Inter";
            this.btn_opzione4medio8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio8
            // 
            this.btn_opzione3medio8.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio8.Name = "btn_opzione3medio8";
            this.btn_opzione3medio8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio8.TabIndex = 13;
            this.btn_opzione3medio8.Text = "Arsenal";
            this.btn_opzione3medio8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio8
            // 
            this.btn_opzione2medio8.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio8.Name = "btn_opzione2medio8";
            this.btn_opzione2medio8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio8.TabIndex = 12;
            this.btn_opzione2medio8.Text = "Marsiglia";
            this.btn_opzione2medio8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio8
            // 
            this.btn_opzione1medio8.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio8.Name = "btn_opzione1medio8";
            this.btn_opzione1medio8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio8.TabIndex = 11;
            this.btn_opzione1medio8.Text = "Roma";
            this.btn_opzione1medio8.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(551, 88);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(58, 13);
            this.label71.TabIndex = 26;
            this.label71.Text = "Punteggio:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(610, 88);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(25, 13);
            this.label72.TabIndex = 25;
            this.label72.Text = "100";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.label73);
            this.groupBox25.Controls.Add(this.label74);
            this.groupBox25.Controls.Add(this.label75);
            this.groupBox25.Controls.Add(this.btn_opzione4difficile8);
            this.groupBox25.Controls.Add(this.btn_opzione3difficile8);
            this.groupBox25.Controls.Add(this.btn_opzione2difficile8);
            this.groupBox25.Controls.Add(this.btn_opzione1difficile8);
            this.groupBox25.Controls.Add(this.pictureBox152);
            this.groupBox25.Controls.Add(this.pictureBox153);
            this.groupBox25.Controls.Add(this.pb_indiziodifficile8_2);
            this.groupBox25.Controls.Add(this.pb_indiziodifficile8_1);
            this.groupBox25.Controls.Add(this.pb_indiziodifficile8_3);
            this.groupBox25.Controls.Add(this.pb_frecciavantidifficile8);
            this.groupBox25.Location = new System.Drawing.Point(6, 107);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(660, 569);
            this.groupBox25.TabIndex = 23;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Campione";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(170, 501);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(318, 13);
            this.label73.TabIndex = 17;
            this.label73.Text = "Questa squadra milita nella Liga Portugal, campionato portoghese.";
            this.label73.Visible = false;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(207, 521);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(248, 13);
            this.label74.TabIndex = 16;
            this.label74.Text = "L’allenatore di questa squadra è Sergio Conceicao.";
            this.label74.Visible = false;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(170, 550);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(304, 13);
            this.label75.TabIndex = 15;
            this.label75.Text = "Questa squadra ha vinto due titoli di UEFA Champions League.";
            this.label75.Visible = false;
            // 
            // btn_opzione4difficile8
            // 
            this.btn_opzione4difficile8.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile8.Name = "btn_opzione4difficile8";
            this.btn_opzione4difficile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile8.TabIndex = 14;
            this.btn_opzione4difficile8.Text = "Inter";
            this.btn_opzione4difficile8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile8
            // 
            this.btn_opzione3difficile8.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile8.Name = "btn_opzione3difficile8";
            this.btn_opzione3difficile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile8.TabIndex = 13;
            this.btn_opzione3difficile8.Text = "Arsenal";
            this.btn_opzione3difficile8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile8
            // 
            this.btn_opzione2difficile8.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile8.Name = "btn_opzione2difficile8";
            this.btn_opzione2difficile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile8.TabIndex = 12;
            this.btn_opzione2difficile8.Text = "Marsiglia";
            this.btn_opzione2difficile8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile8
            // 
            this.btn_opzione1difficile8.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile8.Name = "btn_opzione1difficile8";
            this.btn_opzione1difficile8.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile8.TabIndex = 11;
            this.btn_opzione1difficile8.Text = "Roma";
            this.btn_opzione1difficile8.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(551, 88);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(58, 13);
            this.label76.TabIndex = 26;
            this.label76.Text = "Punteggio:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(610, 88);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(25, 13);
            this.label77.TabIndex = 25;
            this.label77.Text = "100";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.label78);
            this.groupBox26.Controls.Add(this.label79);
            this.groupBox26.Controls.Add(this.label80);
            this.groupBox26.Controls.Add(this.btn_opzione4medio9);
            this.groupBox26.Controls.Add(this.btn_opzione3medio9);
            this.groupBox26.Controls.Add(this.btn_opzione2medio9);
            this.groupBox26.Controls.Add(this.btn_opzione1medio9);
            this.groupBox26.Controls.Add(this.pictureBox160);
            this.groupBox26.Controls.Add(this.pictureBox161);
            this.groupBox26.Controls.Add(this.pb_indiziomedio9_2);
            this.groupBox26.Controls.Add(this.pb_indiziomedio9_1);
            this.groupBox26.Controls.Add(this.pb_indiziomedio9_3);
            this.groupBox26.Controls.Add(this.pb_frecciavantimedio9);
            this.groupBox26.Location = new System.Drawing.Point(6, 107);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(660, 569);
            this.groupBox26.TabIndex = 23;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Esperto";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(181, 501);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(310, 13);
            this.label78.TabIndex = 17;
            this.label78.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.label78.Visible = false;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(205, 521);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(258, 13);
            this.label79.TabIndex = 16;
            this.label79.Text = "L’allenatore di questa squadra è Mauricio Pochettino.";
            this.label79.Visible = false;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(197, 550);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(266, 13);
            this.label80.TabIndex = 15;
            this.label80.Text = "Questa squadra è conosciuta anche così:” The Blues”.";
            this.label80.Visible = false;
            // 
            // btn_opzione4medio9
            // 
            this.btn_opzione4medio9.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio9.Name = "btn_opzione4medio9";
            this.btn_opzione4medio9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio9.TabIndex = 14;
            this.btn_opzione4medio9.Text = "Lazio";
            this.btn_opzione4medio9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio9
            // 
            this.btn_opzione3medio9.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio9.Name = "btn_opzione3medio9";
            this.btn_opzione3medio9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio9.TabIndex = 13;
            this.btn_opzione3medio9.Text = "Atletico Madrid";
            this.btn_opzione3medio9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio9
            // 
            this.btn_opzione2medio9.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio9.Name = "btn_opzione2medio9";
            this.btn_opzione2medio9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio9.TabIndex = 12;
            this.btn_opzione2medio9.Text = "Chelsea";
            this.btn_opzione2medio9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio9
            // 
            this.btn_opzione1medio9.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio9.Name = "btn_opzione1medio9";
            this.btn_opzione1medio9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio9.TabIndex = 11;
            this.btn_opzione1medio9.Text = "Milan";
            this.btn_opzione1medio9.UseVisualStyleBackColor = true;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(551, 88);
            this.label81.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(58, 13);
            this.label81.TabIndex = 26;
            this.label81.Text = "Punteggio:";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(610, 88);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(25, 13);
            this.label82.TabIndex = 25;
            this.label82.Text = "100";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.label83);
            this.groupBox28.Controls.Add(this.label84);
            this.groupBox28.Controls.Add(this.label85);
            this.groupBox28.Controls.Add(this.btn_opzione4difficile9);
            this.groupBox28.Controls.Add(this.btn_opzione3difficile9);
            this.groupBox28.Controls.Add(this.btn_opzione2difficile9);
            this.groupBox28.Controls.Add(this.btn_opzione1difficile9);
            this.groupBox28.Controls.Add(this.pictureBox168);
            this.groupBox28.Controls.Add(this.pictureBox169);
            this.groupBox28.Controls.Add(this.pb_indiziodifficile9_2);
            this.groupBox28.Controls.Add(this.pb_indiziodifficile9_1);
            this.groupBox28.Controls.Add(this.pb_indiziodifficile9_3);
            this.groupBox28.Controls.Add(this.pb_frecciavantidifficile9);
            this.groupBox28.Location = new System.Drawing.Point(6, 107);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(660, 569);
            this.groupBox28.TabIndex = 23;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Campione";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(205, 501);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(266, 13);
            this.label83.TabIndex = 17;
            this.label83.Text = "Questa squadra milita nella Liga, campionato spagnolo.";
            this.label83.Visible = false;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(186, 521);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(305, 13);
            this.label84.TabIndex = 16;
            this.label84.Text = "L’allenatore di questa squadra è Miguel Ángel Sánchez Muñoz.";
            this.label84.Visible = false;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(196, 550);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(284, 13);
            this.label85.TabIndex = 15;
            this.label85.Text = "I colori principali di questa squadra sono il bianco e il rosso.";
            this.label85.Visible = false;
            // 
            // btn_opzione4difficile9
            // 
            this.btn_opzione4difficile9.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile9.Name = "btn_opzione4difficile9";
            this.btn_opzione4difficile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile9.TabIndex = 14;
            this.btn_opzione4difficile9.Text = "Lazio";
            this.btn_opzione4difficile9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile9
            // 
            this.btn_opzione3difficile9.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile9.Name = "btn_opzione3difficile9";
            this.btn_opzione3difficile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile9.TabIndex = 13;
            this.btn_opzione3difficile9.Text = "Atletico Madrid";
            this.btn_opzione3difficile9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile9
            // 
            this.btn_opzione2difficile9.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile9.Name = "btn_opzione2difficile9";
            this.btn_opzione2difficile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile9.TabIndex = 12;
            this.btn_opzione2difficile9.Text = "Chelsea";
            this.btn_opzione2difficile9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile9
            // 
            this.btn_opzione1difficile9.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile9.Name = "btn_opzione1difficile9";
            this.btn_opzione1difficile9.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile9.TabIndex = 11;
            this.btn_opzione1difficile9.Text = "Milan";
            this.btn_opzione1difficile9.UseVisualStyleBackColor = true;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(551, 88);
            this.label86.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(58, 13);
            this.label86.TabIndex = 26;
            this.label86.Text = "Punteggio:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(610, 88);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(25, 13);
            this.label87.TabIndex = 25;
            this.label87.Text = "100";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.label88);
            this.groupBox29.Controls.Add(this.label89);
            this.groupBox29.Controls.Add(this.label90);
            this.groupBox29.Controls.Add(this.btn_opzione4medio10);
            this.groupBox29.Controls.Add(this.btn_opzione3medio10);
            this.groupBox29.Controls.Add(this.btn_opzione2medio10);
            this.groupBox29.Controls.Add(this.btn_opzione1medio10);
            this.groupBox29.Controls.Add(this.pictureBox176);
            this.groupBox29.Controls.Add(this.pictureBox177);
            this.groupBox29.Controls.Add(this.pb_indiziomedio10_2);
            this.groupBox29.Controls.Add(this.pb_indiziomedio10_1);
            this.groupBox29.Controls.Add(this.pb_indiziomedio10_3);
            this.groupBox29.Location = new System.Drawing.Point(6, 107);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(660, 569);
            this.groupBox29.TabIndex = 23;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Esperto";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(163, 501);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(315, 13);
            this.label88.TabIndex = 17;
            this.label88.Text = "Questa squadra milita nella Liga Portugal, campionato portogese. ";
            this.label88.Visible = false;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(209, 521);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(234, 13);
            this.label89.TabIndex = 16;
            this.label89.Text = "L’allenatore di questa squadra è Roger Schmidt.";
            this.label89.Visible = false;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(180, 553);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(278, 13);
            this.label90.TabIndex = 15;
            this.label90.Text = "Questa è la squadra che detiene più titoli di Liga Portugal.";
            this.label90.Visible = false;
            // 
            // btn_opzione4medio10
            // 
            this.btn_opzione4medio10.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4medio10.Name = "btn_opzione4medio10";
            this.btn_opzione4medio10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4medio10.TabIndex = 14;
            this.btn_opzione4medio10.Text = "Bayer Leverkusen";
            this.btn_opzione4medio10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3medio10
            // 
            this.btn_opzione3medio10.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3medio10.Name = "btn_opzione3medio10";
            this.btn_opzione3medio10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3medio10.TabIndex = 13;
            this.btn_opzione3medio10.Text = "Arsenal";
            this.btn_opzione3medio10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2medio10
            // 
            this.btn_opzione2medio10.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2medio10.Name = "btn_opzione2medio10";
            this.btn_opzione2medio10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2medio10.TabIndex = 12;
            this.btn_opzione2medio10.Text = "Borussia Dortmund";
            this.btn_opzione2medio10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1medio10
            // 
            this.btn_opzione1medio10.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1medio10.Name = "btn_opzione1medio10";
            this.btn_opzione1medio10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1medio10.TabIndex = 11;
            this.btn_opzione1medio10.Text = "Bayern Monaco";
            this.btn_opzione1medio10.UseVisualStyleBackColor = true;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(551, 88);
            this.label91.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(58, 13);
            this.label91.TabIndex = 26;
            this.label91.Text = "Punteggio:";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(610, 88);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(25, 13);
            this.label92.TabIndex = 25;
            this.label92.Text = "100";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.label93);
            this.groupBox30.Controls.Add(this.label94);
            this.groupBox30.Controls.Add(this.label95);
            this.groupBox30.Controls.Add(this.btn_opzione4difficile10);
            this.groupBox30.Controls.Add(this.btn_opzione3difficile10);
            this.groupBox30.Controls.Add(this.btn_opzione2difficile10);
            this.groupBox30.Controls.Add(this.btn_opzione1difficile10);
            this.groupBox30.Controls.Add(this.pictureBox183);
            this.groupBox30.Controls.Add(this.pictureBox184);
            this.groupBox30.Controls.Add(this.pb_indiziodifficile10_2);
            this.groupBox30.Controls.Add(this.pb_indiziodifficile10_1);
            this.groupBox30.Controls.Add(this.pb_indiziodifficile10_3);
            this.groupBox30.Location = new System.Drawing.Point(6, 107);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(660, 569);
            this.groupBox30.TabIndex = 23;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Campione";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(168, 501);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(318, 13);
            this.label93.TabIndex = 17;
            this.label93.Text = "Questa squadra milita nella Liga Portugal, campionato portoghese.";
            this.label93.Visible = false;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(210, 521);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(233, 13);
            this.label94.TabIndex = 16;
            this.label94.Text = "L’allenatore di questa squadra è Ruben Amorim.";
            this.label94.Visible = false;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(179, 553);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(286, 13);
            this.label95.TabIndex = 15;
            this.label95.Text = "I colori principali di questa squadra sono il bianco e il verde.";
            this.label95.Visible = false;
            // 
            // btn_opzione4difficile10
            // 
            this.btn_opzione4difficile10.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile10.Name = "btn_opzione4difficile10";
            this.btn_opzione4difficile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile10.TabIndex = 14;
            this.btn_opzione4difficile10.Text = "Bayer Leverkusen";
            this.btn_opzione4difficile10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile10
            // 
            this.btn_opzione3difficile10.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile10.Name = "btn_opzione3difficile10";
            this.btn_opzione3difficile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile10.TabIndex = 13;
            this.btn_opzione3difficile10.Text = "Arsenal";
            this.btn_opzione3difficile10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile10
            // 
            this.btn_opzione2difficile10.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile10.Name = "btn_opzione2difficile10";
            this.btn_opzione2difficile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile10.TabIndex = 12;
            this.btn_opzione2difficile10.Text = "Borussia Dortmund";
            this.btn_opzione2difficile10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile10
            // 
            this.btn_opzione1difficile10.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile10.Name = "btn_opzione1difficile10";
            this.btn_opzione1difficile10.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile10.TabIndex = 11;
            this.btn_opzione1difficile10.Text = "Bayern Monaco";
            this.btn_opzione1difficile10.UseVisualStyleBackColor = true;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(540, 79);
            this.label96.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(113, 13);
            this.label96.TabIndex = 32;
            this.label96.Text = "CAMBIA GIOCATORE";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(19, 79);
            this.label97.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(109, 13);
            this.label97.TabIndex = 31;
            this.label97.Text = "TORNA ALLA HOME";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(490, 605);
            this.label98.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(163, 13);
            this.label98.TabIndex = 30;
            this.label98.Text = "PASSA AL LIVELLO CAMPIONE";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(19, 605);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(182, 13);
            this.label99.TabIndex = 29;
            this.label99.Text = "PASSA AL LIVELLO PRINCIPIANTE";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(313, 185);
            this.label100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(74, 13);
            this.label100.TabIndex = 28;
            this.label100.Text = "PUNTEGGIO ";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(133, 163);
            this.label101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(427, 13);
            this.label101.TabIndex = 27;
            this.label101.Text = "COMPLIMENTI HAI FINITO IL LIVELLO ESPERTO, IL TUO PUNTEGGIO FINALE È DI:";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(540, 79);
            this.label102.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(113, 13);
            this.label102.TabIndex = 32;
            this.label102.Text = "CAMBIA GIOCATORE";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(19, 79);
            this.label103.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(109, 13);
            this.label103.TabIndex = 31;
            this.label103.Text = "TORNA ALLA HOME";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(471, 605);
            this.label104.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(182, 13);
            this.label104.TabIndex = 30;
            this.label104.Text = "PASSA AL LIVELLO PRINCIPIANTE";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(19, 605);
            this.label105.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(158, 13);
            this.label105.TabIndex = 29;
            this.label105.Text = "PASSA AL LIVELLO ESPERTO";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(313, 185);
            this.label106.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(74, 13);
            this.label106.TabIndex = 28;
            this.label106.Text = "PUNTEGGIO ";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(129, 161);
            this.label107.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(432, 13);
            this.label107.TabIndex = 27;
            this.label107.Text = "COMPLIMENTI HAI FINITO IL LIVELLO CAMPIONE, IL TUO PUNTEGGIO FINALE È DI:";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(551, 88);
            this.label108.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(58, 13);
            this.label108.TabIndex = 29;
            this.label108.Text = "Punteggio:";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(610, 88);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(25, 13);
            this.label109.TabIndex = 28;
            this.label109.Text = "100";
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.label110);
            this.groupBox31.Controls.Add(this.label111);
            this.groupBox31.Controls.Add(this.label112);
            this.groupBox31.Controls.Add(this.label113);
            this.groupBox31.Controls.Add(this.btn_opzione4difficile1);
            this.groupBox31.Controls.Add(this.btn_opzione3difficile1);
            this.groupBox31.Controls.Add(this.btn_opzione2difficile1);
            this.groupBox31.Controls.Add(this.btn_opzione1difficile1);
            this.groupBox31.Controls.Add(this.pictureBox198);
            this.groupBox31.Controls.Add(this.pb_indiziodifficile1_2);
            this.groupBox31.Controls.Add(this.pb_indiziodifficile1_1);
            this.groupBox31.Controls.Add(this.pb_indiziodifficile1_3);
            this.groupBox31.Controls.Add(this.pb_frecciavantidifficile1);
            this.groupBox31.Location = new System.Drawing.Point(6, 107);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(660, 569);
            this.groupBox31.TabIndex = 26;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Campione";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(161, 550);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(316, 13);
            this.label110.TabIndex = 12;
            this.label110.Text = "Questa è la squadra che detiene più titoli di Roshn Saudi League.";
            this.label110.Visible = false;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(161, 501);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(330, 13);
            this.label111.TabIndex = 11;
            this.label111.Text = "Questa squadra milita nella Roshn Saudi League, campionato arabo.";
            this.label111.Visible = false;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(208, 521);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(220, 13);
            this.label112.TabIndex = 10;
            this.label112.Text = "L’allenatore di questa squadra è Jorge Jesus.";
            this.label112.Visible = false;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(315, 542);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(0, 13);
            this.label113.TabIndex = 9;
            // 
            // btn_opzione4difficile1
            // 
            this.btn_opzione4difficile1.Location = new System.Drawing.Point(359, 415);
            this.btn_opzione4difficile1.Name = "btn_opzione4difficile1";
            this.btn_opzione4difficile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile1.TabIndex = 8;
            this.btn_opzione4difficile1.Text = "Chelsea";
            this.btn_opzione4difficile1.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile1
            // 
            this.btn_opzione3difficile1.Location = new System.Drawing.Point(109, 415);
            this.btn_opzione3difficile1.Name = "btn_opzione3difficile1";
            this.btn_opzione3difficile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile1.TabIndex = 7;
            this.btn_opzione3difficile1.Text = "Atletich Bilbao";
            this.btn_opzione3difficile1.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile1
            // 
            this.btn_opzione2difficile1.Location = new System.Drawing.Point(360, 344);
            this.btn_opzione2difficile1.Name = "btn_opzione2difficile1";
            this.btn_opzione2difficile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile1.TabIndex = 6;
            this.btn_opzione2difficile1.Text = "Atletico Madrid";
            this.btn_opzione2difficile1.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile1
            // 
            this.btn_opzione1difficile1.Location = new System.Drawing.Point(109, 344);
            this.btn_opzione1difficile1.Name = "btn_opzione1difficile1";
            this.btn_opzione1difficile1.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile1.TabIndex = 5;
            this.btn_opzione1difficile1.Text = "Arsenal";
            this.btn_opzione1difficile1.UseVisualStyleBackColor = true;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(551, 88);
            this.label114.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(58, 13);
            this.label114.TabIndex = 31;
            this.label114.Text = "Punteggio:";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(610, 88);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(25, 13);
            this.label115.TabIndex = 30;
            this.label115.Text = "100";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.label116);
            this.groupBox32.Controls.Add(this.label117);
            this.groupBox32.Controls.Add(this.label118);
            this.groupBox32.Controls.Add(this.btn_opzione4difficile2);
            this.groupBox32.Controls.Add(this.btn_opzione3difficile2);
            this.groupBox32.Controls.Add(this.btn_opzione2difficile2);
            this.groupBox32.Controls.Add(this.btn_opzione1difficile2);
            this.groupBox32.Controls.Add(this.pictureBox205);
            this.groupBox32.Controls.Add(this.pictureBox206);
            this.groupBox32.Controls.Add(this.pb_indiziodifficile2_2);
            this.groupBox32.Controls.Add(this.pb_indiziodifficile2_1);
            this.groupBox32.Controls.Add(this.pb_indiziodifficile2_3);
            this.groupBox32.Controls.Add(this.pb_frecciavantidifficile2);
            this.groupBox32.Location = new System.Drawing.Point(6, 107);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(660, 569);
            this.groupBox32.TabIndex = 28;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Campione";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(190, 501);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(268, 13);
            this.label116.TabIndex = 17;
            this.label116.Text = "Questa squadra milita in MLS, campionato statunitense.";
            this.label116.Visible = false;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(207, 521);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(240, 13);
            this.label117.TabIndex = 16;
            this.label117.Text = "L’allenatore di questa squadra è Gerardo Martino.";
            this.label117.Visible = false;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(170, 550);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(320, 13);
            this.label118.TabIndex = 15;
            this.label118.Text = "In questa squadra gioca il giocatore che ha vinto più Palloni d’Oro.";
            this.label118.Visible = false;
            // 
            // btn_opzione4difficile2
            // 
            this.btn_opzione4difficile2.Location = new System.Drawing.Point(359, 410);
            this.btn_opzione4difficile2.Name = "btn_opzione4difficile2";
            this.btn_opzione4difficile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile2.TabIndex = 14;
            this.btn_opzione4difficile2.Text = "Lipsia";
            this.btn_opzione4difficile2.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile2
            // 
            this.btn_opzione3difficile2.Location = new System.Drawing.Point(109, 410);
            this.btn_opzione3difficile2.Name = "btn_opzione3difficile2";
            this.btn_opzione3difficile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile2.TabIndex = 13;
            this.btn_opzione3difficile2.Text = "Bayer Leverkusen";
            this.btn_opzione3difficile2.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile2
            // 
            this.btn_opzione2difficile2.Location = new System.Drawing.Point(360, 339);
            this.btn_opzione2difficile2.Name = "btn_opzione2difficile2";
            this.btn_opzione2difficile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile2.TabIndex = 12;
            this.btn_opzione2difficile2.Text = "Lazio";
            this.btn_opzione2difficile2.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile2
            // 
            this.btn_opzione1difficile2.Location = new System.Drawing.Point(109, 339);
            this.btn_opzione1difficile2.Name = "btn_opzione1difficile2";
            this.btn_opzione1difficile2.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile2.TabIndex = 11;
            this.btn_opzione1difficile2.Text = "Manchester United";
            this.btn_opzione1difficile2.UseVisualStyleBackColor = true;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(551, 88);
            this.label119.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(58, 13);
            this.label119.TabIndex = 29;
            this.label119.Text = "Punteggio:";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(610, 88);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(25, 13);
            this.label120.TabIndex = 28;
            this.label120.Text = "100";
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.pictureBox213);
            this.groupBox33.Controls.Add(this.label121);
            this.groupBox33.Controls.Add(this.label122);
            this.groupBox33.Controls.Add(this.label123);
            this.groupBox33.Controls.Add(this.label124);
            this.groupBox33.Controls.Add(this.btn_opzione4difficile3);
            this.groupBox33.Controls.Add(this.btn_opzione3difficile3);
            this.groupBox33.Controls.Add(this.btn_opzione2difficile3);
            this.groupBox33.Controls.Add(this.btn_opzione1difficile3);
            this.groupBox33.Controls.Add(this.pictureBox214);
            this.groupBox33.Controls.Add(this.pb_indiziodifficile3_2);
            this.groupBox33.Controls.Add(this.pb_indiziodifficile3_1);
            this.groupBox33.Controls.Add(this.pb_indiziodifficile3_3);
            this.groupBox33.Controls.Add(this.pb_frecciavantidifficile3);
            this.groupBox33.Location = new System.Drawing.Point(6, 107);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(660, 569);
            this.groupBox33.TabIndex = 26;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Campione";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(131, 550);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(411, 13);
            this.label121.TabIndex = 12;
            this.label121.Text = "In questa squadra gioca il giocatore che ha segnato più gol in tutta la storia de" +
    "l calcio.";
            this.label121.Visible = false;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(175, 501);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(316, 13);
            this.label122.TabIndex = 11;
            this.label122.Text = "Questa squadra milita in Roshn Saudi League, campionato arabo.";
            this.label122.Visible = false;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(211, 521);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(216, 13);
            this.label123.TabIndex = 10;
            this.label123.Text = "L’allenatore di questa squadra è Luis Castro.";
            this.label123.Visible = false;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(315, 542);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(0, 13);
            this.label124.TabIndex = 9;
            // 
            // btn_opzione4difficile3
            // 
            this.btn_opzione4difficile3.Location = new System.Drawing.Point(359, 415);
            this.btn_opzione4difficile3.Name = "btn_opzione4difficile3";
            this.btn_opzione4difficile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione4difficile3.TabIndex = 8;
            this.btn_opzione4difficile3.Text = "West-Ham";
            this.btn_opzione4difficile3.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3difficile3
            // 
            this.btn_opzione3difficile3.Location = new System.Drawing.Point(109, 415);
            this.btn_opzione3difficile3.Name = "btn_opzione3difficile3";
            this.btn_opzione3difficile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione3difficile3.TabIndex = 7;
            this.btn_opzione3difficile3.Text = "Benfica";
            this.btn_opzione3difficile3.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2difficile3
            // 
            this.btn_opzione2difficile3.Location = new System.Drawing.Point(360, 344);
            this.btn_opzione2difficile3.Name = "btn_opzione2difficile3";
            this.btn_opzione2difficile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione2difficile3.TabIndex = 6;
            this.btn_opzione2difficile3.Text = "Fiorentina";
            this.btn_opzione2difficile3.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1difficile3
            // 
            this.btn_opzione1difficile3.Location = new System.Drawing.Point(109, 344);
            this.btn_opzione1difficile3.Name = "btn_opzione1difficile3";
            this.btn_opzione1difficile3.Size = new System.Drawing.Size(192, 46);
            this.btn_opzione1difficile3.TabIndex = 5;
            this.btn_opzione1difficile3.Text = "Roma";
            this.btn_opzione1difficile3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(47, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(245, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 156);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(267, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 128);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(482, 287);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 128);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(267, 287);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 128);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(48, 287);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(131, 128);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(48, 153);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(131, 128);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(482, 19);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(131, 128);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(48, 19);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(131, 128);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(267, 19);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(131, 128);
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(482, 153);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(131, 128);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(267, 153);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(131, 128);
            this.pictureBox13.TabIndex = 22;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(191, 0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(299, 151);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(267, 421);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(131, 128);
            this.pictureBox15.TabIndex = 31;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(482, 287);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(131, 128);
            this.pictureBox16.TabIndex = 30;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(267, 287);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(131, 128);
            this.pictureBox17.TabIndex = 29;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox18.Location = new System.Drawing.Point(48, 287);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(131, 128);
            this.pictureBox18.TabIndex = 28;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.Location = new System.Drawing.Point(48, 153);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(131, 128);
            this.pictureBox19.TabIndex = 27;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox20.Location = new System.Drawing.Point(482, 19);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(131, 128);
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox21.Location = new System.Drawing.Point(48, 19);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(131, 128);
            this.pictureBox21.TabIndex = 25;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox22.Location = new System.Drawing.Point(267, 19);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(131, 128);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox23.Location = new System.Drawing.Point(482, 153);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(131, 128);
            this.pictureBox23.TabIndex = 23;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(267, 153);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(131, 128);
            this.pictureBox24.TabIndex = 22;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox25.Location = new System.Drawing.Point(191, 3);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(299, 151);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox25.TabIndex = 32;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox26.Location = new System.Drawing.Point(267, 421);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(131, 128);
            this.pictureBox26.TabIndex = 31;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox27.Location = new System.Drawing.Point(482, 287);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(131, 128);
            this.pictureBox27.TabIndex = 30;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox28.Location = new System.Drawing.Point(267, 287);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(131, 128);
            this.pictureBox28.TabIndex = 29;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox29.Location = new System.Drawing.Point(48, 287);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(131, 128);
            this.pictureBox29.TabIndex = 28;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox30.Location = new System.Drawing.Point(48, 153);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(131, 128);
            this.pictureBox30.TabIndex = 27;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox31.Location = new System.Drawing.Point(482, 19);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(131, 128);
            this.pictureBox31.TabIndex = 26;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox32.Location = new System.Drawing.Point(48, 19);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(131, 128);
            this.pictureBox32.TabIndex = 25;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox33.Location = new System.Drawing.Point(267, 19);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(131, 128);
            this.pictureBox33.TabIndex = 24;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox34.Location = new System.Drawing.Point(482, 153);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(131, 128);
            this.pictureBox34.TabIndex = 23;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackgroundImage = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox35.Location = new System.Drawing.Point(267, 153);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(131, 128);
            this.pictureBox35.TabIndex = 22;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox36.Location = new System.Drawing.Point(191, 3);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(299, 151);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox36.TabIndex = 32;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackgroundImage = global::Football_Quiz.Properties.Resources.real_madrid;
            this.pictureBox37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox37.Location = new System.Drawing.Point(109, 24);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(443, 292);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 4;
            this.pictureBox37.TabStop = false;
            // 
            // pb_indiziofacile1_2
            // 
            this.pb_indiziofacile1_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile1_2.Location = new System.Drawing.Point(606, 349);
            this.pb_indiziofacile1_2.Name = "pb_indiziofacile1_2";
            this.pb_indiziofacile1_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile1_2.TabIndex = 3;
            this.pb_indiziofacile1_2.TabStop = false;
            this.pb_indiziofacile1_2.Click += new System.EventHandler(this.pb_indiziofacile1_2_Click);
            // 
            // pb_inzidiofacile1
            // 
            this.pb_inzidiofacile1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_inzidiofacile1.Location = new System.Drawing.Point(606, 290);
            this.pb_inzidiofacile1.Name = "pb_inzidiofacile1";
            this.pb_inzidiofacile1.Size = new System.Drawing.Size(48, 53);
            this.pb_inzidiofacile1.TabIndex = 2;
            this.pb_inzidiofacile1.TabStop = false;
            this.pb_inzidiofacile1.Click += new System.EventHandler(this.pb_inzidiofacile1_Click);
            // 
            // pb_indiziofacile1_3
            // 
            this.pb_indiziofacile1_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile1_3.Location = new System.Drawing.Point(606, 408);
            this.pb_indiziofacile1_3.Name = "pb_indiziofacile1_3";
            this.pb_indiziofacile1_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile1_3.TabIndex = 1;
            this.pb_indiziofacile1_3.TabStop = false;
            this.pb_indiziofacile1_3.Click += new System.EventHandler(this.pb_indiziofacile1_3_Click);
            // 
            // pb_frecciavanti1facile
            // 
            this.pb_frecciavanti1facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview;
            this.pb_frecciavanti1facile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_frecciavanti1facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti1facile.Name = "pb_frecciavanti1facile";
            this.pb_frecciavanti1facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti1facile.TabIndex = 0;
            this.pb_frecciavanti1facile.TabStop = false;
            this.pb_frecciavanti1facile.Click += new System.EventHandler(this.pb_frecciavanti1facile_Click);
            // 
            // pictureBox97
            // 
            this.pictureBox97.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox97.Location = new System.Drawing.Point(12, 21);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(60, 62);
            this.pictureBox97.TabIndex = 17;
            this.pictureBox97.TabStop = false;
            this.pictureBox97.Click += new System.EventHandler(this.pictureBox97_Click);
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_1_removebg_preview;
            this.pictureBox47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox47.Location = new System.Drawing.Point(179, 21);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(318, 80);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox47.TabIndex = 15;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackgroundImage = global::Football_Quiz.Properties.Resources.manchester_city1;
            this.pictureBox42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox42.Location = new System.Drawing.Point(109, 19);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(443, 292);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox42.TabIndex = 10;
            this.pictureBox42.TabStop = false;
            // 
            // pb_frecciaind2
            // 
            this.pb_frecciaind2.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview1;
            this.pb_frecciaind2.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind2.Name = "pb_frecciaind2";
            this.pb_frecciaind2.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind2.TabIndex = 4;
            this.pb_frecciaind2.TabStop = false;
            this.pb_frecciaind2.Click += new System.EventHandler(this.pb_frecciaind2_Click);
            // 
            // pb_indiziofacile2_2
            // 
            this.pb_indiziofacile2_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview1;
            this.pb_indiziofacile2_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile2_2.Name = "pb_indiziofacile2_2";
            this.pb_indiziofacile2_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile2_2.TabIndex = 3;
            this.pb_indiziofacile2_2.TabStop = false;
            this.pb_indiziofacile2_2.Click += new System.EventHandler(this.pb_indiziofacile2_2_Click);
            // 
            // pb_indiziofacile2_1
            // 
            this.pb_indiziofacile2_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview1;
            this.pb_indiziofacile2_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile2_1.Name = "pb_indiziofacile2_1";
            this.pb_indiziofacile2_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile2_1.TabIndex = 2;
            this.pb_indiziofacile2_1.TabStop = false;
            this.pb_indiziofacile2_1.Click += new System.EventHandler(this.pb_indiziofacile2_1_Click);
            // 
            // pb_indiziofacile2_3
            // 
            this.pb_indiziofacile2_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview1;
            this.pb_indiziofacile2_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile2_3.Name = "pb_indiziofacile2_3";
            this.pb_indiziofacile2_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile2_3.TabIndex = 1;
            this.pb_indiziofacile2_3.TabStop = false;
            this.pb_indiziofacile2_3.Click += new System.EventHandler(this.pb_indiziofacile2_3_Click);
            // 
            // pb_frecciavanti2facile
            // 
            this.pb_frecciavanti2facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview12;
            this.pb_frecciavanti2facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti2facile.Name = "pb_frecciavanti2facile";
            this.pb_frecciavanti2facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti2facile.TabIndex = 0;
            this.pb_frecciavanti2facile.TabStop = false;
            this.pb_frecciavanti2facile.Click += new System.EventHandler(this.pb_frecciavanti2facile_Click);
            // 
            // pictureBox98
            // 
            this.pictureBox98.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview1;
            this.pictureBox98.Location = new System.Drawing.Point(12, 21);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(60, 62);
            this.pictureBox98.TabIndex = 5;
            this.pictureBox98.TabStop = false;
            this.pictureBox98.Click += new System.EventHandler(this.pictureBox98_Click);
            // 
            // pictureBox48
            // 
            this.pictureBox48.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_2_removebg_preview__1_1;
            this.pictureBox48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox48.Location = new System.Drawing.Point(179, 21);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(318, 80);
            this.pictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox48.TabIndex = 17;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackgroundImage = global::Football_Quiz.Properties.Resources.psg1;
            this.pictureBox46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox46.Location = new System.Drawing.Point(109, 19);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(443, 292);
            this.pictureBox46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox46.TabIndex = 10;
            this.pictureBox46.TabStop = false;
            // 
            // pb_frecciaind3
            // 
            this.pb_frecciaind3.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview2;
            this.pb_frecciaind3.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind3.Name = "pb_frecciaind3";
            this.pb_frecciaind3.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind3.TabIndex = 4;
            this.pb_frecciaind3.TabStop = false;
            this.pb_frecciaind3.Click += new System.EventHandler(this.pb_frecciaind3_Click);
            // 
            // pb_indiziofacile3_2
            // 
            this.pb_indiziofacile3_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview2;
            this.pb_indiziofacile3_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile3_2.Name = "pb_indiziofacile3_2";
            this.pb_indiziofacile3_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile3_2.TabIndex = 3;
            this.pb_indiziofacile3_2.TabStop = false;
            this.pb_indiziofacile3_2.Click += new System.EventHandler(this.pb_indiziofacile3_2_Click);
            // 
            // pb_indiziofacile3_1
            // 
            this.pb_indiziofacile3_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview2;
            this.pb_indiziofacile3_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile3_1.Name = "pb_indiziofacile3_1";
            this.pb_indiziofacile3_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile3_1.TabIndex = 2;
            this.pb_indiziofacile3_1.TabStop = false;
            this.pb_indiziofacile3_1.Click += new System.EventHandler(this.pb_indiziofacile3_1_Click);
            // 
            // pb_indiziofacile3_3
            // 
            this.pb_indiziofacile3_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview2;
            this.pb_indiziofacile3_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile3_3.Name = "pb_indiziofacile3_3";
            this.pb_indiziofacile3_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile3_3.TabIndex = 1;
            this.pb_indiziofacile3_3.TabStop = false;
            this.pb_indiziofacile3_3.Click += new System.EventHandler(this.pb_indiziofacile3_3_Click);
            // 
            // pb_frecciavanti3facile
            // 
            this.pb_frecciavanti3facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview13;
            this.pb_frecciavanti3facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti3facile.Name = "pb_frecciavanti3facile";
            this.pb_frecciavanti3facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti3facile.TabIndex = 0;
            this.pb_frecciavanti3facile.TabStop = false;
            this.pb_frecciavanti3facile.Click += new System.EventHandler(this.pb_frecciavanti3facile_Click);
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview2;
            this.pictureBox41.Location = new System.Drawing.Point(12, 21);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(60, 62);
            this.pictureBox41.TabIndex = 19;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Click += new System.EventHandler(this.pictureBox41_Click);
            // 
            // pictureBox54
            // 
            this.pictureBox54.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_3_removebg_preview__1_1;
            this.pictureBox54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox54.Location = new System.Drawing.Point(179, 21);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(318, 80);
            this.pictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox54.TabIndex = 17;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackgroundImage = global::Football_Quiz.Properties.Resources.bayern_monaco1;
            this.pictureBox49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox49.Location = new System.Drawing.Point(109, 19);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(443, 292);
            this.pictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox49.TabIndex = 10;
            this.pictureBox49.TabStop = false;
            // 
            // pb_frecciaind4
            // 
            this.pb_frecciaind4.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview3;
            this.pb_frecciaind4.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind4.Name = "pb_frecciaind4";
            this.pb_frecciaind4.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind4.TabIndex = 4;
            this.pb_frecciaind4.TabStop = false;
            this.pb_frecciaind4.Click += new System.EventHandler(this.pb_frecciaind4_Click);
            // 
            // pb_indiziofacile4_2
            // 
            this.pb_indiziofacile4_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziofacile4_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile4_2.Name = "pb_indiziofacile4_2";
            this.pb_indiziofacile4_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile4_2.TabIndex = 3;
            this.pb_indiziofacile4_2.TabStop = false;
            this.pb_indiziofacile4_2.Click += new System.EventHandler(this.pb_indiziofacile4_2_Click);
            // 
            // pb_indiziofacile4_1
            // 
            this.pb_indiziofacile4_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziofacile4_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile4_1.Name = "pb_indiziofacile4_1";
            this.pb_indiziofacile4_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile4_1.TabIndex = 2;
            this.pb_indiziofacile4_1.TabStop = false;
            this.pb_indiziofacile4_1.Click += new System.EventHandler(this.pb_indiziofacile4_1_Click);
            // 
            // pb_indiziofacile4_3
            // 
            this.pb_indiziofacile4_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziofacile4_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile4_3.Name = "pb_indiziofacile4_3";
            this.pb_indiziofacile4_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile4_3.TabIndex = 1;
            this.pb_indiziofacile4_3.TabStop = false;
            this.pb_indiziofacile4_3.Click += new System.EventHandler(this.pb_indiziofacile4_3_Click);
            // 
            // pb_frecciavanti4facile
            // 
            this.pb_frecciavanti4facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview14;
            this.pb_frecciavanti4facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti4facile.Name = "pb_frecciavanti4facile";
            this.pb_frecciavanti4facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti4facile.TabIndex = 0;
            this.pb_frecciavanti4facile.TabStop = false;
            this.pb_frecciavanti4facile.Click += new System.EventHandler(this.pb_frecciavanti4facile_Click);
            // 
            // pictureBox99
            // 
            this.pictureBox99.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview3;
            this.pictureBox99.Location = new System.Drawing.Point(12, 21);
            this.pictureBox99.Name = "pictureBox99";
            this.pictureBox99.Size = new System.Drawing.Size(60, 62);
            this.pictureBox99.TabIndex = 19;
            this.pictureBox99.TabStop = false;
            this.pictureBox99.Click += new System.EventHandler(this.pictureBox99_Click);
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_4_removebg_preview__1_1;
            this.pictureBox60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox60.Location = new System.Drawing.Point(179, 21);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(318, 80);
            this.pictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox60.TabIndex = 17;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackgroundImage = global::Football_Quiz.Properties.Resources.barcellona1;
            this.pictureBox53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox53.Location = new System.Drawing.Point(109, 19);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(443, 292);
            this.pictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox53.TabIndex = 10;
            this.pictureBox53.TabStop = false;
            // 
            // pb_frecciaind5
            // 
            this.pb_frecciaind5.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview4;
            this.pb_frecciaind5.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind5.Name = "pb_frecciaind5";
            this.pb_frecciaind5.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind5.TabIndex = 4;
            this.pb_frecciaind5.TabStop = false;
            this.pb_frecciaind5.Click += new System.EventHandler(this.pb_frecciaind5_Click);
            // 
            // pb_indiziofacile5_2
            // 
            this.pb_indiziofacile5_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziofacile5_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile5_2.Name = "pb_indiziofacile5_2";
            this.pb_indiziofacile5_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile5_2.TabIndex = 3;
            this.pb_indiziofacile5_2.TabStop = false;
            this.pb_indiziofacile5_2.Click += new System.EventHandler(this.pb_indiziofacile5_2_Click);
            // 
            // pb_indiziofacile5_1
            // 
            this.pb_indiziofacile5_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziofacile5_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile5_1.Name = "pb_indiziofacile5_1";
            this.pb_indiziofacile5_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile5_1.TabIndex = 2;
            this.pb_indiziofacile5_1.TabStop = false;
            this.pb_indiziofacile5_1.Click += new System.EventHandler(this.pb_indiziofacile5_1_Click);
            // 
            // pb_indiziofacile5_3
            // 
            this.pb_indiziofacile5_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziofacile5_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile5_3.Name = "pb_indiziofacile5_3";
            this.pb_indiziofacile5_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile5_3.TabIndex = 1;
            this.pb_indiziofacile5_3.TabStop = false;
            this.pb_indiziofacile5_3.Click += new System.EventHandler(this.pb_indiziofacile5_3_Click);
            // 
            // pb_frecciavanti5facile
            // 
            this.pb_frecciavanti5facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview15;
            this.pb_frecciavanti5facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti5facile.Name = "pb_frecciavanti5facile";
            this.pb_frecciavanti5facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti5facile.TabIndex = 0;
            this.pb_frecciavanti5facile.TabStop = false;
            this.pb_frecciavanti5facile.Click += new System.EventHandler(this.pb_frecciavanti5facile_Click);
            // 
            // pictureBox100
            // 
            this.pictureBox100.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview4;
            this.pictureBox100.Location = new System.Drawing.Point(12, 21);
            this.pictureBox100.Name = "pictureBox100";
            this.pictureBox100.Size = new System.Drawing.Size(60, 62);
            this.pictureBox100.TabIndex = 19;
            this.pictureBox100.TabStop = false;
            this.pictureBox100.Click += new System.EventHandler(this.pictureBox100_Click);
            // 
            // pictureBox66
            // 
            this.pictureBox66.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_5_removebg_preview__1_1;
            this.pictureBox66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox66.Location = new System.Drawing.Point(179, 21);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(318, 80);
            this.pictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox66.TabIndex = 17;
            this.pictureBox66.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackgroundImage = global::Football_Quiz.Properties.Resources.liverpool1;
            this.pictureBox55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox55.Location = new System.Drawing.Point(109, 19);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(443, 292);
            this.pictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox55.TabIndex = 10;
            this.pictureBox55.TabStop = false;
            // 
            // pb_frecciaind6
            // 
            this.pb_frecciaind6.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview5;
            this.pb_frecciaind6.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind6.Name = "pb_frecciaind6";
            this.pb_frecciaind6.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind6.TabIndex = 4;
            this.pb_frecciaind6.TabStop = false;
            this.pb_frecciaind6.Click += new System.EventHandler(this.pb_frecciaind6_Click);
            // 
            // pb_indiziofacile6_2
            // 
            this.pb_indiziofacile6_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziofacile6_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile6_2.Name = "pb_indiziofacile6_2";
            this.pb_indiziofacile6_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile6_2.TabIndex = 3;
            this.pb_indiziofacile6_2.TabStop = false;
            this.pb_indiziofacile6_2.Click += new System.EventHandler(this.pb_indiziofacile6_2_Click);
            // 
            // pb_indiziofacile6_1
            // 
            this.pb_indiziofacile6_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziofacile6_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile6_1.Name = "pb_indiziofacile6_1";
            this.pb_indiziofacile6_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile6_1.TabIndex = 2;
            this.pb_indiziofacile6_1.TabStop = false;
            this.pb_indiziofacile6_1.Click += new System.EventHandler(this.pb_indiziofacile6_1_Click);
            // 
            // pb_indiziofacile6_3
            // 
            this.pb_indiziofacile6_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziofacile6_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile6_3.Name = "pb_indiziofacile6_3";
            this.pb_indiziofacile6_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile6_3.TabIndex = 1;
            this.pb_indiziofacile6_3.TabStop = false;
            this.pb_indiziofacile6_3.Click += new System.EventHandler(this.pb_indiziofacile6_3_Click);
            // 
            // pb_frecciavanti6facile
            // 
            this.pb_frecciavanti6facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview16;
            this.pb_frecciavanti6facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti6facile.Name = "pb_frecciavanti6facile";
            this.pb_frecciavanti6facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti6facile.TabIndex = 0;
            this.pb_frecciavanti6facile.TabStop = false;
            this.pb_frecciavanti6facile.Click += new System.EventHandler(this.pb_frecciavanti6facile_Click);
            // 
            // pictureBox101
            // 
            this.pictureBox101.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview5;
            this.pictureBox101.Location = new System.Drawing.Point(12, 21);
            this.pictureBox101.Name = "pictureBox101";
            this.pictureBox101.Size = new System.Drawing.Size(60, 62);
            this.pictureBox101.TabIndex = 19;
            this.pictureBox101.TabStop = false;
            this.pictureBox101.Click += new System.EventHandler(this.pictureBox101_Click);
            // 
            // pictureBox72
            // 
            this.pictureBox72.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_6_removebg_preview__1_2;
            this.pictureBox72.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox72.Location = new System.Drawing.Point(179, 21);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(318, 80);
            this.pictureBox72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox72.TabIndex = 17;
            this.pictureBox72.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.BackgroundImage = global::Football_Quiz.Properties.Resources.juventus1;
            this.pictureBox59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox59.Location = new System.Drawing.Point(109, 19);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(443, 292);
            this.pictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox59.TabIndex = 10;
            this.pictureBox59.TabStop = false;
            // 
            // pb_frecciaind7
            // 
            this.pb_frecciaind7.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview5;
            this.pb_frecciaind7.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind7.Name = "pb_frecciaind7";
            this.pb_frecciaind7.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind7.TabIndex = 4;
            this.pb_frecciaind7.TabStop = false;
            this.pb_frecciaind7.Click += new System.EventHandler(this.pb_frecciaind7_Click);
            // 
            // pb_indiziofacile7_2
            // 
            this.pb_indiziofacile7_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziofacile7_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile7_2.Name = "pb_indiziofacile7_2";
            this.pb_indiziofacile7_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile7_2.TabIndex = 3;
            this.pb_indiziofacile7_2.TabStop = false;
            this.pb_indiziofacile7_2.Click += new System.EventHandler(this.pb_indiziofacile7_2_Click);
            // 
            // pb_indizifacile7_1
            // 
            this.pb_indizifacile7_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indizifacile7_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indizifacile7_1.Name = "pb_indizifacile7_1";
            this.pb_indizifacile7_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indizifacile7_1.TabIndex = 2;
            this.pb_indizifacile7_1.TabStop = false;
            this.pb_indizifacile7_1.Click += new System.EventHandler(this.pb_indizifacile7_1_Click);
            // 
            // pb_indiziofacile7_3
            // 
            this.pb_indiziofacile7_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziofacile7_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile7_3.Name = "pb_indiziofacile7_3";
            this.pb_indiziofacile7_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile7_3.TabIndex = 1;
            this.pb_indiziofacile7_3.TabStop = false;
            this.pb_indiziofacile7_3.Click += new System.EventHandler(this.pb_indiziofacile7_3_Click);
            // 
            // pb_frecciavanti7facile
            // 
            this.pb_frecciavanti7facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview17;
            this.pb_frecciavanti7facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti7facile.Name = "pb_frecciavanti7facile";
            this.pb_frecciavanti7facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti7facile.TabIndex = 0;
            this.pb_frecciavanti7facile.TabStop = false;
            this.pb_frecciavanti7facile.Click += new System.EventHandler(this.pb_frecciavanti7facile_Click);
            // 
            // pictureBox102
            // 
            this.pictureBox102.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview6;
            this.pictureBox102.Location = new System.Drawing.Point(12, 21);
            this.pictureBox102.Name = "pictureBox102";
            this.pictureBox102.Size = new System.Drawing.Size(60, 62);
            this.pictureBox102.TabIndex = 19;
            this.pictureBox102.TabStop = false;
            this.pictureBox102.Click += new System.EventHandler(this.pictureBox102_Click);
            // 
            // pictureBox78
            // 
            this.pictureBox78.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_7_removebg_preview__1_1;
            this.pictureBox78.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox78.Location = new System.Drawing.Point(179, 21);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(318, 80);
            this.pictureBox78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox78.TabIndex = 17;
            this.pictureBox78.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackgroundImage = global::Football_Quiz.Properties.Resources.inter1;
            this.pictureBox61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox61.Location = new System.Drawing.Point(109, 19);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(443, 292);
            this.pictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox61.TabIndex = 10;
            this.pictureBox61.TabStop = false;
            // 
            // pb_frecciaind8
            // 
            this.pb_frecciaind8.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview6;
            this.pb_frecciaind8.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind8.Name = "pb_frecciaind8";
            this.pb_frecciaind8.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind8.TabIndex = 4;
            this.pb_frecciaind8.TabStop = false;
            this.pb_frecciaind8.Click += new System.EventHandler(this.pb_frecciaind8_Click);
            // 
            // pb_indiziofacile8_2
            // 
            this.pb_indiziofacile8_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziofacile8_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile8_2.Name = "pb_indiziofacile8_2";
            this.pb_indiziofacile8_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile8_2.TabIndex = 3;
            this.pb_indiziofacile8_2.TabStop = false;
            this.pb_indiziofacile8_2.Click += new System.EventHandler(this.pb_indiziofacile8_2_Click);
            // 
            // pb_indiziofacile8_1
            // 
            this.pb_indiziofacile8_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziofacile8_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile8_1.Name = "pb_indiziofacile8_1";
            this.pb_indiziofacile8_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile8_1.TabIndex = 2;
            this.pb_indiziofacile8_1.TabStop = false;
            this.pb_indiziofacile8_1.Click += new System.EventHandler(this.pb_indiziofacile8_1_Click);
            // 
            // pb_indiziofacile8_3
            // 
            this.pb_indiziofacile8_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziofacile8_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile8_3.Name = "pb_indiziofacile8_3";
            this.pb_indiziofacile8_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile8_3.TabIndex = 1;
            this.pb_indiziofacile8_3.TabStop = false;
            this.pb_indiziofacile8_3.Click += new System.EventHandler(this.pb_indiziofacile8_3_Click);
            // 
            // pb_frecciavanti8facile
            // 
            this.pb_frecciavanti8facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview18;
            this.pb_frecciavanti8facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti8facile.Name = "pb_frecciavanti8facile";
            this.pb_frecciavanti8facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti8facile.TabIndex = 0;
            this.pb_frecciavanti8facile.TabStop = false;
            this.pb_frecciavanti8facile.Click += new System.EventHandler(this.pb_frecciavanti8facile_Click);
            // 
            // pictureBox103
            // 
            this.pictureBox103.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview6;
            this.pictureBox103.Location = new System.Drawing.Point(12, 21);
            this.pictureBox103.Name = "pictureBox103";
            this.pictureBox103.Size = new System.Drawing.Size(60, 62);
            this.pictureBox103.TabIndex = 19;
            this.pictureBox103.TabStop = false;
            this.pictureBox103.Click += new System.EventHandler(this.pictureBox103_Click);
            // 
            // pictureBox84
            // 
            this.pictureBox84.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_8_removebg_preview__1_1;
            this.pictureBox84.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox84.Location = new System.Drawing.Point(179, 21);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(318, 80);
            this.pictureBox84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox84.TabIndex = 17;
            this.pictureBox84.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.BackgroundImage = global::Football_Quiz.Properties.Resources.milan1;
            this.pictureBox65.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox65.Location = new System.Drawing.Point(109, 19);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(443, 292);
            this.pictureBox65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox65.TabIndex = 10;
            this.pictureBox65.TabStop = false;
            // 
            // pb_frecciaind9
            // 
            this.pb_frecciaind9.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview6;
            this.pb_frecciaind9.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind9.Name = "pb_frecciaind9";
            this.pb_frecciaind9.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind9.TabIndex = 4;
            this.pb_frecciaind9.TabStop = false;
            this.pb_frecciaind9.Click += new System.EventHandler(this.pb_frecciaind9_Click);
            // 
            // pb_indiziofacile9_2
            // 
            this.pb_indiziofacile9_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziofacile9_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile9_2.Name = "pb_indiziofacile9_2";
            this.pb_indiziofacile9_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile9_2.TabIndex = 3;
            this.pb_indiziofacile9_2.TabStop = false;
            this.pb_indiziofacile9_2.Click += new System.EventHandler(this.pb_indiziofacile9_2_Click);
            // 
            // pb_indiziofacile9_1
            // 
            this.pb_indiziofacile9_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziofacile9_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile9_1.Name = "pb_indiziofacile9_1";
            this.pb_indiziofacile9_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile9_1.TabIndex = 2;
            this.pb_indiziofacile9_1.TabStop = false;
            this.pb_indiziofacile9_1.Click += new System.EventHandler(this.pb_indiziofacile9_1_Click);
            // 
            // pb_indiziofacile9_3
            // 
            this.pb_indiziofacile9_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziofacile9_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile9_3.Name = "pb_indiziofacile9_3";
            this.pb_indiziofacile9_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile9_3.TabIndex = 1;
            this.pb_indiziofacile9_3.TabStop = false;
            this.pb_indiziofacile9_3.Click += new System.EventHandler(this.pb_indiziofacile9_3_Click);
            // 
            // pb_frecciavanti9facile
            // 
            this.pb_frecciavanti9facile.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview19;
            this.pb_frecciavanti9facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti9facile.Name = "pb_frecciavanti9facile";
            this.pb_frecciavanti9facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti9facile.TabIndex = 0;
            this.pb_frecciavanti9facile.TabStop = false;
            this.pb_frecciavanti9facile.Click += new System.EventHandler(this.pb_frecciavanti9facile_Click);
            // 
            // pictureBox104
            // 
            this.pictureBox104.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview7;
            this.pictureBox104.Location = new System.Drawing.Point(12, 21);
            this.pictureBox104.Name = "pictureBox104";
            this.pictureBox104.Size = new System.Drawing.Size(60, 62);
            this.pictureBox104.TabIndex = 19;
            this.pictureBox104.TabStop = false;
            this.pictureBox104.Click += new System.EventHandler(this.pictureBox104_Click);
            // 
            // pictureBox90
            // 
            this.pictureBox90.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_9_removebg_preview__1_1;
            this.pictureBox90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox90.Location = new System.Drawing.Point(179, 21);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(318, 80);
            this.pictureBox90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox90.TabIndex = 17;
            this.pictureBox90.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.BackgroundImage = global::Football_Quiz.Properties.Resources.borussia_dortmund1;
            this.pictureBox67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox67.Location = new System.Drawing.Point(109, 19);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(443, 292);
            this.pictureBox67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox67.TabIndex = 10;
            this.pictureBox67.TabStop = false;
            // 
            // pb_frecciaind10
            // 
            this.pb_frecciaind10.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview7;
            this.pb_frecciaind10.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaind10.Name = "pb_frecciaind10";
            this.pb_frecciaind10.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaind10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind10.TabIndex = 4;
            this.pb_frecciaind10.TabStop = false;
            this.pb_frecciaind10.Click += new System.EventHandler(this.pb_frecciaind10_Click);
            // 
            // pb_livellofacile10_2
            // 
            this.pb_livellofacile10_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_livellofacile10_2.Location = new System.Drawing.Point(606, 344);
            this.pb_livellofacile10_2.Name = "pb_livellofacile10_2";
            this.pb_livellofacile10_2.Size = new System.Drawing.Size(48, 53);
            this.pb_livellofacile10_2.TabIndex = 3;
            this.pb_livellofacile10_2.TabStop = false;
            this.pb_livellofacile10_2.Click += new System.EventHandler(this.pb_livellofacile10_2_Click);
            // 
            // pb_indiziofacile10_1
            // 
            this.pb_indiziofacile10_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_indiziofacile10_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile10_1.Name = "pb_indiziofacile10_1";
            this.pb_indiziofacile10_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile10_1.TabIndex = 2;
            this.pb_indiziofacile10_1.TabStop = false;
            this.pb_indiziofacile10_1.Click += new System.EventHandler(this.pb_indiziofacile10_1_Click);
            // 
            // pb_livellofacile10_3
            // 
            this.pb_livellofacile10_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_livellofacile10_3.Location = new System.Drawing.Point(606, 403);
            this.pb_livellofacile10_3.Name = "pb_livellofacile10_3";
            this.pb_livellofacile10_3.Size = new System.Drawing.Size(48, 53);
            this.pb_livellofacile10_3.TabIndex = 1;
            this.pb_livellofacile10_3.TabStop = false;
            this.pb_livellofacile10_3.Click += new System.EventHandler(this.pb_livellofacile10_3_Click);
            // 
            // pictureBox105
            // 
            this.pictureBox105.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview7;
            this.pictureBox105.Location = new System.Drawing.Point(12, 21);
            this.pictureBox105.Name = "pictureBox105";
            this.pictureBox105.Size = new System.Drawing.Size(60, 62);
            this.pictureBox105.TabIndex = 19;
            this.pictureBox105.TabStop = false;
            this.pictureBox105.Click += new System.EventHandler(this.pictureBox105_Click);
            // 
            // pictureBox96
            // 
            this.pictureBox96.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_10_removebg_preview__1_1;
            this.pictureBox96.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox96.Location = new System.Drawing.Point(160, 21);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(354, 80);
            this.pictureBox96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox96.TabIndex = 17;
            this.pictureBox96.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Location = new System.Drawing.Point(587, 620);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(60, 62);
            this.pictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox43.TabIndex = 26;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Location = new System.Drawing.Point(16, 620);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(60, 62);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox40.TabIndex = 25;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackgroundImage = global::Football_Quiz.Properties.Resources.applausi1;
            this.pictureBox44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox44.Location = new System.Drawing.Point(141, 200);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(403, 371);
            this.pictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox44.TabIndex = 24;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackgroundImage = global::Football_Quiz.Properties.Resources.cambia_giocatore1;
            this.pictureBox39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox39.Location = new System.Drawing.Point(587, 13);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(60, 62);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox39.TabIndex = 21;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview8;
            this.pictureBox38.Location = new System.Drawing.Point(16, 13);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(60, 62);
            this.pictureBox38.TabIndex = 20;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.BackgroundImage = global::Football_Quiz.Properties.Resources.atletico_madrid;
            this.pictureBox45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox45.Location = new System.Drawing.Point(109, 24);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(443, 292);
            this.pictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox45.TabIndex = 4;
            this.pictureBox45.TabStop = false;
            // 
            // pb_indiziomedio1_2
            // 
            this.pb_indiziomedio1_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio1_2.Location = new System.Drawing.Point(606, 349);
            this.pb_indiziomedio1_2.Name = "pb_indiziomedio1_2";
            this.pb_indiziomedio1_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio1_2.TabIndex = 3;
            this.pb_indiziomedio1_2.TabStop = false;
            this.pb_indiziomedio1_2.Click += new System.EventHandler(this.pb_indiziomedio1_2_Click);
            // 
            // pb_indiziomedio1_1
            // 
            this.pb_indiziomedio1_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio1_1.Location = new System.Drawing.Point(606, 290);
            this.pb_indiziomedio1_1.Name = "pb_indiziomedio1_1";
            this.pb_indiziomedio1_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio1_1.TabIndex = 2;
            this.pb_indiziomedio1_1.TabStop = false;
            this.pb_indiziomedio1_1.Click += new System.EventHandler(this.pb_indiziomedio1_1_Click);
            // 
            // pb_indiziomedio1_3
            // 
            this.pb_indiziomedio1_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio1_3.Location = new System.Drawing.Point(606, 408);
            this.pb_indiziomedio1_3.Name = "pb_indiziomedio1_3";
            this.pb_indiziomedio1_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio1_3.TabIndex = 1;
            this.pb_indiziomedio1_3.TabStop = false;
            this.pb_indiziomedio1_3.Click += new System.EventHandler(this.pb_indiziomedio1_3_Click);
            // 
            // pb_frecciavantimedio1
            // 
            this.pb_frecciavantimedio1.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview110;
            this.pb_frecciavantimedio1.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio1.Name = "pb_frecciavantimedio1";
            this.pb_frecciavantimedio1.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio1.TabIndex = 0;
            this.pb_frecciavantimedio1.TabStop = false;
            this.pb_frecciavantimedio1.Click += new System.EventHandler(this.pb_frecciavantimedio1_Click);
            // 
            // pb_homelivello1medio
            // 
            this.pb_homelivello1medio.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview9;
            this.pb_homelivello1medio.Location = new System.Drawing.Point(12, 21);
            this.pb_homelivello1medio.Name = "pb_homelivello1medio";
            this.pb_homelivello1medio.Size = new System.Drawing.Size(60, 62);
            this.pb_homelivello1medio.TabIndex = 22;
            this.pb_homelivello1medio.TabStop = false;
            this.pb_homelivello1medio.Click += new System.EventHandler(this.pb_homelivello1medio_Click);
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_1_removebg_preview1;
            this.pictureBox58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox58.Location = new System.Drawing.Point(179, 21);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(318, 80);
            this.pictureBox58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox58.TabIndex = 20;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackgroundImage = global::Football_Quiz.Properties.Resources.bayer_leverkusen;
            this.pictureBox57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox57.Location = new System.Drawing.Point(109, 19);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(443, 292);
            this.pictureBox57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox57.TabIndex = 10;
            this.pictureBox57.TabStop = false;
            // 
            // pb_frecciaindietromedio2
            // 
            this.pb_frecciaindietromedio2.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview8;
            this.pb_frecciaindietromedio2.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaindietromedio2.Name = "pb_frecciaindietromedio2";
            this.pb_frecciaindietromedio2.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaindietromedio2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaindietromedio2.TabIndex = 4;
            this.pb_frecciaindietromedio2.TabStop = false;
            this.pb_frecciaindietromedio2.Click += new System.EventHandler(this.pb_frecciaindietromedio2_Click);
            // 
            // pb_indiziomedio2_2
            // 
            this.pb_indiziomedio2_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio2_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio2_2.Name = "pb_indiziomedio2_2";
            this.pb_indiziomedio2_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio2_2.TabIndex = 3;
            this.pb_indiziomedio2_2.TabStop = false;
            this.pb_indiziomedio2_2.Click += new System.EventHandler(this.pb_indiziomedio2_2_Click);
            // 
            // pb_indiziomedio2_1
            // 
            this.pb_indiziomedio2_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio2_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio2_1.Name = "pb_indiziomedio2_1";
            this.pb_indiziomedio2_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio2_1.TabIndex = 2;
            this.pb_indiziomedio2_1.TabStop = false;
            this.pb_indiziomedio2_1.Click += new System.EventHandler(this.pb_indiziomedio2_1_Click);
            // 
            // pb_indiziomedio2_3
            // 
            this.pb_indiziomedio2_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio2_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio2_3.Name = "pb_indiziomedio2_3";
            this.pb_indiziomedio2_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio2_3.TabIndex = 1;
            this.pb_indiziomedio2_3.TabStop = false;
            this.pb_indiziomedio2_3.Click += new System.EventHandler(this.pb_indiziomedio2_3_Click);
            // 
            // pb_frecciavantimedio2
            // 
            this.pb_frecciavantimedio2.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview110;
            this.pb_frecciavantimedio2.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio2.Name = "pb_frecciavantimedio2";
            this.pb_frecciavantimedio2.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio2.TabIndex = 0;
            this.pb_frecciavantimedio2.TabStop = false;
            this.pb_frecciavantimedio2.Click += new System.EventHandler(this.pb_frecciavantimedio2_Click);
            // 
            // pb_homemedio2
            // 
            this.pb_homemedio2.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview10;
            this.pb_homemedio2.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio2.Name = "pb_homemedio2";
            this.pb_homemedio2.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio2.TabIndex = 24;
            this.pb_homemedio2.TabStop = false;
            this.pb_homemedio2.Click += new System.EventHandler(this.pb_homemedio2_Click);
            // 
            // pictureBox71
            // 
            this.pictureBox71.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_2_removebg_preview__1_2;
            this.pictureBox71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox71.Location = new System.Drawing.Point(179, 21);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(318, 80);
            this.pictureBox71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox71.TabIndex = 22;
            this.pictureBox71.TabStop = false;
            // 
            // pb_frecciaindietromedio3
            // 
            this.pb_frecciaindietromedio3.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview9;
            this.pb_frecciaindietromedio3.Location = new System.Drawing.Point(6, 501);
            this.pb_frecciaindietromedio3.Name = "pb_frecciaindietromedio3";
            this.pb_frecciaindietromedio3.Size = new System.Drawing.Size(60, 77);
            this.pb_frecciaindietromedio3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaindietromedio3.TabIndex = 25;
            this.pb_frecciaindietromedio3.TabStop = false;
            // 
            // pictureBox73
            // 
            this.pictureBox73.BackgroundImage = global::Football_Quiz.Properties.Resources.roma;
            this.pictureBox73.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox73.Location = new System.Drawing.Point(109, 24);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(443, 292);
            this.pictureBox73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox73.TabIndex = 4;
            this.pictureBox73.TabStop = false;
            // 
            // pb_indiziomedio3_2
            // 
            this.pb_indiziomedio3_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio3_2.Location = new System.Drawing.Point(606, 349);
            this.pb_indiziomedio3_2.Name = "pb_indiziomedio3_2";
            this.pb_indiziomedio3_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio3_2.TabIndex = 3;
            this.pb_indiziomedio3_2.TabStop = false;
            // 
            // pb_indiziomedio3_1
            // 
            this.pb_indiziomedio3_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio3_1.Location = new System.Drawing.Point(606, 290);
            this.pb_indiziomedio3_1.Name = "pb_indiziomedio3_1";
            this.pb_indiziomedio3_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio3_1.TabIndex = 2;
            this.pb_indiziomedio3_1.TabStop = false;
            // 
            // pb_indiziomedio3_3
            // 
            this.pb_indiziomedio3_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziomedio3_3.Location = new System.Drawing.Point(606, 408);
            this.pb_indiziomedio3_3.Name = "pb_indiziomedio3_3";
            this.pb_indiziomedio3_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio3_3.TabIndex = 1;
            this.pb_indiziomedio3_3.TabStop = false;
            // 
            // pb_frecciavantimedio3
            // 
            this.pb_frecciavantimedio3.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview110;
            this.pb_frecciavantimedio3.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio3.Name = "pb_frecciavantimedio3";
            this.pb_frecciavantimedio3.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio3.TabIndex = 0;
            this.pb_frecciavantimedio3.TabStop = false;
            // 
            // pb_homemedio3
            // 
            this.pb_homemedio3.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview10;
            this.pb_homemedio3.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio3.Name = "pb_homemedio3";
            this.pb_homemedio3.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio3.TabIndex = 22;
            this.pb_homemedio3.TabStop = false;
            this.pb_homemedio3.Click += new System.EventHandler(this.pb_homemedio3_Click);
            // 
            // pictureBox80
            // 
            this.pictureBox80.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_3_removebg_preview__1_2;
            this.pictureBox80.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox80.Location = new System.Drawing.Point(179, 21);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(318, 80);
            this.pictureBox80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox80.TabIndex = 20;
            this.pictureBox80.TabStop = false;
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackgroundImage = global::Football_Quiz.Properties.Resources.manchester_united;
            this.pictureBox50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox50.Location = new System.Drawing.Point(109, 19);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(443, 292);
            this.pictureBox50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox50.TabIndex = 10;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview3;
            this.pictureBox51.Location = new System.Drawing.Point(6, 501);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(60, 77);
            this.pictureBox51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox51.TabIndex = 4;
            this.pictureBox51.TabStop = false;
            // 
            // pb_indiziomedio4_2
            // 
            this.pb_indiziomedio4_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziomedio4_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio4_2.Name = "pb_indiziomedio4_2";
            this.pb_indiziomedio4_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio4_2.TabIndex = 3;
            this.pb_indiziomedio4_2.TabStop = false;
            // 
            // pb_indiziomedio4_1
            // 
            this.pb_indiziomedio4_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziomedio4_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio4_1.Name = "pb_indiziomedio4_1";
            this.pb_indiziomedio4_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio4_1.TabIndex = 2;
            this.pb_indiziomedio4_1.TabStop = false;
            // 
            // pb_indiziomedio4_3
            // 
            this.pb_indiziomedio4_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziomedio4_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio4_3.Name = "pb_indiziomedio4_3";
            this.pb_indiziomedio4_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio4_3.TabIndex = 1;
            this.pb_indiziomedio4_3.TabStop = false;
            // 
            // pb_frecciavantimedio4
            // 
            this.pb_frecciavantimedio4.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview14;
            this.pb_frecciavantimedio4.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio4.Name = "pb_frecciavantimedio4";
            this.pb_frecciavantimedio4.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio4.TabIndex = 0;
            this.pb_frecciavantimedio4.TabStop = false;
            // 
            // pb_homelivello4medio
            // 
            this.pb_homelivello4medio.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview3;
            this.pb_homelivello4medio.Location = new System.Drawing.Point(12, 21);
            this.pb_homelivello4medio.Name = "pb_homelivello4medio";
            this.pb_homelivello4medio.Size = new System.Drawing.Size(60, 62);
            this.pb_homelivello4medio.TabIndex = 24;
            this.pb_homelivello4medio.TabStop = false;
            // 
            // pictureBox68
            // 
            this.pictureBox68.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_4_removebg_preview__1_1;
            this.pictureBox68.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox68.Location = new System.Drawing.Point(179, 21);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(318, 80);
            this.pictureBox68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox68.TabIndex = 22;
            this.pictureBox68.TabStop = false;
            // 
            // pictureBox82
            // 
            this.pictureBox82.BackgroundImage = global::Football_Quiz.Properties.Resources.arsenal;
            this.pictureBox82.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox82.Location = new System.Drawing.Point(109, 19);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(443, 292);
            this.pictureBox82.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox82.TabIndex = 10;
            this.pictureBox82.TabStop = false;
            // 
            // pictureBox83
            // 
            this.pictureBox83.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview4;
            this.pictureBox83.Location = new System.Drawing.Point(6, 501);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(60, 77);
            this.pictureBox83.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox83.TabIndex = 4;
            this.pictureBox83.TabStop = false;
            // 
            // pb_indiziomedio5_2
            // 
            this.pb_indiziomedio5_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziomedio5_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio5_2.Name = "pb_indiziomedio5_2";
            this.pb_indiziomedio5_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio5_2.TabIndex = 3;
            this.pb_indiziomedio5_2.TabStop = false;
            // 
            // pb_indiziomedio5_1
            // 
            this.pb_indiziomedio5_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziomedio5_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio5_1.Name = "pb_indiziomedio5_1";
            this.pb_indiziomedio5_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio5_1.TabIndex = 2;
            this.pb_indiziomedio5_1.TabStop = false;
            // 
            // pb_indiziomedio5_3
            // 
            this.pb_indiziomedio5_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziomedio5_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio5_3.Name = "pb_indiziomedio5_3";
            this.pb_indiziomedio5_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio5_3.TabIndex = 1;
            this.pb_indiziomedio5_3.TabStop = false;
            // 
            // pb_frecciavantimedio5
            // 
            this.pb_frecciavantimedio5.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview15;
            this.pb_frecciavantimedio5.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio5.Name = "pb_frecciavantimedio5";
            this.pb_frecciavantimedio5.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio5.TabIndex = 0;
            this.pb_frecciavantimedio5.TabStop = false;
            // 
            // pb_homemedio5
            // 
            this.pb_homemedio5.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview4;
            this.pb_homemedio5.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio5.Name = "pb_homemedio5";
            this.pb_homemedio5.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio5.TabIndex = 24;
            this.pb_homemedio5.TabStop = false;
            // 
            // pictureBox91
            // 
            this.pictureBox91.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_5_removebg_preview__1_1;
            this.pictureBox91.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox91.Location = new System.Drawing.Point(179, 21);
            this.pictureBox91.Name = "pictureBox91";
            this.pictureBox91.Size = new System.Drawing.Size(318, 80);
            this.pictureBox91.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox91.TabIndex = 22;
            this.pictureBox91.TabStop = false;
            // 
            // pictureBox110
            // 
            this.pictureBox110.BackgroundImage = global::Football_Quiz.Properties.Resources.napoli;
            this.pictureBox110.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox110.Location = new System.Drawing.Point(109, 19);
            this.pictureBox110.Name = "pictureBox110";
            this.pictureBox110.Size = new System.Drawing.Size(443, 292);
            this.pictureBox110.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox110.TabIndex = 10;
            this.pictureBox110.TabStop = false;
            // 
            // pictureBox111
            // 
            this.pictureBox111.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview5;
            this.pictureBox111.Location = new System.Drawing.Point(6, 501);
            this.pictureBox111.Name = "pictureBox111";
            this.pictureBox111.Size = new System.Drawing.Size(60, 77);
            this.pictureBox111.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox111.TabIndex = 4;
            this.pictureBox111.TabStop = false;
            // 
            // pb_indiziomedio6_2
            // 
            this.pb_indiziomedio6_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziomedio6_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio6_2.Name = "pb_indiziomedio6_2";
            this.pb_indiziomedio6_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio6_2.TabIndex = 3;
            this.pb_indiziomedio6_2.TabStop = false;
            // 
            // pb_indiziomedio6_1
            // 
            this.pb_indiziomedio6_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziomedio6_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio6_1.Name = "pb_indiziomedio6_1";
            this.pb_indiziomedio6_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio6_1.TabIndex = 2;
            this.pb_indiziomedio6_1.TabStop = false;
            // 
            // pb_indiziomedio6_3
            // 
            this.pb_indiziomedio6_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziomedio6_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio6_3.Name = "pb_indiziomedio6_3";
            this.pb_indiziomedio6_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio6_3.TabIndex = 1;
            this.pb_indiziomedio6_3.TabStop = false;
            // 
            // pb_frecciavantimedio6
            // 
            this.pb_frecciavantimedio6.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview16;
            this.pb_frecciavantimedio6.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio6.Name = "pb_frecciavantimedio6";
            this.pb_frecciavantimedio6.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio6.TabIndex = 0;
            this.pb_frecciavantimedio6.TabStop = false;
            // 
            // pb_homemedio6
            // 
            this.pb_homemedio6.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview5;
            this.pb_homemedio6.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio6.Name = "pb_homemedio6";
            this.pb_homemedio6.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio6.TabIndex = 24;
            this.pb_homemedio6.TabStop = false;
            // 
            // pictureBox117
            // 
            this.pictureBox117.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_6_removebg_preview__1_2;
            this.pictureBox117.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox117.Location = new System.Drawing.Point(179, 21);
            this.pictureBox117.Name = "pictureBox117";
            this.pictureBox117.Size = new System.Drawing.Size(318, 80);
            this.pictureBox117.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox117.TabIndex = 22;
            this.pictureBox117.TabStop = false;
            // 
            // pictureBox126
            // 
            this.pictureBox126.BackgroundImage = global::Football_Quiz.Properties.Resources.marsiglia;
            this.pictureBox126.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox126.Location = new System.Drawing.Point(109, 19);
            this.pictureBox126.Name = "pictureBox126";
            this.pictureBox126.Size = new System.Drawing.Size(443, 292);
            this.pictureBox126.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox126.TabIndex = 10;
            this.pictureBox126.TabStop = false;
            // 
            // pictureBox127
            // 
            this.pictureBox127.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview5;
            this.pictureBox127.Location = new System.Drawing.Point(6, 501);
            this.pictureBox127.Name = "pictureBox127";
            this.pictureBox127.Size = new System.Drawing.Size(60, 77);
            this.pictureBox127.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox127.TabIndex = 4;
            this.pictureBox127.TabStop = false;
            // 
            // pb_indiziomedio7_2
            // 
            this.pb_indiziomedio7_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziomedio7_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio7_2.Name = "pb_indiziomedio7_2";
            this.pb_indiziomedio7_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio7_2.TabIndex = 3;
            this.pb_indiziomedio7_2.TabStop = false;
            // 
            // pb_indiziomedio7_1
            // 
            this.pb_indiziomedio7_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziomedio7_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio7_1.Name = "pb_indiziomedio7_1";
            this.pb_indiziomedio7_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio7_1.TabIndex = 2;
            this.pb_indiziomedio7_1.TabStop = false;
            // 
            // pb_indiziomedio7_3
            // 
            this.pb_indiziomedio7_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziomedio7_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio7_3.Name = "pb_indiziomedio7_3";
            this.pb_indiziomedio7_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio7_3.TabIndex = 1;
            this.pb_indiziomedio7_3.TabStop = false;
            // 
            // pb_frecciavantimedio7
            // 
            this.pb_frecciavantimedio7.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview17;
            this.pb_frecciavantimedio7.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio7.Name = "pb_frecciavantimedio7";
            this.pb_frecciavantimedio7.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio7.TabIndex = 0;
            this.pb_frecciavantimedio7.TabStop = false;
            // 
            // pb_homemedio7
            // 
            this.pb_homemedio7.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview6;
            this.pb_homemedio7.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio7.Name = "pb_homemedio7";
            this.pb_homemedio7.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio7.TabIndex = 24;
            this.pb_homemedio7.TabStop = false;
            // 
            // pictureBox133
            // 
            this.pictureBox133.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_7_removebg_preview__1_1;
            this.pictureBox133.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox133.Location = new System.Drawing.Point(179, 21);
            this.pictureBox133.Name = "pictureBox133";
            this.pictureBox133.Size = new System.Drawing.Size(318, 80);
            this.pictureBox133.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox133.TabIndex = 22;
            this.pictureBox133.TabStop = false;
            // 
            // pictureBox142
            // 
            this.pictureBox142.BackgroundImage = global::Football_Quiz.Properties.Resources.siviglia;
            this.pictureBox142.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox142.Location = new System.Drawing.Point(109, 19);
            this.pictureBox142.Name = "pictureBox142";
            this.pictureBox142.Size = new System.Drawing.Size(443, 292);
            this.pictureBox142.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox142.TabIndex = 10;
            this.pictureBox142.TabStop = false;
            // 
            // pictureBox143
            // 
            this.pictureBox143.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview6;
            this.pictureBox143.Location = new System.Drawing.Point(6, 501);
            this.pictureBox143.Name = "pictureBox143";
            this.pictureBox143.Size = new System.Drawing.Size(60, 77);
            this.pictureBox143.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox143.TabIndex = 4;
            this.pictureBox143.TabStop = false;
            // 
            // pb_indiziomedio8_2
            // 
            this.pb_indiziomedio8_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziomedio8_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio8_2.Name = "pb_indiziomedio8_2";
            this.pb_indiziomedio8_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio8_2.TabIndex = 3;
            this.pb_indiziomedio8_2.TabStop = false;
            // 
            // pb_indiziomedio8_1
            // 
            this.pb_indiziomedio8_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziomedio8_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio8_1.Name = "pb_indiziomedio8_1";
            this.pb_indiziomedio8_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio8_1.TabIndex = 2;
            this.pb_indiziomedio8_1.TabStop = false;
            // 
            // pb_indiziomedio8_3
            // 
            this.pb_indiziomedio8_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziomedio8_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio8_3.Name = "pb_indiziomedio8_3";
            this.pb_indiziomedio8_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio8_3.TabIndex = 1;
            this.pb_indiziomedio8_3.TabStop = false;
            // 
            // pb_frecciavantimedio8
            // 
            this.pb_frecciavantimedio8.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview18;
            this.pb_frecciavantimedio8.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio8.Name = "pb_frecciavantimedio8";
            this.pb_frecciavantimedio8.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio8.TabIndex = 0;
            this.pb_frecciavantimedio8.TabStop = false;
            // 
            // pb_homemedio8
            // 
            this.pb_homemedio8.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview6;
            this.pb_homemedio8.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio8.Name = "pb_homemedio8";
            this.pb_homemedio8.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio8.TabIndex = 24;
            this.pb_homemedio8.TabStop = false;
            // 
            // pictureBox151
            // 
            this.pictureBox151.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_8_removebg_preview__1_1;
            this.pictureBox151.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox151.Location = new System.Drawing.Point(179, 21);
            this.pictureBox151.Name = "pictureBox151";
            this.pictureBox151.Size = new System.Drawing.Size(318, 80);
            this.pictureBox151.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox151.TabIndex = 22;
            this.pictureBox151.TabStop = false;
            // 
            // pictureBox160
            // 
            this.pictureBox160.BackgroundImage = global::Football_Quiz.Properties.Resources.chelsea;
            this.pictureBox160.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox160.Location = new System.Drawing.Point(109, 19);
            this.pictureBox160.Name = "pictureBox160";
            this.pictureBox160.Size = new System.Drawing.Size(443, 292);
            this.pictureBox160.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox160.TabIndex = 10;
            this.pictureBox160.TabStop = false;
            // 
            // pictureBox161
            // 
            this.pictureBox161.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview6;
            this.pictureBox161.Location = new System.Drawing.Point(6, 501);
            this.pictureBox161.Name = "pictureBox161";
            this.pictureBox161.Size = new System.Drawing.Size(60, 77);
            this.pictureBox161.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox161.TabIndex = 4;
            this.pictureBox161.TabStop = false;
            // 
            // pb_indiziomedio9_2
            // 
            this.pb_indiziomedio9_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziomedio9_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio9_2.Name = "pb_indiziomedio9_2";
            this.pb_indiziomedio9_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio9_2.TabIndex = 3;
            this.pb_indiziomedio9_2.TabStop = false;
            // 
            // pb_indiziomedio9_1
            // 
            this.pb_indiziomedio9_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziomedio9_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio9_1.Name = "pb_indiziomedio9_1";
            this.pb_indiziomedio9_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio9_1.TabIndex = 2;
            this.pb_indiziomedio9_1.TabStop = false;
            // 
            // pb_indiziomedio9_3
            // 
            this.pb_indiziomedio9_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziomedio9_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio9_3.Name = "pb_indiziomedio9_3";
            this.pb_indiziomedio9_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio9_3.TabIndex = 1;
            this.pb_indiziomedio9_3.TabStop = false;
            // 
            // pb_frecciavantimedio9
            // 
            this.pb_frecciavantimedio9.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview19;
            this.pb_frecciavantimedio9.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantimedio9.Name = "pb_frecciavantimedio9";
            this.pb_frecciavantimedio9.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantimedio9.TabIndex = 0;
            this.pb_frecciavantimedio9.TabStop = false;
            // 
            // pb_homemedio9
            // 
            this.pb_homemedio9.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview7;
            this.pb_homemedio9.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio9.Name = "pb_homemedio9";
            this.pb_homemedio9.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio9.TabIndex = 24;
            this.pb_homemedio9.TabStop = false;
            // 
            // pictureBox167
            // 
            this.pictureBox167.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_9_removebg_preview__1_1;
            this.pictureBox167.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox167.Location = new System.Drawing.Point(179, 21);
            this.pictureBox167.Name = "pictureBox167";
            this.pictureBox167.Size = new System.Drawing.Size(318, 80);
            this.pictureBox167.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox167.TabIndex = 22;
            this.pictureBox167.TabStop = false;
            // 
            // pictureBox176
            // 
            this.pictureBox176.BackgroundImage = global::Football_Quiz.Properties.Resources.benfica;
            this.pictureBox176.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox176.Location = new System.Drawing.Point(109, 19);
            this.pictureBox176.Name = "pictureBox176";
            this.pictureBox176.Size = new System.Drawing.Size(443, 292);
            this.pictureBox176.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox176.TabIndex = 10;
            this.pictureBox176.TabStop = false;
            // 
            // pictureBox177
            // 
            this.pictureBox177.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview7;
            this.pictureBox177.Location = new System.Drawing.Point(6, 501);
            this.pictureBox177.Name = "pictureBox177";
            this.pictureBox177.Size = new System.Drawing.Size(60, 77);
            this.pictureBox177.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox177.TabIndex = 4;
            this.pictureBox177.TabStop = false;
            // 
            // pb_indiziomedio10_2
            // 
            this.pb_indiziomedio10_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_indiziomedio10_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziomedio10_2.Name = "pb_indiziomedio10_2";
            this.pb_indiziomedio10_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio10_2.TabIndex = 3;
            this.pb_indiziomedio10_2.TabStop = false;
            // 
            // pb_indiziomedio10_1
            // 
            this.pb_indiziomedio10_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_indiziomedio10_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziomedio10_1.Name = "pb_indiziomedio10_1";
            this.pb_indiziomedio10_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio10_1.TabIndex = 2;
            this.pb_indiziomedio10_1.TabStop = false;
            // 
            // pb_indiziomedio10_3
            // 
            this.pb_indiziomedio10_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_indiziomedio10_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziomedio10_3.Name = "pb_indiziomedio10_3";
            this.pb_indiziomedio10_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziomedio10_3.TabIndex = 1;
            this.pb_indiziomedio10_3.TabStop = false;
            // 
            // pb_homemedio10
            // 
            this.pb_homemedio10.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview7;
            this.pb_homemedio10.Location = new System.Drawing.Point(12, 21);
            this.pb_homemedio10.Name = "pb_homemedio10";
            this.pb_homemedio10.Size = new System.Drawing.Size(60, 62);
            this.pb_homemedio10.TabIndex = 24;
            this.pb_homemedio10.TabStop = false;
            // 
            // pictureBox182
            // 
            this.pictureBox182.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_10_removebg_preview__1_1;
            this.pictureBox182.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox182.Location = new System.Drawing.Point(160, 21);
            this.pictureBox182.Name = "pictureBox182";
            this.pictureBox182.Size = new System.Drawing.Size(354, 80);
            this.pictureBox182.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox182.TabIndex = 22;
            this.pictureBox182.TabStop = false;
            // 
            // pictureBox190
            // 
            this.pictureBox190.Location = new System.Drawing.Point(593, 621);
            this.pictureBox190.Name = "pictureBox190";
            this.pictureBox190.Size = new System.Drawing.Size(60, 62);
            this.pictureBox190.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox190.TabIndex = 37;
            this.pictureBox190.TabStop = false;
            // 
            // pictureBox191
            // 
            this.pictureBox191.Location = new System.Drawing.Point(22, 621);
            this.pictureBox191.Name = "pictureBox191";
            this.pictureBox191.Size = new System.Drawing.Size(60, 62);
            this.pictureBox191.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox191.TabIndex = 36;
            this.pictureBox191.TabStop = false;
            // 
            // pictureBox192
            // 
            this.pictureBox192.BackgroundImage = global::Football_Quiz.Properties.Resources.applausi1;
            this.pictureBox192.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox192.Location = new System.Drawing.Point(147, 201);
            this.pictureBox192.Name = "pictureBox192";
            this.pictureBox192.Size = new System.Drawing.Size(403, 371);
            this.pictureBox192.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox192.TabIndex = 35;
            this.pictureBox192.TabStop = false;
            // 
            // pictureBox193
            // 
            this.pictureBox193.BackgroundImage = global::Football_Quiz.Properties.Resources.cambia_giocatore1;
            this.pictureBox193.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox193.Location = new System.Drawing.Point(593, 14);
            this.pictureBox193.Name = "pictureBox193";
            this.pictureBox193.Size = new System.Drawing.Size(60, 62);
            this.pictureBox193.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox193.TabIndex = 34;
            this.pictureBox193.TabStop = false;
            // 
            // pictureBox194
            // 
            this.pictureBox194.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview8;
            this.pictureBox194.Location = new System.Drawing.Point(22, 14);
            this.pictureBox194.Name = "pictureBox194";
            this.pictureBox194.Size = new System.Drawing.Size(60, 62);
            this.pictureBox194.TabIndex = 33;
            this.pictureBox194.TabStop = false;
            // 
            // pictureBox198
            // 
            this.pictureBox198.BackgroundImage = global::Football_Quiz.Properties.Resources.al_hilal;
            this.pictureBox198.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox198.Location = new System.Drawing.Point(109, 24);
            this.pictureBox198.Name = "pictureBox198";
            this.pictureBox198.Size = new System.Drawing.Size(443, 292);
            this.pictureBox198.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox198.TabIndex = 4;
            this.pictureBox198.TabStop = false;
            // 
            // pb_indiziodifficile1_2
            // 
            this.pb_indiziodifficile1_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile1_2.Location = new System.Drawing.Point(606, 349);
            this.pb_indiziodifficile1_2.Name = "pb_indiziodifficile1_2";
            this.pb_indiziodifficile1_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile1_2.TabIndex = 3;
            this.pb_indiziodifficile1_2.TabStop = false;
            // 
            // pb_indiziodifficile1_1
            // 
            this.pb_indiziodifficile1_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile1_1.Location = new System.Drawing.Point(606, 290);
            this.pb_indiziodifficile1_1.Name = "pb_indiziodifficile1_1";
            this.pb_indiziodifficile1_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile1_1.TabIndex = 2;
            this.pb_indiziodifficile1_1.TabStop = false;
            // 
            // pb_indiziodifficile1_3
            // 
            this.pb_indiziodifficile1_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile1_3.Location = new System.Drawing.Point(606, 408);
            this.pb_indiziodifficile1_3.Name = "pb_indiziodifficile1_3";
            this.pb_indiziodifficile1_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile1_3.TabIndex = 1;
            this.pb_indiziodifficile1_3.TabStop = false;
            // 
            // pb_frecciavantidifficile1
            // 
            this.pb_frecciavantidifficile1.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview110;
            this.pb_frecciavantidifficile1.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile1.Name = "pb_frecciavantidifficile1";
            this.pb_frecciavantidifficile1.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile1.TabIndex = 0;
            this.pb_frecciavantidifficile1.TabStop = false;
            // 
            // pb_homedifficile1
            // 
            this.pb_homedifficile1.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview9;
            this.pb_homedifficile1.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile1.Name = "pb_homedifficile1";
            this.pb_homedifficile1.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile1.TabIndex = 27;
            this.pb_homedifficile1.TabStop = false;
            // 
            // pictureBox204
            // 
            this.pictureBox204.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_1_removebg_preview1;
            this.pictureBox204.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox204.Location = new System.Drawing.Point(179, 21);
            this.pictureBox204.Name = "pictureBox204";
            this.pictureBox204.Size = new System.Drawing.Size(318, 80);
            this.pictureBox204.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox204.TabIndex = 25;
            this.pictureBox204.TabStop = false;
            // 
            // pictureBox205
            // 
            this.pictureBox205.BackgroundImage = global::Football_Quiz.Properties.Resources.inter_miami;
            this.pictureBox205.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox205.Location = new System.Drawing.Point(109, 19);
            this.pictureBox205.Name = "pictureBox205";
            this.pictureBox205.Size = new System.Drawing.Size(443, 292);
            this.pictureBox205.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox205.TabIndex = 10;
            this.pictureBox205.TabStop = false;
            // 
            // pictureBox206
            // 
            this.pictureBox206.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview8;
            this.pictureBox206.Location = new System.Drawing.Point(6, 501);
            this.pictureBox206.Name = "pictureBox206";
            this.pictureBox206.Size = new System.Drawing.Size(60, 77);
            this.pictureBox206.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox206.TabIndex = 4;
            this.pictureBox206.TabStop = false;
            // 
            // pb_indiziodifficile2_2
            // 
            this.pb_indiziodifficile2_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile2_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile2_2.Name = "pb_indiziodifficile2_2";
            this.pb_indiziodifficile2_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile2_2.TabIndex = 3;
            this.pb_indiziodifficile2_2.TabStop = false;
            // 
            // pb_indiziodifficile2_1
            // 
            this.pb_indiziodifficile2_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile2_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile2_1.Name = "pb_indiziodifficile2_1";
            this.pb_indiziodifficile2_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile2_1.TabIndex = 2;
            this.pb_indiziodifficile2_1.TabStop = false;
            // 
            // pb_indiziodifficile2_3
            // 
            this.pb_indiziodifficile2_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile2_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile2_3.Name = "pb_indiziodifficile2_3";
            this.pb_indiziodifficile2_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile2_3.TabIndex = 1;
            this.pb_indiziodifficile2_3.TabStop = false;
            // 
            // pb_frecciavantidifficile2
            // 
            this.pb_frecciavantidifficile2.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview110;
            this.pb_frecciavantidifficile2.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile2.Name = "pb_frecciavantidifficile2";
            this.pb_frecciavantidifficile2.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile2.TabIndex = 0;
            this.pb_frecciavantidifficile2.TabStop = false;
            // 
            // pb_homedifficile2
            // 
            this.pb_homedifficile2.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview10;
            this.pb_homedifficile2.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile2.Name = "pb_homedifficile2";
            this.pb_homedifficile2.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile2.TabIndex = 29;
            this.pb_homedifficile2.TabStop = false;
            // 
            // pictureBox212
            // 
            this.pictureBox212.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_2_removebg_preview__1_2;
            this.pictureBox212.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox212.Location = new System.Drawing.Point(179, 21);
            this.pictureBox212.Name = "pictureBox212";
            this.pictureBox212.Size = new System.Drawing.Size(318, 80);
            this.pictureBox212.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox212.TabIndex = 27;
            this.pictureBox212.TabStop = false;
            // 
            // pictureBox213
            // 
            this.pictureBox213.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview9;
            this.pictureBox213.Location = new System.Drawing.Point(6, 501);
            this.pictureBox213.Name = "pictureBox213";
            this.pictureBox213.Size = new System.Drawing.Size(60, 77);
            this.pictureBox213.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox213.TabIndex = 25;
            this.pictureBox213.TabStop = false;
            // 
            // pictureBox214
            // 
            this.pictureBox214.BackgroundImage = global::Football_Quiz.Properties.Resources.al_nassr;
            this.pictureBox214.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox214.Location = new System.Drawing.Point(109, 24);
            this.pictureBox214.Name = "pictureBox214";
            this.pictureBox214.Size = new System.Drawing.Size(443, 292);
            this.pictureBox214.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox214.TabIndex = 4;
            this.pictureBox214.TabStop = false;
            // 
            // pb_indiziodifficile3_2
            // 
            this.pb_indiziodifficile3_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile3_2.Location = new System.Drawing.Point(606, 349);
            this.pb_indiziodifficile3_2.Name = "pb_indiziodifficile3_2";
            this.pb_indiziodifficile3_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile3_2.TabIndex = 3;
            this.pb_indiziodifficile3_2.TabStop = false;
            // 
            // pb_indiziodifficile3_1
            // 
            this.pb_indiziodifficile3_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile3_1.Location = new System.Drawing.Point(606, 290);
            this.pb_indiziodifficile3_1.Name = "pb_indiziodifficile3_1";
            this.pb_indiziodifficile3_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile3_1.TabIndex = 2;
            this.pb_indiziodifficile3_1.TabStop = false;
            // 
            // pb_indiziodifficile3_3
            // 
            this.pb_indiziodifficile3_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview10;
            this.pb_indiziodifficile3_3.Location = new System.Drawing.Point(606, 408);
            this.pb_indiziodifficile3_3.Name = "pb_indiziodifficile3_3";
            this.pb_indiziodifficile3_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile3_3.TabIndex = 1;
            this.pb_indiziodifficile3_3.TabStop = false;
            // 
            // pb_frecciavantidifficile3
            // 
            this.pb_frecciavantidifficile3.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview110;
            this.pb_frecciavantidifficile3.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile3.Name = "pb_frecciavantidifficile3";
            this.pb_frecciavantidifficile3.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile3.TabIndex = 0;
            this.pb_frecciavantidifficile3.TabStop = false;
            // 
            // pb_homedifficile3
            // 
            this.pb_homedifficile3.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview10;
            this.pb_homedifficile3.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile3.Name = "pb_homedifficile3";
            this.pb_homedifficile3.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile3.TabIndex = 27;
            this.pb_homedifficile3.TabStop = false;
            // 
            // pictureBox220
            // 
            this.pictureBox220.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_3_removebg_preview__1_2;
            this.pictureBox220.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox220.Location = new System.Drawing.Point(179, 21);
            this.pictureBox220.Name = "pictureBox220";
            this.pictureBox220.Size = new System.Drawing.Size(318, 80);
            this.pictureBox220.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox220.TabIndex = 25;
            this.pictureBox220.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.BackgroundImage = global::Football_Quiz.Properties.Resources.atalanta;
            this.pictureBox69.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox69.Location = new System.Drawing.Point(109, 19);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(443, 292);
            this.pictureBox69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox69.TabIndex = 10;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox70
            // 
            this.pictureBox70.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview3;
            this.pictureBox70.Location = new System.Drawing.Point(6, 501);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(60, 77);
            this.pictureBox70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox70.TabIndex = 4;
            this.pictureBox70.TabStop = false;
            // 
            // pb_indiziodifficile4_2
            // 
            this.pb_indiziodifficile4_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziodifficile4_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile4_2.Name = "pb_indiziodifficile4_2";
            this.pb_indiziodifficile4_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile4_2.TabIndex = 3;
            this.pb_indiziodifficile4_2.TabStop = false;
            // 
            // pb_indiziodifficile4_1
            // 
            this.pb_indiziodifficile4_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziodifficile4_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile4_1.Name = "pb_indiziodifficile4_1";
            this.pb_indiziodifficile4_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile4_1.TabIndex = 2;
            this.pb_indiziodifficile4_1.TabStop = false;
            // 
            // pb_indiziodifficile4_3
            // 
            this.pb_indiziodifficile4_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview3;
            this.pb_indiziodifficile4_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile4_3.Name = "pb_indiziodifficile4_3";
            this.pb_indiziodifficile4_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile4_3.TabIndex = 1;
            this.pb_indiziodifficile4_3.TabStop = false;
            // 
            // pb_frecciavantidifficile4
            // 
            this.pb_frecciavantidifficile4.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview14;
            this.pb_frecciavantidifficile4.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile4.Name = "pb_frecciavantidifficile4";
            this.pb_frecciavantidifficile4.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile4.TabIndex = 0;
            this.pb_frecciavantidifficile4.TabStop = false;
            // 
            // pb_homedifficile4
            // 
            this.pb_homedifficile4.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview3;
            this.pb_homedifficile4.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile4.Name = "pb_homedifficile4";
            this.pb_homedifficile4.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile4.TabIndex = 24;
            this.pb_homedifficile4.TabStop = false;
            // 
            // pictureBox81
            // 
            this.pictureBox81.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_4_removebg_preview__1_1;
            this.pictureBox81.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox81.Location = new System.Drawing.Point(179, 21);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(318, 80);
            this.pictureBox81.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox81.TabIndex = 22;
            this.pictureBox81.TabStop = false;
            // 
            // pictureBox92
            // 
            this.pictureBox92.BackgroundImage = global::Football_Quiz.Properties.Resources.lazio;
            this.pictureBox92.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox92.Location = new System.Drawing.Point(109, 19);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(443, 292);
            this.pictureBox92.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox92.TabIndex = 10;
            this.pictureBox92.TabStop = false;
            // 
            // pictureBox93
            // 
            this.pictureBox93.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview4;
            this.pictureBox93.Location = new System.Drawing.Point(6, 501);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(60, 77);
            this.pictureBox93.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox93.TabIndex = 4;
            this.pictureBox93.TabStop = false;
            // 
            // pb_indiziodifficile5_2
            // 
            this.pb_indiziodifficile5_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziodifficile5_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile5_2.Name = "pb_indiziodifficile5_2";
            this.pb_indiziodifficile5_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile5_2.TabIndex = 3;
            this.pb_indiziodifficile5_2.TabStop = false;
            // 
            // pb_indiziodifficile5_1
            // 
            this.pb_indiziodifficile5_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziodifficile5_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile5_1.Name = "pb_indiziodifficile5_1";
            this.pb_indiziodifficile5_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile5_1.TabIndex = 2;
            this.pb_indiziodifficile5_1.TabStop = false;
            // 
            // pb_indiziodifficile5_3
            // 
            this.pb_indiziodifficile5_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview4;
            this.pb_indiziodifficile5_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile5_3.Name = "pb_indiziodifficile5_3";
            this.pb_indiziodifficile5_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile5_3.TabIndex = 1;
            this.pb_indiziodifficile5_3.TabStop = false;
            // 
            // pb_frecciavantidifficile5
            // 
            this.pb_frecciavantidifficile5.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview15;
            this.pb_frecciavantidifficile5.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile5.Name = "pb_frecciavantidifficile5";
            this.pb_frecciavantidifficile5.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile5.TabIndex = 0;
            this.pb_frecciavantidifficile5.TabStop = false;
            // 
            // pb_homedifficile5
            // 
            this.pb_homedifficile5.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview4;
            this.pb_homedifficile5.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile5.Name = "pb_homedifficile5";
            this.pb_homedifficile5.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile5.TabIndex = 24;
            this.pb_homedifficile5.TabStop = false;
            // 
            // pictureBox109
            // 
            this.pictureBox109.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_5_removebg_preview__1_1;
            this.pictureBox109.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox109.Location = new System.Drawing.Point(179, 21);
            this.pictureBox109.Name = "pictureBox109";
            this.pictureBox109.Size = new System.Drawing.Size(318, 80);
            this.pictureBox109.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox109.TabIndex = 22;
            this.pictureBox109.TabStop = false;
            // 
            // pictureBox118
            // 
            this.pictureBox118.BackgroundImage = global::Football_Quiz.Properties.Resources.west_ham;
            this.pictureBox118.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox118.Location = new System.Drawing.Point(109, 19);
            this.pictureBox118.Name = "pictureBox118";
            this.pictureBox118.Size = new System.Drawing.Size(443, 292);
            this.pictureBox118.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox118.TabIndex = 10;
            this.pictureBox118.TabStop = false;
            // 
            // pictureBox119
            // 
            this.pictureBox119.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview5;
            this.pictureBox119.Location = new System.Drawing.Point(6, 501);
            this.pictureBox119.Name = "pictureBox119";
            this.pictureBox119.Size = new System.Drawing.Size(60, 77);
            this.pictureBox119.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox119.TabIndex = 4;
            this.pictureBox119.TabStop = false;
            // 
            // pb_indiziodifficile6_2
            // 
            this.pb_indiziodifficile6_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziodifficile6_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile6_2.Name = "pb_indiziodifficile6_2";
            this.pb_indiziodifficile6_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile6_2.TabIndex = 3;
            this.pb_indiziodifficile6_2.TabStop = false;
            // 
            // pb_indiziodifficile6_1
            // 
            this.pb_indiziodifficile6_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziodifficile6_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile6_1.Name = "pb_indiziodifficile6_1";
            this.pb_indiziodifficile6_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile6_1.TabIndex = 2;
            this.pb_indiziodifficile6_1.TabStop = false;
            // 
            // pb_indiziodifficile6_3
            // 
            this.pb_indiziodifficile6_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview5;
            this.pb_indiziodifficile6_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile6_3.Name = "pb_indiziodifficile6_3";
            this.pb_indiziodifficile6_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile6_3.TabIndex = 1;
            this.pb_indiziodifficile6_3.TabStop = false;
            // 
            // pb_frecciavantidifficile6
            // 
            this.pb_frecciavantidifficile6.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview16;
            this.pb_frecciavantidifficile6.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile6.Name = "pb_frecciavantidifficile6";
            this.pb_frecciavantidifficile6.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile6.TabIndex = 0;
            this.pb_frecciavantidifficile6.TabStop = false;
            // 
            // pb_homedifficile6
            // 
            this.pb_homedifficile6.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview5;
            this.pb_homedifficile6.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile6.Name = "pb_homedifficile6";
            this.pb_homedifficile6.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile6.TabIndex = 24;
            this.pb_homedifficile6.TabStop = false;
            // 
            // pictureBox125
            // 
            this.pictureBox125.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_6_removebg_preview__1_2;
            this.pictureBox125.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox125.Location = new System.Drawing.Point(179, 21);
            this.pictureBox125.Name = "pictureBox125";
            this.pictureBox125.Size = new System.Drawing.Size(318, 80);
            this.pictureBox125.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox125.TabIndex = 22;
            this.pictureBox125.TabStop = false;
            // 
            // pictureBox134
            // 
            this.pictureBox134.BackgroundImage = global::Football_Quiz.Properties.Resources.tottenham;
            this.pictureBox134.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox134.Location = new System.Drawing.Point(109, 19);
            this.pictureBox134.Name = "pictureBox134";
            this.pictureBox134.Size = new System.Drawing.Size(443, 292);
            this.pictureBox134.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox134.TabIndex = 10;
            this.pictureBox134.TabStop = false;
            // 
            // pictureBox135
            // 
            this.pictureBox135.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview5;
            this.pictureBox135.Location = new System.Drawing.Point(6, 501);
            this.pictureBox135.Name = "pictureBox135";
            this.pictureBox135.Size = new System.Drawing.Size(60, 77);
            this.pictureBox135.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox135.TabIndex = 4;
            this.pictureBox135.TabStop = false;
            // 
            // pb_indiziodifficile7_2
            // 
            this.pb_indiziodifficile7_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziodifficile7_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile7_2.Name = "pb_indiziodifficile7_2";
            this.pb_indiziodifficile7_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile7_2.TabIndex = 3;
            this.pb_indiziodifficile7_2.TabStop = false;
            // 
            // pb_indiziodifficile7_1
            // 
            this.pb_indiziodifficile7_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziodifficile7_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile7_1.Name = "pb_indiziodifficile7_1";
            this.pb_indiziodifficile7_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile7_1.TabIndex = 2;
            this.pb_indiziodifficile7_1.TabStop = false;
            // 
            // pb_indiziodifficile7_3
            // 
            this.pb_indiziodifficile7_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview6;
            this.pb_indiziodifficile7_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile7_3.Name = "pb_indiziodifficile7_3";
            this.pb_indiziodifficile7_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile7_3.TabIndex = 1;
            this.pb_indiziodifficile7_3.TabStop = false;
            // 
            // pb_frecciavantidifficile7
            // 
            this.pb_frecciavantidifficile7.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview17;
            this.pb_frecciavantidifficile7.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile7.Name = "pb_frecciavantidifficile7";
            this.pb_frecciavantidifficile7.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile7.TabIndex = 0;
            this.pb_frecciavantidifficile7.TabStop = false;
            // 
            // pb_homedifficile7
            // 
            this.pb_homedifficile7.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview6;
            this.pb_homedifficile7.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile7.Name = "pb_homedifficile7";
            this.pb_homedifficile7.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile7.TabIndex = 24;
            this.pb_homedifficile7.TabStop = false;
            // 
            // pictureBox141
            // 
            this.pictureBox141.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_7_removebg_preview__1_1;
            this.pictureBox141.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox141.Location = new System.Drawing.Point(179, 21);
            this.pictureBox141.Name = "pictureBox141";
            this.pictureBox141.Size = new System.Drawing.Size(318, 80);
            this.pictureBox141.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox141.TabIndex = 22;
            this.pictureBox141.TabStop = false;
            // 
            // pictureBox152
            // 
            this.pictureBox152.BackgroundImage = global::Football_Quiz.Properties.Resources.porto;
            this.pictureBox152.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox152.Location = new System.Drawing.Point(109, 19);
            this.pictureBox152.Name = "pictureBox152";
            this.pictureBox152.Size = new System.Drawing.Size(443, 292);
            this.pictureBox152.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox152.TabIndex = 10;
            this.pictureBox152.TabStop = false;
            // 
            // pictureBox153
            // 
            this.pictureBox153.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview6;
            this.pictureBox153.Location = new System.Drawing.Point(6, 501);
            this.pictureBox153.Name = "pictureBox153";
            this.pictureBox153.Size = new System.Drawing.Size(60, 77);
            this.pictureBox153.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox153.TabIndex = 4;
            this.pictureBox153.TabStop = false;
            // 
            // pb_indiziodifficile8_2
            // 
            this.pb_indiziodifficile8_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziodifficile8_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile8_2.Name = "pb_indiziodifficile8_2";
            this.pb_indiziodifficile8_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile8_2.TabIndex = 3;
            this.pb_indiziodifficile8_2.TabStop = false;
            // 
            // pb_indiziodifficile8_1
            // 
            this.pb_indiziodifficile8_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziodifficile8_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile8_1.Name = "pb_indiziodifficile8_1";
            this.pb_indiziodifficile8_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile8_1.TabIndex = 2;
            this.pb_indiziodifficile8_1.TabStop = false;
            // 
            // pb_indiziodifficile8_3
            // 
            this.pb_indiziodifficile8_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview7;
            this.pb_indiziodifficile8_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile8_3.Name = "pb_indiziodifficile8_3";
            this.pb_indiziodifficile8_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile8_3.TabIndex = 1;
            this.pb_indiziodifficile8_3.TabStop = false;
            // 
            // pb_frecciavantidifficile8
            // 
            this.pb_frecciavantidifficile8.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview18;
            this.pb_frecciavantidifficile8.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile8.Name = "pb_frecciavantidifficile8";
            this.pb_frecciavantidifficile8.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile8.TabIndex = 0;
            this.pb_frecciavantidifficile8.TabStop = false;
            // 
            // pb_homedifficile8
            // 
            this.pb_homedifficile8.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview6;
            this.pb_homedifficile8.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile8.Name = "pb_homedifficile8";
            this.pb_homedifficile8.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile8.TabIndex = 24;
            this.pb_homedifficile8.TabStop = false;
            // 
            // pictureBox159
            // 
            this.pictureBox159.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_8_removebg_preview__1_1;
            this.pictureBox159.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox159.Location = new System.Drawing.Point(179, 21);
            this.pictureBox159.Name = "pictureBox159";
            this.pictureBox159.Size = new System.Drawing.Size(318, 80);
            this.pictureBox159.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox159.TabIndex = 22;
            this.pictureBox159.TabStop = false;
            // 
            // pictureBox168
            // 
            this.pictureBox168.BackgroundImage = global::Football_Quiz.Properties.Resources.girona;
            this.pictureBox168.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox168.Location = new System.Drawing.Point(109, 19);
            this.pictureBox168.Name = "pictureBox168";
            this.pictureBox168.Size = new System.Drawing.Size(443, 292);
            this.pictureBox168.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox168.TabIndex = 10;
            this.pictureBox168.TabStop = false;
            // 
            // pictureBox169
            // 
            this.pictureBox169.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview6;
            this.pictureBox169.Location = new System.Drawing.Point(6, 501);
            this.pictureBox169.Name = "pictureBox169";
            this.pictureBox169.Size = new System.Drawing.Size(60, 77);
            this.pictureBox169.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox169.TabIndex = 4;
            this.pictureBox169.TabStop = false;
            // 
            // pb_indiziodifficile9_2
            // 
            this.pb_indiziodifficile9_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziodifficile9_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile9_2.Name = "pb_indiziodifficile9_2";
            this.pb_indiziodifficile9_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile9_2.TabIndex = 3;
            this.pb_indiziodifficile9_2.TabStop = false;
            // 
            // pb_indiziodifficile9_1
            // 
            this.pb_indiziodifficile9_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziodifficile9_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile9_1.Name = "pb_indiziodifficile9_1";
            this.pb_indiziodifficile9_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile9_1.TabIndex = 2;
            this.pb_indiziodifficile9_1.TabStop = false;
            // 
            // pb_indiziodifficile9_3
            // 
            this.pb_indiziodifficile9_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview8;
            this.pb_indiziodifficile9_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile9_3.Name = "pb_indiziodifficile9_3";
            this.pb_indiziodifficile9_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile9_3.TabIndex = 1;
            this.pb_indiziodifficile9_3.TabStop = false;
            // 
            // pb_frecciavantidifficile9
            // 
            this.pb_frecciavantidifficile9.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview19;
            this.pb_frecciavantidifficile9.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavantidifficile9.Name = "pb_frecciavantidifficile9";
            this.pb_frecciavantidifficile9.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavantidifficile9.TabIndex = 0;
            this.pb_frecciavantidifficile9.TabStop = false;
            // 
            // pb_homedifficile9
            // 
            this.pb_homedifficile9.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview7;
            this.pb_homedifficile9.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile9.Name = "pb_homedifficile9";
            this.pb_homedifficile9.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile9.TabIndex = 24;
            this.pb_homedifficile9.TabStop = false;
            // 
            // pictureBox175
            // 
            this.pictureBox175.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_9_removebg_preview__1_1;
            this.pictureBox175.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox175.Location = new System.Drawing.Point(179, 21);
            this.pictureBox175.Name = "pictureBox175";
            this.pictureBox175.Size = new System.Drawing.Size(318, 80);
            this.pictureBox175.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox175.TabIndex = 22;
            this.pictureBox175.TabStop = false;
            // 
            // pictureBox183
            // 
            this.pictureBox183.BackgroundImage = global::Football_Quiz.Properties.Resources.sporting_lisbona;
            this.pictureBox183.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox183.Location = new System.Drawing.Point(109, 19);
            this.pictureBox183.Name = "pictureBox183";
            this.pictureBox183.Size = new System.Drawing.Size(443, 292);
            this.pictureBox183.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox183.TabIndex = 10;
            this.pictureBox183.TabStop = false;
            // 
            // pictureBox184
            // 
            this.pictureBox184.BackgroundImage = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview7;
            this.pictureBox184.Location = new System.Drawing.Point(6, 501);
            this.pictureBox184.Name = "pictureBox184";
            this.pictureBox184.Size = new System.Drawing.Size(60, 77);
            this.pictureBox184.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox184.TabIndex = 4;
            this.pictureBox184.TabStop = false;
            // 
            // pb_indiziodifficile10_2
            // 
            this.pb_indiziodifficile10_2.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_indiziodifficile10_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziodifficile10_2.Name = "pb_indiziodifficile10_2";
            this.pb_indiziodifficile10_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile10_2.TabIndex = 3;
            this.pb_indiziodifficile10_2.TabStop = false;
            // 
            // pb_indiziodifficile10_1
            // 
            this.pb_indiziodifficile10_1.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_indiziodifficile10_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziodifficile10_1.Name = "pb_indiziodifficile10_1";
            this.pb_indiziodifficile10_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile10_1.TabIndex = 2;
            this.pb_indiziodifficile10_1.TabStop = false;
            // 
            // pb_indiziodifficile10_3
            // 
            this.pb_indiziodifficile10_3.BackgroundImage = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview9;
            this.pb_indiziodifficile10_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziodifficile10_3.Name = "pb_indiziodifficile10_3";
            this.pb_indiziodifficile10_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziodifficile10_3.TabIndex = 1;
            this.pb_indiziodifficile10_3.TabStop = false;
            // 
            // pb_homedifficile10
            // 
            this.pb_homedifficile10.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview7;
            this.pb_homedifficile10.Location = new System.Drawing.Point(12, 21);
            this.pb_homedifficile10.Name = "pb_homedifficile10";
            this.pb_homedifficile10.Size = new System.Drawing.Size(60, 62);
            this.pb_homedifficile10.TabIndex = 24;
            this.pb_homedifficile10.TabStop = false;
            // 
            // pictureBox189
            // 
            this.pictureBox189.BackgroundImage = global::Football_Quiz.Properties.Resources.scritta_livello_10_removebg_preview__1_1;
            this.pictureBox189.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox189.Location = new System.Drawing.Point(160, 21);
            this.pictureBox189.Name = "pictureBox189";
            this.pictureBox189.Size = new System.Drawing.Size(354, 80);
            this.pictureBox189.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox189.TabIndex = 22;
            this.pictureBox189.TabStop = false;
            // 
            // pictureBox147
            // 
            this.pictureBox147.Location = new System.Drawing.Point(593, 621);
            this.pictureBox147.Name = "pictureBox147";
            this.pictureBox147.Size = new System.Drawing.Size(60, 62);
            this.pictureBox147.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox147.TabIndex = 37;
            this.pictureBox147.TabStop = false;
            // 
            // pictureBox148
            // 
            this.pictureBox148.Location = new System.Drawing.Point(22, 621);
            this.pictureBox148.Name = "pictureBox148";
            this.pictureBox148.Size = new System.Drawing.Size(60, 62);
            this.pictureBox148.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox148.TabIndex = 36;
            this.pictureBox148.TabStop = false;
            // 
            // pictureBox195
            // 
            this.pictureBox195.BackgroundImage = global::Football_Quiz.Properties.Resources.applausi1;
            this.pictureBox195.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox195.Location = new System.Drawing.Point(147, 201);
            this.pictureBox195.Name = "pictureBox195";
            this.pictureBox195.Size = new System.Drawing.Size(403, 371);
            this.pictureBox195.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox195.TabIndex = 35;
            this.pictureBox195.TabStop = false;
            // 
            // pictureBox196
            // 
            this.pictureBox196.BackgroundImage = global::Football_Quiz.Properties.Resources.cambia_giocatore1;
            this.pictureBox196.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox196.Location = new System.Drawing.Point(593, 14);
            this.pictureBox196.Name = "pictureBox196";
            this.pictureBox196.Size = new System.Drawing.Size(60, 62);
            this.pictureBox196.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox196.TabIndex = 34;
            this.pictureBox196.TabStop = false;
            // 
            // pictureBox197
            // 
            this.pictureBox197.BackgroundImage = global::Football_Quiz.Properties.Resources.home_removebg_preview8;
            this.pictureBox197.Location = new System.Drawing.Point(22, 14);
            this.pictureBox197.Name = "pictureBox197";
            this.pictureBox197.Size = new System.Drawing.Size(60, 62);
            this.pictureBox197.TabIndex = 33;
            this.pictureBox197.TabStop = false;
            // 
            // pb_back
            // 
            this.pb_back.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__21_;
            this.pb_back.Location = new System.Drawing.Point(79, 674);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(157, 52);
            this.pb_back.TabIndex = 6;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_nuovogiocatore
            // 
            this.pb_nuovogiocatore.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__20_;
            this.pb_nuovogiocatore.Location = new System.Drawing.Point(87, 559);
            this.pb_nuovogiocatore.Name = "pb_nuovogiocatore";
            this.pb_nuovogiocatore.Size = new System.Drawing.Size(147, 98);
            this.pb_nuovogiocatore.TabIndex = 5;
            this.pb_nuovogiocatore.TabStop = false;
            this.pb_nuovogiocatore.Click += new System.EventHandler(this.pb_nuovogiocatore_Click);
            // 
            // pb_gioca
            // 
            this.pb_gioca.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__18_;
            this.pb_gioca.Location = new System.Drawing.Point(51, 308);
            this.pb_gioca.Name = "pb_gioca";
            this.pb_gioca.Size = new System.Drawing.Size(206, 164);
            this.pb_gioca.TabIndex = 4;
            this.pb_gioca.TabStop = false;
            this.pb_gioca.Click += new System.EventHandler(this.pb_gioca_Click);
            // 
            // pb_info
            // 
            this.pb_info.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__17_11;
            this.pb_info.Location = new System.Drawing.Point(14, 0);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(54, 52);
            this.pb_info.TabIndex = 3;
            this.pb_info.TabStop = false;
            this.pb_info.Click += new System.EventHandler(this.pb_info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Football_Quiz.Properties.Resources.Screenshot__16_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 739);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_exit
            // 
            this.pb_exit.BackgroundImage = global::Football_Quiz.Properties.Resources.sfondo_exit;
            this.pb_exit.Location = new System.Drawing.Point(823, 12);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(185, 89);
            this.pb_exit.TabIndex = 3;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_magliette
            // 
            this.pb_magliette.BackgroundImage = global::Football_Quiz.Properties.Resources.play_2;
            this.pb_magliette.Location = new System.Drawing.Point(757, 569);
            this.pb_magliette.Name = "pb_magliette";
            this.pb_magliette.Size = new System.Drawing.Size(180, 98);
            this.pb_magliette.TabIndex = 2;
            this.pb_magliette.TabStop = false;
            this.pb_magliette.Click += new System.EventHandler(this.pb_magliette_Click);
            // 
            // pb_squadre
            // 
            this.pb_squadre.BackgroundImage = global::Football_Quiz.Properties.Resources.play_1;
            this.pb_squadre.Location = new System.Drawing.Point(157, 559);
            this.pb_squadre.Name = "pb_squadre";
            this.pb_squadre.Size = new System.Drawing.Size(194, 98);
            this.pb_squadre.TabIndex = 1;
            this.pb_squadre.TabStop = false;
            this.pb_squadre.Click += new System.EventHandler(this.pb_squadre_Click);
            // 
            // pb_sfondo
            // 
            this.pb_sfondo.BackgroundImage = global::Football_Quiz.Properties.Resources.sfondo_completo;
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
            this.ClientSize = new System.Drawing.Size(1020, 738);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.tbp_1facile.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tbp_2facile.ResumeLayout(false);
            this.tbp_2facile.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tbp_3facile.ResumeLayout(false);
            this.tbp_3facile.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tbp_4facile.ResumeLayout(false);
            this.tbp_4facile.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tbp_5facile.ResumeLayout(false);
            this.tbp_5facile.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tbp_6facile.ResumeLayout(false);
            this.tbp_6facile.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tbp_7facile.ResumeLayout(false);
            this.tbp_7facile.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tbp_8facile.ResumeLayout(false);
            this.tbp_8facile.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tbp_9facile.ResumeLayout(false);
            this.tbp_9facile.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tbp_10facile.ResumeLayout(false);
            this.tbp_10facile.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tbp_finefacile.ResumeLayout(false);
            this.tbp_finefacile.PerformLayout();
            this.tbp_1medio.ResumeLayout(false);
            this.tbp_1medio.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tbp_2medio.ResumeLayout(false);
            this.tbp_2medio.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.tbp_3medio.ResumeLayout(false);
            this.tbp_3medio.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tbp_4medio.ResumeLayout(false);
            this.tbp_4medio.PerformLayout();
            this.tbp_5medio.ResumeLayout(false);
            this.tbp_5medio.PerformLayout();
            this.tbp_6medio.ResumeLayout(false);
            this.tbp_6medio.PerformLayout();
            this.tbp_7medio.ResumeLayout(false);
            this.tbp_7medio.PerformLayout();
            this.tbp_8medio.ResumeLayout(false);
            this.tbp_8medio.PerformLayout();
            this.tbp_9medio.ResumeLayout(false);
            this.tbp_9medio.PerformLayout();
            this.tbp_10medio.ResumeLayout(false);
            this.tbp_10medio.PerformLayout();
            this.tbp_finemedio.ResumeLayout(false);
            this.tbp_finemedio.PerformLayout();
            this.tbp_1difficile.ResumeLayout(false);
            this.tbp_1difficile.PerformLayout();
            this.tbp_2difficile.ResumeLayout(false);
            this.tbp_2difficile.PerformLayout();
            this.tbp_3difficile.ResumeLayout(false);
            this.tbp_3difficile.PerformLayout();
            this.tbp_4difficile.ResumeLayout(false);
            this.tbp_4difficile.PerformLayout();
            this.tbp_5difficile.ResumeLayout(false);
            this.tbp_5difficile.PerformLayout();
            this.tbp_6difficile.ResumeLayout(false);
            this.tbp_6difficile.PerformLayout();
            this.tbp_7difficile.ResumeLayout(false);
            this.tbp_7difficile.PerformLayout();
            this.tbp_8difficile.ResumeLayout(false);
            this.tbp_8difficile.PerformLayout();
            this.tbp_9difficile.ResumeLayout(false);
            this.tbp_9difficile.PerformLayout();
            this.tbp_10difficile.ResumeLayout(false);
            this.tbp_10difficile.PerformLayout();
            this.tbp_finedifficili.ResumeLayout(false);
            this.tbp_finedifficili.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inzidiofacile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti1facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti2facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti3facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti4facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti5facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile6_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile6_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile6_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti6facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indizifacile7_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile7_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti7facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile8_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile8_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile8_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti8facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile9_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile9_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile9_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti9facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_livellofacile10_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile10_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_livellofacile10_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homelivello1medio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaindietromedio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaindietromedio3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homelivello4medio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio6_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio6_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio6_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox117)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio7_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio7_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox133)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox142)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio8_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio8_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio8_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox160)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox161)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio9_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio9_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio9_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantimedio9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox176)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox177)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio10_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio10_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziomedio10_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homemedio10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox190)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox191)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox192)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox193)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox194)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox204)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox205)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox206)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox212)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox213)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox214)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox220)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox118)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile6_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile6_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile6_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile7_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile7_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox152)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile8_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile8_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile8_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox159)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox168)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox169)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile9_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile9_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile9_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavantidifficile9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox175)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile10_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile10_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziodifficile10_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homedifficile10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox189)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox147)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox148)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox195)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pb_frecciaind2;
        private System.Windows.Forms.PictureBox pb_indiziofacile2_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile2_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile2_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti2facile;
        private System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pb_frecciaind3;
        private System.Windows.Forms.PictureBox pb_indiziofacile3_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile3_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile3_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti3facile;
        private System.Windows.Forms.PictureBox pictureBox54;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pb_frecciaind4;
        private System.Windows.Forms.PictureBox pb_indiziofacile4_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile4_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile4_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti4facile;
        private System.Windows.Forms.PictureBox pictureBox60;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pb_frecciaind5;
        private System.Windows.Forms.PictureBox pb_indiziofacile5_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile5_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile5_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti5facile;
        private System.Windows.Forms.PictureBox pictureBox66;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pb_frecciaind6;
        private System.Windows.Forms.PictureBox pb_indiziofacile6_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile6_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile6_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti6facile;
        private System.Windows.Forms.PictureBox pictureBox72;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.PictureBox pb_frecciaind7;
        private System.Windows.Forms.PictureBox pb_indiziofacile7_2;
        private System.Windows.Forms.PictureBox pb_indizifacile7_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile7_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti7facile;
        private System.Windows.Forms.PictureBox pictureBox78;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.PictureBox pb_frecciaind8;
        private System.Windows.Forms.PictureBox pb_indiziofacile8_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile8_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile8_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti8facile;
        private System.Windows.Forms.PictureBox pictureBox84;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.PictureBox pb_frecciaind9;
        private System.Windows.Forms.PictureBox pb_indiziofacile9_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile9_1;
        private System.Windows.Forms.PictureBox pb_indiziofacile9_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti9facile;
        private System.Windows.Forms.PictureBox pictureBox90;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.PictureBox pb_frecciaind10;
        private System.Windows.Forms.PictureBox pb_livellofacile10_2;
        private System.Windows.Forms.PictureBox pb_indiziofacile10_1;
        private System.Windows.Forms.PictureBox pb_livellofacile10_3;
        private System.Windows.Forms.PictureBox pictureBox96;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pb_indiziofacile1_2;
        private System.Windows.Forms.PictureBox pb_inzidiofacile1;
        private System.Windows.Forms.PictureBox pb_indiziofacile1_3;
        private System.Windows.Forms.PictureBox pb_frecciavanti1facile;
        private System.Windows.Forms.PictureBox pictureBox97;
        private System.Windows.Forms.PictureBox pictureBox98;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.PictureBox pictureBox99;
        private System.Windows.Forms.PictureBox pictureBox100;
        private System.Windows.Forms.PictureBox pictureBox101;
        private System.Windows.Forms.PictureBox pictureBox102;
        private System.Windows.Forms.PictureBox pictureBox103;
        private System.Windows.Forms.PictureBox pictureBox104;
        private System.Windows.Forms.PictureBox pictureBox105;
        private System.Windows.Forms.Label lbl_punteggio1facile;
        private System.Windows.Forms.Label lbl_punteggio2facile;
        private System.Windows.Forms.Label lbl_punteggio3facile;
        private System.Windows.Forms.Label lbl_punteggio4facile;
        private System.Windows.Forms.Label lbl_punteggio5facile;
        private System.Windows.Forms.Label lbl_punteggio6facile;
        private System.Windows.Forms.Label lbl_punteggio7facile;
        private System.Windows.Forms.Label lbl_punteggio8facile;
        private System.Windows.Forms.Label lbl_punteggio9facile;
        private System.Windows.Forms.Label lbl_punteggio10facile;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.Button btn_opzione4facile1;
        private System.Windows.Forms.Button btn_opzione3facile1;
        private System.Windows.Forms.Button btn_opzione2facile1;
        private System.Windows.Forms.Button btn_opzione1facile1;
        private System.Windows.Forms.Label lbl_indizifacile1;
        private System.Windows.Forms.Label lbl_indizifacile2_3;
        private System.Windows.Forms.Button btn_opzione4facile2;
        private System.Windows.Forms.Button btn_opzione3facile2;
        private System.Windows.Forms.Button btn_opzione2facile2;
        private System.Windows.Forms.Button btn_opzione1facile2;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.Label lbl_indizifacile3_3;
        private System.Windows.Forms.Button btn_opzione4facile3;
        private System.Windows.Forms.Button btn_opzione3facile3;
        private System.Windows.Forms.Button btn_opzione2facile3;
        private System.Windows.Forms.Button btn_opzione1facile3;
        private System.Windows.Forms.PictureBox pictureBox46;
        private System.Windows.Forms.Label lbl_indiziofacile4_3;
        private System.Windows.Forms.Button btn_opzione4facile4;
        private System.Windows.Forms.Button btn_opzione3facile4;
        private System.Windows.Forms.Button btn_opzione2facile4;
        private System.Windows.Forms.Button btn_opzione1facile4;
        private System.Windows.Forms.PictureBox pictureBox49;
        private System.Windows.Forms.Label lbl_indizifacile5_3;
        private System.Windows.Forms.Button btn_opzione4facile5;
        private System.Windows.Forms.Button btn_opzione3facile5;
        private System.Windows.Forms.Button btn_opzione2facile5;
        private System.Windows.Forms.Button btn_opzione1facile5;
        private System.Windows.Forms.PictureBox pictureBox53;
        private System.Windows.Forms.Label lbl_indizifacile6_3;
        private System.Windows.Forms.Button btn_opzione4facile6;
        private System.Windows.Forms.Button btn_opzione3facile6;
        private System.Windows.Forms.Button btn_opzione2facile6;
        private System.Windows.Forms.Button btn_opzione1facile6;
        private System.Windows.Forms.PictureBox pictureBox55;
        private System.Windows.Forms.Label lbl_indizifacile7_3;
        private System.Windows.Forms.Button btn_opzione4facile7;
        private System.Windows.Forms.Button btn_opzione3facile7;
        private System.Windows.Forms.Button btn_opzione2facile7;
        private System.Windows.Forms.Button btn_opzione1facile7;
        private System.Windows.Forms.PictureBox pictureBox59;
        private System.Windows.Forms.Label lbl_indizifacile8_3;
        private System.Windows.Forms.Button btn_opzione4facile8;
        private System.Windows.Forms.Button btn_opzione3facile8;
        private System.Windows.Forms.Button btn_opzione2facile8;
        private System.Windows.Forms.Button btn_opzione1facile8;
        private System.Windows.Forms.PictureBox pictureBox61;
        private System.Windows.Forms.Label lbl_indizifacile9_3;
        private System.Windows.Forms.Button btn_opzione4facile9;
        private System.Windows.Forms.Button btn_opzione3facile9;
        private System.Windows.Forms.Button btn_opzione2facile9;
        private System.Windows.Forms.Button btn_opzione1facile9;
        private System.Windows.Forms.PictureBox pictureBox65;
        private System.Windows.Forms.Label lbl_indizifacile10_3;
        private System.Windows.Forms.Button btn_opzione4facile10;
        private System.Windows.Forms.Button btn_opzione3facile10;
        private System.Windows.Forms.Button btn_opzione2facile10;
        private System.Windows.Forms.Button btn_opzione1facile10;
        private System.Windows.Forms.PictureBox pictureBox67;
        private System.Windows.Forms.Label lbl_indiziofacile1_3;
        private System.Windows.Forms.Label lbl_indiziofacile1_1;
        private System.Windows.Forms.Label lbl_indiziofacile1_2;
        private System.Windows.Forms.Label lbl_indizifacile2_1;
        private System.Windows.Forms.Label lbl_indizifacile2_2;
        private System.Windows.Forms.Label lbl_indiziofacile3_1;
        private System.Windows.Forms.Label lbl_indiziofacile3_2;
        private System.Windows.Forms.Label lbl_indiziofacile4_1;
        private System.Windows.Forms.Label lbl_indiziofacile4_2;
        private System.Windows.Forms.Label lbl_indizifacile5_1;
        private System.Windows.Forms.Label lbl_indizifacile5_2;
        private System.Windows.Forms.Label lbl_indizifacile6_1;
        private System.Windows.Forms.Label lbl_indizifacile6_2;
        private System.Windows.Forms.Label lbl_indizifacile7_1;
        private System.Windows.Forms.Label lbl_indizifacile7_2;
        private System.Windows.Forms.Label lbl_indizifacile8_1;
        private System.Windows.Forms.Label lbl_indizifacile8_2;
        private System.Windows.Forms.Label lbl_indizifacile9_1;
        private System.Windows.Forms.Label lbl_indizifacile9_2;
        private System.Windows.Forms.Label lbl_indizifacile10_1;
        private System.Windows.Forms.Label lbl_indizifacile10_2;
        private System.Windows.Forms.TabPage tbp_finefacile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_punteggiofinale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox44;
        private System.Windows.Forms.PictureBox pictureBox43;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.TabPage tbp_1medio;
        private System.Windows.Forms.TabPage tbp_2medio;
        private System.Windows.Forms.TabPage tbp_3medio;
        private System.Windows.Forms.TabPage tbp_4medio;
        private System.Windows.Forms.TabPage tbp_5medio;
        private System.Windows.Forms.TabPage tbp_6medio;
        private System.Windows.Forms.TabPage tbp_7medio;
        private System.Windows.Forms.TabPage tbp_8medio;
        private System.Windows.Forms.TabPage tbp_9medio;
        private System.Windows.Forms.TabPage tbp_10medio;
        private System.Windows.Forms.TabPage tbp_finemedio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_punteggio1medio;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label lbl_indiziomedio1_3;
        private System.Windows.Forms.Label lbl_indiziomedio1_1;
        private System.Windows.Forms.Label lbl_indiziomedio1_2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_opzione4medio1;
        private System.Windows.Forms.Button btn_opzione3medio1;
        private System.Windows.Forms.Button btn_opzione2medio1;
        private System.Windows.Forms.Button btn_opzione1medio1;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.PictureBox pb_indiziomedio1_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio1_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio1_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio1;
        private System.Windows.Forms.PictureBox pb_homelivello1medio;
        private System.Windows.Forms.PictureBox pictureBox58;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lbl_punteggio3medio;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label lbl_indiziomedio3_3;
        private System.Windows.Forms.Label lbl_indiziomedio3_1;
        private System.Windows.Forms.Label lbl_indiziomedio3_2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btn_opzione4medio3;
        private System.Windows.Forms.Button btn_opzione3medio3;
        private System.Windows.Forms.Button btn_opzione2medio3;
        private System.Windows.Forms.Button btn_opzione1medio3;
        private System.Windows.Forms.PictureBox pictureBox73;
        private System.Windows.Forms.PictureBox pb_indiziomedio3_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio3_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio3_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio3;
        private System.Windows.Forms.PictureBox pb_homemedio3;
        private System.Windows.Forms.PictureBox pictureBox80;
        private System.Windows.Forms.TabPage tbp_1difficile;
        private System.Windows.Forms.TabPage tbp_2difficile;
        private System.Windows.Forms.TabPage tbp_3difficile;
        private System.Windows.Forms.TabPage tbp_4difficile;
        private System.Windows.Forms.TabPage tbp_5difficile;
        private System.Windows.Forms.TabPage tbp_6difficile;
        private System.Windows.Forms.TabPage tbp_7difficile;
        private System.Windows.Forms.TabPage tbp_8difficile;
        private System.Windows.Forms.TabPage tbp_9difficile;
        private System.Windows.Forms.TabPage tbp_10difficile;
        private System.Windows.Forms.TabPage tbp_finedifficili;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbl_punteggio2medio;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label lbl_indiziomedio2_1;
        private System.Windows.Forms.Label lbl_indiziomedio2_2;
        private System.Windows.Forms.Label lbl_indiziomedio2_3;
        private System.Windows.Forms.Button btn_opzione4medio2;
        private System.Windows.Forms.Button btn_opzione3medio2;
        private System.Windows.Forms.Button btn_opzione2medio2;
        private System.Windows.Forms.Button btn_opzione1medio2;
        private System.Windows.Forms.PictureBox pictureBox57;
        private System.Windows.Forms.PictureBox pb_frecciaindietromedio2;
        private System.Windows.Forms.PictureBox pb_indiziomedio2_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio2_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio2_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio2;
        private System.Windows.Forms.PictureBox pb_homemedio2;
        private System.Windows.Forms.PictureBox pictureBox71;
        private System.Windows.Forms.PictureBox pb_frecciaindietromedio3;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_opzione4medio4;
        private System.Windows.Forms.Button btn_opzione3medio4;
        private System.Windows.Forms.Button btn_opzione2medio4;
        private System.Windows.Forms.Button btn_opzione1medio4;
        private System.Windows.Forms.PictureBox pictureBox50;
        private System.Windows.Forms.PictureBox pictureBox51;
        private System.Windows.Forms.PictureBox pb_indiziomedio4_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio4_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio4_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio4;
        private System.Windows.Forms.PictureBox pb_homelivello4medio;
        private System.Windows.Forms.PictureBox pictureBox68;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btn_opzione4difficile4;
        private System.Windows.Forms.Button btn_opzione3difficile4;
        private System.Windows.Forms.Button btn_opzione2difficile4;
        private System.Windows.Forms.Button btn_opzione1difficile4;
        private System.Windows.Forms.PictureBox pictureBox69;
        private System.Windows.Forms.PictureBox pictureBox70;
        private System.Windows.Forms.PictureBox pb_indiziodifficile4_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile4_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile4_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile4;
        private System.Windows.Forms.PictureBox pb_homedifficile4;
        private System.Windows.Forms.PictureBox pictureBox81;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button btn_opzione4medio5;
        private System.Windows.Forms.Button btn_opzione3medio5;
        private System.Windows.Forms.Button btn_opzione2medio5;
        private System.Windows.Forms.Button btn_opzione1medio5;
        private System.Windows.Forms.PictureBox pictureBox82;
        private System.Windows.Forms.PictureBox pictureBox83;
        private System.Windows.Forms.PictureBox pb_indiziomedio5_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio5_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio5_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio5;
        private System.Windows.Forms.PictureBox pb_homemedio5;
        private System.Windows.Forms.PictureBox pictureBox91;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button btn_opzione4medio6;
        private System.Windows.Forms.Button btn_opzione3medio6;
        private System.Windows.Forms.Button btn_opzione2medio6;
        private System.Windows.Forms.Button btn_opzione1medio6;
        private System.Windows.Forms.PictureBox pictureBox110;
        private System.Windows.Forms.PictureBox pictureBox111;
        private System.Windows.Forms.PictureBox pb_indiziomedio6_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio6_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio6_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio6;
        private System.Windows.Forms.PictureBox pb_homemedio6;
        private System.Windows.Forms.PictureBox pictureBox117;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button btn_opzione4medio7;
        private System.Windows.Forms.Button btn_opzione3medio7;
        private System.Windows.Forms.Button btn_opzione2medio7;
        private System.Windows.Forms.Button btn_opzione1medio7;
        private System.Windows.Forms.PictureBox pictureBox126;
        private System.Windows.Forms.PictureBox pictureBox127;
        private System.Windows.Forms.PictureBox pb_indiziomedio7_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio7_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio7_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio7;
        private System.Windows.Forms.PictureBox pb_homemedio7;
        private System.Windows.Forms.PictureBox pictureBox133;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button btn_opzione4medio8;
        private System.Windows.Forms.Button btn_opzione3medio8;
        private System.Windows.Forms.Button btn_opzione2medio8;
        private System.Windows.Forms.Button btn_opzione1medio8;
        private System.Windows.Forms.PictureBox pictureBox142;
        private System.Windows.Forms.PictureBox pictureBox143;
        private System.Windows.Forms.PictureBox pb_indiziomedio8_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio8_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio8_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio8;
        private System.Windows.Forms.PictureBox pb_homemedio8;
        private System.Windows.Forms.PictureBox pictureBox151;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Button btn_opzione4medio9;
        private System.Windows.Forms.Button btn_opzione3medio9;
        private System.Windows.Forms.Button btn_opzione2medio9;
        private System.Windows.Forms.Button btn_opzione1medio9;
        private System.Windows.Forms.PictureBox pictureBox160;
        private System.Windows.Forms.PictureBox pictureBox161;
        private System.Windows.Forms.PictureBox pb_indiziomedio9_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio9_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio9_3;
        private System.Windows.Forms.PictureBox pb_frecciavantimedio9;
        private System.Windows.Forms.PictureBox pb_homemedio9;
        private System.Windows.Forms.PictureBox pictureBox167;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Button btn_opzione4medio10;
        private System.Windows.Forms.Button btn_opzione3medio10;
        private System.Windows.Forms.Button btn_opzione2medio10;
        private System.Windows.Forms.Button btn_opzione1medio10;
        private System.Windows.Forms.PictureBox pictureBox176;
        private System.Windows.Forms.PictureBox pictureBox177;
        private System.Windows.Forms.PictureBox pb_indiziomedio10_2;
        private System.Windows.Forms.PictureBox pb_indiziomedio10_1;
        private System.Windows.Forms.PictureBox pb_indiziomedio10_3;
        private System.Windows.Forms.PictureBox pb_homemedio10;
        private System.Windows.Forms.PictureBox pictureBox182;
        private System.Windows.Forms.PictureBox pictureBox190;
        private System.Windows.Forms.PictureBox pictureBox191;
        private System.Windows.Forms.PictureBox pictureBox192;
        private System.Windows.Forms.PictureBox pictureBox193;
        private System.Windows.Forms.PictureBox pictureBox194;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btn_opzione4difficile5;
        private System.Windows.Forms.Button btn_opzione3difficile5;
        private System.Windows.Forms.Button btn_opzione2difficile5;
        private System.Windows.Forms.Button btn_opzione1difficile5;
        private System.Windows.Forms.PictureBox pictureBox92;
        private System.Windows.Forms.PictureBox pictureBox93;
        private System.Windows.Forms.PictureBox pb_indiziodifficile5_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile5_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile5_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile5;
        private System.Windows.Forms.PictureBox pb_homedifficile5;
        private System.Windows.Forms.PictureBox pictureBox109;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btn_opzione4difficile6;
        private System.Windows.Forms.Button btn_opzione3difficile6;
        private System.Windows.Forms.Button btn_opzione2difficile6;
        private System.Windows.Forms.Button btn_opzione1difficile6;
        private System.Windows.Forms.PictureBox pictureBox118;
        private System.Windows.Forms.PictureBox pictureBox119;
        private System.Windows.Forms.PictureBox pb_indiziodifficile6_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile6_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile6_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile6;
        private System.Windows.Forms.PictureBox pb_homedifficile6;
        private System.Windows.Forms.PictureBox pictureBox125;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button btn_opzione4difficile7;
        private System.Windows.Forms.Button btn_opzione3difficile7;
        private System.Windows.Forms.Button btn_opzione2difficile7;
        private System.Windows.Forms.Button btn_opzione1difficile7;
        private System.Windows.Forms.PictureBox pictureBox134;
        private System.Windows.Forms.PictureBox pictureBox135;
        private System.Windows.Forms.PictureBox pb_indiziodifficile7_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile7_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile7_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile7;
        private System.Windows.Forms.PictureBox pb_homedifficile7;
        private System.Windows.Forms.PictureBox pictureBox141;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Button btn_opzione4difficile8;
        private System.Windows.Forms.Button btn_opzione3difficile8;
        private System.Windows.Forms.Button btn_opzione2difficile8;
        private System.Windows.Forms.Button btn_opzione1difficile8;
        private System.Windows.Forms.PictureBox pictureBox152;
        private System.Windows.Forms.PictureBox pictureBox153;
        private System.Windows.Forms.PictureBox pb_indiziodifficile8_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile8_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile8_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile8;
        private System.Windows.Forms.PictureBox pb_homedifficile8;
        private System.Windows.Forms.PictureBox pictureBox159;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Button btn_opzione4difficile9;
        private System.Windows.Forms.Button btn_opzione3difficile9;
        private System.Windows.Forms.Button btn_opzione2difficile9;
        private System.Windows.Forms.Button btn_opzione1difficile9;
        private System.Windows.Forms.PictureBox pictureBox168;
        private System.Windows.Forms.PictureBox pictureBox169;
        private System.Windows.Forms.PictureBox pb_indiziodifficile9_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile9_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile9_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile9;
        private System.Windows.Forms.PictureBox pb_homedifficile9;
        private System.Windows.Forms.PictureBox pictureBox175;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Button btn_opzione4difficile10;
        private System.Windows.Forms.Button btn_opzione3difficile10;
        private System.Windows.Forms.Button btn_opzione2difficile10;
        private System.Windows.Forms.Button btn_opzione1difficile10;
        private System.Windows.Forms.PictureBox pictureBox183;
        private System.Windows.Forms.PictureBox pictureBox184;
        private System.Windows.Forms.PictureBox pb_indiziodifficile10_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile10_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile10_3;
        private System.Windows.Forms.PictureBox pb_homedifficile10;
        private System.Windows.Forms.PictureBox pictureBox189;
        private System.Windows.Forms.PictureBox pictureBox147;
        private System.Windows.Forms.PictureBox pictureBox148;
        private System.Windows.Forms.PictureBox pictureBox195;
        private System.Windows.Forms.PictureBox pictureBox196;
        private System.Windows.Forms.PictureBox pictureBox197;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Button btn_opzione4difficile1;
        private System.Windows.Forms.Button btn_opzione3difficile1;
        private System.Windows.Forms.Button btn_opzione2difficile1;
        private System.Windows.Forms.Button btn_opzione1difficile1;
        private System.Windows.Forms.PictureBox pictureBox198;
        private System.Windows.Forms.PictureBox pb_indiziodifficile1_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile1_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile1_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile1;
        private System.Windows.Forms.PictureBox pb_homedifficile1;
        private System.Windows.Forms.PictureBox pictureBox204;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Button btn_opzione4difficile2;
        private System.Windows.Forms.Button btn_opzione3difficile2;
        private System.Windows.Forms.Button btn_opzione2difficile2;
        private System.Windows.Forms.Button btn_opzione1difficile2;
        private System.Windows.Forms.PictureBox pictureBox205;
        private System.Windows.Forms.PictureBox pictureBox206;
        private System.Windows.Forms.PictureBox pb_indiziodifficile2_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile2_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile2_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile2;
        private System.Windows.Forms.PictureBox pb_homedifficile2;
        private System.Windows.Forms.PictureBox pictureBox212;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.PictureBox pictureBox213;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Button btn_opzione4difficile3;
        private System.Windows.Forms.Button btn_opzione3difficile3;
        private System.Windows.Forms.Button btn_opzione2difficile3;
        private System.Windows.Forms.Button btn_opzione1difficile3;
        private System.Windows.Forms.PictureBox pictureBox214;
        private System.Windows.Forms.PictureBox pb_indiziodifficile3_2;
        private System.Windows.Forms.PictureBox pb_indiziodifficile3_1;
        private System.Windows.Forms.PictureBox pb_indiziodifficile3_3;
        private System.Windows.Forms.PictureBox pb_frecciavantidifficile3;
        private System.Windows.Forms.PictureBox pb_homedifficile3;
        private System.Windows.Forms.PictureBox pictureBox220;
    }
}

