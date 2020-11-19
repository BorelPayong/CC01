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
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void buttonEtudiants_Click(object sender, EventArgs e)
        {
            Form E = new FrmEtudiant();
            E.Show();
            this.Close();
        }

        private void buttonEcoles_Click(object sender, EventArgs e)
        {
            Form E = new FrmEcoles();
            E.Show();
            this.Close();
        }
    }
}
