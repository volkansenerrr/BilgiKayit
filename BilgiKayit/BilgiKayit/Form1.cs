using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_kayit.Items.Add("Ad :" + tb_ad.Text + "  Soyad:" + tb_soyad.Text + "  TC Kimlik Numarası:" + mtb_tcNo.Text + "  Telefon Numarası:" + mtb_telefonNo.Text + "  Şehir:" + cb_sehir.Text + "  Doğum Tarihi:" + dtp_dogumTarihi.Text); //Kullanıcıdan alınan bilgileri ListBox'ta gösterdim.

            //Kullanıcıdan bilgileri aldım.
            string ad = tb_ad.Text;
            string soyad = tb_soyad.Text;
            string tcNo = mtb_tcNo.Text;
            string telNo = mtb_telefonNo.Text;
            string sehir = cb_sehir.Text;
            string dogumTarihi = dtp_dogumTarihi.Text;

            //Kullanıcıdan alınan bilgiler birleştirildi.
            string kayit = $"Ad: {ad} | Soyad: {soyad} | TC Kimlik Numarası: {tcNo} | Telefon Numarası: {telNo} | Şehir: {sehir} | Doğum Tarihi: {dogumTarihi}";

            //Kayıt dosyasının yolu belirlendi.
            string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Bilgi Kayıt.txt";

            //Bilgi Dosyaya yazdırıldı.
            using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
            {
                sw.WriteLine(kayit);
            }

            //Kayıtın başarıyla eklendiği geri bildirimi alındı
            MessageBox.Show("Kayıt başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tb_ad.Clear();  
            tb_soyad.Clear();
            mtb_tcNo.Clear();   
            mtb_telefonNo.Clear();
        }
    }
}
