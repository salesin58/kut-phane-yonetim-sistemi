
namespace Kutuphane
{
    partial class Ogrenci_emanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_emanet));
            this.Btn_anasayfa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ara = new System.Windows.Forms.Button();
            this.Txt_ogrno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_tum = new System.Windows.Forms.Button();
            this.data_liste = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_anasayfa
            // 
            this.Btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_anasayfa.Location = new System.Drawing.Point(36, 28);
            this.Btn_anasayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_anasayfa.Name = "Btn_anasayfa";
            this.Btn_anasayfa.Size = new System.Drawing.Size(196, 44);
            this.Btn_anasayfa.TabIndex = 8;
            this.Btn_anasayfa.Text = "ANASAYFA";
            this.Btn_anasayfa.UseVisualStyleBackColor = false;
            this.Btn_anasayfa.Click += new System.EventHandler(this.Btn_anasayfa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Btn_ara);
            this.groupBox1.Controls.Add(this.Txt_ogrno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(285, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(628, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade Edilen Kitap";
            // 
            // Btn_ara
            // 
            this.Btn_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_ara.Location = new System.Drawing.Point(440, 31);
            this.Btn_ara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_ara.Name = "Btn_ara";
            this.Btn_ara.Size = new System.Drawing.Size(148, 34);
            this.Btn_ara.TabIndex = 2;
            this.Btn_ara.Text = "ARA";
            this.Btn_ara.UseVisualStyleBackColor = false;
            this.Btn_ara.Click += new System.EventHandler(this.Btn_ara_Click);
            // 
            // Txt_ogrno
            // 
            this.Txt_ogrno.Location = new System.Drawing.Point(115, 37);
            this.Txt_ogrno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_ogrno.Name = "Txt_ogrno";
            this.Txt_ogrno.Size = new System.Drawing.Size(303, 22);
            this.Txt_ogrno.TabIndex = 1;
            this.Txt_ogrno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_ogrno_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // Btn_tum
            // 
            this.Btn_tum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_tum.Location = new System.Drawing.Point(37, 112);
            this.Btn_tum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_tum.Name = "Btn_tum";
            this.Btn_tum.Size = new System.Drawing.Size(195, 41);
            this.Btn_tum.TabIndex = 10;
            this.Btn_tum.Text = "TÜM KAYITLARI GÖSTER";
            this.Btn_tum.UseVisualStyleBackColor = false;
            this.Btn_tum.Click += new System.EventHandler(this.Btn_tum_Click);
            // 
            // data_liste
            // 
            this.data_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_liste.Location = new System.Drawing.Point(36, 207);
            this.data_liste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_liste.Name = "data_liste";
            this.data_liste.RowHeadersWidth = 51;
            this.data_liste.Size = new System.Drawing.Size(877, 256);
            this.data_liste.TabIndex = 11;
            // 
            // Ogrenci_emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.data_liste);
            this.Controls.Add(this.Btn_tum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_anasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ogrenci_emanet";
            this.Text = "Öğrenci Emanet - İade Listesi";
            this.Load += new System.EventHandler(this.Ogrenci_emanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_anasayfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_ara;
        private System.Windows.Forms.TextBox Txt_ogrno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_tum;
        private System.Windows.Forms.DataGridView data_liste;
    }
}