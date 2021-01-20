using System;
using System.Threading;
using WindowsInput.Native;
using WindowsInput;

namespace WeLoveSpam_
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
                                Değişkenlerin Başlangıcı.
            */
            string SpamMesaji;
            int SpamSayisi;
            int SpamAnlik = 0;
            InputSimulator yolla = new InputSimulator();
            /*
                                Değişkenlerin Bitişi.
            */


            Console.WriteLine("Spamlanacak Mesajı Giriniz: ");
            SpamMesaji = Console.ReadLine();

            Console.WriteLine("Ne Kadar Spamlanacak? ");
            SpamSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Spam 3 saniye içinde başlayacak..");
            Thread.Sleep(3000);
            Console.WriteLine("Spam Başladı!");

            while (SpamAnlik < SpamSayisi)
            {
                yolla.Keyboard.TextEntry(SpamMesaji);
                yolla.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                yolla.Keyboard.Sleep(1000);
                SpamAnlik += 1;
            }
            

            Console.ReadKey();
        }
    }
}
