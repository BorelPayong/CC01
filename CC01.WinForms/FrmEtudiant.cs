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
    public partial class FrmEtudiant : Form
    {
        public FrmEtudiant()
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
            textBoxA.Clear();
            textBoxContact.Clear();
            textBoxEmail.Clear();
            textBoxfirstname.Clear();
            textBoxId.Clear();
            textBoxlastname.Clear();
            textBoxNomEcole.Clear();
            textBoxBorn.Clear();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSauvegarder_Click(object sender, EventArgs e)
        {

        }
    }
}
