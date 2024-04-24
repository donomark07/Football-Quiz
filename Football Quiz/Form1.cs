using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbc_squadre.Appearance = TabAppearance.FlatButtons;
            tbc_squadre.ItemSize = new Size(0, 1);
            tbc_squadre.SizeMode = TabSizeMode.Fixed;
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
            if (dato == "Facile")
            {
                tbc_squadre.SelectTab(1);
            }
            if (dato == "Medio")
            {
                tbc_squadre.SelectTab(2);
            }
            if (dato == "Difficile")
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
    }
}
