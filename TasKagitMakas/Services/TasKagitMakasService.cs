namespace TasKagitMakas.Services
{
    class TasKagitMakasService
    {
        string[] _hareketler = new string[3]
        {
            "Kağıt" , "Taş"  , "Makas"
        };
        Random _rastgele = new Random();
        public int HareketOlustur()
        {
            int rastgekeIndex = _rastgele.Next(0, 3);
            return rastgekeIndex;
        }
        public string Oyna(int kullaniciHareketIndex, string rumuz = "Kullanıcı")
        {
            int bilgisayarHareketIndex = HareketOlustur();
            return $"{rumuz} : {_hareketler[kullaniciHareketIndex]}\n" +
                $"Bilgisayar: {_hareketler[bilgisayarHareketIndex]}\n" +
                $"Kazanan: {KazananiBul(bilgisayarHareketIndex, kullaniciHareketIndex , rumuz)}";
            

        }
        public string KazananiBul(int bilgisayarHareketiIndex, int kullaniciHareketiIndex, string rumuz)
        {
            string sonuc = "Berabere";
            int bilgisayarDeger = bilgisayarHareketiIndex == 2 && kullaniciHareketiIndex == 0 ? -1 : bilgisayarHareketiIndex;
            int kullaniciDeger = kullaniciHareketiIndex == 2 && bilgisayarHareketiIndex == 0 ? -1 : kullaniciHareketiIndex;
            if (bilgisayarDeger < kullaniciDeger)
                sonuc = "Bilgisayar";
            else if (kullaniciDeger < bilgisayarDeger)
                sonuc = rumuz;
            return sonuc;
        }
    }
}
