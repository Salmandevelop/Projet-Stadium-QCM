namespace GestionQuestionnaire.Views
{
    partial class FormGererQCM
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
            this.dgvQCM = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQCM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQCM
            // 
            this.dgvQCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQCM.Location = new System.Drawing.Point(234, 62);
            this.dgvQCM.Name = "dgvQCM";
            this.dgvQCM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQCM.Size = new System.Drawing.Size(240, 150);
            this.dgvQCM.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(285, 255);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(143, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer QCM";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FormGererQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dgvQCM);
            this.Name = "FormGererQCM";
            this.Text = "FormGererQCM";
            this.Load += new System.EventHandler(this.FormGererQCM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQCM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQCM;
        private System.Windows.Forms.Button btnSupprimer;
    }
}