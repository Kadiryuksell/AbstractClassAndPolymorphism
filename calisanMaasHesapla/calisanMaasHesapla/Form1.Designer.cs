
namespace calisanMaasHesapla
{
    partial class frmPanel
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
            this.btncalistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalistir
            // 
            this.btncalistir.Location = new System.Drawing.Point(45, 44);
            this.btncalistir.Name = "btncalistir";
            this.btncalistir.Size = new System.Drawing.Size(165, 70);
            this.btncalistir.TabIndex = 0;
            this.btncalistir.Text = "Çalıştır";
            this.btncalistir.UseVisualStyleBackColor = true;
            this.btncalistir.Click += new System.EventHandler(this.btncalistir_Click);
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 154);
            this.Controls.Add(this.btncalistir);
            this.Name = "frmPanel";
            this.Text = "panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalistir;
    }
}

