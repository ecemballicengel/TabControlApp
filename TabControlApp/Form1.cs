﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlApp
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Server=LAPTOP-KF9LJ1A9\\SQLEXPRESS;Database=DB_NOTLAR;Trusted_Connection=True;";
        SqlConnection con = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
            RefreshDataOgrenciler();
            RefreshDataDersler();
        }

        public void RefreshDataOgrenciler()
        {

            string query = "SELECT * FROM Ogrenciler";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewOgrenciler.DataSource = dt;
            for (int i = 0; i < dataGridViewOgrenciler.Columns.Count; i++)
            {
                dataGridViewOgrenciler.Columns[i].ReadOnly = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Ogrenciler(Ad, Soyad, DogumTarihi) VALUES(@Ad, @Soyad, @DogumTarihi)", con);
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshDataOgrenciler();
                MessageBox.Show("Kullanici Basarili Bir Sekilde Eklendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir Hata OLustu!", ex.ToString());
            }
        }

        private void dataGridViewOgrenciler_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciler != null)
            {
                txtAd.Text = dataGridViewOgrenciler.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridViewOgrenciler.CurrentRow.Cells[2].Value.ToString();

                if (dataGridViewOgrenciler.CurrentRow.Cells[3].Value != null && dataGridViewOgrenciler.CurrentRow.Cells[3].Value != DBNull.Value)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridViewOgrenciler.CurrentRow.Cells[3].Value);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciler.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Ogrenciler SET Ad=@Ad, Soyad=@Soyad, DogumTarihi=@DogumTarihi WHERE OgrenciID = @OgrenciID", con);
                cmd.Parameters.AddWithValue("@OgrenciID", Convert.ToInt32(dataGridViewOgrenciler.CurrentRow.Cells[0].Value));
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    RefreshDataOgrenciler();
                    MessageBox.Show("Kullanici Basarili Bir Sekilde Eklendi.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bir Hata OLustu!", ex.ToString());
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciler.CurrentRow != null)
            {
                if (MessageBox.Show("Bu öğrenciyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Ogrenciler WHERE OgrenciID = @OgrenciID", con);
                    cmd.Parameters.AddWithValue("@OgrenciID", Convert.ToInt32(dataGridViewOgrenciler.CurrentRow.Cells[0].Value));
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        RefreshDataOgrenciler();
                        MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Silindi");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir Hata Oluştu", ex.ToString());
                    }
                }
            }
        }

        public void RefreshDataDersler()
        {
            string query = "SELECT * FROM Dersler";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDersler.DataSource = dt;
            for (int i = 0; i < dataGridViewDersler.Columns.Count; i++)
            {
                dataGridViewDersler.Columns[i].ReadOnly = true;
            }
        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Dersler(DersAdi, DersKodu) VALUES(@DersAdi, @DersKodu)", con);
            cmd.Parameters.AddWithValue("@DersAdi", txtDersAdi.Text);
            cmd.Parameters.AddWithValue("@DersKodu", txtDersKodu.Text);
            

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshDataDersler();
                MessageBox.Show("Ders Basarili Bir Sekilde Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata OLustu!", ex.ToString());
            }
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Dersler SET DersAdi=@DersAdi, DersKodu=@DersKodu WHERE DersID=@DersID", con);
            cmd.Parameters.AddWithValue("@DersID", Convert.ToInt32(dataGridViewDersler.CurrentRow.Cells[0].Value));
            cmd.Parameters.AddWithValue("@DersAdi", txtDersAdi.Text);
            cmd.Parameters.AddWithValue("@DersKodu", txtDersKodu.Text);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshDataDersler();
                MessageBox.Show("Ders Basarili Bir Sekilde Guncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata OLustu!", ex.ToString());
            }
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            if (dataGridViewDersler.CurrentRow != null)
            {
                if (MessageBox.Show("Bu Dersi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Dersler WHERE DersID = @DersID", con);
                    cmd.Parameters.AddWithValue("@DersID", Convert.ToInt32(dataGridViewDersler.CurrentRow.Cells[0].Value));
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        RefreshDataDersler();
                        MessageBox.Show("Ders Başarılı Bir Şekilde Silindi");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir Hata Oluştu", ex.ToString());
                    }
                }
            }
        }

      
    }
}
