using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaÖdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // LENGTH(kelimenin uzunluğunu ölçer.)
            /* string isim;
             Console.WriteLine("mesajinizi giriniz");
             isim = Console.ReadLine();
             if (isim.Length > 5) 

                 Console.WriteLine("mesajinizi kabul edilmistir.");
             else Console.WriteLine("mesajiniz cok kisa");
             Console.ReadLine(); */

            // CONCAT( iki kelimenin birleşmesini sağlar.)
            /* string ifade1 = "Kodlama ";
             string ifade2 = "Ogrenıyorum";

             string sonuc = String.Concat(ifade1, ifade2);

             Console.WriteLine("Sonuc : " + sonuc);
             Console.ReadLine(); */

            // TOUPER-TOLOWER(TOUPER-büyük harfle yazar TOLOWER-küçük harfle yazar)
            /* string ifade1 = "Ben kodlama ogrenıyorum";

             string ifade2 = ifade1.ToUpper();
             string ifade3 = ifade1.ToLower();

             Console.WriteLine("İfade2: " + ifade2);
             Console.WriteLine("İfade3: " + ifade3);
             Console.ReadLine(); */

            //SUBSTRİNG
            /*  string ifade1 = "Ben kodlama ogrenıyorum";

              string ifade2 = ifade1.Substring(4);
              // 'k' harfinden başlar..

              string ifade3 = ifade1.Substring(4, 7);
              // 'k' harfinden başlar 7 karakter gider.

              Console.WriteLine("İfade2: " + ifade2);
              Console.WriteLine("İfade3: " + ifade3);
              Console.ReadLine(); */

            //INDEXOF(metindeki karakterin kaçıncı karakter oldugunu verir.)
            /*  string ifade1 = "Ben kodlama ogrenıyorum";

              int sonuc1 = ifade1.IndexOf("kodlama");
              int sonuc2 = ifade1.IndexOf('k');
              int sonuc3 = ifade1.IndexOf('z');

              Console.WriteLine("Sonuc1: " + sonuc1);
              Console.WriteLine("Sonuc2: " + sonuc2);
              Console.WriteLine("Sonuc3: " + sonuc3);
              Console.ReadLine(); */

            // LASTINDEXOF(aradığın karakterin son bulunduğu yerinkaçıncı yer olduğunu verir.)
            /* string mesaj = "Karışık Notlar";
             string aranan = "a";
             Console.WriteLine(mesaj.LastIndexOf(aranan));
             Console.ReadLine();*/

            /* // CONTAİN(aradığımız kelimenin metnin içerisinde olup olmadığını veren metotdur.)
             string ifade1 = "Ben kodlama ogrenıyorum";
             string ifade2 = "kodlama";
             string ifade3 = "program";

             bool sonuc1 = ifade1.Contains(ifade2);
             //bool sonuc1 = ifade1.Contains("kodlama");

             bool sonuc2 = ifade1.Contains(ifade3);

             Console.WriteLine("Sonuc1 : " + sonuc1);
             Console.WriteLine("Sonuc2 : " + sonuc2);
             Console.ReadLine(); */

            //STARTSWİTH(Kelimenin başlangıç harfini kontrol eder.)
            /*  string ifade1 = "Ben kodlama ogrenıyorum";

              bool sonuc1 = ifade1.StartsWith("Ben");
              bool sonuc2 = ifade1.StartsWith("Sen");
              bool sonuc3 = ifade1.StartsWith("B");
              bool sonuc4 = ifade1.StartsWith("a");

              Console.WriteLine("Sonuc1: " + sonuc1);
              Console.WriteLine("Sonuc2: " + sonuc2);
              Console.WriteLine("Sonuc3: " + sonuc3);
              Console.WriteLine("Sonuc4: " + sonuc4);
              Console.ReadLine(); */

            //ENDSWİTH(kelimenin son harfini kontrol eder)
            /* string ifade1 = "Ben kodlama ogrenıyorum";

             bool sonuc1 = ifade1.EndsWith("ogrenıyorum");
             bool sonuc2 = ifade1.EndsWith("kodlama");
             bool sonuc3 = ifade1.EndsWith("m");
             bool sonuc4 = ifade1.EndsWith("k");

             Console.WriteLine("Sonuc1: " + sonuc1);
             Console.WriteLine("Sonuc2: " + sonuc2);
             Console.WriteLine("Sonuc3: " + sonuc3);
             Console.WriteLine("Sonuc4: " + sonuc4);
             Console.ReadLine(); */

            // REPLACE(bir karakterin başka bir karakterle değişmesini sağlar.)
            /*  string metin;
              Console.Write("Metni Girin : ");
              metin = Console.ReadLine();
              string yenimetin = metin.Replace(',', '.');
              Console.WriteLine(yenimetin);
              Console.ReadKey(); */

            //SPLİT(belirlediğimiz karakteri görünce bölmeyi sağlayan fonksiyondur.)

            /* char[] ayrac = { '/', ' ', ':' };
             string tarih = "2018/05/03 14:50";

             string[] parcalar = tarih.Split(ayrac);

             Console.WriteLine("Yıl:{0}  Ay:{1} Gün:{2}  Saat:{3} Dakika:{4}", parcalar[0], parcalar[1], parcalar[2], parcalar[3], parcalar[4]);

             Console.ReadLine(); */

            //TRİM(baştan ve sondan bırkatığımız boşlukları silmeyi sağlar.)

            /* string ifade1 = "     Ben kodlama ogrenıyorum    ";

             string ifade2 = ifade1.Trim();

             Console.WriteLine("İfade2:" + ifade2);
             Console.ReadLine(); */

            //JOIN(

            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

           Console.WriteLine(string.Join("-", gunler));  
            Console.ReadLine();


        }

    }
    }

