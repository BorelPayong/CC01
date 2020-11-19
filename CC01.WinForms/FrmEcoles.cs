using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmEcoles : Form
    {
        public FrmEcoles()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form E = new FrmParent();
            E.Show();
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxAbreviation.Clear();
            textBoxNomEcole.Clear();
            textBoxQuartier.Clear();
            textBoxRecherche.Clear();
            textBoxVille.Clear();
        }
    }
}
