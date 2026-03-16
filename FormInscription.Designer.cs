namespace GestionQuestionnaire.Views
{
    partial class FormInscription
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.seconnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(322, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(322, 82);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant";
            this.lblIdentifiant.Click += new System.EventHandler(this.txtIdentifiant_Click);
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(318, 205);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(74, 13);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "Mot de passe ";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(317, 272);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(317, 107);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(317, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(317, 234);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 6;
            // 
            // seconnecter
            // 
            this.seconnecter.Location = new System.Drawing.Point(286, 323);
            this.seconnecter.Name = "seconnecter";
            this.seconnecter.Size = new System.Drawing.Size(144, 23);
            this.seconnecter.TabIndex = 7;
            this.seconnecter.Text = "Se connecter";
            this.seconnecter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.seconnecter.UseVisualStyleBackColor = true;
            this.seconnecter.Click += new System.EventHandler(this.seconnecter_Click);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.seconnecter);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblEmail);
            this.Name = "FormInscription";
            this.Text = "FormInscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button seconnecter;
    }
}