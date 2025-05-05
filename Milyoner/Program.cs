using System;

namespace Milyoner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
            Console.WriteLine("(a) Lama b) Deve");
            string firstAnswer = Console.ReadLine().ToLower();
            //dogru cevap sayisini tutuyorum 
            int counter = 0;

            if (firstAnswer == "a")
            {
                //cevabin dogru olmasi sartinda counter 1 arttirilir
                Console.WriteLine("Tebrikler doğru cevap!");
                counter++;
            }
            else
            {
                //yanlis olmasi sartinda ekrana mesaj yazdiriyorum
                Console.WriteLine("Yanlış cevap!");
            }

            Console.WriteLine("2 -> Aşağıdakilerden hangisi Türkiye’nin komşusu bir ülke değildir?");
            Console.WriteLine("a) Almanya b) İran ");
            string secondAnswer = Console.ReadLine().ToLower();

            if (secondAnswer == "a")
            {
                //cevabin dogru olmasi sartinda counter 1 arttirilir
                Console.WriteLine("Tebrikler doğru cevap!");
                counter++;
            }
            else
            {
                //yanlis olmasi sartinda ekrana mesaj yazdiriyorum
                Console.WriteLine("Yanlış cevap!");
            }

            if (counter == 0)
            {
                //2 soruya da yanlis cevap verildiyse 3. soru sorulmuyor
                Console.WriteLine("ilk 2 soruyu yanlış cevapladığınız için yarışma sona erdi");
            }
            else
            {

                Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
                Console.WriteLine("a) 7 b) 12 ");
                string thirdAnswer = Console.ReadLine().ToLower();
                if (thirdAnswer == "b")
                {
                    //cevabin dogru olmasi sartinda counter 1 arttirilir
                    Console.WriteLine("Tebrikler doğru cevap!");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap!");
                }


                if (counter >= 2)
                {
                    //Toplam dogru sayisi 2 ve 2 den fazlaysa dogru sayisiyla beraber kazandınız mesajı verilir
                    Console.WriteLine($"Toplam dogru sayiniz: {counter} Tebrikler 1 Milyon TL kazandınız! ");
                }
                else
                {
                    //Dogru sayisi 2 den az ise dogru sayisi ve kazanamadiniz mesaji verilir
                    Console.WriteLine($"Toplam dogru sayiniz: {counter} maalesef buyuk odulu kazanamadınız! ");
                }
            }
        }

        }
    }
