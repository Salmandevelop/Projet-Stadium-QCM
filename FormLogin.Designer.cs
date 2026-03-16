namespace GestionQuestionnaire.Views
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnhassh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(330, 114);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 2;
            this.txtIdentifiant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(330, 183);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '$';
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(345, 236);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnhassh
            // 
            this.btnhassh.Location = new System.Drawing.Point(562, 236);
            this.btnhassh.Name = "btnhassh";
            this.btnhassh.Size = new System.Drawing.Size(101, 23);
            this.btnhassh.TabIndex = 5;
            this.btnhassh.Text = "Vérifier Hash";
            this.btnhassh.UseVisualStyleBackColor = true;
            this.btnhassh.Click += new System.EventHandler(this.btnhassh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnhassh);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnhassh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}