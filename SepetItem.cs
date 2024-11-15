namespace WindowsFormsApp1
{
    internal class SepetItem
    {
        public SepetItem(string adı, string barkod, int adet, float fiyat)
        {
            Adı = adı;
            Barkod = barkod;
            Adet = adet;
            Fiyat = fiyat;
        }

        public object Adı { get; internal set; }
        public object Barkod { get; internal set; }
        public object Adet { get; internal set; }
        public object Fiyat { get; internal set; }
    }
}