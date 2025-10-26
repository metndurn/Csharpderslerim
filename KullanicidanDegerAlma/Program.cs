using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// ReadLine() metodu kullanicidan deger almayi saglar.
			Console.WriteLine("Lutfen adinizi giriniz:");
			string isim = Console.ReadLine();

			Console.WriteLine("Soyadinizi giriniz:");
			string soyisim = Console.ReadLine();

			Console.WriteLine("Merhaba " + isim + " " + soyisim + " MDAJANS'A Hoş Geldiniz..:");
			Console.ReadLine();
		}
	}
}
