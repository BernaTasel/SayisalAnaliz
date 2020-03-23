namespace SayisalAnalizProje
{
    partial class NewtonRaphsonYontemi
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
            this.txt_EpsilonDegeri = new System.Windows.Forms.TextBox();
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
            // txt_EpsilonDegeri
            // 
            this.txt_EpsilonDegeri.Location = new System.Drawing.Point(11, 169);
            this.txt_EpsilonDegeri.Name = "txt_EpsilonDegeri";
            this.txt_EpsilonDegeri.Size = new System.Drawing.Size(154, 20);
            this.txt_EpsilonDegeri.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "ε Değerini Giriniz";
            // 
            // txt_x0
            // 
            this.txt_x0.Location = new System.Drawing.Point(12, 112);
            this.txt_x0.Name = "txt_x0";
            this.txt_x0.Size = new System.Drawing.Size(154, 20);
            this.txt_x0.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Başlangıç Noktası (x0)";
            // 
            // txt_Katsayilar
            // 
            this.txt_Katsayilar.Location = new System.Drawing.Point(12, 68);
            this.txt_Katsayilar.Name = "txt_Katsayilar";
            this.txt_Katsayilar.Size = new System.Drawing.Size(154, 20);
            this.txt_Katsayilar.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fonksiyonun KatSayılarını Aralarında \"/\" Olacak Şekilde Giriniz (Lütfen Sabit Ter" +
    "imden Başlayarak Yazınız)";
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(11, 209);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(154, 23);
            this.btn_Hesapla.TabIndex = 36;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // txt_Ndegeri
            // 
            this.txt_Ndegeri.Location = new System.Drawing.Point(12, 24);
            this.txt_Ndegeri.Name = "txt_Ndegeri";
            this.txt_Ndegeri.Size = new System.Drawing.Size(154, 20);
            this.txt_Ndegeri.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fonksiyon Kaçıncı Dereceden?";
            // 
            // NewtonRaphsonYontemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 405);
            this.Controls.Add(this.txt_EpsilonDegeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_x0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Katsayilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Hesapla);
            this.Controls.Add(this.txt_Ndegeri);
            this.Controls.Add(this.label2);
            this.Name = "NewtonRaphsonYontemi";
            this.Text = "NewtonRaphsonYontemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EpsilonDegeri;
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