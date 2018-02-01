using System;

namespace Proto_game
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
            //you say run !!!
            //Vous savez parfois vous pensez que la vie vous offre un kiwi mais en faite lol non c'est un cactus
        }
    }
#endif
}
