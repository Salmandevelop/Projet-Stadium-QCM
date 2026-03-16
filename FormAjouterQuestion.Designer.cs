namespace GestionQuestionnaire.Views
{
    partial class FormAjouterQuestion
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
            this.btnAjouterQuestion = new System.Windows.Forms.Button();
            this.txtIntituleQuestion = new System.Windows.Forms.MaskedTextBox();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.rbVrai = new System.Windows.Forms.RadioButton();
            this.rbFaux = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajoutez Votre Question";
            // 
            // btnAjouterQuestion
            // 
            this.btnAjouterQuestion.Location = new System.Drawing.Point(320, 223);
            this.btnAjouterQuestion.Name = "btnAjouterQuestion";
            this.btnAjouterQuestion.Size = new System.Drawing.Size(144, 23);
            this.btnAjouterQuestion.TabIndex = 1;
            this.btnAjouterQuestion.Text = "Ajouter la question";
            this.btnAjouterQuestion.UseVisualStyleBackColor = true;
            this.btnAjouterQuestion.Click += new System.EventHandler(this.btnAjouterQuestion_Click);
            // 
            // txtIntituleQuestion
            // 
            this.txtIntituleQuestion.Location = new System.Drawing.Point(172, 138);
            this.txtIntituleQuestion.Name = "txtIntituleQuestion";
            this.txtIntituleQuestion.Size = new System.Drawing.Size(420, 20);
            this.txtIntituleQuestion.TabIndex = 2;
            // 
            // btnTerminer
            // 
            this.btnTerminer.Location = new System.Drawing.Point(334, 274);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(119, 44);
            this.btnTerminer.TabIndex = 3;
            this.btnTerminer.Text = "Terminer";
            this.btnTerminer.UseVisualStyleBackColor = true;
            this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);
            // 
            // rbVrai
            // 
            this.rbVrai.AutoSize = true;
            this.rbVrai.Location = new System.Drawing.Point(320, 171);
            this.rbVrai.Name = "rbVrai";
            this.rbVrai.Size = new System.Drawing.Size(43, 17);
            this.rbVrai.TabIndex = 4;
            this.rbVrai.TabStop = true;
            this.rbVrai.Text = "Vrai";
            this.rbVrai.UseVisualStyleBackColor = true;
            // 
            // rbFaux
            // 
            this.rbFaux.AutoSize = true;
            this.rbFaux.Location = new System.Drawing.Point(416, 171);
            this.rbFaux.Name = "rbFaux";
            this.rbFaux.Size = new System.Drawing.Size(48, 17);
            this.rbFaux.TabIndex = 5;
            this.rbFaux.Text = "Faux";
            this.rbFaux.UseVisualStyleBackColor = true;
            // 
            // FormAjouterQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbFaux);
            this.Controls.Add(this.rbVrai);
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.txtIntituleQuestion);
            this.Controls.Add(this.btnAjouterQuestion);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouterQuestion";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterQuestion;
        private System.Windows.Forms.MaskedTextBox txtIntituleQuestion;
        private System.Windows.Forms.Button btnTerminer;
        private System.Windows.Forms.RadioButton rbVrai;
        private System.Windows.Forms.RadioButton rbFaux;
    }
}