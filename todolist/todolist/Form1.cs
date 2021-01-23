using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace todolist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sqlbaglantisi bag = new sqlbaglantisi();
        DataTable dt = new DataTable();

        void doldur()
        {
            try
            {
            
                dt.Clear();
                SqlDataAdapter listele = new SqlDataAdapter("select * from yapilacaklarListesi order by id desc", bag.baglan());
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 190;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;
           
              
                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "Görev Önceliği";
                comboBox2.Text = "Görev Önceliği Seçiniz";
                comboBox3.Text = "Görev Durumu Seçiniz";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into yapilacaklarListesi(gorevBaslik,gorev,gorevOncelik,gorevTarihi,gorevDurumu) values('" + textBox1.Text + "','" + richTextBox1.Text + "','" +comboBox2.Text + "','" + dateTimePicker3.Value.ToShortDateString() + "','" + comboBox3.Text + "')", bag.baglan());
                //
                // 
            

                komut.ExecuteNonQuery();
                MessageBox.Show("Görev Ekleme İşleminiz Başarılı");
  
             

                doldur();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                dt.Clear();
                SqlDataAdapter listele = new SqlDataAdapter("select * from yapilacaklarListesi where gorevTarihi='" + DateTime.Now.ToShortDateString()+"'", bag.baglan());
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 190;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;


                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "Görev Önceliği";
                comboBox2.Text = "Görev Önceliği Seçiniz";
                comboBox3.Text = "Görev Durumu Seçiniz";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Today;
            DateTime bitis = DateTime.Today;
            DateTime baslangicAy = DateTime.Today;
            DateTime bitisAy = DateTime.Today;
            DateTime d = DateTime.Today;

            baslangic = d.AddDays(-(int)d.DayOfWeek + 1);
            bitis = d.AddDays(-(int)d.DayOfWeek + 7);
            baslangicAy = new DateTime(d.Year, d.Month, 1);
            bitisAy = new DateTime(d.Year, d.Month, 1).AddMonths(1);

            try
            {
               
                dt.Clear();
                SqlDataAdapter listele = new SqlDataAdapter("select * from yapilacaklarListesi where gorevTarihi >='" + baslangic + "' and gorevTarihi<='"+ bitis + "'", bag.baglan());
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 190;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;


                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "Görev Önceliği";
                comboBox2.Text = "Görev Önceliği Seçiniz";
                comboBox3.Text = "Görev Durumu Seçiniz";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
              

                dt.Clear();
                SqlDataAdapter listele = new SqlDataAdapter("select * from yapilacaklarListesi where gorevTarihi between '" + dateTimePicker1.Value+ "' and '"+ dateTimePicker2.Value+ "'  ", bag.baglan());
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 190;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;


                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "Görev Önceliği";
                comboBox2.Text = "Görev Önceliği Seçiniz";
                comboBox3.Text = "Görev Durumu Seçiniz";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                dt.Clear();
                SqlDataAdapter listele = new SqlDataAdapter("select * from yapilacaklarListesi where year(gorevTarihi)='"+DateTime.Now.Year+"'", bag.baglan());
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 190;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;


                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "Görev Önceliği";
                comboBox2.Text = "Görev Önceliği Seçiniz";
                comboBox3.Text = "Görev Durumu Seçiniz";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                dt.Clear();
                SqlDataAdapter listele = new SqlDataAdapter("select * from yapilacaklarListesi where gorevOncelik='"+comboBox1.Text+"'", bag.baglan());
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 190;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;


                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "Görev Önceliği";
                comboBox2.Text = "Görev Önceliği Seçiniz";
                comboBox3.Text = "Görev Durumu Seçiniz";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                dt.Clear();
                SqlDataAdapter listele = new SqlDataAdapter("select * from yapilacaklarListesi where gorevDurumu='" + comboBox4.Text + "'", bag.baglan());
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 190;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;


                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "Görev Önceliği";
                comboBox2.Text = "Görev Önceliği Seçiniz";
                comboBox3.Text = "Görev Durumu Seçiniz";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                try
                {

               
                    SqlCommand sil = new SqlCommand("delete from yapilacaklarListesi where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag.baglan());
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Silme İşleminiz Başarılı");
                    doldur();
                 

                }
                catch
                {

                    ;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker3.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // SqlCommand komut = new SqlCommand("insert into yapilacaklarListesi(gorevBaslik,gorev,gorevOncelik,gorevTarihi,gorevDurumu) values('" + textBox1.Text + "','" + richTextBox1.Text + "','" +comboBox2.Text + "','" + dateTimePicker3.Value.ToShortDateString() + "','" + comboBox3.Text + "')", bag.baglan());


            SqlCommand komut = new SqlCommand("update yapilacaklarListesi set gorevBaslik='" + textBox1.Text + "',gorev='" + richTextBox1.Text + "',gorevOncelik='" + comboBox2.Text + "',gorevTarihi='" + dateTimePicker3.Value.ToShortDateString() + "',gorevDurumu='" + comboBox3.Text + "' where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag.baglan());
            komut.ExecuteNonQuery();
            

            MessageBox.Show("Güncelleme İşlemi Başarılı");
            doldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("update yapilacaklarListesi set gorevDurumu='" + "Bitti" + "' where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag.baglan());
            komut.ExecuteNonQuery();


            MessageBox.Show("Görev Başarıyla Tamamlandı !");
            doldur();
        }
    }
}
