namespace GUI
{
    partial class AjoutMedic
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
            this.btnRetourAjout = new System.Windows.Forms.Button();
            this.btnValidationAjoutMedic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomMedicAjout = new System.Windows.Forms.TextBox();
            this.errorProviderNomMedicament = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourAjout
            // 
            this.btnRetourAjout.Location = new System.Drawing.Point(12, 163);
            this.btnRetourAjout.Name = "btnRetourAjout";
            this.btnRetourAjout.Size = new System.Drawing.Size(118, 30);
            this.btnRetourAjout.TabIndex = 0;
            this.btnRetourAjout.Text = "Retour";
            this.btnRetourAjout.UseVisualStyleBackColor = true;
            this.btnRetourAjout.Click += new System.EventHandler(this.btnRetourAjout_Click);
            // 
            // btnValidationAjoutMedic
            // 
            this.btnValidationAjoutMedic.Location = new System.Drawing.Point(166, 163);
            this.btnValidationAjoutMedic.Name = "btnValidationAjoutMedic";
            this.btnValidationAjoutMedic.Size = new System.Drawing.Size(110, 26);
            this.btnValidationAjoutMedic.TabIndex = 1;
            this.btnValidationAjoutMedic.Text = "Ajouter";
            this.btnValidationAjoutMedic.UseVisualStyleBackColor = true;
            this.btnValidationAjoutMedic.Click += new System.EventHandler(this.btnValidationAjoutMedic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ajout d\'un médicament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom du médicament :";
            // 
            // textBoxNomMedicAjout
            // 
            this.textBoxNomMedicAjout.Location = new System.Drawing.Point(139, 88);
            this.textBoxNomMedicAjout.Name = "textBoxNomMedicAjout";
            this.textBoxNomMedicAjout.Size = new System.Drawing.Size(137, 20);
            this.textBoxNomMedicAjout.TabIndex = 4;
            // 
            // errorProviderNomMedicament
            // 
            this.errorProviderNomMedicament.ContainerControl = this;
            // 
            // AjoutMedic
            // 
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.textBoxNomMedicAjout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidationAjoutMedic);
            this.Controls.Add(this.btnRetourAjout);
            this.Name = "AjoutMedic";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomAjoutMedic;
        private System.Windows.Forms.Button btnRetourMenuMedic;
        private System.Windows.Forms.Button BtnAjoutMedic;
        private System.Windows.Forms.Button btnRetourAjout;
        private System.Windows.Forms.Button btnValidationAjoutMedic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomMedicAjout;
        private System.Windows.Forms.ErrorProvider errorProviderNomMedicament;
    }
}