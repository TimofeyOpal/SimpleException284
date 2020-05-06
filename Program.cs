using System;
using System.Collections;


namespace SimpleException284
{
    class Program
    {
        static void Main(string[] args)
        {
            Car zippy = new Car(20, "zippy");
            zippy.TurnTunes(true);
            
            try { for (int i = 0; i < 20; i++) 
                    zippy.Accelerate(20); }

            catch(Exception e)
            {
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                Console.WriteLine("Help Link: {0}", e.HelpLink);

            }
            

            Console.ReadLine();

        }
    }
}
