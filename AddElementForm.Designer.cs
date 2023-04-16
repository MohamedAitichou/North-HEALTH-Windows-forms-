namespace NorthHealthFormApp
{
    partial class AddElementForm
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
            dossiersMedicauxGridView = new DataGridView();
            add = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dossiersMedicauxGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dossiersMedicauxGridView);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1524, 611);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dossiers médicaux";
            // 
            // dossiersMedicauxGridView
            // 
            dossiersMedicauxGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dossiersMedicauxGridView.Columns.AddRange(new DataGridViewColumn[] { add });
            dossiersMedicauxGridView.Location = new Point(6, 22);
            dossiersMedicauxGridView.Name = "dossiersMedicauxGridView";
            dossiersMedicauxGridView.RowTemplate.Height = 25;
            dossiersMedicauxGridView.Size = new Size(1512, 583);
            dossiersMedicauxGridView.TabIndex = 0;
            dossiersMedicauxGridView.CellContentClick += dossiersMedicauxGridView_CellContentClick;
            // 
            // add
            // 
            add.HeaderText = "#";
            add.Name = "add";
            add.Text = "Ajouter";
            add.ToolTipText = "Ajouter";
            add.UseColumnTextForButtonValue = true;
            // 
            // AddElementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 631);
            Controls.Add(groupBox1);
            Name = "AddElementForm";
            Text = "AddElementForm";
            Load += AddElementForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dossiersMedicauxGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dossiersMedicauxGridView;
        private Button button1;
        private DataGridViewButtonColumn add;
    }
}