namespace CC01.WinForms
{
    partial class FrmParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEtudiants = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEcoles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEtudiants
            // 
            this.buttonEtudiants.Location = new System.Drawing.Point(12, 224);
            this.buttonEtudiants.Name = "buttonEtudiants";
            this.buttonEtudiants.Size = new System.Drawing.Size(201, 86);
            this.buttonEtudiants.TabIndex = 0;
            this.buttonEtudiants.Text = "Etudiants";
            this.buttonEtudiants.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue";
            // 
            // buttonEcoles
            // 
            this.buttonEcoles.Location = new System.Drawing.Point(268, 224);
            this.buttonEcoles.Name = "buttonEcoles";
            this.buttonEcoles.Size = new System.Drawing.Size(201, 86);
            this.buttonEcoles.TabIndex = 2;
            this.buttonEcoles.Text = "Ecoles";
            this.buttonEcoles.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copyright by FB";
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEcoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEtudiants);
            this.Name = "FrmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEtudiants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEcoles;
        private System.Windows.Forms.Label label2;
    }
}