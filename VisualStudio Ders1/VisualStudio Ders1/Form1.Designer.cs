namespace VisualStudio_Ders1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGiris = new Button();
            textBoxMesaj = new TextBox();
            buttonSil = new Button();
            comboBoxİsimler = new ComboBox();
            buttonComboEkle = new Button();
            labelİsim = new Label();
            buttonLabelEkle = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = SystemColors.ButtonFace;
            buttonGiris.ForeColor = SystemColors.ControlText;
            buttonGiris.Location = new Point(21, 54);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(112, 24);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "GİRİŞ";
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // textBoxMesaj
            // 
            textBoxMesaj.Location = new Point(162, 76);
            textBoxMesaj.Name = "textBoxMesaj";
            textBoxMesaj.Size = new Size(148, 23);
            textBoxMesaj.TabIndex = 1;
            textBoxMesaj.TextChanged += textBoxMesaj_TextChanged;
            // 
            // buttonSil
            // 
            buttonSil.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSil.Location = new Point(21, 96);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(112, 23);
            buttonSil.TabIndex = 2;
            buttonSil.Text = "SİL";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // comboBoxİsimler
            // 
            comboBoxİsimler.FormattingEnabled = true;
            comboBoxİsimler.Items.AddRange(new object[] { "Alper ÜZEL ", "Kardelen ÜNAL", "Hasan Hüseyin ALDIVERDİ" });
            comboBoxİsimler.Location = new Point(162, 138);
            comboBoxİsimler.Name = "comboBoxİsimler";
            comboBoxİsimler.Size = new Size(148, 23);
            comboBoxİsimler.TabIndex = 3;
            comboBoxİsimler.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonComboEkle
            // 
            buttonComboEkle.Location = new Point(21, 138);
            buttonComboEkle.Name = "buttonComboEkle";
            buttonComboEkle.Size = new Size(112, 23);
            buttonComboEkle.TabIndex = 4;
            buttonComboEkle.Text = "Comboya Ekle";
            buttonComboEkle.UseVisualStyleBackColor = true;
            buttonComboEkle.Click += button1_Click;
            // 
            // labelİsim
            // 
            labelİsim.AutoSize = true;
            labelİsim.BackColor = SystemColors.ActiveCaptionText;
            labelİsim.ForeColor = SystemColors.ButtonHighlight;
            labelİsim.Location = new Point(162, 188);
            labelİsim.Name = "labelİsim";
            labelİsim.Size = new Size(30, 15);
            labelİsim.TabIndex = 5;
            labelİsim.Text = "İSİM";
            // 
            // buttonLabelEkle
            // 
            buttonLabelEkle.Location = new Point(21, 184);
            buttonLabelEkle.Name = "buttonLabelEkle";
            buttonLabelEkle.Size = new Size(112, 22);
            buttonLabelEkle.TabIndex = 6;
            buttonLabelEkle.Text = "Label Ekle";
            buttonLabelEkle.UseVisualStyleBackColor = true;
            buttonLabelEkle.Click += buttonLabelEkle_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Alper ÜZEL", "Kardelen ÜNAL", "Mustafa Kemal ATATÜRK" });
            listBox1.Location = new Point(94, 242);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(161, 139);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(buttonLabelEkle);
            Controls.Add(labelİsim);
            Controls.Add(buttonComboEkle);
            Controls.Add(comboBoxİsimler);
            Controls.Add(buttonSil);
            Controls.Add(textBoxMesaj);
            Controls.Add(buttonGiris);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGiris;
        private TextBox textBoxMesaj;
        private Button buttonSil;
        private ComboBox comboBoxİsimler;
        private Button buttonComboEkle;
        private Label labelİsim;
        private Button buttonLabelEkle;
        private ListBox listBox1;
    }
}
