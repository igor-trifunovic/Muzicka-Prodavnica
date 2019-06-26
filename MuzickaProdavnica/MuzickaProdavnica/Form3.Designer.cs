namespace MuzickaProdavnica
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.cmbIzdavac = new System.Windows.Forms.ComboBox();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.cmbTipIzdanja = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGodina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbIzvodjac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDIzdanja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.muzickaProdavnicaDataSet = new MuzickaProdavnica.MuzickaProdavnicaDataSet();
            this.tipIzdanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipIzdanjaTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.TipIzdanjaTableAdapter();
            this.zanrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zanrTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.ZanrTableAdapter();
            this.izdavacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdavacTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.IzdavacTableAdapter();
            this.drzavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drzavaTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.DrzavaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muzickaProdavnicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIzdanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.DataSource = this.drzavaBindingSource;
            this.cmbDrzava.DisplayMember = "NazivDrzave";
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(120, 314);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(121, 21);
            this.cmbDrzava.TabIndex = 66;
            this.cmbDrzava.ValueMember = "DrzavaID";
            // 
            // cmbIzdavac
            // 
            this.cmbIzdavac.DataSource = this.izdavacBindingSource;
            this.cmbIzdavac.DisplayMember = "NazivIzdavaca";
            this.cmbIzdavac.FormattingEnabled = true;
            this.cmbIzdavac.Location = new System.Drawing.Point(120, 276);
            this.cmbIzdavac.Name = "cmbIzdavac";
            this.cmbIzdavac.Size = new System.Drawing.Size(121, 21);
            this.cmbIzdavac.TabIndex = 65;
            this.cmbIzdavac.ValueMember = "IzdavacID";
            // 
            // cmbZanr
            // 
            this.cmbZanr.DataSource = this.zanrBindingSource;
            this.cmbZanr.DisplayMember = "NazivZanra";
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(120, 203);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(121, 21);
            this.cmbZanr.TabIndex = 64;
            this.cmbZanr.ValueMember = "ZanrID";
            // 
            // cmbTipIzdanja
            // 
            this.cmbTipIzdanja.DataSource = this.tipIzdanjaBindingSource;
            this.cmbTipIzdanja.DisplayMember = "NazivTipa";
            this.cmbTipIzdanja.FormattingEnabled = true;
            this.cmbTipIzdanja.Location = new System.Drawing.Point(120, 97);
            this.cmbTipIzdanja.Name = "cmbTipIzdanja";
            this.cmbTipIzdanja.Size = new System.Drawing.Size(121, 21);
            this.cmbTipIzdanja.TabIndex = 63;
            this.cmbTipIzdanja.ValueMember = "TipIzdanjaID";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(170, 407);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 62;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(63, 407);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 61;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(120, 350);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(51, 20);
            this.tbCena.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Cena";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Država";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Izdavač";
            // 
            // tbGodina
            // 
            this.tbGodina.Location = new System.Drawing.Point(120, 240);
            this.tbGodina.Name = "tbGodina";
            this.tbGodina.Size = new System.Drawing.Size(51, 20);
            this.tbGodina.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Godina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Žanr";
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(120, 170);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(121, 20);
            this.tbAlbum.TabIndex = 53;
            // 
            // tbIzvodjac
            // 
            this.tbIzvodjac.Location = new System.Drawing.Point(120, 134);
            this.tbIzvodjac.Name = "tbIzvodjac";
            this.tbIzvodjac.Size = new System.Drawing.Size(121, 20);
            this.tbIzvodjac.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Izvođač";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tip izdanja";
            // 
            // tbIDIzdanja
            // 
            this.tbIDIzdanja.Location = new System.Drawing.Point(120, 62);
            this.tbIDIzdanja.Name = "tbIDIzdanja";
            this.tbIDIzdanja.Size = new System.Drawing.Size(65, 20);
            this.tbIDIzdanja.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "ID izdanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "FORMA ZA UNOS NOVOG IZDANJA";
            // 
            // muzickaProdavnicaDataSet
            // 
            this.muzickaProdavnicaDataSet.DataSetName = "MuzickaProdavnicaDataSet";
            this.muzickaProdavnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipIzdanjaBindingSource
            // 
            this.tipIzdanjaBindingSource.DataMember = "TipIzdanja";
            this.tipIzdanjaBindingSource.DataSource = this.muzickaProdavnicaDataSet;
            // 
            // tipIzdanjaTableAdapter
            // 
            this.tipIzdanjaTableAdapter.ClearBeforeFill = true;
            // 
            // zanrBindingSource
            // 
            this.zanrBindingSource.DataMember = "Zanr";
            this.zanrBindingSource.DataSource = this.muzickaProdavnicaDataSet;
            // 
            // zanrTableAdapter
            // 
            this.zanrTableAdapter.ClearBeforeFill = true;
            // 
            // izdavacBindingSource
            // 
            this.izdavacBindingSource.DataMember = "Izdavac";
            this.izdavacBindingSource.DataSource = this.muzickaProdavnicaDataSet;
            // 
            // izdavacTableAdapter
            // 
            this.izdavacTableAdapter.ClearBeforeFill = true;
            // 
            // drzavaBindingSource
            // 
            this.drzavaBindingSource.DataMember = "Drzava";
            this.drzavaBindingSource.DataSource = this.muzickaProdavnicaDataSet;
            // 
            // drzavaTableAdapter
            // 
            this.drzavaTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.cmbIzdavac);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.cmbTipIzdanja);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbGodina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.tbIzvodjac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIDIzdanja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muzickaProdavnicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIzdanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.ComboBox cmbIzdavac;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.ComboBox cmbTipIzdanja;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGodina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbIzvodjac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDIzdanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MuzickaProdavnicaDataSet muzickaProdavnicaDataSet;
        private System.Windows.Forms.BindingSource tipIzdanjaBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.TipIzdanjaTableAdapter tipIzdanjaTableAdapter;
        private System.Windows.Forms.BindingSource zanrBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.ZanrTableAdapter zanrTableAdapter;
        private System.Windows.Forms.BindingSource izdavacBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.IzdavacTableAdapter izdavacTableAdapter;
        private System.Windows.Forms.BindingSource drzavaBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.DrzavaTableAdapter drzavaTableAdapter;
    }
}