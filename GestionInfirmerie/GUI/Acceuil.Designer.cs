namespace GUI
{
    partial class Acceuil
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
            this.DataViewAcc = new System.Windows.Forms.DataGridView();
            this.BtGestionEleve = new System.Windows.Forms.Button();
            this.BtGestionVisite = new System.Windows.Forms.Button();
            this.BtGestionMedicament = new System.Windows.Forms.Button();
            this.BtDeconnexion = new System.Windows.Forms.Button();
            this.BtQuitter = new System.Windows.Forms.Button();
            this.TitreAcc = new System.Windows.Forms.Label();
            this.LabelAnnee = new System.Windows.Forms.Label();
            this.CalendrierDebut = new System.Windows.Forms.DateTimePicker();
            this.CalendrierFin = new System.Windows.Forms.DateTimePicker();
            this.LabelDataDebut = new System.Windows.Forms.Label();
            this.LabelDataFin = new System.Windows.Forms.Label();
            this.BtFiltreAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // DataViewAcc
            // 
            this.DataViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewAcc.Location = new System.Drawing.Point(28, 149);
            this.DataViewAcc.Name = "DataViewAcc";
            this.DataViewAcc.Size = new System.Drawing.Size(372, 333);
            this.DataViewAcc.TabIndex = 0;
            // 
            // BtGestionEleve
            // 
            this.BtGestionEleve.Location = new System.Drawing.Point(454, 179);
            this.BtGestionEleve.Name = "BtGestionEleve";
            this.BtGestionEleve.Size = new System.Drawing.Size(186, 69);
            this.BtGestionEleve.TabIndex = 1;
            this.BtGestionEleve.Text = "Géré les élèves";
            this.BtGestionEleve.UseVisualStyleBackColor = true;
            this.BtGestionEleve.Click += new System.EventHandler(this.BtGestionEleve_Click);
            // 
            // BtGestionVisite
            // 
            this.BtGestionVisite.Location = new System.Drawing.Point(454, 280);
            this.BtGestionVisite.Name = "BtGestionVisite";
            this.BtGestionVisite.Size = new System.Drawing.Size(186, 69);
            this.BtGestionVisite.TabIndex = 2;
            this.BtGestionVisite.Text = "Géré les visites";
            this.BtGestionVisite.UseVisualStyleBackColor = true;
            // 
            // BtGestionMedicament
            // 
            this.BtGestionMedicament.Location = new System.Drawing.Point(454, 368);
            this.BtGestionMedicament.Name = "BtGestionMedicament";
            this.BtGestionMedicament.Size = new System.Drawing.Size(186, 69);
            this.BtGestionMedicament.TabIndex = 3;
            this.BtGestionMedicament.Text = "Géré les médicaments";
            this.BtGestionMedicament.UseVisualStyleBackColor = true;
            this.BtGestionMedicament.Click += new System.EventHandler(this.BtGestionMedicament_Click);
            // 
            // BtDeconnexion
            // 
            this.BtDeconnexion.Location = new System.Drawing.Point(454, 462);
            this.BtDeconnexion.Name = "BtDeconnexion";
            this.BtDeconnexion.Size = new System.Drawing.Size(90, 20);
            this.BtDeconnexion.TabIndex = 4;
            this.BtDeconnexion.Text = "Déconnection";
            this.BtDeconnexion.UseVisualStyleBackColor = true;
            this.BtDeconnexion.Click += new System.EventHandler(this.BtDeconnexion_Click);
            // 
            // BtQuitter
            // 
            this.BtQuitter.Location = new System.Drawing.Point(550, 462);
            this.BtQuitter.Name = "BtQuitter";
            this.BtQuitter.Size = new System.Drawing.Size(90, 20);
            this.BtQuitter.TabIndex = 5;
            this.BtQuitter.Text = "Quitter";
            this.BtQuitter.UseVisualStyleBackColor = true;
            this.BtQuitter.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // TitreAcc
            // 
            this.TitreAcc.AutoSize = true;
            this.TitreAcc.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAcc.ForeColor = System.Drawing.Color.DarkBlue;
            this.TitreAcc.Location = new System.Drawing.Point(273, 9);
            this.TitreAcc.Name = "TitreAcc";
            this.TitreAcc.Size = new System.Drawing.Size(226, 31);
            this.TitreAcc.TabIndex = 6;
            this.TitreAcc.Text = "Lycée St Vincent";
            // 
            // LabelAnnee
            // 
            this.LabelAnnee.AutoSize = true;
            this.LabelAnnee.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAnnee.Location = new System.Drawing.Point(25, 9);
            this.LabelAnnee.Name = "LabelAnnee";
            this.LabelAnnee.Size = new System.Drawing.Size(215, 17);
            this.LabelAnnee.TabIndex = 7;
            this.LabelAnnee.Text = "Synthese de l\'année: xxxx/xxxx";
            // 
            // CalendrierDebut
            // 
            this.CalendrierDebut.Location = new System.Drawing.Point(28, 67);
            this.CalendrierDebut.Name = "CalendrierDebut";
            this.CalendrierDebut.Size = new System.Drawing.Size(200, 20);
            this.CalendrierDebut.TabIndex = 8;
            // 
            // CalendrierFin
            // 
            this.CalendrierFin.Location = new System.Drawing.Point(28, 93);
            this.CalendrierFin.Name = "CalendrierFin";
            this.CalendrierFin.Size = new System.Drawing.Size(200, 20);
            this.CalendrierFin.TabIndex = 9;
            // 
            // LabelDataDebut
            // 
            this.LabelDataDebut.AutoSize = true;
            this.LabelDataDebut.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDataDebut.Location = new System.Drawing.Point(234, 69);
            this.LabelDataDebut.Name = "LabelDataDebut";
            this.LabelDataDebut.Size = new System.Drawing.Size(104, 17);
            this.LabelDataDebut.TabIndex = 10;
            this.LabelDataDebut.Text = "Date de début";
            // 
            // LabelDataFin
            // 
            this.LabelDataFin.AutoSize = true;
            this.LabelDataFin.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDataFin.Location = new System.Drawing.Point(234, 93);
            this.LabelDataFin.Name = "LabelDataFin";
            this.LabelDataFin.Size = new System.Drawing.Size(85, 17);
            this.LabelDataFin.TabIndex = 11;
            this.LabelDataFin.Text = "Date de fin";
            // 
            // BtFiltreAcc
            // 
            this.BtFiltreAcc.Location = new System.Drawing.Point(85, 119);
            this.BtFiltreAcc.Name = "BtFiltreAcc";
            this.BtFiltreAcc.Size = new System.Drawing.Size(75, 24);
            this.BtFiltreAcc.TabIndex = 12;
            this.BtFiltreAcc.Text = "Appliquer";
            this.BtFiltreAcc.UseVisualStyleBackColor = true;
            this.BtFiltreAcc.Click += new System.EventHandler(this.BtFiltreAcc_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 494);
            this.Controls.Add(this.BtFiltreAcc);
            this.Controls.Add(this.LabelDataFin);
            this.Controls.Add(this.LabelDataDebut);
            this.Controls.Add(this.CalendrierFin);
            this.Controls.Add(this.CalendrierDebut);
            this.Controls.Add(this.LabelAnnee);
            this.Controls.Add(this.TitreAcc);
            this.Controls.Add(this.BtQuitter);
            this.Controls.Add(this.BtDeconnexion);
            this.Controls.Add(this.BtGestionMedicament);
            this.Controls.Add(this.BtGestionVisite);
            this.Controls.Add(this.BtGestionEleve);
            this.Controls.Add(this.DataViewAcc);
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataViewAcc;
        private System.Windows.Forms.Button BtGestionEleve;
        private System.Windows.Forms.Button BtGestionVisite;
        private System.Windows.Forms.Button BtGestionMedicament;
        private System.Windows.Forms.Button BtDeconnexion;
        private System.Windows.Forms.Button BtQuitter;
        private System.Windows.Forms.Label TitreAcc;
        private System.Windows.Forms.Label LabelAnnee;
        private System.Windows.Forms.DateTimePicker CalendrierDebut;
        private System.Windows.Forms.DateTimePicker CalendrierFin;
        private System.Windows.Forms.Label LabelDataDebut;
        private System.Windows.Forms.Label LabelDataFin;
        private System.Windows.Forms.Button BtFiltreAcc;
    }
}