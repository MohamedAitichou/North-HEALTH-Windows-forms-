namespace NorthHealthFormApp
{
    partial class PlanningForm
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
            gridBoxPlanning = new GroupBox();
            dossiersGridView = new DataGridView();
            gridBoxPlanning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dossiersGridView).BeginInit();
            SuspendLayout();
            // 
            // gridBoxPlanning
            // 
            gridBoxPlanning.Controls.Add(dossiersGridView);
            gridBoxPlanning.Location = new Point(12, 12);
            gridBoxPlanning.Name = "gridBoxPlanning";
            gridBoxPlanning.Size = new Size(2072, 583);
            gridBoxPlanning.TabIndex = 0;
            gridBoxPlanning.TabStop = false;
            gridBoxPlanning.Text = "Planning d'interventions des patients";
            // 
            // dossiersGridView
            // 
            dossiersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dossiersGridView.Location = new Point(6, 20);
            dossiersGridView.Margin = new Padding(10);
            dossiersGridView.Name = "dossiersGridView";
            dossiersGridView.RowTemplate.Height = 25;
            dossiersGridView.Size = new Size(2066, 557);
            dossiersGridView.TabIndex = 0;
            // 
            // PlanningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2096, 607);
            Controls.Add(gridBoxPlanning);
            Name = "PlanningForm";
            Text = "North Health planning d'interventions";
            Load += PlanningForm_Load;
            gridBoxPlanning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dossiersGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gridBoxPlanning;
        private DataGridView dossiersGridView;
    }
}