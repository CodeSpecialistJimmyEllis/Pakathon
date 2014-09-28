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
    class TextToSpeechObject
    {
        string[] monotext;
        SpriteFont Font1;

        enum TextToSpeechWords
        {
            sentence1, sentence2, sentence3, sentence4, sentence5
        }

        enum TextToSpeechChoices
        {
            choice1, choice2, choice3, choice4, choice5
        }

        TextToSpeechChoices texttospeechchoices;
        TextToSpeechWords texttospeechwords; 
        public TextToSpeechObject()
        {

            monotext = new string[3];
            for (int i = 0; i < 10; i++)
            {
                monotext = new string[i];

            }
            monotext[0] = "Title is Peter Pan one hour and fourty-three minutes is how long the movie is the rating is PG for Parental Guidance The  Star Cast is Jason Isaacs, Jeremy Sumpter, Rachel Wood, ludivine sagnier";
            monotext[2] = "Title is The Dark Knight With the help of Lieutenant Jim Gordon and District Attorney Harvey Dent, Batman sets out to destroy organized crime in Gotham for good. The triumvirate proves to be effective, but they soon find themselves prey to a prising criminal mastermind known as the joker, who thrusts gotham into anarchy and forces the Dark Knight ever closer to corssing the fine line between hero and vigilante.";

            monotext[1] = "Title is Evan Almighty Buffalo newsman evan Baxter is elected to Congress with the slogan, change the world he lucks into a huge house in a new virginia suburb. his capitol office is also fantastic, but there's a catch: he's tapped by the pwoerful congressman long to co-sponsor a bill to allow development in national parks. in steps God, who appears to a disbelieving Evan and gently commands him to build and ark. TOols and wood arrive in Evan's yard, animal pairs folow, his bear and hair grow wildly, nomand's clothes and a staff appear, long grows impatient, evans starts building, his family leaves him reporters gather, and drought grips D.C. still, evan beliefs. but will he change the world?";
            monotext[3] = "JESUS IS LORD!";
            monotext[4] = "JESUS IS THE KING OF KINGS!";

        }

        public void Initialize()
        {

           

        }

        public void LoadContent(ContentManager Content)
        {

            Font1 = Content.Load<SpriteFont>("content/Font1");

        }

        public void UploadContent()
        {



        }

        public void Update(GameTime gameTime)
        {



        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (texttospeechwords == TextToSpeechWords.sentence1)
            {
                spriteBatch.DrawString(Font1, monotext[0], new Vector2(0, 0), Color.White);
            }
            else if (texttospeechwords == TextToSpeechWords.sentence2)
            {
                spriteBatch.DrawString(Font1, monotext[1], new Vector2(0, 0), Color.White);
            }
            else if (texttospeechwords == TextToSpeechWords.sentence3)
            {
                spriteBatch.DrawString(Font1, monotext[2], new Vector2(0, 0), Color.White);
            }

            else if (texttospeechwords == TextToSpeechWords.sentence4)
            {
                spriteBatch.DrawString(Font1, monotext[3], new Vector2(0, 0), Color.White);
            }

            else if (texttospeechwords == TextToSpeechWords.sentence5)
            {
                spriteBatch.DrawString(Font1, monotext[4], new Vector2(0, 0), Color.White);
            }
        }


        public void ControlledBy_TextToSpeechEngine(string newChoice)
        {
            if (newChoice == "choice1")
            {
                texttospeechwords = TextToSpeechWords.sentence1;
            }
            else if (newChoice == "choice2")
            {
                texttospeechwords = TextToSpeechWords.sentence2;
            }

            else if (newChoice == "choice3")
            {   
                texttospeechwords = TextToSpeechWords.sentence3;
            }

            else if (newChoice == "choice4")
            {
                texttospeechwords = TextToSpeechWords.sentence4;

            }

            else if (newChoice == "choice5")
            {
                texttospeechwords = TextToSpeechWords.sentence5;
            }


        }

        public String[] SendTo_TextToSpeechEngine()
        {
            return monotext;
        }
    }
}
