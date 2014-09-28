// JESUS IS LORD! JESUS IS LORD!


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
// using Leap;
// using LeapLibrary;


namespace JESUSISLORDplatformer
{
    class LoginTitleScreen : GameScreen
    {
        #region Fields
        //JESUS IS LORD <<< CONSTRUCTOR CONTROL>>>

        Texture2D[] fingertextures;
        Rectangle[] hitboxrect;

        Rectangle[] leapfingersrect;


        #region Video Fields

        // video player variables
        VideoPlayer virusplayer;
        Video virusvideo;
        Texture2D virusvidtexture;
        Rectangle virusvidtexturerect;
        //
        #endregion
        // KeyboardState keyState;
        //JESUS IS LORD <<< GRAPHICS >>> DISPLAYS THE TEXT ON THE SCREEN JESUS IS LORD
        //JESUS IS LORD! <<< GRPAHICS >>> FONT USED TO DISPLAY MESSAGES
        SpriteFont font;
        ScrollingBackground forward;
        Texture2D computervirus;
        //JESUS IS LORD <<< GRAPHICS >>> FONT USED TO DISPLAY MESSAGES
        SpriteFont font2;
        Texture2D wronghands;
        SoundEffect hitsound;
        ScrollingBackgroundTop scrollingbackgroundtop;
        Texture2D infectedcomputer;
        Rectangle leapcollisionb;
        ScrollingBackgroundBackwards backwards;
        ScrollingBackgroundBottom scrollingbackgroundbottom;
        bool[] broken;
        Texture2D kungfusantaclaus;
        #region JESUS IS LORD GAME 18 VARIABLES JESUS IS LORD
        // JESUS IS LORD <<< GRAPHICS>>> THE GOKU/SUPERMAN GRAPHICS HAVE FIGHT POSE AS ARRAY PLACE 1 AND LOSE POSE AS ARRAY PLACE 2 JESUS IS LORD!

        // JESUS IS LORD <<< GRAPHICS >>> RECTANGLES FOR SCREEN PLACE MENT! JESUS IS LORD!
        //  Rectangle gokuRect;
        // Rectangle supermanRect;
        Texture2D background;
        Rectangle backgroundRect;
        // JESUS IS LORD <<< RECTANGLE FOR SCREEN STATE PLACE MENT >>> GRAHPICS JESUS IS LORD!
        //   Rectangle screenStateRect;

        //JESUS IS LORD <<< SOUND >>> BACKGROUND MUSIC AND SOUND EFFECTS JESUS IS LORD!
        Song backgroundMusic;


        // JESUS IS LORD <<< GRAPHICS>>> EFFECTS THAT FOLLOW CHARACTERS 

        bool displayEndScenes = false;
        #endregion
        #endregion

        #region LoginScreenFields
        string words;
        string[] spokenidnumberarray;
        char[] idnumber;
        KeyboardState idkey;
        SpriteFont spritefont;
        Texture2D textbox;
        Rectangle textboxrec;
        int idnumberplace;
        TextToSpeechEngine texttospeechengine;
        TextToSpeechObject texttospeechobject;
        string middlemannumber;
        int count;
        bool hitkey;
        #endregion
        #region Constructor

        //constructor 1
        public LoginTitleScreen(bool choice)
        {
            #region Loginscreen initializer
            idnumber = new char[9];
            count = 0;
            hitkey = false;
            idkey = new KeyboardState();
            spokenidnumberarray = new string[1];
            spokenidnumberarray[0] = "empty";
            for (int i = 0; i < 9; i++)
            {
                idnumber[i] = '0';
            }


            texttospeechengine = new TextToSpeechEngine();
            texttospeechobject = new TextToSpeechObject();


            texttospeechengine.Initialize();
            texttospeechobject.Initialize();
            idnumberplace = 0;

            /*
            idnumber[0] = '0';
            idnumber[1] = '0';

            idnumber[2] = '0';
            idnumber[3] = '0';

            idnumber[4] = '0';
            idnumber[5] = '0';

            idnumber[6] = '0';
            idnumber[7] = '0';

            idnumber[8] = '0';
           */

            textboxrec = new Rectangle(0, 0, 230, 45);
            #endregion


            virusplayer = new VideoPlayer();

            virusvidtexturerect = new Rectangle(0, 0, 512, 512);
            backwards = new ScrollingBackgroundBackwards();
            leapfingersrect = new Rectangle[6];
            scrollingbackgroundbottom = new ScrollingBackgroundBottom();
            fingertextures = new Texture2D[5];
            leapfingersrect[0] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[1] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[2] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[3] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[4] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[5] = new Rectangle(0, 0, 128, 128);
            this.displayEndScenes = choice;

            forward = new ScrollingBackground();

            //<<< graphics pheonomina >>> scrolling background of snow flakes at the bottom or any itemm;
            scrollingbackgroundtop = new ScrollingBackgroundTop();

            hitboxrect = new Rectangle[11];

            for (int x = 0; x < 11; x++)
            {
                hitboxrect[x].X = 200;
                hitboxrect[x].Y = (x + 2) * 50;

            }



            broken = new bool[11];
            for (int g = 0; g < 11; g++)
            {
                broken[g] = false;

            }
        }

        // constructor 2 
        public LoginTitleScreen()
        {


        

            #region Loginscreen initializer
            idnumber = new char[9];
            count = 0;
            hitkey = false;
            idkey = new KeyboardState();
            spokenidnumberarray = new string[1];
            spokenidnumberarray[0] = "empty";
            for (int i = 0; i < 9; i++)
            {
                idnumber[i] = '0';
            }


            texttospeechengine = new TextToSpeechEngine();
            texttospeechobject = new TextToSpeechObject();


            texttospeechengine.Initialize();
            texttospeechobject.Initialize();
            idnumberplace = 0;

            /*
            idnumber[0] = '0';
            idnumber[1] = '0';

            idnumber[2] = '0';
            idnumber[3] = '0';

            idnumber[4] = '0';
            idnumber[5] = '0';

            idnumber[6] = '0';
            idnumber[7] = '0';

            idnumber[8] = '0';
           */

            textboxrec = new Rectangle(0, 0, 230, 45);
            #endregion



            virusplayer = new VideoPlayer();

            virusvidtexturerect = new Rectangle(0, 0, 512, 512);
            leapfingersrect = new Rectangle[6];
            leapfingersrect[0] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[1] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[2] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[3] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[4] = new Rectangle(0, 0, 128, 128);
            leapfingersrect[5] = new Rectangle(0, 0, 128, 128);
            fingertextures = new Texture2D[5];
            hitboxrect = new Rectangle[11];

            backwards = new ScrollingBackgroundBackwards();
            forward = new ScrollingBackground();
            scrollingbackgroundtop = new ScrollingBackgroundTop();
            for (int x = 0; x < 11; x++)
            {
                hitboxrect[x].X = 200;
                hitboxrect[x].Y = (x + 2) * 50;

            }

            scrollingbackgroundbottom = new ScrollingBackgroundBottom();

            broken = new bool[11];
            for (int g = 0; g < 11; g++)
            {
                broken[g] = false;

            }
        }
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
            // JESUS IS LORD <<< CONTROL >>> INITIALIZE A BUNCH OF ARRAYS FOR USE WITH LOADING TEXTURES THROUGH FOR LOOP JESUS IS LORD
            #region ARRAYS OF TEXTURES GAME 18
            //   goku = new Texture2D[2];
            //  superman = new Texture2D[2];
            #endregion
            hitsound = Content.Load<SoundEffect>("tokensuccess");
            leapcollisionb = new Rectangle(0, 0, 64, 64);
            backwards.LoadContent(Content);
            #region JESUS IS LORD GAME 18 LOADING TEXTURES IN ARRAYS JESUS IS LORD!
            computervirus = Content.Load<Texture2D>("backgrounds/computervirus");
            infectedcomputer = Content.Load<Texture2D>("backgrounds/infectedcomputer");

            MediaPlayer.Volume = 0.08f;
            /*
            // JESUS IS LORD <<< GRAPHICS >>> LOAD SPRITES INTO ARRAYS superman and goku JESUS IS LORD!
            for (int i = 0; i <= 2; i++)
            {
                if (i == 0)
                    goku[i] = Content.Load<Texture2D>("characters/goku");
                else if (i == 1)
                    goku[i] = Content.Load<Texture2D>("characters/goku1");

            }

            for (int x = 0; x <= 2; x++)
            {
                if (x == 0)
                    superman[x] = Content.Load<Texture2D>("characters/superman");
                else if (x == 1)
                    superman[x] = Content.Load<Texture2D>("characters/superman1");

            }


            gokuRect = new Rectangle(0, 160, 130, 246);
            supermanRect = new Rectangle(300, 10, 818, 614);
             * 
             */

            #endregion
            scrollingbackgroundbottom.LoadContent(Content);
            scrollingbackgroundtop.LoadContent(Content);
            forward.LoadContent(Content);
            kungfusantaclaus = Content.Load<Texture2D>("backgrounds/kungfusantaclaus");
            #region JESUS IS LORD LOADING BACKGROUND JESUS IS LORD
            /*fingertextures[0] = Content.Load<Texture2D>("fingers/finger1");
            fingertextures[1] = Content.Load<Texture2D>("fingers/finger2");
            fingertextures[2] = Content.Load<Texture2D>("fingers/finger3");
            fingertextures[3] = Content.Load<Texture2D>("fingers/finger4");
            fingertextures[4] = Content.Load<Texture2D>("fingers/finger5"); */
            wronghands = Content.Load<Texture2D>("backgrounds/WRONGHANDS");
            background = Content.Load<Texture2D>("backgrounds/TitleScreen");
            backgroundRect = new Rectangle(0, 0, 800, 600);

            #endregion

            #region JESUS IS LORD <<< SOUND >>> SONGS AND SOUND EFFECTS FOR GAME

            backgroundMusic = Content.Load<Song>("sound/bgmusic01");

            //  MediaPlayer.Volume = 0.2f;
            MediaPlayer.Play(backgroundMusic);

            // slice = Content.Load<SoundEffect>("sound/slice");
            // explosion = Content.Load<SoundEffect>("sound/explosion");
            // beatUp = Content.Load<SoundEffect>("sound/beatup");
            #endregion

            #region EFFECTS JESUS IS LORD!

            // JESUS IS LORD << DRAWS EFFECTS AND LIGHTNING AND SUCH JESUS IS LORD!@
            //    blueLight = Content.Load<Texture2D>("effects/JESUSISLORDbluelight");
            //   redLight = Content.Load<Texture2D>("effects/JESUSISLORDredlight");

            //  redRect = new Rectangle(0, 200, 132, 132);
            //   blueRect = new Rectangle(650, 200, 132, 132);
            #endregion

            // virusvideo = Content.Load<Video>("videos/viruscountdown");
            //  virusplayer.Play(virusvideo);


            #region loginscreen load content
            texttospeechengine.LoadContent(Content);
            texttospeechobject.LoadContent(Content);

            textbox = Content.Load<Texture2D>("whitebox");
            spritefont = Content.Load<SpriteFont>("content/Font1");
            #endregion 
        }
        #endregion
        #region UnloadContent
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        #endregion
        #region Update
        public override void Update(GameTime gameTime)
        {

            #region JESUS IS LORD  SOUND REPEATING  JESUS IS LORD!
            if (MediaPlayer.State == MediaState.Stopped)
            {
                MediaPlayer.Play(backgroundMusic);

            }

            #endregion


            forward.Update(gameTime);
            scrollingbackgroundtop.Update(gameTime);
            scrollingbackgroundbottom.Update(gameTime);
            backwards.Update(gameTime);
            #region JESUS IS LORD CHARACTER CONTROL ALGORITHIMS
            /*
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.G))
            {
                gokuRect.X = gokuRect.X + 1;


                redRect.X = redRect.X + 2;

            }

            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.S))
            {
                supermanRect.X = supermanRect.X - 1;
                blueRect.X = blueRect.X - 2;
            }

            keyState = Keyboard.GetState();

            if ((gokuRect.X - 250) >= (supermanRect.X))
                ScreenManager.Instance.AddScreen(new TitleScreen());
            if (displayEndScenes)
            {
                if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.D3))
                {
                    ScreenManager.Instance.AddScreen(new GokuWins());
                }

                if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.D4))
                {
                    ScreenManager.Instance.AddScreen(new SuperManWins());
                }

            }
            */
            #endregion


            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }

            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }
            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }
            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }
            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }

            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }

            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }

            if (hitboxrect[0].Intersects(leapcollisionb))
            {
                broken[0] = true;
                hitsound.Play();
            }



            #region JESUS IS LORD AND IN CONTROL -  THIS CHANGES STATE TO THE OPENING VIDEO
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Enter))
            {
                MediaPlayer.Stop();
                //ScreenManager.Instance.AddScreen(new SplashScreen());
                ScreenManager.Instance.AddScreen(new ChangingBackgroundState());
            }
            #endregion


            #region Login Screen Update algorithims

            idkey = Keyboard.GetState();
            // || idkey.IsKeyDown(Keys.D1) || idkey.IsKeyDown(Keys.D2) || idkey.IsKeyDown(Keys.D3) || idkey.IsKeyDown(Keys.D4) || idkey.IsKeyDown(Keys.D5) || idkey.IsKeyDown(Keys.D6) || idkey.IsKeyDown(Keys.D7) || idkey.IsKeyDown(Keys.D8) || idkey.IsKeyDown(Keys.D9))
            if (idkey.IsKeyDown(Keys.Space))
            {
                hitkey = false;
            }

            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D0))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '0';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }

            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D1))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '1';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }


            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D2))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '2';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }
            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D3))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '3';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }
            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D4))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '4';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }
            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D5))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '5';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }
            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D6))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '6';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }
            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D7))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '7';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }
            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D8))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '8';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }
            if (hitkey == false)
            {
                if (idkey.IsKeyDown(Keys.D9))
                {
                    hitkey = true;
                    idnumber[idnumberplace] = '9';

                    idnumberplace++;
                    if (idnumberplace >= 10)
                        idnumberplace = 1;

                }
            }

            //     }
            texttospeechengine.Update(gameTime);


            texttospeechobject.ControlledBy_TextToSpeechEngine(texttospeechengine.Controlling_TextToSpeechObject());

            if (idnumberplace == 9)
            {
                //texttospeechengine.ReceiveFrom_TextToSpeechObject();

                words = new string(idnumber);
                spokenidnumberarray[0] = words;

                texttospeechengine.ReceiveFrom_TextToSpeechObject(spokenidnumberarray);
                idnumberplace++;
                //spokenidnumberarray
            }



            #endregion
        }
        #endregion
        #region Draw
        public override void Draw(SpriteBatch spriteBatch)
        {



            //  spriteBatch.Draw(background, backgroundRect, Color.White);
            forward.Draw(spriteBatch);
            // backwards.Draw(spriteBatch);

            //   scrollingbackgroundtop.Draw(spriteBatch);
            //   scrollingbackgroundbottom.Draw(spriteBatch);
            spriteBatch.Draw(computervirus, new Rectangle(0, 100, 700, 400), Color.White);
            #region login screen draw

            spriteBatch.Draw(textbox, textboxrec, Color.White);
            spriteBatch.DrawString(spritefont, idnumber[0].ToString(), new Vector2(0, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[1].ToString(), new Vector2(10, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[2].ToString(), new Vector2(20, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[3].ToString(), new Vector2(30, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[4].ToString(), new Vector2(40, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[5].ToString(), new Vector2(50, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[6].ToString(), new Vector2(60, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[7].ToString(), new Vector2(70, 0), Color.Black);
            spriteBatch.DrawString(spritefont, idnumber[8].ToString(), new Vector2(80, 0), Color.Black);

            #endregion 

            // spriteBatch.Draw(wronghands, new Rectangle(0, 0, 800, 600), Color.White);
            //       spriteBatch.Draw(infectedcomputer, new Rectangle(300, 100, 256, 128), Color.White);
            //   spriteBatch.Draw(kungfusantaclaus, new Rectangle(0, 0, 800, 100), Color.White);

            //    virusvidtexture = virusplayer.GetTexture();

            //    spriteBatch.Draw(virusvidtexture, virusvidtexturerect, Color.White);




            /*     foreach (Vector2 fingerLocC in Game1.leapa.FingerPoints)
                 {

                     leapcollisionb.X = (int)fingerLocC.X;
                     leapcollisionb.Y = (int)fingerLocC.Y;
                 } */



            /*
                        #region JESUS IS LORD <<< GRAPHICS >>> DRAW EVERYTHING TO THE SCREEN JESUS IS LORD GAME 18
                        //JESUS IS LORD! DRAWS THE BACKGROUN <<< GRAPHICS>>> JESUS IS LORD!
                        //  spriteBatch.Begin();
        
                        //spriteBatch.End();

                        #endregion

                        #region JESUS IS LORD <<< GRAPHICS >>> DRAW SPRITES
                        /*
                        //DRAWS THE SPRITES! JESUS IS LORD! 
                        // spriteBatch.Begin();
                        spriteBatch.Draw(goku[0], gokuRect, Color.White);
                        spriteBatch.Draw(superman[0], supermanRect, Color.White);
                        //  spriteBatch.End();
                        // TODO: Add your drawing code here
                         * */
            /*
            #endregion
            #region JESUS IS LORD <<< GRAPHICS >>> dRAW EFFEECTS ON THE SCREEN
            /* 
            spriteBatch.Draw(blueLight, blueRect, Color.White);
            spriteBatch.Draw(redLight, redRect, Color.White);
           
 * */
            // #endregion



            /*
             if (displayEndScenes)

             #region JESUS IS LORD <<< GRAPHICS>>> DRAW WORDS ON THE SCREEN
             spriteBatch.DrawString(font, "WHAT I SEE IS TRUTH THE GAME", new Vector2(0, 450), Color.White);
             spriteBatch.DrawString(font, "GOAL: CLEAR ALL THE BLOCKS ON THE SCREEN BY TOUCHING THEM!", new Vector2(0, 375), Color.White);
             spriteBatch.DrawString(font, "MAKE SURE YOU REALIEZ THAT YOU MUST CHOOSE A NEW COLOR EACH TIME!", new Vector2(0, 400), Color.White);
             spriteBatch.DrawString(font, "HIT ENTER TO START GAME!!!!", new Vector2(0, 470), Color.White);
             #endregion

      
             {
             * */


            // spriteBatch.DrawString(font2, "HIT 4 TO SEE THE GREAT KUN-FU ENDING!", new Vector2(150, 300), Color.White);

            //   }

            //  LeapComponet[] leaparray = list.ToArray();

            //    leapfingersrect[0].X = (int)Game1.leapa.FingerPoints[0].X;
            //    leapfingersrect[0].Y = (int) Game1.leapa.FingerPoints[0].Y;
            //  leapfingersrect[0].X = (int)Game1.leapa.FirstHandLoc.X;
            //  leapfingersrect[0].Y = (int)Game1.leapa.FirstHandLoc.Y;

            //leapfingersrect[] = Game1.leapa.FingerPoints.ToArray; 
            // leapfingersrect[1].Y = (int)Game1.leapa.FingerPoints[2].Y;
            /*
                        leapfingersrect[2].X = (int)Game1.leapa.FingerPoints[2].X;
                       leapfingersrect[2].Y = (int)Game1.leapa.FingerPoints[2].Y;

                        leapfingersrect[3].X = (int)Game1.leapa.FingerPoints[3].X;
                        leapfingersrect[3].Y = (int)Game1.leapa.FingerPoints[3].Y;

                        leapfingersrect[4].X = (int)Game1.leapa.FingerPoints[4].X;
                        leapfingersrect[4].Y = (int)Game1.leapa.FingerPoints[4].Y;

                        leapfingersrect[5].X = (int)Game1.leapa.FingerPoints[5].X;
                        leapfingersrect[5].Y = (int)Game1.leapa.FingerPoints[5].Y;
                        spriteBatch.Draw(texture, leapfingersrect[0], Color.White);
                        spriteBatch.Draw(texture, leapfingersrect[1], Color.White);
                        spriteBatch.Draw(texture, leapfingersrect[2], Color.White);
                        spriteBatch.Draw(texture, leapfingersrect[3], Color.White);
                        spriteBatch.Draw(texture, leapfingersrect[4], Color.White);
             * */
            // spriteBatch.Draw(texture, leapfingersrect[0], Color.White);
            //spriteBatch.Draw(texture, leapfingersrect[1], Color.White);
            /*  for (int a = 0; a < 5; a++)
                  {
                      spriteBatch.Draw(texture, , Color.White);
                  }*/

            Vector2[] a = new Vector2[10];
            //   a = Game1.leapa.FingerPoints.ToArray();
            //a =  Game1.leapa.FingerPoints.ToArray<Vector2>;
            // a = new Vector2[Game1.leapa.FingerPoints.Count];
            // for (int f = 0; f < 5; f++)
            //{
            //    a = new Vector2[f];
            // }
            int i = 0;
            /*       foreach (Vector2 fingerLoc in Game1.leapa.FingerPoints)
                   {
                       a[i++] = fingerLoc;
                   }


                   spriteBatch.Draw(fingertextures[0], Game1.leapa.Fingerarray[0], Color.White);

                   spriteBatch.Draw(fingertextures[1], Game1.leapa.Fingerarray[1], Color.White);


                   spriteBatch.Draw(fingertextures[2], Game1.leapa.Fingerarray[2], Color.White);

                   spriteBatch.Draw(fingertextures[3], Game1.leapa.Fingerarray[3], Color.White);

                   spriteBatch.Draw(fingertextures[4], Game1.leapa.Fingerarray[4], Color.White);
             * 
             * */
            //  spriteBatch.DrawString(font, a[0].ToString(), new Vector2(200, 200), Color.White);
            //spriteBatch.Draw(texture, a[Game1.leapa.FingerPoints.Count-1], Color.White);
            /*
           foreach (Vector2 fingerLoc in Game1.leapa.FingerPoints)
            {
               
               
               spriteBatch.Draw(texture, fingerLoc, Color.White);
                spriteBatch.Draw(texture, Game1.leapa.FirstHandLoc, Color.White);


               
            }*/

     

        }
            #endregion
    }
}
