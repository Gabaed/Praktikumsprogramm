namespace Praktiku.View
{
    partial class BewerbungAnlegenView
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
            this.lblLand = new System.Windows.Forms.Label();
            this.txtNeueBewerbunAnlegenData = new System.Windows.Forms.TextBox();
            this.lblHausnummer = new System.Windows.Forms.Label();
            this.cmbxNeueBewerbungAnlegenTyp = new System.Windows.Forms.ComboBox();
            this.lblBewerbzngStatus = new System.Windows.Forms.Label();
            this.cmbxNeueBewerbungAnlegenStatus = new System.Windows.Forms.ComboBox();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnHinzufuegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLand.Location = new System.Drawing.Point(204, 208);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(34, 20);
            this.lblLand.TabIndex = 38;
            this.lblLand.Text = "Typ";
            // 
            // txtNeueBewerbunAnlegenData
            // 
            this.txtNeueBewerbunAnlegenData.Location = new System.Drawing.Point(357, 161);
            this.txtNeueBewerbunAnlegenData.Multiline = true;
            this.txtNeueBewerbunAnlegenData.Name = "txtNeueBewerbunAnlegenData";
            this.txtNeueBewerbunAnlegenData.Size = new System.Drawing.Size(173, 31);
            this.txtNeueBewerbunAnlegenData.TabIndex = 37;
            // 
            // lblHausnummer
            // 
            this.lblHausnummer.AutoSize = true;
            this.lblHausnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHausnummer.Location = new System.Drawing.Point(204, 159);
            this.lblHausnummer.Name = "lblHausnummer";
            this.lblHausnummer.Size = new System.Drawing.Size(72, 20);
            this.lblHausnummer.TabIndex = 36;
            this.lblHausnummer.Text = "lblDatum";
            // 
            // cmbxNeueBewerbungAnlegenTyp
            // 
            this.cmbxNeueBewerbungAnlegenTyp.FormattingEnabled = true;
            this.cmbxNeueBewerbungAnlegenTyp.Items.AddRange(new object[] {
            "Persönlich",
            "Online",
            "E-Mail"});
            this.cmbxNeueBewerbungAnlegenTyp.Location = new System.Drawing.Point(357, 210);
            this.cmbxNeueBewerbungAnlegenTyp.Name = "cmbxNeueBewerbungAnlegenTyp";
            this.cmbxNeueBewerbungAnlegenTyp.Size = new System.Drawing.Size(173, 21);
            this.cmbxNeueBewerbungAnlegenTyp.TabIndex = 39;
            // 
            // lblBewerbzngStatus
            // 
            this.lblBewerbzngStatus.AutoSize = true;
            this.lblBewerbzngStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBewerbzngStatus.Location = new System.Drawing.Point(204, 104);
            this.lblBewerbzngStatus.Name = "lblBewerbzngStatus";
            this.lblBewerbzngStatus.Size = new System.Drawing.Size(132, 20);
            this.lblBewerbzngStatus.TabIndex = 40;
            this.lblBewerbzngStatus.Text = "Bewerbng Status";
            // 
            // cmbxNeueBewerbungAnlegenStatus
            // 
            this.cmbxNeueBewerbungAnlegenStatus.FormattingEnabled = true;
            this.cmbxNeueBewerbungAnlegenStatus.Items.AddRange(new object[] {
            "Unterwegs",
            "Abgelehnt"});
            this.cmbxNeueBewerbungAnlegenStatus.Location = new System.Drawing.Point(357, 106);
            this.cmbxNeueBewerbungAnlegenStatus.Name = "cmbxNeueBewerbungAnlegenStatus";
            this.cmbxNeueBewerbungAnlegenStatus.Size = new System.Drawing.Size(173, 21);
            this.cmbxNeueBewerbungAnlegenStatus.TabIndex = 41;
            // 
            // btnZurueck
            // 
            this.btnZurueck.Location = new System.Drawing.Point(197, 324);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(102, 37);
            this.btnZurueck.TabIndex = 42;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnHinzufuegen
            // 
            this.btnHinzufuegen.Location = new System.Drawing.Point(457, 324);
            this.btnHinzufuegen.Name = "btnHinzufuegen";
            this.btnHinzufuegen.Size = new System.Drawing.Size(101, 37);
            this.btnHinzufuegen.TabIndex = 43;
            this.btnHinzufuegen.Text = "Hinzufügen";
            this.btnHinzufuegen.UseVisualStyleBackColor = true;
            this.btnHinzufuegen.Click += new System.EventHandler(this.btnHinzufuegen_Click);
            // 
            // BewerbungAnlegenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnHinzufuegen);
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.cmbxNeueBewerbungAnlegenStatus);
            this.Controls.Add(this.lblBewerbzngStatus);
            this.Controls.Add(this.cmbxNeueBewerbungAnlegenTyp);
            this.Controls.Add(this.lblLand);
            this.Controls.Add(this.txtNeueBewerbunAnlegenData);
            this.Controls.Add(this.lblHausnummer);
            this.Name = "BewerbungAnlegenView";
            this.Text = "BewerbungAnlegenView";
            this.Load += new System.EventHandler(this.BewerbungAnlegenView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.TextBox txtNeueBewerbunAnlegenData;
        private System.Windows.Forms.Label lblHausnummer;
        private System.Windows.Forms.ComboBox cmbxNeueBewerbungAnlegenTyp;
        private System.Windows.Forms.Label lblBewerbzngStatus;
        private System.Windows.Forms.ComboBox cmbxNeueBewerbungAnlegenStatus;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnHinzufuegen;
    }
}