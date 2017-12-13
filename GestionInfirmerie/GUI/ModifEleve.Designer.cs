namespace GUI
{
    partial class ModifEleve
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
            this.ModificationEleve = new System.Windows.Forms.Label();
            this.NomEleveModif = new System.Windows.Forms.Label();
            this.LabelNomEleveModif = new System.Windows.Forms.Label();
            this.PrenomEleveModif = new System.Windows.Forms.Label();
            this.LabelPrenomEleveModif = new System.Windows.Forms.Label();
            this.ClasseEleveModif = new System.Windows.Forms.Label();
            this.LabelClasseEleveModif = new System.Windows.Forms.Label();
            this.DateNaissanceEleveModif = new System.Windows.Forms.Label();
            this.CommentaireSanteEleveModif = new System.Windows.Forms.Label();
            this.TelEleveModif = new System.Windows.Forms.Label();
            this.TelParentEleveModif = new System.Windows.Forms.Label();
            this.TextBoxCommentaireModifEleve = new System.Windows.Forms.TextBox();
            this.TextBoxTelephoneEleveModifEleve = new System.Windows.Forms.TextBox();
            this.TextBoxelephoneParentModifEleve = new System.Windows.Forms.TextBox();
            this.ArchiveOuiModifEleve = new System.Windows.Forms.RadioButton();
            this.ArchiveNonModifEleve = new System.Windows.Forms.RadioButton();
            this.TierTNonModifEleve = new System.Windows.Forms.RadioButton();
            this.TierTOuiModifEleve = new System.Windows.Forms.RadioButton();
            this.ModifEleveDeconnexion = new System.Windows.Forms.Button();
            this.ModifEleveRetour = new System.Windows.Forms.Button();
            this.ModifEleveValidation = new System.Windows.Forms.Button();
            this.LabelDateNEleveModif = new System.Windows.Forms.Label();
            this.TierTModifEleve = new System.Windows.Forms.GroupBox();
            this.EtatModifEleve = new System.Windows.Forms.GroupBox();
            this.TierTModifEleve.SuspendLayout();
            this.EtatModifEleve.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModificationEleve
            // 
            this.ModificationEleve.AutoSize = true;
            this.ModificationEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificationEleve.Location = new System.Drawing.Point(95, 9);
            this.ModificationEleve.Name = "ModificationEleve";
            this.ModificationEleve.Size = new System.Drawing.Size(288, 31);
            this.ModificationEleve.TabIndex = 0;
            this.ModificationEleve.Text = "Modification d\'un élève";
            // 
            // NomEleveModif
            // 
            this.NomEleveModif.AutoSize = true;
            this.NomEleveModif.Location = new System.Drawing.Point(8, 75);
            this.NomEleveModif.Name = "NomEleveModif";
            this.NomEleveModif.Size = new System.Drawing.Size(83, 13);
            this.NomEleveModif.TabIndex = 1;
            this.NomEleveModif.Text = "Nom de l\'élève :";
            // 
            // LabelNomEleveModif
            // 
            this.LabelNomEleveModif.AutoSize = true;
            this.LabelNomEleveModif.Location = new System.Drawing.Point(145, 75);
            this.LabelNomEleveModif.Name = "LabelNomEleveModif";
            this.LabelNomEleveModif.Size = new System.Drawing.Size(35, 13);
            this.LabelNomEleveModif.TabIndex = 2;
            this.LabelNomEleveModif.Text = "label3";
            // 
            // PrenomEleveModif
            // 
            this.PrenomEleveModif.AutoSize = true;
            this.PrenomEleveModif.Location = new System.Drawing.Point(8, 95);
            this.PrenomEleveModif.Name = "PrenomEleveModif";
            this.PrenomEleveModif.Size = new System.Drawing.Size(97, 13);
            this.PrenomEleveModif.TabIndex = 3;
            this.PrenomEleveModif.Text = "Prénom de l\'élève :";
            this.PrenomEleveModif.Click += new System.EventHandler(this.label4_Click);
            // 
            // LabelPrenomEleveModif
            // 
            this.LabelPrenomEleveModif.AutoSize = true;
            this.LabelPrenomEleveModif.Location = new System.Drawing.Point(145, 95);
            this.LabelPrenomEleveModif.Name = "LabelPrenomEleveModif";
            this.LabelPrenomEleveModif.Size = new System.Drawing.Size(35, 13);
            this.LabelPrenomEleveModif.TabIndex = 4;
            this.LabelPrenomEleveModif.Text = "label5";
            // 
            // ClasseEleveModif
            // 
            this.ClasseEleveModif.AutoSize = true;
            this.ClasseEleveModif.Location = new System.Drawing.Point(8, 115);
            this.ClasseEleveModif.Name = "ClasseEleveModif";
            this.ClasseEleveModif.Size = new System.Drawing.Size(92, 13);
            this.ClasseEleveModif.TabIndex = 5;
            this.ClasseEleveModif.Text = "Classe de l\'élève :";
            // 
            // LabelClasseEleveModif
            // 
            this.LabelClasseEleveModif.AutoSize = true;
            this.LabelClasseEleveModif.Location = new System.Drawing.Point(145, 115);
            this.LabelClasseEleveModif.Name = "LabelClasseEleveModif";
            this.LabelClasseEleveModif.Size = new System.Drawing.Size(35, 13);
            this.LabelClasseEleveModif.TabIndex = 6;
            this.LabelClasseEleveModif.Text = "label7";
            // 
            // DateNaissanceEleveModif
            // 
            this.DateNaissanceEleveModif.AutoSize = true;
            this.DateNaissanceEleveModif.Location = new System.Drawing.Point(8, 143);
            this.DateNaissanceEleveModif.Name = "DateNaissanceEleveModif";
            this.DateNaissanceEleveModif.Size = new System.Drawing.Size(102, 13);
            this.DateNaissanceEleveModif.TabIndex = 7;
            this.DateNaissanceEleveModif.Text = "Date de naissance :";
            // 
            // CommentaireSanteEleveModif
            // 
            this.CommentaireSanteEleveModif.AutoSize = true;
            this.CommentaireSanteEleveModif.Location = new System.Drawing.Point(8, 172);
            this.CommentaireSanteEleveModif.Name = "CommentaireSanteEleveModif";
            this.CommentaireSanteEleveModif.Size = new System.Drawing.Size(118, 13);
            this.CommentaireSanteEleveModif.TabIndex = 8;
            this.CommentaireSanteEleveModif.Text = "Commentaire de santé :";
            // 
            // TelEleveModif
            // 
            this.TelEleveModif.AutoSize = true;
            this.TelEleveModif.Location = new System.Drawing.Point(8, 195);
            this.TelEleveModif.Name = "TelEleveModif";
            this.TelEleveModif.Size = new System.Drawing.Size(112, 13);
            this.TelEleveModif.TabIndex = 9;
            this.TelEleveModif.Text = "Téléphone de l\'élève :";
            // 
            // TelParentEleveModif
            // 
            this.TelParentEleveModif.AutoSize = true;
            this.TelParentEleveModif.Location = new System.Drawing.Point(8, 217);
            this.TelParentEleveModif.Name = "TelParentEleveModif";
            this.TelParentEleveModif.Size = new System.Drawing.Size(122, 13);
            this.TelParentEleveModif.TabIndex = 10;
            this.TelParentEleveModif.Text = "Téléphone des parents :";
            // 
            // TextBoxCommentaireModifEleve
            // 
            this.TextBoxCommentaireModifEleve.Location = new System.Drawing.Point(148, 169);
            this.TextBoxCommentaireModifEleve.Name = "TextBoxCommentaireModifEleve";
            this.TextBoxCommentaireModifEleve.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCommentaireModifEleve.TabIndex = 13;
            // 
            // TextBoxTelephoneEleveModifEleve
            // 
            this.TextBoxTelephoneEleveModifEleve.Location = new System.Drawing.Point(148, 195);
            this.TextBoxTelephoneEleveModifEleve.Name = "TextBoxTelephoneEleveModifEleve";
            this.TextBoxTelephoneEleveModifEleve.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTelephoneEleveModifEleve.TabIndex = 14;
            // 
            // TextBoxelephoneParentModifEleve
            // 
            this.TextBoxelephoneParentModifEleve.Location = new System.Drawing.Point(148, 219);
            this.TextBoxelephoneParentModifEleve.Name = "TextBoxelephoneParentModifEleve";
            this.TextBoxelephoneParentModifEleve.Size = new System.Drawing.Size(100, 20);
            this.TextBoxelephoneParentModifEleve.TabIndex = 15;
            // 
            // ArchiveOuiModifEleve
            // 
            this.ArchiveOuiModifEleve.AutoSize = true;
            this.ArchiveOuiModifEleve.Location = new System.Drawing.Point(58, 17);
            this.ArchiveOuiModifEleve.Name = "ArchiveOuiModifEleve";
            this.ArchiveOuiModifEleve.Size = new System.Drawing.Size(41, 17);
            this.ArchiveOuiModifEleve.TabIndex = 16;
            this.ArchiveOuiModifEleve.TabStop = true;
            this.ArchiveOuiModifEleve.Text = "Oui";
            this.ArchiveOuiModifEleve.UseVisualStyleBackColor = true;
            // 
            // ArchiveNonModifEleve
            // 
            this.ArchiveNonModifEleve.AutoSize = true;
            this.ArchiveNonModifEleve.Location = new System.Drawing.Point(105, 17);
            this.ArchiveNonModifEleve.Name = "ArchiveNonModifEleve";
            this.ArchiveNonModifEleve.Size = new System.Drawing.Size(45, 17);
            this.ArchiveNonModifEleve.TabIndex = 17;
            this.ArchiveNonModifEleve.TabStop = true;
            this.ArchiveNonModifEleve.Text = "Non";
            this.ArchiveNonModifEleve.UseVisualStyleBackColor = true;
            // 
            // TierTNonModifEleve
            // 
            this.TierTNonModifEleve.AutoSize = true;
            this.TierTNonModifEleve.Location = new System.Drawing.Point(105, 19);
            this.TierTNonModifEleve.Name = "TierTNonModifEleve";
            this.TierTNonModifEleve.Size = new System.Drawing.Size(45, 17);
            this.TierTNonModifEleve.TabIndex = 19;
            this.TierTNonModifEleve.TabStop = true;
            this.TierTNonModifEleve.Text = "Non";
            this.TierTNonModifEleve.UseVisualStyleBackColor = true;
            this.TierTNonModifEleve.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // TierTOuiModifEleve
            // 
            this.TierTOuiModifEleve.AutoSize = true;
            this.TierTOuiModifEleve.Location = new System.Drawing.Point(58, 19);
            this.TierTOuiModifEleve.Name = "TierTOuiModifEleve";
            this.TierTOuiModifEleve.Size = new System.Drawing.Size(41, 17);
            this.TierTOuiModifEleve.TabIndex = 18;
            this.TierTOuiModifEleve.TabStop = true;
            this.TierTOuiModifEleve.Text = "Oui";
            this.TierTOuiModifEleve.UseVisualStyleBackColor = true;
            // 
            // ModifEleveDeconnexion
            // 
            this.ModifEleveDeconnexion.Location = new System.Drawing.Point(401, 368);
            this.ModifEleveDeconnexion.Name = "ModifEleveDeconnexion";
            this.ModifEleveDeconnexion.Size = new System.Drawing.Size(75, 23);
            this.ModifEleveDeconnexion.TabIndex = 21;
            this.ModifEleveDeconnexion.Text = "Déconexion";
            this.ModifEleveDeconnexion.UseVisualStyleBackColor = true;
            // 
            // ModifEleveRetour
            // 
            this.ModifEleveRetour.Location = new System.Drawing.Point(320, 368);
            this.ModifEleveRetour.Name = "ModifEleveRetour";
            this.ModifEleveRetour.Size = new System.Drawing.Size(75, 23);
            this.ModifEleveRetour.TabIndex = 22;
            this.ModifEleveRetour.Text = "Retour";
            this.ModifEleveRetour.UseVisualStyleBackColor = true;
            // 
            // ModifEleveValidation
            // 
            this.ModifEleveValidation.Location = new System.Drawing.Point(148, 368);
            this.ModifEleveValidation.Name = "ModifEleveValidation";
            this.ModifEleveValidation.Size = new System.Drawing.Size(75, 23);
            this.ModifEleveValidation.TabIndex = 23;
            this.ModifEleveValidation.Text = "Modifier";
            this.ModifEleveValidation.UseVisualStyleBackColor = true;
            this.ModifEleveValidation.Click += new System.EventHandler(this.ModifEleveValidation_Click);
            // 
            // LabelDateNEleveModif
            // 
            this.LabelDateNEleveModif.AutoSize = true;
            this.LabelDateNEleveModif.Location = new System.Drawing.Point(148, 143);
            this.LabelDateNEleveModif.Name = "LabelDateNEleveModif";
            this.LabelDateNEleveModif.Size = new System.Drawing.Size(35, 13);
            this.LabelDateNEleveModif.TabIndex = 24;
            this.LabelDateNEleveModif.Text = "label1";
            // 
            // TierTModifEleve
            // 
            this.TierTModifEleve.Controls.Add(this.ArchiveNonModifEleve);
            this.TierTModifEleve.Controls.Add(this.ArchiveOuiModifEleve);
            this.TierTModifEleve.Location = new System.Drawing.Point(11, 245);
            this.TierTModifEleve.Name = "TierTModifEleve";
            this.TierTModifEleve.Size = new System.Drawing.Size(206, 40);
            this.TierTModifEleve.TabIndex = 25;
            this.TierTModifEleve.TabStop = false;
            this.TierTModifEleve.Text = "Tiers Temps :";
            // 
            // EtatModifEleve
            // 
            this.EtatModifEleve.Controls.Add(this.TierTNonModifEleve);
            this.EtatModifEleve.Controls.Add(this.TierTOuiModifEleve);
            this.EtatModifEleve.Location = new System.Drawing.Point(11, 291);
            this.EtatModifEleve.Name = "EtatModifEleve";
            this.EtatModifEleve.Size = new System.Drawing.Size(206, 43);
            this.EtatModifEleve.TabIndex = 26;
            this.EtatModifEleve.TabStop = false;
            this.EtatModifEleve.Text = "Elève Archivé :";
            // 
            // ModifEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 405);
            this.Controls.Add(this.EtatModifEleve);
            this.Controls.Add(this.TierTModifEleve);
            this.Controls.Add(this.LabelDateNEleveModif);
            this.Controls.Add(this.ModifEleveValidation);
            this.Controls.Add(this.ModifEleveRetour);
            this.Controls.Add(this.ModifEleveDeconnexion);
            this.Controls.Add(this.TextBoxelephoneParentModifEleve);
            this.Controls.Add(this.TextBoxTelephoneEleveModifEleve);
            this.Controls.Add(this.TextBoxCommentaireModifEleve);
            this.Controls.Add(this.TelParentEleveModif);
            this.Controls.Add(this.TelEleveModif);
            this.Controls.Add(this.CommentaireSanteEleveModif);
            this.Controls.Add(this.DateNaissanceEleveModif);
            this.Controls.Add(this.LabelClasseEleveModif);
            this.Controls.Add(this.ClasseEleveModif);
            this.Controls.Add(this.LabelPrenomEleveModif);
            this.Controls.Add(this.PrenomEleveModif);
            this.Controls.Add(this.LabelNomEleveModif);
            this.Controls.Add(this.NomEleveModif);
            this.Controls.Add(this.ModificationEleve);
            this.Name = "ModifEleve";
            this.Text = "ModifEleve";
            this.Load += new System.EventHandler(this.ModifEleve_Load);
            this.TierTModifEleve.ResumeLayout(false);
            this.TierTModifEleve.PerformLayout();
            this.EtatModifEleve.ResumeLayout(false);
            this.EtatModifEleve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModificationEleve;
        private System.Windows.Forms.Label NomEleveModif;
        private System.Windows.Forms.Label LabelNomEleveModif;
        private System.Windows.Forms.Label PrenomEleveModif;
        private System.Windows.Forms.Label LabelPrenomEleveModif;
        private System.Windows.Forms.Label ClasseEleveModif;
        private System.Windows.Forms.Label LabelClasseEleveModif;
        private System.Windows.Forms.Label DateNaissanceEleveModif;
        private System.Windows.Forms.Label CommentaireSanteEleveModif;
        private System.Windows.Forms.Label TelEleveModif;
        private System.Windows.Forms.Label TelParentEleveModif;
        private System.Windows.Forms.TextBox TextBoxCommentaireModifEleve;
        private System.Windows.Forms.TextBox TextBoxTelephoneEleveModifEleve;
        private System.Windows.Forms.TextBox TextBoxelephoneParentModifEleve;
        private System.Windows.Forms.RadioButton ArchiveOuiModifEleve;
        private System.Windows.Forms.RadioButton ArchiveNonModifEleve;
        private System.Windows.Forms.RadioButton TierTNonModifEleve;
        private System.Windows.Forms.RadioButton TierTOuiModifEleve;
        private System.Windows.Forms.Button ModifEleveDeconnexion;
        private System.Windows.Forms.Button ModifEleveRetour;
        private System.Windows.Forms.Button ModifEleveValidation;
        private System.Windows.Forms.Label LabelDateNEleveModif;
        private System.Windows.Forms.GroupBox TierTModifEleve;
        private System.Windows.Forms.GroupBox EtatModifEleve;
    }
}