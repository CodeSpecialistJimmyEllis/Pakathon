#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Media;
#endregion

namespace JESUSISLORDplatformer
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class CampusInformationCenter : GameScreen
    {


        #region Fields

        Texture2D whitebox;
        string[] place;
        string[] title;
        string[] phonenumber;
        string[] website;
        string[] explination;
        SpriteFont spritefont;
        // graphics changing backgroudns rectangle for scree nadn texture
        Texture2D[] changingbackgrounds;
        Rectangle changingbackgroundsrect;
        TextToSpeechEngine texttospeechengine;
        TextToSpeechObject texttospeechobject;
        public static int backgroundchanger;
        ChangingBackgroundButtonObject buttonobject;
        ChangingBackgroundButtonEngine buttonengine;
        Song bgmusic;
        // PHENOMINA enumeration to use control based variables s othis ps 
        enum ChosenBackground
        {
            background1, background2, background3, background4, background5, background6, background7, background8, background9, background10

        }

        // CONTROL  PHEONOMINA enumartion for if statements
        ChosenBackground chosenbackground;

        KeyboardState backgroundkey;

        enum Reading
        {
            nothing, place, title, phonenumber, website, explination
        }

        Reading reading;
        #endregion


        public CampusInformationCenter()
        {
            ChosenBackground chosenbackground = ChosenBackground.background1;
            // TODO: Add your initialization logic here
            // textures for background change 
            #region ChangingBackground array initiation
            changingbackgrounds = new Texture2D[10];
            #endregion

            texttospeechengine = new TextToSpeechEngine();
            texttospeechobject = new TextToSpeechObject();

            reading = Reading.nothing;
            backgroundchanger = 1;
            buttonobject = new ChangingBackgroundButtonObject();
            buttonengine = new ChangingBackgroundButtonEngine();
            //background key initialize
            backgroundkey = new KeyboardState();

            changingbackgroundsrect = new Rectangle(0, 0, 800, 600);

            place = new string[1];

            place[0] = "I I T";
            title = new string[1];
            title[0] = "Campus Information Center";
            phonenumber = new string[1];
            phonenumber[0] = "3 1 2 5 6 7 3 7 0 0";

            website = new string[1];
            website[0] = "iit.edu/campus_and_conference_centers";
            explination = new string[1];
            explination[0] = "The Campus Information Center is your one-stop shop for any questions you have regarding the university. The CIC is located right outside of the MTCC Commons.";
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        public override void LoadContent(ContentManager Content)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            bgmusic = Content.Load<Song>("bgmusic01");

            MediaPlayer.Play(bgmusic);
            #region ChangingBackgrounds LoadContent backgroudn loads
            changingbackgrounds[0] = Content.Load<Texture2D>("changingbackground/image1");
            changingbackgrounds[1] = Content.Load<Texture2D>("changingbackground/image2");
            changingbackgrounds[2] = Content.Load<Texture2D>("changingbackground/image3");
            changingbackgrounds[3] = Content.Load<Texture2D>("changingbackground/image4");
            changingbackgrounds[4] = Content.Load<Texture2D>("changingbackground/image5");

            changingbackgrounds[5] = Content.Load<Texture2D>("changingbackground/image6");
            changingbackgrounds[6] = Content.Load<Texture2D>("changingbackground/image7");
            changingbackgrounds[7] = Content.Load<Texture2D>("changingbackground/image8");
            changingbackgrounds[8] = Content.Load<Texture2D>("changingbackground/image9");
            changingbackgrounds[9] = Content.Load<Texture2D>("changingbackground/image10");
            #endregion
            // TODO: use this.Content to load your game content here
            buttonobject.LoadContent(Content);
            buttonengine.LoadContent(Content);
            whitebox = Content.Load<Texture2D>("whitebox");
            spritefont = Content.Load<SpriteFont>("content/SpriteFont1");
            texttospeechengine.LoadContent(Content);
            texttospeechobject.LoadContent(Content);

            MediaPlayer.Volume = .05f;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>

        public override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {

            // pheonomina the keyboard states are mapped to getstate
            backgroundkey = Keyboard.GetState();

            buttonengine.Update(gameTime);


            buttonengine.ReceiveFrom_ButtonObject(buttonobject.gogobuttonrect);
            buttonobject.ReceiveFrom_ButtonEngine(buttonengine.SendTo_ButtonObject());
            #region ChosenBackground KeyboardKeys

            if (backgroundkey.IsKeyDown(Keys.D0))
            {
                chosenbackground = ChosenBackground.background1;
            }

            if (backgroundkey.IsKeyDown(Keys.D1))
            {
                chosenbackground = ChosenBackground.background2;
            }
            if (backgroundkey.IsKeyDown(Keys.D2))
            {
                chosenbackground = ChosenBackground.background3;
            }

            if (backgroundkey.IsKeyDown(Keys.D3))
            {
                chosenbackground = ChosenBackground.background4;
            }
            if (backgroundkey.IsKeyDown(Keys.D4))
            {
                chosenbackground = ChosenBackground.background5;
            }
            if (backgroundkey.IsKeyDown(Keys.D5))
            {
                chosenbackground = ChosenBackground.background6;
            }
            if (backgroundkey.IsKeyDown(Keys.D6))
            {
                chosenbackground = ChosenBackground.background7;
            }
            if (backgroundkey.IsKeyDown(Keys.D7))
            {
                chosenbackground = ChosenBackground.background8;
            }
            if (backgroundkey.IsKeyDown(Keys.D8))
            {
                chosenbackground = ChosenBackground.background9;
            }
            if (backgroundkey.IsKeyDown(Keys.D9))
            {
                chosenbackground = ChosenBackground.background10;
            }
            // TODO: Add your update logic here
            #endregion

            texttospeechengine.Update(gameTime);


            texttospeechobject.ControlledBy_TextToSpeechEngine(texttospeechengine.Controlling_TextToSpeechObject());


            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.A))
            {
                reading = Reading.place;
            }
            else if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.S))
            {
                reading = Reading.title;
            }
            else if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.D))
            {
                reading = Reading.phonenumber;
            }
            else if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.F))
            {
                reading = Reading.website;
            }
            else if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.G))
            {
                reading = Reading.explination;
            }

            else if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
            {
                ScreenManager.Instance.AddScreen(new SplashScreen());
            }
            if (Reading.place == reading)
            {
                texttospeechengine.ReceiveFrom_TextToSpeechObject(place);
                reading = Reading.nothing;
            }

            else if (Reading.title == reading)
            {
                texttospeechengine.ReceiveFrom_TextToSpeechObject(title);
                reading = Reading.nothing;
            }

            else if (Reading.phonenumber == reading)
            {
                texttospeechengine.ReceiveFrom_TextToSpeechObject(phonenumber);
                reading = Reading.nothing;
            }

            else if (Reading.website == reading)
            {
                texttospeechengine.ReceiveFrom_TextToSpeechObject(website);
                reading = Reading.nothing;
            }
            else if (Reading.explination == reading)
            {
                texttospeechengine.ReceiveFrom_TextToSpeechObject(explination);
                reading = Reading.nothing;
            }


            ////////////////////////////////////
            //texttospeechengine.ReceiveFrom_TextToSpeechObject(spokenidnumberarray);
            //////////////////////////////////////
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(SpriteBatch spriteBatch)
        {


            //todo alphablend 


            //graphics // drawping the pictures




            #region ChaningBackgroundsObjectEngine backgroudn draw switch engine algorthim

            // spriteBatch.Draw();

            if (backgroundchanger == 1)
            {
                spriteBatch.Draw(changingbackgrounds[0], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 2)
            {
                spriteBatch.Draw(changingbackgrounds[1], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 3)
            {
                spriteBatch.Draw(changingbackgrounds[2], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 4)
            {
                spriteBatch.Draw(changingbackgrounds[3], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 5)
            {
                spriteBatch.Draw(changingbackgrounds[4], changingbackgroundsrect, Color.White);
            }

            else if (backgroundchanger == 6)
            {
                spriteBatch.Draw(changingbackgrounds[5], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 7)
            {
                spriteBatch.Draw(changingbackgrounds[6], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 8)
            {
                spriteBatch.Draw(changingbackgrounds[7], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 9)
            {
                spriteBatch.Draw(changingbackgrounds[8], changingbackgroundsrect, Color.White);
            }
            else if (backgroundchanger == 10)
            {
                spriteBatch.Draw(changingbackgrounds[9], changingbackgroundsrect, Color.White);
            }



            if (ChosenBackground.background1 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[0], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background2 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[1], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background3 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[2], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background4 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[3], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background5 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[4], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background6 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[5], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background7 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[6], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background8 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[7], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background9 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[8], changingbackgroundsrect, Color.White);
            }
            if (ChosenBackground.background10 == chosenbackground)
            {
                spriteBatch.Draw(changingbackgrounds[9], changingbackgroundsrect, Color.White);
            }
            #endregion

            buttonobject.Draw(spriteBatch);

            spriteBatch.Draw(whitebox, new Rectangle(0, 0, 800, 150), Color.Black);
            spriteBatch.DrawString(spritefont, "1.)" + place[0], new Vector2(0, 0), Color.White);

            spriteBatch.DrawString(spritefont, "2.)" + title[0], new Vector2(0, 20), Color.White);
            spriteBatch.DrawString(spritefont, "3.)" + "(312)567-3700", new Vector2(0, 40), Color.White);
            spriteBatch.DrawString(spritefont, "4.)" + website[0], new Vector2(0, 60), Color.White);
            spriteBatch.DrawString(spritefont, "5.)" + "The Campus Information Center is your", new Vector2(0, 80), Color.White);
            spriteBatch.DrawString(spritefont, " one-stop shop for any questions you have regarding the university. The CIC is located right outside of the MTCC Commons.", new Vector2(0, 100), Color.White);
            spriteBatch.DrawString(spritefont, "have regarding the university. The CIC is located right outside of the MTCC Commons.", new Vector2(0, 120), Color.White);
            // TODO: Add your drawing code here


        }
    }
}
