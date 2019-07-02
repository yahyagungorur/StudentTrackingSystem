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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void LoadSonuc()
        {
            LinqTODataContext ctx = new LinqTODataContext();

            var tablo = from ogrt in ctx.Ogretmens
                        join drs in ctx.Ders
                        on ogrt.DersID equals drs.DersId
                        select new
                        {
                            ogrt.OgretmenId,
                            ogrt.Adi,
                            ogrt.Soyadi,
                            ogrt.DogumTarihi,
                            ogrt.AktifMi,
                            DersAdi = drs.Adi
                        };
            dataGridView1.DataSource = tablo;
            comboBoxDersAdi.DisplayMember = "Adi";
            comboBoxDersAdi.ValueMember = "DersId";
            comboBoxDersAdi.DataSource = ctx.Ders;

        }

        private void Clear()
        {
            textAdi.Text = "";
            textSoyadi.Text = "";
            dateTimePickerDogumTarihi.Value = DateTime.Today;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            LoadSonuc();
        }
     
        private void btnEkle_Click(object sender, EventArgs e)
        {
            LinqTODataContext ctx = new LinqTODataContext();

            Ogretmen ogrt = new Ogretmen();

            ogrt.Adi = textAdi.Text;
            ogrt.Soyadi = textSoyadi.Text;
            ogrt.DogumTarihi = Convert.ToDateTime(dateTimePickerDogumTarihi.Value.Date);
            ogrt.DersID = (int)comboBoxDersAdi.SelectedValue;
            ogrt.AktifMi = checkBoxAktifMi.Checked;

            ctx.Ogretmens.InsertOnSubmit(ogrt);
            ctx.SubmitChanges();
            LoadSonuc();
            Clear();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;

            int ogrtID = (int)dataGridView1.CurrentRow.Cells["OgretmenId"].Value;

            LinqTODataContext ctx = new LinqTODataContext();

            Ogretmen ogrt = ctx.Ogretmens.SingleOrDefault(og => og.OgretmenId == ogrtID);

            ctx.Ogretmens.DeleteOnSubmit(ogrt);
            ctx.SubmitChanges();
            LoadSonuc();
            Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            textAdi.Text = row.Cells["Adi"].Value.ToString();
            textSoyadi.Text = row.Cells["Soyadi"].Value.ToString();
            dateTimePickerDogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);
            comboBoxDersAdi.SelectedValue = row.Cells["DersAdi"].Value;
            checkBoxAktifMi.Checked = (Boolean)row.Cells["AktifMi"].Value;
            textAdi.Tag = row.Cells["OgretmenId"].Value;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            LinqTODataContext ctx = new LinqTODataContext();

            int id = (int)textAdi.Tag;

            Ogretmen ogrt = ctx.Ogretmens.SingleOrDefault(og => og.OgretmenId == id);

            ogrt.Adi = textAdi.Text;
            ogrt.Soyadi = textSoyadi.Text;
            ogrt.DogumTarihi = Convert.ToDateTime(dateTimePickerDogumTarihi.Value.Date);
            ogrt.DersID = (int)comboBoxDersAdi.SelectedValue;
            ogrt.AktifMi = checkBoxAktifMi.Checked;

            ctx.SubmitChanges();
            LoadSonuc();
            Clear();

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Çıkmak istediğinizden emin misiniz ?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
