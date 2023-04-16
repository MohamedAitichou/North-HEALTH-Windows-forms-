namespace NorthHealthFormApp
{
    partial class AccueilForm
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
            generateInvoiceButton = new Button();
            addElementMenu = new Button();
            planningInterventionMenu = new Button();
            groupBox2 = new GroupBox();
            adminName = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(generateInvoiceButton);
            groupBox1.Controls.Add(addElementMenu);
            groupBox1.Controls.Add(planningInterventionMenu);
            groupBox1.Location = new Point(31, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu de navigation";
            // 
            // generateInvoiceButton
            // 
            generateInvoiceButton.Font = new Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            generateInvoiceButton.Location = new Point(16, 105);
            generateInvoiceButton.Name = "generateInvoiceButton";
            generateInvoiceButton.Size = new Size(332, 28);
            generateInvoiceButton.TabIndex = 4;
            generateInvoiceButton.Text = "Générer un compte rendu";
            generateInvoiceButton.UseVisualStyleBackColor = true;
            generateInvoiceButton.Click += generateInvoiceButton_Click;
            // 
            // addElementMenu
            // 
            addElementMenu.Font = new Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addElementMenu.Location = new Point(16, 71);
            addElementMenu.Name = "addElementMenu";
            addElementMenu.Size = new Size(332, 28);
            addElementMenu.TabIndex = 3;
            addElementMenu.Text = " Ajouter des éléments dans un dossier";
            addElementMenu.UseVisualStyleBackColor = true;
            addElementMenu.Click += addElements;
            // 
            // planningInterventionMenu
            // 
            planningInterventionMenu.Font = new Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            planningInterventionMenu.Location = new Point(16, 37);
            planningInterventionMenu.Name = "planningInterventionMenu";
            planningInterventionMenu.Size = new Size(332, 28);
            planningInterventionMenu.TabIndex = 2;
            planningInterventionMenu.Text = "Planning Intervention";
            planningInterventionMenu.UseVisualStyleBackColor = true;
            planningInterventionMenu.Click += planningInterventionMenu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(adminName);
            groupBox2.Location = new Point(404, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 45);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vous êtes";
            // 
            // adminName
            // 
            adminName.AutoSize = true;
            adminName.Location = new Point(6, 19);
            adminName.Name = "adminName";
            adminName.Size = new Size(0, 15);
            adminName.TabIndex = 0;
            // 
            // AccueilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AccueilForm";
            Text = "North Health menu de navigation";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button generateInvoiceButton;
        private Button addElementMenu;
        private Button planningInterventionMenu;
        private GroupBox groupBox2;
        private Label adminName;
    }
}