using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace JESUSISLORDplatformer
{
    class FireBallSystem
    {

        Texture2D fireball;
        Rectangle fireballrect;
        SpriteBatch FireBatch;
        Texture2D[] blueletters;
        Rectangle blueletterrect;

        KeyboardState keyhit;
        KeyboardState correctkey;
        Random LetterChoice;
        bool correct;

        bool timetochoose = true; 
        enum BlueLetters
        {
            A,S,K
        };

        public FireBallSystem()
        {
            blueletters = new Texture2D[3];

            for (int x = 0; x <= 3; x++)
            {
                blueletters = new Texture2D[x];
            }

           // blueletters = new Texture2D[2];
            LetterChoice = new Random();
        }


        public void Initialize() 
        {
         //Texture2D[] blueletters = new Texture2D[3];
           
        }

        public void LoadContent(ContentManager Content)
        {
            //Texture2D[] blueletters = new Texture2D[3];
            //LetterChoice = new Random();

            // graphics letters
          blueletters[0] = Content.Load<Texture2D>("FireBallSystem/A");
          blueletters[1] = Content.Load<Texture2D>("FireBallSystem/S");
          blueletters[2] = Content.Load<Texture2D>("FireBallSystem/K");
          blueletterrect = new Rectangle(0, 0, 256, 256);

            //graphics fireball
          fireball = Content.Load<Texture2D>("FireballSystem/fireball");
          fireballrect = new Rectangle(0, 0, 256, 256);
        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            if (timetochoose)
            {
                int drawrandom = RandomLetterChoice();
                // graphics draw letter
                 spriteBatch.Draw(blueletters[drawrandom], blueletterrect , Color.White);
            }


        }

        public int RandomLetterChoice()
        {

            int thechoice = 0;
            thechoice = LetterChoice.Next(0, 2);

            return thechoice;
        }



    }
}
