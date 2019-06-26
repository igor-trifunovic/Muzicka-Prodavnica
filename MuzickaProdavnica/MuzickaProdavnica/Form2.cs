using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using MuzickaProdavnica.MuzickaProdavnicaDataSetTableAdapters;

namespace MuzickaProdavnica
{
    public partial class Form2 : Form
    {
        MuzickaProdavnicaDataSet ds = new MuzickaProdavnicaDataSet();
        SqlConnection conn = new SqlConnection(Konekcija.konekcioniString);
        SqlDataAdapter sda;

        public Form2()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM Izdanje", conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            AlbumYearCount();
        }

        //Metoda koja pokazuje broj albuma izdatih pre 1990.godine
        private void AlbumYearCount()
        {
            DataSet ds = new DataSet();

            try
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Izdanje WHERE Godina<1990", conn);
                tbAlbumiPre1990.Text = cmd1.ExecuteScalar().ToString();

                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.Drzava' table. You can move, or remove it, as needed.
            this.drzavaTableAdapter.Fill(this.muzickaProdavnicaDataSet.Drzava);
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.Izdavac' table. You can move, or remove it, as needed.
            this.izdavacTableAdapter.Fill(this.muzickaProdavnicaDataSet.Izdavac);
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.Zanr' table. You can move, or remove it, as needed.
            this.zanrTableAdapter.Fill(this.muzickaProdavnicaDataSet.Zanr);
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.TipIzdanja' table. You can move, or remove it, as needed.
            this.tipIzdanjaTableAdapter.Fill(this.muzickaProdavnicaDataSet.TipIzdanja);
            // TODO: This line of code loads data into the 'muzickaProdavnicaDataSet.Izdanje' table. You can move, or remove it, as needed.
            this.izdanjeTableAdapter.Fill(this.muzickaProdavnicaDataSet.Izdanje);
            AlbumYearCount();
            IzdanjeTableAdapter ta = new IzdanjeTableAdapter();
            ta.Fill(ds.Izdanje);
            dataGridView1.DataSource = ds.Izdanje;
        }

        //Brisanje izdanja
        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbObrisiIzdanje.Text))
                {
                    int number = 0;
                    bool isNumber = int.TryParse(tbObrisiIzdanje.Text, out number);

                    if (isNumber)
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM Izdanje WHERE IzdanjeID = @izdanjeID", conn);
                        cmd.Parameters.AddWithValue("@izdanjeID", tbObrisiIzdanje.Text);
                        cmd.ExecuteNonQuery();

                        izdanjeTableAdapter.Fill(muzickaProdavnicaDataSet.Izdanje);
                        tbObrisiIzdanje.Clear();
                        richTextBox1.Clear();

                        MessageBox.Show("Izdanje uspešno obrisano.");
                    }
                    else { MessageBox.Show("Morate uneti broj."); }
                }
                else { MessageBox.Show("Morate uneti ID izdanja."); }

                conn.Close();
                AlbumYearCount();
                DisplayData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        //Prikaz liste izdanja snimljenih pre 1990.godine
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Izvodjac, Album, Godina FROM Izdanje WHERE Godina<1990", conn);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox1.AppendText(sdr[0].ToString() + ", " + sdr[1].ToString() + 
                        ", " + sdr[2].ToString() + "\n");
                }

                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void unosNovogIzdanjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btnKupi_Click_1(object sender, EventArgs e)
        {
            string putanja = @"C:\Temp\Kupljeni proizvodi.txt";

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Izvodjac, Album, Godina, Cena FROM Izdanje " +
                    "WHERE IzdanjeID = @izdanjeID", conn);
                cmd.Parameters.AddWithValue("@izdanjeID", tbKupi.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    string fileContents = reader[0].ToString() + " " + reader[1].ToString() + " " +
                    reader[2].ToString() + " " + reader[3].ToString() + "\n";
                    File.AppendAllText(putanja, fileContents);
                }

                MessageBox.Show("Proizvod kupljen.");

                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}