﻿using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            //Console.Read();

            #endregion

            #region String Degiskenler

            // Değişkenler

            //String
            // Degisken Türü degisken_adi
            //camelCase olmalı

            //string name;
            //name = "Ugur";

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("***** Rezervasyon Kartı ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email : "+ customerEmail);
            //Console.WriteLine("Adres : " + district + "/" +city);
            //Console.WriteLine("---------------------------------------------------");



            #endregion


            #region Int Degiskenler

            // İnt
            //int number = 24;
            //Console.WriteLine(number);


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("***** Restoran Menu Fiyatı");
            Console.WriteLine();

            Console.WriteLine("----- Hamburger : " + cokePrice + " TL");
            Console.WriteLine("----- Pizza : " + pizzaPrice + " TL");
            Console.WriteLine("----- Kola : " + cokePrice + " TL");
            Console.WriteLine("----- Limonata : " + lemonadePrice + " TL");
            Console.WriteLine("----- Kızartma : " + friesPrice + " TL");
            Console.WriteLine("----- Su : " + waterPrice + " TL");
            Console.WriteLine("***** Restoran Menu Fiyatı");
            Console.WriteLine();


            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice, totalCokePrice, totalWaterPrice, totalFriesPrice, totalPizzaPrice, totalLemonadePrice,totalPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3; 
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalFriesPrice = friesCount * friesPrice;

            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalLemonadePrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + " TL");
            Console.WriteLine("Toplam : " + totalPrice + " TL");
            Console.WriteLine("--------------------------------------------");

            #endregion

            Console.ReadLine();
        }
    }
}


/*
 
Yazdırma Komutları

 
 
 */