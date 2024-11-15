namespace WindowsFormsApp1
{
    internal class SepetListesi
    {
        public string Adı { get; set; }
        public string Barkod { get; set; }
        public int Adet { get; set; }
        public float Fiyat { get; set; }
        public int stok { get; private set; }


       

        public float ToplamFiyat()
        {
            return Adet * Fiyat;
        }

    }

}