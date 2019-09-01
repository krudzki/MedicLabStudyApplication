namespace MedicLabStudyApplication
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameLabel.Name = "userNameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // userNameTxtBox
            // 
            resources.ApplyResources(this.userNameTxtBox, "userNameTxtBox");
            this.userNameTxtBox.Name = "userNameTxtBox";
            // 
            // passwordTxtBox
            // 
            resources.ApplyResources(this.passwordTxtBox, "passwordTxtBox");
            this.passwordTxtBox.Name = "passwordTxtBox";
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // buttonCreate
            // 
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button buttonCreate;
    }
}

