using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_BMI
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("+" + new string('=', 30) + "+");
                Console.WriteLine("|        Kalkulator BMI        |");
                Console.WriteLine("+" + new string('=', 30) + "+");
                Console.Write("\nMasukkan berat badan (kg): ");
                double berat = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan tinggi badan (cm): ");
                double tinggi = Convert.ToDouble(Console.ReadLine());
                double convTinggi = tinggi / 100;

                double bmi = berat / (convTinggi * convTinggi);


                Console.WriteLine($"\nBMI Anda adalah: {bmi:F2}");

                if (bmi < 18.5)
                {
                    Console.WriteLine("Anda berada dalam kategori Kurus.");
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    Console.WriteLine("Anda berada dalam kategori Normal.");
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    Console.WriteLine("Anda berada dalam kategori Kelebihan Berat Badan.");
                }
                else
                {
                    Console.WriteLine("Anda berada dalam kategori Obesitas.");
                }

                Console.Write("\nApakah Anda ingin menjalankan kalkulator lagi? [y/n] ");
                string pilihan = Console.ReadLine().ToLower();

                if (pilihan == "n")
                {
                    running = false;
                }

            }
        }
    }
    
}
