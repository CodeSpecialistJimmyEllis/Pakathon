// JESUS IS LORD! JESUS IS LORD!


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

/*

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;  */

namespace JESUSISLORDplatformer
{
    class SplashScreen : GameScreen
    {

        #region Fields 
        KeyboardState keyState;
        //JESUS IS LORD <<< GRAPHICS >>> DISPLAYS THE TEXT ON THE SCREEN JESUS IS LORD
        //JESUS IS LORD! <<< GRPAHICS >>> FONT USED TO DISPLAY MESSAGES
        SpriteFont font;

        //JESUS IS LORD <<< GRAPHICS >>> FONT USED TO DISPLAY MESSAGES
        SpriteFont font2;


      

  
        ScrollingBackground scrollingkungfu;
        #region JESUS IS LORD GAME 18 VARIABLES JESUS IS LORD
        // JESUS IS LORD <<< GRAPHICS>>> THE GOKU/SUPERMAN GRAPHICS HAVE FIGHT POSE AS ARRAY PLACE 1 AND LOSE POSE AS ARRAY PLACE 2 JESUS IS LORD!
        Texture2D[] goku;
        Texture2D[] superman;
        // JESUS IS LORD <<< GRAPHICS >>> RECTANGLES FOR SCREEN PLACE MENT! JESUS IS LORD!
        Rectangle gokuRect;
        Rectangle supermanRect;
        Texture2D background;
        Rectangle backgroundRect;
        // JESUS IS LORD <<< RECTANGLE FOR SCREEN STATE PLACE MENT >>> GRAHPICS JESUS IS LORD!
        Rectangle screenStateRect;

        //JESUS IS LORD <<< SOUND >>> BACKGROUND MUSIC AND SOUND EFFECTS JESUS IS LORD!
        Song backgroundMusic;
        SoundEffect slice;
        SoundEffect explosion;
        SoundEffect beatUp;

        // JESUS IS LORD <<< GRAPHICS>>> EFFECTS THAT FOLLOW CHARACTERS 
        Texture2D blueLight;
        Texture2D redLight;
        Rectangle blueRect;
        Rectangle redRect;
        bool displayEndScenes = false; 

        //meter object and engine
       
        #endregion 
        #endregion 

        #region Constructor
        //JESUS IS LORD <<< CONSTRUCTOR CONTROL>>>


        public  SplashScreen(bool choice)
        {
          
           // say = new TextEngine("say", 3, new Vector2(0,410));
          //  gre = new TextEngine("gre", 3, new Vector2(200,410));
          //  gory = new TextEngine("gory", 4, new Vector2(400,410));
           // wins = new TextEngine("wins", 4, new Vector2(600,410));
            this.displayEndScenes = choice;
         

        }
        public SplashScreen()
        {

       
         
        }
        #endregion 

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
      
           
            // JESUS IS LORD <<< CONTROL >>> INITIALIZE A BUNCH OF ARRAYS FOR USE WITH LOADING TEXTURES THROUGH FOR LOOP JESUS IS LORD
           #region ARRAYS OF TEXTURES GAME 18
           goku = new Texture2D[2];
           superman = new Texture2D[2];
           #endregion 

      
            //fireball system

         
           #region JESUS IS LORD GAME 18 LOADING character TEXTURES IN ARRAYS JESUS IS LORD!
           // JESUS IS LORD <<< GRAPHICS >>> LOAD SPRITES INTO ARRAYS superman and goku JESUS IS LORD!
           for (int i = 0; i <= 2; i++)
           {
               if (i == 0)
                   goku[i] = Content.Load<Texture2D>("characters/chr1");
               else if (i == 1)
                   goku[i] = Content.Load<Texture2D>("characters/goku1");

           }

           for (int x = 0; x <= 2; x++)
           {
               if (x == 0)
                   superman[x] = Content.Load<Texture2D>("characters/chr2");
               else if (x == 1)
                   superman[x] = Content.Load<Texture2D>("characters/superman1");

           }

#endregion
           #region JESUS IS LORD!! <<<<< GRAPHICS BACKGROUND >>>
           gokuRect = new Rectangle(500, 50, 200, 307);
           supermanRect = new Rectangle(0, 50, 250, 300);

           background = Content.Load<Texture2D>("backgrounds/masterbackground");
           backgroundRect = new Rectangle(0, 0, 800, 600);

      
           #endregion 

            #region JESUS IS LORD <<< SOUND >>> SONGS AND SOUND EFFECTS FOR GAME

           backgroundMusic = Content.Load<Song>("sound/bgmusic01");
           MediaPlayer.Volume = 0.2f;
            MediaPlayer.Play(backgroundMusic);

           slice = Content.Load<SoundEffect>("sound/slice");
           explosion = Content.Load<SoundEffect>("sound/explosion");
           beatUp = Content.Load<SoundEffect>("sound/beatup");
            #endregion 
           scrollingkungfu = new ScrollingBackground();
           scrollingkungfu.LoadContent(Content);
            #region EFFECTS JESUS IS LORD! 

            // JESUS IS LORD << DRAWS EFFECTS AND LIGHTNING AND SUCH JESUS IS LORD!@
           blueLight =  Content.Load<Texture2D>("effects/JESUSISLORDeffectright");
          redLight =   Content.Load<Texture2D>("effects/JESUSISLORDeffectleft");

            redRect = new Rectangle(0, 200 ,132,132);
            blueRect = new Rectangle(650,200,132,132);
            #endregion 

        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {

            #region     JESUS IS LORD <<<REPLACE EVERY GAME>>>> CHARACTER CONTROLS JESUS IS LORD!

            // JESUS IS LORD <<< PHEONOMINA CONTROL>>> JESUS IS LORD!
            if(Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.S))
            {
                gokuRect.X = gokuRect.X - 1;


                redRect.X = redRect.X + 2;

            }

            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.K))
            {
                 supermanRect.X = supermanRect.X + 1;
                 blueRect.X = blueRect.X - 2;
            }

            keyState = Keyboard.GetState();
           
            if  (gokuRect.Intersects(supermanRect)) 
               ScreenManager.Instance.AddScreen(new OpeningTitleScreen());
            if (displayEndScenes)
            {
                if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.D3))
                {
                ScreenManager.Instance.AddScreen(new GokuWins());
                }

                /* if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.D4))
                {
                    ScreenManager.Instance.AddScreen(new SuperManWins());
                } */

            }
            #endregion
            #region JESUS IS LORD  SOUND REPEATING  JESUS IS LORD!
            if (MediaPlayer.State == MediaState.Stopped)
            {
                MediaPlayer.Play(backgroundMusic);

            }

            #endregion
            scrollingkungfu.Update(gameTime);

   

           
        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            #region Scrolling Background

            scrollingkungfu.Draw(spriteBatch);
           // spriteBatch.Draw(background, backgroundRect, Color.White);
           
            #endregion 
            #region JESUS IS LORD <<< GRAPHICS >>> DRAW EVERYTHING TO THE SCREEN JESUS IS LORD GAME 18
            //JESUS IS LORD! DRAWS THE BACKGROUN <<< GRAPHICS>>> JESUS IS LORD!
          //  spriteBatch.Begin();
       //     
            //spriteBatch.End();
        
            //DRAWS THE SPRITES! JESUS IS LORD! 
           // spriteBatch.Begin();
            spriteBatch.Draw(goku[0], gokuRect, Color.White);
            spriteBatch.Draw(superman[0], supermanRect, Color.White);
          //  spriteBatch.End();
            // TODO: Add your drawing code here
            #endregion 
            #region JESUS IS LORD <<< GRAPHICS >>> dRAW EFFEECTS ON THE SCREEN
             
              //  spriteBatch.Draw(blueLight, blueRect, Color.White);
              //  spriteBatch.Draw(redLight, redRect, Color.White);

#endregion

            // fireball

       
                #region JESUS IS LORD movement text <<<< REPLACE EVERY GAME >>> JESUS IS LORD!
         //       spriteBatch.DrawString(font, "SAY GREGORY WINS!", new Vector2(150, 400), Color.Black);
                #endregion
          
                if (displayEndScenes)
                {
                    #region JESUS IS LORD alternate ending tet <<<REPLACE EVERY GAME>>> JESUS IS LORD!
            //        spriteBatch.DrawString(font2, "HIT 3 TO SEE THE GREAT KUNG-FU ENDING!", new Vector2(150, 300), Color.White);
                    #endregion
                }

                // fireball

        }
   
    }
}
