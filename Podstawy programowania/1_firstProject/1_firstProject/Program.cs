using System;


namespace _1_firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("imie :"); //wyswietli imie
            Console.WriteLine("raz");
            /*komentarz
             * w wielu
             * liniach
             */

            /*
             * #
             * ##
             * ###
             */

            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");

            Console.WriteLine("#\n##\n###"); // \n przejscie do nowej lini

            string name;
            name = "kaziu";

            Console.WriteLine (name);
            // + oznacza konkatenacje 
            Console.WriteLine("Masz na imię: " + name);

            Console.WriteLine("masz na imię: {0}",name);

            int age = 27;

            Console.WriteLine("Masz na imię: {0}\nTwój wiek: {1}",name,age);

            sbyte age1 = 27;

            Console.WriteLine("Masz na imię: {0}\nTwój wiek: {1}", name, age1);




            Console.ReadKey();
        }
    }
}
