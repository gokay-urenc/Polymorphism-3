using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_3
{
    public class Personel
    {
        public string ad_soyad { get; set; }
        public char cinsiyet { get; set; }
        public string tc_no { get; set; }
        public virtual string PersonelBilgisi()
        {
            return string.Format("Adı Soyadı: {0} , Cinsiyeti: {1} , Tc No: {2}", ad_soyad, cinsiyet, tc_no); 
        }
    }

    public class Yazilimci : Personel
    {
        public string programlama_dili { get; set; }
        public override string PersonelBilgisi()
        {
            string temel_bilgiler = base.PersonelBilgisi();
            return temel_bilgiler + ", Programlama Dili: " + programlama_dili;
        }
    }

    public class Guvenlik : Personel
    {
        public string sertifika_no { get; set; }
        public bool silahli_mi { get; set; }
        public override string PersonelBilgisi()
        {
            string temel_bilgiler = base.PersonelBilgisi();
            return temel_bilgiler + ", Sertifika Numarası: " + sertifika_no + ", Silahlı mı?: " + (silahli_mi? "Silahlı." : "Silahsız.");
        }
    }
}