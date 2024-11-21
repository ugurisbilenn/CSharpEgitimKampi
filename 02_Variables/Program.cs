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

            #region Double Degiskenler

            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi ******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("------ Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("------ Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("------ Çikek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("------ Patates Birim Fiyatı : " + patatoPrice + " TL");
            //Console.WriteLine("------ Domates Birim Fiyatı : " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram , tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Elma (KG:" + applePrice+") "+ appleGram +" KG " + appleTotalPrice +" TL ");
            //Console.WriteLine("Portakal (KG:" + orangePrice+") "+ orangeGram +" KG " + orangeTotalPrice +" TL ");
            //Console.WriteLine("Çilek (KG:" + strawberryPrice+") "+ strawberryGram +" KG " + strawberryTotalPrice +" TL ");
            //Console.WriteLine("Patates (KG:" + patatoPrice+") "+ patatoGram +" KG " + patatoTotalPrice +" TL ");
            //Console.WriteLine("Domates (KG:" + tomatoPrice+") "+ tomatoGram +" KG " + tomatoTotalPrice +" TL ");
            //Console.WriteLine("Toplam Fiyat : " + totalPrice + " TL ");








            #endregion


            #region Char Degiskenler

            // ABCDEFGH
            // DEF

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden VeriGirişleri String Degişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");

            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Tc Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No "+ passengerIdentityNumber + " Yolcu : Ad Soyad " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);
            //passengerDistrict = Console.ReadLine();
            #endregion

            #region Klavyeden Tam sayı girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount , computerCount , chairCount  , tvCount ;
            //Console.Write("Lütfen aldığınız Ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız Sandalye sayısını giriniz : ");
            //chairCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız TV sayısını giriniz : ");
            //tvCount = int.Parse( Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken Tutar : " + totalPrice +" TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : " +result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyer Seçiniz : ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Cinsiyetiniz : " + gender);


            #endregion

            Console.ReadLine();

        }
    }
}
