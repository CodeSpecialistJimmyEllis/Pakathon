using System;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

using System.Threading;  
namespace JESUSISLORDplatformer
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      
        static void Main(string[] args)
        {

            using (Game1 game = new Game1())
            {

             
            
                
                game.Run();
                
              
            }

           
        }
    }
#endif
}

