
namespace DövizKurlari
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
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelusdAlis = new System.Windows.Forms.Label();
            this.labelUsdSatis = new System.Windows.Forms.Label();
            this.buttonDovizGetir = new System.Windows.Forms.Button();
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            this.textBoxUSDAlis = new System.Windows.Forms.TextBox();
            this.textBoxUsdSatis = new System.Windows.Forms.TextBox();
            this.textBoxEuroSatis = new System.Windows.Forms.TextBox();
            this.textBoxEuroAlis = new System.Windows.Forms.TextBox();
            this.labelEuroSatis = new System.Windows.Forms.Label();
            this.labelEuroAlis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Location = new System.Drawing.Point(294, 68);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(53, 24);
            this.labelTarih.TabIndex = 0;
            this.labelTarih.Text = "Tarih";
            // 
            // labelusdAlis
            // 
            this.labelusdAlis.AutoSize = true;
            this.labelusdAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelusdAlis.Location = new System.Drawing.Point(287, 119);
            this.labelusdAlis.Name = "labelusdAlis";
            this.labelusdAlis.Size = new System.Drawing.Size(84, 20);
            this.labelusdAlis.TabIndex = 1;
            this.labelusdAlis.Text = "USD ALIŞ";
            // 
            // labelUsdSatis
            // 
            this.labelUsdSatis.AutoSize = true;
            this.labelUsdSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUsdSatis.Location = new System.Drawing.Point(287, 152);
            this.labelUsdSatis.Name = "labelUsdSatis";
            this.labelUsdSatis.Size = new System.Drawing.Size(95, 20);
            this.labelUsdSatis.TabIndex = 2;
            this.labelUsdSatis.Text = "USD SATIŞ";
            // 
            // buttonDovizGetir
            // 
            this.buttonDovizGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDovizGetir.Location = new System.Drawing.Point(317, 199);
            this.buttonDovizGetir.Name = "buttonDovizGetir";
            this.buttonDovizGetir.Size = new System.Drawing.Size(130, 38);
            this.buttonDovizGetir.TabIndex = 3;
            this.buttonDovizGetir.Text = "Döviz Kurları";
            this.buttonDovizGetir.UseVisualStyleBackColor = true;
            this.buttonDovizGetir.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTarih.Location = new System.Drawing.Point(246, 12);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(270, 36);
            this.textBoxTarih.TabIndex = 4;
            this.textBoxTarih.Text = "BUGÜNÜN TARİHİ";
            // 
            // textBoxUSDAlis
            // 
            this.textBoxUSDAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUSDAlis.Location = new System.Drawing.Point(171, 112);
            this.textBoxUSDAlis.Name = "textBoxUSDAlis";
            this.textBoxUSDAlis.Size = new System.Drawing.Size(100, 26);
            this.textBoxUSDAlis.TabIndex = 5;
            this.textBoxUSDAlis.Text = "USD ALIŞ:";
            // 
            // textBoxUsdSatis
            // 
            this.textBoxUsdSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUsdSatis.Location = new System.Drawing.Point(171, 145);
            this.textBoxUsdSatis.Name = "textBoxUsdSatis";
            this.textBoxUsdSatis.Size = new System.Drawing.Size(100, 26);
            this.textBoxUsdSatis.TabIndex = 6;
            this.textBoxUsdSatis.Text = "USD SATIŞ:";
            // 
            // textBoxEuroSatis
            // 
            this.textBoxEuroSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEuroSatis.Location = new System.Drawing.Point(406, 149);
            this.textBoxEuroSatis.Name = "textBoxEuroSatis";
            this.textBoxEuroSatis.Size = new System.Drawing.Size(110, 26);
            this.textBoxEuroSatis.TabIndex = 10;
            this.textBoxEuroSatis.Text = "EURO SATIŞ:";
            // 
            // textBoxEuroAlis
            // 
            this.textBoxEuroAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEuroAlis.Location = new System.Drawing.Point(406, 116);
            this.textBoxEuroAlis.Name = "textBoxEuroAlis";
            this.textBoxEuroAlis.Size = new System.Drawing.Size(110, 26);
            this.textBoxEuroAlis.TabIndex = 9;
            this.textBoxEuroAlis.Text = "EURO ALIŞ:";
            // 
            // labelEuroSatis
            // 
            this.labelEuroSatis.AutoSize = true;
            this.labelEuroSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEuroSatis.Location = new System.Drawing.Point(522, 156);
            this.labelEuroSatis.Name = "labelEuroSatis";
            this.labelEuroSatis.Size = new System.Drawing.Size(107, 20);
            this.labelEuroSatis.TabIndex = 8;
            this.labelEuroSatis.Text = "EURO SATIŞ";
            // 
            // labelEuroAlis
            // 
            this.labelEuroAlis.AutoSize = true;
            this.labelEuroAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEuroAlis.Location = new System.Drawing.Point(522, 123);
            this.labelEuroAlis.Name = "labelEuroAlis";
            this.labelEuroAlis.Size = new System.Drawing.Size(96, 20);
            this.labelEuroAlis.TabIndex = 7;
            this.labelEuroAlis.Text = "EURO ALIŞ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEuroSatis);
            this.Controls.Add(this.textBoxEuroAlis);
            this.Controls.Add(this.labelEuroSatis);
            this.Controls.Add(this.labelEuroAlis);
            this.Controls.Add(this.textBoxUsdSatis);
            this.Controls.Add(this.textBoxUSDAlis);
            this.Controls.Add(this.textBoxTarih);
            this.Controls.Add(this.buttonDovizGetir);
            this.Controls.Add(this.labelUsdSatis);
            this.Controls.Add(this.labelusdAlis);
            this.Controls.Add(this.labelTarih);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelusdAlis;
        private System.Windows.Forms.Label labelUsdSatis;
        private System.Windows.Forms.Button buttonDovizGetir;
        private System.Windows.Forms.TextBox textBoxTarih;
        private System.Windows.Forms.TextBox textBoxUSDAlis;
        private System.Windows.Forms.TextBox textBoxUsdSatis;
        private System.Windows.Forms.TextBox textBoxEuroSatis;
        private System.Windows.Forms.TextBox textBoxEuroAlis;
        private System.Windows.Forms.Label labelEuroSatis;
        private System.Windows.Forms.Label labelEuroAlis;
    }
}

