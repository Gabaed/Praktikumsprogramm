namespace Praktiku.View
{
    partial class BewerbungView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idBewerbungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeilnehmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbteilungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bewerbzngStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bewerbungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikumsprogrammBewerbungAnsicht = new Praktiku.praktikumsprogrammBewerbungAnsicht();
            this.btnStartseite = new System.Windows.Forms.Button();
            this.bewerbungTableAdapter = new Praktiku.praktikumsprogrammBewerbungAnsichtTableAdapters.bewerbungTableAdapter();
            this.btnBewerbungAnlegen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikumsprogrammBewerbungAnsicht)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBewerbungDataGridViewTextBoxColumn,
            this.idTeilnehmerDataGridViewTextBoxColumn,
            this.idAbteilungDataGridViewTextBoxColumn,
            this.bewerbzngStatusDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bewerbungBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // idBewerbungDataGridViewTextBoxColumn
            // 
            this.idBewerbungDataGridViewTextBoxColumn.DataPropertyName = "IdBewerbung";
            this.idBewerbungDataGridViewTextBoxColumn.HeaderText = "IdBewerbung";
            this.idBewerbungDataGridViewTextBoxColumn.Name = "idBewerbungDataGridViewTextBoxColumn";
            // 
            // idTeilnehmerDataGridViewTextBoxColumn
            // 
            this.idTeilnehmerDataGridViewTextBoxColumn.DataPropertyName = "IdTeilnehmer";
            this.idTeilnehmerDataGridViewTextBoxColumn.HeaderText = "IdTeilnehmer";
            this.idTeilnehmerDataGridViewTextBoxColumn.Name = "idTeilnehmerDataGridViewTextBoxColumn";
            // 
            // idAbteilungDataGridViewTextBoxColumn
            // 
            this.idAbteilungDataGridViewTextBoxColumn.DataPropertyName = "IdAbteilung";
            this.idAbteilungDataGridViewTextBoxColumn.HeaderText = "IdAbteilung";
            this.idAbteilungDataGridViewTextBoxColumn.Name = "idAbteilungDataGridViewTextBoxColumn";
            // 
            // bewerbzngStatusDataGridViewTextBoxColumn
            // 
            this.bewerbzngStatusDataGridViewTextBoxColumn.DataPropertyName = "BewerbzngStatus";
            this.bewerbzngStatusDataGridViewTextBoxColumn.HeaderText = "BewerbzngStatus";
            this.bewerbzngStatusDataGridViewTextBoxColumn.Name = "bewerbzngStatusDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // bewerbungBindingSource
            // 
            this.bewerbungBindingSource.DataMember = "bewerbung";
            this.bewerbungBindingSource.DataSource = this.praktikumsprogrammBewerbungAnsicht;
            // 
            // praktikumsprogrammBewerbungAnsicht
            // 
            this.praktikumsprogrammBewerbungAnsicht.DataSetName = "praktikumsprogrammBewerbungAnsicht";
            this.praktikumsprogrammBewerbungAnsicht.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnStartseite
            // 
            this.btnStartseite.Location = new System.Drawing.Point(208, 383);
            this.btnStartseite.Name = "btnStartseite";
            this.btnStartseite.Size = new System.Drawing.Size(92, 42);
            this.btnStartseite.TabIndex = 2;
            this.btnStartseite.Text = "Zurück";
            this.btnStartseite.UseVisualStyleBackColor = true;
            this.btnStartseite.Click += new System.EventHandler(this.btnStartseite_Click);
            // 
            // bewerbungTableAdapter
            // 
            this.bewerbungTableAdapter.ClearBeforeFill = true;
            // 
            // btnBewerbungAnlegen
            // 
            this.btnBewerbungAnlegen.Location = new System.Drawing.Point(509, 383);
            this.btnBewerbungAnlegen.Name = "btnBewerbungAnlegen";
            this.btnBewerbungAnlegen.Size = new System.Drawing.Size(114, 42);
            this.btnBewerbungAnlegen.TabIndex = 3;
            this.btnBewerbungAnlegen.Text = "Bewerbung Anlegen";
            this.btnBewerbungAnlegen.UseVisualStyleBackColor = true;
            this.btnBewerbungAnlegen.Click += new System.EventHandler(this.btnBewerbungAnlegen_Click);
            // 
            // BewerbungView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBewerbungAnlegen);
            this.Controls.Add(this.btnStartseite);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BewerbungView";
            this.Text = "Bewerbung";
            this.Load += new System.EventHandler(this.BewerbungView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikumsprogrammBewerbungAnsicht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStartseite;
        private praktikumsprogrammBewerbungAnsicht praktikumsprogrammBewerbungAnsicht;
        private System.Windows.Forms.BindingSource bewerbungBindingSource;
        private praktikumsprogrammBewerbungAnsichtTableAdapters.bewerbungTableAdapter bewerbungTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBewerbungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeilnehmerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbteilungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bewerbzngStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBewerbungAnlegen;
    }
}