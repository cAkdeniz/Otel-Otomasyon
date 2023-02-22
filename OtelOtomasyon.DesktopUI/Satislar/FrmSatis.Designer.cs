
namespace OtelOtomasyon.DesktopUI.Satislar
{
    partial class FrmSatis
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbOda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdaFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunMiktar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnSatisaEkle = new System.Windows.Forms.Button();
            this.listSatislar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdaFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri : ";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(24, 49);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 23);
            this.cmbMusteri.TabIndex = 1;
            // 
            // cmbOda
            // 
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Location = new System.Drawing.Point(162, 49);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(121, 23);
            this.cmbOda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(162, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oda : ";
            // 
            // txtOdaFiyat
            // 
            this.txtOdaFiyat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOdaFiyat.Location = new System.Drawing.Point(302, 49);
            this.txtOdaFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtOdaFiyat.Name = "txtOdaFiyat";
            this.txtOdaFiyat.Size = new System.Drawing.Size(120, 25);
            this.txtOdaFiyat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(302, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oda Fiyatı : ";
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Location = new System.Drawing.Point(24, 79);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.RowTemplate.Height = 25;
            this.dgwUrunler.Size = new System.Drawing.Size(398, 395);
            this.dgwUrunler.TabIndex = 6;
            this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(428, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Miktarı : ";
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunMiktar.Location = new System.Drawing.Point(428, 132);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(120, 25);
            this.txtUrunMiktar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(428, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Fiyatı : ";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunFiyat.Location = new System.Drawing.Point(428, 190);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(120, 25);
            this.txtUrunFiyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(428, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "İndirim :";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIndirim.Location = new System.Drawing.Point(428, 250);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(120, 25);
            this.txtIndirim.TabIndex = 11;
            // 
            // btnSatisaEkle
            // 
            this.btnSatisaEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatisaEkle.Location = new System.Drawing.Point(429, 342);
            this.btnSatisaEkle.Name = "btnSatisaEkle";
            this.btnSatisaEkle.Size = new System.Drawing.Size(119, 36);
            this.btnSatisaEkle.TabIndex = 13;
            this.btnSatisaEkle.Text = "Satışa Ekle";
            this.btnSatisaEkle.UseVisualStyleBackColor = true;
            this.btnSatisaEkle.Click += new System.EventHandler(this.btnSatisaEkle_Click);
            // 
            // listSatislar
            // 
            this.listSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listSatislar.GridLines = true;
            this.listSatislar.HideSelection = false;
            this.listSatislar.Location = new System.Drawing.Point(554, 79);
            this.listSatislar.Name = "listSatislar";
            this.listSatislar.Size = new System.Drawing.Size(382, 353);
            this.listSatislar.TabIndex = 14;
            this.listSatislar.UseCompatibleStateImageBehavior = false;
            this.listSatislar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Sıra No";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "İndirim";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "Fiyat";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 70;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(691, 438);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 36);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 485);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listSatislar);
            this.Controls.Add(this.btnSatisaEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunMiktar);
            this.Controls.Add(this.dgwUrunler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdaFiyat);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSatis";
            this.Text = "FrmSatis";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOdaFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbOda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtOdaFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtUrunMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtUrunFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtIndirim;
        private System.Windows.Forms.Button btnSatisaEkle;
        private System.Windows.Forms.ListView listSatislar;
        private System.Windows.Forms.ColumnHeader SiraNo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader Miktar;
        private System.Windows.Forms.ColumnHeader Indirim;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}