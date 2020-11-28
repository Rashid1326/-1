using System;
using System.IO;
using System.Security.Cryptography;

namespace Лаба2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double age, birth, city, drive, epoch;
            double user, pwd;
            age = Convert.ToDouble(Console.ReadLine());
            birth = Convert.ToDouble(Console.ReadLine());
            city = Convert.ToDouble(Console.ReadLine());
            drive = Convert.ToDouble(Console.ReadLine());
            epoch = Convert.ToDouble(Console.ReadLine());

            if ((birth < 0) || (drive < 0))
                Console.WriteLine("ERROR");
            else
            {
                user = age / Math.Sqrt(birth) + city / Math.Sqrt(drive);
                Console.WriteLine(String.Format("{0:0.000}", user));
            }

            if ((city < 0) || (drive < 0 ) || (epoch < 0 ))
                Console.WriteLine("ERROR");
            else
            {
                pwd = Math.Sqrt(city - Math.Sqrt(drive - Math.Sqrt(epoch)));
                Console.WriteLine(String.Format("{0:0.000}", pwd));
            }




            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();



       
        }
    }
}
