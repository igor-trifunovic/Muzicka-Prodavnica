using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzickaProdavnica
{
    public partial class Form3 : Form
    {
        SqlCommand komanda;
        SqlConnection konekcija = new SqlConnection(Konekcija.konekcioniString);

        public Form3()
        {
            InitializeComponent();
        }

        private void reset()
        {
            tbIDIzdanja.Text = "";
            cmbTipIzdanja.SelectedIndex = -1;
            tbIzvodjac.Text = "";
            tbAlbum.Text = "";
            cmbZanr.SelectedIndex = -1;
            cmbIzdavac.SelectedIndex = -1;
            tbGodina.Text = "";
            cmbDrzava.SelectedIndex = -1;
            tbCena.Text = "";
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (tbIDIzdanja.Text != "" && tbIzvodjac.Text != "" && tbAlbum.Text != "" &&
                tbGodina.Text != "" && tbCena.Text != "")
            {
                try
                {
                    komanda = new SqlCommand("INSERT INTO Izdanje(IzdanjeID, TipIzdanja, Izvodjac, Album, Zanr, Godina, Izdavac, Drzava, Cena) " +
                                         "VALUES (@IzdanjeID, @TipIzdanja, @Izvodjac, @Album, @Zanr, @Godina, @Izdavac, @Drzava, @Cena)", konekcija);
                    konekcija.Open();
                    komanda.Parameters.AddWithValue("@IzdanjeID", tbIDIzdanja.Text);
                    komanda.Parameters.AddWithValue("@TipIzdanja", cmbTipIzdanja.SelectedValue.ToString());
                    komanda.Parameters.AddWithValue("@Izvodjac", tbIzvodjac.Text);
                    komanda.Parameters.AddWithValue("@Album", tbAlbum.Text);
                    komanda.Parameters.AddWithValue("@Zanr", cmbZanr.SelectedValue.ToString());
                    komanda.Parameters.AddWithValue("@Godina", tbGodina.Text);
                    komanda.Parameters.AddWithValue("@Izdavac", cmbIzdavac.SelectedValue.ToString());
                    komanda.Parameters.AddWithValue("@Drzava", cmbDrzava.SelectedValue.ToString());
                    komanda.Parameters.AddWithValue("@Cena", tbCena.Text);

                    komanda.ExecuteReader();
                    MessageBox.Show("Uspešno ste uneli podatke u bazu.");
                    reset();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    konekcija.Close();
                    Close();
                }
            }
            else { MessageBox.Show("Niste uneli sve potrebne podatke."); }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.Drzava' table. You can move, or remove it, as needed.
            this.drzavaTableAdapter.Fill(this.muzickaProdavnicaDataSet.Drzava);
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.Izdavac' table. You can move, or remove it, as needed.
            this.izdavacTableAdapter.Fill(this.muzickaProdavnicaDataSet.Izdavac);
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.Zanr' table. You can move, or remove it, as needed.
            this.zanrTableAdapter.Fill(this.muzickaProdavnicaDataSet.Zanr);
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.TipIzdanja' table. You can move, or remove it, as needed.
            this.tipIzdanjaTableAdapter.Fill(this.muzickaProdavnicaDataSet.TipIzdanja);

            cmbTipIzdanja.SelectedIndex = -1;
            cmbIzdavac.SelectedIndex = -1;
            cmbZanr.SelectedIndex = -1;
            cmbDrzava.SelectedIndex = -1;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
