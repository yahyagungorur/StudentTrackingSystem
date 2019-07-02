using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTo1
{
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSonuc();
        }
        private void LoadSonuc()
        {
            LinqTODataContext ctx = new LinqTODataContext();

            var sonuc = from ogr in ctx.Ogrencis
                        join vels in ctx.Velis
                        on ogr.VeliID equals vels.VeliId
                        select new
                        {
                            ogr.OgrenciId,
                            ogr.TCKN,
                            ogr.Adi,
                            ogr.Soyadi,
                            ogr.OkulNo,
                            ogr.DogumTarihi,
                            VeliAdı = vels.VAdi
                        };


            dataGridView1.DataSource = sonuc;

            comboBoxVeliID.DisplayMember = "VAdi";
            comboBoxVeliID.ValueMember = "VeliId";

            comboBoxVeliID.DataSource = ctx.Velis;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                LinqTODataContext ctx = new LinqTODataContext();

                Ogrenci ogr = ctx.Ogrencis.FirstOrDefault(t => t.TCKN == textTCKN.Text);

                if (ogr != null)
                    throw new Exception("Aynı tc ile ögrenci mevcut");
                  
                ogr = new Ogrenci();
                ogr.TCKN = textTCKN.Text;
                ogr.Adi = textAdi.Text;
                ogr.Soyadi = textSoyadi.Text;
                ogr.OkulNo = int.Parse(textOkulNo.Text);
                ogr.DogumTarihi = Convert.ToDateTime(dateTimePickerDogumTarihi.Value.Date);
                ogr.VeliID = (int)comboBoxVeliID.SelectedValue;

                ctx.Ogrencis.InsertOnSubmit(ogr);
                ctx.SubmitChanges();
                //dataGridView1.DataSource = ctx.Ogrencis;
                LoadSonuc();
                clear();
                MessageBox.Show("Kayıt Eklenmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !!!");

            }


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int ogrID = (int)dataGridView1.CurrentRow.Cells["OgrenciId"].Value;

            LinqTODataContext ctx = new LinqTODataContext();

            Ogrenci o = ctx.Ogrencis.SingleOrDefault(ogr => ogr.OgrenciId == ogrID);

            ctx.Ogrencis.DeleteOnSubmit(o);
            ctx.SubmitChanges();
            // dataGridView1.DataSource = ctx.Ogrencis;
            LoadSonuc();
            clear();
            MessageBox.Show("Kayıt Silinmiştir.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            LinqTODataContext ctx = new LinqTODataContext();
            int id = (int)textAdi.Tag;

            Ogrenci o = ctx.Ogrencis.SingleOrDefault(x => x.OgrenciId == id);

            o.TCKN = textTCKN.Text;
            o.Adi = textAdi.Text;
            o.Soyadi = textSoyadi.Text;
            o.OkulNo = int.Parse(textOkulNo.Text);
            o.DogumTarihi = Convert.ToDateTime(dateTimePickerDogumTarihi.Value.Date);
            o.VeliID = (int)comboBoxVeliID.SelectedValue;

            ctx.SubmitChanges();

            //dataGridView1.DataSource = ctx.Ogrencis;
            LoadSonuc();
            clear();
            MessageBox.Show("Kayıt Güncellenmiştir.");
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.CurrentRow;
            try
            {
                textTCKN.Text = row.Cells["TCKN"].Value.ToString();
                textAdi.Text = row.Cells["Adi"].Value.ToString();
                textSoyadi.Text = row.Cells["Soyadi"].Value.ToString();
                textOkulNo.Text = row.Cells["OkulNo"].Value.ToString();
                dateTimePickerDogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);
                comboBoxVeliID.SelectedValue = row.Cells["VeliAdı"].Value;
                textAdi.Tag = row.Cells["OgrenciId"].Value;
            }catch
            {

            }
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            LinqTODataContext ctx = new LinqTODataContext();

            dataGridView1.DataSource = ctx.Ogrencis.Where(x => x.TCKN.Contains(textAra.Text));
        }

        private void clear()
        {
            textTCKN.Text = "";
            textAdi.Text = "";
            textSoyadi.Text = "";
            textOkulNo.Text = "";
            dateTimePickerDogumTarihi.Value = DateTime.Today;

        }

        private void btngecis_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }
    }
}
