using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gizemliAda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek sayı dizisi
            int[] numbers = { 3, 5, 2 };
            List<string> validExpressions = new List<string>();

            // Operatörler
            char[] operators = { '+', '-', '*', '/' };

            // Geçerli ifadeleri bul
            FindExpressions(numbers, operators, "", 0, validExpressions);

            // Geçerli ifadeleri yazdır
            Console.WriteLine("Geçerli ifadeler:");
            foreach (var expr in validExpressions)
            {
                Console.WriteLine(expr);
            }

            // Kullanıcıdan devam etmesini bekleyin
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void FindExpressions(int[] numbers, char[] operators, string currentExpression, int lastIndex, List<string> validExpressions)
        {
            // Eğer şu anda geçerli bir ifade varsa ve sonucun pozitif olduğunu kontrol et
            if (!string.IsNullOrEmpty(currentExpression))
            {
                // İfadeyi değerlendir
                double result = EvaluateExpression(currentExpression);
                if (result > 0)
                {
                    validExpressions.Add(currentExpression);
                }
            }

            // Sayıları ve operatörleri eklemek için döngü
            for (int i = 0; i < numbers.Length; i++)
            {
                // Sayıyı ekle
                if (lastIndex < numbers.Length)
                {
                    if (string.IsNullOrEmpty(currentExpression))
                    {
                        FindExpressions(numbers, operators, numbers[i].ToString(), i + 1, validExpressions);
                    }
                    else
                    {
                        // Operatörleri ekleyerek yeni ifadeler oluştur
                        for (int j = 0; j < operators.Length; j++)
                        {
                            // İfadeye operatör ekleyin
                            string newExpression = currentExpression + " " + operators[j] + " " + numbers[i];
                            FindExpressions(numbers, operators, newExpression, i + 1, validExpressions);
                        }
                    }
                }
            }
        }

        static double EvaluateExpression(string expression)
        {
            // Basit bir ifadeyi değerlendirmek için bir hesaplama metodu
            // Burada "System.Data.DataTable" kullanarak ifadeyi değerlendiriyoruz
            var dataTable = new System.Data.DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
        }
    }
}
    

