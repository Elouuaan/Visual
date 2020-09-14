namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaise = new System.Windows.Forms.Label();
            this.lblCopie = new System.Windows.Forms.Label();
            this.tbxSaisie = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblResuét = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaise
            // 
            this.lblSaise.AutoSize = true;
            this.lblSaise.Location = new System.Drawing.Point(10, 27);
            this.lblSaise.Name = "lblSaise";
            this.lblSaise.Size = new System.Drawing.Size(41, 13);
            this.lblSaise.TabIndex = 0;
            this.lblSaise.Text = "Saisie :";
            // 
            // lblCopie
            // 
            this.lblCopie.AutoSize = true;
            this.lblCopie.Location = new System.Drawing.Point(10, 71);
            this.lblCopie.Name = "lblCopie";
            this.lblCopie.Size = new System.Drawing.Size(40, 13);
            this.lblCopie.TabIndex = 1;
            this.lblCopie.Text = "Copie :";
            // 
            // tbxSaisie
            // 
            this.tbxSaisie.Location = new System.Drawing.Point(104, 24);
            this.tbxSaisie.Name = "tbxSaisie";
            this.tbxSaisie.Size = new System.Drawing.Size(285, 20);
            this.tbxSaisie.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(302, 127);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(87, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // lblResuét
            // 
            this.lblResuét.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResuét.Location = new System.Drawing.Point(104, 70);
            this.lblResuét.Name = "lblResuét";
            this.lblResuét.Size = new System.Drawing.Size(285, 23);
            this.lblResuét.TabIndex = 6;
            this.lblResuét.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 162);
            this.Controls.Add(this.lblResuét);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxSaisie);
            this.Controls.Add(this.lblCopie);
            this.Controls.Add(this.lblSaise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaise;
        private System.Windows.Forms.Label lblCopie;
        private System.Windows.Forms.TextBox tbxSaisie;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblResuét;
    }
}

