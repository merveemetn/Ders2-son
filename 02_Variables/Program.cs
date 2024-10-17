using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //Console.OutputEncoding = Encoding.UTF8;

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***Fiyat Listesi***");
            //Console.WriteLine("");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı:" + applePrice + "₺");
            //Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice + "₺") ;
            //Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + "₺" ) ;
            //Console.WriteLine("----Patates Birim Fiyatı:" + potatoPrice + "₺" ) ;
            //Console.WriteLine("----Domates Birim Fiyatı:" + tomatoPrice + "₺" ) ;
            //Console.WriteLine() ;   
            //Console.WriteLine() ;   


            //double applegr, orangegr, strawgr, potatogr, tomatogr;
            //applegr = 1.245;
            //orangegr = 2.650;
            //strawgr = 0.750;
            //potatogr = 4.859;
            //tomatogr = 3.745;

            //double appleTotalPrice = applegr * applePrice;
            //double orangeTotalPrice = orangegr * orangePrice;
            //double strawberryTotalPrice = strawgr * strawberryPrice;
            //double potatoTotalPrice = potatogr * potatoPrice;
            //double tomatoTotalPrice = tomatogr * tomatoPrice;


            //Console.WriteLine("Alınan ürün elma - " + "Birim fiyat: " + applePrice + " - Gramaj: " + applegr + " " + " - Toplam Tutar: " + appleTotalPrice + "₺");
            //Console.WriteLine("Alınan ürün portakal - " + "Birim fiyat: " + orangePrice + " - Gramaj: " + orangegr + " " + " - Toplam Tutar: " + orangeTotalPrice + "₺");
            //Console.WriteLine("Alınan ürün çilek - " + "Birim fiyat: " + strawberryPrice + " - Gramaj: " + strawgr + " " + " - Toplam Tutar: " + strawberryTotalPrice + "₺");
            //Console.WriteLine("Alınan ürün patates - " + "Birim fiyat: " + potatoPrice + " - Gramaj: " + potatogr + " " + " - Toplam Tutar: " + potatoTotalPrice + "₺");
            //Console.WriteLine("Alınan ürün domates - " + "Birim fiyat: " + tomatoPrice + " - Gramaj: " + tomatogr + " " + " - Toplam Tutar: " + tomatoTotalPrice + "₺");

            //double ShoppinTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş toplam tutarı :" + ShoppinTotalPrice + "₺");

            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            ////Console.WriteLine("**** C# Havayolları Yolcu Bilgisi ****");
            ////Console.WriteLine();

            ////string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            ////Console.Write("Yolcu Adı: ");
            ////passengerName = Console.ReadLine();
            ////Console.Write("Yolcu Soyadı: ");
            ////passengerSurname = Console.ReadLine();

            ////Console.Write("İlçe Bilgisi:");
            ////passengerDistrict = Console.ReadLine();

            ////Console.Write("Şehir Bilgisi:");
            ////passengerCity = Console.ReadLine();

            ////Console.Write("Yaş Bilgisi:");
            ////passengerAge = Console.ReadLine();

            ////Console.Write("Kimik Bilgisi:");
            ////passengerIdentityNumber = Console.ReadLine();

            ////Console.WriteLine();
            ////Console.WriteLine("-----------------------------");

            ////Console.WriteLine("Yolcu Tc Kimlik bilgisi:" + passengerIdentityNumber + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + passengerAge );

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler


            //int shoesPrice, computerPrice, chairPrice, TvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //TvPrice = 12000;

            //int shoesCount, computerCount, chairCount, TvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen sandalye bilgisayar sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz:");
            //TvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + TvPrice * TvCount);
            //Console.WriteLine("Toplam Tutar:" + totalPrice);








            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız:" + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
            #endregion
            
            
            Console.Read();
        }
    }
}
