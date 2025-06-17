namespace KayitOl_VeriTaban_Tekrari
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4Meslek = new System.Windows.Forms.TextBox();
            this.KayitBtn = new System.Windows.Forms.Button();
            this.radioButton2Bekar = new System.Windows.Forms.RadioButton();
            this.radioButton1Evli = new System.Windows.Forms.RadioButton();
            this.comboBox1Sehr = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1Maas = new System.Windows.Forms.MaskedTextBox();
            this.textBox3Soyad = new System.Windows.Forms.TextBox();
            this.textBox2Ad = new System.Windows.Forms.TextBox();
            this.textBox1Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Işlem = new System.Windows.Forms.GroupBox();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.ListeleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEHIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mESLEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vS_Personel_Kayit2DataSet1 = new KayitOl_VeriTaban_Tekrari.VS_Personel_Kayit2DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.personellerTableAdapter = new KayitOl_VeriTaban_Tekrari.VS_Personel_Kayit2DataSet1TableAdapters.PersonellerTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Işlem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vS_Personel_Kayit2DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4Meslek);
            this.groupBox1.Controls.Add(this.KayitBtn);
            this.groupBox1.Controls.Add(this.radioButton2Bekar);
            this.groupBox1.Controls.Add(this.radioButton1Evli);
            this.groupBox1.Controls.Add(this.comboBox1Sehr);
            this.groupBox1.Controls.Add(this.maskedTextBox1Maas);
            this.groupBox1.Controls.Add(this.textBox3Soyad);
            this.groupBox1.Controls.Add(this.textBox2Ad);
            this.groupBox1.Controls.Add(this.textBox1Id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(136, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 339);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Meslek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Durum:";
            // 
            // textBox4Meslek
            // 
            this.textBox4Meslek.Location = new System.Drawing.Point(173, 238);
            this.textBox4Meslek.Name = "textBox4Meslek";
            this.textBox4Meslek.Size = new System.Drawing.Size(122, 28);
            this.textBox4Meslek.TabIndex = 12;
            // 
            // KayitBtn
            // 
            this.KayitBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.KayitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KayitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitBtn.Location = new System.Drawing.Point(50, 282);
            this.KayitBtn.Name = "KayitBtn";
            this.KayitBtn.Size = new System.Drawing.Size(246, 34);
            this.KayitBtn.TabIndex = 3;
            this.KayitBtn.Text = "Kayıt";
            this.KayitBtn.UseVisualStyleBackColor = false;
            this.KayitBtn.Click += new System.EventHandler(this.KayitBtn_Click);
            // 
            // radioButton2Bekar
            // 
            this.radioButton2Bekar.AutoSize = true;
            this.radioButton2Bekar.Location = new System.Drawing.Point(228, 207);
            this.radioButton2Bekar.Name = "radioButton2Bekar";
            this.radioButton2Bekar.Size = new System.Drawing.Size(78, 26);
            this.radioButton2Bekar.TabIndex = 11;
            this.radioButton2Bekar.TabStop = true;
            this.radioButton2Bekar.Text = "Bekar";
            this.radioButton2Bekar.UseVisualStyleBackColor = true;
            this.radioButton2Bekar.CheckedChanged += new System.EventHandler(this.radioButton2Bekar_CheckedChanged);
            // 
            // radioButton1Evli
            // 
            this.radioButton1Evli.AutoSize = true;
            this.radioButton1Evli.Location = new System.Drawing.Point(172, 207);
            this.radioButton1Evli.Name = "radioButton1Evli";
            this.radioButton1Evli.Size = new System.Drawing.Size(60, 26);
            this.radioButton1Evli.TabIndex = 10;
            this.radioButton1Evli.TabStop = true;
            this.radioButton1Evli.Text = "Evli";
            this.radioButton1Evli.UseVisualStyleBackColor = true;
            this.radioButton1Evli.CheckedChanged += new System.EventHandler(this.radioButton1Evli_CheckedChanged);
            // 
            // comboBox1Sehr
            // 
            this.comboBox1Sehr.FormattingEnabled = true;
            this.comboBox1Sehr.Location = new System.Drawing.Point(173, 129);
            this.comboBox1Sehr.Name = "comboBox1Sehr";
            this.comboBox1Sehr.Size = new System.Drawing.Size(123, 30);
            this.comboBox1Sehr.TabIndex = 9;
            // 
            // maskedTextBox1Maas
            // 
            this.maskedTextBox1Maas.Location = new System.Drawing.Point(173, 163);
            this.maskedTextBox1Maas.Mask = "000000";
            this.maskedTextBox1Maas.Name = "maskedTextBox1Maas";
            this.maskedTextBox1Maas.Size = new System.Drawing.Size(122, 28);
            this.maskedTextBox1Maas.TabIndex = 8;
            this.maskedTextBox1Maas.ValidatingType = typeof(int);
            // 
            // textBox3Soyad
            // 
            this.textBox3Soyad.Location = new System.Drawing.Point(173, 97);
            this.textBox3Soyad.Name = "textBox3Soyad";
            this.textBox3Soyad.Size = new System.Drawing.Size(122, 28);
            this.textBox3Soyad.TabIndex = 7;
            // 
            // textBox2Ad
            // 
            this.textBox2Ad.Location = new System.Drawing.Point(173, 65);
            this.textBox2Ad.Name = "textBox2Ad";
            this.textBox2Ad.Size = new System.Drawing.Size(122, 28);
            this.textBox2Ad.TabIndex = 6;
            // 
            // textBox1Id
            // 
            this.textBox1Id.Location = new System.Drawing.Point(173, 33);
            this.textBox1Id.Name = "textBox1Id";
            this.textBox1Id.Size = new System.Drawing.Size(122, 28);
            this.textBox1Id.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // Işlem
            // 
            this.Işlem.Controls.Add(this.TemizleBtn);
            this.Işlem.Controls.Add(this.GuncelleBtn);
            this.Işlem.Controls.Add(this.SilBtn);
            this.Işlem.Controls.Add(this.ListeleBtn);
            this.Işlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Işlem.Location = new System.Drawing.Point(545, 113);
            this.Işlem.Name = "Işlem";
            this.Işlem.Size = new System.Drawing.Size(171, 227);
            this.Işlem.TabIndex = 4;
            this.Işlem.TabStop = false;
            this.Işlem.Text = "Işlem";
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.BackColor = System.Drawing.Color.IndianRed;
            this.TemizleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemizleBtn.Location = new System.Drawing.Point(27, 163);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(117, 34);
            this.TemizleBtn.TabIndex = 6;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.UseVisualStyleBackColor = false;
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.GuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuncelleBtn.Location = new System.Drawing.Point(27, 120);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(117, 34);
            this.GuncelleBtn.TabIndex = 5;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Location = new System.Drawing.Point(27, 77);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(117, 34);
            this.SilBtn.TabIndex = 4;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.BackColor = System.Drawing.Color.Orange;
            this.ListeleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListeleBtn.Location = new System.Drawing.Point(27, 34);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(117, 34);
            this.ListeleBtn.TabIndex = 2;
            this.ListeleBtn.Text = "Listele";
            this.ListeleBtn.UseVisualStyleBackColor = false;
            this.ListeleBtn.Click += new System.EventHandler(this.ListeleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.sEHIRDataGridViewTextBoxColumn,
            this.mAASDataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn,
            this.mESLEKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personellerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 475);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 146);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            this.sOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEHIRDataGridViewTextBoxColumn
            // 
            this.sEHIRDataGridViewTextBoxColumn.DataPropertyName = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.HeaderText = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEHIRDataGridViewTextBoxColumn.Name = "sEHIRDataGridViewTextBoxColumn";
            this.sEHIRDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAASDataGridViewTextBoxColumn
            // 
            this.mAASDataGridViewTextBoxColumn.DataPropertyName = "MAAS";
            this.mAASDataGridViewTextBoxColumn.HeaderText = "MAAS";
            this.mAASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAASDataGridViewTextBoxColumn.Name = "mAASDataGridViewTextBoxColumn";
            this.mAASDataGridViewTextBoxColumn.Width = 125;
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            this.dURUMDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mESLEKDataGridViewTextBoxColumn
            // 
            this.mESLEKDataGridViewTextBoxColumn.DataPropertyName = "MESLEK";
            this.mESLEKDataGridViewTextBoxColumn.HeaderText = "MESLEK";
            this.mESLEKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mESLEKDataGridViewTextBoxColumn.Name = "mESLEKDataGridViewTextBoxColumn";
            this.mESLEKDataGridViewTextBoxColumn.Width = 125;
            // 
            // personellerBindingSource
            // 
            this.personellerBindingSource.DataMember = "Personeller";
            this.personellerBindingSource.DataSource = this.vS_Personel_Kayit2DataSet1;
            // 
            // vS_Personel_Kayit2DataSet1
            // 
            this.vS_Personel_Kayit2DataSet1.DataSetName = "VS_Personel_Kayit2DataSet1";
            this.vS_Personel_Kayit2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 100);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(133, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(401, 58);
            this.label8.TabIndex = 0;
            this.label8.Text = "Personel Kayıt Sistemi";
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "label9";
            this.label9.TextChanged += new System.EventHandler(this.label9_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(853, 621);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Işlem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_Kayıt2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Işlem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vS_Personel_Kayit2DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4Meslek;
        private System.Windows.Forms.RadioButton radioButton2Bekar;
        private System.Windows.Forms.RadioButton radioButton1Evli;
        private System.Windows.Forms.ComboBox comboBox1Sehr;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1Maas;
        private System.Windows.Forms.TextBox textBox3Soyad;
        private System.Windows.Forms.TextBox textBox2Ad;
        private System.Windows.Forms.TextBox textBox1Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Işlem;
        private System.Windows.Forms.Button TemizleBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button KayitBtn;
        private System.Windows.Forms.Button ListeleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VS_Personel_Kayit2DataSet1 vS_Personel_Kayit2DataSet1;
        private System.Windows.Forms.BindingSource personellerBindingSource;
        private VS_Personel_Kayit2DataSet1TableAdapters.PersonellerTableAdapter personellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEHIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESLEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}

