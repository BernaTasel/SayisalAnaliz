namespace SayisalAnalizProje
{
    partial class SimpsonYontemi
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
            this.txt_NDegeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Bitis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Baslangic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Katsayilar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.txt_BoyutDegeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NDegeri
            // 
            this.txt_NDegeri.Location = new System.Drawing.Point(12, 112);
            this.txt_NDegeri.Name = "txt_NDegeri";
            this.txt_NDegeri.Size = new System.Drawing.Size(154, 20);
            this.txt_NDegeri.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Hassaslık (n değeri)";
            // 
            // txt_Bitis
            // 
            this.txt_Bitis.Location = new System.Drawing.Point(12, 204);
            this.txt_Bitis.Name = "txt_Bitis";
            this.txt_Bitis.Size = new System.Drawing.Size(153, 20);
            this.txt_Bitis.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tanım Aralığının Bitiş Değeri ( B Değeri)";
            // 
            // txt_Baslangic
            // 
            this.txt_Baslangic.Location = new System.Drawing.Point(12, 160);
            this.txt_Baslangic.Name = "txt_Baslangic";
            this.txt_Baslangic.Size = new System.Drawing.Size(154, 20);
            this.txt_Baslangic.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tanım Aralığının Başlık Değeri ( A Değeri)";
            // 
            // txt_Katsayilar
            // 
            this.txt_Katsayilar.Location = new System.Drawing.Point(12, 69);
            this.txt_Katsayilar.Name = "txt_Katsayilar";
            this.txt_Katsayilar.Size = new System.Drawing.Size(154, 20);
            this.txt_Katsayilar.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fonksiyonun KatSayılarını Aralarında \"/\" Olacak Şekilde Giriniz (Lütfen Sabit Ter" +
    "imden Başlayarak Yazınız)";
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(11, 244);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(154, 23);
            this.btn_Hesapla.TabIndex = 47;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // txt_BoyutDegeri
            // 
            this.txt_BoyutDegeri.Location = new System.Drawing.Point(12, 25);
            this.txt_BoyutDegeri.Name = "txt_BoyutDegeri";
            this.txt_BoyutDegeri.Size = new System.Drawing.Size(154, 20);
            this.txt_BoyutDegeri.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Fonksiyon Kaçıncı Dereceden?";
            // 
            // SimpsonYontemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 366);
            this.Controls.Add(this.txt_NDegeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Bitis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Baslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Katsayilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Hesapla);
            this.Controls.Add(this.txt_BoyutDegeri);
            this.Controls.Add(this.label2);
            this.Name = "SimpsonYontemi";
            this.Text = "SimpsonYontemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NDegeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Bitis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Baslangic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Katsayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.TextBox txt_BoyutDegeri;
        private System.Windows.Forms.Label label2;
    }
}