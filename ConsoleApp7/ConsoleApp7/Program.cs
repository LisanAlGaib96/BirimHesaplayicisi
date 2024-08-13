using ConsoleApp7;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.XPath;

namespace ConsoleApp7
{

	internal class Program
	{
      
		static void Main(string[] args)
		{

			while (true)
			{
				Console.WriteLine("Birim hesaplayıcısına hoşgeldiniz.");
				Console.WriteLine("Seçeneklerden birini seçiniz.");
				Console.WriteLine("1.Mil/Kilometre");
				Console.WriteLine("2.Libre/Kilogram");
				Console.WriteLine("3.Fahrenheit/Celsius");

				string girilenDeger= Console.ReadLine();

				//Kullanıcı Girişini Doğrulama

				if (girilenDeger == "1")
				{
					MilKilometre();
				}

				else if(girilenDeger =="2")
				{
					LibreKilogram();
				}

				else if (girilenDeger == "3")
				{
					FahrenheitCelsius();
				}

				else
				{
					Console.WriteLine("Yanlış değer. Lütfen tekrar deneyiniz.");
				}
			}


            Console.Read();


        }

		//Metotları Çağırma
		static void MilKilometre()
		{
			Console.WriteLine("Lütfen mil miktarını girin:");
			double mil = double.Parse(Console.ReadLine());
			double kilometre = mil * 1.609344;
			Console.WriteLine("{0} mil {1} kilometreye eşittir.", mil, kilometre);
		}

		static void LibreKilogram()
		{
			Console.WriteLine("Lütfen kilometre miktarını girin:");
			double libre = double.Parse(Console.ReadLine());
			double kilogram = libre * 0.45359237;
			Console.WriteLine("{0} libre {1} kilograma eşittir.", libre, kilogram);

		}

		static void FahrenheitCelsius()
		{
			Console.WriteLine("Lütfen fahrenheit sıcaklığını giriniz:");
			double fahrenheit = double.Parse(Console.ReadLine());
			double celsius = (fahrenheit - 32) / 5 / 9;
			Console.WriteLine("{0} derece fahfrenheit {1} celsius sıcaklığına eşittir.",fahrenheit,celsius);
		}

		

		

		}
	}












			
		
	


		
	



