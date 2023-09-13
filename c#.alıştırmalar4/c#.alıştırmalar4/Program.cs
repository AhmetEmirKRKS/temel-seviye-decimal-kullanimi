using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_.alıştırmalar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("lutfen iki sayi giriniz:");
            Console.WriteLine("1.sayi:");
            string sayi1= Console.ReadLine(); ;
            Console.WriteLine("2.sayi:");
           string sayi2 = Console.ReadLine();
            decimal s1=Convert.ToDecimal(sayi1);
            decimal s2=Convert.ToDecimal(sayi2);
            decimal toplama=s1+s2;
            decimal cikarma =s1-s2;
            decimal carpma = s1 * s2;
            decimal bolme = s1 / s2;
            Console.WriteLine("toplami:" + toplama);
            Console.WriteLine("cıkarma:" + cikarma);
            Console.WriteLine("carpma:" + carpma);
            Console.WriteLine("bolme:" + bolme);
            Console.ReadLine();
            Console.Clear();    
        }
    }
}
