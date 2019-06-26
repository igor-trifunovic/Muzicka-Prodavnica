namespace MuzickaProdavnica
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosNovogIzdanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogIzdanjaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAlbumiPre1990 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObrisiIzdanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.muzickaProdavnicaDataSet = new MuzickaProdavnica.MuzickaProdavnicaDataSet();
            this.izdanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdanjeTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.IzdanjeTableAdapter();
            this.tipIzdanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipIzdanjaTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.TipIzdanjaTableAdapter();
            this.zanrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zanrTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.ZanrTableAdapter();
            this.izdanjeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.izdavacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdavacTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.IzdavacTableAdapter();
            this.drzavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drzavaTableAdapter = new MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters.DrzavaTableAdapter();
            this.izdanjeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipIzdanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.izvodjacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKupi = new System.Windows.Forms.Button();
            this.tbKupi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzickaProdavnicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIzdanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdanjeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogIzdanjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosNovogIzdanjaToolStripMenuItem
            // 
            this.unosNovogIzdanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogIzdanjaToolStripMenuItem1});
            this.unosNovogIzdanjaToolStripMenuItem.Name = "unosNovogIzdanjaToolStripMenuItem";
            this.unosNovogIzdanjaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.unosNovogIzdanjaToolStripMenuItem.Text = "Izdanja";
            // 
            // unosNovogIzdanjaToolStripMenuItem1
            // 
            this.unosNovogIzdanjaToolStripMenuItem1.Name = "unosNovogIzdanjaToolStripMenuItem1";
            this.unosNovogIzdanjaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.unosNovogIzdanjaToolStripMenuItem1.Text = "Unos novog izdanja";
            this.unosNovogIzdanjaToolStripMenuItem1.Click += new System.EventHandler(this.unosNovogIzdanjaToolStripMenuItem1_Click);
            // 
            // tbAlbumiPre1990
            // 
            this.tbAlbumiPre1990.Location = new System.Drawing.Point(229, 343);
            this.tbAlbumiPre1990.Name = "tbAlbumiPre1990";
            this.tbAlbumiPre1990.Size = new System.Drawing.Size(32, 20);
            this.tbAlbumiPre1990.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj albuma izdatih pre 1990.godine";
            // 
            // tbObrisiIzdanje
            // 
            this.tbObrisiIzdanje.Location = new System.Drawing.Point(706, 300);
            this.tbObrisiIzdanje.Name = "tbObrisiIzdanje";
            this.tbObrisiIzdanje.Size = new System.Drawing.Size(61, 20);
            this.tbObrisiIzdanje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesi ID izdanja za brisanje";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(625, 341);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "&Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ovde možete videti listu svih muzičkih izdanja.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(292, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 117);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(339, 423);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(138, 23);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.Text = "&Albumi snimljeni pre 1990";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.izdanjeIDDataGridViewTextBoxColumn,
            this.tipIzdanjaDataGridViewTextBoxColumn,
            this.izvodjacDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.izdavacDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.izdanjeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 198);
            this.dataGridView1.TabIndex = 10;
            // 
            // muzickaProdavnicaDataSet
            // 
            this.muzickaProdavnicaDataSet.DataSetName = "MuzickaProdavnicaDataSet";
            this.muzickaProdavnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdanjeBindingSource
            // 
            this.izdanjeBindingSource.DataMember = "Izdanje";
            this.izdanjeBindingSource.DataSource = this.muzickaProdavnicaDataSet;
            // 
            // izdanjeTableAdapter
            // 
            this.izdanjeTableAdapter.ClearBeforeFill = true;
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
            // izdanjeBindingSource1
            // 
            this.izdanjeBindingSource1.DataMember = "Izdanje";
            this.izdanjeBindingSource1.DataSource = this.muzickaProdavnicaDataSet;
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
            // izdanjeIDDataGridViewTextBoxColumn
            // 
            this.izdanjeIDDataGridViewTextBoxColumn.DataPropertyName = "IzdanjeID";
            this.izdanjeIDDataGridViewTextBoxColumn.HeaderText = "IzdanjeID";
            this.izdanjeIDDataGridViewTextBoxColumn.Name = "izdanjeIDDataGridViewTextBoxColumn";
            // 
            // tipIzdanjaDataGridViewTextBoxColumn
            // 
            this.tipIzdanjaDataGridViewTextBoxColumn.DataPropertyName = "TipIzdanja";
            this.tipIzdanjaDataGridViewTextBoxColumn.DataSource = this.tipIzdanjaBindingSource;
            this.tipIzdanjaDataGridViewTextBoxColumn.DisplayMember = "NazivTipa";
            this.tipIzdanjaDataGridViewTextBoxColumn.HeaderText = "TipIzdanja";
            this.tipIzdanjaDataGridViewTextBoxColumn.Name = "tipIzdanjaDataGridViewTextBoxColumn";
            this.tipIzdanjaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipIzdanjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipIzdanjaDataGridViewTextBoxColumn.ValueMember = "TipIzdanjaID";
            // 
            // izvodjacDataGridViewTextBoxColumn
            // 
            this.izvodjacDataGridViewTextBoxColumn.DataPropertyName = "Izvodjac";
            this.izvodjacDataGridViewTextBoxColumn.HeaderText = "Izvodjac";
            this.izvodjacDataGridViewTextBoxColumn.Name = "izvodjacDataGridViewTextBoxColumn";
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "Zanr";
            this.zanrDataGridViewTextBoxColumn.DataSource = this.zanrBindingSource;
            this.zanrDataGridViewTextBoxColumn.DisplayMember = "NazivZanra";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Zanr";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            this.zanrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zanrDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zanrDataGridViewTextBoxColumn.ValueMember = "ZanrID";
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "Godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "Godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            // 
            // izdavacDataGridViewTextBoxColumn
            // 
            this.izdavacDataGridViewTextBoxColumn.DataPropertyName = "Izdavac";
            this.izdavacDataGridViewTextBoxColumn.DataSource = this.izdavacBindingSource;
            this.izdavacDataGridViewTextBoxColumn.DisplayMember = "NazivIzdavaca";
            this.izdavacDataGridViewTextBoxColumn.HeaderText = "Izdavac";
            this.izdavacDataGridViewTextBoxColumn.Name = "izdavacDataGridViewTextBoxColumn";
            this.izdavacDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.izdavacDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.izdavacDataGridViewTextBoxColumn.ValueMember = "IzdavacID";
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.DataSource = this.drzavaBindingSource;
            this.drzavaDataGridViewTextBoxColumn.DisplayMember = "NazivDrzave";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.drzavaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.drzavaDataGridViewTextBoxColumn.ValueMember = "DrzavaID";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(625, 423);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(75, 23);
            this.btnKupi.TabIndex = 11;
            this.btnKupi.Text = "&Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click_1);
            // 
            // tbKupi
            // 
            this.tbKupi.Location = new System.Drawing.Point(706, 384);
            this.tbKupi.Name = "tbKupi";
            this.tbKupi.Size = new System.Drawing.Size(61, 20);
            this.tbKupi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Unesi ID izdanja za kupovinu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKupi);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbObrisiIzdanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAlbumiPre1990);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzickaProdavnicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipIzdanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdanjeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosNovogIzdanjaToolStripMenuItem;
        private System.Windows.Forms.TextBox tbAlbumiPre1990;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObrisiIzdanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ToolStripMenuItem unosNovogIzdanjaToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MuzickaProdavnicaDataSet muzickaProdavnicaDataSet;
        private System.Windows.Forms.BindingSource izdanjeBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.IzdanjeTableAdapter izdanjeTableAdapter;
        private System.Windows.Forms.BindingSource tipIzdanjaBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.TipIzdanjaTableAdapter tipIzdanjaTableAdapter;
        private System.Windows.Forms.BindingSource zanrBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.ZanrTableAdapter zanrTableAdapter;
        private System.Windows.Forms.BindingSource izdanjeBindingSource1;
        private System.Windows.Forms.BindingSource izdavacBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.IzdavacTableAdapter izdavacTableAdapter;
        private System.Windows.Forms.BindingSource drzavaBindingSource;
        private MuzickaProdavnicaDataSetTableAdapters.DrzavaTableAdapter drzavaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdanjeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipIzdanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvodjacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn izdavacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.TextBox tbKupi;
        private System.Windows.Forms.Label label4;
    }
}