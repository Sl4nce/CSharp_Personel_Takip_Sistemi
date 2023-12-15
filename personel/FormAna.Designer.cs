namespace personel
{
    partial class FormAna
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.MaskedTextBox();
            this.radiobekar = new System.Windows.Forms.RadioButton();
            this.radioevli = new System.Windows.Forms.RadioButton();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perşehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelveritabaniDataSet = new personel.personelveritabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_perTableAdapter = new personel.personelveritabaniDataSetTableAdapters.tbl_perTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmaas);
            this.groupBox1.Controls.Add(this.radiobekar);
            this.groupBox1.Controls.Add(this.radioevli);
            this.groupBox1.Controls.Add(this.txtmeslek);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsehir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgisi";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(120, 34);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(117, 22);
            this.txtid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Maaş: ";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(120, 281);
            this.txtmaas.Mask = "00000";
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(117, 22);
            this.txtmaas.TabIndex = 8;
            this.txtmaas.ValidatingType = typeof(int);
            // 
            // radiobekar
            // 
            this.radiobekar.AutoSize = true;
            this.radiobekar.Location = new System.Drawing.Point(176, 191);
            this.radiobekar.Name = "radiobekar";
            this.radiobekar.Size = new System.Drawing.Size(64, 20);
            this.radiobekar.TabIndex = 6;
            this.radiobekar.TabStop = true;
            this.radiobekar.Text = "Bekar";
            this.radiobekar.UseVisualStyleBackColor = true;
            this.radiobekar.CheckedChanged += new System.EventHandler(this.radiobekar_CheckedChanged);
            // 
            // radioevli
            // 
            this.radioevli.AutoSize = true;
            this.radioevli.Location = new System.Drawing.Point(120, 191);
            this.radioevli.Name = "radioevli";
            this.radioevli.Size = new System.Drawing.Size(50, 20);
            this.radioevli.TabIndex = 5;
            this.radioevli.TabStop = true;
            this.radioevli.Text = "Evli";
            this.radioevli.UseVisualStyleBackColor = true;
            this.radioevli.CheckedChanged += new System.EventHandler(this.radioevli_CheckedChanged);
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(120, 234);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(117, 22);
            this.txtmeslek.TabIndex = 7;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(120, 104);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(117, 22);
            this.txtsoyad.TabIndex = 3;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(120, 69);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(117, 22);
            this.txtad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Şehir: ";
            // 
            // txtsehir
            // 
            this.txtsehir.FormattingEnabled = true;
            this.txtsehir.Location = new System.Drawing.Point(120, 148);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(117, 24);
            this.txtsehir.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Meslek: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Durum: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyisim: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "İd: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btngrafikler);
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(383, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel İşlemleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Raporla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngrafikler
            // 
            this.btngrafikler.Location = new System.Drawing.Point(25, 277);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(140, 31);
            this.btngrafikler.TabIndex = 15;
            this.btngrafikler.Text = "Grafikler";
            this.btngrafikler.UseVisualStyleBackColor = true;
            this.btngrafikler.Click += new System.EventHandler(this.btngrafikler_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(25, 235);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(140, 36);
            this.btnistatistik.TabIndex = 14;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(25, 191);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(140, 34);
            this.btntemizle.TabIndex = 13;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(25, 148);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(140, 37);
            this.btnguncelle.TabIndex = 12;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(25, 104);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(140, 33);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(25, 62);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(140, 33);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(25, 21);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(140, 35);
            this.btnlistele.TabIndex = 9;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(938, 229);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.perşehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblperBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "perad";
            this.peradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.Width = 125;
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            this.persoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perşehirDataGridViewTextBoxColumn
            // 
            this.perşehirDataGridViewTextBoxColumn.DataPropertyName = "perşehir";
            this.perşehirDataGridViewTextBoxColumn.HeaderText = "perşehir";
            this.perşehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perşehirDataGridViewTextBoxColumn.Name = "perşehirDataGridViewTextBoxColumn";
            this.perşehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "permaas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "permaas";
            this.permaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            this.permaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            this.perdurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            this.permeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblperBindingSource
            // 
            this.tblperBindingSource.DataMember = "tbl_per";
            this.tblperBindingSource.DataSource = this.personelveritabaniDataSet;
            // 
            // personelveritabaniDataSet
            // 
            this.personelveritabaniDataSet.DataSetName = "personelveritabaniDataSet";
            this.personelveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_perTableAdapter
            // 
            this.tbl_perTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(977, 610);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAna";
            this.Text = "Personel Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtmaas;
        private System.Windows.Forms.RadioButton radiobekar;
        private System.Windows.Forms.RadioButton radioevli;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtsehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafikler;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private personelveritabaniDataSet personelveritabaniDataSet;
        private System.Windows.Forms.BindingSource tblperBindingSource;
        private personelveritabaniDataSetTableAdapters.tbl_perTableAdapter tbl_perTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perşehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

