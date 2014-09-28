// JESUS IS LORD! ONLY THROUGH CHRIST JESUS WHO IS GOD IS THIS POSSIBLE! JESUS IS LORD!



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
    public class TitleScreen : GameScreen
    {

        #region Fields 
        KeyboardState keyState;
        SpriteFont font;

        // JESUS IS LORD <<< GRAPHICS >>> TEXTURE FOR THE SLICE ON THE SCREEN 
        Texture2D screenSlice;
        Rectangle screenSliceRect;

        //JESUS IS LORD <<< SOUND EFFECTS>>> THE SOUND EFFECTS THAT LOAD AS SOON AS THE GAME SWITCHES SCREENS JESUS IS LORD
        SoundEffect[] screenSounds; 



        #endregion
        public override void LoadContent(ContentManager Content)
        {
           base.LoadContent(Content);
           if (font == null)
               font = content.Load<SpriteFont>("content/Font1");


            // JESUS IS LORD <<< CONTROL >>> INITIALIZE SCREEN SOUND AS AN ARRAY OF 3
            screenSounds = new SoundEffect[3];

           #region BACKGROUND LOAD JESUS IS LORD

           screenSlice = content.Load<Texture2D>("backgrounds/postencounter");
           screenSliceRect = new Rectangle(0, 0, 800, 600);
           #endregion 

            #region JESUS IS LORD <<< SOUND >>> JESUS IS LORD
            

           for (int x = 0; x < 3; x++)
            {
               if (x == 0)
                   screenSounds[x] = content.Load<SoundEffect>("sound/slice");
            else if (x == 1)
                   screenSounds[x] = content.Load<SoundEffect>("sound/beatup");
                else if (x == 2)
                   screenSounds[x] = content.Load<SoundEffect>("sound/explosion");
            }

            #endregion

            #region JESUS IS LORD <<< SPRITES/CHARACTERS/MOVABLEPIECES >>> JESUS IS LORD

            for(int y = 0; y < 3; y++)
            {
               screenSounds[y].Play();
               

            }

            #endregion 

        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {

            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.D1))
                ScreenManager.Instance.AddScreen(new GokuWins());
         //   if (keyState.IsKeyDown(Keys.D2))
             //   ScreenManager.Instance.AddScreen(new SuperManWins());


        }

        public override void Draw(SpriteBatch spriteBatch)
        {
           

            spriteBatch.Draw(screenSlice, screenSliceRect, Color.White);
            #region JESUS IS LORD <<< REPLACE EVERY GAME >>> JESUS IS THE KING!
            spriteBatch.DrawString(font, "KUNG FU!",
               new Vector2(0, 0), Color.White);
           /* spriteBatch.DrawString(font, "HEY EVERYBODY! JIMMY'S FRIENDS SUMMONED",
          new Vector2(0, 25), Color.White);
            spriteBatch.DrawString(font, " ALL THEIR GOKU SUPERMAN POWERS TO DEFEAT HIM!!!",
       new Vector2(0, 50), Color.White);

            spriteBatch.DrawString(font, "BUT HE IS THE SHIZNIZLAGAZNIA SO WHO KNOWS IF THEY ARE VICTORIOUS!!!!",
          new Vector2(0,75), Color.White);
            spriteBatch.DrawString(font, "WHO DO YOU THINK WON? Hit 1 FOR JIMMY(CREATOR)! HIT 2 FOR FRIENDS!!",
               new Vector2(0, 100), Color.White); */ 

            spriteBatch.DrawString(font, "KUNG FU IS HERE! HIT 1 FOR ENDING! ",
               new Vector2(0, 125), Color.White);

            #endregion 
        }
   
    

    }
}
