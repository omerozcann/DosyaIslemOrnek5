using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String secim = "",veri;
            Console.WriteLine("Ne yapmak istiyorsunuz Kayıt(K) / Listele(L) ?");
            secim= Console.ReadLine();
            if(secim=="K")
            {
                Console.WriteLine("Kaydedilecek Metni Yazınız:");
                veri=Console.ReadLine();
                File.WriteAllText("kayitlar.txt",veri);
            }else if(secim=="L")
            {
                Console.WriteLine("Kayıtlı Verileriniz:");
                veri = File.ReadAllText("kayitlar.txt");
                Console.WriteLine(veri);
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız!");
            }     
            //Not: Dosya işlemlerinde dizin belirtilmezse, varsayılan dizin
            //programın olduğu dizindir.
            //Not:File.WriteAllText komutu her defasında eski dosyayı siler
            //yeniden oluşturur
        }
    }
}
