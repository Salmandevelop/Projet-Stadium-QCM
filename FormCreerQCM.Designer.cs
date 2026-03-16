namespace GestionQuestionnaire.Views
{
    partial class FormCreerQCM
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
            this.txtNomTheme = new System.Windows.Forms.TextBox();
            this.txtNomQuestionnaire = new System.Windows.Forms.TextBox();
            this.btnValiderQCM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbQuestion = new System.Windows.Forms.TextBox();
            this.btnGererQCM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomTheme
            // 
            this.txtNomTheme.Location = new System.Drawing.Point(307, 83);
            this.txtNomTheme.Name = "txtNomTheme";
            this.txtNomTheme.Size = new System.Drawing.Size(100, 20);
            this.txtNomTheme.TabIndex = 0;
            // 
            // txtNomQuestionnaire
            // 
            this.txtNomQuestionnaire.Location = new System.Drawing.Point(307, 167);
            this.txtNomQuestionnaire.Name = "txtNomQuestionnaire";
            this.txtNomQuestionnaire.Size = new System.Drawing.Size(100, 20);
            this.txtNomQuestionnaire.TabIndex = 1;
            this.txtNomQuestionnaire.TextChanged += new System.EventHandler(this.txtNomQuestionnaire_TextChanged);
            // 
            // btnValiderQCM
            // 
            this.btnValiderQCM.Location = new System.Drawing.Point(307, 284);
            this.btnValiderQCM.Name = "btnValiderQCM";
            this.btnValiderQCM.Size = new System.Drawing.Size(75, 23);
            this.btnValiderQCM.TabIndex = 2;
            this.btnValiderQCM.Text = "Valider QCM";
            this.btnValiderQCM.UseVisualStyleBackColor = true;
            this.btnValiderQCM.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Theme";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom Questionnaire";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de question";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNbQuestion
            // 
            this.txtNbQuestion.Location = new System.Drawing.Point(307, 237);
            this.txtNbQuestion.Name = "txtNbQuestion";
            this.txtNbQuestion.Size = new System.Drawing.Size(100, 20);
            this.txtNbQuestion.TabIndex = 5;
            this.txtNbQuestion.TextChanged += new System.EventHandler(this.txtNbQuestion_TextChanged);
            // 
            // btnGererQCM
            // 
            this.btnGererQCM.Location = new System.Drawing.Point(286, 335);
            this.btnGererQCM.Name = "btnGererQCM";
            this.btnGererQCM.Size = new System.Drawing.Size(137, 23);
            this.btnGererQCM.TabIndex = 7;
            this.btnGererQCM.Text = "Voir les QCM";
            this.btnGererQCM.UseVisualStyleBackColor = true;
            this.btnGererQCM.Click += new System.EventHandler(this.btnGererQCM_Click);
            // 
            // FormCreerQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGererQCM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNbQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValiderQCM);
            this.Controls.Add(this.txtNomQuestionnaire);
            this.Controls.Add(this.txtNomTheme);
            this.Name = "FormCreerQCM";
            this.Text = "FormCreerQCM";
            this.Load += new System.EventHandler(this.FormCreerQCM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomTheme;
        private System.Windows.Forms.TextBox txtNomQuestionnaire;
        private System.Windows.Forms.Button btnValiderQCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNbQuestion;
        private System.Windows.Forms.Button btnGererQCM;
    }
}