/*****************************************************************************************************************************************************************************
**                                                  SAKARYA ÜNİVERSİTESİ
**                                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                             BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                            NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                                2020-2021 BAHAR DÖNEMİ
**
**                                           ÖDEV NUMARASI...........: PROJE
**                                           ÖĞRENCİ ADI.............: İLAYDA YILMAZ
**                                           ÖĞRENCİ NUMARASI........: B201210057
**                                           DERSİ ALDIĞI GRUP.......: 1 C GRUBU
**
****************************************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace meyve_oyunu_ndp
{
    public interface Imeyve //Imeyve isimli interface oluşturdum
    {
        public int VitaminA(); //VitaminA metodu tanımladım
        public int VitaminC(); //VitaminC metodu tanımladım.
        public int Pure(); //Pure metodu tanımladım.
    }
  
    public abstract class Narenciye  // Narenciye isimli anstract class tanımladım
    {
        public int Verim() // return değeri Verim olan Verim isimli metot tanımladım.
        {
            Random rastgele = new Random();
            int Verim = rastgele.Next(30, 70); //dökümanda belirtilen değerlerden random bir verim oluşturdum.
            return Verim;
        }
        public int Gramaj() //return değeri Gramaj olan Gramaj isimli metot tanımladım.
        {
            Random rastgele = new Random();
            int Gramaj = rastgele.Next(70, 120); //dökümanda belirtilen değerlerden random bir gramaj oluşturdum.
            return Gramaj;

        }

    }
    public abstract class KatıMeyve //KatıMeyve isimli bir abstract class tanımladım.
    {
        public int Verim() // return değeri Verim olan Verim isimli metot tanımladım.
        {
            Random rastgele = new Random();
            int Verim = rastgele.Next(80, 95); //dökümanda belirtilen değerlerden random bir verim oluşturdum.
            return Verim;
        }
        public int Gramaj() // return değeri Gramaj olan Gramaj isimli metot tanımladım.
        {
            Random rastgele = new Random();
            int Gramaj = rastgele.Next(70, 120); //dökümanda belirtilen değerlerden random bir gramaj oluşturdum.
            return Gramaj;
        }
    }
    public class Elma : KatıMeyve , Imeyve // KatıMeyve abstract classından ve Imeyve interfacesinden miras alan Elma isimli class oluşturdum.
    {
        public int VitaminA() //Interfacede tanımladığım VitaminA metodunu yazdım.
        {
            int VitaminA = 0;
            VitaminA = Gramaj() * Verim() * 54 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnA değerini buldum.
            return VitaminA;
        }

        public int VitaminC() //Interfacede tanımladığım VitaminC metodunu yazdım.
        {
            int VitaminC = 0;
            VitaminC = Gramaj() * Verim() * 5 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnC değerini buldum.
            return VitaminC;
        }
        public int Pure()  //Interfacede tanımladığım Pure metodunu yazdım.
        {
            int Pure = 0;
            Pure = Gramaj() * Verim() / 100;  //Gramaj ve verim metotlarını çağırdım ve püre değerini buldum.
            return Pure;
        }
    }
    public class Armut : KatıMeyve , Imeyve// KatıMeyve abstract classından ve Imeyve interfacesinden miras alan Armut isimli class oluşturdum.
    {
        public int VitaminA() //Interfacede tanımladığım VitaminA metodunu yazdım.
        {
            int VitaminA = 0;
            VitaminA = Gramaj() * Verim() * 25 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnA değerini buldum.
            return VitaminA;
        }

        public int VitaminC() //Interfacede tanımladığım VitaminC metodunu yazdım.
        {
            int VitaminC = 0;
            VitaminC = Gramaj() * Verim() * 5 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnC değerini buldum.
            return VitaminC;
        }
        public int Pure() //Interfacede tanımladığım Pure metodunu yazdım.
        {
            int Pure = 0;
            Pure = Gramaj() * Verim() / 100; //Gramaj ve verim metotlarını çağırdım ve püre değerini buldum.
            return Pure;
        }
    }
    public class Çilek : KatıMeyve, Imeyve // KatıMeyve abstract classından ve Imeyve interfacesinden miras alan Çilek isimli class oluşturdum.
    {
        public int VitaminA() //Interfacede tanımladığım VitaminA metodunu yazdım.
        {
            int VitaminA = 0;
            VitaminA = Gramaj() * Verim() * 12 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnA değerini buldum.
            return VitaminA;
        }

        public int VitaminC() //Interfacede tanımladığım VitaminC metodunu yazdım.
        {
            int VitaminC = 0;
            VitaminC = Gramaj() * Verim() * 60 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnC değerini buldum.
            return VitaminC;
        }
        public int Pure()  //Interfacede tanımladığım Pure metodunu yazdım.
        {
            int Pure = 0;
            Pure = Gramaj() * Verim() / 100; //Gramaj ve verim metotlarını çağırdım ve püre değerini buldum.
            return Pure;
        }
    }
    public class Mandalina : Narenciye ,Imeyve
    {
        public int VitaminA() //Interfacede tanımladığım VitaminA metodunu yazdım.
        {
            int VitaminA = 0;
            VitaminA = Gramaj() * Verim() * 681 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnA değerini buldum.
            return VitaminA;
        }

        public int VitaminC() //Interfacede tanımladığım VitaminC metodunu yazdım.
        {
            int VitaminC = 0;
            VitaminC = Gramaj() * Verim() * 26 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnC değerini buldum.
            return VitaminC;
        }
        public int Pure()  //Interfacede tanımladığım Pure metodunu yazdım.
        {
            int Pure = 0;
            Pure = Gramaj() * Verim() / 100; //Gramaj ve verim metotlarını çağırdım ve püre değerini buldum.
            return Pure;
        }
    }
    public class Greyfurt : Narenciye,Imeyve
    {
        public int VitaminA() //Interfacede tanımladığım VitaminA metodunu yazdım.
        {
            int VitaminA = 0;
            VitaminA = Gramaj() * Verim() * 3 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnA değerini buldum.
            return VitaminA;
        }

        public int VitaminC() //Interfacede tanımladığım VitaminC metodunu yazdım.
        {
            int VitaminC = 0;
            VitaminC = Gramaj() * Verim() * 44 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnC değerini buldum.
            return VitaminC;
        }
        public int Pure() //Interfacede tanımladığım Pure metodunu yazdım.
        {
            int Pure = 0;
            Pure = Gramaj() * Verim() / 100; //Gramaj ve verim metotlarını çağırdım ve püre değerini buldum.
            return Pure;
        }
    }
    public class Portakal : Narenciye,Imeyve
    {
        public int VitaminA() //Interfacede tanımladığım VitaminA metodunu yazdım.
        {
            int VitaminA = 0;
            VitaminA = Gramaj() * Verim() * 225 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnA değerini buldum.
            return VitaminA;
        }

        public int VitaminC() //Interfacede tanımladığım VitaminC metodunu yazdım.
        {
            int VitaminC = 0;
            VitaminC = Gramaj() * Verim() * 45 / 1000; //Gramaj ve Verim metotlarını çağırdım ve dökümandaki değer ile VitamnC değerini buldum.
            return VitaminC;
        }
        public int Pure() //Interfacede tanımladığım Pure metodunu yazdım.
        {
            int Pure = 0;
            Pure = Gramaj() * Verim() / 100;  //Gramaj ve verim metotlarını çağırdım ve püre değerini buldum.
            return Pure;
        }
    }
}
