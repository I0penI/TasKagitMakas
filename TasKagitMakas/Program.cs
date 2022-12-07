using TasKagitMakas.Models;
using TasKagitMakas.Services;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyucnu oyuncu = new Oyucnu();
            Console.Write("Kullanıcı Adı: ");
            oyuncu.Rumuz = Console.ReadLine();
            Console.Write("Ad: ");
            oyuncu.Adi = Console.ReadLine();
            Console.Write("Soyad: ");
            oyuncu.Soyadi = Console.ReadLine();


            TasKagitMakasService servis = new TasKagitMakasService();
            Console.Write("Kağıt için (0), Taş için (1), Makas için (2), Çıkış (3) : ");
            int giris = Convert.ToInt32(Console.ReadLine());
            string sonuc ;
          
            while(giris != 3)
            {
                Console.WriteLine($"Oyuncu: {oyuncu.Adi} {oyuncu.Soyadi}");
                Console.WriteLine(servis.Oyna(giris, oyuncu.Rumuz));
                Console.Write("Kağıt için (0), Taş için (1), Makas için (2), Çıkış (3) : ");
                giris = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}