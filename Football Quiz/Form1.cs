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

        

        
    }
}
