namespace Studenti
{
    partial class formaUnosNovogStudenta
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.comboBoxSmjer = new System.Windows.Forms.ComboBox();
            this.labelSmjer = new System.Windows.Forms.Label();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.labelIndeks = new System.Windows.Forms.Label();
            this.textBoxBrojIndeksa = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.labelDatumRodjenja = new System.Windows.Forms.Label();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(25, 41);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(208, 20);
            this.textBoxIme.TabIndex = 0;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIme_TextChanged);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(22, 25);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime:";
            this.labelIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(22, 90);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(47, 13);
            this.labelPrezime.TabIndex = 3;
            this.labelPrezime.Text = "Prezime:";
            this.labelPrezime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(25, 106);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(208, 20);
            this.textBoxPrezime.TabIndex = 2;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxSmjer
            // 
            this.comboBoxSmjer.FormattingEnabled = true;
            this.comboBoxSmjer.Items.AddRange(new object[] {
            "Programmer",
            "System Administrator",
            "Mrezni Administrator"});
            this.comboBoxSmjer.Location = new System.Drawing.Point(25, 173);
            this.comboBoxSmjer.Name = "comboBoxSmjer";
            this.comboBoxSmjer.Size = new System.Drawing.Size(208, 21);
            this.comboBoxSmjer.TabIndex = 4;
            this.comboBoxSmjer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSmjer_SelectedIndexChanged);
            // 
            // labelSmjer
            // 
            this.labelSmjer.AutoSize = true;
            this.labelSmjer.Location = new System.Drawing.Point(22, 157);
            this.labelSmjer.Name = "labelSmjer";
            this.labelSmjer.Size = new System.Drawing.Size(36, 13);
            this.labelSmjer.TabIndex = 5;
            this.labelSmjer.Text = "Smjer:";
            this.labelSmjer.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(25, 234);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(75, 23);
            this.buttonSnimi.TabIndex = 6;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelIndeks
            // 
            this.labelIndeks.AutoSize = true;
            this.labelIndeks.Location = new System.Drawing.Point(286, 25);
            this.labelIndeks.Name = "labelIndeks";
            this.labelIndeks.Size = new System.Drawing.Size(68, 13);
            this.labelIndeks.TabIndex = 8;
            this.labelIndeks.Text = "Broj indeksa:";
            this.labelIndeks.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // textBoxBrojIndeksa
            // 
            this.textBoxBrojIndeksa.Location = new System.Drawing.Point(289, 41);
            this.textBoxBrojIndeksa.Name = "textBoxBrojIndeksa";
            this.textBoxBrojIndeksa.Size = new System.Drawing.Size(208, 20);
            this.textBoxBrojIndeksa.TabIndex = 7;
            this.textBoxBrojIndeksa.TextChanged += new System.EventHandler(this.textBoxBrojIndeksa_TextChanged);
            // 
            // dateTimePickerDatumRodjenja
            // 
            this.dateTimePickerDatumRodjenja.Location = new System.Drawing.Point(289, 106);
            this.dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            this.dateTimePickerDatumRodjenja.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerDatumRodjenja.TabIndex = 9;
            this.dateTimePickerDatumRodjenja.ValueChanged += new System.EventHandler(this.dateTimePickerDatumRodjenja_ValueChanged);
            // 
            // labelDatumRodjenja
            // 
            this.labelDatumRodjenja.AutoSize = true;
            this.labelDatumRodjenja.Location = new System.Drawing.Point(289, 90);
            this.labelDatumRodjenja.Name = "labelDatumRodjenja";
            this.labelDatumRodjenja.Size = new System.Drawing.Size(81, 13);
            this.labelDatumRodjenja.TabIndex = 10;
            this.labelDatumRodjenja.Text = "Datum rodjenja:";
            this.labelDatumRodjenja.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(422, 234);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(75, 23);
            this.buttonOtkazi.TabIndex = 11;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // formaUnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 286);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.labelDatumRodjenja);
            this.Controls.Add(this.dateTimePickerDatumRodjenja);
            this.Controls.Add(this.labelIndeks);
            this.Controls.Add(this.textBoxBrojIndeksa);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.labelSmjer);
            this.Controls.Add(this.comboBoxSmjer);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.textBoxIme);
            this.Name = "formaUnosNovogStudenta";
            this.Text = "Unos novog studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.ComboBox comboBoxSmjer;
        private System.Windows.Forms.Label labelSmjer;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Label labelIndeks;
        private System.Windows.Forms.TextBox textBoxBrojIndeksa;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodjenja;
        private System.Windows.Forms.Label labelDatumRodjenja;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}