namespace GUI
{
    partial class GestionMedicament
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterMedicament = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libelleMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatMedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet = new GUI.gestion_infirmerieDataSet();
            this.medicamentTableAdapter = new GUI.gestion_infirmerieDataSetTableAdapters.MedicamentTableAdapter();
            this.GestionMedicReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Medicament";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAjouterMedicament
            // 
            this.btnAjouterMedicament.Location = new System.Drawing.Point(57, 247);
            this.btnAjouterMedicament.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterMedicament.Name = "btnAjouterMedicament";
            this.btnAjouterMedicament.Size = new System.Drawing.Size(100, 28);
            this.btnAjouterMedicament.TabIndex = 1;
            this.btnAjouterMedicament.Text = "Ajouter";
            this.btnAjouterMedicament.UseVisualStyleBackColor = true;
            this.btnAjouterMedicament.Click += new System.EventHandler(this.btnAjouterMedicament_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_ModifierMedic_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 247);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_SupprimerMedic_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libelleMedDataGridViewTextBoxColumn,
            this.etatMedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.medicamentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // libelleMedDataGridViewTextBoxColumn
            // 
            this.libelleMedDataGridViewTextBoxColumn.DataPropertyName = "Libelle_Med";
            this.libelleMedDataGridViewTextBoxColumn.HeaderText = "Nom du Médicament :";
            this.libelleMedDataGridViewTextBoxColumn.Name = "libelleMedDataGridViewTextBoxColumn";
            // 
            // etatMedDataGridViewCheckBoxColumn
            // 
            this.etatMedDataGridViewCheckBoxColumn.DataPropertyName = "Etat_Med";
            this.etatMedDataGridViewCheckBoxColumn.HeaderText = "Archivé :";
            this.etatMedDataGridViewCheckBoxColumn.Name = "etatMedDataGridViewCheckBoxColumn";
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "Medicament";
            this.medicamentBindingSource.DataSource = this.gestion_infirmerieDataSet;
            // 
            // gestion_infirmerieDataSet
            // 
            this.gestion_infirmerieDataSet.DataSetName = "gestion_infirmerieDataSet";
            this.gestion_infirmerieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // GestionMedicReturn
            // 
            this.GestionMedicReturn.Location = new System.Drawing.Point(420, 313);
            this.GestionMedicReturn.Name = "GestionMedicReturn";
            this.GestionMedicReturn.Size = new System.Drawing.Size(100, 23);
            this.GestionMedicReturn.TabIndex = 5;
            this.GestionMedicReturn.Text = "Retour";
            this.GestionMedicReturn.UseVisualStyleBackColor = true;
            this.GestionMedicReturn.Click += new System.EventHandler(this.btn_RetourGestMedic_Click);
            // 
            // GestionMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 348);
            this.Controls.Add(this.GestionMedicReturn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjouterMedicament);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionMedicament";
            this.Text = "GestionMedicament";
            this.Load += new System.EventHandler(this.GestionMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterMedicament;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gestion_infirmerieDataSet gestion_infirmerieDataSet;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private gestion_infirmerieDataSetTableAdapters.MedicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn etatMedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button GestionMedicReturn;
    }
}