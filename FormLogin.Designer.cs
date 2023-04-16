namespace NorthHealthFormApp
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginGroupBox = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            seConnecterButton = new Button();
            pwdBox = new TextBox();
            loginBox = new TextBox();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(label2);
            loginGroupBox.Controls.Add(label1);
            loginGroupBox.Controls.Add(seConnecterButton);
            loginGroupBox.Controls.Add(pwdBox);
            loginGroupBox.Controls.Add(loginBox);
            loginGroupBox.Location = new Point(168, 69);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(437, 246);
            loginGroupBox.TabIndex = 0;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "Se connecter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 99);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 4;
            label2.Text = "Mot de Passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 3;
            label1.Text = "Login ou Email";
            // 
            // seConnecterButton
            // 
            seConnecterButton.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            seConnecterButton.Location = new Point(115, 167);
            seConnecterButton.Name = "seConnecterButton";
            seConnecterButton.Size = new Size(195, 37);
            seConnecterButton.TabIndex = 2;
            seConnecterButton.Text = "Se connecter";
            seConnecterButton.TextImageRelation = TextImageRelation.ImageAboveText;
            seConnecterButton.UseVisualStyleBackColor = true;
            seConnecterButton.Click += seConnecterButton_Click;
            // 
            // pwdBox
            // 
            pwdBox.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pwdBox.Location = new Point(41, 123);
            pwdBox.Name = "pwdBox";
            pwdBox.Size = new Size(345, 29);
            pwdBox.TabIndex = 1;
            pwdBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(41, 65);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(345, 29);
            loginBox.TabIndex = 0;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginGroupBox);
            Name = "FormLogin";
            Text = "NorthHealth Application";
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox loginGroupBox;
        private Label label1;
        private Button seConnecterButton;
        private TextBox pwdBox;
        private TextBox loginBox;
        private Label label2;
    }
}