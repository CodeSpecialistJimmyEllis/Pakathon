/* using System;
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
    class InputHandler : GameScreen 
    {

        //JESUS IS LORD KEYBOARD VARIABLES THE LIKES OF WHICH YOU'VE NEVER SEEN JESUS IS LORD!
        KeyboardState controlGoku;
        KeyboardState controlSuperman;
        KeyboardState keyState;

        Keys old, current;
        KeyState oldx, currentx;
        SpriteFont font;


        public override void LoadContent(ContentManager Content)
        {
          base.LoadContent(Content); 
            if (font == null)
                font = content.Load<SpriteFont>("content/Font1");


            // JESUS IS LORD <<< INPUT/CONTROL>>> KEYBOARD STATES FOR GOKU SUPER MAN AND GENERAL JESUS IS LORD!
            controlGoku = new KeyboardState();
            controlSuperman = new KeyboardState();
            keyState = new KeyboardState();
            old = new Keys();
            current = new Keys();
            oldx = new KeyState();
            currentx = new KeyState();

            
        }

        public void UnloadContent()
        {
            base.UnloadContent();
        }

        public  void Update(GameTime gameTime)
        {

            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Enter))
                ScreenManager.Instance.AddScreen(new SplashScreen());


        }

        public void Draw(SpriteBatch spriteBatch)
        { 
            /*    spriteBatch.DrawString(font, "TitleScreen",
                   new Vector2(100, 100), Color.Black); */

/*
        }


        public float InputHandler(Keys a)
        {

            
            switch (controlGoku.GetPressedKeys())
            {
                case Keys.G:
                    

             

            }
        }
        
        }
} */
