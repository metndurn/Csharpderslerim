using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region toplama islemi+
			//int sayi1 = 12, sayi2 = 50;
			//int topla=sayi1 + sayi2;

			//Console.WriteLine("Toplama islemi:" + topla);
			//Console.WriteLine("********");

			//int s1 = 50, s2 = 45;
			//int eksi = s1 - s2;
			//Console.WriteLine("Cikarma islemi:" + eksi);
			#endregion

			#region cıkarma islemi-
			//int s1 = 42, s2 = 12;
			//int carp = s1 * s2;
			//Console.WriteLine("Carpma islemi:" + carp);
			//Console.WriteLine("**********");

			//int s3 = 55, s4 = 45;
			//int bolme = s3 / s4;
			//Console.WriteLine("Bolme islemi:" + bolme);
			#endregion

			#region mod alma islemi%
			//bir sayinin diger sayiya bolumunden kalani verir
			//int sayi1 = 10, sayi2 = 3;

			//int mod = sayi1 % sayi2;

			//Console.WriteLine("Mod alma islemi:" + mod);
			#endregion

			#region artirma ve azaltma islemi ++--
			//int sayi = 10;
			//sayi++; // + isareti ile var olan sayının uzerine sayi eklenmesini saglamıs oluyoruz.
			//Console.WriteLine("Artirma islemi:" + sayi);

			//int sayi2 = 20;
			//sayi2--; // - isareti ile var olan sayinin uzerinden sayi cikartilmasini saglamis oluyoruz.
			//Console.WriteLine("Azaltma islemi:" + sayi2);
			#endregion

			#region atama operator islemi =
			//ana mantık degisken = deger; yani sagdan sola dogru bir atama islemi gerceklesir.
			//int degisken = 50;
			//Console.WriteLine("Atama islemi:" + degisken);
			#endregion

			#region esittir operator islemi ==
			//iki degerin birbirine esit olup olmadigini kontrol eder ve bool (true/false) sonuc dondurur.
			//int sayi1 = 10;
			//int sayi2 = 10;
			//bool esitmi = (sayi1 == sayi2);
			//Console.WriteLine("Esittir operator islemi:" + esitmi);
			#endregion

			#region esit degildir operator islemi !=
			//iki degerin birbirine esit olmadigini kontrol eder ve bool (true/false) sonuc dondurur.
			//int sayi1 = 10;
			//int sayi2 = 20;
			//bool esitdegilmi = (sayi1 != sayi2);
			//Console.WriteLine("Esit degildir operator islemi:" + esitdegilmi);
			#endregion

			#region buyuktur operator buyuk ve esıttır islemi > >=
			//iki degerin karsilastirilmasinda birinci degerin ikinci degerden buyuk olup olmadigini kontrol eder ve bool (true/false) sonuc dondurur.
			//int yas = 18;

			//bool buyukmu = yas > 18;
			//Console.WriteLine("Buyuktur operator islemi:" + buyukmu);

			//bool buyukveesitmi = yas >= 18;
			//Console.WriteLine("Buyuk ve esittir operator islemi:" + buyukveesitmi);
			#endregion

			#region kucuktur operator kucuk ve esıttır islemi < <=
			////iki degerin karsilastirilmasinda birinci degerin ikinci degerden kucuk olup olmadigini kontrol eder ve bool (true/false) sonuc dondurur.
			//int yas = 20;
			//bool kucukmu = yas < 25;
			//Console.WriteLine("Kucuktur operator islemi:" + kucukmu);
			//bool kucukveesitmi = yas <= 20;
			//Console.WriteLine("Kucuk ve esittir operator islemi:" + kucukveesitmi);
			#endregion

			#region Mantiksal operatorler && ve islemi
			// ve operatori (&&) iki veya daha fazla kosulun birlikte dogru olmasi durumunda true degeri dondurur.
			//int sayi = 10;
			//int sayi1 = 10;
			//int sayi2 = 30;
			//bool sonuc = sayi == sayi1 && sayi < sayi2;
			//Console.WriteLine("Ve İslem Sonucun..:" + sonuc);
			#endregion

			#region Mantiksal operatorler || veya islemi
			// veya operatoru (||) iki veya daha fazla kosuldan en az birinin dogru olmasi durumunda true degeri dondurur.
			//int sayi = 15;
			//int sayi1 = 15;
			//int sayi2 = 30;
			//bool sonuc = sayi != sayi1 || sayi < sayi2;
			//Console.WriteLine("Veya İslem Sonucun..:" + sonuc);
			#endregion

			#region Mantiksal operatorler ! degil islemi
			//degil operatoru ! bir kosulun dogru olmadigini belirtir. yani bir seyin zıttını alır Kosul false ise true, true ise false degeri dondurur.
			//bool sonuc = true;
			//Console.WriteLine("Degil İslem Sonucun..:" + !sonuc);
			#endregion

			#region ek atama operatorleri += -= *= /=
			int sayi = 10;
			sayi += 5; //sayi = sayi + 5;
			Console.WriteLine("Ek Atama += Islemi:" + sayi);
			sayi -= 3; //sayi = sayi - 3;
			Console.WriteLine("Ek Atama -= Islemi:" + sayi);
			sayi *= 2; //sayi = sayi * 2;
			Console.WriteLine("Ek Atama *= Islemi:" + sayi);
			sayi /= 4; //sayi = sayi / 4;
			Console.WriteLine("Ek Atama /= Islemi:" + sayi);
			#endregion

			Console.ReadLine();
        }
    }
}
