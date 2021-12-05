using Deneme2;
using System;

namespace Overloading
{
    class Program
    {
       

        static void Main(string[] args)
        {
           
            Console.WriteLine(Avarage(2, 3));
            Console.WriteLine(Avarage(2, 4, 5, 6));

            Students students = new Students();
            students.Adi = "gülsüm";
            students.Soyadi = "aslan";
            Console.WriteLine(students.Adi);
            Console.WriteLine(students.Soyadi);


            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Soyadi = "Onur ";
            ogretmen.Adi = "Doğukan";
            Console.WriteLine(ogretmen.Adi);
            Console.WriteLine(ogretmen.Soyadi);




            Console.ReadLine();
        }

      

        public static int Avarage(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2) / 2;
        }
        

        public static int Avarage(int sayi1,int sayi2,int sayi3 ,int sayi4)
        {
            return (sayi1 + sayi2 + sayi3 + sayi4)/2;

        }

    
    }
   


}
