
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Football_Quiz.funzioni;



namespace Football_Quiz
{
    public partial class Form1 : Form
    {
        private giocatori[] elegiocatori = new giocatori[50];
        private int num = 0;

        #region variabili

        private int punteggioLivello = 100;
        private int punteggiolivello1;
        private int punteggiolivello2;
        private int punteggiolivello3;
        private int punteggiolivello4;
        private int punteggiolivello5;
        private int punteggiolivello6;
        private int punteggiolivello7;
        private int punteggiolivello8;
        private int punteggiolivello9;
        private int punteggiolivello10;
        private int punteggiototalefacile;
        private int punteggiolivellomedio1;
        private int punteggiolivellomedio2;
        private int punteggiolivellomedio3;
        private int punteggiolivellomedio4;
        private int punteggiolivellomedio5;
        private int punteggiolivellomedio6;
        private int punteggiolivellomedio7;
        private int punteggiolivellomedio8;
        private int punteggiolivellomedio9;
        private int punteggiolivellomedio10;
        private int punteggiototalemedio;
        private int punteggiodifficile1;
        private int punteggiodifficile2;
        private int punteggiodifficile3;
        private int punteggiodifficile4;
        private int punteggiodifficile5;
        private int punteggiodifficile6;
        private int punteggiodifficile7;
        private int punteggiodifficile8;
        private int punteggiodifficile9;
        private int punteggiodifficile10;
        private int punteggiodifficiletotale;

#endregion variabili 







        public Form1()
        {
            InitializeComponent();

            tbc_squadre.Appearance = TabAppearance.FlatButtons;
            tbc_squadre.ItemSize = new Size(0, 1);
            tbc_squadre.SizeMode = TabSizeMode.Fixed;

            

            

            #region giocatori preinseriti

            elegiocatori[num].giocatore = "Marco";
            elegiocatori[num].punteggio = 560;
            num++;
            elegiocatori[num].giocatore = "Alessio";
            elegiocatori[num].punteggio = 870;
            num++;
            elegiocatori[num].giocatore = txb_inserisci.Text;
            elegiocatori[num].punteggio = default(int);
            num++;

            #endregion giocatori preinseriti
        }

        private void pb_squadre_Click(object sender, EventArgs e)
        {
            panel_squadre.Visible = true;
            panel_magliette.Visible = false;
        }

       

        private void pb_exit_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler uscire?", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            

        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            panel_squadre.Visible=false;
        }

       

        private void pb_info_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pb_magliette_Click(object sender, EventArgs e)
        {
            panel_magliette.Visible = true;
        }

        private void pb_gioca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_giocatore.Text))
            {
                MessageBox.Show("Selezionare il giocatore");
                return;
            }

            tbc_squadre.Visible = true;
            string dato = cbo_livello.Text;
            if (dato == "Principiante")
            {
                tbc_squadre.SelectTab(1);
            }

            if (dato == "Esperto ")
            {
                tbc_squadre.SelectTab(2);
            }

            if (dato == "Campione ")
            {
                tbc_squadre.SelectTab(3);
            }

        }

       

        private void pb_nuovogiocatore_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(0);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(4);

            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(5);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(7);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(8);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(9);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(10);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(11);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(12);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(13);
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }
        #region frecce avanti e indietro
        private void pb_frecciaind2_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(4);
        }

        private void pb_frecciaind3_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(5);
        }

        private void pb_frecciaind4_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(6);
        }

        private void pb_frecciaind5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(7);
        }

        private void pb_frecciaind6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(8);
        }

        private void pb_frecciaind7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(9);
        }

        private void pb_frecciaind8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(10);
        }

        private void pb_frecciaind9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(11);
        }

        private void pb_frecciaind10_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(12);
        }

        private void pb_frecciavanti1facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(5);
        }

        private void pb_frecciavanti2facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(6);
        }

        private void pb_frecciavanti3facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(7);
        }

        private void pb_frecciavanti4facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(8);
        }

        private void pb_frecciavanti5facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(9);
        }

        private void pb_frecciavanti6facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(10);
        }

        private void pb_frecciavanti7facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(11);
        }

        private void pb_frecciavanti8facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(12);
        }

        private void pb_frecciavanti9facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(13);
        }

        #endregion frecce avanti e indietro 

        private void btn_inserisci_Click(object sender, EventArgs e)
        {
            if(num > 49)
            {
                MessageBox.Show("Errore del vettore");
                return;
            }

            if (string.IsNullOrEmpty(txb_inserisci.Text))
            {
                MessageBox.Show("Inserire nuovo giocatore");
                return;
            }

            giocatori nuovogiocatore = default;

            int gioc = Mylib.cercainserisci(elegiocatori, num, txb_inserisci.Text);
            if (gioc >= 0)
            {
                MessageBox.Show("È già presente un giocatore con questo nome");
                return;
            }

            nuovogiocatore.giocatore = txb_inserisci.Text;

            elegiocatori[num] = nuovogiocatore;

            txb_inserisci.Clear();

            num++;

            cbo_giocatore.Items.Add(nuovogiocatore.giocatore);
        }

        private void btn_cancella_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_cancella.Text))
            {
                MessageBox.Show("Inserire giocatore da cancellare");
                return;
            }

            int cancdati = Mylib.cancella(elegiocatori, ref num , txb_cancella.Text);
            if (cancdati == 0)
            {
                MessageBox.Show("Giocatore non cancellato o inesistente");
            }
            else
            {
                MessageBox.Show("Giocatore cancellato con successo");
            }

            cbo_giocatore.Items.Remove(txb_cancella.Text);

            txb_cancella.Clear();
        }

        

        private void btn_opzione1facile1_Click(object sender, EventArgs e)
        {
            btn_opzione1facile1.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;
            

            lbl_punteggio1facile.Text = $"{punteggioLivello}";
            
        }

        private void btn_opzione3facile1_Click(object sender, EventArgs e)
        {
            btn_opzione3facile1.BackColor = Color.Red;
            punteggioLivello = punteggioLivello - 20;
            

            lbl_punteggio1facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile1_Click(object sender, EventArgs e)
        {
            btn_opzione2facile1.BackColor = Color.Green;

             punteggiolivello1 = punteggioLivello;

            punteggioLivello = 100;
            
            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(5);

            
        }

        private void btn_opzione4facile1_Click(object sender, EventArgs e)
        {
            btn_opzione4facile1.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio1facile.Text = $"{punteggioLivello}";
        }

        private void pb_inzidiofacile1_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile1_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile1_2_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile1_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile1_3_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile1_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

             lbl_punteggio1facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile2_Click(object sender, EventArgs e)
        {
            btn_opzione1facile2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2facile.Text = $"{punteggioLivello}";


        }

        private void btn_opzione3facile2_Click(object sender, EventArgs e)
        {
            btn_opzione3facile2.BackColor= Color.Green;

            punteggiolivello2 = punteggioLivello;

            punteggioLivello = 100;

            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(6);
        }

        private void btn_opzione2facile2_Click(object sender, EventArgs e)
        {
            btn_opzione2facile2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile2_Click(object sender, EventArgs e)
        {
            btn_opzione4facile2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile2_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile2_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2facile.Text = $"{punteggioLivello}";

        }

        private void pb_indiziofacile2_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile2_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile2_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile2_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile3_Click(object sender, EventArgs e)
        {
            btn_opzione1facile3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile3_Click(object sender, EventArgs e)
        {
            btn_opzione2facile3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile3_Click(object sender, EventArgs e)
        {
            btn_opzione4facile3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3facile3_Click(object sender, EventArgs e)
        {
            btn_opzione3facile3.BackColor = Color.Green;

            punteggiolivello3 = punteggioLivello;

            punteggioLivello = 100;

            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(7);

        }

        private void pb_indiziofacile3_1_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile3_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile3_2_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile3_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile3_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile3_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3facile4_Click(object sender, EventArgs e)
        {
            btn_opzione3facile4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile4_Click(object sender, EventArgs e)
        {
            btn_opzione2facile4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4facile.Text = $"{punteggioLivello}";

        }

        private void btn_opzione4facile4_Click(object sender, EventArgs e)
        {
            btn_opzione4facile4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile4_Click(object sender, EventArgs e)
        {
            btn_opzione1facile4.BackColor = Color.Green;

            punteggiolivello4 = punteggioLivello;

            punteggioLivello = 100;

            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(8);
        }

        private void btn_opzione3facile5_Click(object sender, EventArgs e)
        {
            btn_opzione3facile5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile5_Click(object sender, EventArgs e)
        {
            btn_opzione4facile5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile5_Click(object sender, EventArgs e)
        {
            btn_opzione2facile5.BackColor= Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile5_Click(object sender, EventArgs e)
        {
            btn_opzione1facile5.BackColor = Color.Green;

            punteggiolivello5 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(9);
        }

        private void pb_indiziofacile5_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile5_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile5_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile5_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile5_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile5_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile6_Click(object sender, EventArgs e)
        {
            btn_opzione1facile6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile6_Click(object sender, EventArgs e)
        {
            btn_opzione2facile6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile6_Click(object sender, EventArgs e)
        {
            btn_opzione4facile6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3facile6_Click(object sender, EventArgs e)
        {
            btn_opzione3facile6.BackColor = Color.Green;

            punteggiolivello6 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(10);
        }

        private void pb_indiziofacile6_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile6_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile6_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile6_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile6_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile6_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile7_Click(object sender, EventArgs e)
        {
            btn_opzione1facile7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile7_Click(object sender, EventArgs e)
        {
            btn_opzione2facile7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile7_Click(object sender, EventArgs e)
        {
            btn_opzione4facile7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3facile7_Click(object sender, EventArgs e)
        {
            btn_opzione3facile7.BackColor = Color.Green;

            punteggiolivello7 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(11);
        }

        private void pb_indizifacile7_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile7_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile7_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile7_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile7_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile7_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile8_Click(object sender, EventArgs e)
        {
            btn_opzione1facile8.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3facile8_Click(object sender, EventArgs e)
        {
            btn_opzione3facile8.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile8_Click(object sender, EventArgs e)
        {
            btn_opzione2facile8.BackColor= Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile8_Click(object sender, EventArgs e)
        {
            btn_opzione4facile8.BackColor = Color.Green;

            punteggiolivello8 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(12);
        }

        private void pb_indiziofacile8_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile8_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile8_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile8_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile8_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile8_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3facile9_Click(object sender, EventArgs e)
        {
            btn_opzione3facile9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile9_Click(object sender, EventArgs e)
        {
            btn_opzione4facile9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile9_Click(object sender, EventArgs e)
        {
            btn_opzione2facile9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile9_Click(object sender, EventArgs e)
        {
            btn_opzione1facile9.BackColor = Color.Green;

            punteggiolivello9 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(13);
        }

        private void pb_indiziofacile9_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile9_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile9_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile9_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile9_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile9_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1facile10_Click(object sender, EventArgs e)
        {
            btn_opzione1facile10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3facile10_Click(object sender, EventArgs e)
        {
            btn_opzione3facile10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4facile10_Click(object sender, EventArgs e)
        {
            btn_opzione4facile10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2facile10_Click(object sender, EventArgs e)
        {
            btn_opzione2facile10.BackColor = Color.Green;

            punteggiolivello10 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(14);

            punteggiototalefacile = punteggiolivello1 + punteggiolivello2 + punteggiolivello3 + punteggiolivello4 + punteggiolivello5 + punteggiolivello6 + punteggiolivello7 + punteggiolivello8 + punteggiolivello9 + punteggiolivello10;

            giocatori nuovogiocatore = default;

            nuovogiocatore.giocatore = cbo_giocatore.Text;
            nuovogiocatore.punteggio = punteggiototalefacile;
            elegiocatori[num] = nuovogiocatore;
            num++;
            

            //Mylib.salva(elegiocatori, num);

            lbl_punteggiofinale.Text = $"{punteggiototalefacile}";


        }

        private void pb_indiziofacile10_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile10_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10facile.Text = $"{punteggioLivello}";
        }

        private void pb_livellofacile10_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile10_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10facile.Text = $"{punteggioLivello}";
        }

        private void pb_livellofacile10_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile10_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10facile.Text = $"{punteggioLivello}";
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mylib.leggi(elegiocatori, ref num);
        }

        private void pb_indiziofacile4_1_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile4_1 .Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4facile.Text = $"{punteggioLivello}";


        }

        private void pb_indiziofacile4_2_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile4_2 .Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4facile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziofacile4_3_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile4_3 .Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4facile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1medio1_Click(object sender, EventArgs e)
        {
            btn_opzione1medio1.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio1medio.Text = $"{punteggioLivello}";

        }

        private void btn_opzione3medio1_Click(object sender, EventArgs e)
        {
            btn_opzione3medio1.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio1medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio1_Click(object sender, EventArgs e)
        {
            btn_opzione4medio1.BackColor= Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio1medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2medio1_Click(object sender, EventArgs e)
        {
            btn_opzione2medio1.BackColor = Color.Green;

            punteggiolivellomedio1 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(15);
        }

        private void pb_indiziomedio1_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio1_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1medio.Text = $"{punteggioLivello}";

        }

        private void pb_indiziomedio1_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio1_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio1_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio1_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1medio.Text = $"{punteggioLivello}";
        }

        private void pb_frecciavantimedio1_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(15);
        }

        private void pb_homelivello1medio_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void btn_opzione1medio2_Click(object sender, EventArgs e)
        {
            btn_opzione1medio2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2medio.Text = $"{punteggioLivello}";

        }

        private void btn_opzione2medio2_Click(object sender, EventArgs e)
        {
            btn_opzione2medio2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio2_Click(object sender, EventArgs e)
        {
            btn_opzione4medio2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3medio2_Click(object sender, EventArgs e)
        {
            btn_opzione3medio2.BackColor = Color.Green;

            punteggiolivellomedio2 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(16);
        }

        private void pb_indiziomedio2_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio2_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio2_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio2_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio2_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio2_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2medio.Text = $"{punteggioLivello}";
        }

        private void pb_frecciaindietromedio2_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(15);
        }

        private void pb_frecciavantimedio2_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(17);
        }

        private void pb_homemedio2_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_homemedio3_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_tornahomefacile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pb_cambiagiocatore_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(0);
        }

        private void pb_passaesperto_facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_passacampione_facile_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void btn_opzione3medio3_Click(object sender, EventArgs e)
        {
            btn_opzione3medio3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2medio3_Click(object sender, EventArgs e)
        {
            btn_opzione2medio3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio3_Click(object sender, EventArgs e)
        {
            btn_opzione4medio3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1medio3_Click(object sender, EventArgs e)
        {
            btn_opzione1medio3.BackColor = Color.Green;

            punteggiolivellomedio3 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(17);
        }

        private void pb_indiziomedio3_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio3_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio3_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio3_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio3_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio3_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3medio.Text = $"{punteggioLivello}";
        }

        private void pb_frecciaindietromedio3_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(15);
        }

        private void pb_frecciavantimedio3_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(17);
        }

        private void pb_homelivello4medio_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_frecciaindietromedio4_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(16);
        }

        private void pb_frecciavantimedio4_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(18);
        }

        private void pb_homemedio5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_frecciaindietromedio5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(17);
        }

        private void pb_frecciavantimedio5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(19);
        }

        private void pb_homemedio6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_frecciaindietromedio6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(18);
        }

        private void pb_frecciavantimedio6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(20);
        }

        private void pb_homemedio7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_frecciaindietromedio7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(19);
        }

        private void pb_frecciavantimedio7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(21);
        }

        private void pb_homemedio8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_frecciaindietromedio8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(20);
        }

        private void pb_frecciavantimedio8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(22);
        }

        private void pb_homemedio9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_frecciaindietromedio9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(21);
        }

        private void pb_frecciavantimedio9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(23);
        }

        private void pb_homemedio10_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_frecciaindietromedio10_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(22);
        }

        private void btn_opzione2medio4_Click(object sender, EventArgs e)
        {
            btn_opzione2medio4.BackColor = Color.Green;

            punteggiolivellomedio4 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(18);
        }

        private void btn_opzione1medio4_Click(object sender, EventArgs e)
        {
            btn_opzione1medio4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3medio4_Click(object sender, EventArgs e)
        {
            btn_opzione3medio4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio4_Click(object sender, EventArgs e)
        {
            btn_opzione4medio4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio4_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio4_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio4_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio4_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio4_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio4_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2medio5_Click(object sender, EventArgs e)
        {
            btn_opzione2medio5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio5_Click(object sender, EventArgs e)
        {
            btn_opzione4medio5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3medio5_Click(object sender, EventArgs e)
        {
            btn_opzione3medio5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1medio5_Click(object sender, EventArgs e)
        {
            btn_opzione1medio5.BackColor = Color.Green;

            punteggiolivellomedio5 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(19);
        }

        private void pb_indiziomedio5_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio5_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5medio.Text = $"{punteggioLivello}";

        }

        private void pb_indiziomedio5_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio5_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio5_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio5_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2medio6_Click(object sender, EventArgs e)
        {
            btn_opzione2medio6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio6_Click(object sender, EventArgs e)
        {
            btn_opzione4medio6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3medio6_Click(object sender, EventArgs e)
        {
            btn_opzione3medio6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1medio6_Click(object sender, EventArgs e)
        {
            btn_opzione1medio6.BackColor = Color.Green;

            punteggiolivellomedio6 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(20);
        }

        private void pb_indiziomedio6_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio6_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio6_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio6_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio6_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio6_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1medio7_Click(object sender, EventArgs e)
        {
            btn_opzione1medio7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3medio7_Click(object sender, EventArgs e)
        {
            btn_opzione3medio7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio7_Click(object sender, EventArgs e)
        {
            btn_opzione4medio7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2medio7_Click(object sender, EventArgs e)
        {
            btn_opzione2medio7.BackColor = Color.Green;

            punteggiolivellomedio7 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(21);


        }

        private void pb_indiziomedio7_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio7_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio7_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio7_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio7_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio7_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1medio8_Click(object sender, EventArgs e)
        {
            btn_opzione1medio8.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2medio8_Click(object sender, EventArgs e)
        {
            btn_opzione2medio8.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio8_Click(object sender, EventArgs e)
        {
            btn_opzione4medio8.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3medio8_Click(object sender, EventArgs e)
        {
            btn_opzione3medio8.BackColor = Color.Green;

            punteggiolivellomedio8 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(22);


        }

        private void pb_indiziomedio8_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio8_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8medio.Text = $"{punteggioLivello}";


        }

        private void pb_indiziomedio8_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio8_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8medio.Text = $"{punteggioLivello}";

        }

        private void pb_indiziomedio8_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio8_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8medio.Text = $"{punteggioLivello}";

        }

        private void btn_opzione1medio9_Click(object sender, EventArgs e)
        {
            btn_opzione1medio9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9medio.Text = $"{punteggioLivello}";

        }

        private void btn_opzione2medio9_Click(object sender, EventArgs e)
        {
            btn_opzione2medio9.BackColor= Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio9_Click(object sender, EventArgs e)
        {
            btn_opzione4medio9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3medio9_Click(object sender, EventArgs e)
        {
            btn_opzione3medio9.BackColor = Color.Green;

            punteggiolivellomedio9 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(23);


        }

        private void pb_indiziomedio9_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio9_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9medio.Text = $"{punteggioLivello}";

        }

        private void pb_indiziomedio9_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio9_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9medio.Text = $"{punteggioLivello}";

        }

        private void pb_indiziomedio9_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio9_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9medio.Text = $"{punteggioLivello}";

        }

        private void btn_opzione1medio10_Click(object sender, EventArgs e)
        {
            btn_opzione1medio10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10medio.Text = $"{punteggioLivello}";

        }

        private void btn_opzione3medio10_Click(object sender, EventArgs e)
        {
            btn_opzione3medio10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4medio10_Click(object sender, EventArgs e)
        {
            btn_opzione4medio10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10medio.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2medio10_Click(object sender, EventArgs e)
        {
            btn_opzione2medio10.BackColor = Color.Green;

            punteggiolivellomedio10 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(24);

            punteggiototalemedio = punteggiolivellomedio1 + punteggiolivellomedio2 + punteggiolivellomedio3 + punteggiolivellomedio4 + punteggiolivellomedio5
                + punteggiolivellomedio6 + punteggiolivellomedio7 + punteggiolivellomedio8 + punteggiolivellomedio9 + punteggiolivellomedio10;

            giocatori nuovogiocatore = default;

            nuovogiocatore.giocatore = cbo_giocatore.Text;
            nuovogiocatore.punteggio = punteggiototalemedio;
            elegiocatori[num] = nuovogiocatore;
            num++;


            //Mylib.salva(elegiocatori, num);

            lbl_punteggiomediofinale.Text = $"{punteggiototalemedio}";



        }

        private void pb_indiziomedio10_1_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio10_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio10_2_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio10_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10medio.Text = $"{punteggioLivello}";
        }

        private void pb_indiziomedio10_3_Click(object sender, EventArgs e)
        {
            lbl_indiziomedio10_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10medio.Text = $"{punteggioLivello}";
        }

        private void pb_tornahomemedio_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(2);
        }

        private void pb_cambiagiocatoremedio_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(0);
        }

        private void pb_passaprincipiante_esperto_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(1);
        }

        private void pb_passacampione_esperto_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_homedifficile1_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciavantidifficile1_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(27);
        }

        private void pb_homedifficile2_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile2_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(26);
        }

        private void pb_frecciavantidifficile2_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(28);
        }

        private void pb_homedifficile3_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile3_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(27);
        }

        private void pb_frecciavantidifficile3_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(29);
        }

        private void pb_homedifficile4_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile4_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(28);
        }

        private void pb_frecciavantidifficile4_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(30);
        }

        private void pb_homedifficile5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(29);
        }

        private void pb_frecciavantidifficile5_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(31);
        }

        private void pb_homedifficile6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(30);
        }

        private void pb_frecciavantidifficile6_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(32);
        }

        private void pb_homedifficile7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(31);
        }

        private void pb_frecciavantidifficile7_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(33);
        }

        private void pb_homedifficile8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(32);
        }

        private void pb_frecciavantidifficile8_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(34);
        }

        private void pb_homedifficile9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(33);
        }

        private void pb_frecciavantidifficile9_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(35);
        }

        private void pb_homedifficile10_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(3);
        }

        private void pb_frecciaindietrodifficile10_Click(object sender, EventArgs e)
        {
            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(34);
        }

        private void btn_opzione2difficile1_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile1.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio1difficile.Text = $"{punteggioLivello}";

        }

        private void btn_opzione3difficile1_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile1.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio1difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile1_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile1.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio1difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile1_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile1.BackColor = Color.Green;

            punteggiodifficile1 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(27);
        }

        private void pb_indiziodifficile1_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile1_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile1_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile1_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile1_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile1_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio1difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile2_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile2_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile2_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile2.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio2difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile2_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile2.BackColor = Color.Green;

            punteggiodifficile2 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(28);

        }

        private void pb_indiziodifficile2_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile2_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2difficile.Text = $"{punteggioLivello}";


        }

        private void pb_indiziodifficile2_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile2_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile2_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile2_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio2difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile3_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile3_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile3_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile3.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio3difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile3_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile3.BackColor = Color.Green;

            punteggiodifficile3 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(29);


        }

        private void pb_indiziodifficile3_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile3_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3difficile.Text = $"{punteggioLivello}";


        }

        private void pb_indiziodifficile3_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile3_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile3_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile3_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio3difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile4_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile4_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile4_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile4.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio4difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile4_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile4.BackColor = Color.Green;

            punteggiodifficile4 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(30);
        }

        private void pb_indiziodifficile4_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile4_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile4_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile4_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile4_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile4_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio4difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile5_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile5_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile5_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile5.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio5difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile5_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile5.BackColor = Color.Green;

            punteggiodifficile5 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(31);


        }

        private void pb_indiziodifficile5_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile5_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile5_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile5_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile5_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile5_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio5difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile6_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile6_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile6_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile6.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio6difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile6_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile6.BackColor = Color.Green;

            punteggiodifficile6 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(32);


        }

        private void pb_indiziodifficile6_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile6_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile6_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile6_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile6_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile6_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio6difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile7_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile7_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile7_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile7.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio7difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile7_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile7.BackColor = Color.Green;

            punteggiodifficile7 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(33);


        }

        private void pb_indiziodifficile7_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile7_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile7_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile7_2.Visible = true;


            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile7_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile7_3.Visible = true;


            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio7difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile8_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile8.BackColor = Color.Red;


            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile8_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile8.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile8_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile8.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio8difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile8_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile8.BackColor = Color.Green;

            punteggiodifficile8 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(34);



        }

        private void pb_indiziodifficile8_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile8_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8difficile.Text = $"{punteggioLivello}";


        }

        private void pb_indiziodifficile8_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile8_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile8_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile8_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio8difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile9_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile9_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile9_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile9.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio9difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile9_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile9.BackColor = Color.Green;

            punteggiodifficile9 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(35);
        }

        private void pb_indiziodifficile9_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile9_1.Visible = true;


            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile9_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile9_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile9_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile9_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio9difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione2difficile10_Click(object sender, EventArgs e)
        {
            btn_opzione2difficile10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione3difficile10_Click(object sender, EventArgs e)
        {
            btn_opzione3difficile10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione4difficile10_Click(object sender, EventArgs e)
        {
            btn_opzione4difficile10.BackColor = Color.Red;

            punteggioLivello = punteggioLivello - 20;

            lbl_punteggio10difficile.Text = $"{punteggioLivello}";
        }

        private void btn_opzione1difficile10_Click(object sender, EventArgs e)
        {
            btn_opzione1difficile10.BackColor = Color.Green;

            punteggiodifficile10 = punteggioLivello;

            punteggioLivello = 100;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(36);

            punteggiodifficiletotale = punteggiodifficile1 + punteggiodifficile2 + punteggiodifficile3 + punteggiodifficile4 + punteggiodifficile5
                + punteggiodifficile6 + punteggiodifficile7 + punteggiodifficile8 + punteggiodifficile9 + punteggiodifficile10;

            giocatori nuovogiocatore = default;

            nuovogiocatore.giocatore = cbo_giocatore.Text;
            nuovogiocatore.punteggio = punteggiototalemedio;
            elegiocatori[num] = nuovogiocatore;
            num++;


            //Mylib.salva(elegiocatori, num);

            lbl_punteggiofinaledifficile.Text = $"{punteggiodifficiletotale}";

        }

        private void pb_indiziodifficile10_1_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile10_1.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile10_2_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile10_2.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10difficile.Text = $"{punteggioLivello}";
        }

        private void pb_indiziodifficile10_3_Click(object sender, EventArgs e)
        {
            lbl_indiziodifficile10_3.Visible = true;

            punteggioLivello = punteggioLivello - 10;

            lbl_punteggio10difficile.Text = $"{punteggioLivello}";
        }
    }
}
