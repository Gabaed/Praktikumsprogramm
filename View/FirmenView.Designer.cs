namespace Praktiku.View
{
    partial class FirmenView
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
            this.btnFirmaAnlegen = new System.Windows.Forms.Button();
            this.praktikumsprogrammDataSet = new Praktiku.praktikumsprogrammDataSet();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaTableAdapter = new Praktiku.praktikumsprogrammDataSetTableAdapters.firmaTableAdapter();
            this.idFirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmennameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bewerbungTelefonnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bewerbungEMailadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinweiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porstleitzahlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.straßeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hausnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFirmenViewSchliessen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikumsprogrammDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFirmaDataGridViewTextBoxColumn,
            this.firmennameDataGridViewTextBoxColumn,
            this.bewerbungTelefonnummerDataGridViewTextBoxColumn,
            this.bewerbungEMailadresseDataGridViewTextBoxColumn,
            this.hinweiseDataGridViewTextBoxColumn,
            this.porstleitzahlDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.straßeDataGridViewTextBoxColumn,
            this.hausnummerDataGridViewTextBoxColumn,
            this.landDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1069, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnFirmaAnlegen
            // 
            this.btnFirmaAnlegen.Location = new System.Drawing.Point(567, 439);
            this.btnFirmaAnlegen.Name = "btnFirmaAnlegen";
            this.btnFirmaAnlegen.Size = new System.Drawing.Size(136, 43);
            this.btnFirmaAnlegen.TabIndex = 1;
            this.btnFirmaAnlegen.Text = "Fima anlegen";
            this.btnFirmaAnlegen.UseVisualStyleBackColor = true;
            this.btnFirmaAnlegen.Click += new System.EventHandler(this.btnFirmaAnlegen_Click);
            // 
            // praktikumsprogrammDataSet
            // 
            this.praktikumsprogrammDataSet.DataSetName = "praktikumsprogrammDataSet";
            this.praktikumsprogrammDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "firma";
            this.firmaBindingSource.DataSource = this.praktikumsprogrammDataSet;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // idFirmaDataGridViewTextBoxColumn
            // 
            this.idFirmaDataGridViewTextBoxColumn.DataPropertyName = "IdFirma";
            this.idFirmaDataGridViewTextBoxColumn.HeaderText = "IdFirma";
            this.idFirmaDataGridViewTextBoxColumn.Name = "idFirmaDataGridViewTextBoxColumn";
            // 
            // firmennameDataGridViewTextBoxColumn
            // 
            this.firmennameDataGridViewTextBoxColumn.DataPropertyName = "Firmenname";
            this.firmennameDataGridViewTextBoxColumn.HeaderText = "Firmenname";
            this.firmennameDataGridViewTextBoxColumn.Name = "firmennameDataGridViewTextBoxColumn";
            // 
            // bewerbungTelefonnummerDataGridViewTextBoxColumn
            // 
            this.bewerbungTelefonnummerDataGridViewTextBoxColumn.DataPropertyName = "BewerbungTelefonnummer";
            this.bewerbungTelefonnummerDataGridViewTextBoxColumn.HeaderText = "BewerbungTelefonnummer";
            this.bewerbungTelefonnummerDataGridViewTextBoxColumn.Name = "bewerbungTelefonnummerDataGridViewTextBoxColumn";
            // 
            // bewerbungEMailadresseDataGridViewTextBoxColumn
            // 
            this.bewerbungEMailadresseDataGridViewTextBoxColumn.DataPropertyName = "BewerbungEMailadresse";
            this.bewerbungEMailadresseDataGridViewTextBoxColumn.HeaderText = "BewerbungEMailadresse";
            this.bewerbungEMailadresseDataGridViewTextBoxColumn.Name = "bewerbungEMailadresseDataGridViewTextBoxColumn";
            // 
            // hinweiseDataGridViewTextBoxColumn
            // 
            this.hinweiseDataGridViewTextBoxColumn.DataPropertyName = "Hinweise";
            this.hinweiseDataGridViewTextBoxColumn.HeaderText = "Hinweise";
            this.hinweiseDataGridViewTextBoxColumn.Name = "hinweiseDataGridViewTextBoxColumn";
            // 
            // porstleitzahlDataGridViewTextBoxColumn
            // 
            this.porstleitzahlDataGridViewTextBoxColumn.DataPropertyName = "Porstleitzahl";
            this.porstleitzahlDataGridViewTextBoxColumn.HeaderText = "Porstleitzahl";
            this.porstleitzahlDataGridViewTextBoxColumn.Name = "porstleitzahlDataGridViewTextBoxColumn";
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            // 
            // straßeDataGridViewTextBoxColumn
            // 
            this.straßeDataGridViewTextBoxColumn.DataPropertyName = "Straße";
            this.straßeDataGridViewTextBoxColumn.HeaderText = "Straße";
            this.straßeDataGridViewTextBoxColumn.Name = "straßeDataGridViewTextBoxColumn";
            // 
            // hausnummerDataGridViewTextBoxColumn
            // 
            this.hausnummerDataGridViewTextBoxColumn.DataPropertyName = "Hausnummer";
            this.hausnummerDataGridViewTextBoxColumn.HeaderText = "Hausnummer";
            this.hausnummerDataGridViewTextBoxColumn.Name = "hausnummerDataGridViewTextBoxColumn";
            // 
            // landDataGridViewTextBoxColumn
            // 
            this.landDataGridViewTextBoxColumn.DataPropertyName = "Land";
            this.landDataGridViewTextBoxColumn.HeaderText = "Land";
            this.landDataGridViewTextBoxColumn.Name = "landDataGridViewTextBoxColumn";
            // 
            // btnFirmenViewSchliessen
            // 
            this.btnFirmenViewSchliessen.Location = new System.Drawing.Point(209, 439);
            this.btnFirmenViewSchliessen.Name = "btnFirmenViewSchliessen";
            this.btnFirmenViewSchliessen.Size = new System.Drawing.Size(136, 43);
            this.btnFirmenViewSchliessen.TabIndex = 2;
            this.btnFirmenViewSchliessen.Text = "Zurück";
            this.btnFirmenViewSchliessen.UseVisualStyleBackColor = true;
            this.btnFirmenViewSchliessen.Click += new System.EventHandler(this.btnFirmenViewSchliessen_Click);
            // 
            // FirmenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 487);
            this.Controls.Add(this.btnFirmenViewSchliessen);
            this.Controls.Add(this.btnFirmaAnlegen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FirmenView";
            this.Text = "FirmenView";
            this.Load += new System.EventHandler(this.FirmenView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikumsprogrammDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFirmaAnlegen;
        private praktikumsprogrammDataSet praktikumsprogrammDataSet;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private praktikumsprogrammDataSetTableAdapters.firmaTableAdapter firmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmennameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bewerbungTelefonnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bewerbungEMailadresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinweiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porstleitzahlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn straßeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hausnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFirmenViewSchliessen;
    }
}