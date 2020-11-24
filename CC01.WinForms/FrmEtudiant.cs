using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC01.BLL;
using CC01.BO;



namespace CC01.WinForms
{
    public partial class FrmEtudiant : Form
    {
        private Action callBack;
        private Etudiant oldEtudiant;

        public FrmEtudiant()
        {
            InitializeComponent();
        }

        public FrmEtudiant(Action callBack):this()
        {
            this.callBack = callBack;
        }

        public FrmEtudiant(Etudiant etudiant, Action callBack) : this()
        {
            this.oldEtudiant = etudiant;
            textBoxfirstname.Text = etudiant.Firstname;
            textBoxlastname.Text = etudiant.Lastname;
            textBoxBorn.Text = etudiant.Born;
            textBoxA.Text = etudiant.Lieu;
            textBoxId.Text = etudiant.Identifiant;
            textBoxContact.Text = etudiant.Contact.ToString();
            if (etudiant.Picture != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(etudiant.Picture));
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
            try
            {
                checkForm();

                Etudiant newetudiant = new Etudiant
                    (
                        textBoxfirstname.Text,
                        textBoxlastname.Text,
                        textBoxBorn.Text,
                        textBoxA.Text,
                        textBoxId.Text.ToUpper(),
                        double.Parse(textBoxContact.Text),
                        textBoxEmail.Text,
                        textBoxNomEcole.Text,
                        !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtudiant?.Picture
                        
                    );

                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEtudiant == null)
                    etudiantBLO.CreateEtudiant(newetudiant);
                else
                    etudiantBLO.EditEtudiant(oldEtudiant, newetudiant);

                MessageBox.Show
                (
                    "Sauvergade reussi !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldEtudiant != null)
                    Close();

                textBoxA.Clear();
                textBoxContact.Clear();
                textBoxEmail.Clear();
                textBoxfirstname.Clear();
                textBoxId.Clear();
                textBoxlastname.Clear();
                textBoxNomEcole.Clear();
                textBoxBorn.Clear();
            }

            catch(TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }

            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }

            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }

            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        private void checkForm()
        {
            string text = string.Empty;
            textBoxId.BackColor = Color.White;
            textBoxfirstname.BackColor = Color.White;
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                text += "- entrez Id ! \n";
                textBoxId.BackColor = Color.Pink;
            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
