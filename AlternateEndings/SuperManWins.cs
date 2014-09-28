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
    public class SuperManWins : GameScreen
    {

        #region Fields
        KeyboardState keyState;

        //JESUS IS LORD <<< GRAPHICS >>> DISPLAYS THE TEXT ON THE SCREEN JESUS IS LORD
        //JESUS IS LORD! <<< GRPAHICS >>> FONT USED TO DISPLAY MESSAGES
        SpriteFont font;

        //JESUS IS LORD <<< GRAPHICS >>> FONT USED TO DISPLAY MESSAGES
        SpriteFont font2;
        // JESUS IS LORD! <<< GRAPHICS / BACKGROUND >>> LOADS THE BACKGROUND FOR GOKU WIN JESUS IS LORD!
        Texture2D sWinBackground;
        Rectangle sWinRect;
        #region control fields

        bool isLooped = true;
        #endregion

        // <<< JESUS IS LORD!! <<< VIDEO JESUS IS THE KING>> CREATES THE VIDEO AND THE VIDE PLAYER FOR PLAYING VIDE JESUS IS LORD!! JESUSI S THE KING!
        Video supermanWinsVid;
        VideoPlayer supermanPlayer;
        // JESUS IS LORD <<< GRAPHICS / VIDEO >>> TEXTURE VIDEO DISPLAYS ON
        Texture2D supermanVidTexture;
        Rectangle supermanVidRect;
        // JESUS IS LORD! <<< GRAPHICS / SPRITES >>> THE SPRITES THAT APPEAR ON THE SCREEN ARE SUPERMAN HAVING LOST AND GOKU HAVING WON

        //JESUS IS LORD <<< CONTROL FLOW>>> 
        bool isDisposed = false;

        #endregion

        #region LoadContent
        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);


            #region LoadText
            //JESUS IS LORD <<< GRAPHICS >>> LOAD RESPECTIVE SPRITE FONTS FOR RESPECTIVE TEXT DISPLAY ON SCREEN JESUS IS LORD!
            if (font == null)
                font = content.Load<SpriteFont>("content/Font1");
            if (font2 == null)
                font2 = content.Load<SpriteFont>("content/Font2");
            #endregion 
            #region LoadBackgrounds
            // JESUS IS LORD <<< GRAPHICS / BACKGROUND >>> LOAD THE BACKGROUND AND CREATE IT'S RECTANGLE DIMENSIONS 

            sWinBackground = content.Load<Texture2D>("backgrounds/JESUSISLORDalt2win");
            sWinRect = new Rectangle(800, 600, 800, 600);

            #endregion

            #region LoadSprites
            // JESUS IS LORD <<< GRAPHICS /// SPRITES >>> THE SPRITES ARE GOKU HAVING WON AND SUPERMAN HAVING LOST APPEARING ON THE SCREEN JESUS IS LORD!



            #endregion
            #region LoadSounds

            // JESUS IS LORD!!! <<< SOUNDS /// SOUND EFFECTS & BACKGROUND MUSIC >>>> THE BACKGROUND MUSIC PLAYED AND THE SOUND EFFECTS OF SUPERMAN HAVING LOST 

            // TODO: SUPER MAN WORDS OF LOST. GOKU WORDS OF VICTORY. 

            #endregion
         
            #region LoadVideo
         //   Microsoft.Xna.Framework.Media.VideoPlayer
            // JESUS IS LORD!!! <<< VIDEO>>> JESUS IS LORD! THE VIDE WHERE GOKU WINS
            supermanPlayer = new VideoPlayer();
            supermanVidRect = new Rectangle(0, 0, 800, 600);
            supermanWinsVid = content.Load<Video>("videos/JESUSISLORDaltwinvid2");
            supermanPlayer.Volume = 1.0f;

         
            supermanPlayer.Play(supermanWinsVid);
            

            #endregion



        }
        #endregion

        #region UnloadContent
        public override void UnloadContent()
        {
            //  supermanVidTexture.Dispose();
            //  supermanVidRect.Dispose();
            //  supermanPlayer.Dispose(); 

            base.UnloadContent();
        }
        #endregion



        #region Update
        public override void Update(GameTime gameTime)
        {

            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Enter))
                ScreenManager.Instance.AddScreen(new SplashScreen());

            if (isDisposed == false)
            {
                if (supermanPlayer.State == MediaState.Stopped)
                {
                    if (isDisposed == false)
                    {

                        // UnloadContent();
                        //isDisposed = true;
                        sWinRect.X = 0;
                        sWinRect.Y = 0;
                    }
                }
            }

            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.D9))
            {
                ScreenManager.Instance.AddScreen(new SplashScreen(isLooped));
             
                UnloadContent();
                supermanPlayer.Dispose();
                supermanVidTexture.Dispose();
               

            }

        }
        #endregion

        #region Draw
        public override void Draw(SpriteBatch spriteBatch)
        {
            /*    spriteBatch.DrawString(font, "TitleScreen",
                   new Vector2(100, 100), Color.Black); */

            if (isDisposed == false)
            {
                supermanVidTexture = supermanPlayer.GetTexture();


                spriteBatch.Draw(supermanVidTexture, supermanVidRect, Color.White);
            }

            spriteBatch.Draw(sWinBackground, sWinRect, Color.White);
            spriteBatch.DrawString(font, "HIT 9 TO RESTART GAME", new Vector2(70, 550), Color.Blue);   


        }

        #endregion
    }
}
