namespace NorthHealthFormApp
{
    partial class CompteRenduForm
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
            groupBox1 = new GroupBox();
            genererCompteRenduButton = new Button();
            dossierComboBox = new ComboBox();
            userComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(genererCompteRenduButton);
            groupBox1.Controls.Add(dossierComboBox);
            groupBox1.Controls.Add(userComboBox);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1392, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veuillez selectionner les informations pour la génération du compte rendu";
            // 
            // genererCompteRenduButton
            // 
            genererCompteRenduButton.Font = new Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            genererCompteRenduButton.Location = new Point(530, 70);
            genererCompteRenduButton.Name = "genererCompteRenduButton";
            genererCompteRenduButton.Size = new Size(332, 28);
            genererCompteRenduButton.TabIndex = 3;
            genererCompteRenduButton.Text = "Générer le compte rendu";
            genererCompteRenduButton.UseVisualStyleBackColor = true;
            genererCompteRenduButton.Visible = false;
            genererCompteRenduButton.Click += GenerateInvoiceButton;
            // 
            // dossierComboBox
            // 
            dossierComboBox.FormattingEnabled = true;
            dossierComboBox.Location = new Point(727, 29);
            dossierComboBox.Name = "dossierComboBox";
            dossierComboBox.Size = new Size(625, 23);
            dossierComboBox.TabIndex = 1;
            dossierComboBox.Visible = false;
            dossierComboBox.SelectedIndexChanged += ShowButton;
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(34, 29);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(625, 23);
            userComboBox.TabIndex = 0;
            userComboBox.SelectedIndexChanged += userSleected;
            // 
            // CompteRenduForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 671);
            Controls.Add(groupBox1);
            Name = "CompteRenduForm";
            Text = "North Health Générer un compte rendu";
            Load += CompteRenduForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox dossierComboBox;
        private ComboBox userComboBox;
        private Button genererCompteRenduButton;
    }
}