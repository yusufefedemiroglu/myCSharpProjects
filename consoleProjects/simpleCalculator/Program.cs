namespace simpleCalculator
{
using System; // this is turkish example of calculator. why is it turkish ? Because this was my academy project and using turkish language was obligatory for this project.

    class Program 
    {
        static void Main()
        {
            double kullaniciIslemi;

            do
            {
                Console.Clear();
                Console.WriteLine("Hesap Makinesi Uygulamasi");
                Console.WriteLine("-------------------------");
                Console.WriteLine("MENÜ");
                Console.WriteLine("1 - Toplama Islemi Yap");
                Console.WriteLine("2 - Çıkarma Islemi Yap");
                Console.WriteLine("3 - Carpma Islemi Yap");
                Console.WriteLine("4 - Bölme Islemi Yap");
                Console.WriteLine("5 - Cikis");
                Console.WriteLine("                        ");
                Console.WriteLine("Hangi Islemi Yapmak istiyorsunuz?");

                string kullaniciGirisi = Console.ReadLine();


                if (double.TryParse(kullaniciGirisi, out kullaniciIslemi))
                {

                    switch ((int)kullaniciIslemi)
                    {
                        case 1:
                            ToplamaIslemiYap();
                            break;
                        case 2:
                            CikarmaIslemiYap();
                            break;
                        case 3:
                            CarpmaIslemiYap();
                            break;
                        case 4:
                            BolmeIslemiYap();
                            break;
                        case 5:
                            Console.WriteLine("Uygulama Kapanıyor...");
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }

                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadLine();

            } while (kullaniciIslemi != 5);
        }

        static void ToplamaIslemiYap()
        {
            double birinciSayi, ikinciSayi;

            Console.Clear();
            Console.WriteLine("Toplama Islemi");
            Console.WriteLine("---------------");
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz:");

            if (double.TryParse(Console.ReadLine(), out birinciSayi))
            {
                Console.WriteLine("Lütfen 2. Sayiyi Giriniz:");

                if (double.TryParse(Console.ReadLine(), out ikinciSayi))
                {
                    Console.WriteLine("Girilen sayilarin Toplami = " + (birinciSayi + ikinciSayi));
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
            }
        }

        static void CikarmaIslemiYap()
        {
            double birinciSayi, ikinciSayi;

            Console.Clear();
            Console.WriteLine("Çıkarma Islemi");
            Console.WriteLine("---------------");
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz:");

            if (double.TryParse(Console.ReadLine(), out birinciSayi))
            {
                Console.WriteLine("Lütfen 2. Sayiyi Giriniz:");

                if (double.TryParse(Console.ReadLine(), out ikinciSayi))
                {
                    Console.WriteLine("Girilen sayilarin Çıkarması = " + (birinciSayi - ikinciSayi));
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
            }
        }

        static void CarpmaIslemiYap()
        {
            double birinciSayi, ikinciSayi;

            Console.Clear();
            Console.WriteLine("Carpma Islemi");
            Console.WriteLine("---------------");
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz:");

            if (double.TryParse(Console.ReadLine(), out birinciSayi))
            {
                Console.WriteLine("Lütfen 2. Sayiyi Giriniz:");

                if (double.TryParse(Console.ReadLine(), out ikinciSayi))
                {
                    Console.WriteLine("Girilen sayilarin Çarpımı = " + (birinciSayi * ikinciSayi));
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
            }
        }

        static void BolmeIslemiYap()
        {
            double birinciSayi, ikinciSayi;

            Console.Clear();
            Console.WriteLine("Bölme Islemi");
            Console.WriteLine("---------------");
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz:");

            if (double.TryParse(Console.ReadLine(), out birinciSayi))
            {
                Console.WriteLine("Lütfen 2. Sayiyi Giriniz:");

                if (double.TryParse(Console.ReadLine(), out ikinciSayi))
                {
                    if (ikinciSayi != 0)
                    {
                        Console.WriteLine("Girilen sayilarin Bölümü = " + (birinciSayi / ikinciSayi));
                    }
                    else
                    {
                        Console.WriteLine("Bir sayıyı 0'a bölemezsiniz. Lütfen geçerli bir sayı girin.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
            }
        }


    }
    



















}