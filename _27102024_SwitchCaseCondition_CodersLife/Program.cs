using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27102024_SwitchCaseCondition_CodersLife
{
    internal class Program
    {//----------> [SWITCH CASE KARAR YAPISI] <----------//
        /*
         * [Rules (Kurallar)]
         * Anahtar - Kapı ilişkisi gibi düşünülebilinir.
         * Bir adet anahtar ve bir veya birden fazla kapı içerir.
         * Birden fazla anahtar İÇERMEZ! (Önemli Not: Bu kural sadece normal switch case yapısı için geçerlidir!)
         * Anahtar, en az bir kapıya uymalıdır gibi bir zorunluluk YOKTUR!
         * Kapılar benzer olabilir fakat aynı olamaz.
         * Kapılar, anahtar türünde olmak zorundadır.
         * Anahtar Türleri: int, char, string, bool, enum, byte, sbyte, short, ushort, uint, long, ulong, float, double, decimal, nullable olabilir. (Not: Class'ın anahtar olabilmesi için Pattern Mathing yapısı kullanılmalıdır.)
         * Multiple Conditioning (Çoklu Koşullandırma): when keyword kullanımı.
         * 
         * [Örnekler]
         * Gün örneği (string ve enum ile yapılacak)
         * Mevsim Sezon örneği
         * Not Derecelendirme örneği
         * Extra: Mevsim Sezonu örneği (Switch Exrepssions ile)
         * 
         * ----------> [Switch Expressions] <----------
         * Normal Switch yapısıyla aynı mantıkta çalışır.
         * Normal Switch yapısına kıyasla daha okunaklıdır. (C# 8.0 ve üzerisi için kullanılabilinir.)
         * Birden fazla anahtar içerebilir.
         * 'default' keywordu yerine '_' keywordu kullanılır.
         */
        static void Main(string[] args)
        {
            #region Gün örneği (string ve enum ile yapılacak)
            //Gunler gun = Gunler.Cuma;

            //switch (gun)
            //{
            //    case Gunler.Pazartesi:
            //        break;
            //    case Gunler.Salı:
            //        break;
            //    case Gunler.Çarşamba:
            //        break;
            //    case Gunler.Perşembe:
            //        break;
            //    case Gunler.Cuma:
            //        Console.WriteLine("Cuma!");
            //        break;
            //    case Gunler.Cumartesi:
            //        break;
            //    case Gunler.Pazar:
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz bir gün girdisi!");
            //        break;
            //}
            #endregion
            #region Mevsim Sezon örneği
            //Console.Write("Lütfen ayı giriniz:");
            //int ay = int.Parse(Console.ReadLine());
            //switch (ay)
            //{
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar!");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yaz!");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Sonbahar!");
            //        break;
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış!");
            //        break;

            //    default:
            //        Console.WriteLine("Geçersiz ay girdisi!:" + ay);
            //        break;
            //}
            #endregion
            #region Not Derecelendirme örneği
            //Console.WriteLine("Lütfen öğrencinin notunu giriniz:");
            //int not = int.Parse(Console.ReadLine());
            //switch (not)
            //{
            //    case int n when (n >= 90 && n <= 100):
            //        Console.WriteLine("Pek İyi!");
            //        break;
            //    case int n when (n >= 80 && n < 90):
            //        Console.WriteLine("İyi!");
            //        break;
            //    case int n when (n >= 70 && n < 80):
            //        Console.WriteLine("Orta!");
            //        break;
            //    case int n when (n >= 60 && n < 70):
            //        Console.WriteLine("Kötü!");
            //        break;
            //    case int n when (n >= 0 && n < 60):
            //        Console.WriteLine("Çok Kötü!");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz not girişi!");
            //        break;
            //}
            #endregion
            #region Extra: Mevsim Sezonu örneği (Switch Exrepssions ile)
            //Console.Write("Lütfen ayı giriniz:");
            //int ay = int.Parse(Console.ReadLine();
            //string mevsim = ay switch
            //{
            //    12 or 1 or 2 => "Kış",
            //    3 or 4 or 5 => "İlkbahar",
            //    6 or 7 or 8 => "Yaz",
            //    9 or 10 or 11 => "Sonbahar",
            //    _ => "Geçersiz ay"
            //};
            //Console.WriteLine(mevsim);
            #endregion
            Console.ReadKey();
        }
    }
}
