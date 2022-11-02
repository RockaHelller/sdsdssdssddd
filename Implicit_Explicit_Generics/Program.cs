using System;

namespace Implicit_Explicit_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Explicit
            //Manat manat = new Manat(100);

            //Dollar dollar = manat;

            //Console.WriteLine(dollar.USD);

            //Bird bird = new Bird();

            //Animal animal = bird;

            //DateTime date = DateTime.Now;

            //Console.WriteLine(date.ToString("MMMM yy"));
            #endregion



        }
    }

    public class StringList
    {
        private string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }
         
        public void Add()
        {

        }



    }



    //public class Dollar
    //{
    //    public double USD { get; set; }

    //    public Dollar(double usd)
    //    {
    //        USD = usd;
    //    }

    //}



    //public class Manat
    //{
    //    public double AZN { get; set; }

    //    public Manat(double azn)
    //    {
    //        AZN = azn;
    //    }

    //    public static implicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.AZN / 1.7);
    //        //return dollar;
    //    }

    //}



}
