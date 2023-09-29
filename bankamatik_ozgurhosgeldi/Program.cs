using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bankamatik_ozgurhosgeldi
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 2500;
            string sifre = "ab18";
            
            Console.WriteLine("ATM'ye hoşgeldiniz! Lütfen yapmak istediğiniz işlemi tuşlayınız: ");

            Console.WriteLine("1 Kartlı İşlem");
            Console.WriteLine("2 Kartsız İşlem");
            string adım = Console.ReadLine();

            if (adım == "1")
            {
                while(true)
                {
                    Console.Write("Lütfen şifrenizi giriniz: ");
                    string sifre1 = Console.ReadLine();
                    int hak = 3;

                    if (sifre1 == sifre)
                    {

                        Console.WriteLine("Başarılı bir şekilde giriş yaptınız.");

                        Console.WriteLine("ANA MENÜ /Lütfen yapmak istediğiniz işlemi tuşlayınız");
                        Console.WriteLine("1 para çekme");
                        Console.WriteLine("2 para yatırma");
                        Console.WriteLine("3 para Transferi");
                        Console.WriteLine("4 Bilgi güncelleme");


                        string AnaMenu = Console.ReadLine();

                        if (AnaMenu == "1")
                        {
                            Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                            double cekilecekTutar = Convert.ToDouble(Console.ReadLine());


                            if (cekilecekTutar <= bakiye)
                            {

                                Console.WriteLine("Çekilen tutar: " + cekilecekTutar + "Güncel Bakiyeniz: " + (bakiye - cekilecekTutar) + " 9 Ana Menüye Dön 0 Hesaptan çık");
                                string secim = Console.ReadLine();
                                bakiye = bakiye - cekilecekTutar;

                                if (secim == "9")
                                {

                                }
                                else if (secim == "0")
                                {
                                    Console.WriteLine("Hesaptan çıkış yapıldı.");
                                }


                            }

                            else if (cekilecekTutar > bakiye)
                            {
                                Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır. 9 Ana Menüye Dön 0 Hesaptan çık");
                                string secim = Console.ReadLine();
                                if (secim == "9")
                                {

                                }
                                else if (secim == "0")
                                {
                                    Console.WriteLine("Hesaptan çıkış yapıldı.");
                                }
                            }
                        }


                        else if (AnaMenu == "2")
                        {
                            Console.WriteLine("1 Kredi Kartına Para Yatırın");
                            Console.WriteLine("2 Kendi Hesabına Para Yatır");
                            string secim = Console.ReadLine();
                            if (secim == "1")
                            {
                                hak = 3;

                                while (hak > 0)
                                {
                                    Console.WriteLine("12 haneli kredi kartı numaranızı giriniz.");
                                    string kredikartı = Console.ReadLine();

                                    if (kredikartı.Length != 12)
                                    {
                                        hak--;
                                        Console.WriteLine("kart numaranızı 12 haneli olacak şekilde tuşlayınız.");
                                    }
                                    if (hak == 0)
                                    {
                                        Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim1 = Console.ReadLine();
                                        if (secim1 == "9")
                                        {

                                        }
                                        else if (secim1 == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (kredikartı.Length == 12)
                                    {
                                        Console.Write("yatırılacak tutarı giriniz:");
                                        double yatirilacakTutar = Convert.ToDouble(Console.ReadLine());
                                        if (bakiye >= yatirilacakTutar)
                                        {
                                            bakiye = bakiye - yatirilacakTutar;
                                            Console.WriteLine("Kredi Kartına ödeme yapılmıştır./Güncel Bakiye: " + bakiye);
                                            Console.WriteLine("9 Ana Menüye Dön/0 Hesaptan çık");
                                            string secim1 = Console.ReadLine();
                                            if (secim1 == "9")
                                            {

                                            }
                                            else if (secim1 == "0")
                                            {
                                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Hesabınızda yeterli bakiye bulunmamaktadır.");
                                            Console.WriteLine("9 Ana Menüye Dön/ 0 Hesaptan çık");
                                            string secim1 = Console.ReadLine();
                                            if (secim1 == "9")
                                            {

                                            }
                                            else if (secim1 == "0")
                                            {
                                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (secim == "2")
                            {
                                Console.Write("Lütfen hesabınıza yatırmak istediğiniz tutarı giriniz: ");
                                double yatacakmiktar = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= yatacakmiktar)
                                {
                                    bakiye = bakiye - yatacakmiktar;
                                    Console.WriteLine("Tutar hesabınıza aktarılmıştır. Güncel Bakiyeniz: " + bakiye);
                                    Console.WriteLine("9 Ana Menüye Dön 0 Hesaptan çık");
                                    string secim1 = Console.ReadLine();
                                    if (secim1 == "9")
                                    {

                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                                    Console.WriteLine("9 Ana Menüye Dön 0 Hesaptan çık");
                                    string secim1 = Console.ReadLine();
                                    if (secim1 == "9")
                                    {

                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                            }
                        }

                        else if (AnaMenu == "3")
                        {
                            Console.WriteLine("yapmak istediğiniz işlemi tuşlayınız");
                            Console.WriteLine("1 Başka Hesaba EFT");
                            Console.WriteLine("2 Başka Hesaba Havale");
                            string secim2 = Console.ReadLine();

                            if (secim2 == "1")
                            {

                                Console.Write("Başına TR ekleyerek EFT yapılacak hesap numarasını giriniz: ");
                                string EFTno = Console.ReadLine();
                                if (EFTno.StartsWith("TR") && EFTno.Length == 14)
                                {
                                    Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz: ");
                                    double gonderilecekTutar = Convert.ToDouble(Console.ReadLine());
                                    if (gonderilecekTutar > bakiye)
                                    {
                                        Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                                        Console.WriteLine("9 Ana Menüye Dön");
                                        Console.WriteLine("0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {

                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (gonderilecekTutar < bakiye)
                                    {
                                        bakiye = bakiye - gonderilecekTutar;
                                        Console.WriteLine("EFT başarıyla oldu. Yeni Bakiyeniz: " + bakiye);
                                        Console.WriteLine("9 Ana Menüye Dön 0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {

                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }

                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Yanlış EFT Numarası. Lütfen başına TR ekleyin ve 12 haneli bir numara girin.");

                                }

                            }
                            else if (secim2 == "2")
                            {

                                Console.Write(" 11 haneli hesap numarasını giriniz: ");
                                string hesapNo = Console.ReadLine();
                                if (hesapNo.Length == 11)
                                {
                                    Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz: ");
                                    double gonderilecekTutar = Convert.ToDouble(Console.ReadLine());
                                    if (gonderilecekTutar > bakiye)
                                    {
                                        Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır. \n9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {

                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (gonderilecekTutar < bakiye)
                                    {
                                        bakiye = bakiye - gonderilecekTutar;
                                        Console.WriteLine("EFT yapılmıştır. Yeni Bakiyeniz: " + bakiye);
                                        Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {

                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }

                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Hatalı Hesap Numarası. Lütfen 11 haneli bir numara girin.");

                                }
                            }

                        }
                        else if (AnaMenu == "6")
                        {
                            Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız: ");
                            Console.WriteLine("1 Şifre değiştirme");
                            string sifreDegistir = Console.ReadLine();
                            Console.WriteLine("Lütfen yeni şifrenizi tuşlayınız: ");
                            string yeniSifre = Console.ReadLine();
                            sifre = yeniSifre;
                            Console.WriteLine("Şifren başarıyla değişmiştir./9 Ana Menüye Dön /0 Hesaptan Çık");
                            string secim1 = Console.ReadLine();

                            if (secim1 == "9")
                            {

                            }
                            else if (secim1 == "0")
                            {
                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                            }
                        }

                        break;
                    }
                    else
                    {
                        hak--;
                        Console.WriteLine("Yanlış şifre. Kalan deneme hakkı " + hak);
                    }

                    if (hak == 0)
                    {
                        Console.WriteLine("3 yanlış deneme sonucu kartınız bloke olmuştur. Lütfen müşteri temsilcisiyle iletişime geçiniz.");
                        break;
                    }
                }
            }

            

            Console.ReadLine();
        }
    }
}



