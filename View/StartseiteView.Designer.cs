namespace Praktiku.View
{
    partial class StartseiteView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTeilnehmerForm = new System.Windows.Forms.Button();
            this.btnFirmenForm = new System.Windows.Forms.Button();
            this.btnProfilForm = new System.Windows.Forms.Button();
            this.btnBewerbungForm = new System.Windows.Forms.Button();
            this.lblStartseite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTeilnehmerForm
            // 
            this.btnTeilnehmerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeilnehmerForm.Location = new System.Drawing.Point(171, 221);
            this.btnTeilnehmerForm.Name = "btnTeilnehmerForm";
            this.btnTeilnehmerForm.Size = new System.Drawing.Size(126, 61);
            this.btnTeilnehmerForm.TabIndex = 0;
            this.btnTeilnehmerForm.Text = "Teilnehmer";
            this.btnTeilnehmerForm.UseVisualStyleBackColor = true;
            this.btnTeilnehmerForm.Click += new System.EventHandler(this.btnTeilnehmerForm_Click);
            // 
            // btnFirmenForm
            // 
            this.btnFirmenForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmenForm.Location = new System.Drawing.Point(334, 221);
            this.btnFirmenForm.Name = "btnFirmenForm";
            this.btnFirmenForm.Size = new System.Drawing.Size(126, 61);
            this.btnFirmenForm.TabIndex = 1;
            this.btnFirmenForm.Text = "Firmen";
            this.btnFirmenForm.UseVisualStyleBackColor = true;
            this.btnFirmenForm.Click += new System.EventHandler(this.btnFirmenForm_Click);
            // 
            // btnProfilForm
            // 
            this.btnProfilForm.Location = new System.Drawing.Point(701, 24);
            this.btnProfilForm.Name = "btnProfilForm";
            this.btnProfilForm.Size = new System.Drawing.Size(126, 61);
            this.btnProfilForm.TabIndex = 3;
            this.btnProfilForm.Text = "Profil";
            this.btnProfilForm.UseVisualStyleBackColor = true;
            this.btnProfilForm.Click += new System.EventHandler(this.btnProfilForm_Click);
            // 
            // btnBewerbungForm
            // 
            this.btnBewerbungForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewerbungForm.Location = new System.Drawing.Point(497, 221);
            this.btnBewerbungForm.Name = "btnBewerbungForm";
            this.btnBewerbungForm.Size = new System.Drawing.Size(126, 61);
            this.btnBewerbungForm.TabIndex = 4;
            this.btnBewerbungForm.Text = "Bewerbung";
            this.btnBewerbungForm.UseVisualStyleBackColor = true;
            this.btnBewerbungForm.Click += new System.EventHandler(this.btnBewerbungForm_Click);
            // 
            // lblStartseite
            // 
            this.lblStartseite.AutoSize = true;
            this.lblStartseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartseite.Location = new System.Drawing.Point(271, 83);
            this.lblStartseite.Name = "lblStartseite";
            this.lblStartseite.Size = new System.Drawing.Size(284, 69);
            this.lblStartseite.TabIndex = 5;
            this.lblStartseite.Text = "Startseite";
            // 
            // StartseiteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 519);
            this.Controls.Add(this.lblStartseite);
            this.Controls.Add(this.btnBewerbungForm);
            this.Controls.Add(this.btnProfilForm);
            this.Controls.Add(this.btnFirmenForm);
            this.Controls.Add(this.btnTeilnehmerForm);
            this.Name = "StartseiteView";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeilnehmerForm;
        private System.Windows.Forms.Button btnFirmenForm;
        private System.Windows.Forms.Button btnProfilForm;
        private System.Windows.Forms.Button btnBewerbungForm;
        private System.Windows.Forms.Label lblStartseite;
    }
}

