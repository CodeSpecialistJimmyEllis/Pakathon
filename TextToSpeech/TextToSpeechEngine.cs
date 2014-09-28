using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using WindowsFormsApplication1;
using Microsoft.Speech;

namespace JESUSISLORDplatformer
{
    class TextToSpeechEngine
    {
         WindowsFormsApplication1.MonoSpeak monospeak;

         enum TextToSpeechChoices
         {
             choice1, choice2, choice3, choice4, choice5
         }

         bool controlspeaking;
         TextToSpeechChoices texttospeechchoices;
         String sendtexttospeechchoices;
        
         KeyboardState speechkey;
    
        public TextToSpeechEngine()
        {
            monospeak = new MonoSpeak();
            speechkey = new KeyboardState();

            controlspeaking = false; 
        }

        public void Initialize()
        {

            monospeak.Initialize();
        }

        public void LoadContent(ContentManager Content)
        {

        }

        public void UploadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
              speechkey = Keyboard.GetState();


          
           
            if (speechkey.IsKeyDown(Keys.D1))
            {
               // LeapTTS.thecolor = Color.Black;
                texttospeechchoices = TextToSpeechChoices.choice1;


              //     monospeak.TextToSpeech(monotext[0]);
            }
            else  if (speechkey.IsKeyDown(Keys.D2))
            {


               // LeapTTS.thecolor =Color.Black;
                texttospeechchoices = TextToSpeechChoices.choice2;


                //   monospeak.TextToSpeech(monotext[0]);
            }
                /*
            else if (speechkey.IsKeyDown(Keys.D3))
            {
            
                texttospeechchoices = TextToSpeechChoices.choice3;


                //   monospeak.TextToSpeech(monotext[0]);
            }
            else if (speechkey.IsKeyDown(Keys.D4))
            {
             
                texttospeechchoices = TextToSpeechChoices.choice4;


                //   monospeak.TextToSpeech(monotext[0]);
            }
            else if (speechkey.IsKeyDown(Keys.D5))
            {
            
                texttospeechchoices = TextToSpeechChoices.choice5;


                //   monospeak.TextToSpeech(monotext[0]);
            } */

        }

        public void Draw(SpriteBatch spriteBatch)
        {

           
        }


        public void ReceiveFrom_TextToSpeechObject(String[] newmonotext)
        {

           // if (texttospeechchoices == TextToSpeechChoices.choice1)
           // {

                monospeak.TextToSpeech(newmonotext[0]);
                /*
            }

            else if (texttospeechchoices == TextToSpeechChoices.choice2)
            {

                monospeak.TextToSpeech(newmonotext[1]);
            }


            else if (texttospeechchoices == TextToSpeechChoices.choice3)
            {

                monospeak.TextToSpeech(newmonotext[2]);
            }


            else if (texttospeechchoices == TextToSpeechChoices.choice4)
            {

                monospeak.TextToSpeech(newmonotext[3]);
            }

            else if (texttospeechchoices == TextToSpeechChoices.choice5)
            {

                monospeak.TextToSpeech(newmonotext[4]);
            }

            else
            {

            }
                 */
        }

        public String Controlling_TextToSpeechObject()
        {
            if (texttospeechchoices == TextToSpeechChoices.choice1)
            {

                sendtexttospeechchoices = "choice1";

            }
            else if (texttospeechchoices == TextToSpeechChoices.choice2)
            {

                sendtexttospeechchoices = "choice2";

            }

            else if (texttospeechchoices == TextToSpeechChoices.choice3)
            {

                sendtexttospeechchoices = "choice3";

            }

            else if (texttospeechchoices == TextToSpeechChoices.choice4)
            {

                sendtexttospeechchoices = "choice4";

            }

            else if (texttospeechchoices == TextToSpeechChoices.choice5)
            {

                sendtexttospeechchoices = "choice5";

            }
            else
            {
                sendtexttospeechchoices = "choice1";
            }

            return sendtexttospeechchoices;

        }
    }
}
