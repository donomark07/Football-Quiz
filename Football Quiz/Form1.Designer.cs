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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.tbp_giocomedio = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.tbp_giocodifficile = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.tbp_1facile = new System.Windows.Forms.TabPage();
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
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile1_2 = new System.Windows.Forms.PictureBox();
            this.pb_inzidiofacile1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile1_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti1facile = new System.Windows.Forms.PictureBox();
            this.pictureBox97 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.tbp_2facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio2facile = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile2_1 = new System.Windows.Forms.Label();
            this.lbl_indizifacile2_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile2_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile2 = new System.Windows.Forms.Button();
            this.btn_opzione3facile2 = new System.Windows.Forms.Button();
            this.btn_opzione2facile2 = new System.Windows.Forms.Button();
            this.btn_opzione1facile2 = new System.Windows.Forms.Button();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile2_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile2_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile2_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti2facile = new System.Windows.Forms.PictureBox();
            this.pictureBox98 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.tbp_3facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio3facile = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziofacile3_1 = new System.Windows.Forms.Label();
            this.lbl_indiziofacile3_2 = new System.Windows.Forms.Label();
            this.lbl_indizifacile3_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile3 = new System.Windows.Forms.Button();
            this.btn_opzione3facile3 = new System.Windows.Forms.Button();
            this.btn_opzione2facile3 = new System.Windows.Forms.Button();
            this.btn_opzione1facile3 = new System.Windows.Forms.Button();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind3 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile3_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile3_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile3_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti3facile = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.tbp_4facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio4facile = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_indiziofacile4_3 = new System.Windows.Forms.Label();
            this.btn_opzione4facile4 = new System.Windows.Forms.Button();
            this.btn_opzione3facile4 = new System.Windows.Forms.Button();
            this.btn_opzione2facile4 = new System.Windows.Forms.Button();
            this.btn_opzione1facile4 = new System.Windows.Forms.Button();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind4 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile4_2 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile4_1 = new System.Windows.Forms.PictureBox();
            this.pb_indiziofacile4_3 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti4facile = new System.Windows.Forms.PictureBox();
            this.pictureBox99 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.tbp_5facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio5facile = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile5 = new System.Windows.Forms.Label();
            this.btn_opzione4facile5 = new System.Windows.Forms.Button();
            this.btn_opzione3facile5 = new System.Windows.Forms.Button();
            this.btn_opzione2facile5 = new System.Windows.Forms.Button();
            this.btn_opzione1facile5 = new System.Windows.Forms.Button();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind5 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti5facile = new System.Windows.Forms.PictureBox();
            this.pictureBox100 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.tbp_6facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio6facile = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile6 = new System.Windows.Forms.Label();
            this.btn_opzione4facile6 = new System.Windows.Forms.Button();
            this.btn_opzione3facile6 = new System.Windows.Forms.Button();
            this.btn_opzione2facile6 = new System.Windows.Forms.Button();
            this.btn_opzione1facile6 = new System.Windows.Forms.Button();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind6 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti6facile = new System.Windows.Forms.PictureBox();
            this.pictureBox101 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.tbp_7facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio7facile = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile7 = new System.Windows.Forms.Label();
            this.btn_opzione4facile7 = new System.Windows.Forms.Button();
            this.btn_opzione3facile7 = new System.Windows.Forms.Button();
            this.btn_opzione2facile7 = new System.Windows.Forms.Button();
            this.btn_opzione1facile7 = new System.Windows.Forms.Button();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind7 = new System.Windows.Forms.PictureBox();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti7facile = new System.Windows.Forms.PictureBox();
            this.pictureBox102 = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.tbp_8facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio8facile = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile8 = new System.Windows.Forms.Label();
            this.btn_opzione4facile8 = new System.Windows.Forms.Button();
            this.btn_opzione3facile8 = new System.Windows.Forms.Button();
            this.btn_opzione2facile8 = new System.Windows.Forms.Button();
            this.btn_opzione1facile8 = new System.Windows.Forms.Button();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind8 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti8facile = new System.Windows.Forms.PictureBox();
            this.pictureBox103 = new System.Windows.Forms.PictureBox();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.tbp_9facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio9facile = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile9 = new System.Windows.Forms.Label();
            this.btn_opzione4facile9 = new System.Windows.Forms.Button();
            this.btn_opzione3facile9 = new System.Windows.Forms.Button();
            this.btn_opzione2facile9 = new System.Windows.Forms.Button();
            this.btn_opzione1facile9 = new System.Windows.Forms.Button();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind9 = new System.Windows.Forms.PictureBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pb_frecciavanti9facile = new System.Windows.Forms.PictureBox();
            this.pictureBox104 = new System.Windows.Forms.PictureBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.tbp_10facile = new System.Windows.Forms.TabPage();
            this.lbl_punteggio10facile = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lbl_indizifacile10 = new System.Windows.Forms.Label();
            this.btn_opzione4facile10 = new System.Windows.Forms.Button();
            this.btn_opzione3facile10 = new System.Windows.Forms.Button();
            this.btn_opzione2facile10 = new System.Windows.Forms.Button();
            this.btn_opzione1facile10 = new System.Windows.Forms.Button();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pb_frecciaind10 = new System.Windows.Forms.PictureBox();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.pictureBox94 = new System.Windows.Forms.PictureBox();
            this.pictureBox105 = new System.Windows.Forms.PictureBox();
            this.pictureBox96 = new System.Windows.Forms.PictureBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_nuovogiocatore = new System.Windows.Forms.PictureBox();
            this.pb_gioca = new System.Windows.Forms.PictureBox();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.cbo_giocatore = new System.Windows.Forms.ComboBox();
            this.cbo_livello = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_magliette = new System.Windows.Forms.Panel();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_magliette = new System.Windows.Forms.PictureBox();
            this.pb_squadre = new System.Windows.Forms.PictureBox();
            this.pb_sfondo = new System.Windows.Forms.PictureBox();
            this.lbl_indiziofacile4_2 = new System.Windows.Forms.Label();
            this.lbl_indiziofacile4_1 = new System.Windows.Forms.Label();
            this.panel_squadre.SuspendLayout();
            this.tbc_squadre.SuspendLayout();
            this.tbp_giocatore.SuspendLayout();
            this.grb_record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grb_cancella.SuspendLayout();
            this.grb_inserisci.SuspendLayout();
            this.tbp_giocofacile.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tbp_giocomedio.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tbp_giocodifficile.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tbp_1facile.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inzidiofacile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti1facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            this.tbp_2facile.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti2facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            this.tbp_3facile.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti3facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            this.tbp_4facile.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti4facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            this.tbp_5facile.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti5facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            this.tbp_6facile.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti6facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            this.tbp_7facile.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti7facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            this.tbp_8facile.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti8facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            this.tbp_9facile.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti9facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            this.tbp_10facile.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).BeginInit();
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
            this.panel_squadre.Location = new System.Drawing.Point(-3, 1);
            this.panel_squadre.Margin = new System.Windows.Forms.Padding(4);
            this.panel_squadre.Name = "panel_squadre";
            this.panel_squadre.Size = new System.Drawing.Size(1363, 910);
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
            this.tbc_squadre.Location = new System.Drawing.Point(439, 4);
            this.tbc_squadre.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_squadre.Name = "tbc_squadre";
            this.tbc_squadre.SelectedIndex = 0;
            this.tbc_squadre.Size = new System.Drawing.Size(907, 890);
            this.tbc_squadre.TabIndex = 7;
            this.tbc_squadre.Visible = false;
            // 
            // tbp_giocatore
            // 
            this.tbp_giocatore.Controls.Add(this.grb_record);
            this.tbp_giocatore.Controls.Add(this.grb_cancella);
            this.tbp_giocatore.Controls.Add(this.grb_inserisci);
            this.tbp_giocatore.Location = new System.Drawing.Point(4, 25);
            this.tbp_giocatore.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_giocatore.Name = "tbp_giocatore";
            this.tbp_giocatore.Padding = new System.Windows.Forms.Padding(4);
            this.tbp_giocatore.Size = new System.Drawing.Size(899, 861);
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
            this.grb_record.Location = new System.Drawing.Point(31, 586);
            this.grb_record.Margin = new System.Windows.Forms.Padding(4);
            this.grb_record.Name = "grb_record";
            this.grb_record.Padding = new System.Windows.Forms.Padding(4);
            this.grb_record.Size = new System.Drawing.Size(831, 239);
            this.grb_record.TabIndex = 2;
            this.grb_record.TabStop = false;
            this.grb_record.Text = "Record ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Football_Quiz.Properties.Resources.coppa_removebg_preview1;
            this.pictureBox3.Location = new System.Drawing.Point(63, 39);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 192);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "???";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Football_Quiz.Properties.Resources.podio1;
            this.pictureBox2.Location = new System.Drawing.Point(327, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(496, 192);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // grb_cancella
            // 
            this.grb_cancella.Controls.Add(this.btn_cancella);
            this.grb_cancella.Controls.Add(this.label2);
            this.grb_cancella.Controls.Add(this.txb_cancella);
            this.grb_cancella.Location = new System.Drawing.Point(31, 302);
            this.grb_cancella.Margin = new System.Windows.Forms.Padding(4);
            this.grb_cancella.Name = "grb_cancella";
            this.grb_cancella.Padding = new System.Windows.Forms.Padding(4);
            this.grb_cancella.Size = new System.Drawing.Size(831, 239);
            this.grb_cancella.TabIndex = 1;
            this.grb_cancella.TabStop = false;
            this.grb_cancella.Text = "cancella giocatore";
            // 
            // btn_cancella
            // 
            this.btn_cancella.Location = new System.Drawing.Point(19, 98);
            this.btn_cancella.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancella.Name = "btn_cancella";
            this.btn_cancella.Size = new System.Drawing.Size(779, 102);
            this.btn_cancella.TabIndex = 2;
            this.btn_cancella.Text = "cancella";
            this.btn_cancella.UseVisualStyleBackColor = true;
            this.btn_cancella.Click += new System.EventHandler(this.btn_cancella_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserisci nome giocatore da cancellare: ";
            // 
            // txb_cancella
            // 
            this.txb_cancella.Location = new System.Drawing.Point(291, 43);
            this.txb_cancella.Margin = new System.Windows.Forms.Padding(4);
            this.txb_cancella.Name = "txb_cancella";
            this.txb_cancella.Size = new System.Drawing.Size(288, 22);
            this.txb_cancella.TabIndex = 0;
            // 
            // grb_inserisci
            // 
            this.grb_inserisci.Controls.Add(this.btn_inserisci);
            this.grb_inserisci.Controls.Add(this.label1);
            this.grb_inserisci.Controls.Add(this.txb_inserisci);
            this.grb_inserisci.Location = new System.Drawing.Point(31, 36);
            this.grb_inserisci.Margin = new System.Windows.Forms.Padding(4);
            this.grb_inserisci.Name = "grb_inserisci";
            this.grb_inserisci.Padding = new System.Windows.Forms.Padding(4);
            this.grb_inserisci.Size = new System.Drawing.Size(831, 239);
            this.grb_inserisci.TabIndex = 0;
            this.grb_inserisci.TabStop = false;
            this.grb_inserisci.Text = "Nuovo giocatore";
            // 
            // btn_inserisci
            // 
            this.btn_inserisci.Location = new System.Drawing.Point(28, 92);
            this.btn_inserisci.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserisci.Name = "btn_inserisci";
            this.btn_inserisci.Size = new System.Drawing.Size(779, 102);
            this.btn_inserisci.TabIndex = 2;
            this.btn_inserisci.Text = "Inserisci";
            this.btn_inserisci.UseVisualStyleBackColor = true;
            this.btn_inserisci.Click += new System.EventHandler(this.btn_inserisci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci nome nuovo giocatore:";
            // 
            // txb_inserisci
            // 
            this.txb_inserisci.Location = new System.Drawing.Point(241, 43);
            this.txb_inserisci.Margin = new System.Windows.Forms.Padding(4);
            this.txb_inserisci.Name = "txb_inserisci";
            this.txb_inserisci.Size = new System.Drawing.Size(288, 22);
            this.txb_inserisci.TabIndex = 0;
            // 
            // tbp_giocofacile
            // 
            this.tbp_giocofacile.BackColor = System.Drawing.Color.Transparent;
            this.tbp_giocofacile.Controls.Add(this.groupBox1);
            this.tbp_giocofacile.Controls.Add(this.pictureBox14);
            this.tbp_giocofacile.Location = new System.Drawing.Point(4, 25);
            this.tbp_giocofacile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_giocofacile.Name = "tbp_giocofacile";
            this.tbp_giocofacile.Padding = new System.Windows.Forms.Padding(4);
            this.tbp_giocofacile.Size = new System.Drawing.Size(899, 861);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(880, 700);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Principiante";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(356, 518);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 158);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(643, 353);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(175, 158);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(356, 353);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(175, 158);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox7.Location = new System.Drawing.Point(64, 353);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(175, 158);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox8.Location = new System.Drawing.Point(64, 188);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(175, 158);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox9.Location = new System.Drawing.Point(643, 23);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(175, 158);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox10.Location = new System.Drawing.Point(64, 23);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(175, 158);
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox11.Location = new System.Drawing.Point(356, 23);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(175, 158);
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox12.Location = new System.Drawing.Point(643, 188);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(175, 158);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox13.Location = new System.Drawing.Point(356, 188);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(175, 158);
            this.pictureBox13.TabIndex = 22;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox14.Location = new System.Drawing.Point(285, 26);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(363, 98);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            // 
            // tbp_giocomedio
            // 
            this.tbp_giocomedio.Controls.Add(this.groupBox2);
            this.tbp_giocomedio.Controls.Add(this.pictureBox25);
            this.tbp_giocomedio.Location = new System.Drawing.Point(4, 25);
            this.tbp_giocomedio.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_giocomedio.Name = "tbp_giocomedio";
            this.tbp_giocomedio.Size = new System.Drawing.Size(899, 861);
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
            this.groupBox2.Location = new System.Drawing.Point(8, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(880, 700);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Esperto";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox15.Location = new System.Drawing.Point(356, 518);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(175, 158);
            this.pictureBox15.TabIndex = 31;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox16.Location = new System.Drawing.Point(643, 353);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(175, 158);
            this.pictureBox16.TabIndex = 30;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox17.Location = new System.Drawing.Point(356, 353);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(175, 158);
            this.pictureBox17.TabIndex = 29;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox18.Location = new System.Drawing.Point(64, 353);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(175, 158);
            this.pictureBox18.TabIndex = 28;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox19.Location = new System.Drawing.Point(64, 188);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(175, 158);
            this.pictureBox19.TabIndex = 27;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox20.Location = new System.Drawing.Point(643, 23);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(175, 158);
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox21.Location = new System.Drawing.Point(64, 23);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(175, 158);
            this.pictureBox21.TabIndex = 25;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox22.Location = new System.Drawing.Point(356, 23);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(175, 158);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox23.Location = new System.Drawing.Point(643, 188);
            this.pictureBox23.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(175, 158);
            this.pictureBox23.TabIndex = 23;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox24.Location = new System.Drawing.Point(356, 188);
            this.pictureBox24.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(175, 158);
            this.pictureBox24.TabIndex = 22;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox25.Location = new System.Drawing.Point(285, 26);
            this.pictureBox25.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(363, 98);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox25.TabIndex = 13;
            this.pictureBox25.TabStop = false;
            // 
            // tbp_giocodifficile
            // 
            this.tbp_giocodifficile.Controls.Add(this.groupBox3);
            this.tbp_giocodifficile.Controls.Add(this.pictureBox36);
            this.tbp_giocodifficile.Location = new System.Drawing.Point(4, 25);
            this.tbp_giocodifficile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_giocodifficile.Name = "tbp_giocodifficile";
            this.tbp_giocodifficile.Size = new System.Drawing.Size(899, 861);
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
            this.groupBox3.Location = new System.Drawing.Point(8, 132);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(880, 700);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Campione";
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::Football_Quiz.Properties.Resources.LIVELLO_10_removebg_preview;
            this.pictureBox26.Location = new System.Drawing.Point(356, 518);
            this.pictureBox26.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(175, 158);
            this.pictureBox26.TabIndex = 31;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::Football_Quiz.Properties.Resources.LIVELLO_9_removebg_preview;
            this.pictureBox27.Location = new System.Drawing.Point(643, 353);
            this.pictureBox27.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(175, 158);
            this.pictureBox27.TabIndex = 30;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = global::Football_Quiz.Properties.Resources.LIVELLO_8_removebg_preview;
            this.pictureBox28.Location = new System.Drawing.Point(356, 353);
            this.pictureBox28.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(175, 158);
            this.pictureBox28.TabIndex = 29;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = global::Football_Quiz.Properties.Resources.LIVELLO_7_removebg_preview;
            this.pictureBox29.Location = new System.Drawing.Point(64, 353);
            this.pictureBox29.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(175, 158);
            this.pictureBox29.TabIndex = 28;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = global::Football_Quiz.Properties.Resources.LIVELLO_4_removebg_preview;
            this.pictureBox30.Location = new System.Drawing.Point(64, 188);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(175, 158);
            this.pictureBox30.TabIndex = 27;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = global::Football_Quiz.Properties.Resources.LIVELLO_3_removebg_preview;
            this.pictureBox31.Location = new System.Drawing.Point(643, 23);
            this.pictureBox31.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(175, 158);
            this.pictureBox31.TabIndex = 26;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = global::Football_Quiz.Properties.Resources.LIVELLO_1_removebg_preview;
            this.pictureBox32.Location = new System.Drawing.Point(64, 23);
            this.pictureBox32.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(175, 158);
            this.pictureBox32.TabIndex = 25;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Image = global::Football_Quiz.Properties.Resources.LIVELLO_2_removebg_preview;
            this.pictureBox33.Location = new System.Drawing.Point(356, 23);
            this.pictureBox33.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(175, 158);
            this.pictureBox33.TabIndex = 24;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Image = global::Football_Quiz.Properties.Resources.LIVELLO_6_removebg_preview;
            this.pictureBox34.Location = new System.Drawing.Point(643, 188);
            this.pictureBox34.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(175, 158);
            this.pictureBox34.TabIndex = 23;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = global::Football_Quiz.Properties.Resources.LIVELLO_5_removebg_preview;
            this.pictureBox35.Location = new System.Drawing.Point(356, 188);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(175, 158);
            this.pictureBox35.TabIndex = 22;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = global::Football_Quiz.Properties.Resources.Screenshot__32__removebg_preview;
            this.pictureBox36.Location = new System.Drawing.Point(285, 26);
            this.pictureBox36.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(363, 98);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox36.TabIndex = 13;
            this.pictureBox36.TabStop = false;
            // 
            // tbp_1facile
            // 
            this.tbp_1facile.Controls.Add(this.lbl_punteggio1facile);
            this.tbp_1facile.Controls.Add(this.groupBox4);
            this.tbp_1facile.Controls.Add(this.pictureBox97);
            this.tbp_1facile.Controls.Add(this.pictureBox47);
            this.tbp_1facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_1facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_1facile.Name = "tbp_1facile";
            this.tbp_1facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_1facile.TabIndex = 4;
            this.tbp_1facile.Text = "livello 1 facile";
            this.tbp_1facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio1facile
            // 
            this.lbl_punteggio1facile.AutoSize = true;
            this.lbl_punteggio1facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio1facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio1facile.Name = "lbl_punteggio1facile";
            this.lbl_punteggio1facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio1facile.TabIndex = 18;
            this.lbl_punteggio1facile.Text = "Punteggio: 100";
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
            this.groupBox4.Location = new System.Drawing.Point(8, 132);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(880, 700);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Principiante";
            // 
            // lbl_indiziofacile1_3
            // 
            this.lbl_indiziofacile1_3.AutoSize = true;
            this.lbl_indiziofacile1_3.Location = new System.Drawing.Point(253, 677);
            this.lbl_indiziofacile1_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile1_3.Name = "lbl_indiziofacile1_3";
            this.lbl_indiziofacile1_3.Size = new System.Drawing.Size(402, 16);
            this.lbl_indiziofacile1_3.TabIndex = 12;
            this.lbl_indiziofacile1_3.Text = "Questa squadra è quella con più titoli di UEFA Champions League.";
            this.lbl_indiziofacile1_3.Visible = false;
            // 
            // lbl_indiziofacile1_1
            // 
            this.lbl_indiziofacile1_1.AutoSize = true;
            this.lbl_indiziofacile1_1.Location = new System.Drawing.Point(287, 600);
            this.lbl_indiziofacile1_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile1_1.Name = "lbl_indiziofacile1_1";
            this.lbl_indiziofacile1_1.Size = new System.Drawing.Size(338, 16);
            this.lbl_indiziofacile1_1.TabIndex = 11;
            this.lbl_indiziofacile1_1.Text = "Questa squadra milita nella Liga, campionato spagnolo.";
            this.lbl_indiziofacile1_1.Visible = false;
            // 
            // lbl_indiziofacile1_2
            // 
            this.lbl_indiziofacile1_2.AutoSize = true;
            this.lbl_indiziofacile1_2.Location = new System.Drawing.Point(305, 643);
            this.lbl_indiziofacile1_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile1_2.Name = "lbl_indiziofacile1_2";
            this.lbl_indiziofacile1_2.Size = new System.Drawing.Size(291, 16);
            this.lbl_indiziofacile1_2.TabIndex = 10;
            this.lbl_indiziofacile1_2.Text = "L’allenatore di questa squadra è Carlo Ancelotti.";
            this.lbl_indiziofacile1_2.Visible = false;
            // 
            // lbl_indizifacile1
            // 
            this.lbl_indizifacile1.AutoSize = true;
            this.lbl_indizifacile1.Location = new System.Drawing.Point(420, 667);
            this.lbl_indizifacile1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile1.Name = "lbl_indizifacile1";
            this.lbl_indizifacile1.Size = new System.Drawing.Size(0, 16);
            this.lbl_indizifacile1.TabIndex = 9;
            // 
            // btn_opzione4facile1
            // 
            this.btn_opzione4facile1.Location = new System.Drawing.Point(479, 511);
            this.btn_opzione4facile1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile1.Name = "btn_opzione4facile1";
            this.btn_opzione4facile1.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile1.TabIndex = 8;
            this.btn_opzione4facile1.Text = "Barcellona";
            this.btn_opzione4facile1.UseVisualStyleBackColor = true;
            this.btn_opzione4facile1.Click += new System.EventHandler(this.btn_opzione4facile1_Click);
            // 
            // btn_opzione3facile1
            // 
            this.btn_opzione3facile1.Location = new System.Drawing.Point(145, 511);
            this.btn_opzione3facile1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile1.Name = "btn_opzione3facile1";
            this.btn_opzione3facile1.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile1.TabIndex = 7;
            this.btn_opzione3facile1.Text = "Bayern Monaco";
            this.btn_opzione3facile1.UseVisualStyleBackColor = true;
            this.btn_opzione3facile1.Click += new System.EventHandler(this.btn_opzione3facile1_Click);
            // 
            // btn_opzione2facile1
            // 
            this.btn_opzione2facile1.Location = new System.Drawing.Point(480, 423);
            this.btn_opzione2facile1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile1.Name = "btn_opzione2facile1";
            this.btn_opzione2facile1.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile1.TabIndex = 6;
            this.btn_opzione2facile1.Text = "Real Madrid";
            this.btn_opzione2facile1.UseVisualStyleBackColor = true;
            this.btn_opzione2facile1.Click += new System.EventHandler(this.btn_opzione2facile1_Click);
            // 
            // btn_opzione1facile1
            // 
            this.btn_opzione1facile1.Location = new System.Drawing.Point(145, 423);
            this.btn_opzione1facile1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile1.Name = "btn_opzione1facile1";
            this.btn_opzione1facile1.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile1.TabIndex = 5;
            this.btn_opzione1facile1.Text = "Manchester City";
            this.btn_opzione1facile1.UseVisualStyleBackColor = true;
            this.btn_opzione1facile1.Click += new System.EventHandler(this.btn_opzione1facile1_Click);
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = global::Football_Quiz.Properties.Resources.real_madrid;
            this.pictureBox37.Location = new System.Drawing.Point(145, 30);
            this.pictureBox37.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(591, 359);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 4;
            this.pictureBox37.TabStop = false;
            // 
            // pb_indiziofacile1_2
            // 
            this.pb_indiziofacile1_2.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile1_2.Location = new System.Drawing.Point(808, 430);
            this.pb_indiziofacile1_2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile1_2.Name = "pb_indiziofacile1_2";
            this.pb_indiziofacile1_2.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile1_2.TabIndex = 3;
            this.pb_indiziofacile1_2.TabStop = false;
            this.pb_indiziofacile1_2.Click += new System.EventHandler(this.pb_indiziofacile1_2_Click);
            // 
            // pb_inzidiofacile1
            // 
            this.pb_inzidiofacile1.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_inzidiofacile1.Location = new System.Drawing.Point(808, 357);
            this.pb_inzidiofacile1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_inzidiofacile1.Name = "pb_inzidiofacile1";
            this.pb_inzidiofacile1.Size = new System.Drawing.Size(64, 65);
            this.pb_inzidiofacile1.TabIndex = 2;
            this.pb_inzidiofacile1.TabStop = false;
            this.pb_inzidiofacile1.Click += new System.EventHandler(this.pb_inzidiofacile1_Click);
            // 
            // pb_indiziofacile1_3
            // 
            this.pb_indiziofacile1_3.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile1_3.Location = new System.Drawing.Point(808, 502);
            this.pb_indiziofacile1_3.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile1_3.Name = "pb_indiziofacile1_3";
            this.pb_indiziofacile1_3.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile1_3.TabIndex = 1;
            this.pb_indiziofacile1_3.TabStop = false;
            this.pb_indiziofacile1_3.Click += new System.EventHandler(this.pb_indiziofacile1_3_Click);
            // 
            // pb_frecciavanti1facile
            // 
            this.pb_frecciavanti1facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti1facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti1facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti1facile.Name = "pb_frecciavanti1facile";
            this.pb_frecciavanti1facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti1facile.TabIndex = 0;
            this.pb_frecciavanti1facile.TabStop = false;
            this.pb_frecciavanti1facile.Click += new System.EventHandler(this.pb_frecciavanti1facile_Click);
            // 
            // pictureBox97
            // 
            this.pictureBox97.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox97.Location = new System.Drawing.Point(16, 26);
            this.pictureBox97.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(80, 76);
            this.pictureBox97.TabIndex = 17;
            this.pictureBox97.TabStop = false;
            this.pictureBox97.Click += new System.EventHandler(this.pictureBox97_Click);
            // 
            // pictureBox47
            // 
            this.pictureBox47.Image = global::Football_Quiz.Properties.Resources.scritta_livello_1_removebg_preview;
            this.pictureBox47.Location = new System.Drawing.Point(239, 26);
            this.pictureBox47.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(424, 98);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox47.TabIndex = 15;
            this.pictureBox47.TabStop = false;
            // 
            // tbp_2facile
            // 
            this.tbp_2facile.Controls.Add(this.lbl_punteggio2facile);
            this.tbp_2facile.Controls.Add(this.groupBox5);
            this.tbp_2facile.Controls.Add(this.pictureBox98);
            this.tbp_2facile.Controls.Add(this.pictureBox48);
            this.tbp_2facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_2facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_2facile.Name = "tbp_2facile";
            this.tbp_2facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_2facile.TabIndex = 5;
            this.tbp_2facile.Text = "livello 2 facile";
            this.tbp_2facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio2facile
            // 
            this.lbl_punteggio2facile.AutoSize = true;
            this.lbl_punteggio2facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio2facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio2facile.Name = "lbl_punteggio2facile";
            this.lbl_punteggio2facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio2facile.TabIndex = 19;
            this.lbl_punteggio2facile.Text = "Punteggio: 100";
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
            this.groupBox5.Location = new System.Drawing.Point(8, 132);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(880, 700);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Principiante";
            // 
            // lbl_indizifacile2_1
            // 
            this.lbl_indizifacile2_1.AutoSize = true;
            this.lbl_indizifacile2_1.Location = new System.Drawing.Point(303, 596);
            this.lbl_indizifacile2_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile2_1.Name = "lbl_indizifacile2_1";
            this.lbl_indizifacile2_1.Size = new System.Drawing.Size(395, 16);
            this.lbl_indizifacile2_1.TabIndex = 17;
            this.lbl_indizifacile2_1.Text = "Questa squadra milita nella Premier League, campionato inglese.";
            this.lbl_indizifacile2_1.Visible = false;
            // 
            // lbl_indizifacile2_2
            // 
            this.lbl_indizifacile2_2.AutoSize = true;
            this.lbl_indizifacile2_2.Location = new System.Drawing.Point(303, 632);
            this.lbl_indizifacile2_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile2_2.Name = "lbl_indizifacile2_2";
            this.lbl_indizifacile2_2.Size = new System.Drawing.Size(292, 16);
            this.lbl_indizifacile2_2.TabIndex = 16;
            this.lbl_indizifacile2_2.Text = "L’allenatore di questa squadra è Pep Guardiola.";
            this.lbl_indizifacile2_2.Visible = false;
            // 
            // lbl_indizifacile2_3
            // 
            this.lbl_indizifacile2_3.AutoSize = true;
            this.lbl_indizifacile2_3.Location = new System.Drawing.Point(303, 662);
            this.lbl_indizifacile2_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile2_3.Name = "lbl_indizifacile2_3";
            this.lbl_indizifacile2_3.Size = new System.Drawing.Size(355, 16);
            this.lbl_indizifacile2_3.TabIndex = 15;
            this.lbl_indizifacile2_3.Text = "Questa squadra è l’ultima detentrice della Premier League.";
            this.lbl_indizifacile2_3.Visible = false;
            // 
            // btn_opzione4facile2
            // 
            this.btn_opzione4facile2.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile2.Name = "btn_opzione4facile2";
            this.btn_opzione4facile2.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile2.TabIndex = 14;
            this.btn_opzione4facile2.Text = "Bayern Monaco";
            this.btn_opzione4facile2.UseVisualStyleBackColor = true;
            this.btn_opzione4facile2.Click += new System.EventHandler(this.btn_opzione4facile2_Click);
            // 
            // btn_opzione3facile2
            // 
            this.btn_opzione3facile2.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile2.Name = "btn_opzione3facile2";
            this.btn_opzione3facile2.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile2.TabIndex = 13;
            this.btn_opzione3facile2.Text = "Manchester City";
            this.btn_opzione3facile2.UseVisualStyleBackColor = true;
            this.btn_opzione3facile2.Click += new System.EventHandler(this.btn_opzione3facile2_Click);
            // 
            // btn_opzione2facile2
            // 
            this.btn_opzione2facile2.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile2.Name = "btn_opzione2facile2";
            this.btn_opzione2facile2.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile2.TabIndex = 12;
            this.btn_opzione2facile2.Text = "Paris Saint Germain";
            this.btn_opzione2facile2.UseVisualStyleBackColor = true;
            this.btn_opzione2facile2.Click += new System.EventHandler(this.btn_opzione2facile2_Click);
            // 
            // btn_opzione1facile2
            // 
            this.btn_opzione1facile2.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile2.Name = "btn_opzione1facile2";
            this.btn_opzione1facile2.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile2.TabIndex = 11;
            this.btn_opzione1facile2.Text = "Inter";
            this.btn_opzione1facile2.UseVisualStyleBackColor = true;
            this.btn_opzione1facile2.Click += new System.EventHandler(this.btn_opzione1facile2_Click);
            // 
            // pictureBox42
            // 
            this.pictureBox42.Image = global::Football_Quiz.Properties.Resources.manchester_city;
            this.pictureBox42.Location = new System.Drawing.Point(145, 23);
            this.pictureBox42.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(591, 359);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox42.TabIndex = 10;
            this.pictureBox42.TabStop = false;
            // 
            // pb_frecciaind2
            // 
            this.pb_frecciaind2.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind2.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind2.Name = "pb_frecciaind2";
            this.pb_frecciaind2.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind2.TabIndex = 4;
            this.pb_frecciaind2.TabStop = false;
            this.pb_frecciaind2.Click += new System.EventHandler(this.pb_frecciaind2_Click);
            // 
            // pb_indiziofacile2_2
            // 
            this.pb_indiziofacile2_2.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile2_2.Location = new System.Drawing.Point(808, 423);
            this.pb_indiziofacile2_2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile2_2.Name = "pb_indiziofacile2_2";
            this.pb_indiziofacile2_2.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile2_2.TabIndex = 3;
            this.pb_indiziofacile2_2.TabStop = false;
            this.pb_indiziofacile2_2.Click += new System.EventHandler(this.pb_indiziofacile2_2_Click);
            // 
            // pb_indiziofacile2_1
            // 
            this.pb_indiziofacile2_1.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile2_1.Location = new System.Drawing.Point(808, 351);
            this.pb_indiziofacile2_1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile2_1.Name = "pb_indiziofacile2_1";
            this.pb_indiziofacile2_1.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile2_1.TabIndex = 2;
            this.pb_indiziofacile2_1.TabStop = false;
            this.pb_indiziofacile2_1.Click += new System.EventHandler(this.pb_indiziofacile2_1_Click);
            // 
            // pb_indiziofacile2_3
            // 
            this.pb_indiziofacile2_3.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile2_3.Location = new System.Drawing.Point(808, 496);
            this.pb_indiziofacile2_3.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile2_3.Name = "pb_indiziofacile2_3";
            this.pb_indiziofacile2_3.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile2_3.TabIndex = 1;
            this.pb_indiziofacile2_3.TabStop = false;
            this.pb_indiziofacile2_3.Click += new System.EventHandler(this.pb_indiziofacile2_3_Click);
            // 
            // pb_frecciavanti2facile
            // 
            this.pb_frecciavanti2facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti2facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti2facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti2facile.Name = "pb_frecciavanti2facile";
            this.pb_frecciavanti2facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti2facile.TabIndex = 0;
            this.pb_frecciavanti2facile.TabStop = false;
            this.pb_frecciavanti2facile.Click += new System.EventHandler(this.pb_frecciavanti2facile_Click);
            // 
            // pictureBox98
            // 
            this.pictureBox98.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox98.Location = new System.Drawing.Point(16, 26);
            this.pictureBox98.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(80, 76);
            this.pictureBox98.TabIndex = 5;
            this.pictureBox98.TabStop = false;
            this.pictureBox98.Click += new System.EventHandler(this.pictureBox98_Click);
            // 
            // pictureBox48
            // 
            this.pictureBox48.Image = global::Football_Quiz.Properties.Resources.scritta_livello_2_removebg_preview__1_;
            this.pictureBox48.Location = new System.Drawing.Point(239, 26);
            this.pictureBox48.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(424, 98);
            this.pictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox48.TabIndex = 17;
            this.pictureBox48.TabStop = false;
            // 
            // tbp_3facile
            // 
            this.tbp_3facile.Controls.Add(this.lbl_punteggio3facile);
            this.tbp_3facile.Controls.Add(this.groupBox6);
            this.tbp_3facile.Controls.Add(this.pictureBox41);
            this.tbp_3facile.Controls.Add(this.pictureBox54);
            this.tbp_3facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_3facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_3facile.Name = "tbp_3facile";
            this.tbp_3facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_3facile.TabIndex = 6;
            this.tbp_3facile.Text = "livello 3 facile";
            this.tbp_3facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio3facile
            // 
            this.lbl_punteggio3facile.AutoSize = true;
            this.lbl_punteggio3facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio3facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio3facile.Name = "lbl_punteggio3facile";
            this.lbl_punteggio3facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio3facile.TabIndex = 20;
            this.lbl_punteggio3facile.Text = "Punteggio: 100";
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
            this.groupBox6.Location = new System.Drawing.Point(8, 132);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(880, 700);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Principiante";
            // 
            // lbl_indiziofacile3_1
            // 
            this.lbl_indiziofacile3_1.AutoSize = true;
            this.lbl_indiziofacile3_1.Location = new System.Drawing.Point(321, 584);
            this.lbl_indiziofacile3_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile3_1.Name = "lbl_indiziofacile3_1";
            this.lbl_indiziofacile3_1.Size = new System.Drawing.Size(350, 16);
            this.lbl_indiziofacile3_1.TabIndex = 17;
            this.lbl_indiziofacile3_1.Text = "Questa squadra milita nella Ligue 1, campionato francese.";
            this.lbl_indiziofacile3_1.Visible = false;
            // 
            // lbl_indiziofacile3_2
            // 
            this.lbl_indiziofacile3_2.AutoSize = true;
            this.lbl_indiziofacile3_2.Location = new System.Drawing.Point(321, 632);
            this.lbl_indiziofacile3_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile3_2.Name = "lbl_indiziofacile3_2";
            this.lbl_indiziofacile3_2.Size = new System.Drawing.Size(278, 16);
            this.lbl_indiziofacile3_2.TabIndex = 16;
            this.lbl_indiziofacile3_2.Text = "L’allenatore di questa squadra è Luis Enrique.";
            this.lbl_indiziofacile3_2.Visible = false;
            // 
            // lbl_indizifacile3_3
            // 
            this.lbl_indizifacile3_3.AutoSize = true;
            this.lbl_indizifacile3_3.Location = new System.Drawing.Point(321, 670);
            this.lbl_indizifacile3_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile3_3.Name = "lbl_indizifacile3_3";
            this.lbl_indizifacile3_3.Size = new System.Drawing.Size(262, 16);
            this.lbl_indizifacile3_3.TabIndex = 15;
            this.lbl_indizifacile3_3.Text = "Questa squadra gioca al Parc des Princes.";
            this.lbl_indizifacile3_3.Visible = false;
            // 
            // btn_opzione4facile3
            // 
            this.btn_opzione4facile3.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile3.Name = "btn_opzione4facile3";
            this.btn_opzione4facile3.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile3.TabIndex = 14;
            this.btn_opzione4facile3.Text = "Borussia Dortmund";
            this.btn_opzione4facile3.UseVisualStyleBackColor = true;
            this.btn_opzione4facile3.Click += new System.EventHandler(this.btn_opzione4facile3_Click);
            // 
            // btn_opzione3facile3
            // 
            this.btn_opzione3facile3.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile3.Name = "btn_opzione3facile3";
            this.btn_opzione3facile3.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile3.TabIndex = 13;
            this.btn_opzione3facile3.Text = "Paris Saint Germain";
            this.btn_opzione3facile3.UseVisualStyleBackColor = true;
            this.btn_opzione3facile3.Click += new System.EventHandler(this.btn_opzione3facile3_Click);
            // 
            // btn_opzione2facile3
            // 
            this.btn_opzione2facile3.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile3.Name = "btn_opzione2facile3";
            this.btn_opzione2facile3.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile3.TabIndex = 12;
            this.btn_opzione2facile3.Text = "Juventus";
            this.btn_opzione2facile3.UseVisualStyleBackColor = true;
            this.btn_opzione2facile3.Click += new System.EventHandler(this.btn_opzione2facile3_Click);
            // 
            // btn_opzione1facile3
            // 
            this.btn_opzione1facile3.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile3.Name = "btn_opzione1facile3";
            this.btn_opzione1facile3.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile3.TabIndex = 11;
            this.btn_opzione1facile3.Text = "Barcellona";
            this.btn_opzione1facile3.UseVisualStyleBackColor = true;
            this.btn_opzione1facile3.Click += new System.EventHandler(this.btn_opzione1facile3_Click);
            // 
            // pictureBox46
            // 
            this.pictureBox46.Image = global::Football_Quiz.Properties.Resources.psg;
            this.pictureBox46.Location = new System.Drawing.Point(145, 23);
            this.pictureBox46.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(591, 359);
            this.pictureBox46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox46.TabIndex = 10;
            this.pictureBox46.TabStop = false;
            // 
            // pb_frecciaind3
            // 
            this.pb_frecciaind3.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind3.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind3.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind3.Name = "pb_frecciaind3";
            this.pb_frecciaind3.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind3.TabIndex = 4;
            this.pb_frecciaind3.TabStop = false;
            this.pb_frecciaind3.Click += new System.EventHandler(this.pb_frecciaind3_Click);
            // 
            // pb_indiziofacile3_2
            // 
            this.pb_indiziofacile3_2.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile3_2.Location = new System.Drawing.Point(808, 423);
            this.pb_indiziofacile3_2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile3_2.Name = "pb_indiziofacile3_2";
            this.pb_indiziofacile3_2.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile3_2.TabIndex = 3;
            this.pb_indiziofacile3_2.TabStop = false;
            this.pb_indiziofacile3_2.Click += new System.EventHandler(this.pb_indiziofacile3_2_Click);
            // 
            // pb_indiziofacile3_1
            // 
            this.pb_indiziofacile3_1.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile3_1.Location = new System.Drawing.Point(808, 351);
            this.pb_indiziofacile3_1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile3_1.Name = "pb_indiziofacile3_1";
            this.pb_indiziofacile3_1.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile3_1.TabIndex = 2;
            this.pb_indiziofacile3_1.TabStop = false;
            this.pb_indiziofacile3_1.Click += new System.EventHandler(this.pb_indiziofacile3_1_Click);
            // 
            // pb_indiziofacile3_3
            // 
            this.pb_indiziofacile3_3.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile3_3.Location = new System.Drawing.Point(808, 496);
            this.pb_indiziofacile3_3.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile3_3.Name = "pb_indiziofacile3_3";
            this.pb_indiziofacile3_3.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile3_3.TabIndex = 1;
            this.pb_indiziofacile3_3.TabStop = false;
            this.pb_indiziofacile3_3.Click += new System.EventHandler(this.pb_indiziofacile3_3_Click);
            // 
            // pb_frecciavanti3facile
            // 
            this.pb_frecciavanti3facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti3facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti3facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti3facile.Name = "pb_frecciavanti3facile";
            this.pb_frecciavanti3facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti3facile.TabIndex = 0;
            this.pb_frecciavanti3facile.TabStop = false;
            this.pb_frecciavanti3facile.Click += new System.EventHandler(this.pb_frecciavanti3facile_Click);
            // 
            // pictureBox41
            // 
            this.pictureBox41.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox41.Location = new System.Drawing.Point(16, 26);
            this.pictureBox41.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(80, 76);
            this.pictureBox41.TabIndex = 19;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Click += new System.EventHandler(this.pictureBox41_Click);
            // 
            // pictureBox54
            // 
            this.pictureBox54.Image = global::Football_Quiz.Properties.Resources.scritta_livello_3_removebg_preview__1_;
            this.pictureBox54.Location = new System.Drawing.Point(239, 26);
            this.pictureBox54.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(424, 98);
            this.pictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox54.TabIndex = 17;
            this.pictureBox54.TabStop = false;
            // 
            // tbp_4facile
            // 
            this.tbp_4facile.Controls.Add(this.lbl_punteggio4facile);
            this.tbp_4facile.Controls.Add(this.groupBox7);
            this.tbp_4facile.Controls.Add(this.pictureBox99);
            this.tbp_4facile.Controls.Add(this.pictureBox60);
            this.tbp_4facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_4facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_4facile.Name = "tbp_4facile";
            this.tbp_4facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_4facile.TabIndex = 7;
            this.tbp_4facile.Text = "livello 4 facile";
            this.tbp_4facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio4facile
            // 
            this.lbl_punteggio4facile.AutoSize = true;
            this.lbl_punteggio4facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio4facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio4facile.Name = "lbl_punteggio4facile";
            this.lbl_punteggio4facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio4facile.TabIndex = 20;
            this.lbl_punteggio4facile.Text = "Punteggio: 100";
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
            this.groupBox7.Location = new System.Drawing.Point(8, 132);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(880, 700);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Principiante";
            // 
            // lbl_indiziofacile4_3
            // 
            this.lbl_indiziofacile4_3.AutoSize = true;
            this.lbl_indiziofacile4_3.Location = new System.Drawing.Point(295, 662);
            this.lbl_indiziofacile4_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile4_3.Name = "lbl_indiziofacile4_3";
            this.lbl_indiziofacile4_3.Size = new System.Drawing.Size(327, 16);
            this.lbl_indiziofacile4_3.TabIndex = 15;
            this.lbl_indiziofacile4_3.Text = "Questa squadra è l’ultima detentrice della Bundesliga.";
            this.lbl_indiziofacile4_3.Visible = false;
            // 
            // btn_opzione4facile4
            // 
            this.btn_opzione4facile4.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile4.Name = "btn_opzione4facile4";
            this.btn_opzione4facile4.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile4.TabIndex = 14;
            this.btn_opzione4facile4.Text = "Bayer Leverkusen";
            this.btn_opzione4facile4.UseVisualStyleBackColor = true;
            this.btn_opzione4facile4.Click += new System.EventHandler(this.btn_opzione4facile4_Click);
            // 
            // btn_opzione3facile4
            // 
            this.btn_opzione3facile4.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile4.Name = "btn_opzione3facile4";
            this.btn_opzione3facile4.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile4.TabIndex = 13;
            this.btn_opzione3facile4.Text = "Real Madrid ";
            this.btn_opzione3facile4.UseVisualStyleBackColor = true;
            this.btn_opzione3facile4.Click += new System.EventHandler(this.btn_opzione3facile4_Click);
            // 
            // btn_opzione2facile4
            // 
            this.btn_opzione2facile4.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile4.Name = "btn_opzione2facile4";
            this.btn_opzione2facile4.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile4.TabIndex = 12;
            this.btn_opzione2facile4.Text = "Milan ";
            this.btn_opzione2facile4.UseVisualStyleBackColor = true;
            this.btn_opzione2facile4.Click += new System.EventHandler(this.btn_opzione2facile4_Click);
            // 
            // btn_opzione1facile4
            // 
            this.btn_opzione1facile4.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile4.Name = "btn_opzione1facile4";
            this.btn_opzione1facile4.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile4.TabIndex = 11;
            this.btn_opzione1facile4.Text = "Bayern Monaco";
            this.btn_opzione1facile4.UseVisualStyleBackColor = true;
            this.btn_opzione1facile4.Click += new System.EventHandler(this.btn_opzione1facile4_Click);
            // 
            // pictureBox49
            // 
            this.pictureBox49.Image = global::Football_Quiz.Properties.Resources.bayern_monaco;
            this.pictureBox49.Location = new System.Drawing.Point(145, 23);
            this.pictureBox49.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(591, 359);
            this.pictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox49.TabIndex = 10;
            this.pictureBox49.TabStop = false;
            // 
            // pb_frecciaind4
            // 
            this.pb_frecciaind4.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind4.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind4.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind4.Name = "pb_frecciaind4";
            this.pb_frecciaind4.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind4.TabIndex = 4;
            this.pb_frecciaind4.TabStop = false;
            this.pb_frecciaind4.Click += new System.EventHandler(this.pb_frecciaind4_Click);
            // 
            // pb_indiziofacile4_2
            // 
            this.pb_indiziofacile4_2.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile4_2.Location = new System.Drawing.Point(808, 423);
            this.pb_indiziofacile4_2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile4_2.Name = "pb_indiziofacile4_2";
            this.pb_indiziofacile4_2.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile4_2.TabIndex = 3;
            this.pb_indiziofacile4_2.TabStop = false;
            // 
            // pb_indiziofacile4_1
            // 
            this.pb_indiziofacile4_1.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile4_1.Location = new System.Drawing.Point(808, 351);
            this.pb_indiziofacile4_1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile4_1.Name = "pb_indiziofacile4_1";
            this.pb_indiziofacile4_1.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile4_1.TabIndex = 2;
            this.pb_indiziofacile4_1.TabStop = false;
            // 
            // pb_indiziofacile4_3
            // 
            this.pb_indiziofacile4_3.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pb_indiziofacile4_3.Location = new System.Drawing.Point(808, 496);
            this.pb_indiziofacile4_3.Margin = new System.Windows.Forms.Padding(4);
            this.pb_indiziofacile4_3.Name = "pb_indiziofacile4_3";
            this.pb_indiziofacile4_3.Size = new System.Drawing.Size(64, 65);
            this.pb_indiziofacile4_3.TabIndex = 1;
            this.pb_indiziofacile4_3.TabStop = false;
            // 
            // pb_frecciavanti4facile
            // 
            this.pb_frecciavanti4facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti4facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti4facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti4facile.Name = "pb_frecciavanti4facile";
            this.pb_frecciavanti4facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti4facile.TabIndex = 0;
            this.pb_frecciavanti4facile.TabStop = false;
            this.pb_frecciavanti4facile.Click += new System.EventHandler(this.pb_frecciavanti4facile_Click);
            // 
            // pictureBox99
            // 
            this.pictureBox99.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox99.Location = new System.Drawing.Point(16, 26);
            this.pictureBox99.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox99.Name = "pictureBox99";
            this.pictureBox99.Size = new System.Drawing.Size(80, 76);
            this.pictureBox99.TabIndex = 19;
            this.pictureBox99.TabStop = false;
            this.pictureBox99.Click += new System.EventHandler(this.pictureBox99_Click);
            // 
            // pictureBox60
            // 
            this.pictureBox60.Image = global::Football_Quiz.Properties.Resources.scritta_livello_4_removebg_preview__1_;
            this.pictureBox60.Location = new System.Drawing.Point(239, 26);
            this.pictureBox60.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(424, 98);
            this.pictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox60.TabIndex = 17;
            this.pictureBox60.TabStop = false;
            // 
            // tbp_5facile
            // 
            this.tbp_5facile.Controls.Add(this.lbl_punteggio5facile);
            this.tbp_5facile.Controls.Add(this.groupBox8);
            this.tbp_5facile.Controls.Add(this.pictureBox100);
            this.tbp_5facile.Controls.Add(this.pictureBox66);
            this.tbp_5facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_5facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_5facile.Name = "tbp_5facile";
            this.tbp_5facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_5facile.TabIndex = 8;
            this.tbp_5facile.Text = "livello 5 facile";
            this.tbp_5facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio5facile
            // 
            this.lbl_punteggio5facile.AutoSize = true;
            this.lbl_punteggio5facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio5facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio5facile.Name = "lbl_punteggio5facile";
            this.lbl_punteggio5facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio5facile.TabIndex = 20;
            this.lbl_punteggio5facile.Text = "Punteggio: 100";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbl_indizifacile5);
            this.groupBox8.Controls.Add(this.btn_opzione4facile5);
            this.groupBox8.Controls.Add(this.btn_opzione3facile5);
            this.groupBox8.Controls.Add(this.btn_opzione2facile5);
            this.groupBox8.Controls.Add(this.btn_opzione1facile5);
            this.groupBox8.Controls.Add(this.pictureBox53);
            this.groupBox8.Controls.Add(this.pb_frecciaind5);
            this.groupBox8.Controls.Add(this.pictureBox62);
            this.groupBox8.Controls.Add(this.pictureBox63);
            this.groupBox8.Controls.Add(this.pictureBox64);
            this.groupBox8.Controls.Add(this.pb_frecciavanti5facile);
            this.groupBox8.Location = new System.Drawing.Point(8, 132);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(880, 700);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Principiante";
            // 
            // lbl_indizifacile5
            // 
            this.lbl_indizifacile5.AutoSize = true;
            this.lbl_indizifacile5.Location = new System.Drawing.Point(420, 661);
            this.lbl_indizifacile5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile5.Name = "lbl_indizifacile5";
            this.lbl_indizifacile5.Size = new System.Drawing.Size(37, 16);
            this.lbl_indizifacile5.TabIndex = 15;
            this.lbl_indizifacile5.Text = "indizi";
            // 
            // btn_opzione4facile5
            // 
            this.btn_opzione4facile5.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile5.Name = "btn_opzione4facile5";
            this.btn_opzione4facile5.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile5.TabIndex = 14;
            this.btn_opzione4facile5.Text = "button4";
            this.btn_opzione4facile5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3facile5
            // 
            this.btn_opzione3facile5.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile5.Name = "btn_opzione3facile5";
            this.btn_opzione3facile5.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile5.TabIndex = 13;
            this.btn_opzione3facile5.Text = "button3";
            this.btn_opzione3facile5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2facile5
            // 
            this.btn_opzione2facile5.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile5.Name = "btn_opzione2facile5";
            this.btn_opzione2facile5.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile5.TabIndex = 12;
            this.btn_opzione2facile5.Text = "button2";
            this.btn_opzione2facile5.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1facile5
            // 
            this.btn_opzione1facile5.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile5.Name = "btn_opzione1facile5";
            this.btn_opzione1facile5.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile5.TabIndex = 11;
            this.btn_opzione1facile5.Text = "button1";
            this.btn_opzione1facile5.UseVisualStyleBackColor = true;
            // 
            // pictureBox53
            // 
            this.pictureBox53.Image = global::Football_Quiz.Properties.Resources.barcellona;
            this.pictureBox53.Location = new System.Drawing.Point(145, 23);
            this.pictureBox53.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(591, 359);
            this.pictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox53.TabIndex = 10;
            this.pictureBox53.TabStop = false;
            // 
            // pb_frecciaind5
            // 
            this.pb_frecciaind5.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind5.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind5.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind5.Name = "pb_frecciaind5";
            this.pb_frecciaind5.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind5.TabIndex = 4;
            this.pb_frecciaind5.TabStop = false;
            this.pb_frecciaind5.Click += new System.EventHandler(this.pb_frecciaind5_Click);
            // 
            // pictureBox62
            // 
            this.pictureBox62.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox62.Location = new System.Drawing.Point(808, 423);
            this.pictureBox62.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(64, 65);
            this.pictureBox62.TabIndex = 3;
            this.pictureBox62.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox63.Location = new System.Drawing.Point(808, 351);
            this.pictureBox63.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(64, 65);
            this.pictureBox63.TabIndex = 2;
            this.pictureBox63.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox64.Location = new System.Drawing.Point(808, 496);
            this.pictureBox64.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(64, 65);
            this.pictureBox64.TabIndex = 1;
            this.pictureBox64.TabStop = false;
            // 
            // pb_frecciavanti5facile
            // 
            this.pb_frecciavanti5facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti5facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti5facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti5facile.Name = "pb_frecciavanti5facile";
            this.pb_frecciavanti5facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti5facile.TabIndex = 0;
            this.pb_frecciavanti5facile.TabStop = false;
            this.pb_frecciavanti5facile.Click += new System.EventHandler(this.pb_frecciavanti5facile_Click);
            // 
            // pictureBox100
            // 
            this.pictureBox100.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox100.Location = new System.Drawing.Point(16, 26);
            this.pictureBox100.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox100.Name = "pictureBox100";
            this.pictureBox100.Size = new System.Drawing.Size(80, 76);
            this.pictureBox100.TabIndex = 19;
            this.pictureBox100.TabStop = false;
            this.pictureBox100.Click += new System.EventHandler(this.pictureBox100_Click);
            // 
            // pictureBox66
            // 
            this.pictureBox66.Image = global::Football_Quiz.Properties.Resources.scritta_livello_5_removebg_preview__1_;
            this.pictureBox66.Location = new System.Drawing.Point(239, 26);
            this.pictureBox66.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(424, 98);
            this.pictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox66.TabIndex = 17;
            this.pictureBox66.TabStop = false;
            // 
            // tbp_6facile
            // 
            this.tbp_6facile.Controls.Add(this.lbl_punteggio6facile);
            this.tbp_6facile.Controls.Add(this.groupBox9);
            this.tbp_6facile.Controls.Add(this.pictureBox101);
            this.tbp_6facile.Controls.Add(this.pictureBox72);
            this.tbp_6facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_6facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_6facile.Name = "tbp_6facile";
            this.tbp_6facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_6facile.TabIndex = 9;
            this.tbp_6facile.Text = "livello 6 facile";
            this.tbp_6facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio6facile
            // 
            this.lbl_punteggio6facile.AutoSize = true;
            this.lbl_punteggio6facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio6facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio6facile.Name = "lbl_punteggio6facile";
            this.lbl_punteggio6facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio6facile.TabIndex = 20;
            this.lbl_punteggio6facile.Text = "Punteggio: 100";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbl_indizifacile6);
            this.groupBox9.Controls.Add(this.btn_opzione4facile6);
            this.groupBox9.Controls.Add(this.btn_opzione3facile6);
            this.groupBox9.Controls.Add(this.btn_opzione2facile6);
            this.groupBox9.Controls.Add(this.btn_opzione1facile6);
            this.groupBox9.Controls.Add(this.pictureBox55);
            this.groupBox9.Controls.Add(this.pb_frecciaind6);
            this.groupBox9.Controls.Add(this.pictureBox68);
            this.groupBox9.Controls.Add(this.pictureBox69);
            this.groupBox9.Controls.Add(this.pictureBox70);
            this.groupBox9.Controls.Add(this.pb_frecciavanti6facile);
            this.groupBox9.Location = new System.Drawing.Point(8, 132);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(880, 700);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Principiante";
            // 
            // lbl_indizifacile6
            // 
            this.lbl_indizifacile6.AutoSize = true;
            this.lbl_indizifacile6.Location = new System.Drawing.Point(420, 661);
            this.lbl_indizifacile6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile6.Name = "lbl_indizifacile6";
            this.lbl_indizifacile6.Size = new System.Drawing.Size(37, 16);
            this.lbl_indizifacile6.TabIndex = 15;
            this.lbl_indizifacile6.Text = "indizi";
            // 
            // btn_opzione4facile6
            // 
            this.btn_opzione4facile6.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile6.Name = "btn_opzione4facile6";
            this.btn_opzione4facile6.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile6.TabIndex = 14;
            this.btn_opzione4facile6.Text = "button4";
            this.btn_opzione4facile6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3facile6
            // 
            this.btn_opzione3facile6.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile6.Name = "btn_opzione3facile6";
            this.btn_opzione3facile6.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile6.TabIndex = 13;
            this.btn_opzione3facile6.Text = "button3";
            this.btn_opzione3facile6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2facile6
            // 
            this.btn_opzione2facile6.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile6.Name = "btn_opzione2facile6";
            this.btn_opzione2facile6.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile6.TabIndex = 12;
            this.btn_opzione2facile6.Text = "button2";
            this.btn_opzione2facile6.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1facile6
            // 
            this.btn_opzione1facile6.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile6.Name = "btn_opzione1facile6";
            this.btn_opzione1facile6.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile6.TabIndex = 11;
            this.btn_opzione1facile6.Text = "button1";
            this.btn_opzione1facile6.UseVisualStyleBackColor = true;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Image = global::Football_Quiz.Properties.Resources.liverpool;
            this.pictureBox55.Location = new System.Drawing.Point(145, 23);
            this.pictureBox55.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(591, 359);
            this.pictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox55.TabIndex = 10;
            this.pictureBox55.TabStop = false;
            // 
            // pb_frecciaind6
            // 
            this.pb_frecciaind6.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind6.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind6.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind6.Name = "pb_frecciaind6";
            this.pb_frecciaind6.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind6.TabIndex = 4;
            this.pb_frecciaind6.TabStop = false;
            this.pb_frecciaind6.Click += new System.EventHandler(this.pb_frecciaind6_Click);
            // 
            // pictureBox68
            // 
            this.pictureBox68.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox68.Location = new System.Drawing.Point(808, 423);
            this.pictureBox68.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(64, 65);
            this.pictureBox68.TabIndex = 3;
            this.pictureBox68.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox69.Location = new System.Drawing.Point(808, 351);
            this.pictureBox69.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(64, 65);
            this.pictureBox69.TabIndex = 2;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox70
            // 
            this.pictureBox70.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox70.Location = new System.Drawing.Point(808, 496);
            this.pictureBox70.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(64, 65);
            this.pictureBox70.TabIndex = 1;
            this.pictureBox70.TabStop = false;
            // 
            // pb_frecciavanti6facile
            // 
            this.pb_frecciavanti6facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti6facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti6facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti6facile.Name = "pb_frecciavanti6facile";
            this.pb_frecciavanti6facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti6facile.TabIndex = 0;
            this.pb_frecciavanti6facile.TabStop = false;
            this.pb_frecciavanti6facile.Click += new System.EventHandler(this.pb_frecciavanti6facile_Click);
            // 
            // pictureBox101
            // 
            this.pictureBox101.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox101.Location = new System.Drawing.Point(16, 26);
            this.pictureBox101.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox101.Name = "pictureBox101";
            this.pictureBox101.Size = new System.Drawing.Size(80, 76);
            this.pictureBox101.TabIndex = 19;
            this.pictureBox101.TabStop = false;
            this.pictureBox101.Click += new System.EventHandler(this.pictureBox101_Click);
            // 
            // pictureBox72
            // 
            this.pictureBox72.Image = global::Football_Quiz.Properties.Resources.scritta_livello_6_removebg_preview__1_1;
            this.pictureBox72.Location = new System.Drawing.Point(239, 26);
            this.pictureBox72.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(424, 98);
            this.pictureBox72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox72.TabIndex = 17;
            this.pictureBox72.TabStop = false;
            // 
            // tbp_7facile
            // 
            this.tbp_7facile.Controls.Add(this.lbl_punteggio7facile);
            this.tbp_7facile.Controls.Add(this.groupBox10);
            this.tbp_7facile.Controls.Add(this.pictureBox102);
            this.tbp_7facile.Controls.Add(this.pictureBox78);
            this.tbp_7facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_7facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_7facile.Name = "tbp_7facile";
            this.tbp_7facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_7facile.TabIndex = 10;
            this.tbp_7facile.Text = "livello 7 facile";
            this.tbp_7facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio7facile
            // 
            this.lbl_punteggio7facile.AutoSize = true;
            this.lbl_punteggio7facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio7facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio7facile.Name = "lbl_punteggio7facile";
            this.lbl_punteggio7facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio7facile.TabIndex = 20;
            this.lbl_punteggio7facile.Text = "Punteggio: 100";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lbl_indizifacile7);
            this.groupBox10.Controls.Add(this.btn_opzione4facile7);
            this.groupBox10.Controls.Add(this.btn_opzione3facile7);
            this.groupBox10.Controls.Add(this.btn_opzione2facile7);
            this.groupBox10.Controls.Add(this.btn_opzione1facile7);
            this.groupBox10.Controls.Add(this.pictureBox59);
            this.groupBox10.Controls.Add(this.pb_frecciaind7);
            this.groupBox10.Controls.Add(this.pictureBox74);
            this.groupBox10.Controls.Add(this.pictureBox75);
            this.groupBox10.Controls.Add(this.pictureBox76);
            this.groupBox10.Controls.Add(this.pb_frecciavanti7facile);
            this.groupBox10.Location = new System.Drawing.Point(8, 132);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(880, 700);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Principiante";
            // 
            // lbl_indizifacile7
            // 
            this.lbl_indizifacile7.AutoSize = true;
            this.lbl_indizifacile7.Location = new System.Drawing.Point(420, 661);
            this.lbl_indizifacile7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile7.Name = "lbl_indizifacile7";
            this.lbl_indizifacile7.Size = new System.Drawing.Size(37, 16);
            this.lbl_indizifacile7.TabIndex = 15;
            this.lbl_indizifacile7.Text = "indizi";
            // 
            // btn_opzione4facile7
            // 
            this.btn_opzione4facile7.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile7.Name = "btn_opzione4facile7";
            this.btn_opzione4facile7.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile7.TabIndex = 14;
            this.btn_opzione4facile7.Text = "button4";
            this.btn_opzione4facile7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3facile7
            // 
            this.btn_opzione3facile7.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile7.Name = "btn_opzione3facile7";
            this.btn_opzione3facile7.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile7.TabIndex = 13;
            this.btn_opzione3facile7.Text = "button3";
            this.btn_opzione3facile7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2facile7
            // 
            this.btn_opzione2facile7.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile7.Name = "btn_opzione2facile7";
            this.btn_opzione2facile7.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile7.TabIndex = 12;
            this.btn_opzione2facile7.Text = "button2";
            this.btn_opzione2facile7.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1facile7
            // 
            this.btn_opzione1facile7.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile7.Name = "btn_opzione1facile7";
            this.btn_opzione1facile7.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile7.TabIndex = 11;
            this.btn_opzione1facile7.Text = "button1";
            this.btn_opzione1facile7.UseVisualStyleBackColor = true;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Image = global::Football_Quiz.Properties.Resources.juventus;
            this.pictureBox59.Location = new System.Drawing.Point(145, 23);
            this.pictureBox59.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(591, 359);
            this.pictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox59.TabIndex = 10;
            this.pictureBox59.TabStop = false;
            // 
            // pb_frecciaind7
            // 
            this.pb_frecciaind7.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind7.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind7.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind7.Name = "pb_frecciaind7";
            this.pb_frecciaind7.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind7.TabIndex = 4;
            this.pb_frecciaind7.TabStop = false;
            this.pb_frecciaind7.Click += new System.EventHandler(this.pb_frecciaind7_Click);
            // 
            // pictureBox74
            // 
            this.pictureBox74.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox74.Location = new System.Drawing.Point(808, 423);
            this.pictureBox74.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(64, 65);
            this.pictureBox74.TabIndex = 3;
            this.pictureBox74.TabStop = false;
            // 
            // pictureBox75
            // 
            this.pictureBox75.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox75.Location = new System.Drawing.Point(808, 351);
            this.pictureBox75.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(64, 65);
            this.pictureBox75.TabIndex = 2;
            this.pictureBox75.TabStop = false;
            // 
            // pictureBox76
            // 
            this.pictureBox76.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox76.Location = new System.Drawing.Point(808, 496);
            this.pictureBox76.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(64, 65);
            this.pictureBox76.TabIndex = 1;
            this.pictureBox76.TabStop = false;
            // 
            // pb_frecciavanti7facile
            // 
            this.pb_frecciavanti7facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti7facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti7facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti7facile.Name = "pb_frecciavanti7facile";
            this.pb_frecciavanti7facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti7facile.TabIndex = 0;
            this.pb_frecciavanti7facile.TabStop = false;
            this.pb_frecciavanti7facile.Click += new System.EventHandler(this.pb_frecciavanti7facile_Click);
            // 
            // pictureBox102
            // 
            this.pictureBox102.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox102.Location = new System.Drawing.Point(16, 26);
            this.pictureBox102.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox102.Name = "pictureBox102";
            this.pictureBox102.Size = new System.Drawing.Size(80, 76);
            this.pictureBox102.TabIndex = 19;
            this.pictureBox102.TabStop = false;
            this.pictureBox102.Click += new System.EventHandler(this.pictureBox102_Click);
            // 
            // pictureBox78
            // 
            this.pictureBox78.Image = global::Football_Quiz.Properties.Resources.scritta_livello_7_removebg_preview__1_;
            this.pictureBox78.Location = new System.Drawing.Point(239, 26);
            this.pictureBox78.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(424, 98);
            this.pictureBox78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox78.TabIndex = 17;
            this.pictureBox78.TabStop = false;
            // 
            // tbp_8facile
            // 
            this.tbp_8facile.Controls.Add(this.lbl_punteggio8facile);
            this.tbp_8facile.Controls.Add(this.groupBox11);
            this.tbp_8facile.Controls.Add(this.pictureBox103);
            this.tbp_8facile.Controls.Add(this.pictureBox84);
            this.tbp_8facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_8facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_8facile.Name = "tbp_8facile";
            this.tbp_8facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_8facile.TabIndex = 11;
            this.tbp_8facile.Text = "livello 8 facile";
            this.tbp_8facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio8facile
            // 
            this.lbl_punteggio8facile.AutoSize = true;
            this.lbl_punteggio8facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio8facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio8facile.Name = "lbl_punteggio8facile";
            this.lbl_punteggio8facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio8facile.TabIndex = 20;
            this.lbl_punteggio8facile.Text = "Punteggio: 100";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lbl_indizifacile8);
            this.groupBox11.Controls.Add(this.btn_opzione4facile8);
            this.groupBox11.Controls.Add(this.btn_opzione3facile8);
            this.groupBox11.Controls.Add(this.btn_opzione2facile8);
            this.groupBox11.Controls.Add(this.btn_opzione1facile8);
            this.groupBox11.Controls.Add(this.pictureBox61);
            this.groupBox11.Controls.Add(this.pb_frecciaind8);
            this.groupBox11.Controls.Add(this.pictureBox80);
            this.groupBox11.Controls.Add(this.pictureBox81);
            this.groupBox11.Controls.Add(this.pictureBox82);
            this.groupBox11.Controls.Add(this.pb_frecciavanti8facile);
            this.groupBox11.Location = new System.Drawing.Point(8, 132);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(880, 700);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Principiante";
            // 
            // lbl_indizifacile8
            // 
            this.lbl_indizifacile8.AutoSize = true;
            this.lbl_indizifacile8.Location = new System.Drawing.Point(420, 661);
            this.lbl_indizifacile8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile8.Name = "lbl_indizifacile8";
            this.lbl_indizifacile8.Size = new System.Drawing.Size(37, 16);
            this.lbl_indizifacile8.TabIndex = 15;
            this.lbl_indizifacile8.Text = "indizi";
            // 
            // btn_opzione4facile8
            // 
            this.btn_opzione4facile8.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile8.Name = "btn_opzione4facile8";
            this.btn_opzione4facile8.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile8.TabIndex = 14;
            this.btn_opzione4facile8.Text = "button4";
            this.btn_opzione4facile8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3facile8
            // 
            this.btn_opzione3facile8.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile8.Name = "btn_opzione3facile8";
            this.btn_opzione3facile8.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile8.TabIndex = 13;
            this.btn_opzione3facile8.Text = "button3";
            this.btn_opzione3facile8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2facile8
            // 
            this.btn_opzione2facile8.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile8.Name = "btn_opzione2facile8";
            this.btn_opzione2facile8.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile8.TabIndex = 12;
            this.btn_opzione2facile8.Text = "button2";
            this.btn_opzione2facile8.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1facile8
            // 
            this.btn_opzione1facile8.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile8.Name = "btn_opzione1facile8";
            this.btn_opzione1facile8.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile8.TabIndex = 11;
            this.btn_opzione1facile8.Text = "button1";
            this.btn_opzione1facile8.UseVisualStyleBackColor = true;
            // 
            // pictureBox61
            // 
            this.pictureBox61.Image = global::Football_Quiz.Properties.Resources.inter;
            this.pictureBox61.Location = new System.Drawing.Point(145, 23);
            this.pictureBox61.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(591, 359);
            this.pictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox61.TabIndex = 10;
            this.pictureBox61.TabStop = false;
            // 
            // pb_frecciaind8
            // 
            this.pb_frecciaind8.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind8.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind8.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind8.Name = "pb_frecciaind8";
            this.pb_frecciaind8.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind8.TabIndex = 4;
            this.pb_frecciaind8.TabStop = false;
            this.pb_frecciaind8.Click += new System.EventHandler(this.pb_frecciaind8_Click);
            // 
            // pictureBox80
            // 
            this.pictureBox80.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox80.Location = new System.Drawing.Point(808, 423);
            this.pictureBox80.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(64, 65);
            this.pictureBox80.TabIndex = 3;
            this.pictureBox80.TabStop = false;
            // 
            // pictureBox81
            // 
            this.pictureBox81.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox81.Location = new System.Drawing.Point(808, 351);
            this.pictureBox81.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(64, 65);
            this.pictureBox81.TabIndex = 2;
            this.pictureBox81.TabStop = false;
            // 
            // pictureBox82
            // 
            this.pictureBox82.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox82.Location = new System.Drawing.Point(808, 496);
            this.pictureBox82.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(64, 65);
            this.pictureBox82.TabIndex = 1;
            this.pictureBox82.TabStop = false;
            // 
            // pb_frecciavanti8facile
            // 
            this.pb_frecciavanti8facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti8facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti8facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti8facile.Name = "pb_frecciavanti8facile";
            this.pb_frecciavanti8facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti8facile.TabIndex = 0;
            this.pb_frecciavanti8facile.TabStop = false;
            this.pb_frecciavanti8facile.Click += new System.EventHandler(this.pb_frecciavanti8facile_Click);
            // 
            // pictureBox103
            // 
            this.pictureBox103.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox103.Location = new System.Drawing.Point(16, 26);
            this.pictureBox103.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox103.Name = "pictureBox103";
            this.pictureBox103.Size = new System.Drawing.Size(80, 76);
            this.pictureBox103.TabIndex = 19;
            this.pictureBox103.TabStop = false;
            this.pictureBox103.Click += new System.EventHandler(this.pictureBox103_Click);
            // 
            // pictureBox84
            // 
            this.pictureBox84.Image = global::Football_Quiz.Properties.Resources.scritta_livello_8_removebg_preview__1_;
            this.pictureBox84.Location = new System.Drawing.Point(239, 26);
            this.pictureBox84.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(424, 98);
            this.pictureBox84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox84.TabIndex = 17;
            this.pictureBox84.TabStop = false;
            // 
            // tbp_9facile
            // 
            this.tbp_9facile.Controls.Add(this.lbl_punteggio9facile);
            this.tbp_9facile.Controls.Add(this.groupBox12);
            this.tbp_9facile.Controls.Add(this.pictureBox104);
            this.tbp_9facile.Controls.Add(this.pictureBox90);
            this.tbp_9facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_9facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_9facile.Name = "tbp_9facile";
            this.tbp_9facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_9facile.TabIndex = 12;
            this.tbp_9facile.Text = "livello 9 facile";
            this.tbp_9facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio9facile
            // 
            this.lbl_punteggio9facile.AutoSize = true;
            this.lbl_punteggio9facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio9facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio9facile.Name = "lbl_punteggio9facile";
            this.lbl_punteggio9facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio9facile.TabIndex = 20;
            this.lbl_punteggio9facile.Text = "Punteggio: 100";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lbl_indizifacile9);
            this.groupBox12.Controls.Add(this.btn_opzione4facile9);
            this.groupBox12.Controls.Add(this.btn_opzione3facile9);
            this.groupBox12.Controls.Add(this.btn_opzione2facile9);
            this.groupBox12.Controls.Add(this.btn_opzione1facile9);
            this.groupBox12.Controls.Add(this.pictureBox65);
            this.groupBox12.Controls.Add(this.pb_frecciaind9);
            this.groupBox12.Controls.Add(this.pictureBox86);
            this.groupBox12.Controls.Add(this.pictureBox87);
            this.groupBox12.Controls.Add(this.pictureBox88);
            this.groupBox12.Controls.Add(this.pb_frecciavanti9facile);
            this.groupBox12.Location = new System.Drawing.Point(8, 132);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(880, 700);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Principiante";
            // 
            // lbl_indizifacile9
            // 
            this.lbl_indizifacile9.AutoSize = true;
            this.lbl_indizifacile9.Location = new System.Drawing.Point(420, 661);
            this.lbl_indizifacile9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile9.Name = "lbl_indizifacile9";
            this.lbl_indizifacile9.Size = new System.Drawing.Size(37, 16);
            this.lbl_indizifacile9.TabIndex = 15;
            this.lbl_indizifacile9.Text = "indizi";
            // 
            // btn_opzione4facile9
            // 
            this.btn_opzione4facile9.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile9.Name = "btn_opzione4facile9";
            this.btn_opzione4facile9.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile9.TabIndex = 14;
            this.btn_opzione4facile9.Text = "button4";
            this.btn_opzione4facile9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3facile9
            // 
            this.btn_opzione3facile9.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile9.Name = "btn_opzione3facile9";
            this.btn_opzione3facile9.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile9.TabIndex = 13;
            this.btn_opzione3facile9.Text = "button3";
            this.btn_opzione3facile9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2facile9
            // 
            this.btn_opzione2facile9.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile9.Name = "btn_opzione2facile9";
            this.btn_opzione2facile9.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile9.TabIndex = 12;
            this.btn_opzione2facile9.Text = "button2";
            this.btn_opzione2facile9.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1facile9
            // 
            this.btn_opzione1facile9.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile9.Name = "btn_opzione1facile9";
            this.btn_opzione1facile9.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile9.TabIndex = 11;
            this.btn_opzione1facile9.Text = "button1";
            this.btn_opzione1facile9.UseVisualStyleBackColor = true;
            // 
            // pictureBox65
            // 
            this.pictureBox65.Image = global::Football_Quiz.Properties.Resources.milan;
            this.pictureBox65.Location = new System.Drawing.Point(145, 23);
            this.pictureBox65.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(591, 359);
            this.pictureBox65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox65.TabIndex = 10;
            this.pictureBox65.TabStop = false;
            // 
            // pb_frecciaind9
            // 
            this.pb_frecciaind9.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind9.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind9.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind9.Name = "pb_frecciaind9";
            this.pb_frecciaind9.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind9.TabIndex = 4;
            this.pb_frecciaind9.TabStop = false;
            this.pb_frecciaind9.Click += new System.EventHandler(this.pb_frecciaind9_Click);
            // 
            // pictureBox86
            // 
            this.pictureBox86.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox86.Location = new System.Drawing.Point(808, 423);
            this.pictureBox86.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(64, 65);
            this.pictureBox86.TabIndex = 3;
            this.pictureBox86.TabStop = false;
            // 
            // pictureBox87
            // 
            this.pictureBox87.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox87.Location = new System.Drawing.Point(808, 351);
            this.pictureBox87.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(64, 65);
            this.pictureBox87.TabIndex = 2;
            this.pictureBox87.TabStop = false;
            // 
            // pictureBox88
            // 
            this.pictureBox88.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox88.Location = new System.Drawing.Point(808, 496);
            this.pictureBox88.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(64, 65);
            this.pictureBox88.TabIndex = 1;
            this.pictureBox88.TabStop = false;
            // 
            // pb_frecciavanti9facile
            // 
            this.pb_frecciavanti9facile.Image = global::Football_Quiz.Properties.Resources.freccia_avanti_removebg_preview11;
            this.pb_frecciavanti9facile.Location = new System.Drawing.Point(792, 617);
            this.pb_frecciavanti9facile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciavanti9facile.Name = "pb_frecciavanti9facile";
            this.pb_frecciavanti9facile.Size = new System.Drawing.Size(80, 76);
            this.pb_frecciavanti9facile.TabIndex = 0;
            this.pb_frecciavanti9facile.TabStop = false;
            this.pb_frecciavanti9facile.Click += new System.EventHandler(this.pb_frecciavanti9facile_Click);
            // 
            // pictureBox104
            // 
            this.pictureBox104.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox104.Location = new System.Drawing.Point(16, 26);
            this.pictureBox104.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox104.Name = "pictureBox104";
            this.pictureBox104.Size = new System.Drawing.Size(80, 76);
            this.pictureBox104.TabIndex = 19;
            this.pictureBox104.TabStop = false;
            this.pictureBox104.Click += new System.EventHandler(this.pictureBox104_Click);
            // 
            // pictureBox90
            // 
            this.pictureBox90.Image = global::Football_Quiz.Properties.Resources.scritta_livello_9_removebg_preview__1_;
            this.pictureBox90.Location = new System.Drawing.Point(239, 26);
            this.pictureBox90.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(424, 98);
            this.pictureBox90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox90.TabIndex = 17;
            this.pictureBox90.TabStop = false;
            // 
            // tbp_10facile
            // 
            this.tbp_10facile.Controls.Add(this.lbl_punteggio10facile);
            this.tbp_10facile.Controls.Add(this.groupBox13);
            this.tbp_10facile.Controls.Add(this.pictureBox105);
            this.tbp_10facile.Controls.Add(this.pictureBox96);
            this.tbp_10facile.Location = new System.Drawing.Point(4, 25);
            this.tbp_10facile.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_10facile.Name = "tbp_10facile";
            this.tbp_10facile.Size = new System.Drawing.Size(899, 861);
            this.tbp_10facile.TabIndex = 13;
            this.tbp_10facile.Text = "livello 10 facile";
            this.tbp_10facile.UseVisualStyleBackColor = true;
            // 
            // lbl_punteggio10facile
            // 
            this.lbl_punteggio10facile.AutoSize = true;
            this.lbl_punteggio10facile.Location = new System.Drawing.Point(775, 108);
            this.lbl_punteggio10facile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_punteggio10facile.Name = "lbl_punteggio10facile";
            this.lbl_punteggio10facile.Size = new System.Drawing.Size(95, 16);
            this.lbl_punteggio10facile.TabIndex = 20;
            this.lbl_punteggio10facile.Text = "Punteggio: 100";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.lbl_indizifacile10);
            this.groupBox13.Controls.Add(this.btn_opzione4facile10);
            this.groupBox13.Controls.Add(this.btn_opzione3facile10);
            this.groupBox13.Controls.Add(this.btn_opzione2facile10);
            this.groupBox13.Controls.Add(this.btn_opzione1facile10);
            this.groupBox13.Controls.Add(this.pictureBox67);
            this.groupBox13.Controls.Add(this.pb_frecciaind10);
            this.groupBox13.Controls.Add(this.pictureBox92);
            this.groupBox13.Controls.Add(this.pictureBox93);
            this.groupBox13.Controls.Add(this.pictureBox94);
            this.groupBox13.Location = new System.Drawing.Point(8, 132);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(880, 700);
            this.groupBox13.TabIndex = 18;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Principiante";
            // 
            // lbl_indizifacile10
            // 
            this.lbl_indizifacile10.AutoSize = true;
            this.lbl_indizifacile10.Location = new System.Drawing.Point(420, 661);
            this.lbl_indizifacile10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indizifacile10.Name = "lbl_indizifacile10";
            this.lbl_indizifacile10.Size = new System.Drawing.Size(37, 16);
            this.lbl_indizifacile10.TabIndex = 15;
            this.lbl_indizifacile10.Text = "indizi";
            // 
            // btn_opzione4facile10
            // 
            this.btn_opzione4facile10.Location = new System.Drawing.Point(479, 505);
            this.btn_opzione4facile10.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione4facile10.Name = "btn_opzione4facile10";
            this.btn_opzione4facile10.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione4facile10.TabIndex = 14;
            this.btn_opzione4facile10.Text = "button4";
            this.btn_opzione4facile10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione3facile10
            // 
            this.btn_opzione3facile10.Location = new System.Drawing.Point(145, 505);
            this.btn_opzione3facile10.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione3facile10.Name = "btn_opzione3facile10";
            this.btn_opzione3facile10.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione3facile10.TabIndex = 13;
            this.btn_opzione3facile10.Text = "button3";
            this.btn_opzione3facile10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione2facile10
            // 
            this.btn_opzione2facile10.Location = new System.Drawing.Point(480, 417);
            this.btn_opzione2facile10.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione2facile10.Name = "btn_opzione2facile10";
            this.btn_opzione2facile10.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione2facile10.TabIndex = 12;
            this.btn_opzione2facile10.Text = "button2";
            this.btn_opzione2facile10.UseVisualStyleBackColor = true;
            // 
            // btn_opzione1facile10
            // 
            this.btn_opzione1facile10.Location = new System.Drawing.Point(145, 417);
            this.btn_opzione1facile10.Margin = new System.Windows.Forms.Padding(4);
            this.btn_opzione1facile10.Name = "btn_opzione1facile10";
            this.btn_opzione1facile10.Size = new System.Drawing.Size(256, 57);
            this.btn_opzione1facile10.TabIndex = 11;
            this.btn_opzione1facile10.Text = "button1";
            this.btn_opzione1facile10.UseVisualStyleBackColor = true;
            // 
            // pictureBox67
            // 
            this.pictureBox67.Image = global::Football_Quiz.Properties.Resources.borussia_dortmund;
            this.pictureBox67.Location = new System.Drawing.Point(145, 23);
            this.pictureBox67.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(591, 359);
            this.pictureBox67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox67.TabIndex = 10;
            this.pictureBox67.TabStop = false;
            // 
            // pb_frecciaind10
            // 
            this.pb_frecciaind10.Image = global::Football_Quiz.Properties.Resources.freccia_indietro_removebg_preview;
            this.pb_frecciaind10.Location = new System.Drawing.Point(8, 617);
            this.pb_frecciaind10.Margin = new System.Windows.Forms.Padding(4);
            this.pb_frecciaind10.Name = "pb_frecciaind10";
            this.pb_frecciaind10.Size = new System.Drawing.Size(80, 95);
            this.pb_frecciaind10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frecciaind10.TabIndex = 4;
            this.pb_frecciaind10.TabStop = false;
            this.pb_frecciaind10.Click += new System.EventHandler(this.pb_frecciaind10_Click);
            // 
            // pictureBox92
            // 
            this.pictureBox92.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox92.Location = new System.Drawing.Point(808, 423);
            this.pictureBox92.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(64, 65);
            this.pictureBox92.TabIndex = 3;
            this.pictureBox92.TabStop = false;
            // 
            // pictureBox93
            // 
            this.pictureBox93.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox93.Location = new System.Drawing.Point(808, 351);
            this.pictureBox93.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(64, 65);
            this.pictureBox93.TabIndex = 2;
            this.pictureBox93.TabStop = false;
            // 
            // pictureBox94
            // 
            this.pictureBox94.Image = global::Football_Quiz.Properties.Resources.lampadina_indizi_removebg_preview;
            this.pictureBox94.Location = new System.Drawing.Point(808, 496);
            this.pictureBox94.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox94.Name = "pictureBox94";
            this.pictureBox94.Size = new System.Drawing.Size(64, 65);
            this.pictureBox94.TabIndex = 1;
            this.pictureBox94.TabStop = false;
            // 
            // pictureBox105
            // 
            this.pictureBox105.Image = global::Football_Quiz.Properties.Resources.home_removebg_preview;
            this.pictureBox105.Location = new System.Drawing.Point(16, 26);
            this.pictureBox105.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox105.Name = "pictureBox105";
            this.pictureBox105.Size = new System.Drawing.Size(80, 76);
            this.pictureBox105.TabIndex = 19;
            this.pictureBox105.TabStop = false;
            this.pictureBox105.Click += new System.EventHandler(this.pictureBox105_Click);
            // 
            // pictureBox96
            // 
            this.pictureBox96.Image = global::Football_Quiz.Properties.Resources.scritta_livello_10_removebg_preview__1_;
            this.pictureBox96.Location = new System.Drawing.Point(213, 26);
            this.pictureBox96.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(472, 98);
            this.pictureBox96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox96.TabIndex = 17;
            this.pictureBox96.TabStop = false;
            // 
            // pb_back
            // 
            this.pb_back.Image = global::Football_Quiz.Properties.Resources.Screenshot__21_;
            this.pb_back.Location = new System.Drawing.Point(105, 830);
            this.pb_back.Margin = new System.Windows.Forms.Padding(4);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(209, 64);
            this.pb_back.TabIndex = 6;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_nuovogiocatore
            // 
            this.pb_nuovogiocatore.Image = global::Football_Quiz.Properties.Resources.Screenshot__20_;
            this.pb_nuovogiocatore.Location = new System.Drawing.Point(116, 688);
            this.pb_nuovogiocatore.Margin = new System.Windows.Forms.Padding(4);
            this.pb_nuovogiocatore.Name = "pb_nuovogiocatore";
            this.pb_nuovogiocatore.Size = new System.Drawing.Size(196, 121);
            this.pb_nuovogiocatore.TabIndex = 5;
            this.pb_nuovogiocatore.TabStop = false;
            this.pb_nuovogiocatore.Click += new System.EventHandler(this.pb_nuovogiocatore_Click);
            // 
            // pb_gioca
            // 
            this.pb_gioca.Image = global::Football_Quiz.Properties.Resources.Screenshot__18_;
            this.pb_gioca.Location = new System.Drawing.Point(68, 379);
            this.pb_gioca.Margin = new System.Windows.Forms.Padding(4);
            this.pb_gioca.Name = "pb_gioca";
            this.pb_gioca.Size = new System.Drawing.Size(275, 202);
            this.pb_gioca.TabIndex = 4;
            this.pb_gioca.TabStop = false;
            this.pb_gioca.Click += new System.EventHandler(this.pb_gioca_Click);
            // 
            // pb_info
            // 
            this.pb_info.Image = global::Football_Quiz.Properties.Resources.Screenshot__17_1;
            this.pb_info.Location = new System.Drawing.Point(19, 0);
            this.pb_info.Margin = new System.Windows.Forms.Padding(4);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(72, 64);
            this.pb_info.TabIndex = 3;
            this.pb_info.TabStop = false;
            this.pb_info.Click += new System.EventHandler(this.pb_info_Click);
            // 
            // cbo_giocatore
            // 
            this.cbo_giocatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_giocatore.FormattingEnabled = true;
            this.cbo_giocatore.Items.AddRange(new object[] {
            "Alessio",
            "Marco"});
            this.cbo_giocatore.Location = new System.Drawing.Point(275, 642);
            this.cbo_giocatore.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_giocatore.Name = "cbo_giocatore";
            this.cbo_giocatore.Size = new System.Drawing.Size(139, 24);
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
            this.cbo_livello.Location = new System.Drawing.Point(252, 316);
            this.cbo_livello.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_livello.Name = "cbo_livello";
            this.cbo_livello.Size = new System.Drawing.Size(161, 24);
            this.cbo_livello.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Football_Quiz.Properties.Resources.Screenshot__16_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 910);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_magliette
            // 
            this.panel_magliette.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_magliette.Location = new System.Drawing.Point(1039, 193);
            this.panel_magliette.Margin = new System.Windows.Forms.Padding(4);
            this.panel_magliette.Name = "panel_magliette";
            this.panel_magliette.Size = new System.Drawing.Size(211, 203);
            this.panel_magliette.TabIndex = 5;
            this.panel_magliette.Visible = false;
            // 
            // pb_exit
            // 
            this.pb_exit.Image = global::Football_Quiz.Properties.Resources.sfondo_exit;
            this.pb_exit.Location = new System.Drawing.Point(1097, 15);
            this.pb_exit.Margin = new System.Windows.Forms.Padding(4);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(247, 110);
            this.pb_exit.TabIndex = 3;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_magliette
            // 
            this.pb_magliette.Image = global::Football_Quiz.Properties.Resources.play_2;
            this.pb_magliette.Location = new System.Drawing.Point(1009, 700);
            this.pb_magliette.Margin = new System.Windows.Forms.Padding(4);
            this.pb_magliette.Name = "pb_magliette";
            this.pb_magliette.Size = new System.Drawing.Size(240, 121);
            this.pb_magliette.TabIndex = 2;
            this.pb_magliette.TabStop = false;
            this.pb_magliette.Click += new System.EventHandler(this.pb_magliette_Click);
            // 
            // pb_squadre
            // 
            this.pb_squadre.Image = global::Football_Quiz.Properties.Resources.play_1;
            this.pb_squadre.Location = new System.Drawing.Point(209, 688);
            this.pb_squadre.Margin = new System.Windows.Forms.Padding(4);
            this.pb_squadre.Name = "pb_squadre";
            this.pb_squadre.Size = new System.Drawing.Size(259, 121);
            this.pb_squadre.TabIndex = 1;
            this.pb_squadre.TabStop = false;
            this.pb_squadre.Click += new System.EventHandler(this.pb_squadre_Click);
            // 
            // pb_sfondo
            // 
            this.pb_sfondo.Image = global::Football_Quiz.Properties.Resources.sfondo_completo;
            this.pb_sfondo.Location = new System.Drawing.Point(-3, 1);
            this.pb_sfondo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_sfondo.Name = "pb_sfondo";
            this.pb_sfondo.Size = new System.Drawing.Size(1363, 865);
            this.pb_sfondo.TabIndex = 0;
            this.pb_sfondo.TabStop = false;
            // 
            // lbl_indiziofacile4_2
            // 
            this.lbl_indiziofacile4_2.AutoSize = true;
            this.lbl_indiziofacile4_2.Location = new System.Drawing.Point(295, 632);
            this.lbl_indiziofacile4_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile4_2.Name = "lbl_indiziofacile4_2";
            this.lbl_indiziofacile4_2.Size = new System.Drawing.Size(299, 16);
            this.lbl_indiziofacile4_2.TabIndex = 16;
            this.lbl_indiziofacile4_2.Text = "L’allenatore di questa squadra è Thomas Tuchel.";
            this.lbl_indiziofacile4_2.Visible = false;
            // 
            // lbl_indiziofacile4_1
            // 
            this.lbl_indiziofacile4_1.AutoSize = true;
            this.lbl_indiziofacile4_1.Location = new System.Drawing.Point(295, 596);
            this.lbl_indiziofacile4_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_indiziofacile4_1.Name = "lbl_indiziofacile4_1";
            this.lbl_indiziofacile4_1.Size = new System.Drawing.Size(372, 16);
            this.lbl_indiziofacile4_1.TabIndex = 17;
            this.lbl_indiziofacile4_1.Text = "Questa squadra milita nella Bundesliga, campionato tedesco.";
            this.lbl_indiziofacile4_1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 910);
            this.Controls.Add(this.panel_squadre);
            this.Controls.Add(this.panel_magliette);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.pb_magliette);
            this.Controls.Add(this.pb_squadre);
            this.Controls.Add(this.pb_sfondo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_squadre.ResumeLayout(false);
            this.tbc_squadre.ResumeLayout(false);
            this.tbp_giocatore.ResumeLayout(false);
            this.grb_record.ResumeLayout(false);
            this.grb_record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grb_cancella.ResumeLayout(false);
            this.grb_cancella.PerformLayout();
            this.grb_inserisci.ResumeLayout(false);
            this.grb_inserisci.PerformLayout();
            this.tbp_giocofacile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
            this.tbp_giocomedio.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
            this.tbp_giocodifficile.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
            this.tbp_1facile.ResumeLayout(false);
            this.tbp_1facile.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inzidiofacile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti1facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            this.tbp_2facile.ResumeLayout(false);
            this.tbp_2facile.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti2facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            this.tbp_3facile.ResumeLayout(false);
            this.tbp_3facile.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti3facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            this.tbp_4facile.ResumeLayout(false);
            this.tbp_4facile.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indiziofacile4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti4facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            this.tbp_5facile.ResumeLayout(false);
            this.tbp_5facile.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti5facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            this.tbp_6facile.ResumeLayout(false);
            this.tbp_6facile.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti6facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            this.tbp_7facile.ResumeLayout(false);
            this.tbp_7facile.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti7facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            this.tbp_8facile.ResumeLayout(false);
            this.tbp_8facile.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti8facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            this.tbp_9facile.ResumeLayout(false);
            this.tbp_9facile.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciavanti9facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            this.tbp_10facile.ResumeLayout(false);
            this.tbp_10facile.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frecciaind10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox62;
        private System.Windows.Forms.PictureBox pictureBox63;
        private System.Windows.Forms.PictureBox pictureBox64;
        private System.Windows.Forms.PictureBox pb_frecciavanti5facile;
        private System.Windows.Forms.PictureBox pictureBox66;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pb_frecciaind6;
        private System.Windows.Forms.PictureBox pictureBox68;
        private System.Windows.Forms.PictureBox pictureBox69;
        private System.Windows.Forms.PictureBox pictureBox70;
        private System.Windows.Forms.PictureBox pb_frecciavanti6facile;
        private System.Windows.Forms.PictureBox pictureBox72;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.PictureBox pb_frecciaind7;
        private System.Windows.Forms.PictureBox pictureBox74;
        private System.Windows.Forms.PictureBox pictureBox75;
        private System.Windows.Forms.PictureBox pictureBox76;
        private System.Windows.Forms.PictureBox pb_frecciavanti7facile;
        private System.Windows.Forms.PictureBox pictureBox78;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.PictureBox pb_frecciaind8;
        private System.Windows.Forms.PictureBox pictureBox80;
        private System.Windows.Forms.PictureBox pictureBox81;
        private System.Windows.Forms.PictureBox pictureBox82;
        private System.Windows.Forms.PictureBox pb_frecciavanti8facile;
        private System.Windows.Forms.PictureBox pictureBox84;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.PictureBox pb_frecciaind9;
        private System.Windows.Forms.PictureBox pictureBox86;
        private System.Windows.Forms.PictureBox pictureBox87;
        private System.Windows.Forms.PictureBox pictureBox88;
        private System.Windows.Forms.PictureBox pb_frecciavanti9facile;
        private System.Windows.Forms.PictureBox pictureBox90;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.PictureBox pb_frecciaind10;
        private System.Windows.Forms.PictureBox pictureBox92;
        private System.Windows.Forms.PictureBox pictureBox93;
        private System.Windows.Forms.PictureBox pictureBox94;
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
        private System.Windows.Forms.Label lbl_indizifacile5;
        private System.Windows.Forms.Button btn_opzione4facile5;
        private System.Windows.Forms.Button btn_opzione3facile5;
        private System.Windows.Forms.Button btn_opzione2facile5;
        private System.Windows.Forms.Button btn_opzione1facile5;
        private System.Windows.Forms.PictureBox pictureBox53;
        private System.Windows.Forms.Label lbl_indizifacile6;
        private System.Windows.Forms.Button btn_opzione4facile6;
        private System.Windows.Forms.Button btn_opzione3facile6;
        private System.Windows.Forms.Button btn_opzione2facile6;
        private System.Windows.Forms.Button btn_opzione1facile6;
        private System.Windows.Forms.PictureBox pictureBox55;
        private System.Windows.Forms.Label lbl_indizifacile7;
        private System.Windows.Forms.Button btn_opzione4facile7;
        private System.Windows.Forms.Button btn_opzione3facile7;
        private System.Windows.Forms.Button btn_opzione2facile7;
        private System.Windows.Forms.Button btn_opzione1facile7;
        private System.Windows.Forms.PictureBox pictureBox59;
        private System.Windows.Forms.Label lbl_indizifacile8;
        private System.Windows.Forms.Button btn_opzione4facile8;
        private System.Windows.Forms.Button btn_opzione3facile8;
        private System.Windows.Forms.Button btn_opzione2facile8;
        private System.Windows.Forms.Button btn_opzione1facile8;
        private System.Windows.Forms.PictureBox pictureBox61;
        private System.Windows.Forms.Label lbl_indizifacile9;
        private System.Windows.Forms.Button btn_opzione4facile9;
        private System.Windows.Forms.Button btn_opzione3facile9;
        private System.Windows.Forms.Button btn_opzione2facile9;
        private System.Windows.Forms.Button btn_opzione1facile9;
        private System.Windows.Forms.PictureBox pictureBox65;
        private System.Windows.Forms.Label lbl_indizifacile10;
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
    }
}

