using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
//using LeapLibrary;


namespace JESUSISLORDplatformer
{
    class ChangingBackgroundButtonEngine
    {

        bool longertime;
        bool timecontrol;
        bool changecontrol;
        int timeint;
        Rectangle gogobuttonrect;
        KeyboardState iitkey;
        enum ChosenButton
        {
            button1, button2
        }
        ChosenButton chosenbutton = ChosenButton.button1;

        public ChangingBackgroundButtonEngine()
        {
            changecontrol = false;
            longertime = false;
        }

        public void Initialize()
        {

            iitkey = new KeyboardState();
        }

        public void LoadContent(ContentManager Content)
        {
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime gameTime)
        {

            iitkey = Keyboard.GetState();


            if (longertime == false)
            {
                if (iitkey.IsKeyDown(Keys.Space))
                // if (((Game1.leapcollision.X > 0) && (Game1.leapcollision.X < 800)) && ((Game1.leapcollision.Y) > 0 && (Game1.leapcollision.Y < 600)))
                {

                    longertime = true;
                    if (ChangingBackgroundState.backgroundchanger <= 9)
                    {
                        ChangingBackgroundState.backgroundchanger += 1;
                        changecontrol = true;
                    }
                    else if (ChangingBackgroundState.backgroundchanger == 10)
                    {
                        ChangingBackgroundState.backgroundchanger = 0;
                    }


                    }
                
            }
            
            if (iitkey.IsKeyDown(Keys.LeftAlt))
            {
                longertime = false;
            }
            if (iitkey.IsKeyDown(Keys.M))
            //if (gogobuttonrect.Intersects(Game1.leapcollision))
            {

                chosenbutton = ChosenButton.button2;
                ScreenManager.Instance.AddScreen( new OpeningTitleScreen()); 
            }

        


            else
            {
                chosenbutton = ChosenButton.button1;


            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }

        public string SendTo_ButtonObject()
        {
            if (ChosenButton.button1 == chosenbutton)
            {
                return "button1";
            }
            else if (ChosenButton.button2 == chosenbutton)
            {
                return "button2";
            }

            else
            {
                return "button1";
            }
        }

        public void ReceiveFrom_ButtonObject(Rectangle newgogobuttonrect)
        {

            this.gogobuttonrect = newgogobuttonrect;
        }
    }
}
