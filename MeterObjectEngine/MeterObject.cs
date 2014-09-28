// MULTI CONSTRUCTOR POLYMORPHIC GAME ENGINE 
// Code & Engine Desgin By: Jimmy Ellis


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
    class MeterObject
    {
        #region Fields 
        private Texture2D[] meter;
        private Rectangle meterrect;


   public  enum MeterStatus
        {
            win, right, neutral, wrong, lose
        }
       public MeterStatus status;


        #region Clone Fields 
     public MeterStatus clonestatus;
        #endregion

        #region Properites 

 /*       public enum Clonestatus
        {
            
        }
        */ 


          /*
                if ((clonestatus == status) && (clonestatus != null))
                {
                    return clonestatus;
                }
                else
                {
                    return 0; 
                }
            }

            set
            {
                if ((clonestatus == status) && (clonestatus != null))
                {

                    clonestatus = value;
                }
                else
                {
                    clonestatus = 0; 
                }
        
            }
        } */ 
        #endregion

        /*
         * 
         *         public MeterStatus Clonestatus
        {
            get
            {

            }

            set
            {
            }
        }*/

        #region Constructors
        public MeterObject()
        {
            meter = new Texture2D[5];

            for (int a = 0; a < 0; a++)
            {
                meter = new Texture2D[a];
            }
            status = MeterStatus.neutral;
        }

        /* public MeterObject()
         {

         }

         public MeterObject()
         {

         } */
        #endregion

        #endregion

        public void Initialize()
        {

        }

        public void LoadContent(ContentManager Content)
        {


            meter[0] = Content.Load<Texture2D>("decidemeter/meterwin");
            meter[1] = Content.Load<Texture2D>("decidemeter/meterright");
            meter[2] = Content.Load<Texture2D>("decidemeter/meterneutral");
            meter[3] = Content.Load<Texture2D>("decidemeter/meterwrong");
            meter[4] = Content.Load<Texture2D>("decidemeter/meterlose");

            meterrect = new Rectangle(0,350,256,256);
        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
          
        }

        public void Draw(SpriteBatch spriteBatch)
        {


            if (status == MeterStatus.win)
            {
                spriteBatch.Draw(meter[0], meterrect, Color.White);
            }
            else if (status == MeterStatus.right)
            {
                spriteBatch.Draw(meter[1], meterrect, Color.White);
            }
            else if (status == MeterStatus.neutral)
            {
                spriteBatch.Draw(meter[2], meterrect, Color.White);
            }
            else if (status == MeterStatus.wrong)
            {
                spriteBatch.Draw(meter[3], meterrect, Color.White);
            }
            else if (status == MeterStatus.lose)
            {
                spriteBatch.Draw(meter[4], meterrect, Color.White);
            }

            else
            {

            }

        }



        public void CloneAssign(GameTime gameTime)
        {
            if (clonestatus != status)
            {
                status = clonestatus;
            }

            else
            {

            }

        }


    }
}
