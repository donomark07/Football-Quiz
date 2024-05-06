
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


namespace Football_Quiz
{
    public partial class Form1 : Form
    {
        private giocatori[] elegiocatori = new giocatori[50];
        private int num = 0;
        private int punteggioIniziale = 100;
        private int punteggioLivello = 100;
        private int punteggioParzialeLivello = default(int);
        
        
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

            punteggioIniziale = punteggioLivello;

            punteggioLivello = punteggioLivello - 20;

            punteggioParzialeLivello = punteggioIniziale + punteggioLivello;

            lbl_punteggio1facile.Text = $"{punteggioParzialeLivello}";
            
        }

        private void btn_opzione3facile1_Click(object sender, EventArgs e)
        {
            btn_opzione3facile1.BackColor = Color.Red;

            punteggioIniziale = punteggioLivello;

            punteggioLivello = punteggioLivello - 20;

            punteggioParzialeLivello = punteggioIniziale + punteggioLivello;

            lbl_punteggio1facile.Text = $"{punteggioParzialeLivello}";
        }

        private void btn_opzione2facile1_Click(object sender, EventArgs e)
        {
            btn_opzione2facile1.BackColor = Color.Green;

            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(5);

            
        }

        private void btn_opzione4facile1_Click(object sender, EventArgs e)
        {
            btn_opzione4facile1.BackColor = Color.Red;

            punteggioIniziale = punteggioLivello;

            punteggioLivello = punteggioLivello - 20;

            punteggioParzialeLivello = punteggioIniziale + punteggioLivello;

            lbl_punteggio1facile.Text = $"{punteggioParzialeLivello}";
        }

        private void pb_inzidiofacile1_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile1_1.Visible = true;

            punteggioIniziale = punteggioLivello;

            punteggioLivello = punteggioLivello - 10;

            punteggioParzialeLivello = punteggioIniziale + punteggioLivello;

            lbl_punteggio1facile.Text = $"{punteggioParzialeLivello}";
        }

        private void pb_indiziofacile1_2_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile1_2.Visible = true;

            punteggioIniziale = punteggioLivello;

            punteggioLivello = punteggioLivello - 10;

            punteggioParzialeLivello = punteggioIniziale + punteggioLivello;

            lbl_punteggio1facile.Text = $"{punteggioParzialeLivello}";
        }

        private void pb_indiziofacile1_3_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile1_3.Visible = true;

            punteggioIniziale = punteggioLivello;

            punteggioLivello = punteggioLivello - 10;

            punteggioParzialeLivello = punteggioIniziale + punteggioLivello;

            lbl_punteggio1facile.Text = $"{punteggioParzialeLivello}";
        }

        private void btn_opzione1facile2_Click(object sender, EventArgs e)
        {
            btn_opzione1facile2.BackColor = Color.Red;
        }

        private void btn_opzione3facile2_Click(object sender, EventArgs e)
        {
            btn_opzione3facile2.BackColor= Color.Green;

            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(6);
        }

        private void btn_opzione2facile2_Click(object sender, EventArgs e)
        {
            btn_opzione2facile2.BackColor = Color.Red;
        }

        private void btn_opzione4facile2_Click(object sender, EventArgs e)
        {
            btn_opzione4facile2.BackColor = Color.Red;
        }

        private void pb_indiziofacile2_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile2_1.Visible = true;
   
        }

        private void pb_indiziofacile2_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile2_2.Visible = true;
        }

        private void pb_indiziofacile2_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile2_3.Visible = true;
        }

        private void btn_opzione1facile3_Click(object sender, EventArgs e)
        {
            btn_opzione1facile3.BackColor = Color.Red;
        }

        private void btn_opzione2facile3_Click(object sender, EventArgs e)
        {
            btn_opzione2facile3.BackColor = Color.Red;
        }

        private void btn_opzione4facile3_Click(object sender, EventArgs e)
        {
            btn_opzione4facile3.BackColor = Color.Red;
        }

        private void btn_opzione3facile3_Click(object sender, EventArgs e)
        {
            btn_opzione3facile3.BackColor = Color.Green;

            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(7);

        }

        private void pb_indiziofacile3_1_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile3_1.Visible = true;
        }

        private void pb_indiziofacile3_2_Click(object sender, EventArgs e)
        {
            lbl_indiziofacile3_2.Visible = true;
        }

        private void pb_indiziofacile3_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile3_3.Visible = true; 
        }

        private void btn_opzione3facile4_Click(object sender, EventArgs e)
        {
            btn_opzione3facile4.BackColor = Color.Red;
        }

        private void btn_opzione2facile4_Click(object sender, EventArgs e)
        {
            btn_opzione2facile4.BackColor = Color.Red;
        }

        private void btn_opzione4facile4_Click(object sender, EventArgs e)
        {
            btn_opzione4facile4.BackColor = Color.Red;
        }

        private void btn_opzione1facile4_Click(object sender, EventArgs e)
        {
            btn_opzione1facile4.BackColor = Color.Green;

            Thread.Sleep(1000);

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(8);
        }

        private void btn_opzione3facile5_Click(object sender, EventArgs e)
        {
            btn_opzione3facile5.BackColor = Color.Red;
        }

        private void btn_opzione4facile5_Click(object sender, EventArgs e)
        {
            btn_opzione4facile5.BackColor = Color.Red;
        }

        private void btn_opzione2facile5_Click(object sender, EventArgs e)
        {
            btn_opzione2facile5.BackColor= Color.Red;
        }

        private void btn_opzione1facile5_Click(object sender, EventArgs e)
        {
            btn_opzione1facile5.BackColor = Color.Green;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(9);
        }

        private void pb_indiziofacile5_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile5_1.Visible = true;
        }

        private void pb_indiziofacile5_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile5_2.Visible = true;
        }

        private void pb_indiziofacile5_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile5_3.Visible = true;
        }

        private void btn_opzione1facile6_Click(object sender, EventArgs e)
        {
            btn_opzione1facile6.BackColor = Color.Red;
        }

        private void btn_opzione2facile6_Click(object sender, EventArgs e)
        {
            btn_opzione2facile6.BackColor = Color.Red;
        }

        private void btn_opzione4facile6_Click(object sender, EventArgs e)
        {
            btn_opzione4facile6.BackColor = Color.Red;
        }

        private void btn_opzione3facile6_Click(object sender, EventArgs e)
        {
            btn_opzione3facile6.BackColor = Color.Green;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(10);
        }

        private void pb_indiziofacile6_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile6_1.Visible = true;
        }

        private void pb_indiziofacile6_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile6_2.Visible = true;
        }

        private void pb_indiziofacile6_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile6_3.Visible = true;
        }

        private void btn_opzione1facile7_Click(object sender, EventArgs e)
        {
            btn_opzione1facile7.BackColor = Color.Red;
        }

        private void btn_opzione2facile7_Click(object sender, EventArgs e)
        {
            btn_opzione2facile7.BackColor = Color.Red;
        }

        private void btn_opzione4facile7_Click(object sender, EventArgs e)
        {
            btn_opzione4facile7.BackColor = Color.Red;
        }

        private void btn_opzione3facile7_Click(object sender, EventArgs e)
        {
            btn_opzione3facile7.BackColor = Color.Green;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(11);
        }

        private void pb_indizifacile7_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile7_1.Visible = true;
        }

        private void pb_indiziofacile7_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile7_2.Visible = true;
        }

        private void pb_indiziofacile7_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile7_3.Visible = true;
        }

        private void btn_opzione1facile8_Click(object sender, EventArgs e)
        {
            btn_opzione1facile8.BackColor = Color.Red;
        }

        private void btn_opzione3facile8_Click(object sender, EventArgs e)
        {
            btn_opzione3facile8.BackColor = Color.Red;
        }

        private void btn_opzione2facile8_Click(object sender, EventArgs e)
        {
            btn_opzione2facile8.BackColor= Color.Red;
        }

        private void btn_opzione4facile8_Click(object sender, EventArgs e)
        {
            btn_opzione4facile8.BackColor = Color.Green;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(12);
        }

        private void pb_indiziofacile8_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile8_1.Visible = true;
        }

        private void pb_indiziofacile8_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile8_2.Visible = true;
        }

        private void pb_indiziofacile8_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile8_3.Visible = true;
        }

        private void btn_opzione3facile9_Click(object sender, EventArgs e)
        {
            btn_opzione3facile9.BackColor = Color.Red;
        }

        private void btn_opzione4facile9_Click(object sender, EventArgs e)
        {
            btn_opzione4facile9.BackColor = Color.Red;
        }

        private void btn_opzione2facile9_Click(object sender, EventArgs e)
        {
            btn_opzione2facile9.BackColor = Color.Red;
        }

        private void btn_opzione1facile9_Click(object sender, EventArgs e)
        {
            btn_opzione1facile9.BackColor = Color.Green;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(13);
        }

        private void pb_indiziofacile9_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile9_1.Visible = true;
        }

        private void pb_indiziofacile9_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile9_2.Visible = true;
        }

        private void pb_indiziofacile9_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile9_3.Visible = true;
        }

        private void btn_opzione1facile10_Click(object sender, EventArgs e)
        {
            btn_opzione1facile10.BackColor = Color.Red;
        }

        private void btn_opzione3facile10_Click(object sender, EventArgs e)
        {
            btn_opzione3facile10.BackColor = Color.Red;
        }

        private void btn_opzione4facile10_Click(object sender, EventArgs e)
        {
            btn_opzione4facile10.BackColor = Color.Red;
        }

        private void btn_opzione2facile10_Click(object sender, EventArgs e)
        {
            btn_opzione2facile10.BackColor = Color.Green;

            tbc_squadre.Visible = true;
            tbc_squadre.SelectTab(14);
        }

        private void pb_indiziofacile10_1_Click(object sender, EventArgs e)
        {
            lbl_indizifacile10_1.Visible = true;
        }

        private void pb_livellofacile10_2_Click(object sender, EventArgs e)
        {
            lbl_indizifacile10_2.Visible = true;
        }

        private void pb_livellofacile10_3_Click(object sender, EventArgs e)
        {
            lbl_indizifacile10_3.Visible = true;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        
    }
}
