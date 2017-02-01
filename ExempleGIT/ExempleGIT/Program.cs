using System;

namespace ExempleGIT
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
                Console.WriteLine("Hi");
        }
    }
#endif
}

