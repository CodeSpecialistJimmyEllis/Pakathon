// MULTI CONSTRUCTOR POLYMORPHIC GAME ENGINE 
// Code & Engine Design By: Jimmy Ellis

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
namespace JESUSISLORDplatformer
{
    class MeterEngine
    {
        KeyboardState playerkey;
        enum StateChange
        {
            isWin, isRight, isNeutral, isWrong, isLose
        }

        StateChange statechanger; 


        public MeterEngine()
        {
            StateChange statechanger = StateChange.isNeutral; 
        }
        /*
        public MeterEngine()
        {

        }

        public MeterEngine()
        {

        } */

        public void Initialize()
        {
            playerkey = new KeyboardState();
        }

        public void LoadContent(ContentManager Content)
        {

        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
            playerkey = Keyboard.GetState();
   
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        public MeterObject.MeterStatus ChangeMeterObject( MeterObject newmeter)
        {
            if (playerkey.IsKeyDown(Keys.G))  //(Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
            {
                statechanger = StateChange.isWin;
                newmeter.clonestatus = MeterObject.MeterStatus.win;
            }
            else if (playerkey.IsKeyDown(Keys.F))
            {
                statechanger = StateChange.isRight;
                newmeter.clonestatus = MeterObject.MeterStatus.right;
            }
            else if (playerkey.IsKeyDown(Keys.D))
            {
                statechanger = StateChange.isNeutral;
                newmeter.clonestatus = MeterObject.MeterStatus.neutral;
            }
            else if (playerkey.IsKeyDown(Keys.S))
            {
                statechanger = StateChange.isWrong;
                newmeter.clonestatus = MeterObject.MeterStatus.wrong;
            }
            else if (playerkey.IsKeyDown(Keys.A))
            {
                statechanger = StateChange.isLose;
                newmeter.clonestatus = MeterObject.MeterStatus.lose;
            }

            return newmeter.clonestatus;
        }

    }
}
