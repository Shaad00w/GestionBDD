namespace Gestion_de_base_de_donnees
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreation = new System.Windows.Forms.Button();
            this.txtbxDBName = new System.Windows.Forms.TextBox();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(311, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 48);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(12, 12);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(140, 48);
            this.btnCreation.TabIndex = 1;
            this.btnCreation.Text = "Créez votre DB";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.BtnCreation_Click);
            // 
            // txtbxDBName
            // 
            this.txtbxDBName.Location = new System.Drawing.Point(251, 39);
            this.txtbxDBName.Name = "txtbxDBName";
            this.txtbxDBName.Size = new System.Drawing.Size(100, 20);
            this.txtbxDBName.TabIndex = 2;
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(12, 89);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(140, 47);
            this.btnDeleteDB.TabIndex = 3;
            this.btnDeleteDB.Text = "Supprimez votre DB";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.BtnDeleteDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.txtbxDBName);
            this.Controls.Add(this.btnCreation);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Gestion de base de données";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.TextBox txtbxDBName;
        private System.Windows.Forms.Button btnDeleteDB;
    }
}

