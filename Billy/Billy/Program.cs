using System;

namespace Billy
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Billy game = new Billy())
            {
                game.Run();
            }
        }
    }
#endif
}

