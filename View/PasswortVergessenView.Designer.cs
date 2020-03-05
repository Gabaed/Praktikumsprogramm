namespace Praktiku.View
{
    partial class PasswortVergessenView
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
            this.lblPasswordVergessenEmail = new System.Windows.Forms.Label();
            this.lblSicherheitsFrage = new System.Windows.Forms.Label();
            this.txtPasswortVergessenEmal = new System.Windows.Forms.TextBox();
            this.txtSicherheitsfrage = new System.Windows.Forms.TextBox();
            this.btnWiederherstellen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPasswordVergessenEmail
            // 
            this.lblPasswordVergessenEmail.AutoSize = true;
            this.lblPasswordVergessenEmail.Location = new System.Drawing.Point(61, 106);
            this.lblPasswordVergessenEmail.Name = "lblPasswordVergessenEmail";
            this.lblPasswordVergessenEmail.Size = new System.Drawing.Size(36, 13);
            this.lblPasswordVergessenEmail.TabIndex = 0;
            this.lblPasswordVergessenEmail.Text = "E-Mail";
            // 
            // lblSicherheitsFrage
            // 
            this.lblSicherheitsFrage.AutoSize = true;
            this.lblSicherheitsFrage.Location = new System.Drawing.Point(61, 196);
            this.lblSicherheitsFrage.Name = "lblSicherheitsFrage";
            this.lblSicherheitsFrage.Size = new System.Drawing.Size(223, 13);
            this.lblSicherheitsFrage.TabIndex = 1;
            this.lblSicherheitsFrage.Text = "Was war der Name deines ersten Haustieres?";
            // 
            // txtPasswortVergessenEmal
            // 
            this.txtPasswortVergessenEmal.Location = new System.Drawing.Point(64, 122);
            this.txtPasswortVergessenEmal.Name = "txtPasswortVergessenEmal";
            this.txtPasswortVergessenEmal.Size = new System.Drawing.Size(100, 20);
            this.txtPasswortVergessenEmal.TabIndex = 2;
            // 
            // txtSicherheitsfrage
            // 
            this.txtSicherheitsfrage.Location = new System.Drawing.Point(64, 221);
            this.txtSicherheitsfrage.Name = "txtSicherheitsfrage";
            this.txtSicherheitsfrage.Size = new System.Drawing.Size(100, 20);
            this.txtSicherheitsfrage.TabIndex = 3;
            // 
            // btnWiederherstellen
            // 
            this.btnWiederherstellen.Location = new System.Drawing.Point(123, 273);
            this.btnWiederherstellen.Name = "btnWiederherstellen";
            this.btnWiederherstellen.Size = new System.Drawing.Size(96, 34);
            this.btnWiederherstellen.TabIndex = 4;
            this.btnWiederherstellen.Text = "Wiederherstellen";
            this.btnWiederherstellen.UseVisualStyleBackColor = true;
            this.btnWiederherstellen.Click += new System.EventHandler(this.btnWiederherstellen_Click);
            // 
            // PasswortVergessenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 411);
            this.Controls.Add(this.btnWiederherstellen);
            this.Controls.Add(this.txtSicherheitsfrage);
            this.Controls.Add(this.txtPasswortVergessenEmal);
            this.Controls.Add(this.lblSicherheitsFrage);
            this.Controls.Add(this.lblPasswordVergessenEmail);
            this.Name = "PasswortVergessenView";
            this.Text = "PasswortVergessenView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordVergessenEmail;
        private System.Windows.Forms.Label lblSicherheitsFrage;
        private System.Windows.Forms.TextBox txtPasswortVergessenEmal;
        private System.Windows.Forms.TextBox txtSicherheitsfrage;
        private System.Windows.Forms.Button btnWiederherstellen;
    }
}