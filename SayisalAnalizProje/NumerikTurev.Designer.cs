﻿namespace SayisalAnalizProje
{
    partial class NumerikTurev
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
            this.txt_DeltaDegeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_x0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Katsayilar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.txt_Ndegeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_DeltaDegeri
            // 
            this.txt_DeltaDegeri.Location = new System.Drawing.Point(12, 171);
            this.txt_DeltaDegeri.Name = "txt_DeltaDegeri";
            this.txt_DeltaDegeri.Size = new System.Drawing.Size(154, 20);
            this.txt_DeltaDegeri.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Δx Değerini Giriniz";
            // 
            // txt_x0
            // 
            this.txt_x0.Location = new System.Drawing.Point(13, 114);
            this.txt_x0.Name = "txt_x0";
            this.txt_x0.Size = new System.Drawing.Size(154, 20);
            this.txt_x0.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Başlangıç Noktası (x0)";
            // 
            // txt_Katsayilar
            // 
            this.txt_Katsayilar.Location = new System.Drawing.Point(13, 70);
            this.txt_Katsayilar.Name = "txt_Katsayilar";
            this.txt_Katsayilar.Size = new System.Drawing.Size(154, 20);
            this.txt_Katsayilar.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fonksiyonun KatSayılarını Aralarında \"/\" Olacak Şekilde Giriniz (Lütfen Sabit Ter" +
    "imden Başlayarak Yazınız)";
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(12, 211);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(154, 23);
            this.btn_Hesapla.TabIndex = 47;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // txt_Ndegeri
            // 
            this.txt_Ndegeri.Location = new System.Drawing.Point(13, 26);
            this.txt_Ndegeri.Name = "txt_Ndegeri";
            this.txt_Ndegeri.Size = new System.Drawing.Size(154, 20);
            this.txt_Ndegeri.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Fonksiyon Kaçıncı Dereceden?";
            // 
            // NumerikTurev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 404);
            this.Controls.Add(this.txt_DeltaDegeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_x0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Katsayilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Hesapla);
            this.Controls.Add(this.txt_Ndegeri);
            this.Controls.Add(this.label2);
            this.Name = "NumerikTurev";
            this.Text = "NumerikTurev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DeltaDegeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_x0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Katsayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.TextBox txt_Ndegeri;
        private System.Windows.Forms.Label label2;
    }
}