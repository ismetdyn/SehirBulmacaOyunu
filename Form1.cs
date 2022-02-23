using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._35SehirBulmacaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sehirler =
            "ADANA,ADIYAMAN,AFYONKARAHİSAR,AĞRI,AKSARAY,AMASYA,ANKARA,ANTALYA,ARDAHAN,ARTVİN,AYDIN," +
            "BALIKESİR,BARTIN,BATMAN,BAYBURT,BİLECİK,BİNGÖL,BİTLİS,BOLU,BURDUR,BURSA,ÇANAKKALE," +
            "ÇANKIRI,ÇORUM,DENİZLİ,DİYARBAKIR,DÜZCE,EDİRNE,ELAZIĞ,ERZİNCAN,ERZURUM,ESKİŞEHİR," +
            "GAZİANTEP,GİRESUN,GÜMÜŞHANE,HAKKARİ,HATAY,IĞDIR,ISPARTA,İSTANBUL,İZMİR,KAHRAMANMARAŞ," +
            "KARABÜK,KARAMAN,KARS,KASTAMONU,KAYSERİ,KIRIKKALE,KIRKLARELİ,KIRŞEHİR,KİLİS,KOCAELİ," +
            "KONYA,KÜTAHYA,MALATYA,MANİSA,MARDİN,MERSİN,MUĞLA,MUŞ,NEVŞEHİR,NİĞDE,ORDU,OSMANİYE,RİZE," +
            "SAKARYA,SAMSUN,SİİRT,SİNOP,SİVAS,ŞIRNAK,TEKİRDAĞ,TOKAT,TRABZON,TUNCELİ,ŞANLIURFA,UŞAK," +
            "VAN,YALOVA,YOZGAT,ZONGULDAK";
        string[] sehirlerListesi;
        string sehirIsmi = "";
        int harfSayisi = 0;
        int kalanHak = 4;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            sehirlerListesi = sehirler.Split(',');
            tbHarf.MaxLength = 1;
            btnHarf.Enabled = false;
            btnTahmin.Enabled = false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kalanHak = 4;
            lToplamPuan.Text = "0";
            lAktifHarfPuani.Text = rnd.Next(1, 20).ToString();
            harfSayisi = 0;
            btnHarf.Enabled = true;
            btnTahmin.Enabled = true;
            lGirilenHarfler.Text = "";

            int rastgeleSayi = rnd.Next(0, sehirlerListesi.Length);
            sehirIsmi = sehirlerListesi[rastgeleSayi];

            lKalanHakSayisi.Text = kalanHak.ToString();

            pnlSehirAdi.Controls.Clear();

            for (int i = 0; i < sehirIsmi.Length; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20 * i + 30, 20);
                lbl.Text = sehirIsmi[i].ToString();
                lbl.Size = new System.Drawing.Size(15, 20);
                lbl.BackColor = Color.Red;
                lbl.ForeColor = Color.Red;
                pnlSehirAdi.Controls.Add(lbl);
            }
        }

        private void btnHarf_Click(object sender, EventArgs e)
        {
            bool harfDurumu = false;
            foreach (Control item in pnlSehirAdi.Controls)
            {
                if(item is Label)
                {
                    Label label = item as Label;
                    if(label.Text == tbHarf.Text.ToUpper())
                    {
                        label.ForeColor = Color.White;
                        label.BackColor = Color.Lime;
                        harfDurumu = true;
                        harfSayisi++;
                        lToplamPuan.Text = Convert.ToString(Convert.ToInt32(lToplamPuan.Text) +
                            Convert.ToInt32(lAktifHarfPuani.Text));
                    }
                }
            }

            lAktifHarfPuani.Text= rnd.Next(1, 20).ToString();
            if(!harfDurumu)
            {
                kalanHak--;

                lKalanHakSayisi.Text = kalanHak.ToString();

                if(kalanHak == 0)
                {
                    btnHarf.Enabled = false;
                    btnTahmin.Enabled = false;
                    MessageBox.Show("Üzgünüz kaybettiniz" + sehirIsmi);
                }
            }

            lGirilenHarfler.Text += tbHarf.Text + " ";

            if (harfSayisi == sehirIsmi.Length)
            {
                btnHarf.Enabled = false;
                btnTahmin.Enabled = false;
                MessageBox.Show("Tebrikler kazandınız.");
            }

            tbHarf.Text = "";
            tbHarf.Focus();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if(sehirIsmi == tbTahmin.Text.ToUpper())
            {
                foreach (Control item in pnlSehirAdi.Controls)
                {
                    if(item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;
                    }
                }
                MessageBox.Show("Tebrikler kazandınız.");
            }
            else
            {
                MessageBox.Show("Üzgünüz kaybettiniz. Cevap: " + sehirIsmi);
            }

            btnHarf.Enabled = false;
            btnTahmin.Enabled = false;

        }
    }
}
