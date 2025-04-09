namespace ConsoleApp6;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер варианта (1-30): ");
        int caseNumber = int.Parse(Console.ReadLine());

        
        Func<double, double, double>[] cases = new Func<double, double, double>[]
        {
            (y, f) => (Math.Exp(2 * y) + Math.Sin(f)) / Math.Log(3.8 * y + f), 
            (d, a) => Math.Log(d) + (3.5 * Math.Pow(d, 2) + 1) / Math.Cos(2 * a),
            (k, y) => (Math.Log(k - y) + Math.Pow(y, 4)) / (Math.Exp(y) + 2.355 * Math.Pow(k, 2)), 
            (w, y) => (9.33 * w + Math.Sqrt(w)) / (Math.Log(y + 3.5) + Math.Sqrt(y)), 
            (a, y) => (7.8 * Math.Pow(a, 2) + 3.52 * y) / (Math.Log(a + 2 * y) + Math.Exp(y)), 
            (l, y) => (0.81 * Math.Cos(l)) / (Math.Log(y) + 2 * Math.Pow(y, 3)), 
            (m, y) => (m * m + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6),
            (t, y) => (2.37 * Math.Sin(t + 1)) / (4 * Math.Sqrt(y) - 0.1 * y + 5),
            (y, w) => Math.Pow(y + 2 * w, 3) / Math.Log(y + 0.75), 
            (t, y) => (2 * t + y * Math.Cos(t)) / Math.Sqrt(y + 4.831), 
            (y, _) => (Math.Pow(y, 2) + 0.5 * y + 4.8) / Math.Sin(y), 
            (t, y) => (Math.Sin(Math.Pow(2 * t + 1, 2)) + 0.3) / Math.Log(t + y), 
            (h, y) => (Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Exp(y) + y),
            (h, y) => (Math.Exp(y + 2.5) + 7.1 * Math.Pow(h, 3)) / (Math.Sqrt(y) + 0.04 * h), 
            (y, j) => (2 * Math.Sin(0.354 * y + 1)) / Math.Log(y + 2 * j), 
            (r, _) => (4 * Math.Pow(r, 3) + Math.Log(r)) / (Math.Exp(r) + 7.2 * Math.Sin(r)), 
            (y, n) => Math.Pow(y, 2) - 0.8 * y + Math.Sqrt(y) + 23 * Math.Log(n), 
            (y, k) => (Math.Sqrt(Math.Sin(y)) + 6.835) / (Math.Log(y + k) + 3 * Math.Pow(y, 2)), 
            (q, y) => (Math.Log(0.7 * y + 2 * q)) / (Math.Sqrt(3 * y) + 0.5 * y + 4), 
            (t, y) => (2 * t * t + 3 * t + 7.2) / (Math.Log(y) + Math.Exp(2 * y)), 
            (k, x) => (Math.Sqrt(k + 2.6 * Math.Sin(k))) / (x - ( 3)), 
            (t, y) => (4.351 * y + 2 * t * Math.Log(t)) / (Math.Cos(2 * y) + 4.351),
            (y, d) => (Math.Sin(y) + 0.3 * d) / (Math.Exp(y) + d), 
            (k, y) => (Math.Log(2 * k + 4.3)) / (Math.Exp(k + y) + Math.Sqrt(y)), 
            (c, t) => (Math.Cos(c * c) + 3 * t * t + 4) / (Math.Sqrt(c) + t), 
            (u, y) => Math.Sin(2 * u) / Math.Log(2 * y + u), 
            (p, y) => (Math.Sin(p + 0.4) * Math.Sin(p + 0.4)) / (y * y + 7.325 * p), 
            (v, _) => (0.004 * v + Math.Exp(v)) / Math.Exp(2), 
            (h, y) => (0.355 * h * h - 4.355) / (Math.Exp(h) + Math.Sqrt(2.7 * y)), 
            (p, y) => (3 * y * y + Math.Sqrt(y) + 1) / (Math.Log(p + y) + Math.Exp(y)) 
        };

        if (caseNumber >= 1 && caseNumber <= cases.Length)
        {
            
            double result = cases[caseNumber - 1](2, 3);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Неверный номер варианта.");
        }
    }
}