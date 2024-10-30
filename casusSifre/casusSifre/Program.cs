using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casusSifre
{
    class Program
    {
        static void Main(string[] args)
        
            {
                string encryptedMessage = "şifrelenmiş mesaj"; // Buraya şifrelenmiş mesajınızı girin.
                string decryptedMessage = DecryptMessage(encryptedMessage);
                Console.WriteLine("Çözülmüş Mesaj: " + decryptedMessage);

            // Programın bitmeden önce kullanıcıdan bir tuşa basmasını bekleyin
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey(); // Kullanıcı bir tuşa bastığında devam eder
        }

            // Fibonacci dizisini oluştur
            static List<int> GenerateFibonacci(int length)
            {
                List<int> fibonacci = new List<int> { 1, 1 };
                for (int i = 2; i < length; i++)
                {
                    fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                }
                return fibonacci;
            }

            // Asal kontrolü
            static bool IsPrime(int num)
            {
                if (num <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }

            // Şifre çözme işlemi
            static string DecryptMessage(string encryptedMessage)
            {
                int length = encryptedMessage.Length;
                List<int> fibonacci = GenerateFibonacci(length);
                char[] decryptedChars = new char[length];

                for (int i = 0; i < length; i++)
                {
                    int modValue = (int)encryptedMessage[i];

                    // Pozisyon 1'den başlıyor
                    int position = i + 1;

                    // Mod işlemini tersine çevir
                    int originalValue;
                    if (IsPrime(position))
                    {
                        // Asal pozisyonda mod 100 ile çarpım
                        originalValue = (modValue + 100) % 256; // 100 ile ters mod işlemi
                    }
                    else
                    {
                        // Asal olmayan pozisyonda mod 256 ile çarpım
                        originalValue = (modValue + 256) % 256; // 256 ile ters mod işlemi
                    }

                    // Fibonacci ile çarpım
                    decryptedChars[i] = (char)(originalValue / fibonacci[i]);
                }

                return new string(decryptedChars);
            }
        }
    }
    

