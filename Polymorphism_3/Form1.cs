using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazilimci egitmen = new Yazilimci();
            egitmen.ad_soyad = "Onur Şişoğlu";
            egitmen.cinsiyet = 'E';
            egitmen.tc_no = "19562783427";
            egitmen.programlama_dili = "C#";
            MessageBox.Show(egitmen.PersonelBilgisi());

            Guvenlik gorevli = new Guvenlik();
            gorevli.ad_soyad = "Fahri Yılmaz";
            gorevli.cinsiyet = 'E';
            gorevli.tc_no = "14961578156";
            gorevli.sertifika_no = "4615";
            gorevli.silahli_mi = true;
            MessageBox.Show(gorevli.PersonelBilgisi());
        }
    }
}
// Personel class'ı açarak ortak özellikleri(ad soyad, cinsiyet, tc no) tanımlayınız.
// Personel class'ında içi ezilebilir olarak personel bilgisi veren metodu yazınız.
// Personel olarak yazılımcı ve güvenlik personeli olarak 2 class açıp personel class'ından   miras alınız.
// Yazılımcının kendi özellikleri: programlama dili olarak ekleyiniz.
// Güvenlikçinin kendi özellikleri: sertifika numarası ve silahlı mı olarak ekleyiniz.
// Yazılımcının personel bilgisini ekranda gösteriniz.