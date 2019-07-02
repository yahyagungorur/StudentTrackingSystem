namespace LinqTo1
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
            System.Windows.Forms.Label ARA;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.textSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTCKN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVeliID = new System.Windows.Forms.ComboBox();
            this.textOkulNo = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dateTimePickerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.textAra = new System.Windows.Forms.TextBox();
            this.btngecis = new System.Windows.Forms.Button();
            ARA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ARA
            // 
            ARA.AutoSize = true;
            ARA.Location = new System.Drawing.Point(407, 117);
            ARA.Name = "ARA";
            ARA.Size = new System.Drawing.Size(46, 13);
            ARA.TabIndex = 18;
            ARA.Text = "TC Ara :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Adı";
            // 
            // textAdi
            // 
            this.textAdi.Location = new System.Drawing.Point(139, 48);
            this.textAdi.Name = "textAdi";
            this.textAdi.Size = new System.Drawing.Size(100, 20);
            this.textAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Okul No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doğum Tarihi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(67, 112);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textSoyadi
            // 
            this.textSoyadi.Location = new System.Drawing.Point(273, 48);
            this.textSoyadi.Name = "textSoyadi";
            this.textSoyadi.Size = new System.Drawing.Size(100, 20);
            this.textSoyadi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TC Kimlik No";
            // 
            // textTCKN
            // 
            this.textTCKN.Location = new System.Drawing.Point(12, 48);
            this.textTCKN.MaxLength = 11;
            this.textTCKN.Name = "textTCKN";
            this.textTCKN.Size = new System.Drawing.Size(100, 20);
            this.textTCKN.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Veli Adı";
            // 
            // comboBoxVeliID
            // 
            this.comboBoxVeliID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeliID.FormattingEnabled = true;
            this.comboBoxVeliID.Location = new System.Drawing.Point(674, 48);
            this.comboBoxVeliID.Name = "comboBoxVeliID";
            this.comboBoxVeliID.Size = new System.Drawing.Size(78, 21);
            this.comboBoxVeliID.TabIndex = 13;
            // 
            // textOkulNo
            // 
            this.textOkulNo.Location = new System.Drawing.Point(410, 48);
            this.textOkulNo.Name = "textOkulNo";
            this.textOkulNo.Size = new System.Drawing.Size(61, 20);
            this.textOkulNo.TabIndex = 14;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(298, 112);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(181, 112);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dateTimePickerDogumTarihi
            // 
            this.dateTimePickerDogumTarihi.Location = new System.Drawing.Point(494, 48);
            this.dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            this.dateTimePickerDogumTarihi.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerDogumTarihi.TabIndex = 17;
            // 
            // textAra
            // 
            this.textAra.Location = new System.Drawing.Point(470, 114);
            this.textAra.MaxLength = 11;
            this.textAra.Name = "textAra";
            this.textAra.Size = new System.Drawing.Size(100, 20);
            this.textAra.TabIndex = 19;
            this.textAra.TextChanged += new System.EventHandler(this.textAra_TextChanged);
            // 
            // btngecis
            // 
            this.btngecis.Location = new System.Drawing.Point(659, 111);
            this.btngecis.Name = "btngecis";
            this.btngecis.Size = new System.Drawing.Size(75, 23);
            this.btngecis.TabIndex = 20;
            this.btngecis.Text = "Öğretmenler";
            this.btngecis.UseVisualStyleBackColor = true;
            this.btngecis.Click += new System.EventHandler(this.btngecis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 486);
            this.Controls.Add(this.btngecis);
            this.Controls.Add(this.textAra);
            this.Controls.Add(ARA);
            this.Controls.Add(this.dateTimePickerDogumTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.textOkulNo);
            this.Controls.Add(this.comboBoxVeliID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTCKN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSoyadi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenciler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox textSoyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTCKN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVeliID;
        private System.Windows.Forms.TextBox textOkulNo;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarihi;
        private System.Windows.Forms.TextBox textAra;
        private System.Windows.Forms.Button btngecis;
    }
}

