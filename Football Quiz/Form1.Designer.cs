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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_nuovogiocatore = new System.Windows.Forms.PictureBox();
            this.pb_gioca = new System.Windows.Forms.PictureBox();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_magliette = new System.Windows.Forms.PictureBox();
            this.pb_squadre = new System.Windows.Forms.PictureBox();
            this.pb_sfondo = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nuovogiocatore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gioca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_magliette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_squadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sfondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
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
            this.tbc_squadre.Controls.Add(this.tbp_finefacile);
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
            this.tbp_giocatore.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.tbp_giocofacile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 107);
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
            this.tbp_finefacile.Controls.Add(this.label7);
            this.tbp_finefacile.Controls.Add(this.label6);
            this.tbp_finefacile.Location = new System.Drawing.Point(4, 22);
            this.tbp_finefacile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "PUNTEGGIO ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "COMPLIMENTI HAI FINITO I LIVELLO FACILE, IL TUO PUNTEGGIO FINALE È DI:";
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
            this.pictureBox4.Location = new System.Drawing.Point(267, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 128);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(482, 287);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 128);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(267, 287);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 128);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(48, 287);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(131, 128);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(48, 153);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(131, 128);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(482, 19);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(131, 128);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(48, 19);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(131, 128);
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(267, 19);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(131, 128);
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(482, 153);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(131, 128);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(267, 153);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(131, 128);
            this.pictureBox13.TabIndex = 22;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(214, 21);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(272, 80);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(267, 421);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(131, 128);
            this.pictureBox15.TabIndex = 31;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(482, 287);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(131, 128);
            this.pictureBox16.TabIndex = 30;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(267, 287);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(131, 128);
            this.pictureBox17.TabIndex = 29;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(48, 287);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(131, 128);
            this.pictureBox18.TabIndex = 28;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(48, 153);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(131, 128);
            this.pictureBox19.TabIndex = 27;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(482, 19);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(131, 128);
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(48, 19);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(131, 128);
            this.pictureBox21.TabIndex = 25;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(267, 19);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(131, 128);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(482, 153);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(131, 128);
            this.pictureBox23.TabIndex = 23;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(267, 153);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(131, 128);
            this.pictureBox24.TabIndex = 22;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(214, 21);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(272, 80);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox25.TabIndex = 13;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(267, 421);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(131, 128);
            this.pictureBox26.TabIndex = 31;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Location = new System.Drawing.Point(482, 287);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(131, 128);
            this.pictureBox27.TabIndex = 30;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Location = new System.Drawing.Point(267, 287);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(131, 128);
            this.pictureBox28.TabIndex = 29;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Location = new System.Drawing.Point(48, 287);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(131, 128);
            this.pictureBox29.TabIndex = 28;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Location = new System.Drawing.Point(48, 153);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(131, 128);
            this.pictureBox30.TabIndex = 27;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Location = new System.Drawing.Point(482, 19);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(131, 128);
            this.pictureBox31.TabIndex = 26;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Location = new System.Drawing.Point(48, 19);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(131, 128);
            this.pictureBox32.TabIndex = 25;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(267, 19);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(131, 128);
            this.pictureBox33.TabIndex = 24;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Location = new System.Drawing.Point(482, 153);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(131, 128);
            this.pictureBox34.TabIndex = 23;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Location = new System.Drawing.Point(267, 153);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(131, 128);
            this.pictureBox35.TabIndex = 22;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Location = new System.Drawing.Point(214, 21);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(272, 80);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox36.TabIndex = 13;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Location = new System.Drawing.Point(109, 24);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(443, 292);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 4;
            this.pictureBox37.TabStop = false;
            // 
            // pb_indiziofacile1_2
            // 
            this.pb_indiziofacile1_2.Location = new System.Drawing.Point(606, 349);
            this.pb_indiziofacile1_2.Name = "pb_indiziofacile1_2";
            this.pb_indiziofacile1_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile1_2.TabIndex = 3;
            this.pb_indiziofacile1_2.TabStop = false;
            this.pb_indiziofacile1_2.Click += new System.EventHandler(this.pb_indiziofacile1_2_Click);
            // 
            // pb_inzidiofacile1
            // 
            this.pb_inzidiofacile1.Location = new System.Drawing.Point(606, 290);
            this.pb_inzidiofacile1.Name = "pb_inzidiofacile1";
            this.pb_inzidiofacile1.Size = new System.Drawing.Size(48, 53);
            this.pb_inzidiofacile1.TabIndex = 2;
            this.pb_inzidiofacile1.TabStop = false;
            this.pb_inzidiofacile1.Click += new System.EventHandler(this.pb_inzidiofacile1_Click);
            // 
            // pb_indiziofacile1_3
            // 
            this.pb_indiziofacile1_3.Location = new System.Drawing.Point(606, 408);
            this.pb_indiziofacile1_3.Name = "pb_indiziofacile1_3";
            this.pb_indiziofacile1_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile1_3.TabIndex = 1;
            this.pb_indiziofacile1_3.TabStop = false;
            this.pb_indiziofacile1_3.Click += new System.EventHandler(this.pb_indiziofacile1_3_Click);
            // 
            // pb_frecciavanti1facile
            // 
            this.pb_frecciavanti1facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti1facile.Name = "pb_frecciavanti1facile";
            this.pb_frecciavanti1facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti1facile.TabIndex = 0;
            this.pb_frecciavanti1facile.TabStop = false;
            this.pb_frecciavanti1facile.Click += new System.EventHandler(this.pb_frecciavanti1facile_Click);
            // 
            // pictureBox97
            // 
            this.pictureBox97.Location = new System.Drawing.Point(12, 21);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(60, 62);
            this.pictureBox97.TabIndex = 17;
            this.pictureBox97.TabStop = false;
            this.pictureBox97.Click += new System.EventHandler(this.pictureBox97_Click);
            // 
            // pictureBox47
            // 
            this.pictureBox47.Location = new System.Drawing.Point(179, 21);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(318, 80);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox47.TabIndex = 15;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Location = new System.Drawing.Point(109, 19);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(443, 292);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox42.TabIndex = 10;
            this.pictureBox42.TabStop = false;
            // 
            // pb_frecciaind2
            // 
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
            this.pb_indiziofacile2_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile2_2.Name = "pb_indiziofacile2_2";
            this.pb_indiziofacile2_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile2_2.TabIndex = 3;
            this.pb_indiziofacile2_2.TabStop = false;
            this.pb_indiziofacile2_2.Click += new System.EventHandler(this.pb_indiziofacile2_2_Click);
            // 
            // pb_indiziofacile2_1
            // 
            this.pb_indiziofacile2_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile2_1.Name = "pb_indiziofacile2_1";
            this.pb_indiziofacile2_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile2_1.TabIndex = 2;
            this.pb_indiziofacile2_1.TabStop = false;
            this.pb_indiziofacile2_1.Click += new System.EventHandler(this.pb_indiziofacile2_1_Click);
            // 
            // pb_indiziofacile2_3
            // 
            this.pb_indiziofacile2_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile2_3.Name = "pb_indiziofacile2_3";
            this.pb_indiziofacile2_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile2_3.TabIndex = 1;
            this.pb_indiziofacile2_3.TabStop = false;
            this.pb_indiziofacile2_3.Click += new System.EventHandler(this.pb_indiziofacile2_3_Click);
            // 
            // pb_frecciavanti2facile
            // 
            this.pb_frecciavanti2facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti2facile.Name = "pb_frecciavanti2facile";
            this.pb_frecciavanti2facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti2facile.TabIndex = 0;
            this.pb_frecciavanti2facile.TabStop = false;
            this.pb_frecciavanti2facile.Click += new System.EventHandler(this.pb_frecciavanti2facile_Click);
            // 
            // pictureBox98
            // 
            this.pictureBox98.Location = new System.Drawing.Point(12, 21);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(60, 62);
            this.pictureBox98.TabIndex = 5;
            this.pictureBox98.TabStop = false;
            this.pictureBox98.Click += new System.EventHandler(this.pictureBox98_Click);
            // 
            // pictureBox48
            // 
            this.pictureBox48.Location = new System.Drawing.Point(179, 21);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(318, 80);
            this.pictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox48.TabIndex = 17;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Location = new System.Drawing.Point(109, 19);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(443, 292);
            this.pictureBox46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox46.TabIndex = 10;
            this.pictureBox46.TabStop = false;
            // 
            // pb_frecciaind3
            // 
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
            this.pb_indiziofacile3_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile3_2.Name = "pb_indiziofacile3_2";
            this.pb_indiziofacile3_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile3_2.TabIndex = 3;
            this.pb_indiziofacile3_2.TabStop = false;
            this.pb_indiziofacile3_2.Click += new System.EventHandler(this.pb_indiziofacile3_2_Click);
            // 
            // pb_indiziofacile3_1
            // 
            this.pb_indiziofacile3_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile3_1.Name = "pb_indiziofacile3_1";
            this.pb_indiziofacile3_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile3_1.TabIndex = 2;
            this.pb_indiziofacile3_1.TabStop = false;
            this.pb_indiziofacile3_1.Click += new System.EventHandler(this.pb_indiziofacile3_1_Click);
            // 
            // pb_indiziofacile3_3
            // 
            this.pb_indiziofacile3_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile3_3.Name = "pb_indiziofacile3_3";
            this.pb_indiziofacile3_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile3_3.TabIndex = 1;
            this.pb_indiziofacile3_3.TabStop = false;
            this.pb_indiziofacile3_3.Click += new System.EventHandler(this.pb_indiziofacile3_3_Click);
            // 
            // pb_frecciavanti3facile
            // 
            this.pb_frecciavanti3facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti3facile.Name = "pb_frecciavanti3facile";
            this.pb_frecciavanti3facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti3facile.TabIndex = 0;
            this.pb_frecciavanti3facile.TabStop = false;
            this.pb_frecciavanti3facile.Click += new System.EventHandler(this.pb_frecciavanti3facile_Click);
            // 
            // pictureBox41
            // 
            this.pictureBox41.Location = new System.Drawing.Point(12, 21);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(60, 62);
            this.pictureBox41.TabIndex = 19;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Click += new System.EventHandler(this.pictureBox41_Click);
            // 
            // pictureBox54
            // 
            this.pictureBox54.Location = new System.Drawing.Point(179, 21);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(318, 80);
            this.pictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox54.TabIndex = 17;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.Location = new System.Drawing.Point(109, 19);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(443, 292);
            this.pictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox49.TabIndex = 10;
            this.pictureBox49.TabStop = false;
            // 
            // pb_frecciaind4
            // 
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
            this.pb_indiziofacile4_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile4_2.Name = "pb_indiziofacile4_2";
            this.pb_indiziofacile4_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile4_2.TabIndex = 3;
            this.pb_indiziofacile4_2.TabStop = false;
            // 
            // pb_indiziofacile4_1
            // 
            this.pb_indiziofacile4_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile4_1.Name = "pb_indiziofacile4_1";
            this.pb_indiziofacile4_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile4_1.TabIndex = 2;
            this.pb_indiziofacile4_1.TabStop = false;
            // 
            // pb_indiziofacile4_3
            // 
            this.pb_indiziofacile4_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile4_3.Name = "pb_indiziofacile4_3";
            this.pb_indiziofacile4_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile4_3.TabIndex = 1;
            this.pb_indiziofacile4_3.TabStop = false;
            // 
            // pb_frecciavanti4facile
            // 
            this.pb_frecciavanti4facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti4facile.Name = "pb_frecciavanti4facile";
            this.pb_frecciavanti4facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti4facile.TabIndex = 0;
            this.pb_frecciavanti4facile.TabStop = false;
            this.pb_frecciavanti4facile.Click += new System.EventHandler(this.pb_frecciavanti4facile_Click);
            // 
            // pictureBox99
            // 
            this.pictureBox99.Location = new System.Drawing.Point(12, 21);
            this.pictureBox99.Name = "pictureBox99";
            this.pictureBox99.Size = new System.Drawing.Size(60, 62);
            this.pictureBox99.TabIndex = 19;
            this.pictureBox99.TabStop = false;
            this.pictureBox99.Click += new System.EventHandler(this.pictureBox99_Click);
            // 
            // pictureBox60
            // 
            this.pictureBox60.Location = new System.Drawing.Point(179, 21);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(318, 80);
            this.pictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox60.TabIndex = 17;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.Location = new System.Drawing.Point(109, 19);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(443, 292);
            this.pictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox53.TabIndex = 10;
            this.pictureBox53.TabStop = false;
            // 
            // pb_frecciaind5
            // 
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
            this.pb_indiziofacile5_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile5_2.Name = "pb_indiziofacile5_2";
            this.pb_indiziofacile5_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile5_2.TabIndex = 3;
            this.pb_indiziofacile5_2.TabStop = false;
            this.pb_indiziofacile5_2.Click += new System.EventHandler(this.pb_indiziofacile5_2_Click);
            // 
            // pb_indiziofacile5_1
            // 
            this.pb_indiziofacile5_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile5_1.Name = "pb_indiziofacile5_1";
            this.pb_indiziofacile5_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile5_1.TabIndex = 2;
            this.pb_indiziofacile5_1.TabStop = false;
            this.pb_indiziofacile5_1.Click += new System.EventHandler(this.pb_indiziofacile5_1_Click);
            // 
            // pb_indiziofacile5_3
            // 
            this.pb_indiziofacile5_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile5_3.Name = "pb_indiziofacile5_3";
            this.pb_indiziofacile5_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile5_3.TabIndex = 1;
            this.pb_indiziofacile5_3.TabStop = false;
            this.pb_indiziofacile5_3.Click += new System.EventHandler(this.pb_indiziofacile5_3_Click);
            // 
            // pb_frecciavanti5facile
            // 
            this.pb_frecciavanti5facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti5facile.Name = "pb_frecciavanti5facile";
            this.pb_frecciavanti5facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti5facile.TabIndex = 0;
            this.pb_frecciavanti5facile.TabStop = false;
            this.pb_frecciavanti5facile.Click += new System.EventHandler(this.pb_frecciavanti5facile_Click);
            // 
            // pictureBox100
            // 
            this.pictureBox100.Location = new System.Drawing.Point(12, 21);
            this.pictureBox100.Name = "pictureBox100";
            this.pictureBox100.Size = new System.Drawing.Size(60, 62);
            this.pictureBox100.TabIndex = 19;
            this.pictureBox100.TabStop = false;
            this.pictureBox100.Click += new System.EventHandler(this.pictureBox100_Click);
            // 
            // pictureBox66
            // 
            this.pictureBox66.Location = new System.Drawing.Point(179, 21);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(318, 80);
            this.pictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox66.TabIndex = 17;
            this.pictureBox66.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Location = new System.Drawing.Point(109, 19);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(443, 292);
            this.pictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox55.TabIndex = 10;
            this.pictureBox55.TabStop = false;
            // 
            // pb_frecciaind6
            // 
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
            this.pb_indiziofacile6_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile6_2.Name = "pb_indiziofacile6_2";
            this.pb_indiziofacile6_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile6_2.TabIndex = 3;
            this.pb_indiziofacile6_2.TabStop = false;
            this.pb_indiziofacile6_2.Click += new System.EventHandler(this.pb_indiziofacile6_2_Click);
            // 
            // pb_indiziofacile6_1
            // 
            this.pb_indiziofacile6_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile6_1.Name = "pb_indiziofacile6_1";
            this.pb_indiziofacile6_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile6_1.TabIndex = 2;
            this.pb_indiziofacile6_1.TabStop = false;
            this.pb_indiziofacile6_1.Click += new System.EventHandler(this.pb_indiziofacile6_1_Click);
            // 
            // pb_indiziofacile6_3
            // 
            this.pb_indiziofacile6_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile6_3.Name = "pb_indiziofacile6_3";
            this.pb_indiziofacile6_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile6_3.TabIndex = 1;
            this.pb_indiziofacile6_3.TabStop = false;
            this.pb_indiziofacile6_3.Click += new System.EventHandler(this.pb_indiziofacile6_3_Click);
            // 
            // pb_frecciavanti6facile
            // 
            this.pb_frecciavanti6facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti6facile.Name = "pb_frecciavanti6facile";
            this.pb_frecciavanti6facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti6facile.TabIndex = 0;
            this.pb_frecciavanti6facile.TabStop = false;
            this.pb_frecciavanti6facile.Click += new System.EventHandler(this.pb_frecciavanti6facile_Click);
            // 
            // pictureBox101
            // 
            this.pictureBox101.Location = new System.Drawing.Point(12, 21);
            this.pictureBox101.Name = "pictureBox101";
            this.pictureBox101.Size = new System.Drawing.Size(60, 62);
            this.pictureBox101.TabIndex = 19;
            this.pictureBox101.TabStop = false;
            this.pictureBox101.Click += new System.EventHandler(this.pictureBox101_Click);
            // 
            // pictureBox72
            // 
            this.pictureBox72.Location = new System.Drawing.Point(179, 21);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(318, 80);
            this.pictureBox72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox72.TabIndex = 17;
            this.pictureBox72.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Location = new System.Drawing.Point(109, 19);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(443, 292);
            this.pictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox59.TabIndex = 10;
            this.pictureBox59.TabStop = false;
            // 
            // pb_frecciaind7
            // 
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
            this.pb_indiziofacile7_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile7_2.Name = "pb_indiziofacile7_2";
            this.pb_indiziofacile7_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile7_2.TabIndex = 3;
            this.pb_indiziofacile7_2.TabStop = false;
            this.pb_indiziofacile7_2.Click += new System.EventHandler(this.pb_indiziofacile7_2_Click);
            // 
            // pb_indizifacile7_1
            // 
            this.pb_indizifacile7_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indizifacile7_1.Name = "pb_indizifacile7_1";
            this.pb_indizifacile7_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indizifacile7_1.TabIndex = 2;
            this.pb_indizifacile7_1.TabStop = false;
            this.pb_indizifacile7_1.Click += new System.EventHandler(this.pb_indizifacile7_1_Click);
            // 
            // pb_indiziofacile7_3
            // 
            this.pb_indiziofacile7_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile7_3.Name = "pb_indiziofacile7_3";
            this.pb_indiziofacile7_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile7_3.TabIndex = 1;
            this.pb_indiziofacile7_3.TabStop = false;
            this.pb_indiziofacile7_3.Click += new System.EventHandler(this.pb_indiziofacile7_3_Click);
            // 
            // pb_frecciavanti7facile
            // 
            this.pb_frecciavanti7facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti7facile.Name = "pb_frecciavanti7facile";
            this.pb_frecciavanti7facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti7facile.TabIndex = 0;
            this.pb_frecciavanti7facile.TabStop = false;
            this.pb_frecciavanti7facile.Click += new System.EventHandler(this.pb_frecciavanti7facile_Click);
            // 
            // pictureBox102
            // 
            this.pictureBox102.Location = new System.Drawing.Point(12, 21);
            this.pictureBox102.Name = "pictureBox102";
            this.pictureBox102.Size = new System.Drawing.Size(60, 62);
            this.pictureBox102.TabIndex = 19;
            this.pictureBox102.TabStop = false;
            this.pictureBox102.Click += new System.EventHandler(this.pictureBox102_Click);
            // 
            // pictureBox78
            // 
            this.pictureBox78.Location = new System.Drawing.Point(179, 21);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(318, 80);
            this.pictureBox78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox78.TabIndex = 17;
            this.pictureBox78.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.Location = new System.Drawing.Point(109, 19);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(443, 292);
            this.pictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox61.TabIndex = 10;
            this.pictureBox61.TabStop = false;
            // 
            // pb_frecciaind8
            // 
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
            this.pb_indiziofacile8_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile8_2.Name = "pb_indiziofacile8_2";
            this.pb_indiziofacile8_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile8_2.TabIndex = 3;
            this.pb_indiziofacile8_2.TabStop = false;
            this.pb_indiziofacile8_2.Click += new System.EventHandler(this.pb_indiziofacile8_2_Click);
            // 
            // pb_indiziofacile8_1
            // 
            this.pb_indiziofacile8_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile8_1.Name = "pb_indiziofacile8_1";
            this.pb_indiziofacile8_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile8_1.TabIndex = 2;
            this.pb_indiziofacile8_1.TabStop = false;
            this.pb_indiziofacile8_1.Click += new System.EventHandler(this.pb_indiziofacile8_1_Click);
            // 
            // pb_indiziofacile8_3
            // 
            this.pb_indiziofacile8_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile8_3.Name = "pb_indiziofacile8_3";
            this.pb_indiziofacile8_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile8_3.TabIndex = 1;
            this.pb_indiziofacile8_3.TabStop = false;
            this.pb_indiziofacile8_3.Click += new System.EventHandler(this.pb_indiziofacile8_3_Click);
            // 
            // pb_frecciavanti8facile
            // 
            this.pb_frecciavanti8facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti8facile.Name = "pb_frecciavanti8facile";
            this.pb_frecciavanti8facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti8facile.TabIndex = 0;
            this.pb_frecciavanti8facile.TabStop = false;
            this.pb_frecciavanti8facile.Click += new System.EventHandler(this.pb_frecciavanti8facile_Click);
            // 
            // pictureBox103
            // 
            this.pictureBox103.Location = new System.Drawing.Point(12, 21);
            this.pictureBox103.Name = "pictureBox103";
            this.pictureBox103.Size = new System.Drawing.Size(60, 62);
            this.pictureBox103.TabIndex = 19;
            this.pictureBox103.TabStop = false;
            this.pictureBox103.Click += new System.EventHandler(this.pictureBox103_Click);
            // 
            // pictureBox84
            // 
            this.pictureBox84.Location = new System.Drawing.Point(179, 21);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(318, 80);
            this.pictureBox84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox84.TabIndex = 17;
            this.pictureBox84.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.Location = new System.Drawing.Point(109, 19);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(443, 292);
            this.pictureBox65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox65.TabIndex = 10;
            this.pictureBox65.TabStop = false;
            // 
            // pb_frecciaind9
            // 
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
            this.pb_indiziofacile9_2.Location = new System.Drawing.Point(606, 344);
            this.pb_indiziofacile9_2.Name = "pb_indiziofacile9_2";
            this.pb_indiziofacile9_2.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile9_2.TabIndex = 3;
            this.pb_indiziofacile9_2.TabStop = false;
            this.pb_indiziofacile9_2.Click += new System.EventHandler(this.pb_indiziofacile9_2_Click);
            // 
            // pb_indiziofacile9_1
            // 
            this.pb_indiziofacile9_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile9_1.Name = "pb_indiziofacile9_1";
            this.pb_indiziofacile9_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile9_1.TabIndex = 2;
            this.pb_indiziofacile9_1.TabStop = false;
            this.pb_indiziofacile9_1.Click += new System.EventHandler(this.pb_indiziofacile9_1_Click);
            // 
            // pb_indiziofacile9_3
            // 
            this.pb_indiziofacile9_3.Location = new System.Drawing.Point(606, 403);
            this.pb_indiziofacile9_3.Name = "pb_indiziofacile9_3";
            this.pb_indiziofacile9_3.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile9_3.TabIndex = 1;
            this.pb_indiziofacile9_3.TabStop = false;
            this.pb_indiziofacile9_3.Click += new System.EventHandler(this.pb_indiziofacile9_3_Click);
            // 
            // pb_frecciavanti9facile
            // 
            this.pb_frecciavanti9facile.Location = new System.Drawing.Point(594, 501);
            this.pb_frecciavanti9facile.Name = "pb_frecciavanti9facile";
            this.pb_frecciavanti9facile.Size = new System.Drawing.Size(60, 62);
            this.pb_frecciavanti9facile.TabIndex = 0;
            this.pb_frecciavanti9facile.TabStop = false;
            this.pb_frecciavanti9facile.Click += new System.EventHandler(this.pb_frecciavanti9facile_Click);
            // 
            // pictureBox104
            // 
            this.pictureBox104.Location = new System.Drawing.Point(12, 21);
            this.pictureBox104.Name = "pictureBox104";
            this.pictureBox104.Size = new System.Drawing.Size(60, 62);
            this.pictureBox104.TabIndex = 19;
            this.pictureBox104.TabStop = false;
            this.pictureBox104.Click += new System.EventHandler(this.pictureBox104_Click);
            // 
            // pictureBox90
            // 
            this.pictureBox90.Location = new System.Drawing.Point(179, 21);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(318, 80);
            this.pictureBox90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox90.TabIndex = 17;
            this.pictureBox90.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.Location = new System.Drawing.Point(109, 19);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(443, 292);
            this.pictureBox67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox67.TabIndex = 10;
            this.pictureBox67.TabStop = false;
            // 
            // pb_frecciaind10
            // 
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
            this.pb_livellofacile10_2.Location = new System.Drawing.Point(606, 344);
            this.pb_livellofacile10_2.Name = "pb_livellofacile10_2";
            this.pb_livellofacile10_2.Size = new System.Drawing.Size(48, 53);
            this.pb_livellofacile10_2.TabIndex = 3;
            this.pb_livellofacile10_2.TabStop = false;
            this.pb_livellofacile10_2.Click += new System.EventHandler(this.pb_livellofacile10_2_Click);
            // 
            // pb_indiziofacile10_1
            // 
            this.pb_indiziofacile10_1.Location = new System.Drawing.Point(606, 285);
            this.pb_indiziofacile10_1.Name = "pb_indiziofacile10_1";
            this.pb_indiziofacile10_1.Size = new System.Drawing.Size(48, 53);
            this.pb_indiziofacile10_1.TabIndex = 2;
            this.pb_indiziofacile10_1.TabStop = false;
            this.pb_indiziofacile10_1.Click += new System.EventHandler(this.pb_indiziofacile10_1_Click);
            // 
            // pb_livellofacile10_3
            // 
            this.pb_livellofacile10_3.Location = new System.Drawing.Point(606, 403);
            this.pb_livellofacile10_3.Name = "pb_livellofacile10_3";
            this.pb_livellofacile10_3.Size = new System.Drawing.Size(48, 53);
            this.pb_livellofacile10_3.TabIndex = 1;
            this.pb_livellofacile10_3.TabStop = false;
            this.pb_livellofacile10_3.Click += new System.EventHandler(this.pb_livellofacile10_3_Click);
            // 
            // pictureBox105
            // 
            this.pictureBox105.Location = new System.Drawing.Point(12, 21);
            this.pictureBox105.Name = "pictureBox105";
            this.pictureBox105.Size = new System.Drawing.Size(60, 62);
            this.pictureBox105.TabIndex = 19;
            this.pictureBox105.TabStop = false;
            this.pictureBox105.Click += new System.EventHandler(this.pictureBox105_Click);
            // 
            // pictureBox96
            // 
            this.pictureBox96.Location = new System.Drawing.Point(160, 21);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(354, 80);
            this.pictureBox96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox96.TabIndex = 17;
            this.pictureBox96.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Location = new System.Drawing.Point(141, 200);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(403, 371);
            this.pictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox44.TabIndex = 24;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Location = new System.Drawing.Point(587, 13);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(60, 62);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox39.TabIndex = 21;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Location = new System.Drawing.Point(16, 13);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(60, 62);
            this.pictureBox38.TabIndex = 20;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Click += new System.EventHandler(this.pictureBox38_Click);
            // 
            // pb_back
            // 
            this.pb_back.Location = new System.Drawing.Point(79, 674);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(157, 52);
            this.pb_back.TabIndex = 6;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_nuovogiocatore
            // 
            this.pb_nuovogiocatore.Location = new System.Drawing.Point(87, 559);
            this.pb_nuovogiocatore.Name = "pb_nuovogiocatore";
            this.pb_nuovogiocatore.Size = new System.Drawing.Size(147, 98);
            this.pb_nuovogiocatore.TabIndex = 5;
            this.pb_nuovogiocatore.TabStop = false;
            this.pb_nuovogiocatore.Click += new System.EventHandler(this.pb_nuovogiocatore_Click);
            // 
            // pb_gioca
            // 
            this.pb_gioca.Location = new System.Drawing.Point(51, 308);
            this.pb_gioca.Name = "pb_gioca";
            this.pb_gioca.Size = new System.Drawing.Size(206, 164);
            this.pb_gioca.TabIndex = 4;
            this.pb_gioca.TabStop = false;
            this.pb_gioca.Click += new System.EventHandler(this.pb_gioca_Click);
            // 
            // pb_info
            // 
            this.pb_info.Location = new System.Drawing.Point(14, 0);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(54, 52);
            this.pb_info.TabIndex = 3;
            this.pb_info.TabStop = false;
            this.pb_info.Click += new System.EventHandler(this.pb_info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 739);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_exit
            // 
            this.pb_exit.Location = new System.Drawing.Point(823, 12);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(185, 89);
            this.pb_exit.TabIndex = 3;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_magliette
            // 
            this.pb_magliette.Location = new System.Drawing.Point(757, 569);
            this.pb_magliette.Name = "pb_magliette";
            this.pb_magliette.Size = new System.Drawing.Size(180, 98);
            this.pb_magliette.TabIndex = 2;
            this.pb_magliette.TabStop = false;
            this.pb_magliette.Click += new System.EventHandler(this.pb_magliette_Click);
            // 
            // pb_squadre
            // 
            this.pb_squadre.Location = new System.Drawing.Point(157, 559);
            this.pb_squadre.Name = "pb_squadre";
            this.pb_squadre.Size = new System.Drawing.Size(194, 98);
            this.pb_squadre.TabIndex = 1;
            this.pb_squadre.TabStop = false;
            this.pb_squadre.Click += new System.EventHandler(this.pb_squadre_Click);
            // 
            // pb_sfondo
            // 
            this.pb_sfondo.Location = new System.Drawing.Point(-2, 1);
            this.pb_sfondo.Name = "pb_sfondo";
            this.pb_sfondo.Size = new System.Drawing.Size(1022, 703);
            this.pb_sfondo.TabIndex = 0;
            this.pb_sfondo.TabStop = false;
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
            // pictureBox43
            // 
            this.pictureBox43.Location = new System.Drawing.Point(587, 620);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(60, 62);
            this.pictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox43.TabIndex = 26;
            this.pictureBox43.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nuovogiocatore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gioca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_magliette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_squadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sfondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
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
        private System.Windows.Forms.Label label7;
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
    }
}

