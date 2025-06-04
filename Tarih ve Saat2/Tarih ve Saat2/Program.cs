using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarih_ve_Saat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İki tarih arasında fark hesaplama
            DateTime baslangic = new DateTime(2025, 6, 1);
            DateTime bitis = new DateTime(2025, 6, 15);

            TimeSpan fark = bitis - baslangic;

            Console.WriteLine("Başlangıç tarihi: " + baslangic.ToShortDateString());
            Console.WriteLine("Bitiş tarihi: " + bitis.ToShortDateString());
            Console.WriteLine("Gün farkı: " + fark.TotalDays + " gün");

            // Şu an ile gelecek arasındaki fark
            DateTime simdi = DateTime.Now;
            DateTime hedefZaman = simdi.AddHours(5).AddMinutes(30);
            TimeSpan kalanSure = hedefZaman - simdi;

            Console.WriteLine("\nŞimdiki Zaman: " + simdi);
            Console.WriteLine("Hedef Zaman: " + hedefZaman);
            Console.WriteLine("Kalan Süre: " + kalanSure.Hours + " saat " + kalanSure.Minutes + " dakika");
        }
    }
}
