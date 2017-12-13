namespace GUI
{
    partial class GestionEleve
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
            this.DataViewClassGestionEleve_Frm = new System.Windows.Forms.DataGridView();
            this.DataViewEleveGestionEleve_Frm = new System.Windows.Forms.DataGridView();
            this.LabelGestionEleve = new System.Windows.Forms.Label();
            this.BoxClassGestionEleve_Frm = new System.Windows.Forms.ComboBox();
            this.BtAjoutEleve = new System.Windows.Forms.Button();
            this.BtModifEleve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtSupprimerEleve = new System.Windows.Forms.Button();
            this.LabelNomEleve = new System.Windows.Forms.Label();
            this.BtRetourGesionEleve = new System.Windows.Forms.Button();
            this.BtDeconnectionGestionEleve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewClassGestionEleve_Frm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewEleveGestionEleve_Frm)).BeginInit();
            this.SuspendLayout();
            // 
            // DataViewClassGestionEleve_Frm
            // 
            this.DataViewClassGestionEleve_Frm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewClassGestionEleve_Frm.Location = new System.Drawing.Point(12, 29);
            this.DataViewClassGestionEleve_Frm.Name = "DataViewClassGestionEleve_Frm";
            this.DataViewClassGestionEleve_Frm.Size = new System.Drawing.Size(240, 236);
            this.DataViewClassGestionEleve_Frm.TabIndex = 0;
            this.DataViewClassGestionEleve_Frm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewClassGestionEleve_Frm_CellClick);
            // 
            // DataViewEleveGestionEleve_Frm
            // 
            this.DataViewEleveGestionEleve_Frm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewEleveGestionEleve_Frm.Location = new System.Drawing.Point(309, 77);
            this.DataViewEleveGestionEleve_Frm.Name = "DataViewEleveGestionEleve_Frm";
            this.DataViewEleveGestionEleve_Frm.Size = new System.Drawing.Size(438, 188);
            this.DataViewEleveGestionEleve_Frm.TabIndex = 1;
            this.DataViewEleveGestionEleve_Frm.Visible = false;
            // 
            // LabelGestionEleve
            // 
            this.LabelGestionEleve.AutoSize = true;
            this.LabelGestionEleve.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGestionEleve.Location = new System.Drawing.Point(59, 9);
            this.LabelGestionEleve.Name = "LabelGestionEleve";
            this.LabelGestionEleve.Size = new System.Drawing.Size(141, 17);
            this.LabelGestionEleve.TabIndex = 2;
            this.LabelGestionEleve.Text = "Cliquer sur un élève";
            // 
            // BoxClassGestionEleve_Frm
            // 
            this.BoxClassGestionEleve_Frm.FormattingEnabled = true;
            this.BoxClassGestionEleve_Frm.Location = new System.Drawing.Point(62, 271);
            this.BoxClassGestionEleve_Frm.Name = "BoxClassGestionEleve_Frm";
            this.BoxClassGestionEleve_Frm.Size = new System.Drawing.Size(138, 21);
            this.BoxClassGestionEleve_Frm.TabIndex = 3;
            this.BoxClassGestionEleve_Frm.SelectedValueChanged += new System.EventHandler(this.BoxClassGestionEleve_Frm_SelectedValueChanged);
            // 
            // BtAjoutEleve
            // 
            this.BtAjoutEleve.Location = new System.Drawing.Point(12, 298);
            this.BtAjoutEleve.Name = "BtAjoutEleve";
            this.BtAjoutEleve.Size = new System.Drawing.Size(240, 35);
            this.BtAjoutEleve.TabIndex = 4;
            this.BtAjoutEleve.Text = "Ajouter un élève";
            this.BtAjoutEleve.UseVisualStyleBackColor = true;
            this.BtAjoutEleve.Click += new System.EventHandler(this.BtAjoutEleve_Click);
            // 
            // BtModifEleve
            // 
            this.BtModifEleve.Location = new System.Drawing.Point(309, 271);
            this.BtModifEleve.Name = "BtModifEleve";
            this.BtModifEleve.Size = new System.Drawing.Size(142, 35);
            this.BtModifEleve.TabIndex = 5;
            this.BtModifEleve.Text = "Modifier l\'élève";
            this.BtModifEleve.UseVisualStyleBackColor = true;
            this.BtModifEleve.Visible = false;
            this.BtModifEleve.Click += new System.EventHandler(this.BtModifEleve_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Archivé l\'élève";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // BtSupprimerEleve
            // 
            this.BtSupprimerEleve.Location = new System.Drawing.Point(457, 271);
            this.BtSupprimerEleve.Name = "BtSupprimerEleve";
            this.BtSupprimerEleve.Size = new System.Drawing.Size(142, 35);
            this.BtSupprimerEleve.TabIndex = 7;
            this.BtSupprimerEleve.Text = "Supprimer l\'élève";
            this.BtSupprimerEleve.UseVisualStyleBackColor = true;
            this.BtSupprimerEleve.Visible = false;
            this.BtSupprimerEleve.Click += new System.EventHandler(this.BtSupprimerEleve_Click);
            // 
            // LabelNomEleve
            // 
            this.LabelNomEleve.AutoSize = true;
            this.LabelNomEleve.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomEleve.Location = new System.Drawing.Point(423, 29);
            this.LabelNomEleve.Name = "LabelNomEleve";
            this.LabelNomEleve.Size = new System.Drawing.Size(183, 21);
            this.LabelNomEleve.TabIndex = 8;
            this.LabelNomEleve.Text = "Selectionné un élève";
            // 
            // BtRetourGesionEleve
            // 
            this.BtRetourGesionEleve.Location = new System.Drawing.Point(581, 314);
            this.BtRetourGesionEleve.Name = "BtRetourGesionEleve";
            this.BtRetourGesionEleve.Size = new System.Drawing.Size(85, 19);
            this.BtRetourGesionEleve.TabIndex = 9;
            this.BtRetourGesionEleve.Text = "Retour";
            this.BtRetourGesionEleve.UseVisualStyleBackColor = true;
            this.BtRetourGesionEleve.Click += new System.EventHandler(this.BtRetourGesionEleve_Click);
            // 
            // BtDeconnectionGestionEleve
            // 
            this.BtDeconnectionGestionEleve.Location = new System.Drawing.Point(672, 314);
            this.BtDeconnectionGestionEleve.Name = "BtDeconnectionGestionEleve";
            this.BtDeconnectionGestionEleve.Size = new System.Drawing.Size(85, 19);
            this.BtDeconnectionGestionEleve.TabIndex = 10;
            this.BtDeconnectionGestionEleve.Text = "Déconnection";
            this.BtDeconnectionGestionEleve.UseVisualStyleBackColor = true;
            this.BtDeconnectionGestionEleve.Click += new System.EventHandler(this.BtDeconnectionGestionEleve_Click);
            // 
            // GestionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 340);
            this.Controls.Add(this.BtDeconnectionGestionEleve);
            this.Controls.Add(this.BtRetourGesionEleve);
            this.Controls.Add(this.LabelNomEleve);
            this.Controls.Add(this.BtSupprimerEleve);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtModifEleve);
            this.Controls.Add(this.BtAjoutEleve);
            this.Controls.Add(this.BoxClassGestionEleve_Frm);
            this.Controls.Add(this.LabelGestionEleve);
            this.Controls.Add(this.DataViewEleveGestionEleve_Frm);
            this.Controls.Add(this.DataViewClassGestionEleve_Frm);
            this.Name = "GestionEleve";
            this.Text = "GestionEleve_Frm";
            this.Load += new System.EventHandler(this.GestionEleve_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewClassGestionEleve_Frm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewEleveGestionEleve_Frm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataViewClassGestionEleve_Frm;
        private System.Windows.Forms.DataGridView DataViewEleveGestionEleve_Frm;
        private System.Windows.Forms.Label LabelGestionEleve;
        private System.Windows.Forms.ComboBox BoxClassGestionEleve_Frm;
        private System.Windows.Forms.Button BtAjoutEleve;
        private System.Windows.Forms.Button BtModifEleve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtSupprimerEleve;
        private System.Windows.Forms.Label LabelNomEleve;
        private System.Windows.Forms.Button BtRetourGesionEleve;
        private System.Windows.Forms.Button BtDeconnectionGestionEleve;
    }
}