
namespace OtelOtomasyon.DesktopUI.Tanimlar
{
    partial class FrmBirimTip
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
            this.dgwBirimTip = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimTip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBirimTip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBirimTip
            // 
            this.dgwBirimTip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBirimTip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBirimTip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwBirimTip.Enabled = false;
            this.dgwBirimTip.Location = new System.Drawing.Point(0, 64);
            this.dgwBirimTip.Name = "dgwBirimTip";
            this.dgwBirimTip.RowTemplate.Height = 25;
            this.dgwBirimTip.Size = new System.Drawing.Size(452, 211);
            this.dgwBirimTip.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(312, 21);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birim Tip Adı : ";
            // 
            // txtBirimTip
            // 
            this.txtBirimTip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirimTip.Location = new System.Drawing.Point(108, 21);
            this.txtBirimTip.Name = "txtBirimTip";
            this.txtBirimTip.Size = new System.Drawing.Size(176, 25);
            this.txtBirimTip.TabIndex = 4;
            // 
            // FrmBirimTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 275);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirimTip);
            this.Controls.Add(this.dgwBirimTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBirimTip";
            this.Text = "FrmBirimTip";
            this.Load += new System.EventHandler(this.FrmBirimTip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBirimTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBirimTip;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimTip;
    }
}