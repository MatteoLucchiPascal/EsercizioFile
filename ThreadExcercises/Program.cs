using System;
using System.IO;
using System.Threading;

namespace ThreadExcercises
{
    class Program
    {
        static int count = 0;
        
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(lettore));

            t1.Start();

            t1.IsBackground = true;

            string parola = "c";
            StreamReader documento = new StreamReader("input.txt");
            while (parola != null)
            {

                parola = documento.ReadLine();

                if (parola == "Thread")
                    count++;

                Thread.Sleep(1);

            }

           

        }

        static void lettore()
        {
            while(true)
            {
                Console.WriteLine(count);
                Thread.Sleep(1);

            }
           

        }
    }
}
