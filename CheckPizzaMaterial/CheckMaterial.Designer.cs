namespace CheckPizzaMaterial
{
    partial class CheckMaterial
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
            label1 = new Label();
            lblFiyat = new Label();
            groupBox1 = new GroupBox();
            chkJambon = new CheckBox();
            chkMantar = new CheckBox();
            chkKasar = new CheckBox();
            chkZeytin = new CheckBox();
            chkSucuk = new CheckBox();
            chkMisir = new CheckBox();
            label2 = new Label();
            lblTutar = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 24);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Orta Boy Karışık Pizza";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFiyat
            // 
            lblFiyat.BorderStyle = BorderStyle.FixedSingle;
            lblFiyat.Location = new Point(27, 65);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(296, 98);
            lblFiyat.TabIndex = 1;
            lblFiyat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkJambon);
            groupBox1.Controls.Add(chkMantar);
            groupBox1.Controls.Add(chkKasar);
            groupBox1.Controls.Add(chkZeytin);
            groupBox1.Controls.Add(chkSucuk);
            groupBox1.Controls.Add(chkMisir);
            groupBox1.Location = new Point(27, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 141);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ek Malzemeler";
            // 
            // chkJambon
            // 
            chkJambon.AutoSize = true;
            chkJambon.Location = new Point(152, 102);
            chkJambon.Name = "chkJambon";
            chkJambon.Size = new Size(94, 19);
            chkJambon.TabIndex = 5;
            chkJambon.Text = "Jambon(15₺)";
            chkJambon.UseVisualStyleBackColor = true;
            chkJambon.Click += Hesapla;
            // 
            // chkMantar
            // 
            chkMantar.AutoSize = true;
            chkMantar.Location = new Point(152, 62);
            chkMantar.Name = "chkMantar";
            chkMantar.Size = new Size(84, 19);
            chkMantar.TabIndex = 4;
            chkMantar.Text = "Mantar(8₺)";
            chkMantar.UseVisualStyleBackColor = true;
            chkMantar.Click += Hesapla;
            // 
            // chkKasar
            // 
            chkKasar.AutoSize = true;
            chkKasar.Location = new Point(152, 22);
            chkKasar.Name = "chkKasar";
            chkKasar.Size = new Size(80, 19);
            chkKasar.TabIndex = 3;
            chkKasar.Text = "Kaşar(10₺)";
            chkKasar.UseVisualStyleBackColor = true;
            chkKasar.Click += Hesapla;
            // 
            // chkZeytin
            // 
            chkZeytin.AutoSize = true;
            chkZeytin.Location = new Point(15, 102);
            chkZeytin.Name = "chkZeytin";
            chkZeytin.Size = new Size(79, 19);
            chkZeytin.TabIndex = 2;
            chkZeytin.Text = "Zeytin(8₺)";
            chkZeytin.UseVisualStyleBackColor = true;
            chkZeytin.Click += Hesapla;
            // 
            // chkSucuk
            // 
            chkSucuk.AutoSize = true;
            chkSucuk.Location = new Point(15, 62);
            chkSucuk.Name = "chkSucuk";
            chkSucuk.Size = new Size(84, 19);
            chkSucuk.TabIndex = 1;
            chkSucuk.Text = "Sucuk(15₺)";
            chkSucuk.UseVisualStyleBackColor = true;
            chkSucuk.Click += Hesapla;
            // 
            // chkMisir
            // 
            chkMisir.AutoSize = true;
            chkMisir.Location = new Point(15, 22);
            chkMisir.Name = "chkMisir";
            chkMisir.Size = new Size(78, 19);
            chkMisir.TabIndex = 0;
            chkMisir.Text = "Mısır(10₺)";
            chkMisir.UseVisualStyleBackColor = true;
            chkMisir.Click += Hesapla;
            // 
            // label2
            // 
            label2.Location = new Point(118, 333);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Ödenecek Tutar";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTutar
            // 
            lblTutar.BorderStyle = BorderStyle.FixedSingle;
            lblTutar.Location = new Point(27, 356);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(296, 70);
            lblTutar.TabIndex = 4;
            lblTutar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CheckMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            Controls.Add(lblTutar);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(lblFiyat);
            Controls.Add(label1);
            Name = "CheckMaterial";
            Text = "CheckMaterial";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFiyat;
        private GroupBox groupBox1;
        private CheckBox chkMisir;
        private CheckBox chkJambon;
        private CheckBox chkMantar;
        private CheckBox chkKasar;
        private CheckBox chkZeytin;
        private CheckBox chkSucuk;
        private Label label2;
        private Label lblTutar;
    }
}