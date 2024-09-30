using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMilyonerOlmakIster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int dogruCevapSayisi = 0;

            
            Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
            Console.WriteLine("a) Lama b) Deve");
            Console.Write("Cevabınızı girin (a/b): ");
            string cevap1 = Console.ReadLine().ToLower();

            if (cevap1 == "a")
            {
                Console.WriteLine("Doğru cevap! Lama tüküren bir hayvandır.");
                dogruCevapSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap. Doğru cevap 'a) Lama' olacaktı.");
            }


            if (dogruCevapSayisi < 2)
            {
                
                Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir?");
                Console.WriteLine("a) Venüs b) Mars");
                Console.Write("Cevabınızı girin (a/b): ");
                string cevap2 = Console.ReadLine().ToLower();

                if (cevap2 == "a")
                {
                    Console.WriteLine("Doğru cevap! Venüs, Dünya'ya en yakın gezegendir.");
                    dogruCevapSayisi++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap. Doğru cevap 'a) Venüs' olacaktı.");
                }
            }

            if (dogruCevapSayisi == 2 && dogruCevapSayisi==1 )
            {
                
                Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
                Console.WriteLine("a) 7 b) 12");
                Console.Write("Cevabınızı girin (a/b): ");
                string cevap3 = Console.ReadLine().ToLower();

                if (cevap3 == "b")
                {
                    Console.WriteLine("Doğru cevap! İşlemin sonucu 12'dir.");
                    dogruCevapSayisi++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap. Doğru cevap 'b) 12' olacaktı.");
                }
            }

            if (dogruCevapSayisi >= 2)
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
            }
            else
            {
                Console.WriteLine("Maalesef, büyük ödülü kazanamadınız.");
            }

            Console.ReadLine();
        }
    }
}
