using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace polinom
{
    static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nİlk polinomu girin (örnek: 2x^2 + 3x - 5) veya 'exit' yazarak çıkın:");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "exit") break;

                Console.WriteLine("İkinci polinomu girin (örnek: x^2 - 4):");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "exit") break;

                // Polinomları ayrıştır
                var poly1 = ParsePolynomial(input1);
                var poly2 = ParsePolynomial(input2);

                // Toplama ve çıkarma işlemleri
                var sum = AddPolynomials(poly1, poly2);
                var difference = SubtractPolynomials(poly1, poly2);

                // Sonuçları göster
                Console.WriteLine("\nToplam: " + PolynomialToString(sum));
                Console.WriteLine("Fark: " + PolynomialToString(difference));
            }

            Console.WriteLine("\nProgramdan çıkmak için Enter'a basın...");
            Console.ReadLine(); // Programın kapanmasını engeller
        }

        // Polinomu ayrıştırarak her terimi dictionary formatında kaydeder
         static Dictionary<int, double> ParsePolynomial(string input)
        {
            var polynomial = new Dictionary<int, double>();
            var matches = Regex.Matches(input, @"([+-]?\s*\d*)x?\^?(\d*)");

            foreach (Match match in matches)
            {
                string coefStr = match.Groups[1].Value.Replace(" ", "");
                string expStr = match.Groups[2].Value;

                double coef = coefStr == "+" || coefStr == "-" || coefStr == "" ?
                              (coefStr == "-" ? -1 : 1) : double.Parse(coefStr);
                int exp = expStr == "" ? (match.Value.Contains("x") ? 1 : 0) : int.Parse(expStr);

                if (polynomial.ContainsKey(exp))
                    polynomial[exp] += coef;
                else
                    polynomial[exp] = coef;
            }

            return polynomial;
        }

        // Polinom toplama işlemi
        static Dictionary<int, double> AddPolynomials(Dictionary<int, double> poly1, Dictionary<int, double> poly2)
        {
            var result = new Dictionary<int, double>(poly1);

            foreach (var term in poly2)
            {
                if (result.ContainsKey(term.Key))
                    result[term.Key] += term.Value;
                else
                    result[term.Key] = term.Value;
            }

            return result;
        }

        // Polinom çıkarma işlemi
         static Dictionary<int, double> SubtractPolynomials(Dictionary<int, double> poly1, Dictionary<int, double> poly2)
        {
            var result = new Dictionary<int, double>(poly1);

            foreach (var term in poly2)
            {
                if (result.ContainsKey(term.Key))
                    result[term.Key] -= term.Value;
                else
                    result[term.Key] = -term.Value;
            }

            return result;
        }

        // Polinomu yazdırmak için string formatına çevirme
         static string PolynomialToString(Dictionary<int, double> polynomial)
        {
            var terms = new List<string>();

            foreach (var term in polynomial)
            {
                if (term.Value == 0) continue;

                string coef = term.Value == 1 && term.Key != 0 ? "" : term.Value.ToString();
                string variable = term.Key == 0 ? "" : (term.Key == 1 ? "x" : $"x^{term.Key}");
                string sign = term.Value > 0 ? "+" : "-";

                terms.Add((terms.Count > 0 ? " " : "") + sign + " " + coef.Replace("-", "") + variable);
            }

            return string.Join(" ", terms).TrimStart('+', ' ');
        }
    }

}
    

