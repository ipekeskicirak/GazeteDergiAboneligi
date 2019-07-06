namespace GazeteDergiAboneligi
{
    partial class Dergiler
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
            this.grd_Dergiler = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_Gazete_Adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNASAYFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gAZETELERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dERGİLERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tÜMÜRÜNLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİŞİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBONELİKLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICILARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİLİNMİŞXKAYITLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet3 = new GazeteDergiAboneligi.DataSet3();
            this.tURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tURTableAdapter = new GazeteDergiAboneligi.DataSet3TableAdapters.TURTableAdapter();
            this.uRUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRUNTableAdapter = new GazeteDergiAboneligi.DataSet3TableAdapters.URUNTableAdapter();
            this.URUN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tURIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIYATI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dergiler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Dergiler
            // 
            this.grd_Dergiler.AllowUserToOrderColumns = true;
            this.grd_Dergiler.AutoGenerateColumns = false;
            this.grd_Dergiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Dergiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URUN_ID,
            this.tURIDDataGridViewTextBoxColumn,
            this.FIYATI});
            this.grd_Dergiler.DataSource = this.uRUNBindingSource1;
            this.grd_Dergiler.Location = new System.Drawing.Point(176, 144);
            this.grd_Dergiler.Name = "grd_Dergiler";
            this.grd_Dergiler.RowTemplate.Height = 24;
            this.grd_Dergiler.Size = new System.Drawing.Size(247, 307);
            this.grd_Dergiler.TabIndex = 14;
            this.grd_Dergiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Dergiler_CellContentClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.Location = new System.Drawing.Point(371, 93);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(97, 45);
            this.btn_Sil.TabIndex = 13;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Enabled = false;
            this.btn_Guncelle.Location = new System.Drawing.Point(251, 93);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(97, 45);
            this.btn_Guncelle.TabIndex = 12;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(139, 93);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(97, 45);
            this.btn_Kaydet.TabIndex = 11;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // txt_Gazete_Adi
            // 
            this.txt_Gazete_Adi.Location = new System.Drawing.Point(269, 54);
            this.txt_Gazete_Adi.Name = "txt_Gazete_Adi";
            this.txt_Gazete_Adi.Size = new System.Drawing.Size(147, 22);
            this.txt_Gazete_Adi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dergi Adı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASAYFAToolStripMenuItem,
            this.üRÜNLERToolStripMenuItem,
            this.kİŞİLERToolStripMenuItem,
            this.aBONELİKLERToolStripMenuItem,
            this.kULLANICILARToolStripMenuItem,
            this.sİLİNMİŞXKAYITLARIToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(820, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            this.aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            this.aNASAYFAToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            this.aNASAYFAToolStripMenuItem.Click += new System.EventHandler(this.ANASAYFAToolStripMenuItem_Click);
            // 
            // üRÜNLERToolStripMenuItem
            // 
            this.üRÜNLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gAZETELERToolStripMenuItem1,
            this.dERGİLERToolStripMenuItem1,
            this.tÜMÜRÜNLERToolStripMenuItem});
            this.üRÜNLERToolStripMenuItem.Name = "üRÜNLERToolStripMenuItem";
            this.üRÜNLERToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.üRÜNLERToolStripMenuItem.Text = "ÜRÜNLER";
            this.üRÜNLERToolStripMenuItem.Click += new System.EventHandler(this.ÜRÜNLERToolStripMenuItem_Click);
            // 
            // gAZETELERToolStripMenuItem1
            // 
            this.gAZETELERToolStripMenuItem1.Name = "gAZETELERToolStripMenuItem1";
            this.gAZETELERToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.gAZETELERToolStripMenuItem1.Text = "GAZETELER";
            this.gAZETELERToolStripMenuItem1.Click += new System.EventHandler(this.GAZETELERToolStripMenuItem1_Click);
            // 
            // dERGİLERToolStripMenuItem1
            // 
            this.dERGİLERToolStripMenuItem1.Name = "dERGİLERToolStripMenuItem1";
            this.dERGİLERToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.dERGİLERToolStripMenuItem1.Text = "DERGİLER";
            this.dERGİLERToolStripMenuItem1.Click += new System.EventHandler(this.DERGİLERToolStripMenuItem1_Click);
            // 
            // tÜMÜRÜNLERToolStripMenuItem
            // 
            this.tÜMÜRÜNLERToolStripMenuItem.Name = "tÜMÜRÜNLERToolStripMenuItem";
            this.tÜMÜRÜNLERToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.tÜMÜRÜNLERToolStripMenuItem.Text = "TÜM ÜRÜNLER";
            this.tÜMÜRÜNLERToolStripMenuItem.Click += new System.EventHandler(this.TÜMÜRÜNLERToolStripMenuItem_Click);
            // 
            // kİŞİLERToolStripMenuItem
            // 
            this.kİŞİLERToolStripMenuItem.Name = "kİŞİLERToolStripMenuItem";
            this.kİŞİLERToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.kİŞİLERToolStripMenuItem.Text = "KİŞİLER";
            this.kİŞİLERToolStripMenuItem.Click += new System.EventHandler(this.KİŞİLERToolStripMenuItem_Click);
            // 
            // aBONELİKLERToolStripMenuItem
            // 
            this.aBONELİKLERToolStripMenuItem.Name = "aBONELİKLERToolStripMenuItem";
            this.aBONELİKLERToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.aBONELİKLERToolStripMenuItem.Text = "ABONELİKLER";
            this.aBONELİKLERToolStripMenuItem.Click += new System.EventHandler(this.ABONELİKLERToolStripMenuItem_Click);
            // 
            // kULLANICILARToolStripMenuItem
            // 
            this.kULLANICILARToolStripMenuItem.Name = "kULLANICILARToolStripMenuItem";
            this.kULLANICILARToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.kULLANICILARToolStripMenuItem.Text = "KULLANICILAR";
            this.kULLANICILARToolStripMenuItem.Click += new System.EventHandler(this.KULLANICILARToolStripMenuItem_Click);
            // 
            // sİLİNMİŞXKAYITLARIToolStripMenuItem
            // 
            this.sİLİNMİŞXKAYITLARIToolStripMenuItem.Name = "sİLİNMİŞXKAYITLARIToolStripMenuItem";
            this.sİLİNMİŞXKAYITLARIToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.sİLİNMİŞXKAYITLARIToolStripMenuItem.Text = "SİLİNMİŞ KAYITLAR";
            this.sİLİNMİŞXKAYITLARIToolStripMenuItem.Click += new System.EventHandler(this.SİLİNMİŞXKAYITLARIToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.ÇIKIŞToolStripMenuItem_Click);
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tURBindingSource
            // 
            this.tURBindingSource.DataMember = "TUR";
            this.tURBindingSource.DataSource = this.dataSet3;
            // 
            // tURTableAdapter
            // 
            this.tURTableAdapter.ClearBeforeFill = true;
            // 
            // uRUNBindingSource
            // 
            this.uRUNBindingSource.DataMember = "URUN";
            this.uRUNBindingSource.DataSource = this.dataSet3;
            // 
            // uRUNTableAdapter
            // 
            this.uRUNTableAdapter.ClearBeforeFill = true;
            // 
            // URUN_ID
            // 
            this.URUN_ID.Frozen = true;
            this.URUN_ID.HeaderText = "Ürün ID";
            this.URUN_ID.Name = "URUN_ID";
            this.URUN_ID.Visible = false;
            // 
            // tURIDDataGridViewTextBoxColumn
            // 
            this.tURIDDataGridViewTextBoxColumn.DataPropertyName = "TUR_ID";
            this.tURIDDataGridViewTextBoxColumn.HeaderText = "Tür ID";
            this.tURIDDataGridViewTextBoxColumn.Name = "tURIDDataGridViewTextBoxColumn";
            // 
            // FIYATI
            // 
            this.FIYATI.HeaderText = "Fiyati";
            this.FIYATI.Name = "FIYATI";
            this.FIYATI.ReadOnly = true;
            // 
            // uRUNBindingSource1
            // 
            this.uRUNBindingSource1.DataMember = "URUN";
            this.uRUNBindingSource1.DataSource = this.dataSet3;
            // 
            // Dergiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.grd_Dergiler);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Gazete_Adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dergiler";
            this.Text = "Dergiler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dergiler_FormClosed);
            this.Load += new System.EventHandler(this.Dergiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dergiler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Dergiler;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_Gazete_Adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gAZETELERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dERGİLERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tÜMÜRÜNLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBONELİKLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICILARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sİLİNMİŞXKAYITLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİŞİLERToolStripMenuItem;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource tURBindingSource;
        private DataSet3TableAdapters.TURTableAdapter tURTableAdapter;
        private System.Windows.Forms.BindingSource uRUNBindingSource;
        private DataSet3TableAdapters.URUNTableAdapter uRUNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tURIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIYATI;
        private System.Windows.Forms.BindingSource uRUNBindingSource1;
    }
}