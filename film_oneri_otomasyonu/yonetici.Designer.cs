namespace film_oneri_otomasyonu
{
    partial class yonetici
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            txt_imdb = new MaskedTextBox();
            label10 = new Label();
            button1 = new Button();
            label4 = new Label();
            txt_yil = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            txt_baslik = new TextBox();
            panel2 = new Panel();
            label9 = new Label();
            comboBoxTur = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            text_box_yıl = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            text_box_baslik = new TextBox();
            label8 = new Label();
            comboBoxFilm = new ComboBox();
            text_box_imdb = new MaskedTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "aksiyon", "anime", "bilim", "dram", "fantastik", "gizem", "komedi", "korku", "muzik", "romantik", "yesil" });
            comboBox1.Location = new Point(27, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 81);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 1;
            label1.Text = "filmin türünü seçiniz";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_imdb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_yil);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_baslik);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 469);
            panel1.TabIndex = 2;
            // 
            // txt_imdb
            // 
            txt_imdb.Location = new Point(30, 353);
            txt_imdb.Mask = "0.0";
            txt_imdb.Name = "txt_imdb";
            txt_imdb.Size = new Size(191, 27);
            txt_imdb.TabIndex = 12;
            txt_imdb.ValidatingType = typeof(int);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(30, 21);
            label10.Name = "label10";
            label10.Size = new Size(141, 35);
            label10.TabIndex = 11;
            label10.Text = "ekleme yeri";
            // 
            // button1
            // 
            button1.Location = new Point(30, 405);
            button1.Name = "button1";
            button1.Size = new Size(191, 52);
            button1.TabIndex = 10;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 324);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 9;
            label4.Text = "imbd_rating";
            // 
            // txt_yil
            // 
            txt_yil.Location = new Point(30, 270);
            txt_yil.Mask = "00000";
            txt_yil.Name = "txt_yil";
            txt_yil.Size = new Size(191, 27);
            txt_yil.TabIndex = 7;
            txt_yil.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 242);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 6;
            label3.Text = "yıl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 169);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "baslik";
            // 
            // txt_baslik
            // 
            txt_baslik.Location = new Point(27, 192);
            txt_baslik.Name = "txt_baslik";
            txt_baslik.Size = new Size(194, 27);
            txt_baslik.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(text_box_imdb);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxTur);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(text_box_yıl);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(text_box_baslik);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBoxFilm);
            panel2.Location = new Point(275, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 469);
            panel2.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 21);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 12;
            label9.Text = "filmin türünü seçiniz";
            // 
            // comboBoxTur
            // 
            comboBoxTur.FormattingEnabled = true;
            comboBoxTur.Items.AddRange(new object[] { "aksiyon", "anime", "bilim", "dram", "fantastik", "gizem", "komedi", "korku", "muzik", "romantik", "yesil" });
            comboBoxTur.Location = new Point(32, 62);
            comboBoxTur.Name = "comboBoxTur";
            comboBoxTur.Size = new Size(194, 28);
            comboBoxTur.TabIndex = 11;
            comboBoxTur.SelectedIndexChanged += comboBoxTur_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(35, 405);
            button2.Name = "button2";
            button2.Size = new Size(191, 52);
            button2.TabIndex = 10;
            button2.Text = "güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 330);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 9;
            label5.Text = "imbd_rating";
            // 
            // text_box_yıl
            // 
            text_box_yıl.Location = new Point(35, 276);
            text_box_yıl.Mask = "00000";
            text_box_yıl.Name = "text_box_yıl";
            text_box_yıl.Size = new Size(191, 27);
            text_box_yıl.TabIndex = 7;
            text_box_yıl.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 248);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 6;
            label6.Text = "yıl";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 175);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 4;
            label7.Text = "baslik";
            // 
            // text_box_baslik
            // 
            text_box_baslik.Location = new Point(32, 198);
            text_box_baslik.Name = "text_box_baslik";
            text_box_baslik.Size = new Size(194, 27);
            text_box_baslik.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 95);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 1;
            label8.Text = "filmin adını seçiniz";
            // 
            // comboBoxFilm
            // 
            comboBoxFilm.FormattingEnabled = true;
            comboBoxFilm.Location = new Point(32, 136);
            comboBoxFilm.Name = "comboBoxFilm";
            comboBoxFilm.Size = new Size(194, 28);
            comboBoxFilm.TabIndex = 0;
            comboBoxFilm.SelectedIndexChanged += comboBoxFilm_SelectedIndexChanged;
            // 
            // text_box_imdb
            // 
            text_box_imdb.Location = new Point(35, 353);
            text_box_imdb.Mask = "0.0";
            text_box_imdb.Name = "text_box_imdb";
            text_box_imdb.Size = new Size(191, 27);
            text_box_imdb.TabIndex = 13;
            text_box_imdb.ValidatingType = typeof(int);
            // 
            // yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "yonetici";
            Text = "yonetici";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txt_baslik;
        private Button button1;
        private Label label4;
        private MaskedTextBox txt_yil;
        private Panel panel2;
        private Button button2;
        private Label label5;
        private MaskedTextBox text_box_yıl;
        private Label label6;
        private Label label7;
        private TextBox text_box_baslik;
        private Label label8;
        private ComboBox comboBoxFilm;
        private Label label10;
        private Label label9;
        private ComboBox comboBoxTur;
        private MaskedTextBox txt_imdb;
        private MaskedTextBox text_box_imdb;
    }
}