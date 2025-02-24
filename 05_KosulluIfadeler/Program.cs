namespace _05_KosulluIfadeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Kosul bloklari bir durum karsisinda izlenecek yolu yada islemleri belirtir. Bu vasita ile yonumuzu diledigimiz gibi sekillendirebiliriz.

            //if (false) // if(durum)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (true) // Eger bir onceki durum saglanmadiysa bu durumu kontrol et
            //{
            //    Console.WriteLine(true);
            //}
            //else if (true)
            //{
            //    Console.WriteLine("Bir onceki durum saglanmadiysa buraya duser"); 
            //}
            //else
            //{
            //    Console.WriteLine("Hicbir durum saglanmadiginda default olarak burasi calisir.");
            //}

            //// Gelen sayi ciftse ekranda cift, tek ise ekranda tek yazdirilsin.
            //Console.Write("Bir sayi giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //bool ciftMi = sayi % 2 == 0;

            //Kullanıcıdan alınan sayı eğer 3e bölünüyorsa ekranda fizz eğer 5e bölünüyorsa buzz ikisini aynı anda bölünüyorsa fizzbuzz
            Console.WriteLine("Lütfen sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 3 == 0 && sayi % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if( sayi % 5==0)
            {
                Console.WriteLine("buzz");
            }
            else if(sayi%3==0)
            {
                Console.WriteLine("fizz");
            }
            else
            {
                Console.WriteLine("sayi fizz,buzz veya fizzbuzz değildir");
            }


            //kullanıcıdan alınan sayı elimizde mevcutsa bir meyvedir elimizde yoksa tanınmıyordur
            Console.WriteLine("Lütfen meyve giriniz");
            string meyve = Console.ReadLine();
            if(meyve == "elma")
            {
                Console.WriteLine("Bu bir meyvedir");
            }
            else if( meyve == "muz")
            {
                Console.WriteLine("bu bir meyvedir");
            }
            else if(meyve == "mandalina")
            {

                Console.WriteLine("bu bir meyvedir");
            }
            else
            {
                Console.WriteLine("meyve değildir");
            }

            //kullanıcıdan alinan ad yoklama içersinde mevcut mu değil mi kontrol edin
            
            Console.WriteLine("Lütfen ad giriniz");
            string ad = Console.ReadLine();
            if (ad == "ezgi")
            {
                Console.WriteLine("mevcut");
            }
            else if( ad== "can")
            {
                Console.WriteLine("mevcut");
            }
            else if (ad == "ali")
            {
                Console.WriteLine("mevcut");
            }
            else if (ad == "nisa")
            {
                Console.WriteLine("mevcut");
            }
            else if (ad == "ahmet")
            {
                Console.WriteLine("mevcut");
            }
            else
            {
                Console.WriteLine("mevcut değildir");
            }


            //kul. alınan d.tarihi üzerinden eğer yaşı 18 in altındaysa 18 e tamamlayin ve resitsin deyin, eğer 60 üzerinde ise 60a çekerek sen daha yeni emeklki olmuşsun yazdıralım.
            Console.WriteLine("Lütfen doğum yılınızı giriniz");
            int dogumTarihi = int.Parse(Console.ReadLine());
            int yas = 2025 - dogumTarihi;

            if (yas <= 18)
            {
                Console.WriteLine("18 yaşındasınız");
            }
            else if (yas >= 60)
            {
                Console.WriteLine("sen daha yeni emeklki olmuşsun");
            }
            else
            {
                Console.WriteLine($"{yas} yaşındasınız");
            }

            // kul. pc sayisi ve ogr. sayisi alınız. burada her öğr. bir pc düşmekte. pc eksik ise kasa yok şeklinde uyarı verilsin. eğer fazla ise öğr. lazım, eğer tamsa tamda bize kadar  vyazdır.
            //Console.WriteLine("bilgisayar sayısı giriniz");
            //int pcSayisi = int.Parse(Console.ReadLine());
            //Console.WriteLine("ogrenci sayısı giriniz");
            //int ogrenciSayisi = int.Parse(Console.ReadLine());

            //if(pcSayisi== ogrenciSayisi)
            //{
            //    Console.WriteLine("tam da bize kadar");
            //}
            //else if(pcSayisi< ogrenciSayisi)
            //{
            //    Console.WriteLine("kasa yok");
            //}
            //else if(ogrenciSayisi<pcSayisi) {
            //    Console.WriteLine("ogrenci lazım");
            //}
            //else
            //{
            //    Console.WriteLine("uygun değerler giriniz");
            //}

            //Switch case : bu koşul blokları gelen değerin denklerini kontrol eder.Yani eşit eşit durumuna bakar.

            //http durum kodları için 201 de created 202 de accepted 204 de no content şeklinde ekrana metin yazdırınız.
            int httpStatus = 201;
            switch (httpStatus)
            {
                case 201:
                    Console.WriteLine("created");
                    break;

                case 202:
                    Console.WriteLine("accepted");
                    break;

                case 204:
                    Console.WriteLine("no content");
                    break;

                    default:
                    Console.WriteLine("tanımlanmıyor");
                        break;
            }

            // gelen role göre adminse full moderatörse sınırlı standartsa normal erişim şeklinde ekrana msj yazdır

            string rol = Console.ReadLine();

            switch (rol)
            {

                case "admin":
                    Console.WriteLine("full erişim");
                    break;
                case "moderator":
                    Console.WriteLine("sınırlı");
                    break;
                case "standart":
                    Console.WriteLine("normal");
                    break;
                default:
                    Console.WriteLine("rol yok");
                    break;
            }


            //kullanıcıdan gelen veri meyve sebze mi ona göre mesaj yazdır
            string urun = Console.ReadLine();
            switch (urun) {
                case "elma":
                case "armut":
                case "kiraz":
                case "kivi":
                case "muz":
                    Console.WriteLine("meyve");
                    break;
                case "kabak":
                 case "pırasa":
                 case "sogan":
                 case "ıspanak":
                    Console.WriteLine("sebze");
                    break;
                default:
                    break;
            }

            //gelen vasıta otomobilse ekrana binek araç kamyonetse kamyon motorsa motorsiklet yazdır.

            string arac = Console.ReadLine();
            switch (arac)
            {
                case "otomobil":
                    Console.WriteLine("binek arac");
                    break;

                case "kamyonet":
                    Console.WriteLine("kamyon");
                    break;
                case "motor":
                    Console.WriteLine("motorsiklet");
                    break;
                default:
                    break;

            }

            //kuıllanıcıdan sayısal değerler alarak haftanın günlerini yazdırınız


            int rakam = Convert.ToInt32(Console.ReadLine());
            switch (rakam)
            {
                case 1:
                    Console.WriteLine("pazartesi");
                    break;

                case 2:
                    Console.WriteLine("salı");
                    break;


                case 3:
                    Console.WriteLine("çarşamba");
                    break;



                case 4:
                    Console.WriteLine("perşembe");
                    break;

                case 5:
                    Console.WriteLine("cuma");
                    break;




                case 6:
                    Console.WriteLine("cumartesi");
                    break;



                case 7:
                    Console.WriteLine("pazar");
                    break;



                default:
                    break;
            }


            //ing ya da türkçe girdi farketmeksizin herhangi bir ifadenin diğer karşılığını yazdırınız
            string kelime= Console.ReadLine();
            switch(kelime) {
                case"elma" :
                    Console.WriteLine("apple");
                    break;

                case "book":
                    Console.WriteLine("kitap");
                    break;

                case "computer":
                    Console.WriteLine("bilgisayar");
                    break;
                    default: break;
            }


            //girilen marka için 2şer araç yazdırınız
            string araci = Console.ReadLine();

            switch (araci)
            {
                case "fiat":
                    Console.WriteLine("egea \n doblo");
                    break;

                case "opel":
                    Console.WriteLine("mokka \n corsa");
                    break;
                default:
                    break;

            }
            //girilen rengin ingilizce karşılığını yazdırınız.

            string renk = Console.ReadLine();
            switch (renk)
            {
                case "mavi":
                    Console.WriteLine("blue");
                    break;

                case "sarı":
                    Console.WriteLine("yellow");
                    break;

                case "red":
                    Console.WriteLine("kırmızı");
                    break;

                default:
                    break;

            }
            //girilen renge göre hangi kıyafete en iyi olduğunu yazdırınız

            string kiyafet = Console.ReadLine();
            switch (kiyafet)
            {
                case "sarı":
                    Console.WriteLine("tişört");
                    break;

                case "lacivert":
                    Console.WriteLine("mont");
                    break;

                case "siyah":
                    Console.WriteLine("pantolon");
                    break;
                default:
                    break;
            }
            //girilen teknolojiye göre signalR, Hangfire, Sentry, Docker Elastic,Search,RabitMQ olacak şekilde bilgiler yazdırınız.
            string teknoloji = Console.ReadLine();
            switch (teknoloji)
            {
                case "signalR":
                    Console.WriteLine("Gerçek zamanlı iletişim");
                    break;

                case "Hangfire":
                    Console.WriteLine("arka plan işlemleri");
                    break;


                case "Sentry":
                    Console.WriteLine("hata izleme");
                    break;
                case "Docker":
                    Console.WriteLine("Konteynerleştirme");
                    break;
                case "ElasticSearch":
                    Console.WriteLine("arama motoru");
                    break;
                case "RabbitMQ":
                    Console.WriteLine("MESAJ KUYRUĞU");
                    break;
                default:
                    break;

            }

            //girilen bilgisayar parcası adına göre bir marka önerisinde bulunuz
            string parca = Console.ReadLine();
            switch (parca)
            {
                case "işlemci":
                    Console.WriteLine("intel");
                    break;

                case "anakart":
                    Console.WriteLine("asus");
                    break;
                default:
                    break;
            }
            //girilen ip adresine göre hangi siteye  yönlendirileceğini yazdırınız
        }

    }
}