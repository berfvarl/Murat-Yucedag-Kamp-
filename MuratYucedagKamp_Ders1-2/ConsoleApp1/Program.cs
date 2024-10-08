// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string Ad;
//Ad = "Berfin";
//Console.WriteLine(Ad);
//Console.Read();

// Double Değişkenler
//double number;
//number = 4.85;
//Console.WriteLine(number);
//Console.Read();

using System;

Console.WriteLine("*****Fiyat Listesi*****");
Console.WriteLine();

double applePrice, OrangePrice, strawberryPrice, potatoPrice, tomatoPrice;
applePrice = 15.85;
OrangePrice = 20.40;
strawberryPrice = 45;
potatoPrice = 11;
tomatoPrice = 12;


Console.WriteLine("Elma Birim Fiyatı:" + applePrice + "TL");
Console.WriteLine("Portakal Birim Fiyatı:" + OrangePrice + "TL");
Console.WriteLine("Çilek Birim Fiyatı:" + strawberryPrice + "TL");
Console.WriteLine("Patates Birim Fiyatı:" + potatoPrice + "TL");
Console.WriteLine("Domates Birim Fiyatı:" + tomatoPrice + "TL");

double appleGram, OrangeGram, strawGram, potatoGram, tomatoGram;
appleGram = 1.245;
OrangeGram = 2.650;
strawGram = 1.150;
potatoGram = 1.200;
tomatoGram = 1.200;

double appleTotalPrice = appleGram * applePrice;
double OrangeTotalPrice = OrangeGram * applePrice;
double StrawberryTotalPrice = strawGram * strawberryPrice;
double potatoTotalPrice = potatoGram * potatoPrice;
double tomatoTotalPrice = tomatoGram * tomatoPrice;
Console.WriteLine("Elmanın Toplam Fiyatı:" + appleTotalPrice + "TL");
Console.WriteLine("Alınan Ürün: Elma" + " - Birim Fiyat:" + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar:" +appleTotalPrice+ "TL "  );
Console.WriteLine("Alınan Ürün: Portakal" + " - Birim Fiyat:" + OrangePrice + " - Gramaj:" + OrangeGram + " - Toplam Tutar:" + OrangeTotalPrice + "TL ");
Console.WriteLine("Alınan Ürün: Çilek" + " - Birim Fiyat:" + strawberryPrice + " - Gramaj:" + strawGram + " - Toplam Tutar:" + StrawberryTotalPrice + "TL ");
Console.WriteLine("Alınan Ürün: Patates" + " - Birim Fiyat:" + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar:" + potatoTotalPrice + "TL ");
Console.WriteLine("Alınan Ürün: Domates" + " - Birim Fiyat:" + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice + "TL ");
double totalTutar=appleTotalPrice+OrangeTotalPrice+StrawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
Console.WriteLine("Toplam TUTAR:"+totalTutar+ "TL");



#region CHAR DEĞİŞKENLER

//char symbol;
//symbol = 'a';
//Console.WriteLine(symbol);
//#endregion

//#region KLAVYEDEN VERİ GİRİŞLERİ STRİNG DEĞİŞKENLER
//Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgisi****");
//Console.WriteLine();

//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

//Console.Write("Yolcu Adı:");
//passengerName = Console.ReadLine();

//Console.Write("Yolcu Soyadı:");
//passengerSurname = Console.ReadLine();

//Console.Write("İlçe Bilgisi:");
//passengerDistrict = Console.ReadLine();

//Console.Write("Şehir Bilgisi:");
//passengerCity = Console.ReadLine();

//Console.Write("Yolcu Yaşı:");
//passengerAge= Console.ReadLine();

//Console.Write("TC Kimlik Numarası:");
//passengerIdentityNumber= Console.ReadLine();

//Console.WriteLine();
//Console.WriteLine("------------------------------");
//Console.WriteLine("Yolcu:" + passengerName +" "+ passengerSurname +" "+ passengerDistrict +" "+ passengerCity +" "+ passengerAge +" "+ passengerIdentityNumber);
//Console.Read();


#endregion


//Klavyeden Tam Sayı Girişleri ve Dönüşümler

    int shoesPrice, computerPrice, chairPrice, tvPrice;
shoesPrice = 350;
computerPrice = 20000;
chairPrice = 60;
tvPrice = 12000;

int shoesCount, computerCount, chairCount, tvCount;
Console.WriteLine("Lütfen aldığınız ayakkabı miktarını giriniz:");
shoesCount = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen aldığınız bilgisayar miktarını giriniz:");
computerCount = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen aldığınız sandalye miktarını giriniz:");
chairCount = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen aldığınız televizyon miktarını giriniz:");
tvCount = int.Parse(Console.ReadLine());

int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
Console.WriteLine();
Console.WriteLine("Toplam Tutar:" + totalPrice);







